using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace Chat_Room
{
    public partial class Client: Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string username;

        public Client()
        {
            InitializeComponent();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please login first.");
                return;
            }

            string message = box_message_client.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                // Gửi đúng định dạng mà server yêu cầu
                string fullMessage = $"MESSAGE|{message}|{username}";
                SendMessage(fullMessage);
                box_message_client.Clear();

                // Tùy chọn: hiển thị tin nhắn của chính mình (vì server không broadcast lại cho sender)
                UpdateChat($"{username}: {message}");
            }
            else
            {
                MessageBox.Show("Please enter your message");
            }
        }


        private void ReceiveMessage()
        {
            byte[] buffer = new byte[1024];
            int byte_Count;

            try
            {
                while ((byte_Count = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, byte_Count);
                    HandleServerMessage(message);
                }
            }
            catch (Exception)
            {
                UpdateChat("⚠️ Disconnected from server.");
            }
        }

        private void HandleServerMessage(string message)
        {
            if (message == "LOGIN_SUCCESS")
            {
                UpdateChat("✅ Login successful.");
            }
            else if (message == "LOGIN_FAILED")
            {
                UpdateChat("❌ Login failed. Please check username or password.");
            }
            else if (message == "REGISTER_SUCCESS")
            {
                UpdateChat("✅ Registration successful.");
            }
            else if (message == "REGISTER_FAILED")
            {
                UpdateChat("❌ Registration failed. Username may already exist.");
            }
            else if (message.StartsWith("ROOM_CREATED|"))
            {
                string roomId = message.Split('|')[1];
                UpdateChat($"✅ Room created successfully! Room ID: {roomId}");
            }
            else if (message == "JOIN_ROOM_SUCCESS")
            {
                UpdateChat("✅ Successfully joined the room.");
            }
            else if (message == "JOIN_ROOM_FAILED")
            {
                UpdateChat("❌ Failed to join the room. Please check Room ID.");
            }
            else
            {
                UpdateChat(message);
            }
        }

        private void UpdateChat(string message)
        {
            if (box_client_chat.InvokeRequired)
            {
                box_client_chat.Invoke(new MethodInvoker(delegate
                {
                    box_client_chat.Text += $"{message}\r\n";
                }));
            }
            else
            {
                box_client_chat.Text += $"{message}\r\n";
            }
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            username = box_username.Text.Trim();
            string password = box_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password");
                return;
            }

            ConnectToServer();
            SendMessage($"LOGIN|{username}|{password}");
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            username = box_username.Text.Trim();
            string password = box_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password");
                return;
            }

            ConnectToServer();
            SendMessage($"REGISTER|{username}|{password}");
        }

        private void ConnectToServer()
        {
            if (client == null || !client.Connected)
            {
                try
                {
                    client = new TcpClient("127.0.0.1", 9999);
                    stream = client.GetStream();
                    Thread receive_Thread = new Thread(ReceiveMessage);
                    receive_Thread.IsBackground = true;
                    receive_Thread.Start();
                } 
                catch
                {
                    MessageBox.Show("❌ Failed to connect to server. Please check if the server is running.");
                    return;
                }
            }
        }

        private void SendMessage(string message) 
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                UpdateChat("⚠️ Error sending message: " + ex.Message);
            }
        }

        private void btncreateRoom__Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please login first!");
                return;
            }
            SendMessage($"CREATE_ROOM|{username}");
        }

        private void joinRoom_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please login first!");
                return;
            }

            string roomId = box_roomID.Text.Trim();
            if (!string.IsNullOrEmpty(roomId))
            {
                SendMessage($"JOIN_ROOM|{roomId}|{username}");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Client.ActiveForm.Close();
        }
    }
}
