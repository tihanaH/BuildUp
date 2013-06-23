namespace BuildUp_teretana
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(699, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDodajSpravu
            // 
            this.btnDodajSpravu.Location = new System.Drawing.Point(12, 22);
            this.btnDodajSpravu.Name = "btnDodajSpravu";
            this.btnDodajSpravu.Size = new System.Drawing.Size(109, 42);
            this.btnDodajSpravu.TabIndex = 1;
            this.btnDodajSpravu.Text = "Dodaj spravu";
            this.btnDodajSpravu.UseVisualStyleBackColor = true;
            this.btnDodajSpravu.Click += new System.EventHandler(this.btnDodajSpravu_Click);
            // 
            // btnPromijeniSpravu
            // 
            this.btnPromijeniSpravu.Location = new System.Drawing.Point(127, 22);
            this.btnPromijeniSpravu.Name = "btnPromijeniSpravu";
            this.btnPromijeniSpravu.Size = new System.Drawing.Size(109, 42);
            this.btnPromijeniSpravu.TabIndex = 2;
            this.btnPromijeniSpravu.Text = "Promijeni spravu";
            this.btnPromijeniSpravu.UseVisualStyleBackColor = true;
            this.btnPromijeniSpravu.Click += new System.EventHandler(this.btnPromijeniSpravu_Click);
            // 
            // btnObrisiSpravu
            // 
            this.btnObrisiSpravu.Location = new System.Drawing.Point(66, 70);
            this.btnObrisiSpravu.Name = "btnObrisiSpravu";
            this.btnObrisiSpravu.Size = new System.Drawing.Size(109, 42);
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
            this.grpDodaj.Location = new System.Drawing.Point(254, 12);
            this.grpDodaj.Name = "grpDodaj";
            this.grpDodaj.Size = new System.Drawing.Size(218, 127);
            this.grpDodaj.TabIndex = 4;
            this.grpDodaj.TabStop = false;
            this.grpDodaj.Text = "Dodaj spravu";
            this.grpDodaj.Visible = false;
            // 
            // btnPotvrdiDodavanje
            // 
            this.btnPotvrdiDodavanje.Location = new System.Drawing.Point(57, 96);
            this.btnPotvrdiDodavanje.Name = "btnPotvrdiDodavanje";
            this.btnPotvrdiDodavanje.Size = new System.Drawing.Size(102, 25);
            this.btnPotvrdiDodavanje.TabIndex = 6;
            this.btnPotvrdiDodavanje.Text = "Potvrdi";
            this.btnPotvrdiDodavanje.UseVisualStyleBackColor = true;
            this.btnPotvrdiDodavanje.Click += new System.EventHandler(this.btnPotvrdiDodavanje_Click);
            // 
            // txtImeDodaneSprave
            // 
            this.txtImeDodaneSprave.Location = new System.Drawing.Point(99, 34);
            this.txtImeDodaneSprave.Name = "txtImeDodaneSprave";
            this.txtImeDodaneSprave.Size = new System.Drawing.Size(113, 20);
            this.txtImeDodaneSprave.TabIndex = 8;
            // 
            // lblImeDodaneSprave
            // 
            this.lblImeDodaneSprave.AutoSize = true;
            this.lblImeDodaneSprave.Location = new System.Drawing.Point(6, 37);
            this.lblImeDodaneSprave.Name = "lblImeDodaneSprave";
            this.lblImeDodaneSprave.Size = new System.Drawing.Size(69, 13);
            this.lblImeDodaneSprave.TabIndex = 9;
            this.lblImeDodaneSprave.Text = "Naziv sprave";
            // 
            // txtKalorijeNoveSprave
            // 
            this.txtKalorijeNoveSprave.Location = new System.Drawing.Point(99, 60);
            this.txtKalorijeNoveSprave.Name = "txtKalorijeNoveSprave";
            this.txtKalorijeNoveSprave.Size = new System.Drawing.Size(113, 20);
            this.txtKalorijeNoveSprave.TabIndex = 6;
            // 
            // lblKalorijeNoveSprave
            // 
            this.lblKalorijeNoveSprave.AutoSize = true;
            this.lblKalorijeNoveSprave.Location = new System.Drawing.Point(6, 63);
            this.lblKalorijeNoveSprave.Name = "lblKalorijeNoveSprave";
            this.lblKalorijeNoveSprave.Size = new System.Drawing.Size(90, 13);
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
            this.grpPromijeni.Location = new System.Drawing.Point(478, 12);
            this.grpPromijeni.Name = "grpPromijeni";
            this.grpPromijeni.Size = new System.Drawing.Size(218, 127);
            this.grpPromijeni.TabIndex = 5;
            this.grpPromijeni.TabStop = false;
            this.grpPromijeni.Text = "Promijeni podatke o spravi";
            this.grpPromijeni.Visible = false;
            // 
            // btnPotvrdiPromjenu
            // 
            this.btnPotvrdiPromjenu.Location = new System.Drawing.Point(64, 96);
            this.btnPotvrdiPromjenu.Name = "btnPotvrdiPromjenu";
            this.btnPotvrdiPromjenu.Size = new System.Drawing.Size(102, 25);
            this.btnPotvrdiPromjenu.TabIndex = 10;
            this.btnPotvrdiPromjenu.Text = "Potvrdi";
            this.btnPotvrdiPromjenu.UseVisualStyleBackColor = true;
            this.btnPotvrdiPromjenu.Click += new System.EventHandler(this.btnPotvrdiPromjenu_Click);
            // 
            // txtNazivPromijenjeni
            // 
            this.txtNazivPromijenjeni.Location = new System.Drawing.Point(99, 34);
            this.txtNazivPromijenjeni.Name = "txtNazivPromijenjeni";
            this.txtNazivPromijenjeni.Size = new System.Drawing.Size(113, 20);
            this.txtNazivPromijenjeni.TabIndex = 13;
            // 
            // lblNazivPromijenjeneSprave
            // 
            this.lblNazivPromijenjeneSprave.AutoSize = true;
            this.lblNazivPromijenjeneSprave.Location = new System.Drawing.Point(6, 37);
            this.lblNazivPromijenjeneSprave.Name = "lblNazivPromijenjeneSprave";
            this.lblNazivPromijenjeneSprave.Size = new System.Drawing.Size(92, 13);
            this.lblNazivPromijenjeneSprave.TabIndex = 14;
            this.lblNazivPromijenjeneSprave.Text = "Novi naziv sprave";
            // 
            // txtKalorijePromijenjene
            // 
            this.txtKalorijePromijenjene.Location = new System.Drawing.Point(99, 60);
            this.txtKalorijePromijenjene.Name = "txtKalorijePromijenjene";
            this.txtKalorijePromijenjene.Size = new System.Drawing.Size(113, 20);
            this.txtKalorijePromijenjene.TabIndex = 11;
            // 
            // lblPromijeniKalorije
            // 
            this.lblPromijeniKalorije.AutoSize = true;
            this.lblPromijeniKalorije.Location = new System.Drawing.Point(6, 63);
            this.lblPromijeniKalorije.Name = "lblPromijeniKalorije";
            this.lblPromijeniKalorije.Size = new System.Drawing.Size(90, 13);
            this.lblPromijeniKalorije.TabIndex = 12;
            this.lblPromijeniKalorije.Text = "Prosječne kalorije";
            // 
            // btnDodajUProgram
            // 
            this.btnDodajUProgram.Location = new System.Drawing.Point(66, 128);
            this.btnDodajUProgram.Name = "btnDodajUProgram";
            this.btnDodajUProgram.Size = new System.Drawing.Size(109, 23);
            this.btnDodajUProgram.TabIndex = 6;
            this.btnDodajUProgram.Text = "Potvrdi";
            this.btnDodajUProgram.UseVisualStyleBackColor = true;
            this.btnDodajUProgram.Visible = false;
            this.btnDodajUProgram.Click += new System.EventHandler(this.btnDodajUProgram_Click);
            // 
            // Sprave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 494);
            this.Controls.Add(this.btnDodajUProgram);
            this.Controls.Add(this.grpPromijeni);
            this.Controls.Add(this.grpDodaj);
            this.Controls.Add(this.btnObrisiSpravu);
            this.Controls.Add(this.btnPromijeniSpravu);
            this.Controls.Add(this.btnDodajSpravu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sprave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprave";
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