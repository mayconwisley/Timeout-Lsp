namespace Timeout_Copacol
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.LblAguardando = new System.Windows.Forms.Label();
            this.TimeoutPrincipal = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblAguardando
            // 
            this.LblAguardando.AutoSize = true;
            this.LblAguardando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAguardando.Location = new System.Drawing.Point(77, 21);
            this.LblAguardando.Name = "LblAguardando";
            this.LblAguardando.Size = new System.Drawing.Size(193, 20);
            this.LblAguardando.TabIndex = 0;
            this.LblAguardando.Text = "Aguardando 00 segundos";
            // 
            // TimeoutPrincipal
            // 
            this.TimeoutPrincipal.Interval = 1000;
            this.TimeoutPrincipal.Tick += new System.EventHandler(this.TimeoutPrincipal_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 63);
            this.Controls.Add(this.LblAguardando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timeout";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAguardando;
        private System.Windows.Forms.Timer TimeoutPrincipal;
    }
}

