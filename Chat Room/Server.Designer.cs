namespace Chat_Room
{
    partial class Server
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
            this.Listen_btn = new System.Windows.Forms.Button();
            this.box_server_chat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listen_btn
            // 
            this.Listen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Listen_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Listen_btn.Font = new System.Drawing.Font("Rockwell Condensed", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Listen_btn.Location = new System.Drawing.Point(-28, -11);
            this.Listen_btn.Name = "Listen_btn";
            this.Listen_btn.Size = new System.Drawing.Size(284, 151);
            this.Listen_btn.TabIndex = 0;
            this.Listen_btn.Text = "👂  Listen";
            this.Listen_btn.UseVisualStyleBackColor = false;
            this.Listen_btn.Click += new System.EventHandler(this.Listen_btn_Click);
            // 
            // box_server_chat
            // 
            this.box_server_chat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box_server_chat.Location = new System.Drawing.Point(253, 5);
            this.box_server_chat.Name = "box_server_chat";
            this.box_server_chat.Size = new System.Drawing.Size(761, 624);
            this.box_server_chat.TabIndex = 1;
            this.box_server_chat.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Listen_btn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 143);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 627);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 337);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Location = new System.Drawing.Point(3, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 143);
            this.panel2.TabIndex = 3;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Rockwell Condensed", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.Location = new System.Drawing.Point(-28, 21);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(284, 137);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "❌  Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 636);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.box_server_chat);
            this.Name = "Server";
            this.Text = "Chat Server";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listen_btn;
        private System.Windows.Forms.RichTextBox box_server_chat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel3;
    }
}

