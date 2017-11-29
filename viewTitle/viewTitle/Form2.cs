using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewTitle
{
    public partial class Form2 : Form
    {
        public delegate void Form2_EventHandler(String data);
        public event Form2_EventHandler TextSendEvent;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextSendEvent(textBox1.ToString());
            
            textBox1.Text = "";
            this.Close();
        }
    }
}
