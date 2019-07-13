using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("你的名字是：" + txt_Name.Text);
            if (MessageBox.Show(txt_Name.Text, "SHOW_MESSAGE", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                Console.WriteLine("CANSEL");
            }
            else
                Console.WriteLine("OK");
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_Count.Text = txt_Name.Text.Count().ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_Add_Name.Text;
            lst_Names.Items.Add(name);
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            lst_Names.Items.Clear();
        }

        private void btn_ShowForm2_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.ShowDialog();
            frm2.Hide();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
