using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Taskify
{
    public partial class EventForm : Form
    {
        //create connection String
        static String connString = "server=localhost;Uid=root;Pwd='';Port=3307;database=db_calendar;sslmode=none";
        MySqlConnection conn;

        public EventForm()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
             //lets call the static variable we declare
             txdate.Text = UserControlDays.static_day + "/" + Form1.static_month + "/" + Form1.static_year;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,event)VALUES(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
        }
    }
}
