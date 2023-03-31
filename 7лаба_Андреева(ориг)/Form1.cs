using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7лаба_Андреева_ориг_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] items = new object[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                items[i] = Program.ReverseChar((string)listBox1.Items[i]);
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            if(form2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.AddRange(form2.strings);
            }
            form2.Visible = false;
        }
    }
}
