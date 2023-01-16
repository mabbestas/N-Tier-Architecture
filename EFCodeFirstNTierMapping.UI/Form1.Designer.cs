
namespace EFCodeFirstNTierMapping.UI
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
            this.grpAddFilm = new System.Windows.Forms.GroupBox();
            this.grpFilms = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.txtFilmDetail = new System.Windows.Forms.TextBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.lstFilms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.grpAddFilm.SuspendLayout();
            this.grpFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddFilm
            // 
            this.grpAddFilm.Controls.Add(this.cmbCategoryName);
            this.grpAddFilm.Controls.Add(this.btnAddFilm);
            this.grpAddFilm.Controls.Add(this.txtFilmDetail);
            this.grpAddFilm.Controls.Add(this.txtFilmName);
            this.grpAddFilm.Controls.Add(this.label3);
            this.grpAddFilm.Controls.Add(this.label2);
            this.grpAddFilm.Controls.Add(this.label1);
            this.grpAddFilm.Location = new System.Drawing.Point(20, 15);
            this.grpAddFilm.Name = "grpAddFilm";
            this.grpAddFilm.Size = new System.Drawing.Size(305, 174);
            this.grpAddFilm.TabIndex = 0;
            this.grpAddFilm.TabStop = false;
            this.grpAddFilm.Text = "Film Ekleme";
            // 
            // grpFilms
            // 
            this.grpFilms.Controls.Add(this.lstFilms);
            this.grpFilms.Location = new System.Drawing.Point(20, 229);
            this.grpFilms.Name = "grpFilms";
            this.grpFilms.Size = new System.Drawing.Size(463, 225);
            this.grpFilms.TabIndex = 1;
            this.grpFilms.TabStop = false;
            this.grpFilms.Text = "Filmler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FilmDetayı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Adı:";
            // 
            // txtFilmName
            // 
            this.txtFilmName.Location = new System.Drawing.Point(88, 36);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(126, 20);
            this.txtFilmName.TabIndex = 3;
            // 
            // txtFilmDetail
            // 
            this.txtFilmDetail.Location = new System.Drawing.Point(88, 65);
            this.txtFilmDetail.Name = "txtFilmDetail";
            this.txtFilmDetail.Size = new System.Drawing.Size(126, 20);
            this.txtFilmDetail.TabIndex = 4;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(72, 132);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(126, 25);
            this.btnAddFilm.TabIndex = 6;
            this.btnAddFilm.Text = "Film Ekle";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // lstFilms
            // 
            this.lstFilms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstFilms.GridLines = true;
            this.lstFilms.HideSelection = false;
            this.lstFilms.Location = new System.Drawing.Point(6, 19);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(451, 206);
            this.lstFilms.TabIndex = 0;
            this.lstFilms.UseCompatibleStateImageBehavior = false;
            this.lstFilms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 120;
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(88, 92);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(126, 21);
            this.cmbCategoryName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 466);
            this.Controls.Add(this.grpFilms);
            this.Controls.Add(this.grpAddFilm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddFilm.ResumeLayout(false);
            this.grpAddFilm.PerformLayout();
            this.grpFilms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.TextBox txtFilmDetail;
        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFilms;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        public System.Windows.Forms.ListView lstFilms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

