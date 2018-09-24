using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuixiangzi0
{
    public partial class Form1 : Form
    {
        private string FileName = string.Empty;
        private int Level = 1;
        private string[] txt;
        private string[] txt_n;
        private int[,] myArray;
        private int[,,] myArray_old;
        private int[,] myArray_old1; //recover用的临时数据
        private int i, j;
        private int seq = -1;
        private int row_num=0, col_num=0;
        internal int flag_last = 0;
        public int row_start = 0, row_end = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void reload_map()
        {
            Form1_Load(null, null);
        }
        public int[,] ReadMap(string[] txt)  //将text file里的第n关map数据写入一个integer array中
        {
            string[] array0 = txt[0].Split(',');
            col_num = array0.Length;
            var array = new string[row_num, col_num];
            for (int i = 0; i < row_num; i++)
            {
                string[] arrayi = txt[i].Split(',');
                for (int j = 0; j < col_num; j++)
                {
                    array.SetValue(arrayi[j], i, j);
                }
            }

            int[,] array1 = new int[row_num,col_num];
            for (int i=0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    int.TryParse(array[i,j], result: out array1[i,j]);
                }
            }
            //初始化存储撤销数据的数组
            myArray_old = new int[500, row_num, col_num];

            return array1;
        }
        public string[] ExtractLines(string[] txt, int n)
        {
            string array_s = "//";

            //获取开始和结束行
            int num_slash = 0;
            row_start = 0; row_end = 0;

            for (int row = 0; row < txt.Length;row++)
            {
                if (txt[row].Contains(array_s))
                {
                    num_slash++;
                    if (num_slash == n)
                    {
                        row_start = row+1;
                    }
                    if (num_slash == n+1)
                    {
                        row_end = row;
                    }
                }
            }
            //判断是否为最后一关
            if(row_end==0)
            {
                row_end = txt.Length;
                flag_last = 1;
            }

            row_num = row_end - row_start;
            //为新的array赋值
            txt_n = new string[row_num];
            for (int i = 0; i < row_num; i++)
            {
                txt_n[i]=string.Copy(txt[row_start + i]);
            }

            return txt_n;
        }

        //0 空地，1 墙， 3 箱子， 4 箱子目的地， 6 人， 7 箱子与目的地重合， 9 人与目的地重合
        public Bitmap DrawMap(int[,]myArray)
        {
            pictureBox1.Width = myArray.GetLength(1)*30;
            pictureBox1.Height = myArray.GetLength(0)*30;
            Bitmap bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bit);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Image image = new Bitmap("worker.png");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (myArray[i, j] == 1)
                    {
                        image = new Bitmap("wall.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                    if (myArray[i, j] == 6)
                    {
                        image = new Bitmap("worker.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                    if (myArray[i, j] == 3)
                    {
                        image = new Bitmap("box.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                    if (myArray[i, j] == 0)
                    {
                        image = new Bitmap("land.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                    if (myArray[i, j] == 4)
                    {
                        image = new Bitmap("dest.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                    if (myArray[i, j] == 9)
                    {
                        image = new Bitmap("WoD.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                    if (myArray[i, j] == 7)
                    {
                        image = new Bitmap("BoD.png");
                        g.DrawImage(image, j * 30, i * 30, 30, 30);
                    }
                }
            }
            return bit;
        }
        public void init_data()
        {
            txtLeveln.Text = Level.ToString();
            txt_n = ExtractLines(txt, Level);
            myArray = ReadMap(txt_n);
            pictureBox1.Image = DrawMap(myArray);
            seq = -1;
            撤销ToolStripMenuItem.Enabled = false;
        }
        private void undo_data()
        {
            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    myArray_old[seq, i, j] = myArray[i, j];
                }
            }
        }
        private bool isfinish()
        {
            bool bfinish = true;
            for (int i = 0; i < row_num; i++)
                for (int j = 0; j < col_num; j++)
                    if (myArray[i, j] == 4
                        || myArray[i, j] == 9)
                        bfinish = false;
            return bfinish;
        }
        private void btnUndo_Click(object sender, EventArgs e) //撤销
        {
            myArray_old1 = new int[row_num, col_num];
            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    myArray_old1[i, j] = myArray_old[seq, i, j];
                }
            }
            pictureBox1.Image = DrawMap(myArray_old1);
            Array.Copy(myArray_old1, myArray, myArray.Length);
            seq--;
            if (seq < 0) { 撤销ToolStripMenuItem.Enabled = false; }
        }

        private void btnRestart_Click(object sender, EventArgs e) //重新开始本关
        {
            init_data();
        }

        private void btnNextLevel_Click(object sender, EventArgs e) //下一关
        {
            Level++;
            //判断是否有下一关
            if (flag_last==1)
            {
                MessageBox.Show("没有下一关了", "提醒");
                Level--;
                return;
            }
            init_data();
        }

        private void btnExit_Click(object sender, EventArgs e) //退出程序
        {
            Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            FileName = ".\\map\\configurations.txt";
            txt = File.ReadAllLines(FileName);
            init_data();
            Level_selection();
        }
        private void Level_selection()
        {
            //清除原本数据
            int levels = 关卡选择toolStripMenuItem.DropDownItems.Count;
            if (levels > 0)
            {
                for (int j = 0; j < levels; j++)
                {
                    关卡选择toolStripMenuItem.DropDownItems.RemoveAt(0);
                }
            }
            int Total_n = count_level(txt);
            for (i = 1; i <= Total_n; i++)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Name = "tsm" + i.ToString();
                tsmi.Text = i.ToString();
                关卡选择toolStripMenuItem.DropDownItems.Add(tsmi);
                tsmi.Click += new EventHandler(MenuClicked);
            }
        }
        private void MenuClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            Level = int.Parse(tsmi.Text);
            init_data();
        }
        private int count_level(string[] txt)
        {
            string array_s = "//";
            int n = 0;
            for (int row = 0; row < txt.Length; row++)
            {
                if (txt[row].Contains(array_s))
                {
                    n++;
                }
            }
            return n;
        }
        private void Keydown(object sender, KeyEventArgs e) //按下按键时操作
        {
            label2.Text = "";
            //得到人的坐标
            for (int x = 0; x < row_num; x++)
            {
                for (int y = 0; y < col_num; y++)
                {
                    if (myArray[x, y] == 6 || myArray[x, y] == 9)
                    {
                        i = x;
                        j = y;
                    }
                }
                
            }
            //存储撤销所需的数据，执行撤销快捷键
            if (e.KeyCode != Keys.C)
            {
                seq++;
                undo_data();
                撤销ToolStripMenuItem.Enabled = true;
            }
            else if (e.KeyCode == Keys.C && 撤销ToolStripMenuItem.Enabled == true)
            {
                btnUndo_Click(null, null);
            }
            //接收按键
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (myArray[i - 1, j] == 0)
                    {
                        myArray[i - 1, j] = 6;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i - 1, j] == 3 && myArray[i - 2, j] == 0)
                    {
                        myArray[i - 1, j] = 6;
                        myArray[i - 2, j] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i - 1, j] == 4)
                    {
                        myArray[i - 1, j] = 9;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i - 1, j] == 7 && myArray[i - 2, j] == 0)
                    {
                        myArray[i - 1, j] = 9;
                        myArray[i - 2, j] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }

                    }
                    else if (myArray[i - 1, j] == 3 && myArray[i - 2, j] == 4)
                    {
                        myArray[i - 1, j] = 6;
                        myArray[i - 2, j] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i - 1, j] == 7 && myArray[i - 2, j] == 4)
                    {
                        myArray[i - 1, j] = 9;
                        myArray[i - 2, j] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else label2.Text="无效操作";
                    break;
                case Keys.Left:
                    if (myArray[i, j - 1] == 0)
                    {
                        myArray[i, j - 1] = 6;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j - 1] == 3 && myArray[i, j - 2] == 0)
                    {
                        myArray[i, j - 1] = 6;
                        myArray[i, j - 2] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j - 1] == 4)
                    {
                        myArray[i, j - 1] = 9;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j - 1] == 7 && myArray[i, j - 2] == 0)
                    {
                        myArray[i, j - 1] = 9;
                        myArray[i, j - 2] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }

                    }
                    else if (myArray[i, j - 1] == 3 && myArray[i, j - 2] == 4)
                    {
                        myArray[i, j - 1] = 6;
                        myArray[i, j - 2] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j - 1] == 7 && myArray[i, j - 2] == 4)
                    {
                        myArray[i, j - 1] = 9;
                        myArray[i, j - 2] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else label2.Text = "无效操作";
                    break;
                case Keys.Down:
                    if (myArray[i + 1, j] == 0)
                    {
                        myArray[i + 1, j] = 6;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i + 1, j] == 3 && myArray[i + 2, j] == 0)
                    {
                        myArray[i + 1, j] = 6;
                        myArray[i + 2, j] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i + 1, j] == 4)
                    {
                        myArray[i + 1, j] = 9;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i + 1, j] == 7 && myArray[i + 2, j] == 0)
                    {
                        myArray[i + 1, j] = 9;
                        myArray[i + 2, j] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }

                    }
                    else if (myArray[i + 1, j] == 3 && myArray[i + 2, j] == 4)
                    {
                        myArray[i + 1, j] = 6;
                        myArray[i + 2, j] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i + 1, j] == 7 && myArray[i + 2, j] == 4)
                    {
                        myArray[i + 1, j] = 9;
                        myArray[i + 2, j] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else label2.Text = "无效操作";
                    break;
                case Keys.Right:
                    if (myArray[i, j + 1] == 0)
                    {
                        myArray[i, j + 1] = 6;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j + 1] == 3 && myArray[i, j + 2] == 0)
                    {
                        myArray[i, j + 1] = 6;
                        myArray[i, j + 2] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j + 1] == 4)
                    {
                        myArray[i, j + 1] = 9;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j + 1] == 7 && myArray[i, j + 2] == 0)
                    {
                        myArray[i, j + 1] = 9;
                        myArray[i, j + 2] = 3;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }

                    }
                    else if (myArray[i, j + 1] == 3 && myArray[i, j + 2] == 4)
                    {
                        myArray[i, j + 1] = 6;
                        myArray[i, j + 2] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else if (myArray[i, j + 1] == 7 && myArray[i, j + 2] == 4)
                    {
                        myArray[i, j + 1] = 9;
                        myArray[i, j + 2] = 7;
                        if (myArray[i, j] == 6)
                        {
                            myArray[i, j] = 0;
                        }
                        else
                        {
                            myArray[i, j] = 4;
                        }
                    }
                    else label2.Text = "无效操作";
                    break;
            }
            pictureBox1.Image = DrawMap(myArray);
            if (isfinish()) {
                MessageBox.Show("恭喜你顺利过关", "提示");
                btnNextLevel_Click(null, null);
                }
            return;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ClickEvent += new ClickDelegateHander(reload_map);//注册事件
            f2.ShowDialog();
        }

        private void PreviewKeydown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                e.IsInputKey = true;
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
                return false;
            else
                return base.ProcessDialogKey(keyData);
        }


    }
}
