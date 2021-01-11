using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk2App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_hellomessage.Text = "nice to meet you";
        }

        private void btn_changecolor_Click(object sender, EventArgs e)
        {
            int num1 = 400;
            int num2 = 699;

            int  result = num1 * num2;
            lbl_hellomessage.Text = $"You have Ksh: {result}";

        }

        private void ckb_runs_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_runs.Checked)
            {
                ckb_runs.Text = "checked";

            }
            else
            {
                ckb_runs.Text = "not-checked";
                
            }
        }
    }
}
