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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iKor = 0;
            int iEng = 0;
            int iMat = 0;

            iKor = Convert.ToInt16(textBox1.Text);
            iEng = Convert.ToInt16(textBox2.Text);
            iMat = Convert.ToInt16(textBox3.Text);

            textBox1.Text = Grade(iKor);
            textBox2.Text = Grade(iEng);
            textBox3.Text = Grade(iMat);

        }

        private string Grade(int score)
        {
            string returnText = string.Empty;

            if (score > 90)
            {
                returnText = "수";
            }
            else if (score > 80)
            {
                returnText = "우";
            }
            else if (score > 70)
            {
                returnText = "미";
            }
            else
            {
                returnText = "가";
            }

            return returnText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iKor = 0;

            iKor = Convert.ToInt16(textBox1.Text);
            if (iKor > 90)
            {
                textBox1.Text = "수";
            }
            else if (iKor > 80)
            {
                textBox1.Text = "우";
            }
            else if (iKor > 70)
            {
                textBox1.Text = "미";
            }
            else
            {
                textBox1.Text = "가";
            }
        }
    }
}
