
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
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.textBox_budget = new System.Windows.Forms.TextBox();
            this.textBox_org = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.griupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox_generaldetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_generaldetails
            // 
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
            this.groupBox_generaldetails.Size = new System.Drawing.Size(319, 122);
            this.groupBox_generaldetails.TabIndex = 0;
            this.groupBox_generaldetails.TabStop = false;
            this.groupBox_generaldetails.Text = "General Details";
            // 
            // comboBox_location
            // 
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Location = new System.Drawing.Point(85, 95);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(121, 21);
            this.comboBox_location.TabIndex = 7;
            // 
            // textBox_budget
            // 
            this.textBox_budget.Location = new System.Drawing.Point(85, 73);
            this.textBox_budget.Name = "textBox_budget";
            this.textBox_budget.Size = new System.Drawing.Size(121, 20);
            this.textBox_budget.TabIndex = 6;
            // 
            // textBox_org
            // 
            this.textBox_org.Location = new System.Drawing.Point(85, 51);
            this.textBox_org.Name = "textBox_org";
            this.textBox_org.Size = new System.Drawing.Size(121, 20);
            this.textBox_org.TabIndex = 5;
            this.textBox_org.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(85, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(121, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Budget: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organizer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // griupBox
            // 
            this.griupBox.Location = new System.Drawing.Point(12, 167);
            this.griupBox.Name = "griupBox";
            this.griupBox.Size = new System.Drawing.Size(319, 63);
            this.griupBox.TabIndex = 1;
            this.griupBox.TabStop = false;
            this.griupBox.Text = "General Details";
            this.griupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 152);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Details";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(540, 515);
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
            this.button_cancel.Location = new System.Drawing.Point(450, 515);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 593);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.griupBox);
            this.Controls.Add(this.groupBox_generaldetails);
            this.Name = "Register_form";
            this.Text = "Register_form";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.groupBox_generaldetails.ResumeLayout(false);
            this.groupBox_generaldetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_generaldetails;
        private System.Windows.Forms.GroupBox griupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
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
    }
}