namespace PFF_Projet
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.monProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Le Meilleur";
            // 
            // monProgressBar
            // 
            this.monProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.monProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monProgressBar.ForeColor = System.Drawing.Color.White;
            this.monProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.monProgressBar.Location = new System.Drawing.Point(321, 132);
            this.monProgressBar.Minimum = 0;
            this.monProgressBar.Name = "monProgressBar";
            this.monProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.monProgressBar.ShadowDecoration.Parent = this.monProgressBar;
            this.monProgressBar.Size = new System.Drawing.Size(232, 232);
            this.monProgressBar.TabIndex = 3;
            this.monProgressBar.Text = "guna2CircleProgressBar1";
            this.monProgressBar.UseTransparentBackground = true;
            this.monProgressBar.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "SYSTEM DE MANAGEMENT DU SUPER MARCHE";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(867, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monProgressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar monProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}