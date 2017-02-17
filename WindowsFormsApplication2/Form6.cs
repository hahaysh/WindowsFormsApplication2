using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.panel1.Controls)
            {
                if (control is RadioButton)
                {
                    //RadioButton rdBtn = control as RadioButton;
                    RadioButton rdBtn = control as RadioButton;
                    //rdBtn = null;

                    if (rdBtn.Checked == true)
                    {
                        MessageBox.Show(rdBtn.Text);
                    }

                }

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
        }
    }

}
