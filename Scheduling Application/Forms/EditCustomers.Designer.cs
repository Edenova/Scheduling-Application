
namespace Scheduling_Application.Model
{
    partial class EditCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Address2label = new System.Windows.Forms.Label();
            this.Address1label = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostalCodelabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.NametBox = new System.Windows.Forms.TextBox();
            this.Address1tBox = new System.Windows.Forms.TextBox();
            this.Address2tBox = new System.Windows.Forms.TextBox();
            this.PostalCodetBox = new System.Windows.Forms.TextBox();
            this.PhonetBox = new System.Windows.Forms.TextBox();
            this.SaveAddbtn = new System.Windows.Forms.Button();
            this.Cancelbttn = new System.Windows.Forms.Button();
            this.cityLbl = new System.Windows.Forms.Label();
            this.countryLbl = new System.Windows.Forms.Label();
            this.countryTbox = new System.Windows.Forms.TextBox();
            this.citycomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Address2label
            // 
            this.Address2label.AutoSize = true;
            this.Address2label.Location = new System.Drawing.Point(15, 146);
            this.Address2label.Name = "Address2label";
            this.Address2label.Size = new System.Drawing.Size(51, 13);
            this.Address2label.TabIndex = 9;
            this.Address2label.Text = "Address2";
            // 
            // Address1label
            // 
            this.Address1label.AutoSize = true;
            this.Address1label.Location = new System.Drawing.Point(15, 120);
            this.Address1label.Name = "Address1label";
            this.Address1label.Size = new System.Drawing.Size(51, 13);
            this.Address1label.TabIndex = 8;
            this.Address1label.Text = "Address1";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(15, 68);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 7;
            this.Namelabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PostalCodelabel
            // 
            this.PostalCodelabel.AutoSize = true;
            this.PostalCodelabel.Location = new System.Drawing.Point(15, 172);
            this.PostalCodelabel.Name = "PostalCodelabel";
            this.PostalCodelabel.Size = new System.Drawing.Size(64, 13);
            this.PostalCodelabel.TabIndex = 10;
            this.PostalCodelabel.Text = "Postal Code";
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Location = new System.Drawing.Point(15, 94);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(78, 13);
            this.Phonelabel.TabIndex = 11;
            this.Phonelabel.Text = "Phone Number";
            // 
            // NametBox
            // 
            this.NametBox.Location = new System.Drawing.Point(99, 65);
            this.NametBox.Name = "NametBox";
            this.NametBox.Size = new System.Drawing.Size(217, 20);
            this.NametBox.TabIndex = 0;
            this.NametBox.TextChanged += new System.EventHandler(this.NametBox_TextChanged);
            // 
            // Address1tBox
            // 
            this.Address1tBox.Location = new System.Drawing.Point(99, 117);
            this.Address1tBox.Name = "Address1tBox";
            this.Address1tBox.Size = new System.Drawing.Size(217, 20);
            this.Address1tBox.TabIndex = 2;
            this.Address1tBox.TextChanged += new System.EventHandler(this.Address1tBox_TextChanged);
            // 
            // Address2tBox
            // 
            this.Address2tBox.Location = new System.Drawing.Point(98, 143);
            this.Address2tBox.Name = "Address2tBox";
            this.Address2tBox.Size = new System.Drawing.Size(217, 20);
            this.Address2tBox.TabIndex = 3;
            this.Address2tBox.TextChanged += new System.EventHandler(this.Address2tBox_TextChanged);
            // 
            // PostalCodetBox
            // 
            this.PostalCodetBox.Location = new System.Drawing.Point(98, 169);
            this.PostalCodetBox.Name = "PostalCodetBox";
            this.PostalCodetBox.Size = new System.Drawing.Size(217, 20);
            this.PostalCodetBox.TabIndex = 4;
            this.PostalCodetBox.TextChanged += new System.EventHandler(this.PostalCodetBox_TextChanged);
            // 
            // PhonetBox
            // 
            this.PhonetBox.Location = new System.Drawing.Point(99, 91);
            this.PhonetBox.Name = "PhonetBox";
            this.PhonetBox.Size = new System.Drawing.Size(217, 20);
            this.PhonetBox.TabIndex = 1;
            this.PhonetBox.TextChanged += new System.EventHandler(this.PhonetBox_TextChanged);
            // 
            // SaveAddbtn
            // 
            this.SaveAddbtn.Location = new System.Drawing.Point(90, 267);
            this.SaveAddbtn.Name = "SaveAddbtn";
            this.SaveAddbtn.Size = new System.Drawing.Size(75, 23);
            this.SaveAddbtn.TabIndex = 6;
            this.SaveAddbtn.Text = "Save";
            this.SaveAddbtn.UseVisualStyleBackColor = true;
            this.SaveAddbtn.Click += new System.EventHandler(this.SaveAddbtn_Click);
            // 
            // Cancelbttn
            // 
            this.Cancelbttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbttn.Location = new System.Drawing.Point(171, 267);
            this.Cancelbttn.Name = "Cancelbttn";
            this.Cancelbttn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbttn.TabIndex = 7;
            this.Cancelbttn.Text = "Cancel";
            this.Cancelbttn.UseVisualStyleBackColor = true;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(15, 198);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(24, 13);
            this.cityLbl.TabIndex = 20;
            this.cityLbl.Text = "City";
            // 
            // countryLbl
            // 
            this.countryLbl.AutoSize = true;
            this.countryLbl.Location = new System.Drawing.Point(15, 225);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(43, 13);
            this.countryLbl.TabIndex = 21;
            this.countryLbl.Text = "Country";
            // 
            // countryTbox
            // 
            this.countryTbox.Location = new System.Drawing.Point(98, 222);
            this.countryTbox.Name = "countryTbox";
            this.countryTbox.ReadOnly = true;
            this.countryTbox.Size = new System.Drawing.Size(217, 20);
            this.countryTbox.TabIndex = 22;
            this.countryTbox.TabStop = false;
            // 
            // citycomboBox
            // 
            this.citycomboBox.FormattingEnabled = true;
            this.citycomboBox.ItemHeight = 13;
            this.citycomboBox.Location = new System.Drawing.Point(99, 195);
            this.citycomboBox.Name = "citycomboBox";
            this.citycomboBox.Size = new System.Drawing.Size(217, 21);
            this.citycomboBox.TabIndex = 5;
            this.citycomboBox.SelectedIndexChanged += new System.EventHandler(this.citycomboBox_SelectedIndexChanged);
            // 
            // EditCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 326);
            this.Controls.Add(this.citycomboBox);
            this.Controls.Add(this.countryTbox);
            this.Controls.Add(this.countryLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.Cancelbttn);
            this.Controls.Add(this.SaveAddbtn);
            this.Controls.Add(this.PhonetBox);
            this.Controls.Add(this.PostalCodetBox);
            this.Controls.Add(this.Address2tBox);
            this.Controls.Add(this.Address1tBox);
            this.Controls.Add(this.NametBox);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.PostalCodelabel);
            this.Controls.Add(this.Address2label);
            this.Controls.Add(this.Address1label);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.EditCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address2label;
        private System.Windows.Forms.Label Address1label;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PostalCodelabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.TextBox NametBox;
        private System.Windows.Forms.TextBox Address1tBox;
        private System.Windows.Forms.TextBox Address2tBox;
        private System.Windows.Forms.TextBox PostalCodetBox;
        private System.Windows.Forms.TextBox PhonetBox;
        private System.Windows.Forms.Button SaveAddbtn;
        private System.Windows.Forms.Button Cancelbttn;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.TextBox countryTbox;
        private System.Windows.Forms.ComboBox citycomboBox;
    }
}