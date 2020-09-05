namespace MaandelijkseLonen
{
    partial class FormGebruikerGegevens
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGeslacht = new System.Windows.Forms.ComboBox();
            this.tbRekeningNummer = new System.Windows.Forms.MaskedTextBox();
            this.tbRijksregisterNummer = new System.Windows.Forms.MaskedTextBox();
            this.dtGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDatumInDienst = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numBrutoLoon = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBedrijfsWagen = new System.Windows.Forms.ComboBox();
            this.numUren = new System.Windows.Forms.NumericUpDown();
            this.cbTypeContract = new System.Windows.Forms.ComboBox();
            this.cbFunctie = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutoLoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geboorte datum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rijkregisternummer :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGeslacht);
            this.groupBox1.Controls.Add(this.tbRekeningNummer);
            this.groupBox1.Controls.Add(this.tbRijksregisterNummer);
            this.groupBox1.Controls.Add(this.dtGeboorteDatum);
            this.groupBox1.Controls.Add(this.tbNaam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persoonlijke gegevens";
            // 
            // cbGeslacht
            // 
            this.cbGeslacht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeslacht.FormattingEnabled = true;
            this.cbGeslacht.Location = new System.Drawing.Point(122, 71);
            this.cbGeslacht.Name = "cbGeslacht";
            this.cbGeslacht.Size = new System.Drawing.Size(130, 21);
            this.cbGeslacht.TabIndex = 3;
            // 
            // tbRekeningNummer
            // 
            this.tbRekeningNummer.Location = new System.Drawing.Point(122, 124);
            this.tbRekeningNummer.Mask = "BE00 0000 0000 0000";
            this.tbRekeningNummer.Name = "tbRekeningNummer";
            this.tbRekeningNummer.Size = new System.Drawing.Size(130, 20);
            this.tbRekeningNummer.TabIndex = 5;
            // 
            // tbRijksregisterNummer
            // 
            this.tbRijksregisterNummer.Location = new System.Drawing.Point(122, 98);
            this.tbRijksregisterNummer.Mask = "000000-000-00";
            this.tbRijksregisterNummer.Name = "tbRijksregisterNummer";
            this.tbRijksregisterNummer.Size = new System.Drawing.Size(130, 20);
            this.tbRijksregisterNummer.TabIndex = 4;
            // 
            // dtGeboorteDatum
            // 
            this.dtGeboorteDatum.CustomFormat = "dd MM yyyy";
            this.dtGeboorteDatum.Location = new System.Drawing.Point(122, 45);
            this.dtGeboorteDatum.MaxDate = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            this.dtGeboorteDatum.Name = "dtGeboorteDatum";
            this.dtGeboorteDatum.Size = new System.Drawing.Size(130, 20);
            this.dtGeboorteDatum.TabIndex = 2;
            this.dtGeboorteDatum.Value = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(122, 19);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(226, 20);
            this.tbNaam.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geslacht:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rekening nummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.dtDatumInDienst);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numBrutoLoon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbBedrijfsWagen);
            this.groupBox2.Controls.Add(this.numUren);
            this.groupBox2.Controls.Add(this.cbTypeContract);
            this.groupBox2.Controls.Add(this.cbFunctie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract gegevens";
            // 
            // dtDatumInDienst
            // 
            this.dtDatumInDienst.Location = new System.Drawing.Point(125, 46);
            this.dtDatumInDienst.Name = "dtDatumInDienst";
            this.dtDatumInDienst.Size = new System.Drawing.Size(121, 20);
            this.dtDatumInDienst.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Datum in dienst :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bruto loon :";
            // 
            // numBrutoLoon
            // 
            this.numBrutoLoon.Location = new System.Drawing.Point(125, 128);
            this.numBrutoLoon.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBrutoLoon.Name = "numBrutoLoon";
            this.numBrutoLoon.Size = new System.Drawing.Size(121, 20);
            this.numBrutoLoon.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Aantal uren :";
            // 
            // cbBedrijfsWagen
            // 
            this.cbBedrijfsWagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBedrijfsWagen.FormattingEnabled = true;
            this.cbBedrijfsWagen.Location = new System.Drawing.Point(125, 152);
            this.cbBedrijfsWagen.Name = "cbBedrijfsWagen";
            this.cbBedrijfsWagen.Size = new System.Drawing.Size(121, 21);
            this.cbBedrijfsWagen.TabIndex = 11;
            // 
            // numUren
            // 
            this.numUren.Location = new System.Drawing.Point(125, 102);
            this.numUren.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUren.Name = "numUren";
            this.numUren.Size = new System.Drawing.Size(121, 20);
            this.numUren.TabIndex = 9;
            this.numUren.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUren.ValueChanged += new System.EventHandler(this.numUren_ValueChanged);
            // 
            // cbTypeContract
            // 
            this.cbTypeContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeContract.FormattingEnabled = true;
            this.cbTypeContract.Location = new System.Drawing.Point(125, 75);
            this.cbTypeContract.Name = "cbTypeContract";
            this.cbTypeContract.Size = new System.Drawing.Size(121, 21);
            this.cbTypeContract.TabIndex = 8;
            this.cbTypeContract.SelectedIndexChanged += new System.EventHandler(this.cbTypeContract_SelectedIndexChanged);
            // 
            // cbFunctie
            // 
            this.cbFunctie.BackColor = System.Drawing.SystemColors.Window;
            this.cbFunctie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Location = new System.Drawing.Point(125, 19);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(121, 21);
            this.cbFunctie.TabIndex = 6;
            this.cbFunctie.SelectedIndexChanged += new System.EventHandler(this.cbFunctie_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bedrijfs wagen :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Functie :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type contract :";
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(12, 376);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(175, 23);
            this.btnBevestigen.TabIndex = 12;
            this.btnBevestigen.Text = "button1";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // FormGebruikerGegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(410, 450);
            this.MinimumSize = new System.Drawing.Size(410, 415);
            this.Name = "FormGebruikerGegevens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGebruikerGegevens";
            this.Load += new System.EventHandler(this.FormGebruikerGegevens_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutoLoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbRekeningNummer;
        private System.Windows.Forms.MaskedTextBox tbRijksregisterNummer;
        private System.Windows.Forms.DateTimePicker dtGeboorteDatum;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.ComboBox cbGeslacht;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBedrijfsWagen;
        private System.Windows.Forms.NumericUpDown numUren;
        private System.Windows.Forms.ComboBox cbTypeContract;
        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numBrutoLoon;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtDatumInDienst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider epError;
    }
}