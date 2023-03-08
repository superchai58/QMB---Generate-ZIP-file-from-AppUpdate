namespace ExportZipFileFromByte
{
    partial class frmGenZip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbZipName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenZip = new System.Windows.Forms.Button();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBU = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.dgvZipfile = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZipfile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbZipName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGenZip);
            this.groupBox1.Controls.Add(this.cboProgram);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboBU);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROL";
            // 
            // lbZipName
            // 
            this.lbZipName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZipName.Location = new System.Drawing.Point(104, 119);
            this.lbZipName.Name = "lbZipName";
            this.lbZipName.Size = new System.Drawing.Size(422, 19);
            this.lbZipName.TabIndex = 6;
            this.lbZipName.Text = "000000000000000000000000000000000000000000\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ZipName";
            // 
            // btnGenZip
            // 
            this.btnGenZip.BackColor = System.Drawing.Color.Blue;
            this.btnGenZip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenZip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenZip.Location = new System.Drawing.Point(409, 41);
            this.btnGenZip.Name = "btnGenZip";
            this.btnGenZip.Size = new System.Drawing.Size(117, 65);
            this.btnGenZip.TabIndex = 4;
            this.btnGenZip.Text = "Gen Zip File";
            this.btnGenZip.UseVisualStyleBackColor = false;
            this.btnGenZip.Click += new System.EventHandler(this.btnGenZip_Click);
            // 
            // cboProgram
            // 
            this.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgram.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Location = new System.Drawing.Point(108, 79);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(295, 27);
            this.cboProgram.TabIndex = 2;
            this.cboProgram.SelectedIndexChanged += new System.EventHandler(this.cboProgram_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program";
            // 
            // cboBU
            // 
            this.cboBU.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBU.FormattingEnabled = true;
            this.cboBU.Location = new System.Drawing.Point(108, 41);
            this.cboBU.Name = "cboBU";
            this.cboBU.Size = new System.Drawing.Size(295, 27);
            this.cboBU.TabIndex = 1;
            this.cboBU.SelectedIndexChanged += new System.EventHandler(this.cboBU_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULT";
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(34, 39);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(492, 46);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "0000\r\n";
            // 
            // dgvZipfile
            // 
            this.dgvZipfile.AllowUserToAddRows = false;
            this.dgvZipfile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZipfile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZipfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZipfile.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvZipfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZipfile.Location = new System.Drawing.Point(0, 154);
            this.dgvZipfile.Name = "dgvZipfile";
            this.dgvZipfile.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZipfile.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvZipfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZipfile.Size = new System.Drawing.Size(579, 339);
            this.dgvZipfile.TabIndex = 3;
            this.dgvZipfile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZipfile_CellDoubleClick);
            // 
            // frmGenZip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(579, 597);
            this.Controls.Add(this.dgvZipfile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenZip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create ZIP file from AppUpdate [20220615]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZipfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenZip;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.DataGridView dgvZipfile;
        private System.Windows.Forms.Label lbZipName;
        private System.Windows.Forms.Label label3;
    }
}

