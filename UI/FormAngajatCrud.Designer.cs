namespace FormLog
{
    partial class FormAngajatCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAngajatCrud));
            this.butoncreareanunt = new System.Windows.Forms.Button();
            this.butonvizualizareanunt = new System.Windows.Forms.Button();
            this.butonstergere = new System.Windows.Forms.Button();
            this.butoneditare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butoncreareanunt
            // 
            this.butoncreareanunt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoncreareanunt.Location = new System.Drawing.Point(45, 48);
            this.butoncreareanunt.Name = "butoncreareanunt";
            this.butoncreareanunt.Size = new System.Drawing.Size(119, 41);
            this.butoncreareanunt.TabIndex = 0;
            this.butoncreareanunt.Text = "Creare Anunţ";
            this.butoncreareanunt.UseVisualStyleBackColor = true;
            this.butoncreareanunt.Click += new System.EventHandler(this.butoncreareanunt_Click);
            // 
            // butonvizualizareanunt
            // 
            this.butonvizualizareanunt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonvizualizareanunt.Location = new System.Drawing.Point(45, 106);
            this.butonvizualizareanunt.Name = "butonvizualizareanunt";
            this.butonvizualizareanunt.Size = new System.Drawing.Size(119, 41);
            this.butonvizualizareanunt.TabIndex = 1;
            this.butonvizualizareanunt.Text = "Vizualizare Anunţuri";
            this.butonvizualizareanunt.UseVisualStyleBackColor = true;
            this.butonvizualizareanunt.Click += new System.EventHandler(this.butonvizualizareanunt_Click);
            // 
            // butonstergere
            // 
            this.butonstergere.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonstergere.Location = new System.Drawing.Point(258, 48);
            this.butonstergere.Name = "butonstergere";
            this.butonstergere.Size = new System.Drawing.Size(119, 41);
            this.butonstergere.TabIndex = 2;
            this.butonstergere.Text = "Ştergere Anunţ";
            this.butonstergere.UseVisualStyleBackColor = true;
            this.butonstergere.Click += new System.EventHandler(this.butonstergere_Click);
            // 
            // butoneditare
            // 
            this.butoneditare.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoneditare.Location = new System.Drawing.Point(258, 106);
            this.butoneditare.Name = "butoneditare";
            this.butoneditare.Size = new System.Drawing.Size(119, 41);
            this.butoneditare.TabIndex = 3;
            this.butoneditare.Text = "Editare Anunţ";
            this.butoneditare.UseVisualStyleBackColor = true;
            this.butoneditare.Click += new System.EventHandler(this.butoneditare_Click);
            // 
            // FormAngajatCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormLog.Properties.Resources.images11;
            this.ClientSize = new System.Drawing.Size(421, 191);
            this.Controls.Add(this.butoneditare);
            this.Controls.Add(this.butonstergere);
            this.Controls.Add(this.butonvizualizareanunt);
            this.Controls.Add(this.butoncreareanunt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAngajatCrud";
            this.Text = " Operatii Pe Anunt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butoncreareanunt;
        private System.Windows.Forms.Button butonvizualizareanunt;
        private System.Windows.Forms.Button butonstergere;
        private System.Windows.Forms.Button butoneditare;
    }
}