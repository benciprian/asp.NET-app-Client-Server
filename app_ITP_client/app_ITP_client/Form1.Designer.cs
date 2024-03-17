namespace app_ITP_client
{
    partial class Form1
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
            this.label_text = new System.Windows.Forms.Label();
            this.button_programari = new System.Windows.Forms.Button();
            this.button_rez_inspectie = new System.Windows.Forms.Button();
            this.button_iesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.Location = new System.Drawing.Point(60, 342);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(185, 41);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "Welcome";
            // 
            // button_programari
            // 
            this.button_programari.BackColor = System.Drawing.Color.Lime;
            this.button_programari.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_programari.Location = new System.Drawing.Point(670, 57);
            this.button_programari.Name = "button_programari";
            this.button_programari.Size = new System.Drawing.Size(275, 98);
            this.button_programari.TabIndex = 1;
            this.button_programari.Text = "Programari_ITP";
            this.button_programari.UseVisualStyleBackColor = false;
            this.button_programari.Click += new System.EventHandler(this.button_programari_Click);
            // 
            // button_rez_inspectie
            // 
            this.button_rez_inspectie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_rez_inspectie.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rez_inspectie.Location = new System.Drawing.Point(647, 311);
            this.button_rez_inspectie.Name = "button_rez_inspectie";
            this.button_rez_inspectie.Size = new System.Drawing.Size(333, 114);
            this.button_rez_inspectie.TabIndex = 2;
            this.button_rez_inspectie.Text = "Rezultat_Inspectie_ITP";
            this.button_rez_inspectie.UseVisualStyleBackColor = false;
            this.button_rez_inspectie.Click += new System.EventHandler(this.button_rez_inspectie_Click);
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_iesire.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iesire.Location = new System.Drawing.Point(698, 577);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(247, 95);
            this.button_iesire.TabIndex = 3;
            this.button_iesire.Text = "Logout";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app_ITP_client.Properties.Resources.img_itp_1;
            this.ClientSize = new System.Drawing.Size(992, 709);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.button_rez_inspectie);
            this.Controls.Add(this.button_programari);
            this.Controls.Add(this.label_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_programari;
        private System.Windows.Forms.Button button_rez_inspectie;
        private System.Windows.Forms.Button button_iesire;
    }
}

