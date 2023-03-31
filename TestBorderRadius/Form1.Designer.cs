namespace TestBorderRadius
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRadius1 = new NeoComponents.PanelRadius();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelRadius1
            // 
            this.panelRadius1.BackColor = System.Drawing.Color.White;
            this.panelRadius1.BorderRadius = 30;
            this.panelRadius1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRadius1.ForeColor = System.Drawing.Color.Black;
            this.panelRadius1.GradientAngle = 90;
            this.panelRadius1.GradientBottomColor = System.Drawing.Color.PaleTurquoise;
            this.panelRadius1.GradientTopColor = System.Drawing.Color.Navy;
            this.panelRadius1.Location = new System.Drawing.Point(488, 111);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Size = new System.Drawing.Size(252, 300);
            this.panelRadius1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(121, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelRadius1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NeoComponents.PanelRadius panelRadius1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

