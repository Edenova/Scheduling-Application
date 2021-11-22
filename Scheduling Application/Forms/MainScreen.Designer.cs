
namespace Scheduling_Application.Model
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.AppointmentsLabel = new System.Windows.Forms.Label();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentsGridView = new System.Windows.Forms.DataGridView();
            this.AddbtAppts = new System.Windows.Forms.Button();
            this.UpdatebtnAppts = new System.Windows.Forms.Button();
            this.DeletebtnAppts = new System.Windows.Forms.Button();
            this.u06hKtDataSet1 = new Scheduling_Application.U06hKtDataSet1();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new Scheduling_Application.U06hKtDataSet1TableAdapters.addressTableAdapter();
            this.u06hKtDataSet3 = new Scheduling_Application.U06hKtDataSet3();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Scheduling_Application.U06hKtDataSet3TableAdapters.customerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delCustbtn = new System.Windows.Forms.Button();
            this.updateCustbtn = new System.Windows.Forms.Button();
            this.addCustbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAptMonth = new System.Windows.Forms.RadioButton();
            this.rbAptWeek = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbApptNumberByTypeAndMonth = new System.Windows.Forms.RadioButton();
            this.rbSchedulerByConsultant = new System.Windows.Forms.RadioButton();
            this.rtbReportView = new System.Windows.Forms.RichTextBox();
            this.rbCustomers = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06hKtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06hKtDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentsLabel
            // 
            this.AppointmentsLabel.AutoSize = true;
            this.AppointmentsLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsLabel.ForeColor = System.Drawing.Color.Gold;
            this.AppointmentsLabel.Location = new System.Drawing.Point(6, 6);
            this.AppointmentsLabel.Name = "AppointmentsLabel";
            this.AppointmentsLabel.Size = new System.Drawing.Size(120, 20);
            this.AppointmentsLabel.TabIndex = 2;
            this.AppointmentsLabel.Text = "Appointments";
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.AllowUserToAddRows = false;
            this.CustomersGridView.AllowUserToDeleteRows = false;
            this.CustomersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Location = new System.Drawing.Point(8, 38);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.ReadOnly = true;
            this.CustomersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGridView.Size = new System.Drawing.Size(674, 335);
            this.CustomersGridView.TabIndex = 3;
            // 
            // AppointmentsGridView
            // 
            this.AppointmentsGridView.AllowUserToAddRows = false;
            this.AppointmentsGridView.AllowUserToDeleteRows = false;
            this.AppointmentsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsGridView.Location = new System.Drawing.Point(8, 38);
            this.AppointmentsGridView.Name = "AppointmentsGridView";
            this.AppointmentsGridView.ReadOnly = true;
            this.AppointmentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsGridView.Size = new System.Drawing.Size(674, 335);
            this.AppointmentsGridView.TabIndex = 4;
            // 
            // AddbtAppts
            // 
            this.AddbtAppts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddbtAppts.Location = new System.Drawing.Point(445, 380);
            this.AddbtAppts.Name = "AddbtAppts";
            this.AddbtAppts.Size = new System.Drawing.Size(75, 23);
            this.AddbtAppts.TabIndex = 8;
            this.AddbtAppts.Text = "Add";
            this.AddbtAppts.UseVisualStyleBackColor = true;
            this.AddbtAppts.Click += new System.EventHandler(this.AddbtAppts_Click);
            // 
            // UpdatebtnAppts
            // 
            this.UpdatebtnAppts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatebtnAppts.Location = new System.Drawing.Point(526, 380);
            this.UpdatebtnAppts.Name = "UpdatebtnAppts";
            this.UpdatebtnAppts.Size = new System.Drawing.Size(75, 23);
            this.UpdatebtnAppts.TabIndex = 9;
            this.UpdatebtnAppts.Text = "Update";
            this.UpdatebtnAppts.UseVisualStyleBackColor = true;
            this.UpdatebtnAppts.Click += new System.EventHandler(this.UpdatebtnAppts_Click);
            // 
            // DeletebtnAppts
            // 
            this.DeletebtnAppts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletebtnAppts.Location = new System.Drawing.Point(607, 380);
            this.DeletebtnAppts.Name = "DeletebtnAppts";
            this.DeletebtnAppts.Size = new System.Drawing.Size(75, 23);
            this.DeletebtnAppts.TabIndex = 10;
            this.DeletebtnAppts.Text = "Delete";
            this.DeletebtnAppts.UseVisualStyleBackColor = true;
            this.DeletebtnAppts.Click += new System.EventHandler(this.DeletebtnAppts_Click);
            // 
            // u06hKtDataSet1
            // 
            this.u06hKtDataSet1.DataSetName = "U06hKtDataSet1";
            this.u06hKtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.u06hKtDataSet1;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // u06hKtDataSet3
            // 
            this.u06hKtDataSet3.DataSetName = "U06hKtDataSet3";
            this.u06hKtDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u06hKtDataSet3;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customers";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 436);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.delCustbtn);
            this.tabPage1.Controls.Add(this.updateCustbtn);
            this.tabPage1.Controls.Add(this.addCustbtn);
            this.tabPage1.Controls.Add(this.CustomersGridView);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            // 
            // delCustbtn
            // 
            this.delCustbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delCustbtn.Location = new System.Drawing.Point(607, 379);
            this.delCustbtn.Name = "delCustbtn";
            this.delCustbtn.Size = new System.Drawing.Size(75, 23);
            this.delCustbtn.TabIndex = 6;
            this.delCustbtn.Text = "Delete";
            this.delCustbtn.UseVisualStyleBackColor = true;
            this.delCustbtn.Click += new System.EventHandler(this.delCustbtn_Click);
            // 
            // updateCustbtn
            // 
            this.updateCustbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateCustbtn.Location = new System.Drawing.Point(526, 379);
            this.updateCustbtn.Name = "updateCustbtn";
            this.updateCustbtn.Size = new System.Drawing.Size(75, 23);
            this.updateCustbtn.TabIndex = 5;
            this.updateCustbtn.Text = "Update";
            this.updateCustbtn.UseVisualStyleBackColor = true;
            this.updateCustbtn.Click += new System.EventHandler(this.updateCustbtn_Click);
            // 
            // addCustbtn
            // 
            this.addCustbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustbtn.Location = new System.Drawing.Point(445, 379);
            this.addCustbtn.Name = "addCustbtn";
            this.addCustbtn.Size = new System.Drawing.Size(75, 23);
            this.addCustbtn.TabIndex = 4;
            this.addCustbtn.Text = "Add";
            this.addCustbtn.UseVisualStyleBackColor = true;
            this.addCustbtn.Click += new System.EventHandler(this.addCustbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.AppointmentsGridView);
            this.tabPage2.Controls.Add(this.AddbtAppts);
            this.tabPage2.Controls.Add(this.AppointmentsLabel);
            this.tabPage2.Controls.Add(this.DeletebtnAppts);
            this.tabPage2.Controls.Add(this.UpdatebtnAppts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointments";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbAptMonth);
            this.panel1.Controls.Add(this.rbAptWeek);
            this.panel1.Location = new System.Drawing.Point(471, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 29);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "For comming";
            // 
            // rbAptMonth
            // 
            this.rbAptMonth.AutoSize = true;
            this.rbAptMonth.Checked = true;
            this.rbAptMonth.Location = new System.Drawing.Point(93, 6);
            this.rbAptMonth.Name = "rbAptMonth";
            this.rbAptMonth.Size = new System.Drawing.Size(55, 17);
            this.rbAptMonth.TabIndex = 11;
            this.rbAptMonth.TabStop = true;
            this.rbAptMonth.Text = "Month";
            this.rbAptMonth.UseVisualStyleBackColor = true;
            this.rbAptMonth.CheckedChanged += new System.EventHandler(this.rbAptMonth_CheckedChanged);
            // 
            // rbAptWeek
            // 
            this.rbAptWeek.AutoSize = true;
            this.rbAptWeek.Location = new System.Drawing.Point(154, 6);
            this.rbAptWeek.Name = "rbAptWeek";
            this.rbAptWeek.Size = new System.Drawing.Size(54, 17);
            this.rbAptWeek.TabIndex = 12;
            this.rbAptWeek.Text = "Week";
            this.rbAptWeek.UseVisualStyleBackColor = true;
            this.rbAptWeek.CheckedChanged += new System.EventHandler(this.rbAptWeek_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.rtbReportView);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(690, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbCustomers);
            this.panel2.Controls.Add(this.rbApptNumberByTypeAndMonth);
            this.panel2.Controls.Add(this.rbSchedulerByConsultant);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 29);
            this.panel2.TabIndex = 15;
            // 
            // rbApptNumberByTypeAndMonth
            // 
            this.rbApptNumberByTypeAndMonth.AutoSize = true;
            this.rbApptNumberByTypeAndMonth.Checked = true;
            this.rbApptNumberByTypeAndMonth.Location = new System.Drawing.Point(3, 6);
            this.rbApptNumberByTypeAndMonth.Name = "rbApptNumberByTypeAndMonth";
            this.rbApptNumberByTypeAndMonth.Size = new System.Drawing.Size(236, 17);
            this.rbApptNumberByTypeAndMonth.TabIndex = 11;
            this.rbApptNumberByTypeAndMonth.TabStop = true;
            this.rbApptNumberByTypeAndMonth.Text = "Number of Appointments by Type and Month";
            this.rbApptNumberByTypeAndMonth.UseVisualStyleBackColor = true;
            this.rbApptNumberByTypeAndMonth.CheckedChanged += new System.EventHandler(this.rbApptNumberByTypeAndMonth_CheckedChanged);
            // 
            // rbSchedulerByConsultant
            // 
            this.rbSchedulerByConsultant.AutoSize = true;
            this.rbSchedulerByConsultant.Location = new System.Drawing.Point(245, 6);
            this.rbSchedulerByConsultant.Name = "rbSchedulerByConsultant";
            this.rbSchedulerByConsultant.Size = new System.Drawing.Size(141, 17);
            this.rbSchedulerByConsultant.TabIndex = 12;
            this.rbSchedulerByConsultant.Text = "Schedule per Consultant";
            this.rbSchedulerByConsultant.UseVisualStyleBackColor = true;
            this.rbSchedulerByConsultant.CheckedChanged += new System.EventHandler(this.rbSchedulerByConsultant_CheckedChanged);
            // 
            // rtbReportView
            // 
            this.rtbReportView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReportView.Location = new System.Drawing.Point(4, 38);
            this.rtbReportView.Name = "rtbReportView";
            this.rtbReportView.Size = new System.Drawing.Size(678, 365);
            this.rtbReportView.TabIndex = 16;
            this.rtbReportView.Text = "";
            // 
            // rbCustomers
            // 
            this.rbCustomers.AutoSize = true;
            this.rbCustomers.Location = new System.Drawing.Point(392, 6);
            this.rbCustomers.Name = "rbCustomers";
            this.rbCustomers.Size = new System.Drawing.Size(74, 17);
            this.rbCustomers.TabIndex = 14;
            this.rbCustomers.Text = "Customers";
            this.rbCustomers.UseVisualStyleBackColor = true;
            this.rbCustomers.CheckedChanged += new System.EventHandler(this.rbCustomers_CheckedChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 464);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06hKtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06hKtDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label AppointmentsLabel;
        private System.Windows.Forms.DataGridView CustomersGridView;
        private System.Windows.Forms.DataGridView AppointmentsGridView;
        private System.Windows.Forms.Button AddbtAppts;
        private System.Windows.Forms.Button UpdatebtnAppts;
        private System.Windows.Forms.Button DeletebtnAppts;
        private U06hKtDataSet1 u06hKtDataSet1;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private U06hKtDataSet1TableAdapters.addressTableAdapter addressTableAdapter;
        private U06hKtDataSet3 u06hKtDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U06hKtDataSet3TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delCustbtn;
        private System.Windows.Forms.Button updateCustbtn;
        private System.Windows.Forms.Button addCustbtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbAptMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAptWeek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbApptNumberByTypeAndMonth;
        private System.Windows.Forms.RadioButton rbSchedulerByConsultant;
        private System.Windows.Forms.RichTextBox rtbReportView;
        private System.Windows.Forms.RadioButton rbCustomers;
    }
}