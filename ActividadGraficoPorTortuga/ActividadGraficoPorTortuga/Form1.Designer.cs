namespace ActividadGraficoPorTortuga
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
            this.btnSubirPluma = new System.Windows.Forms.Button();
            this.btnBajarPluma = new System.Windows.Forms.Button();
            this.btnGirarAIzquierda = new System.Windows.Forms.Button();
            this.btnGirarADerecha = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPosiciones = new System.Windows.Forms.TextBox();
            this.txtBxTablero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubirPluma
            // 
            this.btnSubirPluma.AutoSize = true;
            this.btnSubirPluma.Location = new System.Drawing.Point(23, 15);
            this.btnSubirPluma.Name = "btnSubirPluma";
            this.btnSubirPluma.Size = new System.Drawing.Size(154, 39);
            this.btnSubirPluma.TabIndex = 0;
            this.btnSubirPluma.Text = "Subir Pluma";
            this.btnSubirPluma.UseVisualStyleBackColor = true;
            this.btnSubirPluma.Click += new System.EventHandler(this.btnSubirPluma_Click);
            // 
            // btnBajarPluma
            // 
            this.btnBajarPluma.AutoSize = true;
            this.btnBajarPluma.Location = new System.Drawing.Point(268, 15);
            this.btnBajarPluma.Name = "btnBajarPluma";
            this.btnBajarPluma.Size = new System.Drawing.Size(153, 39);
            this.btnBajarPluma.TabIndex = 1;
            this.btnBajarPluma.Text = "Bajar Pluma";
            this.btnBajarPluma.UseVisualStyleBackColor = true;
            this.btnBajarPluma.Click += new System.EventHandler(this.btnBajarPluma_Click);
            // 
            // btnGirarAIzquierda
            // 
            this.btnGirarAIzquierda.AutoSize = true;
            this.btnGirarAIzquierda.Location = new System.Drawing.Point(221, 70);
            this.btnGirarAIzquierda.Name = "btnGirarAIzquierda";
            this.btnGirarAIzquierda.Size = new System.Drawing.Size(200, 39);
            this.btnGirarAIzquierda.TabIndex = 2;
            this.btnGirarAIzquierda.Text = "Girar a Izquierda";
            this.btnGirarAIzquierda.UseVisualStyleBackColor = true;
            this.btnGirarAIzquierda.Click += new System.EventHandler(this.btnGirarAIzquierda_Click);
            // 
            // btnGirarADerecha
            // 
            this.btnGirarADerecha.AutoSize = true;
            this.btnGirarADerecha.Location = new System.Drawing.Point(23, 70);
            this.btnGirarADerecha.Name = "btnGirarADerecha";
            this.btnGirarADerecha.Size = new System.Drawing.Size(192, 39);
            this.btnGirarADerecha.TabIndex = 3;
            this.btnGirarADerecha.Text = "Girar a Derecha";
            this.btnGirarADerecha.UseVisualStyleBackColor = true;
            this.btnGirarADerecha.Click += new System.EventHandler(this.btnGirarADerecha_Click);
            // 
            // btnFin
            // 
            this.btnFin.AutoSize = true;
            this.btnFin.Location = new System.Drawing.Point(346, 185);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 39);
            this.btnFin.TabIndex = 4;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.AutoSize = true;
            this.btnAvanzar.Location = new System.Drawing.Point(314, 127);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(107, 39);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Location = new System.Drawing.Point(23, 185);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(196, 39);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir Arreglo";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Posiciones:";
            // 
            // txtBxPosiciones
            // 
            this.txtBxPosiciones.Location = new System.Drawing.Point(160, 129);
            this.txtBxPosiciones.Name = "txtBxPosiciones";
            this.txtBxPosiciones.Size = new System.Drawing.Size(148, 34);
            this.txtBxPosiciones.TabIndex = 8;
            // 
            // txtBxTablero
            // 
            this.txtBxTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTablero.Location = new System.Drawing.Point(23, 238);
            this.txtBxTablero.Multiline = true;
            this.txtBxTablero.Name = "txtBxTablero";
            this.txtBxTablero.Size = new System.Drawing.Size(398, 375);
            this.txtBxTablero.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 625);
            this.Controls.Add(this.txtBxTablero);
            this.Controls.Add(this.txtBxPosiciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnGirarADerecha);
            this.Controls.Add(this.btnGirarAIzquierda);
            this.Controls.Add(this.btnBajarPluma);
            this.Controls.Add(this.btnSubirPluma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Tortuga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubirPluma;
        private System.Windows.Forms.Button btnBajarPluma;
        private System.Windows.Forms.Button btnGirarAIzquierda;
        private System.Windows.Forms.Button btnGirarADerecha;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPosiciones;
        private System.Windows.Forms.TextBox txtBxTablero;
    }
}

