namespace Vise_formi
{
    partial class NoviStudent
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
            this.fSnimi = new System.Windows.Forms.Button();
            this.fOtkazi = new System.Windows.Forms.Button();
            this.fIme = new System.Windows.Forms.TextBox();
            this.fPrezime = new System.Windows.Forms.TextBox();
            this.fBrojIndeksa = new System.Windows.Forms.TextBox();
            this.fSmjer = new System.Windows.Forms.ComboBox();
            this.fDatRodjenja = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fSnimi
            // 
            this.fSnimi.Location = new System.Drawing.Point(521, 278);
            this.fSnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fSnimi.Name = "fSnimi";
            this.fSnimi.Size = new System.Drawing.Size(100, 28);
            this.fSnimi.TabIndex = 0;
            this.fSnimi.Text = "Snimi";
            this.fSnimi.UseVisualStyleBackColor = true;
            this.fSnimi.Click += new System.EventHandler(this.fSnimi_Click);
            // 
            // fOtkazi
            // 
            this.fOtkazi.Location = new System.Drawing.Point(53, 278);
            this.fOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fOtkazi.Name = "fOtkazi";
            this.fOtkazi.Size = new System.Drawing.Size(100, 28);
            this.fOtkazi.TabIndex = 1;
            this.fOtkazi.Text = "Otkaži";
            this.fOtkazi.UseVisualStyleBackColor = true;
            this.fOtkazi.Click += new System.EventHandler(this.fOtkazi_Click);
            // 
            // fIme
            // 
            this.fIme.Location = new System.Drawing.Point(53, 62);
            this.fIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fIme.Name = "fIme";
            this.fIme.Size = new System.Drawing.Size(132, 22);
            this.fIme.TabIndex = 2;
            // 
            // fPrezime
            // 
            this.fPrezime.Location = new System.Drawing.Point(53, 126);
            this.fPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fPrezime.Name = "fPrezime";
            this.fPrezime.Size = new System.Drawing.Size(132, 22);
            this.fPrezime.TabIndex = 3;
            // 
            // fBrojIndeksa
            // 
            this.fBrojIndeksa.Location = new System.Drawing.Point(355, 62);
            this.fBrojIndeksa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fBrojIndeksa.Name = "fBrojIndeksa";
            this.fBrojIndeksa.Size = new System.Drawing.Size(132, 22);
            this.fBrojIndeksa.TabIndex = 4;
            // 
            // fSmjer
            // 
            this.fSmjer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fSmjer.FormattingEnabled = true;
            this.fSmjer.Items.AddRange(new object[] {
            "Programer",
            "Sistem Administrator",
            "Mrežni administrator"});
            this.fSmjer.Location = new System.Drawing.Point(53, 182);
            this.fSmjer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fSmjer.Name = "fSmjer";
            this.fSmjer.Size = new System.Drawing.Size(160, 24);
            this.fSmjer.TabIndex = 5;
            // 
            // fDatRodjenja
            // 
            this.fDatRodjenja.Location = new System.Drawing.Point(355, 122);
            this.fDatRodjenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fDatRodjenja.Name = "fDatRodjenja";
            this.fDatRodjenja.Size = new System.Drawing.Size(265, 22);
            this.fDatRodjenja.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(53, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 15);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Ime:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(53, 102);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 15);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Prezime:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(53, 159);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 15);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Smjer:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(355, 38);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 15);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Broj indexa:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(355, 102);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 15);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Datum Rođenja:";
            // 
            // NoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 425);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fDatRodjenja);
            this.Controls.Add(this.fSmjer);
            this.Controls.Add(this.fBrojIndeksa);
            this.Controls.Add(this.fPrezime);
            this.Controls.Add(this.fIme);
            this.Controls.Add(this.fOtkazi);
            this.Controls.Add(this.fSnimi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NoviStudent";
            this.Text = "Unos Novog studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fSnimi;
        private System.Windows.Forms.Button fOtkazi;
        private System.Windows.Forms.TextBox fIme;
        private System.Windows.Forms.TextBox fPrezime;
        private System.Windows.Forms.TextBox fBrojIndeksa;
        private System.Windows.Forms.ComboBox fSmjer;
        private System.Windows.Forms.DateTimePicker fDatRodjenja;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}