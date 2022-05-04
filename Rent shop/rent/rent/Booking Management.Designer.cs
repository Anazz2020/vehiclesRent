namespace rent
{
    partial class Booking_Management
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
            this.cmbcar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbcus = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rentdate = new System.Windows.Forms.DateTimePicker();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtbookinid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndis = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsearchside = new System.Windows.Forms.Button();
            this.btndeleteside = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtdel = new System.Windows.Forms.TextBox();
            this.txtser = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbcar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cmbcus);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.rentdate);
            this.panel1.Controls.Add(this.returndate);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.txtbookinid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 200);
            this.panel1.TabIndex = 0;
            // 
            // cmbcar
            // 
            this.cmbcar.FormattingEnabled = true;
            this.cmbcar.Location = new System.Drawing.Point(447, 80);
            this.cmbcar.Name = "cmbcar";
            this.cmbcar.Size = new System.Drawing.Size(121, 21);
            this.cmbcar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "CAR";
            // 
            // cmbcus
            // 
            this.cmbcus.FormattingEnabled = true;
            this.cmbcus.Location = new System.Drawing.Point(447, 16);
            this.cmbcus.Name = "cmbcus";
            this.cmbcus.Size = new System.Drawing.Size(121, 21);
            this.cmbcus.TabIndex = 12;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(364, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 11;
            // 
            // rentdate
            // 
            this.rentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentdate.Location = new System.Drawing.Point(165, 144);
            this.rentdate.Name = "rentdate";
            this.rentdate.Size = new System.Drawing.Size(118, 20);
            this.rentdate.TabIndex = 8;
            // 
            // returndate
            // 
            this.returndate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returndate.Location = new System.Drawing.Point(465, 144);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(118, 20);
            this.returndate.TabIndex = 7;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(165, 85);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(130, 20);
            this.txtamount.TabIndex = 6;
            // 
            // txtbookinid
            // 
            this.txtbookinid.Location = new System.Drawing.Point(165, 17);
            this.txtbookinid.Name = "txtbookinid";
            this.txtbookinid.Size = new System.Drawing.Size(130, 20);
            this.txtbookinid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CUSTOMER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL AMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RENT DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RETURN DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOKING ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndis);
            this.panel2.Controls.Add(this.btnup);
            this.panel2.Controls.Add(this.btnsearchside);
            this.panel2.Controls.Add(this.btndeleteside);
            this.panel2.Controls.Add(this.btninsert);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 66);
            this.panel2.TabIndex = 1;
            // 
            // btndis
            // 
            this.btndis.Location = new System.Drawing.Point(551, 16);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(164, 32);
            this.btndis.TabIndex = 4;
            this.btndis.Text = "DISPLAY";
            this.btndis.UseVisualStyleBackColor = true;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(131, 16);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(98, 32);
            this.btnup.TabIndex = 3;
            this.btnup.Text = "UPDATE";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnsearchside
            // 
            this.btnsearchside.Location = new System.Drawing.Point(407, 16);
            this.btnsearchside.Name = "btnsearchside";
            this.btnsearchside.Size = new System.Drawing.Size(112, 32);
            this.btnsearchside.TabIndex = 2;
            this.btnsearchside.Text = "SEARCH SIDE";
            this.btnsearchside.UseVisualStyleBackColor = true;
            this.btnsearchside.Click += new System.EventHandler(this.btnsearchside_Click);
            // 
            // btndeleteside
            // 
            this.btndeleteside.Location = new System.Drawing.Point(251, 16);
            this.btndeleteside.Name = "btndeleteside";
            this.btndeleteside.Size = new System.Drawing.Size(132, 32);
            this.btndeleteside.TabIndex = 1;
            this.btndeleteside.Text = "DELETE SIDE";
            this.btndeleteside.UseVisualStyleBackColor = true;
            this.btndeleteside.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(15, 16);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(98, 32);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(12, 301);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(843, 213);
            this.dgv3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "DELETE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "SEARCH";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(18, 116);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 28);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(97, 116);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(62, 28);
            this.btnsearch.TabIndex = 16;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(173, 116);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(62, 28);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtdel
            // 
            this.txtdel.Location = new System.Drawing.Point(113, 25);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(122, 20);
            this.txtdel.TabIndex = 18;
            this.txtdel.TextChanged += new System.EventHandler(this.txtdel_TextChanged);
            // 
            // txtser
            // 
            this.txtser.Location = new System.Drawing.Point(113, 63);
            this.txtser.Name = "txtser";
            this.txtser.Size = new System.Drawing.Size(122, 20);
            this.txtser.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtser);
            this.panel3.Controls.Add(this.txtdel);
            this.panel3.Controls.Add(this.btncancel);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(589, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 160);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Booking_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 526);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Booking_Management";
            this.Text = "Booking_Management";
            this.Load += new System.EventHandler(this.Booking_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker rentdate;
        private System.Windows.Forms.DateTimePicker returndate;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtbookinid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnsearchside;
        private System.Windows.Forms.Button btndeleteside;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmbcus;
        private System.Windows.Forms.ComboBox cmbcar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtser;
        private System.Windows.Forms.TextBox txtdel;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}