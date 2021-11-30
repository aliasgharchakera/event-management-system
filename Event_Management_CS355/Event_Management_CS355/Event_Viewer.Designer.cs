﻿
namespace Event_Management_CS355
{
    partial class Event_Viewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Upcoming = new System.Windows.Forms.CheckBox();
            this.checkBox_past = new System.Windows.Forms.CheckBox();
            this.checkbox_open = new System.Windows.Forms.CheckBox();
            this.checkBox_student_only = new System.Windows.Forms.CheckBox();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_maxBudget = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.comboBox_organizer = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EventView_datagrid = new System.Windows.Forms.DataGridView();
            this.EvenName_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventView_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Upcoming
            // 
            this.Upcoming.AutoSize = true;
            this.Upcoming.Location = new System.Drawing.Point(219, 274);
            this.Upcoming.Name = "Upcoming";
            this.Upcoming.Size = new System.Drawing.Size(74, 17);
            this.Upcoming.TabIndex = 6;
            this.Upcoming.Text = "Upcoming";
            this.Upcoming.UseVisualStyleBackColor = true;
            this.Upcoming.CheckedChanged += new System.EventHandler(this.Upcoming_CheckedChanged);
            // 
            // checkBox_past
            // 
            this.checkBox_past.AutoSize = true;
            this.checkBox_past.Location = new System.Drawing.Point(219, 297);
            this.checkBox_past.Name = "checkBox_past";
            this.checkBox_past.Size = new System.Drawing.Size(47, 17);
            this.checkBox_past.TabIndex = 7;
            this.checkBox_past.Text = "Past";
            this.checkBox_past.UseVisualStyleBackColor = true;
            this.checkBox_past.CheckedChanged += new System.EventHandler(this.checkBox_past_CheckedChanged);
            // 
            // checkbox_open
            // 
            this.checkbox_open.AutoSize = true;
            this.checkbox_open.Location = new System.Drawing.Point(219, 320);
            this.checkbox_open.Name = "checkbox_open";
            this.checkbox_open.Size = new System.Drawing.Size(94, 17);
            this.checkbox_open.TabIndex = 8;
            this.checkbox_open.Text = "Sign ups open";
            this.checkbox_open.UseVisualStyleBackColor = true;
            this.checkbox_open.CheckedChanged += new System.EventHandler(this.checkbox_open_CheckedChanged);
            // 
            // checkBox_student_only
            // 
            this.checkBox_student_only.AutoSize = true;
            this.checkBox_student_only.Location = new System.Drawing.Point(219, 343);
            this.checkBox_student_only.Name = "checkBox_student_only";
            this.checkBox_student_only.Size = new System.Drawing.Size(85, 17);
            this.checkBox_student_only.TabIndex = 9;
            this.checkBox_student_only.Text = "Student only";
            this.checkBox_student_only.UseVisualStyleBackColor = true;
            this.checkBox_student_only.CheckedChanged += new System.EventHandler(this.checkBox_student_only_CheckedChanged);
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.label12);
            this.groupBox_filter.Controls.Add(this.label11);
            this.groupBox_filter.Controls.Add(this.label10);
            this.groupBox_filter.Controls.Add(this.label9);
            this.groupBox_filter.Controls.Add(this.dateTimePicker3);
            this.groupBox_filter.Controls.Add(this.label8);
            this.groupBox_filter.Controls.Add(this.label7);
            this.groupBox_filter.Controls.Add(this.label4);
            this.groupBox_filter.Controls.Add(this.trackBar_maxBudget);
            this.groupBox_filter.Controls.Add(this.trackBar1);
            this.groupBox_filter.Controls.Add(this.label6);
            this.groupBox_filter.Controls.Add(this.label5);
            this.groupBox_filter.Controls.Add(this.dateTimePicker2);
            this.groupBox_filter.Controls.Add(this.dateTimePicker1);
            this.groupBox_filter.Controls.Add(this.label3);
            this.groupBox_filter.Controls.Add(this.label2);
            this.groupBox_filter.Controls.Add(this.label1);
            this.groupBox_filter.Controls.Add(this.comboBox_category);
            this.groupBox_filter.Controls.Add(this.comboBox_location);
            this.groupBox_filter.Controls.Add(this.comboBox_organizer);
            this.groupBox_filter.Controls.Add(this.checkBox_student_only);
            this.groupBox_filter.Controls.Add(this.Upcoming);
            this.groupBox_filter.Controls.Add(this.checkbox_open);
            this.groupBox_filter.Controls.Add(this.checkBox_past);
            this.groupBox_filter.Location = new System.Drawing.Point(573, 12);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(335, 371);
            this.groupBox_filter.TabIndex = 10;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Filter";
            this.groupBox_filter.Enter += new System.EventHandler(this.groupBox_filter_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Min Budget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Max Budget";
            // 
            // trackBar_maxBudget
            // 
            this.trackBar_maxBudget.AllowDrop = true;
            this.trackBar_maxBudget.Location = new System.Drawing.Point(125, 191);
            this.trackBar_maxBudget.Maximum = 50000;
            this.trackBar_maxBudget.Name = "trackBar_maxBudget";
            this.trackBar_maxBudget.Size = new System.Drawing.Size(179, 45);
            this.trackBar_maxBudget.TabIndex = 24;
            this.trackBar_maxBudget.Value = 20;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(125, 140);
            this.trackBar1.Maximum = 50000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 45);
            this.trackBar1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "EndDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "StartDate";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(63, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Organizer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Location:";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(63, 304);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 12;
            // 
            // comboBox_location
            // 
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Location = new System.Drawing.Point(63, 263);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(121, 21);
            this.comboBox_location.TabIndex = 11;
            // 
            // comboBox_organizer
            // 
            this.comboBox_organizer.FormattingEnabled = true;
            this.comboBox_organizer.Location = new System.Drawing.Point(63, 344);
            this.comboBox_organizer.Name = "comboBox_organizer";
            this.comboBox_organizer.Size = new System.Drawing.Size(121, 21);
            this.comboBox_organizer.TabIndex = 10;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 467);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // EventView_datagrid
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventView_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.EventView_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventView_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvenName_1,
            this.DateTime,
            this.Location,
            this.Organizer,
            this.Category});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventView_datagrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.EventView_datagrid.Location = new System.Drawing.Point(12, 12);
            this.EventView_datagrid.Name = "EventView_datagrid";
            this.EventView_datagrid.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventView_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.EventView_datagrid.Size = new System.Drawing.Size(544, 442);
            this.EventView_datagrid.TabIndex = 15;
            this.EventView_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventView_datagrid_CellContentClick);
            // 
            // EvenName_1
            // 
            this.EvenName_1.HeaderText = "EventName";
            this.EvenName_1.Name = "EvenName_1";
            this.EvenName_1.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Datetime";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Organizer
            // 
            this.Organizer.HeaderText = "Organizer";
            this.Organizer.Name = "Organizer";
            this.Organizer.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(833, 409);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 16;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(573, 409);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Start Time";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:MM";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(63, 86);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "50,000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "50,000";
            // 
            // Event_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 467);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.EventView_datagrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox_filter);
            this.Name = "Event_Viewer";
            this.Text = "Event_Viewer";
            this.Load += new System.EventHandler(this.Event_Viewer_Load);
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventView_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox Upcoming;
        private System.Windows.Forms.CheckBox checkBox_past;
        private System.Windows.Forms.CheckBox checkbox_open;
        private System.Windows.Forms.CheckBox checkBox_student_only;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView EventView_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvenName_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.ComboBox comboBox_organizer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_maxBudget;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}