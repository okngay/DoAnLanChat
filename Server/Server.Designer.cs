namespace Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.textMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.listNoti = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.bFont = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textMessage.Location = new System.Drawing.Point(215, 394);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(483, 42);
            this.textMessage.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listRoom);
            this.panel2.Controls.Add(this.listNoti);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 465);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOTIFICATIONS";
            // 
            // listRoom
            // 
            this.listRoom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listRoom.FormattingEnabled = true;
            this.listRoom.Location = new System.Drawing.Point(3, 262);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(191, 199);
            this.listRoom.TabIndex = 25;
            // 
            // listNoti
            // 
            this.listNoti.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listNoti.FormattingEnabled = true;
            this.listNoti.Location = new System.Drawing.Point(3, 30);
            this.listNoti.Name = "listNoti";
            this.listNoti.Size = new System.Drawing.Size(191, 186);
            this.listNoti.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ROOM";
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(215, 12);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(530, 342);
            this.listMessage.TabIndex = 22;
            // 
            // buttonSend
            // 
            this.buttonSend.Image = global::Server.Properties.Resources.send;
            this.buttonSend.Location = new System.Drawing.Point(698, 404);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(41, 23);
            this.buttonSend.TabIndex = 18;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // bFont
            // 
            this.bFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFont.Image = global::Server.Properties.Resources.z_file_font;
            this.bFont.Location = new System.Drawing.Point(251, 364);
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(27, 28);
            this.bFont.TabIndex = 30;
            this.bFont.UseVisualStyleBackColor = true;
            this.bFont.Click += new System.EventHandler(this.button6_Click);
            // 
            // bColor
            // 
            this.bColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColor.Image = global::Server.Properties.Resources.color_line;
            this.bColor.Location = new System.Drawing.Point(218, 364);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(27, 28);
            this.bColor.TabIndex = 27;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.cbColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Server.Properties.Resources.icons;
            this.button2.Location = new System.Drawing.Point(284, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 28);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Server.Properties.Resources.pin_black__1_;
            this.button5.Location = new System.Drawing.Point(320, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 39);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Server.Properties.Resources.toolbar_pictures;
            this.button4.Location = new System.Drawing.Point(266, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 39);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Server.Properties.Resources.pin;
            this.button3.Location = new System.Drawing.Point(215, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 39);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Server.Properties.Resources._32_19;
            this.button1.Location = new System.Drawing.Point(372, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 39);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Server
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 518);
            this.Controls.Add(this.bFont);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.ListBox listNoti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button bFont;

    }
}

