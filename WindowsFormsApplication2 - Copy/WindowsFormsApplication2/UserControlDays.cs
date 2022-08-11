using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControlDays : UserControl
    {
        ToolTip t1;
        public static string staticdate; 
        public UserControlDays(ToolTip T)
        {
            ToolTip t1 = T;
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            button1.Text = numday + " ";
            DayLabel.Text = numday + " ";
        }

        private void DayLabel_Click(object sender, EventArgs e)
        {
            staticdate = DayLabel.Text;
            EventForm eform = new EventForm();
            string eventname = eform.events[eform.Txdate];
            eform.Eventlbl = eventname;
            Label l = (Label)sender;
            eform.Show();
            t1.SetToolTip(l, eventname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            staticdate = DayLabel.Text;
            EventForm eform = new EventForm();
            string eventname = eform.events[eform.Txdate];
            Button l = (Button)sender;
            eform.Show();
            t1.SetToolTip(l, eventname);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try 
            {
                staticdate = DayLabel.Text;
            EventForm eform = new EventForm();
            string eventname = eform.events[eform.Txdate];
            eform.Eventlbl = eventname;
            Label l = (Label)sender;
            eform.Show();
            t1.SetToolTip(l,eventname);
            }

           catch
           {
               staticdate = DayLabel.Text;
            EventForm eform = new EventForm();
            eform.Show();
           }

        }
    }
}
