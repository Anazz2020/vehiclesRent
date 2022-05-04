namespace rent
{
    partial class DealSettlement
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
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeal = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndis = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdel = new System.Windows.Forms.TextBox();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.btnno);
            this.pnl2.Controls.Add(this.btnyes);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Location = new System.Drawing.Point(12, 212);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(341, 178);
            this.pnl2.TabIndex = 0;
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(190, 117);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(95, 30);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(37, 117);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(95, 30);
            this.btnyes.TabIndex = 1;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Are you sure";
            // 
            // cmbcus
            // 
            this.cmbcus.FormattingEnabled = true;
            this.cmbcus.Location = new System.Drawing.Point(166, 39);
            this.cmbcus.Name = "cmbcus";
            this.cmbcus.Size = new System.Drawing.Size(142, 21);
            this.cmbcus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMER";
            // 
            // btndeal
            // 
            this.btndeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeal.Location = new System.Drawing.Point(93, 126);
            this.btndeal.Name = "btndeal";
            this.btndeal.Size = new System.Drawing.Size(129, 35);
            this.btndeal.TabIndex = 2;
            this.btndeal.Text = "Deal Settlement";
            this.btndeal.UseVisualStyleBackColor = true;
            this.btndeal.Click += new System.EventHandler(this.btndeal_Click);
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.btndeal);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.cmbcus);
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(341, 194);
            this.pnl1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 315);
            this.dataGridView1.TabIndex = 4;
            // 
            // btndis
            // 
            this.btndis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndis.Location = new System.Drawing.Point(367, 12);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(123, 55);
            this.btndis.TabIndex = 5;
            this.btndis.Text = "RECORD SHOW";
            this.btndis.UseVisualStyleBackColor = true;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.Location = new System.Drawing.Point(716, 18);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(124, 43);
            this.btnDEL.TabIndex = 6;
            this.btnDEL.Text = "DELETE";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "enter the bookin id";
            // 
            // txtdel
            // 
            this.txtdel.Location = new System.Drawing.Point(619, 30);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(73, 20);
            this.txtdel.TabIndex = 8;
            // 
            // DealSettlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 472);
            this.Controls.Add(this.txtdel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Name = "DealSettlement";
            this.Text = "DealSettlement";
            this.Load += new System.EventHandler(this.DealSettlement_Load);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ComboBox cmbcus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeal;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdel;
    }
}