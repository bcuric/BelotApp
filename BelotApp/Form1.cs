using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelotApp
{
    public partial class Form1 : Form
    {
        private int sumUs=0;
        private int sumYou=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            listBoxResult.Items.Add(txtUs.Text + "-" + txtYou.Text);
            txtUs.Text = null;
            txtYou.Text = null;

        }
    }
}
