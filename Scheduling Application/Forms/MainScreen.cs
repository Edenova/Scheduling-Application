using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduling_Application.Types;
using Scheduling_Application.Model;

namespace Scheduling_Application.Model
{
    public partial class MainScreen : Form
    {
        // Report retrieving 
        private class appointmentReport
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public string aType { get; set; }
            public int Count { get; set; }
        }

        private class apptByConsultantReport
        {
            public string Title { get; set; }
            public string Consultant { get; set; }
            public string CustomerName { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }


        U06hKtEntities _db = null;
        // Refresh and retrieve of customer data for data grid view that uses lambda expression for one-off method which makes retrival faster and provides less work that would be creating a full method.
        private void RefreshCustomerView()
        {
            CustomersGridView.DataSource = null;
            CustomersGridView.DataSource = _db.customers.Join(_db.addresses, customer => customer.addressId, address => address.addressId, (customer, address) =>
                 new CustomerViewRecord() { ID = customer.customerId, Name = customer.customerName, Address1 = address.address1, Address2 = address.address2, PostalCode = address.postalCode, PhoneNumber = address.phone }).ToList();
           CustomersGridView.Columns["ID"].Visible = false;
        }
        // Refresh and retrieve of appointment data for data grid view that uses lambda expression for one-off method which makes retrival faster and provides less work that would be creating a full method.
        private void RefreshAppointmentView()
        {
            AppointmentsGridView.DataSource = null;
            string userName = Authentication.getUserName();
            DateTime startDate = DateTime.Now.ToUniversalTime();
            DateTime endDate = rbAptMonth.Checked ? DateTime.Now.AddMonths(1).ToUniversalTime() : DateTime.Now.AddDays(7).ToUniversalTime();
            List<AppointmentRecordView> recs = _db.appointments.Where(appt => appt.start > startDate && appt.start < endDate && appt.user.userName == userName).Join(_db.customers, appointment => appointment.customerId, customer => customer.customerId, (appointment, customer) =>
            new AppointmentRecordView() { AppointmentID = appointment.appointmentId, Title = appointment.title, Type = appointment.type, 
                Customer = customer.customerName, Start=appointment.start, End=appointment.end}).ToList();
            foreach (var item in recs)
            {
                item.Start = item.Start.ToLocalTime();
                item.End = item.End.ToLocalTime();
            }
            AppointmentsGridView.DataSource = recs;
            AppointmentsGridView.Columns["AppointmentID"].Visible = false;
            AppointmentsGridView.Columns["Start"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            AppointmentsGridView.Columns["End"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            AppointmentsGridView.Columns["Start"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            AppointmentsGridView.Columns["End"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        // Refresh and retrive for reports. Has lambda expression that makes retrival faster than creating a method to sort each report seperately.
        private void RefreshReportsView()
        {
            if (rbSchedulerByConsultant.Checked)
            {
                rtbReportView.Clear();
                rtbReportView.SelectionTabs = new int[] { 50, 150, 300, 420 };
                rtbReportView.AppendText("\tCustomer\tTitle\tStarts\tEnds");
                rtbReportView.AppendText("\n===============================================================================================");
                var cList = _db.appointments.Select(a => new apptByConsultantReport()
                {
                    Title = a.title,
                    Consultant = a.user.userName,
                    CustomerName = a.customer.customerName,
                    Start = a.start,
                    End = a.end
                }).OrderBy(a => a.Consultant).ThenBy(a=> a.Start).ToList();
                String consultant = "";
                foreach (var c in cList)
                {
                    if (c.Consultant != consultant)
                    {
                        consultant = c.Consultant;
                        rtbReportView.AppendText($"\n\nConsultant: {c.Consultant}");
                        rtbReportView.AppendText("\n-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    rtbReportView.AppendText($"\n\t{c.CustomerName}\t{c.Title}\t{c.Start.ToLocalTime().ToString("MM/dd/yyyy hh:mm tt")}\t{c.End.ToLocalTime().ToString("MM/dd/yyyy hh:mm tt")}");
                }

            }
            else if (rbCustomers.Checked)
            {
                rtbReportView.Clear();
                rtbReportView.SelectionTabs = new int[] { 100, 150, 350, 420, 500 };
                rtbReportView.AppendText("Name\tPhone\tAddress\tCity\tPostal code\tCountry");
                rtbReportView.AppendText("\n-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                var cList = _db.customers.Select(c => new
                {
                    Name = c.customerName,
                    Phone = c.address.phone,
                    Address = c.address.address1 + "" + c.address.address2,
                    City = c.address.city.city1,
                    Postal = c.address.postalCode,
                    Country = c.address.city.country.country1
                });
                foreach (var item in cList)
                {
                    rtbReportView.AppendText($"\n{item.Name}\t{item.Phone}\t{item.Address}\t{item.City}\t{item.Postal}\t{item.Country}");
                }
            }
            else
            {
                rtbReportView.Clear();
                rtbReportView.SelectionTabs = new int[] { 50, 100, 200 };
                rtbReportView.AppendText("Year\tMonth\tType\tCount");
                rtbReportView.AppendText("\n----------------------------------------------------------------------------");

                var aList = _db.appointments.Select(a => new { Year = a.start.Year, Month = a.start.Month, aType = a.type }).ToList();
                var rList = aList.GroupBy(a => new { year = a.Year, month = a.Month, aType = a.aType })
                    .Select(a => new appointmentReport() { Year = a.Key.year, Month = a.Key.month, aType = a.Key.aType, Count = a.Count() })
                    .OrderBy(o => o.Year).ThenBy(o => o.Month).ToList();
                foreach (var item in rList)
                {
                    rtbReportView.AppendText($"\n{item.Year}\t{item.Month}\t{item.aType}\t{item.Count}");
                }
            }
        }

        public MainScreen(U06hKtEntities db)
        {
            // Load screen that uses methods above to load and refresh each view respectively.
            InitializeComponent();
            _db = db;
            RefreshCustomerView();
            RefreshAppointmentView();
            RefreshReportsView();
            this.Text = $"Schedule for consultant {Authentication.getUserName()}";
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.u06hKtDataSet3.customer);
            this.addressTableAdapter.Fill(this.u06hKtDataSet1.address);
        }
        
        private void delCustbtn_Click(object sender, EventArgs e)
        {
            //Delete function for customers uses lambda expression for when customer matches ID. Makes finding customer faster and deletetion of selected customer.
            CustomerViewRecord o = (CustomerViewRecord)CustomersGridView.SelectedRows[0].DataBoundItem;
            var appts = _db.appointments.Where(a => a.customerId == o.ID);
            if (MessageBox.Show(appts.Count() > 0 ? "Customer has " + appts.Count().ToString() + " appointment(s). Do you want to delete customer and appointment(s)?" : "Do you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (appts.Count() > 0)
                    _db.appointments.RemoveRange(appts);
                _db.customers.Remove(_db.customers.FirstOrDefault(c => c.customerId == o.ID));
                _db.SaveChanges();
                RefreshCustomerView();
                RefreshAppointmentView();
            }
        }

        private void rbAptMonth_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAppointmentView();
        }

        private void rbAptWeek_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAppointmentView();
        }

        private void DeletebtnAppts_Click(object sender, EventArgs e)
        {
            //Delete function for appointments uses lambda expression for when appointment matches ID. Makes finding appointment faster and deletetion of selected appointment.
            AppointmentRecordView o = (AppointmentRecordView)AppointmentsGridView.SelectedRows[0].DataBoundItem;
           
            if (MessageBox.Show("Do you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _db.appointments.Remove(_db.appointments.FirstOrDefault(c => c.appointmentId == o.AppointmentID));
                _db.SaveChanges();
                RefreshAppointmentView();
            }
        }

        private void updateCustbtn_Click(object sender, EventArgs e)
        {
            //Loads update customer screen
            CustomerViewRecord o = (CustomerViewRecord)CustomersGridView.SelectedRows[0].DataBoundItem;
            EditCustomers editCustomers = new EditCustomers(o, _db);
            editCustomers.ShowDialog();
            RefreshCustomerView();
        }

        private void addCustbtn_Click(object sender, EventArgs e)
        {
            //Loads Add customer screen
            EditCustomers editCustomers = new EditCustomers(null, _db);
            editCustomers.ShowDialog();
            RefreshCustomerView();
        }

		private void AddbtAppts_Click(object sender, EventArgs e)
		{
            //Loads add appointment screen
            Appointments appointments = new Appointments(null, _db);
            appointments.ShowDialog();
            RefreshAppointmentView();
		}

		private void UpdatebtnAppts_Click(object sender, EventArgs e)
		{
            //Loads update appointment screen
            AppointmentRecordView o = (AppointmentRecordView)AppointmentsGridView.SelectedRows[0].DataBoundItem;
            Appointments appointments = new Appointments(o, _db);
            appointments.ShowDialog();
            RefreshAppointmentView();
		}

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logs user out 
            Authentication.LogOut();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Buttons bellow used to generate reports.
        private void rbApptNumberByTypeAndMonth_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReportsView();
        }

        private void rbSchedulerByConsultant_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReportsView();
        }

        private void rbCustomers_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReportsView();
        }
    }
}
