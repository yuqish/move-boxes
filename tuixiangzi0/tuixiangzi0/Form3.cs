using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuixiangzi0
{
    public partial class Form3 : Form
    {
        internal int row_num;
        internal int col_num;
        internal int flag_size=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //点击提交时
        {
            flag_size = 0;
            bool flag=IsValid();
            if (flag == true) {
                flag_size = 1;
                row_num = int.Parse(txtWidth.Text);
                col_num = int.Parse(txtLength.Text);
                Close();
            }
            else {
                MessageBox.Show("提醒","参数有误!");
                return; }
        }
        private bool IsValid()
        {
            try
            {
                int i = int.Parse(txtLength.Text);
                int j = int.Parse(txtWidth.Text);
                if ( i < 1 || j < 1) { return false; }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtWidth.Text = row_num.ToString();
            txtLength.Text = col_num.ToString();
        }
    }
}
