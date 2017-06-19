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
namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }


        private string[] ListUser = new string[100]; //Danh sách client
        private int n = 0; // số client
        //Ngắt kết nối
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> ListClient;
        //Kết nối server
        //Nhan ten
       
        void Connect()
        {

            //Thông báo khi có client connect

            ListClient = new List<Socket>();
            // IP là địa chỉ server
            IP = new IPEndPoint(IPAddress.Any, 3333);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);
            // Server đợi kết nối với các client 
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {

                        server.Listen(100);
                        Socket client = server.Accept();

                        ListClient.Add(client);

                        Thread receive = new Thread(UpdateNewUser);
                        receive.IsBackground = true;
                        receive.Start(client);
                        
                        receive = new Thread(MyReceive);
                        receive.IsBackground = true;
                        receive.Start(client);
                      
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 3333);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }
            });
            Listen.IsBackground = true;
            Listen.Start();
           

        }

        //Ngắt kết nối
        void Close()
        {
            server.Close();
        }

        //Gửi
        void MySend(Socket client) //Hàm Send tự tạo
        {
            string temp = "Server : " + textMessage.Text;
            if (client != null && textMessage.Text != string.Empty)
                client.Send(Serialize(temp)); //Đây là hàm Send có sẵn
        }
      
        //Hàm hiển thị thông báo và lưu tên khi có client mới kết nối
        void UpdateNewUser(object obj)
        {
            //Nhận thông tin về client mới kết nối
            Socket client = obj as Socket;
            byte[] data = new byte[1024 * 5];
            client.Receive(data);//Hàm Receive có sẵn

            string mess = Deserialize(data).ToString();
           
            //Hiện thông báo 
            listNoti.Items.Add(mess+" đã kết nối");
            //Hiện người có trong phòng
            listRoom.Items.Add(mess);
            //Lưu tên người mới
            ListUser[n] = mess;
            n++;
        }
        //Nhận
        void MyReceive(object obj) // Hàm Receive tự tạo
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5];
                    client.Receive(data);//Hàm Receive có sẵn

                    string mess = Deserialize(data).ToString();

                    bool flag = false;
                    //Kiểm tra điều kiện và thông báo có client đã thoát
                    for (int i = 0; i < n; i++)
                        if (mess == ListUser[i] + " Quit")
                        {
                            listNoti.Items.Add(ListUser[i] + " đã thoát");
                            flag = true;
                           
                            ListUser[i] = null; // xóa client
                           
                            //Cập nhật lại danh sách room
                            listRoom.Items.Clear();
                            for (int j = 0; j < n; j++)
                                if (ListUser[j] != null)
                                    listRoom.Items.Add(ListUser[j]);
                            break;

                        }

                    //Nhận tin từ 1 client và gửi cho tất cả các client khác xem
                    if (flag == false)
                    {
                       
                      
                            foreach (Socket item in ListClient)
                            {
                                if (item != null && item != client)
                                    item.Send(Serialize(mess));
                            }
                            //Hiện tin nhắn lên màn hình
                            AddMessage(mess);
                    }  
                }
            }
            catch
            {
                //Ngắt kết nối client
                ListClient.Remove(client);
                client.Close();

            }
        }

        //Hiện tin nhắn lên khung chat
        void AddMessage(string s)
        {
            listMessage.Items.Add( s );
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

        
        // Gửi tin khi nhấn gửi
        private void buttonSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in ListClient)
            {
                MySend(item);
            }
            string s = "Server : " + textMessage.Text;
            AddMessage(s);
            textMessage.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                  listMessage.BackColor = colorDialog.Color;
            }  
        }

        private void cbColor_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.ForeColor = colorDialog.Color;
                textMessage.ForeColor = colorDialog.Color;
            }  
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.Font = fontDialog.Font;
                textMessage.Font = fontDialog.Font;
            }  
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}
