
namespace LatvanyossagokApplication
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
            this.grpBx_varos = new System.Windows.Forms.GroupBox();
            this.bttn_varos = new System.Windows.Forms.Button();
            this.txtBx_lakossag = new System.Windows.Forms.TextBox();
            this.txtBx_varosnev = new System.Windows.Forms.TextBox();
            this.grpBx_latvanyossag = new System.Windows.Forms.GroupBox();
            this.txtBx_nevLatvanyossag = new System.Windows.Forms.TextBox();
            this.bttn_latvanyossag = new System.Windows.Forms.Button();
            this.txtBx_leiras = new System.Windows.Forms.TextBox();
            this.cmbBx_nev = new System.Windows.Forms.ComboBox();
            this.txtBx_ar = new System.Windows.Forms.TextBox();
            this.lstBx_varosok = new System.Windows.Forms.ListBox();
            this.bttn_varosMod = new System.Windows.Forms.Button();
            this.lstBx_latvanyossagok = new System.Windows.Forms.ListBox();
            this.bttn_latvanyossagMod = new System.Windows.Forms.Button();
            this.grpBx_varos.SuspendLayout();
            this.grpBx_latvanyossag.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBx_varos
            // 
            this.grpBx_varos.Controls.Add(this.bttn_varos);
            this.grpBx_varos.Controls.Add(this.txtBx_lakossag);
            this.grpBx_varos.Controls.Add(this.txtBx_varosnev);
            this.grpBx_varos.Location = new System.Drawing.Point(12, 12);
            this.grpBx_varos.Name = "grpBx_varos";
            this.grpBx_varos.Size = new System.Drawing.Size(219, 138);
            this.grpBx_varos.TabIndex = 0;
            this.grpBx_varos.TabStop = false;
            this.grpBx_varos.Text = "Város hozzáadása";
            // 
            // bttn_varos
            // 
            this.bttn_varos.Location = new System.Drawing.Point(6, 92);
            this.bttn_varos.Name = "bttn_varos";
            this.bttn_varos.Size = new System.Drawing.Size(203, 40);
            this.bttn_varos.TabIndex = 1;
            this.bttn_varos.Text = "Hozzáad";
            this.bttn_varos.UseVisualStyleBackColor = true;
            this.bttn_varos.Click += new System.EventHandler(this.bttn_varos_Click);
            // 
            // txtBx_lakossag
            // 
            this.txtBx_lakossag.Location = new System.Drawing.Point(6, 59);
            this.txtBx_lakossag.Name = "txtBx_lakossag";
            this.txtBx_lakossag.PlaceholderText = "Adja meg a város lakosságát..";
            this.txtBx_lakossag.Size = new System.Drawing.Size(203, 27);
            this.txtBx_lakossag.TabIndex = 2;
            this.txtBx_lakossag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_lakossag_KeyPress);
            // 
            // txtBx_varosnev
            // 
            this.txtBx_varosnev.Location = new System.Drawing.Point(6, 26);
            this.txtBx_varosnev.Name = "txtBx_varosnev";
            this.txtBx_varosnev.PlaceholderText = "Adja meg a város nevét..";
            this.txtBx_varosnev.Size = new System.Drawing.Size(203, 27);
            this.txtBx_varosnev.TabIndex = 1;
            // 
            // grpBx_latvanyossag
            // 
            this.grpBx_latvanyossag.Controls.Add(this.txtBx_nevLatvanyossag);
            this.grpBx_latvanyossag.Controls.Add(this.bttn_latvanyossag);
            this.grpBx_latvanyossag.Controls.Add(this.txtBx_leiras);
            this.grpBx_latvanyossag.Controls.Add(this.cmbBx_nev);
            this.grpBx_latvanyossag.Controls.Add(this.txtBx_ar);
            this.grpBx_latvanyossag.Location = new System.Drawing.Point(12, 161);
            this.grpBx_latvanyossag.Name = "grpBx_latvanyossag";
            this.grpBx_latvanyossag.Size = new System.Drawing.Size(219, 277);
            this.grpBx_latvanyossag.TabIndex = 0;
            this.grpBx_latvanyossag.TabStop = false;
            this.grpBx_latvanyossag.Text = "Látványosság hozzáadása";
            // 
            // txtBx_nevLatvanyossag
            // 
            this.txtBx_nevLatvanyossag.Location = new System.Drawing.Point(6, 61);
            this.txtBx_nevLatvanyossag.Name = "txtBx_nevLatvanyossag";
            this.txtBx_nevLatvanyossag.PlaceholderText = "Adja meg a nevét..";
            this.txtBx_nevLatvanyossag.Size = new System.Drawing.Size(203, 27);
            this.txtBx_nevLatvanyossag.TabIndex = 4;
            // 
            // bttn_latvanyossag
            // 
            this.bttn_latvanyossag.Location = new System.Drawing.Point(6, 231);
            this.bttn_latvanyossag.Name = "bttn_latvanyossag";
            this.bttn_latvanyossag.Size = new System.Drawing.Size(203, 40);
            this.bttn_latvanyossag.TabIndex = 7;
            this.bttn_latvanyossag.Text = "Hozzáad";
            this.bttn_latvanyossag.UseVisualStyleBackColor = true;
            this.bttn_latvanyossag.Click += new System.EventHandler(this.bttn_latvanyossag_Click);
            // 
            // txtBx_leiras
            // 
            this.txtBx_leiras.Location = new System.Drawing.Point(6, 126);
            this.txtBx_leiras.Multiline = true;
            this.txtBx_leiras.Name = "txtBx_leiras";
            this.txtBx_leiras.PlaceholderText = "Adjon meg egy rövid leírást";
            this.txtBx_leiras.Size = new System.Drawing.Size(203, 103);
            this.txtBx_leiras.TabIndex = 6;
            // 
            // cmbBx_nev
            // 
            this.cmbBx_nev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_nev.FormattingEnabled = true;
            this.cmbBx_nev.Location = new System.Drawing.Point(7, 27);
            this.cmbBx_nev.Name = "cmbBx_nev";
            this.cmbBx_nev.Size = new System.Drawing.Size(202, 28);
            this.cmbBx_nev.TabIndex = 3;
            // 
            // txtBx_ar
            // 
            this.txtBx_ar.Location = new System.Drawing.Point(6, 93);
            this.txtBx_ar.Name = "txtBx_ar";
            this.txtBx_ar.PlaceholderText = "Adja meg az árat..";
            this.txtBx_ar.Size = new System.Drawing.Size(203, 27);
            this.txtBx_ar.TabIndex = 5;
            this.txtBx_ar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_ar_KeyPress);
            // 
            // lstBx_varosok
            // 
            this.lstBx_varosok.FormattingEnabled = true;
            this.lstBx_varosok.ItemHeight = 20;
            this.lstBx_varosok.Location = new System.Drawing.Point(237, 26);
            this.lstBx_varosok.Name = "lstBx_varosok";
            this.lstBx_varosok.Size = new System.Drawing.Size(219, 124);
            this.lstBx_varosok.TabIndex = 7;
            this.lstBx_varosok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_varosok_MouseClick);
            this.lstBx_varosok.SelectedIndexChanged += new System.EventHandler(this.lstBx_varosok_SelectedIndexChanged);
            this.lstBx_varosok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_varosok_MouseDoubleClick);
            // 
            // bttn_varosMod
            // 
            this.bttn_varosMod.Enabled = false;
            this.bttn_varosMod.Location = new System.Drawing.Point(462, 26);
            this.bttn_varosMod.Name = "bttn_varosMod";
            this.bttn_varosMod.Size = new System.Drawing.Size(203, 40);
            this.bttn_varosMod.TabIndex = 9;
            this.bttn_varosMod.Text = "Város módosítása";
            this.bttn_varosMod.UseVisualStyleBackColor = true;
            this.bttn_varosMod.Click += new System.EventHandler(this.bttn_varosMod_Click);
            // 
            // lstBx_latvanyossagok
            // 
            this.lstBx_latvanyossagok.FormattingEnabled = true;
            this.lstBx_latvanyossagok.ItemHeight = 20;
            this.lstBx_latvanyossagok.Location = new System.Drawing.Point(237, 161);
            this.lstBx_latvanyossagok.Name = "lstBx_latvanyossagok";
            this.lstBx_latvanyossagok.Size = new System.Drawing.Size(219, 124);
            this.lstBx_latvanyossagok.TabIndex = 8;
            this.lstBx_latvanyossagok.SelectedIndexChanged += new System.EventHandler(this.lstBx_latvanyossagok_SelectedIndexChanged);
            this.lstBx_latvanyossagok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_latvanyossagok_MouseDoubleClick);
            // 
            // bttn_latvanyossagMod
            // 
            this.bttn_latvanyossagMod.Enabled = false;
            this.bttn_latvanyossagMod.Location = new System.Drawing.Point(462, 161);
            this.bttn_latvanyossagMod.Name = "bttn_latvanyossagMod";
            this.bttn_latvanyossagMod.Size = new System.Drawing.Size(203, 40);
            this.bttn_latvanyossagMod.TabIndex = 10;
            this.bttn_latvanyossagMod.Text = "Látványosság módosítása";
            this.bttn_latvanyossagMod.UseVisualStyleBackColor = true;
            this.bttn_latvanyossagMod.Click += new System.EventHandler(this.bttn_latvanyossagMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_latvanyossagMod);
            this.Controls.Add(this.lstBx_latvanyossagok);
            this.Controls.Add(this.bttn_varosMod);
            this.Controls.Add(this.lstBx_varosok);
            this.Controls.Add(this.grpBx_latvanyossag);
            this.Controls.Add(this.grpBx_varos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Látványosságok";
            this.grpBx_varos.ResumeLayout(false);
            this.grpBx_varos.PerformLayout();
            this.grpBx_latvanyossag.ResumeLayout(false);
            this.grpBx_latvanyossag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBx_varos;
        private System.Windows.Forms.TextBox txtBx_varosnev;
        private System.Windows.Forms.Button bttn_varos;
        private System.Windows.Forms.TextBox txtBx_lakossag;
        private System.Windows.Forms.GroupBox grpBx_latvanyossag;
        private System.Windows.Forms.TextBox txtBx_leiras;
        private System.Windows.Forms.TextBox txtBx_ar;
        private System.Windows.Forms.ComboBox cmbBx_nev;
        private System.Windows.Forms.Button bttn_latvanyossag;
        private System.Windows.Forms.TextBox txtBx_nevLatvanyossag;
        private System.Windows.Forms.ListBox lstBx_varosok;
        private System.Windows.Forms.Button bttn_varosMod;
        private System.Windows.Forms.ListBox lstBx_latvanyossagok;
        private System.Windows.Forms.Button bttn_latvanyossagMod;
    }
}

