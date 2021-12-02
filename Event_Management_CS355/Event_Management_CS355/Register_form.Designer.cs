
namespace Event_Management_CS355
{
    partial class Register_form
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
            this.groupBox_generaldetails = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_eventTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_eventDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.textBox_budget = new System.Windows.Forms.TextBox();
            this.textBox_org = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_addVendors = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedListBox_inventory = new System.Windows.Forms.CheckedListBox();
            this.checkBox_online = new System.Windows.Forms.CheckBox();
            this.listBox_vendors = new System.Windows.Forms.ListBox();
            this.listBox_sponsors = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_generaldetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_generaldetails
            // 
            this.groupBox_generaldetails.Controls.Add(this.checkBox_online);
            this.groupBox_generaldetails.Controls.Add(this.label9);
            this.groupBox_generaldetails.Controls.Add(this.label7);
            this.groupBox_generaldetails.Controls.Add(this.label6);
            this.groupBox_generaldetails.Controls.Add(this.label5);
            this.groupBox_generaldetails.Controls.Add(this.comboBox1);
            this.groupBox_generaldetails.Controls.Add(this.dateTimePicker_eventTime);
            this.groupBox_generaldetails.Controls.Add(this.dateTimePicker_eventDate);
            this.groupBox_generaldetails.Controls.Add(this.textBox1);
            this.groupBox_generaldetails.Controls.Add(this.comboBox_location);
            this.groupBox_generaldetails.Controls.Add(this.textBox_budget);
            this.groupBox_generaldetails.Controls.Add(this.textBox_org);
            this.groupBox_generaldetails.Controls.Add(this.textBox_name);
            this.groupBox_generaldetails.Controls.Add(this.label4);
            this.groupBox_generaldetails.Controls.Add(this.label3);
            this.groupBox_generaldetails.Controls.Add(this.label2);
            this.groupBox_generaldetails.Controls.Add(this.label1);
            this.groupBox_generaldetails.Location = new System.Drawing.Point(12, 21);
            this.groupBox_generaldetails.Name = "groupBox_generaldetails";
            this.groupBox_generaldetails.Size = new System.Drawing.Size(319, 323);
            this.groupBox_generaldetails.TabIndex = 0;
            this.groupBox_generaldetails.TabStop = false;
            this.groupBox_generaldetails.Text = "General Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Club:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sponsors:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Duration (hrs):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // dateTimePicker_eventTime
            // 
            this.dateTimePicker_eventTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker_eventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_eventTime.Location = new System.Drawing.Point(85, 167);
            this.dateTimePicker_eventTime.Name = "dateTimePicker_eventTime";
            this.dateTimePicker_eventTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_eventTime.TabIndex = 11;
            // 
            // dateTimePicker_eventDate
            // 
            this.dateTimePicker_eventDate.Location = new System.Drawing.Point(85, 140);
            this.dateTimePicker_eventDate.Name = "dateTimePicker_eventDate";
            this.dateTimePicker_eventDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_eventDate.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox_location
            // 
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Location = new System.Drawing.Point(85, 113);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(121, 21);
            this.comboBox_location.TabIndex = 7;
            // 
            // textBox_budget
            // 
            this.textBox_budget.Location = new System.Drawing.Point(85, 86);
            this.textBox_budget.Name = "textBox_budget";
            this.textBox_budget.Size = new System.Drawing.Size(121, 20);
            this.textBox_budget.TabIndex = 6;
            // 
            // textBox_org
            // 
            this.textBox_org.Location = new System.Drawing.Point(85, 59);
            this.textBox_org.Name = "textBox_org";
            this.textBox_org.Size = new System.Drawing.Size(121, 20);
            this.textBox_org.TabIndex = 5;
            this.textBox_org.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(85, 32);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(121, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Budget: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organizer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(256, 541);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_cancel.Location = new System.Drawing.Point(175, 541);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_sponsors);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox_vendors);
            this.groupBox1.Controls.Add(this.button_addVendors);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkedListBox_inventory);
            this.groupBox1.Location = new System.Drawing.Point(12, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Others";
            // 
            // button_addVendors
            // 
            this.button_addVendors.Location = new System.Drawing.Point(61, 89);
            this.button_addVendors.Name = "button_addVendors";
            this.button_addVendors.Size = new System.Drawing.Size(89, 23);
            this.button_addVendors.TabIndex = 22;
            this.button_addVendors.Text = "Add Vendors";
            this.button_addVendors.UseVisualStyleBackColor = true;
            this.button_addVendors.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Vendors:";
            // 
            // checkedListBox_inventory
            // 
            this.checkedListBox_inventory.FormattingEnabled = true;
            this.checkedListBox_inventory.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox_inventory.Name = "checkedListBox_inventory";
            this.checkedListBox_inventory.Size = new System.Drawing.Size(307, 64);
            this.checkedListBox_inventory.TabIndex = 16;
            // 
            // checkBox_online
            // 
            this.checkBox_online.AutoSize = true;
            this.checkBox_online.Location = new System.Drawing.Point(9, 283);
            this.checkBox_online.Name = "checkBox_online";
            this.checkBox_online.Size = new System.Drawing.Size(56, 17);
            this.checkBox_online.TabIndex = 23;
            this.checkBox_online.Text = "Online";
            this.checkBox_online.UseVisualStyleBackColor = true;
            // 
            // listBox_vendors
            // 
            this.listBox_vendors.FormattingEnabled = true;
            this.listBox_vendors.Location = new System.Drawing.Point(61, 118);
            this.listBox_vendors.Name = "listBox_vendors";
            this.listBox_vendors.Size = new System.Drawing.Size(89, 43);
            this.listBox_vendors.TabIndex = 23;
            // 
            // listBox_sponsors
            // 
            this.listBox_sponsors.FormattingEnabled = true;
            this.listBox_sponsors.Location = new System.Drawing.Point(214, 118);
            this.listBox_sponsors.Name = "listBox_sponsors";
            this.listBox_sponsors.Size = new System.Drawing.Size(89, 43);
            this.listBox_sponsors.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Sponsors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox_generaldetails);
            this.Name = "Register_form";
            this.Text = "Register_form";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.groupBox_generaldetails.ResumeLayout(false);
            this.groupBox_generaldetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_generaldetails;
        private System.Windows.Forms.TextBox textBox_org;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.TextBox textBox_budget;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_eventTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_eventDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox_inventory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_addVendors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_online;
        private System.Windows.Forms.ListBox listBox_vendors;
        private System.Windows.Forms.ListBox listBox_sponsors;
        private System.Windows.Forms.Button button1;
    }
}