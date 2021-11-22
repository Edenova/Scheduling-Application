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
    public partial class EditCustomers : Form
    {
        U06hKtEntities _db = null;
        int _ID = 0;
        public EditCustomers(CustomerViewRecord cust, U06hKtEntities db)
        {
            //customer initialize screen that either loads customer data when update customer is clicked or shows empty boxes for when add customer is clicked.
            //city is preloaded in combo box so user can select city and country will automatically be selected based off of the city.
            InitializeComponent();
            _db = db;
            _ID = cust != null ? cust.ID : 0;
            citycomboBox.DataSource = _db.cities.ToList();
            citycomboBox.DisplayMember = "city1";
            citycomboBox.ValueMember = "cityId";

            this.label1.Text = _ID != 0 ? "Update Customer" : "Add Customer";

            if (_ID != 0)
            {
                customer _cust = db.customers.FirstOrDefault(c => c.customerId == _ID);
                NametBox.Text = _cust.customerName;
                PhonetBox.Text = _cust.address.phone;
                Address1tBox.Text = _cust.address.address1;
                Address2tBox.Text = _cust.address.address2;
                PostalCodetBox.Text = _cust.address.postalCode;
                citycomboBox.Text = _cust.address.city.city1;
                countryTbox.Text = _cust.address.city.country.country1;
            }
        }

        private void NametBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NametBox.Text, out int n) || string.IsNullOrEmpty(NametBox.Text))
            {
                NametBox.BackColor = Color.Red;
                SaveAddbtn.Enabled = false;
            }
            else
            {
                NametBox.BackColor = Color.White;
                SaveAddbtn.Enabled = true;
            }
        }

        private void Address1tBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address1tBox.Text))
            {
                Address1tBox.BackColor = Color.Red;
                SaveAddbtn.Enabled = false;
            }
            else
            {
                Address1tBox.BackColor = Color.White;
                SaveAddbtn.Enabled = true;
            }
        }

        private void Address2tBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address2tBox.Text))
            {
                Address2tBox.BackColor = Color.Red;
                SaveAddbtn.Enabled = false;
            }
            else
            {
                Address2tBox.BackColor = Color.White;
                SaveAddbtn.Enabled = true;
            }
        }

        private void PostalCodetBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PostalCodetBox.Text))
            {
                PostalCodetBox.BackColor = Color.Red;
                SaveAddbtn.Enabled = false;
            }
            else
            {
                PostalCodetBox.BackColor = Color.White;
                SaveAddbtn.Enabled = true;
            }
        }

        private void PhonetBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhonetBox.Text))
            {
                PhonetBox.BackColor = Color.Red;
                SaveAddbtn.Enabled = false;
            }
            else
            {
                PhonetBox.BackColor = Color.White;
                SaveAddbtn.Enabled = true;
            }
        }
        // save button that saves customers to database with exception controls.
        private void SaveAddbtn_Click(object sender, EventArgs e)
        {
            if (NametBox.Text.Trim() == string.Empty || Address1tBox.Text.Trim() == string.Empty || PostalCodetBox.Text.Trim() == string.Empty || PhonetBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            // Prevents user from saving if the textboxes are red
            if (NametBox.BackColor == Color.Red || Address1tBox.BackColor == Color.Red || PostalCodetBox.BackColor == Color.Red || PhonetBox.BackColor == Color.Red)
            {
                MessageBox.Show("Please correct the red box(s)");
                return;
            }
            
            
            customer _cus = null;
            if (_ID != 0)
                _cus = _db.customers.SingleOrDefault(c => c.customerId == _ID);
            else
            {
                _cus = new customer();
                _cus.createdBy = Authentication.getUserName();
                _cus.address = new address();
                _cus.address.createdBy = Authentication.getUserName();
                _db.customers.Add(_cus);
            }
            _cus.customerName = NametBox.Text;
            _cus.address.phone = PhonetBox.Text;
            _cus.address.address1 = Address1tBox.Text;
            _cus.address.address2 = Address2tBox.Text;
            _cus.address.postalCode = PostalCodetBox.Text;
            _cus.lastUpdateBy = Authentication.getUserName();
            _cus.address.lastUpdateBy = Authentication.getUserName();
            _cus.address.city = _db.cities.SingleOrDefault(c => c.cityId == (int)citycomboBox.SelectedValue);
            _db.SaveChanges();
            Close();
        }

        private void citycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cityId = citycomboBox.SelectedValue;
            if (cityId is int)
                countryTbox.Text = _db.cities.SingleOrDefault(c => c.cityId == (int)cityId).country.country1;
        }

        private void EditCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}


