﻿namespace BuildUp_teretana
{
    partial class Sprave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajSpravu = new System.Windows.Forms.Button();
            this.btnPromijeniSpravu = new System.Windows.Forms.Button();
            this.btnObrisiSpravu = new System.Windows.Forms.Button();
            this.grpDodaj = new System.Windows.Forms.GroupBox();
            this.btnPotvrdiDodavanje = new System.Windows.Forms.Button();
            this.txtImeDodaneSprave = new System.Windows.Forms.TextBox();
            this.lblImeDodaneSprave = new System.Windows.Forms.Label();
            this.txtKalorijeNoveSprave = new System.Windows.Forms.TextBox();
            this.lblKalorijeNoveSprave = new System.Windows.Forms.Label();
            this.grpPromijeni = new System.Windows.Forms.GroupBox();
            this.btnPotvrdiPromjenu = new System.Windows.Forms.Button();
            this.txtNazivPromijenjeni = new System.Windows.Forms.TextBox();
            this.lblNazivPromijenjeneSprave = new System.Windows.Forms.Label();
            this.txtKalorijePromijenjene = new System.Windows.Forms.TextBox();
            this.lblPromijeniKalorije = new System.Windows.Forms.Label();
            this.btnDodajUProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDodaj.SuspendLayout();
            this.grpPromijeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(932, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDodajSpravu
            // 
            this.btnDodajSpravu.Location = new System.Drawing.Point(16, 27);
            this.btnDodajSpravu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajSpravu.Name = "btnDodajSpravu";
            this.btnDodajSpravu.Size = new System.Drawing.Size(145, 52);
            this.btnDodajSpravu.TabIndex = 1;
            this.btnDodajSpravu.Text = "Dodaj spravu";
            this.btnDodajSpravu.UseVisualStyleBackColor = true;
            this.btnDodajSpravu.Click += new System.EventHandler(this.btnDodajSpravu_Click);
            // 
            // btnPromijeniSpravu
            // 
            this.btnPromijeniSpravu.Location = new System.Drawing.Point(169, 27);
            this.btnPromijeniSpravu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromijeniSpravu.Name = "btnPromijeniSpravu";
            this.btnPromijeniSpravu.Size = new System.Drawing.Size(145, 52);
            this.btnPromijeniSpravu.TabIndex = 2;
            this.btnPromijeniSpravu.Text = "Promijeni spravu";
            this.btnPromijeniSpravu.UseVisualStyleBackColor = true;
            this.btnPromijeniSpravu.Click += new System.EventHandler(this.btnPromijeniSpravu_Click);
            // 
            // btnObrisiSpravu
            // 
            this.btnObrisiSpravu.Location = new System.Drawing.Point(88, 86);
            this.btnObrisiSpravu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiSpravu.Name = "btnObrisiSpravu";
            this.btnObrisiSpravu.Size = new System.Drawing.Size(145, 52);
            this.btnObrisiSpravu.TabIndex = 3;
            this.btnObrisiSpravu.Text = "Obriši spravu";
            this.btnObrisiSpravu.UseVisualStyleBackColor = true;
            this.btnObrisiSpravu.Click += new System.EventHandler(this.btnObrisiSpravu_Click);
            // 
            // grpDodaj
            // 
            this.grpDodaj.Controls.Add(this.btnPotvrdiDodavanje);
            this.grpDodaj.Controls.Add(this.txtImeDodaneSprave);
            this.grpDodaj.Controls.Add(this.lblImeDodaneSprave);
            this.grpDodaj.Controls.Add(this.txtKalorijeNoveSprave);
            this.grpDodaj.Controls.Add(this.lblKalorijeNoveSprave);
            this.grpDodaj.Location = new System.Drawing.Point(339, 15);
            this.grpDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDodaj.Name = "grpDodaj";
            this.grpDodaj.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDodaj.Size = new System.Drawing.Size(291, 156);
            this.grpDodaj.TabIndex = 4;
            this.grpDodaj.TabStop = false;
            this.grpDodaj.Text = "Dodaj spravu";
            this.grpDodaj.Visible = false;
            // 
            // btnPotvrdiDodavanje
            // 
            this.btnPotvrdiDodavanje.Location = new System.Drawing.Point(76, 118);
            this.btnPotvrdiDodavanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPotvrdiDodavanje.Name = "btnPotvrdiDodavanje";
            this.btnPotvrdiDodavanje.Size = new System.Drawing.Size(136, 31);
            this.btnPotvrdiDodavanje.TabIndex = 6;
            this.btnPotvrdiDodavanje.Text = "Potvrdi";
            this.btnPotvrdiDodavanje.UseVisualStyleBackColor = true;
            this.btnPotvrdiDodavanje.Click += new System.EventHandler(this.btnPotvrdiDodavanje_Click);
            // 
            // txtImeDodaneSprave
            // 
            this.txtImeDodaneSprave.Location = new System.Drawing.Point(132, 42);
            this.txtImeDodaneSprave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImeDodaneSprave.Name = "txtImeDodaneSprave";
            this.txtImeDodaneSprave.Size = new System.Drawing.Size(149, 22);
            this.txtImeDodaneSprave.TabIndex = 8;
            // 
            // lblImeDodaneSprave
            // 
            this.lblImeDodaneSprave.AutoSize = true;
            this.lblImeDodaneSprave.Location = new System.Drawing.Point(8, 46);
            this.lblImeDodaneSprave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImeDodaneSprave.Name = "lblImeDodaneSprave";
            this.lblImeDodaneSprave.Size = new System.Drawing.Size(90, 17);
            this.lblImeDodaneSprave.TabIndex = 9;
            this.lblImeDodaneSprave.Text = "Naziv sprave";
            // 
            // txtKalorijeNoveSprave
            // 
            this.txtKalorijeNoveSprave.Location = new System.Drawing.Point(132, 74);
            this.txtKalorijeNoveSprave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKalorijeNoveSprave.Name = "txtKalorijeNoveSprave";
            this.txtKalorijeNoveSprave.Size = new System.Drawing.Size(149, 22);
            this.txtKalorijeNoveSprave.TabIndex = 6;
            // 
            // lblKalorijeNoveSprave
            // 
            this.lblKalorijeNoveSprave.AutoSize = true;
            this.lblKalorijeNoveSprave.Location = new System.Drawing.Point(8, 78);
            this.lblKalorijeNoveSprave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalorijeNoveSprave.Name = "lblKalorijeNoveSprave";
            this.lblKalorijeNoveSprave.Size = new System.Drawing.Size(120, 17);
            this.lblKalorijeNoveSprave.TabIndex = 7;
            this.lblKalorijeNoveSprave.Text = "Prosječne kalorije";
            // 
            // grpPromijeni
            // 
            this.grpPromijeni.Controls.Add(this.btnPotvrdiPromjenu);
            this.grpPromijeni.Controls.Add(this.txtNazivPromijenjeni);
            this.grpPromijeni.Controls.Add(this.lblNazivPromijenjeneSprave);
            this.grpPromijeni.Controls.Add(this.txtKalorijePromijenjene);
            this.grpPromijeni.Controls.Add(this.lblPromijeniKalorije);
            this.grpPromijeni.Location = new System.Drawing.Point(637, 15);
            this.grpPromijeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPromijeni.Name = "grpPromijeni";
            this.grpPromijeni.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPromijeni.Size = new System.Drawing.Size(291, 156);
            this.grpPromijeni.TabIndex = 5;
            this.grpPromijeni.TabStop = false;
            this.grpPromijeni.Text = "Promijeni podatke o spravi";
            this.grpPromijeni.Visible = false;
            // 
            // btnPotvrdiPromjenu
            // 
            this.btnPotvrdiPromjenu.Location = new System.Drawing.Point(85, 118);
            this.btnPotvrdiPromjenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPotvrdiPromjenu.Name = "btnPotvrdiPromjenu";
            this.btnPotvrdiPromjenu.Size = new System.Drawing.Size(136, 31);
            this.btnPotvrdiPromjenu.TabIndex = 10;
            this.btnPotvrdiPromjenu.Text = "Potvrdi";
            this.btnPotvrdiPromjenu.UseVisualStyleBackColor = true;
            this.btnPotvrdiPromjenu.Click += new System.EventHandler(this.btnPotvrdiPromjenu_Click);
            // 
            // txtNazivPromijenjeni
            // 
            this.txtNazivPromijenjeni.Location = new System.Drawing.Point(132, 42);
            this.txtNazivPromijenjeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNazivPromijenjeni.Name = "txtNazivPromijenjeni";
            this.txtNazivPromijenjeni.Size = new System.Drawing.Size(149, 22);
            this.txtNazivPromijenjeni.TabIndex = 13;
            // 
            // lblNazivPromijenjeneSprave
            // 
            this.lblNazivPromijenjeneSprave.AutoSize = true;
            this.lblNazivPromijenjeneSprave.Location = new System.Drawing.Point(8, 46);
            this.lblNazivPromijenjeneSprave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivPromijenjeneSprave.Name = "lblNazivPromijenjeneSprave";
            this.lblNazivPromijenjeneSprave.Size = new System.Drawing.Size(120, 17);
            this.lblNazivPromijenjeneSprave.TabIndex = 14;
            this.lblNazivPromijenjeneSprave.Text = "Novi naziv sprave";
            // 
            // txtKalorijePromijenjene
            // 
            this.txtKalorijePromijenjene.Location = new System.Drawing.Point(132, 74);
            this.txtKalorijePromijenjene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKalorijePromijenjene.Name = "txtKalorijePromijenjene";
            this.txtKalorijePromijenjene.Size = new System.Drawing.Size(149, 22);
            this.txtKalorijePromijenjene.TabIndex = 11;
            // 
            // lblPromijeniKalorije
            // 
            this.lblPromijeniKalorije.AutoSize = true;
            this.lblPromijeniKalorije.Location = new System.Drawing.Point(8, 78);
            this.lblPromijeniKalorije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromijeniKalorije.Name = "lblPromijeniKalorije";
            this.lblPromijeniKalorije.Size = new System.Drawing.Size(120, 17);
            this.lblPromijeniKalorije.TabIndex = 12;
            this.lblPromijeniKalorije.Text = "Prosječne kalorije";
            // 
            // btnDodajUProgram
            // 
            this.btnDodajUProgram.Location = new System.Drawing.Point(88, 145);
            this.btnDodajUProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajUProgram.Name = "btnDodajUProgram";
            this.btnDodajUProgram.Size = new System.Drawing.Size(145, 31);
            this.btnDodajUProgram.TabIndex = 6;
            this.btnDodajUProgram.Text = "Potvrdi";
            this.btnDodajUProgram.UseVisualStyleBackColor = true;
            this.btnDodajUProgram.Visible = false;
            this.btnDodajUProgram.Click += new System.EventHandler(this.btnDodajUProgram_Click);
            // 
            // Sprave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 608);
            this.Controls.Add(this.btnDodajUProgram);
            this.Controls.Add(this.grpPromijeni);
            this.Controls.Add(this.grpDodaj);
            this.Controls.Add(this.btnObrisiSpravu);
            this.Controls.Add(this.btnPromijeniSpravu);
            this.Controls.Add(this.btnDodajSpravu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Sprave";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprave";
            this.Load += new System.EventHandler(this.Sprave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDodaj.ResumeLayout(false);
            this.grpDodaj.PerformLayout();
            this.grpPromijeni.ResumeLayout(false);
            this.grpPromijeni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajSpravu;
        private System.Windows.Forms.Button btnPromijeniSpravu;
        private System.Windows.Forms.Button btnObrisiSpravu;
        private System.Windows.Forms.GroupBox grpDodaj;
        private System.Windows.Forms.Button btnPotvrdiDodavanje;
        private System.Windows.Forms.TextBox txtImeDodaneSprave;
        private System.Windows.Forms.Label lblImeDodaneSprave;
        private System.Windows.Forms.TextBox txtKalorijeNoveSprave;
        private System.Windows.Forms.Label lblKalorijeNoveSprave;
        private System.Windows.Forms.GroupBox grpPromijeni;
        private System.Windows.Forms.Button btnPotvrdiPromjenu;
        private System.Windows.Forms.TextBox txtNazivPromijenjeni;
        private System.Windows.Forms.Label lblNazivPromijenjeneSprave;
        private System.Windows.Forms.TextBox txtKalorijePromijenjene;
        private System.Windows.Forms.Label lblPromijeniKalorije;
        private System.Windows.Forms.Button btnDodajUProgram;
    }
}