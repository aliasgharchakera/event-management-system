namespace CSSamples2005
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cboCustomerCode = new System.Windows.Forms.ComboBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chkShipped = new System.Windows.Forms.CheckBox();
            this.grdDetails = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ship Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ship Address:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(114, 19);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 5;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(114, 54);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 6;
            // 
            // cboCustomerCode
            // 
            this.cboCustomerCode.FormattingEnabled = true;
            this.cboCustomerCode.Location = new System.Drawing.Point(114, 84);
            this.cboCustomerCode.Name = "cboCustomerCode";
            this.cboCustomerCode.Size = new System.Drawing.Size(142, 21);
            this.cboCustomerCode.TabIndex = 7;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(114, 113);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(200, 20);
            this.txtShipName.TabIndex = 8;
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(114, 141);
            this.txtShipAddress.Multiline = true;
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(200, 60);
            this.txtShipAddress.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(239, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkShipped
            // 
            this.chkShipped.AutoSize = true;
            this.chkShipped.Location = new System.Drawing.Point(114, 208);
            this.chkShipped.Name = "chkShipped";
            this.chkShipped.Size = new System.Drawing.Size(65, 17);
            this.chkShipped.TabIndex = 11;
            this.chkShipped.Text = "Shipped";
            this.chkShipped.UseVisualStyleBackColor = true;
            // 
            // grdDetails
            // 
            this.grdDetails.AllowUserToAddRows = false;
            this.grdDetails.AllowUserToDeleteRows = false;
            this.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetails.Location = new System.Drawing.Point(12, 231);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.ReadOnly = true;
            this.grdDetails.Size = new System.Drawing.Size(450, 176);
            this.grdDetails.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(387, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(387, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.chkShipped);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtShipAddress);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.cboCustomerCode);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.ComboBox cboCustomerCode;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chkShipped;
        private System.Windows.Forms.DataGridView grdDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}

