using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        datafff kn = new datafff(); 

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
            kn.writedata(namePlayer, score);
            if (kn.CountPlayer() > 10)
            {
                kn.deletebt();
            }
            this.Close();
            }

        private void T_Load(object sender, EventArgs e)
        {

        }
    }
}
