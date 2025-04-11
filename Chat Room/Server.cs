using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_Room
{
    public partial class Server : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isAlive = false;

        private Dictionary<string, TcpClient> loggedInUsers = new Dictionary<string, TcpClient>();
        private List<string> users = new List<string>(); // Đã đăng ký
        private Dictionary<string, List<TcpClient>> chatRooms = new Dictionary<string, List<TcpClient>>();
        private Dictionary<TcpClient, string> clientRooms = new Dictionary<TcpClient, string>();

        public Server()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void Listen_btn_Click(object sender, EventArgs e)
        {
            Thread server_Thread = new Thread(StartServer);
            server_Thread.IsBackground = true;
            server_Thread.Start();
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 9999);
                server.Start();
                isAlive = true;
                UpdateLog("🔵 Server is running on port 9999...");

                while (isAlive)
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);

                    Thread client_Thread = new Thread(HandleClient);
                    client_Thread.IsBackground = true;
                    client_Thread.Start(client);
                }
            }
            catch (Exception ex)
            {
                UpdateLog("❌ Error: " + ex.Message);
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytes_Count;

            try
            {
                while ((bytes_Count = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytes_Count);
                    string[] parts = message.Split('|');

                    if (parts[0] == "LOGIN")
                    {
                        bool success = Login(parts[1], parts[2]);
                        SendMessage(client, success ? "LOGIN_SUCCESS" : "LOGIN_FAILED");
                        UpdateLog($"🔵 {parts[1]} has login");

                        if (success)
                        {
                            loggedInUsers[parts[1]] = client;
                        }
                    }
                    else if (parts[0] == "REGISTER")
                    {
                        bool success = Register(parts[1], parts[2]);
                        SendMessage(client, success ? "REGISTER_SUCCESS" : "REGISTER_FAILED");
                        UpdateLog($"📝 {parts[1]} has registered");
                    }
                    else if (parts[0] == "CREATE_ROOM")
                    {
                        string roomId = Guid.NewGuid().ToString().Substring(0, 6).ToUpper();
                        chatRooms[roomId] = new List<TcpClient> { client };
                        clientRooms[client] = roomId;
                        SendMessage(client, $"ROOM_CREATED|{roomId}");
                        UpdateLog($"🔧 {parts[1]} created room {roomId}");
                    }
                    else if (parts[0] == "JOIN_ROOM")
                    {
                        string roomId = parts[1];
                        string user = parts[2];

                        if (chatRooms.ContainsKey(roomId))
                        {
                            if (!chatRooms[roomId].Contains(client))
                                chatRooms[roomId].Add(client);

                            clientRooms[client] = roomId;
                            SendMessage(client, "JOIN_ROOM_SUCCESS");
                            BroadcastToRoom(roomId, $"🔵 {user} has joined room {roomId}", client);
                            UpdateLog($"🔵 {user} joined room {roomId}");
                        }
                        else
                        {
                            SendMessage(client, "JOIN_ROOM_FAILED");
                        }
                    }
                    else if (parts[0] == "MESSAGE")
                    {
                        string content = parts[1];
                        string senderName = parts[2];

                        if (clientRooms.ContainsKey(client))
                        {
                            string roomId = clientRooms[client];
                            BroadcastToRoom(roomId, $"{senderName}: {content}", client);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateLog("⚠️ Client disconnected: " + ex.Message);
            }
            finally
            {
                RemoveClient(client);
            }
        }

        private void BroadcastToRoom(string roomId, string message, TcpClient sender)
        {
            if (!chatRooms.ContainsKey(roomId)) return;

            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (TcpClient client in chatRooms[roomId])
            {
                if (client != sender)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    catch
                    {
                        // Ignore client that has been closed
                    }
                }
            }
        }

        private void SendMessage(TcpClient client, string message)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
            catch { }
        }

        private void UpdateLog(string message)
        {
            if (box_server_chat.InvokeRequired)
            {
                box_server_chat.Invoke(new MethodInvoker(delegate
                {
                    box_server_chat.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                box_server_chat.AppendText(message + Environment.NewLine);
            }
        }

        private bool Register(string username, string password)
        {
            if (users.Any(u => u.StartsWith(username + ":"))) return false;

            users.Add(username + ":" + password);
            File.WriteAllLines("users.txt", users);
            return true;
        }

        private bool Login(string username, string password)
        {
            return users.Contains(username + ":" + password);
        }

        private void LoadUsers()
        {
            if (File.Exists("users.txt"))
                users = File.ReadAllLines("users.txt").ToList();
        }

        private void RemoveClient(TcpClient client)
        {
            if (clientRooms.ContainsKey(client))
            {
                string roomId = clientRooms[client];
                chatRooms[roomId].Remove(client);

                BroadcastToRoom(roomId, "🔴 A user has left the room.", client);

                if (chatRooms[roomId].Count == 0)
                {
                    chatRooms.Remove(roomId);
                    UpdateLog($"⚠️ Room {roomId} removed (empty).");
                }

                clientRooms.Remove(client);
            }

            clients.Remove(client);
            client.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Server.ActiveForm.Close();
        }
    }
}
