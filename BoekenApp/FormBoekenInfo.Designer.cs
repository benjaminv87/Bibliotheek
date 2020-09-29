namespace BoekenApp
{
    partial class FormBoekenInfo
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPublicatie = new System.Windows.Forms.Label();
            this.lblUitgeverij = new System.Windows.Forms.Label();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(101, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(23, 13);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "titel";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(101, 34);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(77, 13);
            this.lblPaginas.TabIndex = 1;
            this.lblPaginas.Text = "Aantal paginas";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(101, 58);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            // 
            // lblPublicatie
            // 
            this.lblPublicatie.AutoSize = true;
            this.lblPublicatie.Location = new System.Drawing.Point(101, 82);
            this.lblPublicatie.Name = "lblPublicatie";
            this.lblPublicatie.Size = new System.Drawing.Size(53, 13);
            this.lblPublicatie.TabIndex = 3;
            this.lblPublicatie.Text = "Publicatie";
            // 
            // lblUitgeverij
            // 
            this.lblUitgeverij.AutoSize = true;
            this.lblUitgeverij.Location = new System.Drawing.Point(101, 128);
            this.lblUitgeverij.Name = "lblUitgeverij";
            this.lblUitgeverij.Size = new System.Drawing.Size(51, 13);
            this.lblUitgeverij.TabIndex = 5;
            this.lblUitgeverij.Text = "Uitgeverij";
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(15, 168);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbGenres.Size = new System.Drawing.Size(121, 95);
            this.lbGenres.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Aantal Paginas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Publicatie :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Auteur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Uitgeverij :";
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.Location = new System.Drawing.Point(150, 168);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbAuteurs.Size = new System.Drawing.Size(120, 95);
            this.lbAuteurs.TabIndex = 14;
            // 
            // FormBoekenInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 273);
            this.Controls.Add(this.lbAuteurs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lblUitgeverij);
            this.Controls.Add(this.lblPublicatie);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblTitel);
            this.Name = "FormBoekenInfo";
            this.Text = "BoekenInfo";
            this.Load += new System.EventHandler(this.BoekenInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPublicatie;
        private System.Windows.Forms.Label lblUitgeverij;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbAuteurs;
    }
}