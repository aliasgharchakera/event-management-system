
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Upcoming = new System.Windows.Forms.CheckBox();
            this.checkBox_past = new System.Windows.Forms.CheckBox();
            this.checkbox_open = new System.Windows.Forms.CheckBox();
            this.checkBox_student_only = new System.Windows.Forms.CheckBox();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EventView_datagrid = new System.Windows.Forms.DataGridView();
            this.EvenName_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_organizer = new System.Windows.Forms.ComboBox();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_budget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventView_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Upcoming
            // 
            this.Upcoming.AutoSize = true;
            this.Upcoming.Location = new System.Drawing.Point(219, 229);
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
            this.checkBox_past.Location = new System.Drawing.Point(219, 253);
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
            this.checkbox_open.Location = new System.Drawing.Point(219, 276);
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
            this.checkBox_student_only.Location = new System.Drawing.Point(219, 296);
            this.checkBox_student_only.Name = "checkBox_student_only";
            this.checkBox_student_only.Size = new System.Drawing.Size(85, 17);
            this.checkBox_student_only.TabIndex = 9;
            this.checkBox_student_only.Text = "Student only";
            this.checkBox_student_only.UseVisualStyleBackColor = true;
            this.checkBox_student_only.CheckedChanged += new System.EventHandler(this.checkBox_student_only_CheckedChanged);
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.monthCalendar1);
            this.groupBox_filter.Controls.Add(this.label4);
            this.groupBox_filter.Controls.Add(this.label3);
            this.groupBox_filter.Controls.Add(this.label2);
            this.groupBox_filter.Controls.Add(this.label1);
            this.groupBox_filter.Controls.Add(this.comboBox_budget);
            this.groupBox_filter.Controls.Add(this.comboBox_category);
            this.groupBox_filter.Controls.Add(this.comboBox_location);
            this.groupBox_filter.Controls.Add(this.comboBox_organizer);
            this.groupBox_filter.Controls.Add(this.checkBox_student_only);
            this.groupBox_filter.Controls.Add(this.Upcoming);
            this.groupBox_filter.Controls.Add(this.checkbox_open);
            this.groupBox_filter.Controls.Add(this.checkBox_past);
            this.groupBox_filter.Location = new System.Drawing.Point(573, 12);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(335, 413);
            this.groupBox_filter.TabIndex = 10;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Filter";
            this.groupBox_filter.Enter += new System.EventHandler(this.groupBox_filter_Enter);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventView_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.EventView_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventView_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvenName_1,
            this.DateTime,
            this.Location,
            this.Organizer,
            this.Category});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventView_datagrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.EventView_datagrid.Location = new System.Drawing.Point(12, 12);
            this.EventView_datagrid.Name = "EventView_datagrid";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventView_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.EventView_datagrid.Size = new System.Drawing.Size(544, 442);
            this.EventView_datagrid.TabIndex = 15;
            this.EventView_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventView_datagrid_CellContentClick);
            // 
            // EvenName_1
            // 
            this.EvenName_1.HeaderText = "EventName";
            this.EvenName_1.Name = "EvenName_1";
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Datetime";
            this.DateTime.Name = "DateTime";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Organizer
            // 
            this.Organizer.HeaderText = "Organizer";
            this.Organizer.Name = "Organizer";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(847, 431);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 16;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(766, 431);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_organizer
            // 
            this.comboBox_organizer.FormattingEnabled = true;
            this.comboBox_organizer.Location = new System.Drawing.Point(63, 325);
            this.comboBox_organizer.Name = "comboBox_organizer";
            this.comboBox_organizer.Size = new System.Drawing.Size(121, 21);
            this.comboBox_organizer.TabIndex = 10;
            // 
            // comboBox_location
            // 
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Location = new System.Drawing.Point(63, 227);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(121, 21);
            this.comboBox_location.TabIndex = 11;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(63, 275);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 12;
            // 
            // comboBox_budget
            // 
            this.comboBox_budget.FormattingEnabled = true;
            this.comboBox_budget.Location = new System.Drawing.Point(63, 370);
            this.comboBox_budget.Name = "comboBox_budget";
            this.comboBox_budget.Size = new System.Drawing.Size(121, 21);
            this.comboBox_budget.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Organizer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Budget:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_budget;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.ComboBox comboBox_organizer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}