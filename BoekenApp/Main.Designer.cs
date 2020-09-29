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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbBoeken
            // 
            this.lbBoeken.FormattingEnabled = true;
            this.lbBoeken.Location = new System.Drawing.Point(12, 38);
            this.lbBoeken.Name = "lbBoeken";
            this.lbBoeken.Size = new System.Drawing.Size(235, 303);
            this.lbBoeken.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(253, 38);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(127, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Bekijk info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBoekToevoegen
            // 
            this.btnBoekToevoegen.Location = new System.Drawing.Point(253, 229);
            this.btnBoekToevoegen.Name = "btnBoekToevoegen";
            this.btnBoekToevoegen.Size = new System.Drawing.Size(131, 23);
            this.btnBoekToevoegen.TabIndex = 2;
            this.btnBoekToevoegen.Text = "Boek Toevoegen";
            this.btnBoekToevoegen.UseVisualStyleBackColor = true;
            this.btnBoekToevoegen.Click += new System.EventHandler(this.btnBoekToevoegen_Click);
            // 
            // btnAuteurToevoegen
            // 
            this.btnAuteurToevoegen.Location = new System.Drawing.Point(253, 258);
            this.btnAuteurToevoegen.Name = "btnAuteurToevoegen";
            this.btnAuteurToevoegen.Size = new System.Drawing.Size(131, 23);
            this.btnAuteurToevoegen.TabIndex = 3;
            this.btnAuteurToevoegen.Text = "AuteurToevoegen";
            this.btnAuteurToevoegen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Genre Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Uitgeverij Toevoegen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(12, 12);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(235, 21);
            this.cbCategorie.TabIndex = 6;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 387);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAuteurToevoegen);
            this.Controls.Add(this.btnBoekToevoegen);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbBoeken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoeken;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBoekToevoegen;
        private System.Windows.Forms.Button btnAuteurToevoegen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbCategorie;
    }
}

