using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduling_Application.Model;
using Scheduling_Application.Types;


namespace Scheduling_Application.Model
{
    public partial class Appointments : Form
    {
        U06hKtEntities _db = null;
        int _ID = 0;
        bool _edit = false;

        public Appointments( AppointmentRecordView appt,U06hKtEntities db)
        {
            //appointment initialize screen that either loads appointment data when update appointment is clicked or shows empty boxes for when new appointment is clicked.
            //Customer name is preloaded so user can choose what customer the appointment is for.
            InitializeComponent();
            _db = db;
            _ID = appt != null ? appt.AppointmentID : 0;
            CustmrcomboBox.DataSource = _db.customers.ToList();
            CustmrcomboBox.DisplayMember = "customerName";
            CustmrcomboBox.ValueMember = "customerId";
            TitletBox.BackColor = Color.Red;
            TypetBox.BackColor = Color.Red;
            saveBtn.Enabled = false;
            _edit = _ID != 0;
            this.label1.Text = _edit ? "Update Appointment" : "Add Appointment";
            if (_ID != 0)
			{
                appointment _appt = db.appointments.FirstOrDefault(c => c.appointmentId == _ID);
                TitletBox.Text = _appt.title;
                CustmrcomboBox.Text = _appt.customer.customerName;
                TypetBox.Text = _appt.type;
                
               StartdateTimePicker.Value = _appt.start.ToLocalTime();
               EnddateTimePicker.Value = _appt.end.ToLocalTime();
			}
        }
        // Save button with exception controls including scheduling outside of business hours, scheduling overlapping appointments, entering nonexistent or invalid customer data.
        private void saveBtn_Click(object sender, EventArgs e)
		{
			if (StartdateTimePicker.Value.Hour < 9 || StartdateTimePicker.Value.Hour > 17)
			{
                MessageBox.Show("Appointment cannot be scheduled outside of business hours");
                return;
			}
			if (EnddateTimePicker.Value.Hour < 9 || EnddateTimePicker.Value.Hour > 17)
			{
                MessageBox.Show("Appointmend cannot end outside of business hours");
                return;
			}
			if (EnddateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || EnddateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
			{
                MessageBox.Show("Appointmend cannot be scheduled on weekends");
                return;
            }
			if (StartdateTimePicker.Value >= EnddateTimePicker.Value)
			{
                MessageBox.Show("Appointment cannot end before start time");
                return;
			}
            if (TitletBox.Text.Trim() == string.Empty || TypetBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            DateTime apptStart = StartdateTimePicker.Value.ToUniversalTime();
            DateTime apptEnd = EnddateTimePicker.Value.ToUniversalTime();
            foreach (var appt in _db.appointments)
            {
                if (appt.start < apptEnd && apptStart < appt.end && appt.appointmentId != _ID)
                {
                    MessageBox.Show("Appointment overlaps with existing appointment. Please select another time.");
                    return;
                }
            }
            if (TypetBox.BackColor == Color.Red || TitletBox.BackColor == Color.Red)
            {
                MessageBox.Show("Please correct the red box(s)");
                return;
            }

            appointment _appt = null;
            if (_ID != 0)
                _appt = _db.appointments.SingleOrDefault(c => c.appointmentId == _ID);
			else
			{
                _appt = new appointment();
                _appt.userId = Authentication.getUser().userId;
                _appt.description = "not needed";
                _appt.location = "not needed";
                _appt.contact = "not needed";
                _appt.url = "not needed";
                _appt.createDate = DateTime.Now;
                _appt.createdBy = Authentication.getUserName();
                
                _db.appointments.Add(_appt);
			}

            _appt.lastUpdateBy = Authentication.getUserName();
            _appt.customer = _db.customers.SingleOrDefault(c => c.customerId == (int)CustmrcomboBox.SelectedValue);
            _appt.type = TypetBox.Text;
            _appt.title = TitletBox.Text;
            _appt.start = StartdateTimePicker.Value.ToUniversalTime();
            _appt.end = EnddateTimePicker.Value.ToUniversalTime();
            _db.SaveChanges();
            Close();
		}

		private void TitletBox_TextChanged(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(TitletBox.Text))
            {
                TitletBox.BackColor = Color.Red;
                saveBtn.Enabled = false;
            }
            else
            {
                TitletBox.BackColor = Color.White;
                saveBtn.Enabled = true;
            }
        }

        private void TypetBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TypetBox.Text))
            {
                TypetBox.BackColor = Color.Red;
                saveBtn.Enabled = false;
            }
            else
            {
                TypetBox.BackColor = Color.White;
                saveBtn.Enabled = true;
            }
        }
	}
}
