using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankClient
{
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
            client = new Client();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.send("JOIN#", this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.send("UP#", this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            client.send("SHOOT#", this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            client.send("DOWN#", this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.send("RIGHT#", this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.send("LEFT#", this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
