namespace Chat_Room
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_client_chat = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_message_client = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_username = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.box_roomID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncreateRoom_ = new System.Windows.Forms.Button();
            this.joinRoom_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_client_chat
            // 
            this.box_client_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_client_chat.Location = new System.Drawing.Point(330, 97);
            this.box_client_chat.Name = "box_client_chat";
            this.box_client_chat.Size = new System.Drawing.Size(1006, 637);
            this.box_client_chat.TabIndex = 0;
            this.box_client_chat.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(338, 756);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // box_message_client
            // 
            this.box_message_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_message_client.Location = new System.Drawing.Point(497, 750);
            this.box_message_client.Name = "box_message_client";
            this.box_message_client.Size = new System.Drawing.Size(685, 44);
            this.box_message_client.TabIndex = 4;
            // 
            // send_btn
            // 
            this.send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_btn.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.Location = new System.Drawing.Point(1203, 749);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(138, 45);
            this.send_btn.TabIndex = 5;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // box_password
            // 
            this.box_password.BackColor = System.Drawing.Color.LightGray;
            this.box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_password.Location = new System.Drawing.Point(9, 44);
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(277, 44);
            this.box_password.TabIndex = 9;
            // 
            // box_username
            // 
            this.box_username.BackColor = System.Drawing.Color.LightGray;
            this.box_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_username.Location = new System.Drawing.Point(9, 43);
            this.box_username.Name = "box_username";
            this.box_username.Size = new System.Drawing.Size(277, 44);
            this.box_username.TabIndex = 8;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(-26, -32);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(353, 90);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_btn.Location = new System.Drawing.Point(-57, 3);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(410, 81);
            this.register_btn.TabIndex = 11;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // box_roomID
            // 
            this.box_roomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_roomID.Location = new System.Drawing.Point(497, 31);
            this.box_roomID.Name = "box_roomID";
            this.box_roomID.Size = new System.Drawing.Size(545, 44);
            this.box_roomID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Room ID";
            // 
            // btncreateRoom_
            // 
            this.btncreateRoom_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btncreateRoom_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncreateRoom_.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateRoom_.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreateRoom_.Location = new System.Drawing.Point(-17, -39);
            this.btncreateRoom_.Name = "btncreateRoom_";
            this.btncreateRoom_.Size = new System.Drawing.Size(333, 105);
            this.btncreateRoom_.TabIndex = 14;
            this.btncreateRoom_.Text = "Create Room";
            this.btncreateRoom_.UseVisualStyleBackColor = false;
            this.btncreateRoom_.Click += new System.EventHandler(this.btncreateRoom__Click);
            // 
            // joinRoom_btn
            // 
            this.joinRoom_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinRoom_btn.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinRoom_btn.Location = new System.Drawing.Point(1055, 26);
            this.joinRoom_btn.Name = "joinRoom_btn";
            this.joinRoom_btn.Size = new System.Drawing.Size(281, 53);
            this.joinRoom_btn.TabIndex = 15;
            this.joinRoom_btn.Text = "Join";
            this.joinRoom_btn.UseVisualStyleBackColor = true;
            this.joinRoom_btn.Click += new System.EventHandler(this.joinRoom_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(309, 825);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.box_username);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 110);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.box_password);
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 110);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.register_btn);
            this.panel3.Location = new System.Drawing.Point(3, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 94);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.login_btn);
            this.panel4.Location = new System.Drawing.Point(3, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 77);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.btncreateRoom_);
            this.panel5.Location = new System.Drawing.Point(3, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 110);
            this.panel5.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 534);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(389, 120);
            this.panel7.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel6.Controls.Add(this.exit_btn);
            this.panel6.Location = new System.Drawing.Point(3, 660);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 153);
            this.panel6.TabIndex = 18;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.Location = new System.Drawing.Point(-67, 49);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(396, 118);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "❌  Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 814);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.joinRoom_btn);
            this.Controls.Add(this.box_roomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.box_message_client);
            this.Controls.Add(this.box_client_chat);
            this.Name = "Client";
            this.Text = "Client";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox box_client_chat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_message_client;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_username;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox box_roomID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncreateRoom_;
        private System.Windows.Forms.Button joinRoom_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}