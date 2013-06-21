namespace BuildUp_teretana
{
    partial class FrmČlanovi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTraziClan = new System.Windows.Forms.Button();
            this.txtTraziClan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.brišiČlanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promijeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pošaljiIzvještajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dolazakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odlazakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programVježbanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAktivirajClanarinu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTraziClan
            // 
            this.btnTraziClan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraziClan.Location = new System.Drawing.Point(832, 40);
            this.btnTraziClan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraziClan.Name = "btnTraziClan";
            this.btnTraziClan.Size = new System.Drawing.Size(132, 33);
            this.btnTraziClan.TabIndex = 0;
            this.btnTraziClan.Text = "Traži";
            this.btnTraziClan.UseVisualStyleBackColor = true;
            this.btnTraziClan.Click += new System.EventHandler(this.btnTraziClan_Click);
            // 
            // txtTraziClan
            // 
            this.txtTraziClan.Location = new System.Drawing.Point(615, 45);
            this.txtTraziClan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTraziClan.Name = "txtTraziClan";
            this.txtTraziClan.Size = new System.Drawing.Size(192, 22);
            this.txtTraziClan.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 538);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brišiČlanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brišiČlanaToolStripMenuItem
            // 
            this.brišiČlanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brišiToolStripMenuItem,
            this.izmjeniToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.promijeniToolStripMenuItem,
            this.pošaljiIzvještajToolStripMenuItem1,
            this.evidencijaToolStripMenuItem1,
            this.programVježbanjaToolStripMenuItem});
            this.brišiČlanaToolStripMenuItem.Name = "brišiČlanaToolStripMenuItem";
            this.brišiČlanaToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.brišiČlanaToolStripMenuItem.Text = "Član";
            // 
            // brišiToolStripMenuItem
            // 
            this.brišiToolStripMenuItem.Name = "brišiToolStripMenuItem";
            this.brišiToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.brišiToolStripMenuItem.Text = "Briši";
            this.brišiToolStripMenuItem.Click += new System.EventHandler(this.brišiToolStripMenuItem_Click);
            // 
            // izmjeniToolStripMenuItem
            // 
            this.izmjeniToolStripMenuItem.Name = "izmjeniToolStripMenuItem";
            this.izmjeniToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.izmjeniToolStripMenuItem.Text = "Izmjeni";
            this.izmjeniToolStripMenuItem.Click += new System.EventHandler(this.izmjeniToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // promijeniToolStripMenuItem
            // 
            this.promijeniToolStripMenuItem.Name = "promijeniToolStripMenuItem";
            this.promijeniToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.promijeniToolStripMenuItem.Text = "Neaktivni članovi";
            this.promijeniToolStripMenuItem.Click += new System.EventHandler(this.promijeniToolStripMenuItem_Click);
            // 
            // pošaljiIzvještajToolStripMenuItem1
            // 
            this.pošaljiIzvještajToolStripMenuItem1.Name = "pošaljiIzvještajToolStripMenuItem1";
            this.pošaljiIzvještajToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.pošaljiIzvještajToolStripMenuItem1.Text = "Pošalji izvještaj";
            // 
            // evidencijaToolStripMenuItem1
            // 
            this.evidencijaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolazakToolStripMenuItem1,
            this.odlazakToolStripMenuItem1});
            this.evidencijaToolStripMenuItem1.Name = "evidencijaToolStripMenuItem1";
            this.evidencijaToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.evidencijaToolStripMenuItem1.Text = "Evidencija";
            // 
            // dolazakToolStripMenuItem1
            // 
            this.dolazakToolStripMenuItem1.Name = "dolazakToolStripMenuItem1";
            this.dolazakToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.dolazakToolStripMenuItem1.Text = "Dolazak";
            // 
            // odlazakToolStripMenuItem1
            // 
            this.odlazakToolStripMenuItem1.Name = "odlazakToolStripMenuItem1";
            this.odlazakToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.odlazakToolStripMenuItem1.Text = "Odlazak";
            // 
            // programVježbanjaToolStripMenuItem
            // 
            this.programVježbanjaToolStripMenuItem.Name = "programVježbanjaToolStripMenuItem";
            this.programVježbanjaToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.programVježbanjaToolStripMenuItem.Text = "Program vježbanja";
            // 
            // btnAktivirajClanarinu
            // 
            this.btnAktivirajClanarinu.Location = new System.Drawing.Point(24, 40);
            this.btnAktivirajClanarinu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAktivirajClanarinu.Name = "btnAktivirajClanarinu";
            this.btnAktivirajClanarinu.Size = new System.Drawing.Size(132, 33);
            this.btnAktivirajClanarinu.TabIndex = 4;
            this.btnAktivirajClanarinu.Text = "Aktiviraj članarinu";
            this.btnAktivirajClanarinu.UseVisualStyleBackColor = true;
            this.btnAktivirajClanarinu.Visible = false;
            this.btnAktivirajClanarinu.Click += new System.EventHandler(this.btnAktivirajClanarinu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(191, 40);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Prikaži sve aktivne članove";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(432, 48);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(176, 17);
            this.lblPretraga.TabIndex = 6;
            this.lblPretraga.Text = "Upišite ime i prezime člana";
            // 
            // FrmČlanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 636);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAktivirajClanarinu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTraziClan);
            this.Controls.Add(this.btnTraziClan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmČlanovi";
            this.Text = "BuildUp Članovi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraziClan;
        private System.Windows.Forms.TextBox txtTraziClan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brišiČlanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promijeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pošaljiIzvještajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evidencijaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dolazakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odlazakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programVježbanjaToolStripMenuItem;
        private System.Windows.Forms.Button btnAktivirajClanarinu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPretraga;
    }
}