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
            this.btnMaakLoonBrieven = new System.Windows.Forms.Button();
            this.btnGebruikerWijzigen = new System.Windows.Forms.Button();
            this.btnNieuweWerknemer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMijnWerknemers
            // 
            this.lbMijnWerknemers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMijnWerknemers.FormattingEnabled = true;
            this.lbMijnWerknemers.Location = new System.Drawing.Point(12, 12);
            this.lbMijnWerknemers.Name = "lbMijnWerknemers";
            this.lbMijnWerknemers.Size = new System.Drawing.Size(132, 121);
            this.lbMijnWerknemers.TabIndex = 0;
            this.lbMijnWerknemers.SelectedIndexChanged += new System.EventHandler(this.lbMijnWerknemers_SelectedIndexChanged);
            // 
            // btnMaakLoonBrieven
            // 
            this.btnMaakLoonBrieven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaakLoonBrieven.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaakLoonBrieven.Location = new System.Drawing.Point(150, 106);
            this.btnMaakLoonBrieven.Name = "btnMaakLoonBrieven";
            this.btnMaakLoonBrieven.Size = new System.Drawing.Size(130, 23);
            this.btnMaakLoonBrieven.TabIndex = 2;
            this.btnMaakLoonBrieven.Text = "Maak loonbrieven";
            this.btnMaakLoonBrieven.UseVisualStyleBackColor = true;
            this.btnMaakLoonBrieven.Click += new System.EventHandler(this.btnMaakLoonBrieven_Click);
            // 
            // btnGebruikerWijzigen
            // 
            this.btnGebruikerWijzigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGebruikerWijzigen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGebruikerWijzigen.Location = new System.Drawing.Point(150, 12);
            this.btnGebruikerWijzigen.Name = "btnGebruikerWijzigen";
            this.btnGebruikerWijzigen.Size = new System.Drawing.Size(130, 23);
            this.btnGebruikerWijzigen.TabIndex = 3;
            this.btnGebruikerWijzigen.Text = "Wijzig gebruiker";
            this.btnGebruikerWijzigen.UseVisualStyleBackColor = true;
            this.btnGebruikerWijzigen.Click += new System.EventHandler(this.btnGebruikerWijzigen_Click);
            // 
            // btnNieuweWerknemer
            // 
            this.btnNieuweWerknemer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNieuweWerknemer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNieuweWerknemer.Location = new System.Drawing.Point(150, 41);
            this.btnNieuweWerknemer.Name = "btnNieuweWerknemer";
            this.btnNieuweWerknemer.Size = new System.Drawing.Size(130, 23);
            this.btnNieuweWerknemer.TabIndex = 4;
            this.btnNieuweWerknemer.Text = "Werknemer Toevoegen";
            this.btnNieuweWerknemer.UseVisualStyleBackColor = true;
            this.btnNieuweWerknemer.Click += new System.EventHandler(this.btnNieuweWerknemer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.btnNieuweWerknemer);
            this.Controls.Add(this.btnGebruikerWijzigen);
            this.Controls.Add(this.btnMaakLoonBrieven);
            this.Controls.Add(this.lbMijnWerknemers);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMijnWerknemers;
        private System.Windows.Forms.Button btnMaakLoonBrieven;
        private System.Windows.Forms.Button btnGebruikerWijzigen;
        private System.Windows.Forms.Button btnNieuweWerknemer;
    }
}

