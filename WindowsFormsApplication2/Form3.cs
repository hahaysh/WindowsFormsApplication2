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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int iZerg;
        int iTerran;
        int iProtoss;
        private void button1_Click(object sender, EventArgs e)
        {
            //나 , 설명임. 진짜임.
            iZerg = Convert.ToInt16(textBox1.Text);
            iTerran = Convert.ToInt16(textBox2.Text);
            //iZerg++;

            iProtoss = iZerg + iTerran;
            MessageBox.Show(iProtoss.ToString());
        }
    }
}
