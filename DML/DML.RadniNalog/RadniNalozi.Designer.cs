namespace DML.RadniNalog
{
    partial class RadniNalozi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ddgRadniNalozi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVrstaRobe = new System.Windows.Forms.TextBox();
            this.txtPrimateljRobe = new System.Windows.Forms.TextBox();
            this.txtNarucitelj = new System.Windows.Forms.TextBox();
            this.txtVrstaStroja = new System.Windows.Forms.TextBox();
            this.txtVozac = new System.Windows.Forms.TextBox();
            this.txtRadilište = new System.Windows.Forms.TextBox();
            this.txtVrstaUsluge = new System.Windows.Forms.TextBox();
            this.txtRegOznakaKamiona = new System.Windows.Forms.TextBox();
            this.txtRobuIzdao = new System.Windows.Forms.TextBox();
            this.TxtKolicinaRobe = new System.Windows.Forms.TextBox();
            this.btnSaveRn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRadniNalog = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddgRadniNalozi)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ddgRadniNalozi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(574, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pregled radnih naloga";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ddgRadniNalozi
            // 
            this.ddgRadniNalozi.AllowUserToAddRows = false;
            this.ddgRadniNalozi.AllowUserToDeleteRows = false;
            this.ddgRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgRadniNalozi.Location = new System.Drawing.Point(5, 43);
            this.ddgRadniNalozi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddgRadniNalozi.Name = "ddgRadniNalozi";
            this.ddgRadniNalozi.ReadOnly = true;
            this.ddgRadniNalozi.RowTemplate.Height = 24;
            this.ddgRadniNalozi.Size = new System.Drawing.Size(566, 292);
            this.ddgRadniNalozi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(130, 14);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(151, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta robe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Količina robe/usluge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Robu izdao/uslugu izvršio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reg. oznaka kamiona:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vrsta usluge:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Radilište:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Vozać:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vrsta stroja:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Naručitelj:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 286);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Primatelj robe/usluge:";
            // 
            // txtVrstaRobe
            // 
            this.txtVrstaRobe.Location = new System.Drawing.Point(130, 41);
            this.txtVrstaRobe.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrstaRobe.Name = "txtVrstaRobe";
            this.txtVrstaRobe.Size = new System.Drawing.Size(151, 20);
            this.txtVrstaRobe.TabIndex = 12;
            // 
            // txtPrimateljRobe
            // 
            this.txtPrimateljRobe.Location = new System.Drawing.Point(130, 281);
            this.txtPrimateljRobe.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimateljRobe.Name = "txtPrimateljRobe";
            this.txtPrimateljRobe.Size = new System.Drawing.Size(151, 20);
            this.txtPrimateljRobe.TabIndex = 15;
            // 
            // txtNarucitelj
            // 
            this.txtNarucitelj.Location = new System.Drawing.Point(130, 256);
            this.txtNarucitelj.Margin = new System.Windows.Forms.Padding(2);
            this.txtNarucitelj.Name = "txtNarucitelj";
            this.txtNarucitelj.Size = new System.Drawing.Size(151, 20);
            this.txtNarucitelj.TabIndex = 16;
            // 
            // txtVrstaStroja
            // 
            this.txtVrstaStroja.Location = new System.Drawing.Point(130, 231);
            this.txtVrstaStroja.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrstaStroja.Name = "txtVrstaStroja";
            this.txtVrstaStroja.Size = new System.Drawing.Size(151, 20);
            this.txtVrstaStroja.TabIndex = 17;
            // 
            // txtVozac
            // 
            this.txtVozac.Location = new System.Drawing.Point(130, 205);
            this.txtVozac.Margin = new System.Windows.Forms.Padding(2);
            this.txtVozac.Name = "txtVozac";
            this.txtVozac.Size = new System.Drawing.Size(151, 20);
            this.txtVozac.TabIndex = 18;
            // 
            // txtRadilište
            // 
            this.txtRadilište.Location = new System.Drawing.Point(130, 179);
            this.txtRadilište.Margin = new System.Windows.Forms.Padding(2);
            this.txtRadilište.Name = "txtRadilište";
            this.txtRadilište.Size = new System.Drawing.Size(151, 20);
            this.txtRadilište.TabIndex = 19;
            // 
            // txtVrstaUsluge
            // 
            this.txtVrstaUsluge.Location = new System.Drawing.Point(130, 153);
            this.txtVrstaUsluge.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrstaUsluge.Name = "txtVrstaUsluge";
            this.txtVrstaUsluge.Size = new System.Drawing.Size(151, 20);
            this.txtVrstaUsluge.TabIndex = 20;
            // 
            // txtRegOznakaKamiona
            // 
            this.txtRegOznakaKamiona.Location = new System.Drawing.Point(130, 126);
            this.txtRegOznakaKamiona.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegOznakaKamiona.Name = "txtRegOznakaKamiona";
            this.txtRegOznakaKamiona.Size = new System.Drawing.Size(151, 20);
            this.txtRegOznakaKamiona.TabIndex = 21;
            // 
            // txtRobuIzdao
            // 
            this.txtRobuIzdao.Location = new System.Drawing.Point(130, 96);
            this.txtRobuIzdao.Margin = new System.Windows.Forms.Padding(2);
            this.txtRobuIzdao.Name = "txtRobuIzdao";
            this.txtRobuIzdao.Size = new System.Drawing.Size(151, 20);
            this.txtRobuIzdao.TabIndex = 22;
            // 
            // TxtKolicinaRobe
            // 
            this.TxtKolicinaRobe.Location = new System.Drawing.Point(130, 67);
            this.TxtKolicinaRobe.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKolicinaRobe.Name = "TxtKolicinaRobe";
            this.TxtKolicinaRobe.Size = new System.Drawing.Size(151, 20);
            this.TxtKolicinaRobe.TabIndex = 23;
            // 
            // btnSaveRn
            // 
            this.btnSaveRn.Location = new System.Drawing.Point(130, 312);
            this.btnSaveRn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveRn.Name = "btnSaveRn";
            this.btnSaveRn.Size = new System.Drawing.Size(56, 19);
            this.btnSaveRn.TabIndex = 24;
            this.btnSaveRn.Text = "Spremin radni nalog";
            this.btnSaveRn.UseVisualStyleBackColor = true;
            this.btnSaveRn.Click += new System.EventHandler(this.btnSaveRn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRadniNalog);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnSaveRn);
            this.tabPage1.Controls.Add(this.TxtKolicinaRobe);
            this.tabPage1.Controls.Add(this.txtRobuIzdao);
            this.tabPage1.Controls.Add(this.txtRegOznakaKamiona);
            this.tabPage1.Controls.Add(this.txtVrstaUsluge);
            this.tabPage1.Controls.Add(this.txtRadilište);
            this.tabPage1.Controls.Add(this.txtVozac);
            this.tabPage1.Controls.Add(this.txtVrstaStroja);
            this.tabPage1.Controls.Add(this.txtNarucitelj);
            this.tabPage1.Controls.Add(this.txtPrimateljRobe);
            this.tabPage1.Controls.Add(this.txtVrstaRobe);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpDatum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(574, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unos radnog naloga";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRadniNalog
            // 
            this.txtRadniNalog.Location = new System.Drawing.Point(419, 17);
            this.txtRadniNalog.Margin = new System.Windows.Forms.Padding(2);
            this.txtRadniNalog.Name = "txtRadniNalog";
            this.txtRadniNalog.Size = new System.Drawing.Size(151, 20);
            this.txtRadniNalog.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Radni nalog/Otpremnica:";
            // 
            // RadniNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 383);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RadniNalozi";
            this.Text = "Radni nalozi";
            this.Load += new System.EventHandler(this.RadniNalozi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddgRadniNalozi)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ddgRadniNalozi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRadniNalog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveRn;
        private System.Windows.Forms.TextBox TxtKolicinaRobe;
        private System.Windows.Forms.TextBox txtRobuIzdao;
        private System.Windows.Forms.TextBox txtRegOznakaKamiona;
        private System.Windows.Forms.TextBox txtVrstaUsluge;
        private System.Windows.Forms.TextBox txtRadilište;
        private System.Windows.Forms.TextBox txtVozac;
        private System.Windows.Forms.TextBox txtVrstaStroja;
        private System.Windows.Forms.TextBox txtNarucitelj;
        private System.Windows.Forms.TextBox txtPrimateljRobe;
        private System.Windows.Forms.TextBox txtVrstaRobe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

