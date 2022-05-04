namespace rent
{
    partial class vehicle_category
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
            this.btnins = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtser = new System.Windows.Forms.TextBox();
            this.txtdel = new System.Windows.Forms.TextBox();
            this.txtdis = new System.Windows.Forms.RichTextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnins
            // 
            this.btnins.Location = new System.Drawing.Point(14, 3);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(95, 39);
            this.btnins.TabIndex = 0;
            this.btnins.Text = "INSERT";
            this.btnins.UseVisualStyleBackColor = true;
            this.btnins.Click += new System.EventHandler(this.btnins_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(14, 48);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(95, 42);
            this.btnup.TabIndex = 1;
            this.btnup.Text = "UPDATE";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(14, 144);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(95, 42);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(14, 96);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(95, 42);
            this.btndel.TabIndex = 3;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btndis);
            this.panel1.Controls.Add(this.btnins);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnup);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(542, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 246);
            this.panel1.TabIndex = 4;
            // 
            // btndis
            // 
            this.btndis.Location = new System.Drawing.Point(14, 192);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(95, 42);
            this.btndis.TabIndex = 4;
            this.btndis.Text = "DISPLAY";
            this.btndis.UseVisualStyleBackColor = true;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtser);
            this.panel2.Controls.Add(this.txtdel);
            this.panel2.Controls.Add(this.txtdis);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.txtcid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 246);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SEARCH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "DELETE";
            // 
            // txtser
            // 
            this.txtser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtser.Location = new System.Drawing.Point(367, 205);
            this.txtser.Name = "txtser";
            this.txtser.Size = new System.Drawing.Size(98, 22);
            this.txtser.TabIndex = 7;
            // 
            // txtdel
            // 
            this.txtdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdel.Location = new System.Drawing.Point(132, 205);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(91, 22);
            this.txtdel.TabIndex = 6;
            // 
            // txtdis
            // 
            this.txtdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdis.Location = new System.Drawing.Point(153, 93);
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(338, 80);
            this.txtdis.TabIndex = 5;
            this.txtdis.Text = "";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(153, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(141, 21);
            this.txtname.TabIndex = 4;
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(153, 24);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(141, 21);
            this.txtcid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CATEGORY NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DISCRIPTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORY ID";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 264);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(659, 175);
            this.dgv1.TabIndex = 6;
            // 
            // vehicle_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 440);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "vehicle_category";
            this.Text = "vehicle_category";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtdis;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtser;
        private System.Windows.Forms.TextBox txtdel;
    }
}