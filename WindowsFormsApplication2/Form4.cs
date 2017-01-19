using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = 0;

            age = Convert.ToInt16(textBox1.Text);

            if (age <= 10)
            {
                MessageBox.Show("당신은 유년기네요.");
            }
            else if (age <= 20)
            {
                MessageBox.Show("질풍노도의 시기");
            }
            else if (age <= 30)
            {
                MessageBox.Show("인생의 황금기네요");
            }
            else
            {
                MessageBox.Show("노년기네요.");
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bloodtype = string.Empty;
            bloodtype = textBox1.Text.ToUpper();

            switch (bloodtype)
            {
                case "A":
                    MessageBox.Show("부드러운 성격이네요");
                    break;
                case "B":
                    MessageBox.Show("매력적인 성격이네요");
                    break;
                case "O":
                    MessageBox.Show("열정적인 성격이네요");
                    break;
                case "AB":
                    MessageBox.Show("카리스마 성격이네요");
                    break;
                default:
                    MessageBox.Show("외계인?");
                    break;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            cnt = Convert.ToInt16(textBox1.Text);

            for (int i = 1; i <= cnt; i++)
            {
                MessageBox.Show(i.ToString() + " 번째 메시지 입니다.");
            }
        }
    }
}
