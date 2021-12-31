using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace RandomExtract
{
    public partial class Main : Form
    {
        int[] numFlag = new int[1000];
        int[] nameFlag = new int[1000];
        int numcount = 0;
        int namecount = 0;
        string strList="";
        public Main()
        {
            InitializeComponent();
        }
        #region UI相关
        //关闭
        private void close_button_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        //最小化到任务栏
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //设置
        private void setting_button_Click(object sender, EventArgs e)
        {
            Setting fsetting = new Setting(this);
            fsetting.ShowDialog();
            Config.GetConfig();
        }

        private void main_lable_Click(object sender, EventArgs e)
        {

        }

        //移动窗口
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        private const int HT_CLIENT = 0x1;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref msg);
        }

        //鼠标移到设置按钮时显示设置
        private void setting_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.setting_button, "设置");
        }

        //鼠标移到最小化按钮时显示最小化
        private void minimize_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.minimize_button, "最小化");
        }

        //鼠标移到关闭按钮时显示关闭
        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.close_button, "关闭");
        }
        #endregion

        #region 启动
        private void Main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory+@"NameList");
            if (!Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory+@"NameList"))//判断名单路径是否存在
            {
                Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory+@"NameList");
            }
            Config.GetConfig();
            //抽号不放回型标志
            for (int i = 0; i <= 999; i++)
            {
                numFlag[i] = 0;
            }
            //点名不放回标志
            for (int i = 0; i <=999; i++)
            {
                nameFlag[i] = 0;
            }
        }
        #endregion
        private void show_image(int count)
        {
            int a = count % 4;
            if(a == 0)
            {
                pictureBox1.Image = global::RandomExtract.Properties.Resources.cat;
            }
            if (a == 1)
            {
                pictureBox1.Image = global::RandomExtract.Properties.Resources.woman;
            }
            if (a == 3)
            {
                pictureBox1.Image = global::RandomExtract.Properties.Resources.emoji1;
            }
            if (a == 2)
            {
                pictureBox1.Image = global::RandomExtract.Properties.Resources.emoji2;
            }
        }
        #region 开始抽号
        private void go_button_Click(object sender, EventArgs e)
        {
            switch (Config.Mode)
            {
                case "A1"://抽号放回型
                    for (int i = 0; i < BaseRandom.GetRandom(20, 30); i++)
                    {
                        main_lable.Text = BaseRandom.GetRandom(Config.MIN, Config.MAX+1).ToString();
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(50);
                    }
                    show_image(0);
                    break;
                case "A2"://抽号不放回型
                    if (numcount == (Config.MAX - Config.MIN + 1))
                    {
                        MessageBox.Show("所有号码已抽完，即将重置");
                        numcount = 0;
                        for (int i = 0; i <=999; i++)
                        {
                            numFlag[i] = 0;
                        }
                        strList = "";
                        choosedList.Text = strList;
                        break;
                    }
                    for (int i = 0; i <= 20; i++)
                    {
                        int num = BaseRandom.GetRandom(Config.MIN, (Config.MAX+1));
                        main_lable.Text = num.ToString();
                        Application.DoEvents();
                        if (i==20)
                        {
                            if (numcount != (Config.MAX - Config.MIN+1))
                            {
                                if (numFlag[num-1] == 1)
                                {
                                    i--;
                                }
                                else
                                {
                                    numcount++;
                                    numFlag[num-1] = 1;
                                    string tmp = strList;
                                    strList = tmp + " " + num.ToString();
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(50);
                    }
                    choosedList.Text=strList;
                    Application.DoEvents();
                    show_image(numcount);
                    break;
                case "B1"://点名放回型
                    if (Config.NameList=="")
                    {
                        break;
                    }
                    for (int i = 0; i < BaseRandom.GetRandom(20, 30); i++)
                    {
                        main_lable.Text = Config.name[BaseRandom.GetRandom(0, Config.name.Count)];
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(50);
                    }
                    show_image(0);
                    break;
                case "B2"://点名不放回型
                    if (Config.NameList == "")
                    {
                        break;
                    }
                    if (namecount == Config.name.Count)
                    {
                        MessageBox.Show("所有人已抽完，即将重置");
                        namecount = 0;
                        for (int i = 0; i <= 999; i++)
                        {
                            nameFlag[i] = 0;
                        }
                        strList = "";
                        choosedList.Text = strList;
                        break;

                    }
                    for (int i = 0; i <= 20; i++)
                    {
                        int num = BaseRandom.GetRandom(0, Config.name.Count);
                        main_lable.Text = Config.name[num];
                        Application.DoEvents();
                        if (i == 20)
                        {
                            if (numcount != Config.name.Count)
                            {
                                if (nameFlag[num] == 1)
                                {
                                    i--;
                                }
                                else
                                {
                                    namecount++;
                                    nameFlag[num] = 1;
                                    string tmp = strList;
                                    strList = tmp+" "+Config.name[num];
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(50);
                    }
                    choosedList.Text=strList;
                    Application.DoEvents();
                    show_image(namecount);
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void choosedList_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("gitLab：https://gitee.com/OWmess/rand-extract.git");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
