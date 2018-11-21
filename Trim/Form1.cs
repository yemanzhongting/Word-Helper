using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Web;
using System.Text.RegularExpressions;
using System.Net;

namespace Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // richTextBox1.BackColor = Color.Green;
        }

        private void 转化_Click(object sender, EventArgs e)
        {
            string strWrite = string.Empty;
            string strRead = richTextBox1.Text;
            CharEnumerator CEnumerator = strRead.GetEnumerator();

            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.ASCIIEncoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    strWrite += CEnumerator.Current.ToString();
                }
            }
            richTextBox2.Text = strWrite;
            //Console 输出字符串
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strWrite = string.Empty;
            string strRead = richTextBox1.Text;
            CharEnumerator CEnumerator = strRead.GetEnumerator();

            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.ASCIIEncoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    strWrite += CEnumerator.Current.ToString();
                }
            }
            //Console 输出字符串
            string l_strResult = strWrite.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
            richTextBox2.Text = l_strResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 转化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strWrite = string.Empty;
            string strRead = richTextBox1.Text;
            CharEnumerator CEnumerator = strRead.GetEnumerator();

            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.ASCIIEncoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    strWrite += CEnumerator.Current.ToString();
                }
            }
            richTextBox2.Text = strWrite;
            //richTextBox2.Copy();
            //richTextBox2.Paste();

        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "";
                openFileDialog1.ShowDialog();
                //textBox1.Text = openFileDialog1.FileName;
                StreamReader sreader = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                //openFileDialog1.
                // if (Directory.Exists(openFileDialog1.FileName))
                // {                    
                richTextBox1.Text = sreader.ReadToEnd();
                sreader.Close();
                // }
                //  else
                //  {
                //      MessageBox.Show("输入文件名不能为空");
                //}
            }
            catch (FormatException)
            {
                return;
            }

        }

        private void 保存文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string character = richTextBox2.Text;
            StreamWriter myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myStream = new StreamWriter(saveFileDialog1.FileName);
                myStream.Write(richTextBox2.Text);
                // Code to write the stream goes here.
                myStream.Close();
            }
        }

        private void 清空所有文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void 复制结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("孬孬提示：没有要粘贴的内容!");
            }
            else
            Clipboard.SetText(richTextBox2.Text);
        }

        private void 符号处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strWrite = string.Empty;
            string strRead = richTextBox1.Text;
            CharEnumerator CEnumerator = strRead.GetEnumerator();

            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.ASCIIEncoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    strWrite += CEnumerator.Current.ToString();
                }
            }
            //Console 输出字符串
            string l_strResult = strWrite.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "").Replace(".", "。").Replace(",", "，");

            richTextBox2.Text = l_strResult;
            //richTextBox2.Copy();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("别点啦");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text.Trim();
            string tb2 = textBox2.Text.Trim();
            if (tb1 == null | richTextBox2.Text == null)
            {
                MessageBox.Show("输入有误");
            }
            else
            {
                richTextBox2.Text = richTextBox1.Text.Replace(tb1, tb2);
            }
        }

        private void 英文翻译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox2.Clear();
            richTextBox2.Text = Translate.translation(richTextBox1.Text);
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化 
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏 
                notifyIcon1.Visible = true;  //托盘图标可见 ，其中binzhounotifyIcon为上述notifyicon控件的ID
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;  //显示在系统任务栏 
                this.WindowState = FormWindowState.Normal;  //还原窗体 
                notifyIcon1.Visible = false;  //托盘图标隐藏 
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("喵喵张撰写"+"\n"+"yemanzhongting@163.com,欢迎交流！", "帮助");
        }

        private void unicode转中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            richTextBox2.Text = Regex.Unescape(str);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 生成百度云分享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // https://pan.baidu.com/s/1pJxC0g7
            //"file_list":null,"uk":2906476217,"task_key":null

            string url = richTextBox1.Text;
            //https://pan.baidu.com/share/home?uk=2533571399&view=share#category/type=0
            //string id = (richTextBox1.Text);//Convert.ToInt32;

            Uri uri = new Uri(url);
            WebRequest myReq = WebRequest.Create(uri);
            WebResponse result = myReq.GetResponse();
            Stream receviceStream = result.GetResponseStream();
            StreamReader readerOfStream = new StreamReader(receviceStream, System.Text.Encoding.GetEncoding("utf-8"));
            string strHTML = readerOfStream.ReadToEnd();
            readerOfStream.Close();
            receviceStream.Close();
            result.Close();
            // return strHTML;
            

            MatchCollection mc = Regex.Matches(strHTML, @"\d{10}");
            url = "https://pan.baidu.com/share/home?uk=" + mc[0] + "&view = share#category/type=0";
            richTextBox2.Text = url;
            //foreach (Match m in mc)
            //{
            //    Console.WriteLine(m.Value);
            //}
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("喵喵张撰写" + "\n" + "yemanzhongting@163.com,欢迎交流！", "帮助");
        }

        private void uRLdecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;           
            richTextBox2.Text= HttpUtility.UrlEncode(text);  //utf-8 编码
            //HttpUtility.UrlDecode(text);  //utf-8 解码
            //HttpUtility.UrlEncode(text, System.Text.Encoding.GetEncoding(936));  //gb2312编码
            //HttpUtility.UrlDecode(text, System.Text.Encoding.GetEncoding(936));  //gb2312解码
        }

        private void uRL解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            richTextBox2.Text = HttpUtility.UrlDecode(text);  //utf-8 解码
        }

        //        第一部分：http://api.fanyi.baidu.com/api/trans/vip/translate

        //第二部分：q(请求翻译的内容)

        //第三部分：from(翻译源语言)

        //第四部分：to(译文语言)

        //第五部分：appid(申请的接口返回的APP ID)

        //第六部分：salt=1435660288(这个加盐貌似是固定的值)

        //第七部分：sign(签名,这个签名是根据前面appid,q,salt和密钥的值拼起来用md5加密后的值)

        //例子(以中文转英文为例)：

        //q=苹果,from=zh,to=en,appid=你的appid,salt=1435660288

        //private static System.Threading.Mutex mutex;
        //[STAThread]
        //static void M()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    mutex = new System.Threading.Mutex(true, "OnlyRun");
        //    if (mutex.WaitOne(0, false))
        //    {
        //        Application.Run(new Form());
        //    }
        //    else
        //    {
        //        MessageBox.Show("程序已经在运行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        Application.Exit();
        //    }
        // }
    }
}
