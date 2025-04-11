using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class Menu: Form
    {
        bool slidebarExpand;

        public Menu()
        {
            InitializeComponent();
        }

        private void server_btn_Click(object sender, EventArgs e)
        {
            Server server_Form = new Server();
            server_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client_Form = new Client();
            client_Form.Show();
        }

        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slidebarContainer.Width -= 10;
                panelHead.Width += 10;
                if (slidebarContainer.Width == slidebarContainer.MinimumSize.Width)
                {
                    slidebarTimer.Stop();
                    slidebarExpand = false;
                } 
            }
            else
            {
                slidebarContainer.Width += 10;
                panelHead.Width -= 10;
                if (slidebarContainer.Width == slidebarContainer.MaximumSize.Width)
                {
                    slidebarTimer.Stop();
                    slidebarExpand = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
