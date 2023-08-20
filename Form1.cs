using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskify
{
    public partial class Form1 : Form
    {
        int month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {

            DateTime now = DateTime.Now;
            // Lets getthe first day of month.
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofmonth = new DateTime(year, month, 1);

            //count days of month
            int days = DateTime.DaysInMonth(year, month);

            //convert start of month in integer
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //lets create a blank userControl
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //lets create a blank userControl for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear day container
            daycontainer.Controls.Clear();

            //decreament month
            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);

            //count days of month
            int days = DateTime.DaysInMonth(year, month);

            //convert start of month in integer
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //lets create a blank userControl
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //lets create a blank userControl for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear day container
            daycontainer.Controls.Clear();

            //increament month
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
                
            DateTime startofmonth = new DateTime(year, month, 1);

            //count days of month
            int days = DateTime.DaysInMonth(year, month);

            //convert start of month in integer
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //lets create a blank userControl
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //lets create a blank userControl for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
