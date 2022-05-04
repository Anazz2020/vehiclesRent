namespace rent
{
    partial class CarManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlside = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtdeleteandsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimemfd = new System.Windows.Forms.DateTimePicker();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.txtdeilyprice = new System.Windows.Forms.TextBox();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.txtinsurance = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtcarname = new System.Windows.Forms.TextBox();
            this.txtcarid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btndeleteandsearchside = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlside.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlside);
            this.panel1.Controls.Add(this.datetimemfd);
            this.panel1.Controls.Add(this.cmbcategory);
            this.panel1.Controls.Add(this.txtdeilyprice);
            this.panel1.Controls.Add(this.txtregno);
            this.panel1.Controls.Add(this.txtinsurance);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.txtcarname);
            this.panel1.Controls.Add(this.txtcarid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 238);
            this.panel1.TabIndex = 0;
            // 
            // pnlside
            // 
            this.pnlside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlside.Controls.Add(this.btncancel);
            this.pnlside.Controls.Add(this.btnsearch);
            this.pnlside.Controls.Add(this.btndelete);
            this.pnlside.Controls.Add(this.txtdeleteandsearch);
            this.pnlside.Controls.Add(this.label5);
            this.pnlside.Location = new System.Drawing.Point(794, 14);
            this.pnlside.Name = "pnlside";
            this.pnlside.Size = new System.Drawing.Size(266, 208);
            this.pnlside.TabIndex = 17;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(185, 157);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(76, 29);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "CANCAL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(94, 157);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(76, 29);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(3, 157);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(76, 29);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtdeleteandsearch
            // 
            this.txtdeleteandsearch.Location = new System.Drawing.Point(118, 84);
            this.txtdeleteandsearch.Name = "txtdeleteandsearch";
            this.txtdeleteandsearch.Size = new System.Drawing.Size(94, 20);
            this.txtdeleteandsearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ENTER CAR ID";
            // 
            // datetimemfd
            // 
            this.datetimemfd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimemfd.Location = new System.Drawing.Point(584, 30);
            this.datetimemfd.Name = "datetimemfd";
            this.datetimemfd.Size = new System.Drawing.Size(187, 20);
            this.datetimemfd.TabIndex = 16;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(142, 141);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(186, 21);
            this.cmbcategory.TabIndex = 15;
            // 
            // txtdeilyprice
            // 
            this.txtdeilyprice.Location = new System.Drawing.Point(584, 203);
            this.txtdeilyprice.Name = "txtdeilyprice";
            this.txtdeilyprice.Size = new System.Drawing.Size(187, 20);
            this.txtdeilyprice.TabIndex = 14;
            // 
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(584, 143);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(187, 20);
            this.txtregno.TabIndex = 13;
            // 
            // txtinsurance
            // 
            this.txtinsurance.Location = new System.Drawing.Point(584, 83);
            this.txtinsurance.Name = "txtinsurance";
            this.txtinsurance.Size = new System.Drawing.Size(187, 20);
            this.txtinsurance.TabIndex = 12;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(142, 203);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(187, 20);
            this.txtcolor.TabIndex = 11;
            // 
            // txtcarname
            // 
            this.txtcarname.Location = new System.Drawing.Point(142, 86);
            this.txtcarname.Name = "txtcarname";
            this.txtcarname.Size = new System.Drawing.Size(187, 20);
            this.txtcarname.TabIndex = 10;
            // 
            // txtcarid
            // 
            this.txtcarid.Location = new System.Drawing.Point(142, 30);
            this.txtcarid.Name = "txtcarid";
            this.txtcarid.Size = new System.Drawing.Size(187, 20);
            this.txtcarid.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "CATEGORY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = " PRICE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "COLOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "REG NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "INSURANCE NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MFD DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAR ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR NAME";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnhome);
            this.panel2.Controls.Add(this.btndisplay);
            this.panel2.Controls.Add(this.btndeleteandsearchside);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btninsert);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 89);
            this.panel2.TabIndex = 1;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(743, 19);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(103, 38);
            this.btndisplay.TabIndex = 4;
            this.btndisplay.Text = "DISPLAY";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btndeleteandsearchside
            // 
            this.btndeleteandsearchside.Location = new System.Drawing.Point(407, 19);
            this.btndeleteandsearchside.Name = "btndeleteandsearchside";
            this.btndeleteandsearchside.Size = new System.Drawing.Size(265, 38);
            this.btndeleteandsearchside.TabIndex = 2;
            this.btndeleteandsearchside.Text = "DELETE & SEARCH SIDE";
            this.btndeleteandsearchside.UseVisualStyleBackColor = true;
            this.btndeleteandsearchside.Click += new System.EventHandler(this.btndeleteandsearchside_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(237, 19);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 38);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(33, 19);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(103, 38);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(12, 347);
            this.dgv4.Name = "dgv4";
            this.dgv4.Size = new System.Drawing.Size(1086, 287);
            this.dgv4.TabIndex = 2;
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(928, 19);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(103, 38);
            this.btnhome.TabIndex = 5;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // CarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 644);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarManagement";
            this.Text = "CarManagement";
            this.Load += new System.EventHandler(this.CarManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlside.ResumeLayout(false);
            this.pnlside.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlside;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtdeleteandsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetimemfd;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.TextBox txtdeilyprice;
        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.TextBox txtinsurance;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtcarname;
        private System.Windows.Forms.TextBox txtcarid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btndeleteandsearchside;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.Button btnhome;
    }
}