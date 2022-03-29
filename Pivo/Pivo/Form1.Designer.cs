namespace Pivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxCerna12 = new System.Windows.Forms.TextBox();
            this.txtBoxSvetla12 = new System.Windows.Forms.TextBox();
            this.txtBoxNeGrep = new System.Windows.Forms.TextBox();
            this.txtBoxSpecialLH = new System.Windows.Forms.TextBox();
            this.txtBoxBirellLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVlozit = new System.Windows.Forms.Button();
            this.rdbBtnCerna12 = new System.Windows.Forms.RadioButton();
            this.rdbButtonSvetla12 = new System.Windows.Forms.RadioButton();
            this.rdbBtnNealkoGrep = new System.Windows.Forms.RadioButton();
            this.rdbBtnStarySpecial = new System.Windows.Forms.RadioButton();
            this.rdbBtnBirell = new System.Windows.Forms.RadioButton();
            this.btnTady = new System.Windows.Forms.Button();
            this.btnStanek = new System.Windows.Forms.Button();
            this.btnSebou = new System.Windows.Forms.Button();
            this.lblVyslednaCena = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObjednavka = new System.Windows.Forms.Button();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxCerna12
            // 
            this.txtBoxCerna12.Location = new System.Drawing.Point(114, 17);
            this.txtBoxCerna12.Name = "txtBoxCerna12";
            this.txtBoxCerna12.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCerna12.TabIndex = 0;
            // 
            // txtBoxSvetla12
            // 
            this.txtBoxSvetla12.Location = new System.Drawing.Point(114, 51);
            this.txtBoxSvetla12.Name = "txtBoxSvetla12";
            this.txtBoxSvetla12.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSvetla12.TabIndex = 1;
            // 
            // txtBoxNeGrep
            // 
            this.txtBoxNeGrep.Location = new System.Drawing.Point(114, 91);
            this.txtBoxNeGrep.Name = "txtBoxNeGrep";
            this.txtBoxNeGrep.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNeGrep.TabIndex = 2;
            // 
            // txtBoxSpecialLH
            // 
            this.txtBoxSpecialLH.Location = new System.Drawing.Point(114, 133);
            this.txtBoxSpecialLH.Name = "txtBoxSpecialLH";
            this.txtBoxSpecialLH.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSpecialLH.TabIndex = 3;
            // 
            // txtBoxBirellLH
            // 
            this.txtBoxBirellLH.Location = new System.Drawing.Point(114, 179);
            this.txtBoxBirellLH.Name = "txtBoxBirellLH";
            this.txtBoxBirellLH.Size = new System.Drawing.Size(100, 23);
            this.txtBoxBirellLH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Černá 12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Světlá 12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nealko grep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Starý speciál lh.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birell lahev";
            // 
            // btnVlozit
            // 
            this.btnVlozit.Location = new System.Drawing.Point(12, 245);
            this.btnVlozit.Name = "btnVlozit";
            this.btnVlozit.Size = new System.Drawing.Size(75, 23);
            this.btnVlozit.TabIndex = 10;
            this.btnVlozit.Text = "Vlož ceny";
            this.btnVlozit.UseVisualStyleBackColor = true;
            this.btnVlozit.Click += new System.EventHandler(this.btnVlozit_Click);
            // 
            // rdbBtnCerna12
            // 
            this.rdbBtnCerna12.AutoSize = true;
            this.rdbBtnCerna12.Location = new System.Drawing.Point(17, 22);
            this.rdbBtnCerna12.Name = "rdbBtnCerna12";
            this.rdbBtnCerna12.Size = new System.Drawing.Size(71, 19);
            this.rdbBtnCerna12.TabIndex = 11;
            this.rdbBtnCerna12.TabStop = true;
            this.rdbBtnCerna12.Text = "Černá 12";
            this.rdbBtnCerna12.UseVisualStyleBackColor = true;
            // 
            // rdbButtonSvetla12
            // 
            this.rdbButtonSvetla12.AutoSize = true;
            this.rdbButtonSvetla12.Location = new System.Drawing.Point(17, 47);
            this.rdbButtonSvetla12.Name = "rdbButtonSvetla12";
            this.rdbButtonSvetla12.Size = new System.Drawing.Size(71, 19);
            this.rdbButtonSvetla12.TabIndex = 12;
            this.rdbButtonSvetla12.TabStop = true;
            this.rdbButtonSvetla12.Text = "Světlá 12";
            this.rdbButtonSvetla12.UseVisualStyleBackColor = true;
            // 
            // rdbBtnNealkoGrep
            // 
            this.rdbBtnNealkoGrep.AutoSize = true;
            this.rdbBtnNealkoGrep.Location = new System.Drawing.Point(17, 71);
            this.rdbBtnNealkoGrep.Name = "rdbBtnNealkoGrep";
            this.rdbBtnNealkoGrep.Size = new System.Drawing.Size(90, 19);
            this.rdbBtnNealkoGrep.TabIndex = 13;
            this.rdbBtnNealkoGrep.TabStop = true;
            this.rdbBtnNealkoGrep.Text = "Nealko Grep";
            this.rdbBtnNealkoGrep.UseVisualStyleBackColor = true;
            // 
            // rdbBtnStarySpecial
            // 
            this.rdbBtnStarySpecial.AutoSize = true;
            this.rdbBtnStarySpecial.Location = new System.Drawing.Point(104, 22);
            this.rdbBtnStarySpecial.Name = "rdbBtnStarySpecial";
            this.rdbBtnStarySpecial.Size = new System.Drawing.Size(90, 19);
            this.rdbBtnStarySpecial.TabIndex = 14;
            this.rdbBtnStarySpecial.TabStop = true;
            this.rdbBtnStarySpecial.Text = "Starý speciál";
            this.rdbBtnStarySpecial.UseVisualStyleBackColor = true;
            // 
            // rdbBtnBirell
            // 
            this.rdbBtnBirell.AutoSize = true;
            this.rdbBtnBirell.Location = new System.Drawing.Point(104, 53);
            this.rdbBtnBirell.Name = "rdbBtnBirell";
            this.rdbBtnBirell.Size = new System.Drawing.Size(83, 19);
            this.rdbBtnBirell.TabIndex = 15;
            this.rdbBtnBirell.TabStop = true;
            this.rdbBtnBirell.Text = "Birell plech";
            this.rdbBtnBirell.UseVisualStyleBackColor = true;
            // 
            // btnTady
            // 
            this.btnTady.Location = new System.Drawing.Point(390, 343);
            this.btnTady.Name = "btnTady";
            this.btnTady.Size = new System.Drawing.Size(82, 37);
            this.btnTady.TabIndex = 16;
            this.btnTady.Text = "Tady";
            this.btnTady.UseVisualStyleBackColor = true;
            this.btnTady.Click += new System.EventHandler(this.btnTady_Click);
            // 
            // btnStanek
            // 
            this.btnStanek.Location = new System.Drawing.Point(566, 343);
            this.btnStanek.Name = "btnStanek";
            this.btnStanek.Size = new System.Drawing.Size(82, 37);
            this.btnStanek.TabIndex = 17;
            this.btnStanek.Text = "Stánek";
            this.btnStanek.UseVisualStyleBackColor = true;
            // 
            // btnSebou
            // 
            this.btnSebou.Location = new System.Drawing.Point(478, 343);
            this.btnSebou.Name = "btnSebou";
            this.btnSebou.Size = new System.Drawing.Size(82, 37);
            this.btnSebou.TabIndex = 18;
            this.btnSebou.Text = "Sebou";
            this.btnSebou.UseVisualStyleBackColor = true;
            // 
            // lblVyslednaCena
            // 
            this.lblVyslednaCena.AutoSize = true;
            this.lblVyslednaCena.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVyslednaCena.Location = new System.Drawing.Point(390, 17);
            this.lblVyslednaCena.Name = "lblVyslednaCena";
            this.lblVyslednaCena.Size = new System.Drawing.Size(74, 89);
            this.lblVyslednaCena.TabIndex = 19;
            this.lblVyslednaCena.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBtnCerna12);
            this.groupBox1.Controls.Add(this.rdbButtonSvetla12);
            this.groupBox1.Controls.Add(this.rdbBtnNealkoGrep);
            this.groupBox1.Controls.Add(this.rdbBtnStarySpecial);
            this.groupBox1.Controls.Add(this.rdbBtnBirell);
            this.groupBox1.Location = new System.Drawing.Point(390, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Položky";
            // 
            // btnObjednavka
            // 
            this.btnObjednavka.Location = new System.Drawing.Point(390, 386);
            this.btnObjednavka.Name = "btnObjednavka";
            this.btnObjednavka.Size = new System.Drawing.Size(258, 62);
            this.btnObjednavka.TabIndex = 21;
            this.btnObjednavka.Text = "Dokončit objednávku";
            this.btnObjednavka.UseVisualStyleBackColor = true;
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(12, 415);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(349, 23);
            this.pgBar.Step = 25;
            this.pgBar.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.btnObjednavka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVyslednaCena);
            this.Controls.Add(this.btnSebou);
            this.Controls.Add(this.btnStanek);
            this.Controls.Add(this.btnTady);
            this.Controls.Add(this.btnVlozit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBirellLH);
            this.Controls.Add(this.txtBoxSpecialLH);
            this.Controls.Add(this.txtBoxNeGrep);
            this.Controls.Add(this.txtBoxSvetla12);
            this.Controls.Add(this.txtBoxCerna12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxCerna12;
        private TextBox txtBoxSvetla12;
        private TextBox txtBoxNeGrep;
        private TextBox txtBoxSpecialLH;
        private TextBox txtBoxBirellLH;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVlozit;
        private RadioButton rdbBtnCerna12;
        private RadioButton rdbButtonSvetla12;
        private RadioButton rdbBtnNealkoGrep;
        private RadioButton rdbBtnStarySpecial;
        private RadioButton rdbBtnBirell;
        private Button btnTady;
        private Button btnStanek;
        private Button btnSebou;
        private Label lblVyslednaCena;
        private GroupBox groupBox1;
        private Button btnObjednavka;
        private ProgressBar pgBar;
    }
}