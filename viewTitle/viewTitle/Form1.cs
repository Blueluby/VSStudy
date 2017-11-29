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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 f2;

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            //this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        { 

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 타이틀바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strTitle = "";
            foreach(Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "Form2")
                {
                    openForm.Activate();
                    return;
                }
            }
            f2 = new Form2();
            f2.TextSendEvent += new Form2.Form2_EventHandler(form2_getEventhandler);
            f2.Show();
        }

        private void form2_getEventhandler(String t)
        {
            this.Text = Text;
        }
    }
}
