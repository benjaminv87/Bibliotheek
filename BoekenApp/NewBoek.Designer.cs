namespace BoekenApp
{
    partial class NewBoek
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
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.numAantalPaginas = new System.Windows.Forms.NumericUpDown();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.cbUitgeverij = new System.Windows.Forms.ComboBox();
            this.dtPublicatieDatum = new System.Windows.Forms.DateTimePicker();
            this.btnBoekToevoegen = new System.Windows.Forms.Button();
            this.btnUitgeverijToevoegen = new System.Windows.Forms.Button();
            this.btnNieuweAuteur = new System.Windows.Forms.Button();
            this.btnNieuwGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAantalPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.Location = new System.Drawing.Point(12, 136);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAuteurs.Size = new System.Drawing.Size(140, 160);
            this.lbAuteurs.TabIndex = 7;
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(158, 136);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbGenres.Size = new System.Drawing.Size(148, 160);
            this.lbGenres.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auteur(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Uitgeverij :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Publicatie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Aantal Paginas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Titel :";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(105, 6);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(201, 20);
            this.tbTitel.TabIndex = 1;
            // 
            // numAantalPaginas
            // 
            this.numAantalPaginas.Location = new System.Drawing.Point(106, 32);
            this.numAantalPaginas.Name = "numAantalPaginas";
            this.numAantalPaginas.Size = new System.Drawing.Size(46, 20);
            this.numAantalPaginas.TabIndex = 2;
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(260, 32);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(46, 20);
            this.numScore.TabIndex = 3;
            // 
            // cbUitgeverij
            // 
            this.cbUitgeverij.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbUitgeverij.FormattingEnabled = true;
            this.cbUitgeverij.Location = new System.Drawing.Point(106, 89);
            this.cbUitgeverij.Name = "cbUitgeverij";
            this.cbUitgeverij.Size = new System.Drawing.Size(162, 21);
            this.cbUitgeverij.TabIndex = 5;
            // 
            // dtPublicatieDatum
            // 
            this.dtPublicatieDatum.Location = new System.Drawing.Point(105, 58);
            this.dtPublicatieDatum.Name = "dtPublicatieDatum";
            this.dtPublicatieDatum.Size = new System.Drawing.Size(200, 20);
            this.dtPublicatieDatum.TabIndex = 4;
            // 
            // btnBoekToevoegen
            // 
            this.btnBoekToevoegen.Location = new System.Drawing.Point(11, 332);
            this.btnBoekToevoegen.Name = "btnBoekToevoegen";
            this.btnBoekToevoegen.Size = new System.Drawing.Size(294, 23);
            this.btnBoekToevoegen.TabIndex = 11;
            this.btnBoekToevoegen.Text = "Boek toevoegen";
            this.btnBoekToevoegen.UseVisualStyleBackColor = true;
            this.btnBoekToevoegen.Click += new System.EventHandler(this.btnBoekToevoegen_Click);
            // 
            // btnUitgeverijToevoegen
            // 
            this.btnUitgeverijToevoegen.Location = new System.Drawing.Point(274, 89);
            this.btnUitgeverijToevoegen.Name = "btnUitgeverijToevoegen";
            this.btnUitgeverijToevoegen.Size = new System.Drawing.Size(31, 21);
            this.btnUitgeverijToevoegen.TabIndex = 6;
            this.btnUitgeverijToevoegen.Text = "+";
            this.btnUitgeverijToevoegen.UseVisualStyleBackColor = true;
            this.btnUitgeverijToevoegen.Click += new System.EventHandler(this.btnUitgeverijToevoegen_Click);
            // 
            // btnNieuweAuteur
            // 
            this.btnNieuweAuteur.Location = new System.Drawing.Point(12, 302);
            this.btnNieuweAuteur.Name = "btnNieuweAuteur";
            this.btnNieuweAuteur.Size = new System.Drawing.Size(141, 21);
            this.btnNieuweAuteur.TabIndex = 8;
            this.btnNieuweAuteur.Text = "+";
            this.btnNieuweAuteur.UseVisualStyleBackColor = true;
            this.btnNieuweAuteur.Click += new System.EventHandler(this.btnNieuweAuteur_Click);
            // 
            // btnNieuwGenre
            // 
            this.btnNieuwGenre.Location = new System.Drawing.Point(158, 302);
            this.btnNieuwGenre.Name = "btnNieuwGenre";
            this.btnNieuwGenre.Size = new System.Drawing.Size(147, 21);
            this.btnNieuwGenre.TabIndex = 10;
            this.btnNieuwGenre.Text = "+";
            this.btnNieuwGenre.UseVisualStyleBackColor = true;
            this.btnNieuwGenre.Click += new System.EventHandler(this.btnNieuwGenre_Click);
            // 
            // NewBoek
            // 
            this.AcceptButton = this.btnBoekToevoegen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 367);
            this.Controls.Add(this.btnNieuwGenre);
            this.Controls.Add(this.btnNieuweAuteur);
            this.Controls.Add(this.btnUitgeverijToevoegen);
            this.Controls.Add(this.btnBoekToevoegen);
            this.Controls.Add(this.dtPublicatieDatum);
            this.Controls.Add(this.cbUitgeverij);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.numAantalPaginas);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lbAuteurs);
            this.Name = "NewBoek";
            this.Text = "Boek toevoegen";
            this.Load += new System.EventHandler(this.NewBoek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAantalPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAuteurs;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.NumericUpDown numAantalPaginas;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.ComboBox cbUitgeverij;
        private System.Windows.Forms.DateTimePicker dtPublicatieDatum;
        private System.Windows.Forms.Button btnBoekToevoegen;
        private System.Windows.Forms.Button btnUitgeverijToevoegen;
        private System.Windows.Forms.Button btnNieuweAuteur;
        private System.Windows.Forms.Button btnNieuwGenre;
    }
}