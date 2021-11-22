
namespace Scheduling_Application.Model
{
    partial class Appointments
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.CustLabel = new System.Windows.Forms.Label();
            this.Strtlabel = new System.Windows.Forms.Label();
            this.Endlabel = new System.Windows.Forms.Label();
            this.TitletBox = new System.Windows.Forms.TextBox();
            this.TypetBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.CustmrcomboBox = new System.Windows.Forms.ComboBox();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(35, 130);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(35, 173);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type";
            // 
            // CustLabel
            // 
            this.CustLabel.AutoSize = true;
            this.CustLabel.Location = new System.Drawing.Point(35, 84);
            this.CustLabel.Name = "CustLabel";
            this.CustLabel.Size = new System.Drawing.Size(51, 13);
            this.CustLabel.TabIndex = 3;
            this.CustLabel.Text = "Customer";
            // 
            // Strtlabel
            // 
            this.Strtlabel.AutoSize = true;
            this.Strtlabel.Location = new System.Drawing.Point(35, 215);
            this.Strtlabel.Name = "Strtlabel";
            this.Strtlabel.Size = new System.Drawing.Size(55, 13);
            this.Strtlabel.TabIndex = 4;
            this.Strtlabel.Text = "Start Time";
            // 
            // Endlabel
            // 
            this.Endlabel.AutoSize = true;
            this.Endlabel.Location = new System.Drawing.Point(35, 255);
            this.Endlabel.Name = "Endlabel";
            this.Endlabel.Size = new System.Drawing.Size(52, 13);
            this.Endlabel.TabIndex = 5;
            this.Endlabel.Text = "End Time";
            // 
            // TitletBox
            // 
            this.TitletBox.Location = new System.Drawing.Point(92, 127);
            this.TitletBox.Name = "TitletBox";
            this.TitletBox.Size = new System.Drawing.Size(153, 20);
            this.TitletBox.TabIndex = 1;
            this.TitletBox.TextChanged += new System.EventHandler(this.TitletBox_TextChanged);
            // 
            // TypetBox
            // 
            this.TypetBox.Location = new System.Drawing.Point(92, 170);
            this.TypetBox.Name = "TypetBox";
            this.TypetBox.Size = new System.Drawing.Size(153, 20);
            this.TypetBox.TabIndex = 2;
            this.TypetBox.TextChanged += new System.EventHandler(this.TypetBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(75, 302);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(156, 302);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // CustmrcomboBox
            // 
            this.CustmrcomboBox.FormattingEnabled = true;
            this.CustmrcomboBox.Location = new System.Drawing.Point(92, 81);
            this.CustmrcomboBox.Name = "CustmrcomboBox";
            this.CustmrcomboBox.Size = new System.Drawing.Size(153, 21);
            this.CustmrcomboBox.TabIndex = 0;
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartdateTimePicker.Location = new System.Drawing.Point(92, 209);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.StartdateTimePicker.TabIndex = 3;
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EnddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EnddateTimePicker.Location = new System.Drawing.Point(92, 249);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.EnddateTimePicker.TabIndex = 4;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 369);
            this.Controls.Add(this.EnddateTimePicker);
            this.Controls.Add(this.StartdateTimePicker);
            this.Controls.Add(this.CustmrcomboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.TypetBox);
            this.Controls.Add(this.TitletBox);
            this.Controls.Add(this.Endlabel);
            this.Controls.Add(this.Strtlabel);
            this.Controls.Add(this.CustLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label CustLabel;
		private System.Windows.Forms.Label Strtlabel;
		private System.Windows.Forms.Label Endlabel;
		private System.Windows.Forms.TextBox TitletBox;
		private System.Windows.Forms.TextBox TypetBox;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ComboBox CustmrcomboBox;
		private System.Windows.Forms.DateTimePicker StartdateTimePicker;
		private System.Windows.Forms.DateTimePicker EnddateTimePicker;
	}
}