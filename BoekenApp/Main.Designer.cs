namespace BoekenApp
{
    partial class Form1
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
            this.lbBoeken = new System.Windows.Forms.ListBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBoekToevoegen = new System.Windows.Forms.Button();
            this.btnAuteurToevoegen = new System.Windows.Forms.Button();
            this.btnGenreToevoegen = new System.Windows.Forms.Button();
            this.btnNieuweUitgeverij = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbBoeken
            // 
            this.lbBoeken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBoeken.FormattingEnabled = true;
            this.lbBoeken.Location = new System.Drawing.Point(12, 38);
            this.lbBoeken.MultiColumn = true;
            this.lbBoeken.Name = "lbBoeken";
            this.lbBoeken.Size = new System.Drawing.Size(235, 290);
            this.lbBoeken.TabIndex = 0;
            this.lbBoeken.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbBoeken_MouseDoubleClick);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Location = new System.Drawing.Point(253, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(127, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Bekijk info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBoekToevoegen
            // 
            this.btnBoekToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoekToevoegen.Location = new System.Drawing.Point(253, 218);
            this.btnBoekToevoegen.Name = "btnBoekToevoegen";
            this.btnBoekToevoegen.Size = new System.Drawing.Size(131, 23);
            this.btnBoekToevoegen.TabIndex = 2;
            this.btnBoekToevoegen.Text = "Boek Toevoegen";
            this.btnBoekToevoegen.UseVisualStyleBackColor = true;
            this.btnBoekToevoegen.Click += new System.EventHandler(this.btnBoekToevoegen_Click);
            // 
            // btnAuteurToevoegen
            // 
            this.btnAuteurToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuteurToevoegen.Location = new System.Drawing.Point(253, 247);
            this.btnAuteurToevoegen.Name = "btnAuteurToevoegen";
            this.btnAuteurToevoegen.Size = new System.Drawing.Size(131, 23);
            this.btnAuteurToevoegen.TabIndex = 3;
            this.btnAuteurToevoegen.Text = "AuteurToevoegen";
            this.btnAuteurToevoegen.UseVisualStyleBackColor = true;
            this.btnAuteurToevoegen.Click += new System.EventHandler(this.btnAuteurToevoegen_Click);
            // 
            // btnGenreToevoegen
            // 
            this.btnGenreToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenreToevoegen.Location = new System.Drawing.Point(253, 276);
            this.btnGenreToevoegen.Name = "btnGenreToevoegen";
            this.btnGenreToevoegen.Size = new System.Drawing.Size(131, 23);
            this.btnGenreToevoegen.TabIndex = 4;
            this.btnGenreToevoegen.Text = "Genre Toevoegen";
            this.btnGenreToevoegen.UseVisualStyleBackColor = true;
            this.btnGenreToevoegen.Click += new System.EventHandler(this.btnGenreToevoegen_Click);
            // 
            // btnNieuweUitgeverij
            // 
            this.btnNieuweUitgeverij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNieuweUitgeverij.Location = new System.Drawing.Point(253, 305);
            this.btnNieuweUitgeverij.Name = "btnNieuweUitgeverij";
            this.btnNieuweUitgeverij.Size = new System.Drawing.Size(131, 23);
            this.btnNieuweUitgeverij.TabIndex = 5;
            this.btnNieuweUitgeverij.Text = "Uitgeverij Toevoegen";
            this.btnNieuweUitgeverij.UseVisualStyleBackColor = true;
            this.btnNieuweUitgeverij.Click += new System.EventHandler(this.btnNieuweUitgeverij_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(12, 12);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategorie.Size = new System.Drawing.Size(235, 21);
            this.cbCategorie.TabIndex = 6;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 336);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.btnNieuweUitgeverij);
            this.Controls.Add(this.btnGenreToevoegen);
            this.Controls.Add(this.btnAuteurToevoegen);
            this.Controls.Add(this.btnBoekToevoegen);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbBoeken);
            this.MinimumSize = new System.Drawing.Size(410, 375);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoeken;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBoekToevoegen;
        private System.Windows.Forms.Button btnAuteurToevoegen;
        private System.Windows.Forms.Button btnGenreToevoegen;
        private System.Windows.Forms.Button btnNieuweUitgeverij;
        private System.Windows.Forms.ComboBox cbCategorie;
    }
}

