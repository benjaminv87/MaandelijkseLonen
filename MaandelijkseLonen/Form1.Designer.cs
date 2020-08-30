namespace MaandelijkseLonen
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
            this.lbMijnWerknemers = new System.Windows.Forms.ListBox();
            this.lblMijnWerknemer = new System.Windows.Forms.Label();
            this.btnMaakLoonBrieven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMijnWerknemers
            // 
            this.lbMijnWerknemers.FormattingEnabled = true;
            this.lbMijnWerknemers.Location = new System.Drawing.Point(41, 68);
            this.lbMijnWerknemers.Name = "lbMijnWerknemers";
            this.lbMijnWerknemers.Size = new System.Drawing.Size(120, 95);
            this.lbMijnWerknemers.TabIndex = 0;
            this.lbMijnWerknemers.SelectedIndexChanged += new System.EventHandler(this.lbMijnWerknemers_SelectedIndexChanged);
            // 
            // lblMijnWerknemer
            // 
            this.lblMijnWerknemer.AutoSize = true;
            this.lblMijnWerknemer.Location = new System.Drawing.Point(167, 68);
            this.lblMijnWerknemer.Name = "lblMijnWerknemer";
            this.lblMijnWerknemer.Size = new System.Drawing.Size(35, 13);
            this.lblMijnWerknemer.TabIndex = 1;
            this.lblMijnWerknemer.Text = "label1";
            // 
            // btnMaakLoonBrieven
            // 
            this.btnMaakLoonBrieven.Location = new System.Drawing.Point(274, 68);
            this.btnMaakLoonBrieven.Name = "btnMaakLoonBrieven";
            this.btnMaakLoonBrieven.Size = new System.Drawing.Size(165, 23);
            this.btnMaakLoonBrieven.TabIndex = 2;
            this.btnMaakLoonBrieven.Text = "Maak loonbrieven";
            this.btnMaakLoonBrieven.UseVisualStyleBackColor = true;
            this.btnMaakLoonBrieven.Click += new System.EventHandler(this.btnMaakLoonBrieven_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaakLoonBrieven);
            this.Controls.Add(this.lblMijnWerknemer);
            this.Controls.Add(this.lbMijnWerknemers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMijnWerknemers;
        private System.Windows.Forms.Label lblMijnWerknemer;
        private System.Windows.Forms.Button btnMaakLoonBrieven;
    }
}

