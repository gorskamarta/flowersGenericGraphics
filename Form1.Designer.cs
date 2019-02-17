namespace GrafikaGenryczna
{
    partial class Form1
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
            this.Generuj = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generuj
            // 
            this.Generuj.Location = new System.Drawing.Point(942, 791);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(300, 150);
            this.Generuj.TabIndex = 0;
            this.Generuj.Text = "Płatki";
            this.Generuj.UseVisualStyleBackColor = true;
            this.Generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(628, 791);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(308, 150);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Nowy kwiat";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 953);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Generuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button Circle;
    }
}

