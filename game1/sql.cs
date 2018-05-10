using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    class datafff
    {
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-VGNG2FP;Initial Catalog=game;Integrated Security=True");
        public void viewtop(DataGridView data )
        {


            kn.Open();
            
            string sql = "select * from dbo.player order by score";
            SqlCommand cm = new SqlCommand(sql, kn);
            SqlDataAdapter adap = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adap.Fill(table);
            data.DataSource = table;
            
        }
        public void writedata(TextBox namePlayer,int score )
        {
            kn.Open();
            string sql = "insert into dbo.player values('" + namePlayer.Text + "'," + score + ")";
            SqlCommand comand = new SqlCommand(sql, kn);
            comand.ExecuteNonQuery();
            kn.Close();
           
        }
        public int getplayer10()
        {
            int a;
            kn.Open();
            string sql = "select top 1 score from dbo.player order by score";
            SqlCommand command = new SqlCommand(sql,kn);
            a = int.Parse(command.ExecuteScalar().ToString());
            return a;

        }
        public int CountPlayer()
        {
            int a;
            kn.Open();
            string sql = "select COUNT(score) from dbo.player";
            SqlCommand command = new SqlCommand(sql, kn);
            a = int.Parse(command.ExecuteScalar().ToString());
            kn.Close();
            return a;

        }
        public void deletebt()
        {
            kn.Open();
            string sql = "delete from dbo.player where score=(select top 1 score from dbo.player order by score)";
            SqlCommand comand = new SqlCommand(sql, kn);
            comand.ExecuteNonQuery();
            kn.Close();
        }
        

        
    }
}
