using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
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
        Label lblDays;
        public static bool isDelete = false;

        public EventForm(Label lblDays)
        {
            InitializeComponent();
            this.lblDays = lblDays;
            conn = new MySqlConnection(connString);
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
             //lets call the static variable we declare
             txdate.Text = UserControlDays.static_day + "/" + Form1.static_month + "/" + Form1.static_year;
            if (UserControlDays.isUpdate)
            {
                btnsave.Text = "Update";
                txevent.Text = UserControlDays.prevEvent;
                UserControlDays.isUpdate = false;
                btndelete.Visible = true;
            }
            else
            {
                btnsave.Text = "Save";
                txevent.Text = "";
                btndelete.Visible = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (btnsave.Text == "Update")
            {
                updateEvent();
            }
            else
            {
                insertEvent();
            }
            
        }

        private void updateEvent()
        {
            conn.Open();
            String sql = "UPDATE tbl_calendar SET event = ? where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event Updated");
            this.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void insertEvent()
        {
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,event)VALUES(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            this.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "DELETE FROM tbl_calendar where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Notes");
            lblDays.Text = "";
            this.Dispose();
            cmd.Dispose();
            conn.Close();
        }
    }
}
