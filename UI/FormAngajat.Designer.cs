namespace FormLog
{
    partial class FormAngajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAngajat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crud = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.EXPORT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormLog.Properties.Resources.user_settings_icon;
            this.pictureBox1.Location = new System.Drawing.Point(346, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 253);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bine aţi venit ! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operaţiuni disponibile rolului de Angajat:";
            // 
            // crud
            // 
            this.crud.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crud.Location = new System.Drawing.Point(17, 162);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(126, 45);
            this.crud.TabIndex = 3;
            this.crud.Text = "Operaţii CRUD";
            this.crud.UseVisualStyleBackColor = true;
            this.crud.Click += new System.EventHandler(this.crud_Click);
            // 
            // import
            // 
            this.import.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.Location = new System.Drawing.Point(17, 248);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(126, 45);
            this.import.TabIndex = 4;
            this.import.Text = "Import Anunţ";
            this.import.UseVisualStyleBackColor = true;
            // 
            // EXPORT
            // 
            this.EXPORT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXPORT.Location = new System.Drawing.Point(17, 330);
            this.EXPORT.Name = "EXPORT";
            this.EXPORT.Size = new System.Drawing.Size(126, 45);
            this.EXPORT.TabIndex = 5;
            this.EXPORT.Text = "Export Anunţ";
            this.EXPORT.UseVisualStyleBackColor = true;
            // 
            // FormAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormLog.Properties.Resources.images1;
            this.ClientSize = new System.Drawing.Size(575, 537);
            this.Controls.Add(this.EXPORT);
            this.Controls.Add(this.import);
            this.Controls.Add(this.crud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAngajat";
            this.Text = "Angajat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button crud;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button EXPORT;

    }
}