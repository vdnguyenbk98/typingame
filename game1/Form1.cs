using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        
        
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            panelMain.Controls.Add(label1);
            label1.Text = "Let's go";
            label1.Font = new Font(label1.Font.Name,16,label1.Font.Style);
            label1.Size = new Size(100, 30);
            
            timer1.Stop();
            label1.Hide();

        }
         
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random rd = new Random();
            int x = rd.Next(panelMain.Width-50);
            int y = rd.Next(panelMain.Height-50);
            label1.Location = new Point(x, y);
            label1.Text = WordGenerator.GetRandomWord();
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                EndGame();
            }
            
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar == label1.Text[0]) && (label1.Text != ""))
                {
                    label1.Text = label1.Text.Substring(1);
                    
                }
                if (label1.Text == "")
                {
                    score++;
                    label2.Text = score + "";
                    
                }
            }
            catch (Exception ) { }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        void EndGame()
        {
            progressBar1.Value = 0;
            timer1.Stop();
            label1.Hide();
            if (score >= 1)
            {
                T form2 = new T();

                form2.fundata(this.label2);
                form2.ShowDialog();
            }
         }
        void StartGame()
        {
            lblv1.Hide();
            lblv2.Hide();
            lblv3.Hide();
            timer1.Start();
            label1.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void lblv1_Click_1(object sender, EventArgs e)
        {
            
            timer1.Interval = cons.TimeLV1;
            StartGame();



        }

        private void lblv2_Click(object sender, EventArgs e)
        {
            
            timer1.Interval = cons.TimeLV2;
            StartGame();


        }

        private void lblv3_Click(object sender, EventArgs e)
        {

            
            timer1.Interval = cons.TimeLV3;
            StartGame();



        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndGame();
            
            lblv1.Show();
            lblv2.Show();
            lblv3.Show();
            

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


