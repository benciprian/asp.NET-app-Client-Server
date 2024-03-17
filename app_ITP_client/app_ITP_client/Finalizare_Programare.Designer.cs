namespace app_ITP_client
{
    partial class Finalizare_Programare
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
            this.button_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_end
            // 
            this.button_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_end.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_end.Location = new System.Drawing.Point(773, 520);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(154, 72);
            this.button_end.TabIndex = 0;
            this.button_end.Text = "End ";
            this.button_end.UseVisualStyleBackColor = false;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // Finalizare_Programare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app_ITP_client.Properties.Resources.img_itp_2;
            this.ClientSize = new System.Drawing.Size(1006, 717);
            this.Controls.Add(this.button_end);
            this.Name = "Finalizare_Programare";
            this.Text = "Finalizare_Programare";
            this.Load += new System.EventHandler(this.Finalizare_Programare_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_end;
    }
}