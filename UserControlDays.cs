using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskify
{
    public partial class UserControlDays : UserControl
    {
        //lets create another static variable for days

        public static string static_day;
        static String connString = "server=localhost;Uid=root;Pwd='';Port=3307;database=db_calendar;sslmode=none";

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            //start timer if usercontrolday is clicked
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        //create a new method to display event
        private void displayEvents()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM tbl_calendar where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", lbdays.Text + "/" + Form1.static_month + "/" + Form1.static_year);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {   
                lbevent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        //Create a timer for auto display event if new event added
        private void timer1_Tick(object sender, EventArgs e)
        {
            //call displayEvent method
            displayEvents();
        }

        
    }
}
