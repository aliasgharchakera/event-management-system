
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox_events = new System.Windows.Forms.ListBox();
            this.checkBox_upcoming = new System.Windows.Forms.CheckBox();
            this.checkBox_past = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(788, 393);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(27, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // listBox_events
            // 
            this.listBox_events.FormattingEnabled = true;
            this.listBox_events.Location = new System.Drawing.Point(79, 126);
            this.listBox_events.Name = "listBox_events";
            this.listBox_events.Size = new System.Drawing.Size(226, 329);
            this.listBox_events.TabIndex = 5;
            // 
            // checkBox_upcoming
            // 
            this.checkBox_upcoming.AutoSize = true;
            this.checkBox_upcoming.Location = new System.Drawing.Point(636, 360);
            this.checkBox_upcoming.Name = "checkBox_upcoming";
            this.checkBox_upcoming.Size = new System.Drawing.Size(74, 17);
            this.checkBox_upcoming.TabIndex = 6;
            this.checkBox_upcoming.Text = "Upcoming";
            this.checkBox_upcoming.UseVisualStyleBackColor = true;
            // 
            // checkBox_past
            // 
            this.checkBox_past.AutoSize = true;
            this.checkBox_past.Location = new System.Drawing.Point(636, 384);
            this.checkBox_past.Name = "checkBox_past";
            this.checkBox_past.Size = new System.Drawing.Size(68, 17);
            this.checkBox_past.TabIndex = 7;
            this.checkBox_past.Text = "Upcomin";
            this.checkBox_past.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(636, 407);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(636, 427);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(636, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(636, 142);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(636, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(556, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Event_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox_past);
            this.Controls.Add(this.checkBox_upcoming);
            this.Controls.Add(this.listBox_events);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Event_Viewer";
            this.Text = "Event_Viewer";
            this.Load += new System.EventHandler(this.Event_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox_events;
        private System.Windows.Forms.CheckBox checkBox_upcoming;
        private System.Windows.Forms.CheckBox checkBox_past;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}