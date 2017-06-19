namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonSend = new System.Windows.Forms.Button();
            this.bFont = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textMessage.Location = new System.Drawing.Point(12, 442);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(483, 42);
            this.textMessage.TabIndex = 26;
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(12, 60);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(524, 342);
            this.listMessage.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên hiển thị: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(105, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonSend
            // 
            this.buttonSend.Image = global::Client.Properties.Resources.send;
            this.buttonSend.Location = new System.Drawing.Point(495, 452);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(41, 23);
            this.buttonSend.TabIndex = 28;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // bFont
            // 
            this.bFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFont.Image = global::Client.Properties.Resources.z_file_font;
            this.bFont.Location = new System.Drawing.Point(45, 408);
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(27, 28);
            this.bFont.TabIndex = 37;
            this.bFont.UseVisualStyleBackColor = true;
            this.bFont.Click += new System.EventHandler(this.bFont_Click);
            // 
            // bColor
            // 
            this.bColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColor.Image = global::Client.Properties.Resources.color_line;
            this.bColor.Location = new System.Drawing.Point(12, 408);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(27, 28);
            this.bColor.TabIndex = 36;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Client.Properties.Resources.icons;
            this.button2.Location = new System.Drawing.Point(78, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 28);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Client.Properties.Resources.pin_black__1_;
            this.button5.Location = new System.Drawing.Point(110, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 39);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Client.Properties.Resources.pin;
            this.button3.Location = new System.Drawing.Point(12, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 39);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Client.Properties.Resources._32_19;
            this.button1.Location = new System.Drawing.Point(162, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 39);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Image = global::Client.Properties.Resources.toolbar_pictures;
            this.button4.Location = new System.Drawing.Point(59, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 39);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 542);
            this.Controls.Add(this.bFont);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bFont;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button button2;

    }
}

