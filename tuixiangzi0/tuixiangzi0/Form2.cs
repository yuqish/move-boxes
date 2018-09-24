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
    public delegate void ClickDelegateHander();
    public partial class Form2 : Form
    {
        public event ClickDelegateHander ClickEvent; //声明保存后更新数据到form1
        private string FileName = string.Empty;
        private int Level = 1;
        private string[] txt;
        private string[] txt_o; //用于保存对比
        private string[] txt_n;
        internal int[,] myArray;
        private int now_select;
        private bool selection_flag = false;
        private bool human = false;
        Form1 f = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            FileName = ".\\map\\configurations.txt";
            txt = File.ReadAllLines(FileName);
            txt_o = new string[txt.Length];
            Array.Copy(txt,txt_o,txt.Length);
            init_data();
        }
        private void Level_selection()
        {
            //清除原本数据
            int levels = 关卡选择ToolStripMenuItem.DropDownItems.Count;
            if (levels > 0)
            {
                for (int j = 0; j < levels; j++)
                {
                    关卡选择ToolStripMenuItem.DropDownItems.RemoveAt(0);
                }
            }
            int Total_n = count_level(txt);
            for (int i = 1; i <= Total_n; i++)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Name = "tsm" + i.ToString();
                tsmi.Text = i.ToString();
                关卡选择ToolStripMenuItem.DropDownItems.Add(tsmi);
                tsmi.Click += new EventHandler(MenuClicked);
            }
        }
        private void MenuClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            Level = int.Parse(tsmi.Text);
            init_data();
        }
        private int count_level(string[] txt){
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

        public void init_data()
        {
            txtLeveln.Text = Level.ToString();
            txt_n = f.ExtractLines(txt, Level);
            myArray = f.ReadMap(txt_n);
            pictureBox1.Image = f.DrawMap(myArray);
            Level_selection();
            if(myArray.GetLength(0)==10 & myArray.GetLength(1) == 10)
            {
                默认10x10ToolStripMenuItem.Checked = true;
                x15ToolStripMenuItem.Checked = false;
                自定义ToolStripMenuItem.Checked = false;
            }else if(myArray.GetLength(0) == 15 & myArray.GetLength(1) == 15)
            {
                默认10x10ToolStripMenuItem.Checked = false;
                x15ToolStripMenuItem.Checked = true;
                自定义ToolStripMenuItem.Checked = false;
            }
            else {
                默认10x10ToolStripMenuItem.Checked = false;
                x15ToolStripMenuItem.Checked = false;
                自定义ToolStripMenuItem.Checked = true;
            }
        }
        private void Level_Regenerate() //更新某关数据
        {
            List<string> lines = txt.ToList<string>();
            for (int i = f.row_start; i < f.row_end; i++)
            {
                lines.RemoveAt(f.row_start); //删除第 row_start~row_end 行
            }
            string[,] array= new string [myArray.GetLength(0),myArray.GetLength(1)];
            string[] arrayi = new string[myArray.GetLength(1)];
            string[] arrays = new string[myArray.GetLength(0)];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    array[i,j]=myArray[i,j].ToString();
                    arrayi.SetValue(array[i, j], j);
                }
                arrays[i]=string.Join(",", arrayi);
            }
            for (int i = f.row_start; i < f.row_start+ myArray.GetLength(0); i++)
            {
                lines.Insert(i,arrays[i- f.row_start]); //插入新行
            }
            txt = lines.ToArray();
        }
        private void Level_New() //增加新关卡
        {
            int Total_n = count_level(txt);
            Level = Total_n + 1;
            List<string> lines = txt.ToList<string>();
            string[,] array = new string[myArray.GetLength(0), myArray.GetLength(1)];
            string[] arrayi = new string[myArray.GetLength(1)];
            string[] arrays = new string[myArray.GetLength(0)];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    array[i, j] = myArray[i, j].ToString();
                    arrayi.SetValue(array[i, j], j);
                }
                arrays[i] = string.Join(",", arrayi);
            }
            lines.Add("//");
            for(int i=0;i< myArray.GetLength(0); i++)
            {
                lines.Add(arrays[i]);
            }
            txt = lines.ToArray();
            init_data();
        }
        private void 默认10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认10x10ToolStripMenuItem.Checked = true;
            x15ToolStripMenuItem.Checked = false;
            自定义ToolStripMenuItem.Checked = false;
            myArray = new int[10, 10];
            pictureBox1.Image = f.DrawMap(myArray);
            Level_Regenerate();
        }

        private void 自定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认10x10ToolStripMenuItem.Checked = false;
            x15ToolStripMenuItem.Checked = false;
            自定义ToolStripMenuItem.Checked = true;
            Form3 f3 = new Form3();
            f3.row_num = myArray.GetLength(0);
            f3.col_num = myArray.GetLength(1);
            f3.ShowDialog();
            if (f3.flag_size == 1)
            {
                myArray = new int[f3.row_num, f3.col_num];
                pictureBox1.Image = f.DrawMap(myArray);
                Level_Regenerate();
            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array.Clear(myArray,0,myArray.Length);
            pictureBox1.Image = f.DrawMap(myArray);
            Level_Regenerate();
        }

        private void 平铺墙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i= 0; i < myArray.GetLength(0); i++)
            {
                for(int j = 0;j < myArray.GetLength(1); j++)
                {
                    myArray.SetValue(1,i,j);
                }
            }
            pictureBox1.Image = f.DrawMap(myArray);
            Level_Regenerate();
        }

        private void 删除关卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> lines = txt.ToList<string>();
            if (f.flag_last == 0)
            {
                for (int i = f.row_start; i <= f.row_end; i++)
                {
                    lines.RemoveAt(f.row_start); //删除第 row_start~row_end 行
                }
            }
            else {
                for (int i = f.row_start-1; i < f.row_end; i++)
                {
                    lines.RemoveAt(f.row_start-1); //删除第 (row_start-1)~row_end 行
                }
                Level--;
                f.flag_last = 0;
            }
            txt = lines.ToArray();
            txt_n = f.ExtractLines(txt, Level);
            init_data();
        }

        private void x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x15ToolStripMenuItem.Checked = true;
            默认10x10ToolStripMenuItem.Checked = false;
            自定义ToolStripMenuItem.Checked = false;
            myArray = new int[15, 15];
            Level_Regenerate();
            pictureBox1.Image = f.DrawMap(myArray);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否保存修改？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //执行保存
                //【1】清空
                File.WriteAllText(FileName, string.Empty);

                //【2】把全部txt写入
                File.WriteAllLines(FileName, txt);

                //【3】写入完成
                MessageBox.Show("写入完成", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //【4】更新用于比较的txt_o
                txt_o = new string[txt.Length];
                Array.Copy(txt, txt_o, txt.Length);
            }
        }

        private void 退出编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form2_Close(object sender, FormClosedEventArgs e)
        {
            //比较有没有修改数据
            if (!Enumerable.SequenceEqual(txt,txt_o))
            {
                保存ToolStripMenuItem_Click(null, null);
            }
            //重载地图
            if (ClickEvent != null) { ClickEvent(); }
        }

        private void 新关卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认10x10ToolStripMenuItem.Checked = true;
            x15ToolStripMenuItem.Checked = false;
            自定义ToolStripMenuItem.Checked = false;
            myArray = new int[10, 10];
            Level_New();
        }

        //0 空地，1 墙， 3 箱子， 4 箱子目的地， 6 人， 7 箱子与目的地重合， 9 人与目的地重合
        private void tsbLand_Click(object sender, EventArgs e)  //选中空地
        {
            now_select = 0;
            selection_flag = true;
        }

        private void tsbWall_Click(object sender, EventArgs e)  //选中墙
        {
            now_select = 1;
            selection_flag = true;
        }

        private void tsbBox_Click(object sender, EventArgs e)   //选中箱子
        {
            now_select = 3;
            selection_flag = true;
        }

        private void tsbDest_Click(object sender, EventArgs e)   //选中目的地
        {
            now_select = 4;
            selection_flag = true;
        }

        private void tsbBoD_Click(object sender, EventArgs e)   //选中箱子在目的地
        {
            now_select = 7;
            selection_flag = true;
        }

        private void tsbMan_Click(object sender, EventArgs e)    //选中人
        {
            now_select = 6;
            selection_flag = true;
        }

        private void tsbMoD_Click(object sender, EventArgs e)    //选中人在目的地
        {
            now_select = 9;
            selection_flag = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (selection_flag)
            {
                int x, y;
                x = e.X / 30;
                y = e.Y / 30;

                //如果人重复选择，更新人的位置
                int row=-1, col=-1;
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        if (myArray[i, j] == 6 || myArray[i, j] == 9)
                        {
                            human = true;
                            row = i;col = j;
                        }
                    }
                }
                if (human == true)
                {
                    if (now_select == 6 || now_select == 9) { myArray[row, col] = 0; }
                }
                    human = false;
                    myArray[y, x] = now_select;
                    pictureBox1.Image = f.DrawMap(myArray);
                    Level_Regenerate();
            }
        }

    }
}
