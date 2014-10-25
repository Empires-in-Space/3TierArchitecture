using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        MiddleTier.BC.BusinessConnector bc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bc = new MiddleTier.BC.BusinessConnector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += bc.shipMove(1, 1, 2, 1) + Environment.NewLine;
        }
    }
}
