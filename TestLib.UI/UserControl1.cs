using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLib.UI
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var class1 = new TestLib.Class1();
            int a = int.Parse(this.textBox2.Text);
            int b = int.Parse(this.textBox3.Text);
            int result = class1.Add(a, b);

            // 足し算の式も表示
            string newLine = $"{a} + {b} = {result}";
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                this.textBox1.Text = newLine;
            }
            else
            {
                this.textBox1.Text = newLine + Environment.NewLine + this.textBox1.Text;
            }
        }
    }
}