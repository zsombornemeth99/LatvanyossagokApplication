
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
            this.grpBx_varos.SuspendLayout();
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
            this.bttn_varos.Location = new System.Drawing.Point(6, 103);
            this.bttn_varos.Name = "bttn_varos";
            this.bttn_varos.Size = new System.Drawing.Size(203, 29);
            this.bttn_varos.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBx_varos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Látványosságok";
            this.grpBx_varos.ResumeLayout(false);
            this.grpBx_varos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBx_varos;
        private System.Windows.Forms.TextBox txtBx_varosnev;
        private System.Windows.Forms.Button bttn_varos;
        private System.Windows.Forms.TextBox txtBx_lakossag;
    }
}

