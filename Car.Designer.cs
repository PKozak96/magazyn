namespace WypozyczalniaAut
{
    partial class Car
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CarsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.AvaiableCb = new System.Windows.Forms.ComboBox();
            this.RegNumTb = new System.Windows.Forms.TextBox();
            this.BrandTb = new System.Windows.Forms.TextBox();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Szukaj = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(924, 73);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(886, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(320, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zarządzanie samochodami";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "WYPOŻYCZALNIA SAMOCHODÓW";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(120, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 38);
            this.button3.TabIndex = 38;
            this.button3.Text = "COFNIJ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(221, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 38);
            this.button4.TabIndex = 37;
            this.button4.Text = "USUŃ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(120, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "EDYTUJ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(17, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID auta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(477, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lista samochodów";
            // 
            // CarsDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CarsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CarsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsDGV.BackgroundColor = System.Drawing.Color.White;
            this.CarsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CarsDGV.ColumnHeadersHeight = 22;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CarsDGV.EnableHeadersVisualStyles = false;
            this.CarsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsDGV.Location = new System.Drawing.Point(325, 169);
            this.CarsDGV.Name = "CarsDGV";
            this.CarsDGV.RowHeadersVisible = false;
            this.CarsDGV.RowTemplate.Height = 24;
            this.CarsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsDGV.Size = new System.Drawing.Size(587, 407);
            this.CarsDGV.TabIndex = 39;
            this.CarsDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CarsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CarsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CarsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CarsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CarsDGV.ThemeStyle.HeaderStyle.Height = 22;
            this.CarsDGV.ThemeStyle.ReadOnly = false;
            this.CarsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CarsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CarsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDGV_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cena";
            // 
            // AvaiableCb
            // 
            this.AvaiableCb.FormattingEnabled = true;
            this.AvaiableCb.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.AvaiableCb.Location = new System.Drawing.Point(142, 359);
            this.AvaiableCb.Name = "AvaiableCb";
            this.AvaiableCb.Size = new System.Drawing.Size(166, 24);
            this.AvaiableCb.TabIndex = 41;
            // 
            // RegNumTb
            // 
            this.RegNumTb.Location = new System.Drawing.Point(143, 170);
            this.RegNumTb.Name = "RegNumTb";
            this.RegNumTb.Size = new System.Drawing.Size(165, 22);
            this.RegNumTb.TabIndex = 42;
            // 
            // BrandTb
            // 
            this.BrandTb.Location = new System.Drawing.Point(142, 216);
            this.BrandTb.Name = "BrandTb";
            this.BrandTb.Size = new System.Drawing.Size(166, 22);
            this.BrandTb.TabIndex = 43;
            // 
            // ModelTb
            // 
            this.ModelTb.Location = new System.Drawing.Point(142, 264);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(166, 22);
            this.ModelTb.TabIndex = 44;
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(142, 313);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(166, 22);
            this.PriceTb.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 46;
            this.label9.Text = "Dostępny";
            // 
            // Szukaj
            // 
            this.Szukaj.FormattingEnabled = true;
            this.Szukaj.Items.AddRange(new object[] {
            "Dostępny",
            "Niedostępny"});
            this.Szukaj.Location = new System.Drawing.Point(433, 128);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(166, 24);
            this.Szukaj.TabIndex = 47;
            this.Szukaj.SelectionChangeCommitted += new System.EventHandler(this.Szukaj_SelectionChangeCommitted);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Location = new System.Drawing.Point(628, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 24);
            this.button5.TabIndex = 48;
            this.button5.Text = "ODŚWIEŻ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 577);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.BrandTb);
            this.Controls.Add(this.RegNumTb);
            this.Controls.Add(this.AvaiableCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CarsDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView CarsDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AvaiableCb;
        private System.Windows.Forms.TextBox RegNumTb;
        private System.Windows.Forms.TextBox BrandTb;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Szukaj;
        private System.Windows.Forms.Button button5;
    }
}