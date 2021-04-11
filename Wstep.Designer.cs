namespace WypozyczalniaAut
{
    partial class Wstep
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wstep));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Mycar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Percentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).BeginInit();
            this.Myprogress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(204, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wypożyczalnia samochodów";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // Mycar
            // 
            this.Mycar.FillColor = System.Drawing.Color.Transparent;
            this.Mycar.Image = ((System.Drawing.Image)(resources.GetObject("Mycar.Image")));
            this.Mycar.Location = new System.Drawing.Point(49, 56);
            this.Mycar.Name = "Mycar";
            this.Mycar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Mycar.ShadowDecoration.Parent = this.Mycar;
            this.Mycar.Size = new System.Drawing.Size(227, 158);
            this.Mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mycar.TabIndex = 3;
            this.Mycar.TabStop = false;
            // 
            // Myprogress
            // 
            this.Myprogress.Controls.Add(this.Percentage);
            this.Myprogress.Controls.Add(this.Mycar);
            this.Myprogress.FillColor = System.Drawing.Color.Silver;
            this.Myprogress.FillThickness = 8;
            this.Myprogress.Location = new System.Drawing.Point(184, 93);
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressThickness = 8;
            this.Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Myprogress.ShadowDecoration.Parent = this.Myprogress;
            this.Myprogress.Size = new System.Drawing.Size(327, 288);
            this.Myprogress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(206, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wykonali: Konrad Gaworowski, Piotr Kozak";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Percentage.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Percentage.Location = new System.Drawing.Point(149, 228);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(18, 16);
            this.Percentage.TabIndex = 6;
            this.Percentage.Text = "%";
            // 
            // Wstep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wstep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).EndInit();
            this.Myprogress.ResumeLayout(false);
            this.Myprogress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Mycar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Percentage;
    }
}

