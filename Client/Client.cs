using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            
        }


        //Properties
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }

        }
     
        //Ngắt kết nối khi thoát
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           //Gửi thông báo đã thoát đến server
            client.Send(Serialize(this.UserName+ " Quit")); 
            Close();
        }


        IPEndPoint IP;
        Socket client;

        //Kết nối server
        void Connect()
        {
            
            // IP là địa chỉ server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3333);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            
            try
            {
                client.Connect(IP);
            }
            catch
            {
                
                MessageBox.Show("Không thể kết nối với server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                return;
               
                
            }

            
            Thread listen = new Thread(MyReceive);
            listen.IsBackground = true;
            listen.Start();
            
            
        }

        //Ngắt kết nối
        void Close()
        {
            client.Close();
        }

        //Gửi
        void MySend() //Hàm Send tự tạo
        {
            if (textMessage.Text != string.Empty)
            {
                string s = this.UserName+ " : " + textMessage.Text;
                client.Send(Serialize(s)); //Đây là hàm Send có sẵn
               
            }
        }

        //Nhận
        void MyReceive() // Hàm Receive tự tạo
        {
            try
            {
                
                while (true)
                {
                    byte[] data = new byte[1024 * 5];
                    client.Receive(data);//Hàm Receive có sẵn
                    
                    string mess = Deserialize(data).ToString();
               
                        AddMessageReceive(mess);

                }
            }
            catch
            {
                Close();

            }
        }

        //Hiện tin nhắn lên khung chat
        void AddMessageSend(string s)
        {
            string temp = this.UserName+ " : " + s;
            listMessage.Items.Add(temp);
            textMessage.Clear();
        }
        void AddMessageReceive(string s)
        {
           
            listMessage.Items.Add(s);
            textMessage.Clear();
        }


        //Phân mảnh
        byte[] Serialize(string str)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, str); // Hàm Serialize có sẵn khác với hàm tự tạo
            return stream.ToArray();

            //Giải thích:  hàm này phân tích biến str theo kiểu binary rồi gán vào stream, hàm Serialize  
            //có sẵn sẽ phân mảnh rồi trả về kiểu mảng
        }

        //Gom mảnh
        string Deserialize(byte[] arr)
        {
            MemoryStream stream = new MemoryStream(arr);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream).ToString(); // Hàm Deserialize có sẵn khác với hàm tự tạo

        }
       
        //Thực hiện gửi khi ấn button Send
        
        private void buttonSend_Click(object sender, EventArgs e)
        {
            MySend();
            AddMessageSend(textMessage.Text);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            //Hiện tên
            label2.Text = this.UserName;
            //Gửi thông báo đã kết nối với server
            client.Send(Serialize(this.UserName)); 
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.ForeColor = colorDialog.Color;
                textMessage.ForeColor = colorDialog.Color;
            }  
        }

        private void bFont_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.Font = fontDialog.Font;
                textMessage.Font = fontDialog.Font;
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.BackColor = colorDialog.Color;
            }  
        }

       
    }
}
