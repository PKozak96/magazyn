namespace WypozyczalniaAut
{
    partial class Wypozyczenia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KwotaTb = new System.Windows.Forms.TextBox();
            this.NazwaTb = new System.Windows.Forms.TextBox();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdAutaCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CustCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 73);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1072, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(452, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wypożyczenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "WYPOŻYCZALNIA SAMOCHODÓW";
            // 
            // KwotaTb
            // 
            this.KwotaTb.Location = new System.Drawing.Point(248, 420);
            this.KwotaTb.Name = "KwotaTb";
            this.KwotaTb.Size = new System.Drawing.Size(207, 22);
            this.KwotaTb.TabIndex = 75;
            // 
            // NazwaTb
            // 
            this.NazwaTb.Enabled = false;
            this.NazwaTb.Location = new System.Drawing.Point(248, 281);
            this.NazwaTb.Name = "NazwaTb";
            this.NazwaTb.Size = new System.Drawing.Size(207, 22);
            this.NazwaTb.TabIndex = 73;
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(248, 151);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(207, 22);
            this.IdTb.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(26, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "Opłata";
            // 
            // RentDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentDGV.BackgroundColor = System.Drawing.Color.White;
            this.RentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RentDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RentDGV.ColumnHeadersHeight = 22;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.RentDGV.EnableHeadersVisualStyles = false;
            this.RentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentDGV.Location = new System.Drawing.Point(479, 152);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersVisible = false;
            this.RentDGV.RowTemplate.Height = 24;
            this.RentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentDGV.Size = new System.Drawing.Size(602, 444);
            this.RentDGV.TabIndex = 70;
            this.RentDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RentDGV.ThemeStyle.HeaderStyle.Height = 22;
            this.RentDGV.ThemeStyle.ReadOnly = false;
            this.RentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RentDGV.ThemeStyle.RowsStyle.Height = 24;
            this.RentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(169, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 38);
            this.button3.TabIndex = 69;
            this.button3.Text = "COFNIJ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(278, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 38);
            this.button4.TabIndex = 68;
            this.button4.Text = "USUŃ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(169, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 38);
            this.button2.TabIndex = 67;
            this.button2.Text = "EDYTUJ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(66, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 66;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Id wypożyczenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Imię i nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(671, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "Wypożyczenia";
            // 
            // IdAutaCb
            // 
            this.IdAutaCb.FormattingEnabled = true;
            this.IdAutaCb.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.IdAutaCb.Location = new System.Drawing.Point(248, 192);
            this.IdAutaCb.Name = "IdAutaCb";
            this.IdAutaCb.Size = new System.Drawing.Size(207, 24);
            this.IdAutaCb.TabIndex = 76;
            this.IdAutaCb.SelectionChangeCommitted += new System.EventHandler(this.IdAutaCb_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(26, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 29);
            this.label9.TabIndex = 77;
            this.label9.Text = "Id auta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(26, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 29);
            this.label10.TabIndex = 78;
            this.label10.Text = "Data wynajmu";
            // 
            // RentDate
            // 
            this.RentDate.BackColor = System.Drawing.Color.Transparent;
            this.RentDate.CheckedState.Parent = this.RentDate;
            this.RentDate.FillColor = System.Drawing.Color.LightSeaGreen;
            this.RentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RentDate.HoverState.Parent = this.RentDate;
            this.RentDate.Location = new System.Drawing.Point(248, 323);
            this.RentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RentDate.Name = "RentDate";
            this.RentDate.ShadowDecoration.Parent = this.RentDate;
            this.RentDate.Size = new System.Drawing.Size(207, 36);
            this.RentDate.TabIndex = 79;
            this.RentDate.Value = new System.DateTime(2021, 5, 20, 1, 4, 10, 628);
            this.RentDate.ValueChanged += new System.EventHandler(this.RentDate_ValueChanged);
            // 
            // ReturnDate
            // 
            this.ReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.ReturnDate.CheckedState.Parent = this.ReturnDate;
            this.ReturnDate.FillColor = System.Drawing.Color.LightSeaGreen;
            this.ReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.HoverState.Parent = this.ReturnDate;
            this.ReturnDate.Location = new System.Drawing.Point(248, 365);
            this.ReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ShadowDecoration.Parent = this.ReturnDate;
            this.ReturnDate.Size = new System.Drawing.Size(207, 36);
            this.ReturnDate.TabIndex = 81;
            this.ReturnDate.Value = new System.DateTime(2021, 5, 20, 1, 4, 10, 628);
            this.ReturnDate.ValueChanged += new System.EventHandler(this.ReturnDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(26, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 80;
            this.label7.Text = "Data zwrotu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(26, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 29);
            this.label11.TabIndex = 82;
            this.label11.Text = "Id klienta";
            // 
            // CustCb
            // 
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.CustCb.Location = new System.Drawing.Point(248, 240);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(207, 24);
            this.CustCb.TabIndex = 83;
            this.CustCb.SelectionChangeCommitted += new System.EventHandler(this.CustCb_SelectionChangeCommitted);
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 608);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IdAutaCb);
            this.Controls.Add(this.KwotaTb);
            this.Controls.Add(this.NazwaTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wypozyczenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypozyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KwotaTb;
        private System.Windows.Forms.TextBox NazwaTb;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView RentDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox IdAutaCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker RentDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CustCb;
    }
}