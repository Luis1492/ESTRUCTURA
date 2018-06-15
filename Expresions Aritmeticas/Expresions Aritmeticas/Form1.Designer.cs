namespace Expresions_Aritmeticas
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
            this.txtexpresion = new System.Windows.Forms.TextBox();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.cmdanalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtexpresion
            // 
            this.txtexpresion.Location = new System.Drawing.Point(314, 89);
            this.txtexpresion.Name = "txtexpresion";
            this.txtexpresion.Size = new System.Drawing.Size(174, 30);
            this.txtexpresion.TabIndex = 0;
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(219, 219);
            this.txtmostrar.Multiline = true;
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(500, 344);
            this.txtmostrar.TabIndex = 1;
            // 
            // cmdanalizar
            // 
            this.cmdanalizar.Location = new System.Drawing.Point(596, 61);
            this.cmdanalizar.Name = "cmdanalizar";
            this.cmdanalizar.Size = new System.Drawing.Size(136, 58);
            this.cmdanalizar.TabIndex = 2;
            this.cmdanalizar.Text = "Analizar";
            this.cmdanalizar.UseVisualStyleBackColor = true;
            this.cmdanalizar.Click += new System.EventHandler(this.cmdanalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 563);
            this.Controls.Add(this.cmdanalizar);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.txtexpresion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtexpresion;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.Button cmdanalizar;
    }
}

