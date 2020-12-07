
namespace LatvanyossagokApplication
{
    partial class LatvanyossagModositas
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
            this.grpBx_latvanyossagMod = new System.Windows.Forms.GroupBox();
            this.txtBx_nevLatvanyossagMod = new System.Windows.Forms.TextBox();
            this.bttn_latvanyossagMod = new System.Windows.Forms.Button();
            this.txtBx_leirasMod = new System.Windows.Forms.TextBox();
            this.txtBx_arMod = new System.Windows.Forms.TextBox();
            this.grpBx_latvanyossagMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBx_latvanyossagMod
            // 
            this.grpBx_latvanyossagMod.Controls.Add(this.txtBx_nevLatvanyossagMod);
            this.grpBx_latvanyossagMod.Controls.Add(this.bttn_latvanyossagMod);
            this.grpBx_latvanyossagMod.Controls.Add(this.txtBx_leirasMod);
            this.grpBx_latvanyossagMod.Controls.Add(this.txtBx_arMod);
            this.grpBx_latvanyossagMod.Location = new System.Drawing.Point(28, 29);
            this.grpBx_latvanyossagMod.Name = "grpBx_latvanyossagMod";
            this.grpBx_latvanyossagMod.Size = new System.Drawing.Size(219, 255);
            this.grpBx_latvanyossagMod.TabIndex = 1;
            this.grpBx_latvanyossagMod.TabStop = false;
            this.grpBx_latvanyossagMod.Text = "Látványosság módosítása";
            // 
            // txtBx_nevLatvanyossagMod
            // 
            this.txtBx_nevLatvanyossagMod.Location = new System.Drawing.Point(6, 26);
            this.txtBx_nevLatvanyossagMod.Name = "txtBx_nevLatvanyossagMod";
            this.txtBx_nevLatvanyossagMod.PlaceholderText = "Adja meg a nevét..";
            this.txtBx_nevLatvanyossagMod.Size = new System.Drawing.Size(203, 27);
            this.txtBx_nevLatvanyossagMod.TabIndex = 1;
            // 
            // bttn_latvanyossagMod
            // 
            this.bttn_latvanyossagMod.Location = new System.Drawing.Point(6, 201);
            this.bttn_latvanyossagMod.Name = "bttn_latvanyossagMod";
            this.bttn_latvanyossagMod.Size = new System.Drawing.Size(203, 40);
            this.bttn_latvanyossagMod.TabIndex = 4;
            this.bttn_latvanyossagMod.Text = "Módosít";
            this.bttn_latvanyossagMod.UseVisualStyleBackColor = true;
            this.bttn_latvanyossagMod.Click += new System.EventHandler(this.bttn_latvanyossagMod_Click);
            // 
            // txtBx_leirasMod
            // 
            this.txtBx_leirasMod.Location = new System.Drawing.Point(6, 92);
            this.txtBx_leirasMod.Multiline = true;
            this.txtBx_leirasMod.Name = "txtBx_leirasMod";
            this.txtBx_leirasMod.PlaceholderText = "Adjon meg egy rövid leírást";
            this.txtBx_leirasMod.Size = new System.Drawing.Size(203, 103);
            this.txtBx_leirasMod.TabIndex = 3;
            // 
            // txtBx_arMod
            // 
            this.txtBx_arMod.Location = new System.Drawing.Point(6, 59);
            this.txtBx_arMod.Name = "txtBx_arMod";
            this.txtBx_arMod.PlaceholderText = "Adja meg az árat..";
            this.txtBx_arMod.Size = new System.Drawing.Size(203, 27);
            this.txtBx_arMod.TabIndex = 2;
            // 
            // LatvanyossagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 322);
            this.Controls.Add(this.grpBx_latvanyossagMod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LatvanyossagModositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Látványosság Módosítása";
            this.grpBx_latvanyossagMod.ResumeLayout(false);
            this.grpBx_latvanyossagMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBx_latvanyossagMod;
        private System.Windows.Forms.TextBox txtBx_nevLatvanyossagMod;
        private System.Windows.Forms.Button bttn_latvanyossagMod;
        private System.Windows.Forms.TextBox txtBx_leirasMod;
        private System.Windows.Forms.TextBox txtBx_arMod;
    }
}