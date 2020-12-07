
namespace LatvanyossagokApplication
{
    partial class VarosModositas
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
            this.grpBx_varosMod = new System.Windows.Forms.GroupBox();
            this.bttn_varosMod = new System.Windows.Forms.Button();
            this.txtBx_lakossagMod = new System.Windows.Forms.TextBox();
            this.txtBx_varosnevMod = new System.Windows.Forms.TextBox();
            this.grpBx_varosMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBx_varosMod
            // 
            this.grpBx_varosMod.Controls.Add(this.bttn_varosMod);
            this.grpBx_varosMod.Controls.Add(this.txtBx_lakossagMod);
            this.grpBx_varosMod.Controls.Add(this.txtBx_varosnevMod);
            this.grpBx_varosMod.Location = new System.Drawing.Point(53, 31);
            this.grpBx_varosMod.Name = "grpBx_varosMod";
            this.grpBx_varosMod.Size = new System.Drawing.Size(219, 138);
            this.grpBx_varosMod.TabIndex = 1;
            this.grpBx_varosMod.TabStop = false;
            this.grpBx_varosMod.Text = "Város módosítása";
            // 
            // bttn_varosMod
            // 
            this.bttn_varosMod.Location = new System.Drawing.Point(6, 92);
            this.bttn_varosMod.Name = "bttn_varosMod";
            this.bttn_varosMod.Size = new System.Drawing.Size(203, 40);
            this.bttn_varosMod.TabIndex = 3;
            this.bttn_varosMod.Text = "Módosít";
            this.bttn_varosMod.UseVisualStyleBackColor = true;
            this.bttn_varosMod.Click += new System.EventHandler(this.bttn_varosMod_Click);
            // 
            // txtBx_lakossagMod
            // 
            this.txtBx_lakossagMod.Location = new System.Drawing.Point(6, 59);
            this.txtBx_lakossagMod.Name = "txtBx_lakossagMod";
            this.txtBx_lakossagMod.PlaceholderText = "Adja meg a város lakosságát..";
            this.txtBx_lakossagMod.Size = new System.Drawing.Size(203, 27);
            this.txtBx_lakossagMod.TabIndex = 2;
            // 
            // txtBx_varosnevMod
            // 
            this.txtBx_varosnevMod.Location = new System.Drawing.Point(6, 26);
            this.txtBx_varosnevMod.Name = "txtBx_varosnevMod";
            this.txtBx_varosnevMod.PlaceholderText = "Adja meg a város nevét..";
            this.txtBx_varosnevMod.Size = new System.Drawing.Size(203, 27);
            this.txtBx_varosnevMod.TabIndex = 1;
            // 
            // VarosModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 207);
            this.Controls.Add(this.grpBx_varosMod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VarosModositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Város Módosítása";
            this.grpBx_varosMod.ResumeLayout(false);
            this.grpBx_varosMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBx_varosMod;
        private System.Windows.Forms.Button bttn_varosMod;
        private System.Windows.Forms.TextBox txtBx_lakossagMod;
        private System.Windows.Forms.TextBox txtBx_varosnevMod;
    }
}