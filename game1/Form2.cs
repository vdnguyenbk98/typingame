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
        //nhận score từ form 1
        public void fundata(Label label2)
        {
            score = Convert.ToInt32(label2.Text);
        }
        //nút cancel
        private void Cc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //nút OK
        private void ok_Click(object sender, EventArgs e)
        {if (namePlayer.Text != "")
            {
                kn.writedata(namePlayer, score);
                if (kn.CountPlayer() > 10)
                {
                    kn.deletebt();
                }
                this.Close();
            }
        }

        
    }
}
