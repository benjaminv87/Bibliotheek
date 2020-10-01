namespace BoekenApp
{
    partial class AdvancedFilterForm
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
            this.btnBoekToevoegen = new System.Windows.Forms.Button();
            this.dtPublicatieDatum = new System.Windows.Forms.DateTimePicker();
            this.cbUitgeverij = new System.Windows.Forms.ComboBox();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.numAantalPaginas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.gbAantalPaginas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAantalPaginas)).BeginInit();
            this.gbAantalPaginas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoekToevoegen
            // 
            this.btnBoekToevoegen.Location = new System.Drawing.Point(21, 397);
            this.btnBoekToevoegen.Name = "btnBoekToevoegen";
            this.btnBoekToevoegen.Size = new System.Drawing.Size(294, 23);
            this.btnBoekToevoegen.TabIndex = 48;
            this.btnBoekToevoegen.Text = "Filter toepassen";
            this.btnBoekToevoegen.UseVisualStyleBackColor = true;
            // 
            // dtPublicatieDatum
            // 
            this.dtPublicatieDatum.Location = new System.Drawing.Point(6, 33);
            this.dtPublicatieDatum.Name = "dtPublicatieDatum";
            this.dtPublicatieDatum.Size = new System.Drawing.Size(165, 20);
            this.dtPublicatieDatum.TabIndex = 47;
            // 
            // cbUitgeverij
            // 
            this.cbUitgeverij.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbUitgeverij.FormattingEnabled = true;
            this.cbUitgeverij.Location = new System.Drawing.Point(75, 218);
            this.cbUitgeverij.Name = "cbUitgeverij";
            this.cbUitgeverij.Size = new System.Drawing.Size(162, 21);
            this.cbUitgeverij.TabIndex = 46;
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(35, 56);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(46, 20);
            this.numScore.TabIndex = 45;
            // 
            // numAantalPaginas
            // 
            this.numAantalPaginas.Location = new System.Drawing.Point(35, 30);
            this.numAantalPaginas.Name = "numAantalPaginas";
            this.numAantalPaginas.Size = new System.Drawing.Size(46, 20);
            this.numAantalPaginas.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Uitgeverij :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Genres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Auteur(s)";
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(161, 271);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbGenres.Size = new System.Drawing.Size(148, 95);
            this.lbGenres.TabIndex = 36;
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.Location = new System.Drawing.Point(15, 271);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAuteurs.Size = new System.Drawing.Size(140, 95);
            this.lbAuteurs.TabIndex = 35;
            // 
            // gbAantalPaginas
            // 
            this.gbAantalPaginas.Controls.Add(this.label3);
            this.gbAantalPaginas.Controls.Add(this.numAantalPaginas);
            this.gbAantalPaginas.Controls.Add(this.label4);
            this.gbAantalPaginas.Controls.Add(this.numScore);
            this.gbAantalPaginas.Location = new System.Drawing.Point(12, 12);
            this.gbAantalPaginas.Name = "gbAantalPaginas";
            this.gbAantalPaginas.Size = new System.Drawing.Size(102, 88);
            this.gbAantalPaginas.TabIndex = 52;
            this.gbAantalPaginas.TabStop = false;
            this.gbAantalPaginas.Text = "Aantal Paginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "min";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtPublicatieDatum);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 100);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "publicatie datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Verschenen na:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Verschenen voor:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(120, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 88);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "min";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "max";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(35, 56);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown2.TabIndex = 49;
            // 
            // AdvancedFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAantalPaginas);
            this.Controls.Add(this.btnBoekToevoegen);
            this.Controls.Add(this.cbUitgeverij);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lbAuteurs);
            this.Name = "AdvancedFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdvancedFilterForm";
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAantalPaginas)).EndInit();
            this.gbAantalPaginas.ResumeLayout(false);
            this.gbAantalPaginas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoekToevoegen;
        private System.Windows.Forms.DateTimePicker dtPublicatieDatum;
        private System.Windows.Forms.ComboBox cbUitgeverij;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.NumericUpDown numAantalPaginas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.ListBox lbAuteurs;
        private System.Windows.Forms.GroupBox gbAantalPaginas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
    }
}