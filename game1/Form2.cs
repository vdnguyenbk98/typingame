using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class T : Form
    {
        int score;
        public T()
        {
            InitializeComponent();
        }
        public void fundata(Label label2)
        {
            score = Convert.ToInt32(label2.Text);
        }

        private void Cc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                using (StreamWriter r = new StreamWriter(Application.StartupPath + "\\dulieu.txt"))
                {
                    r.WriteLine(textBox1.Text + " " + score+ Environment.NewLine);
                    
                }
                this.Close();
            }
        }
    }
}
