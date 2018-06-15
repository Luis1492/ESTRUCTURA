namespace Grafico_de_totugaL
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
            this.cmdPlumaArr = new System.Windows.Forms.Button();
            this.cmdPlumaAba = new System.Windows.Forms.Button();
            this.cmdGiraD = new System.Windows.Forms.Button();
            this.cmdGiraIz = new System.Windows.Forms.Button();
            this.cdmAvanza = new System.Windows.Forms.Button();
            this.cdmImprime = new System.Windows.Forms.Button();
            this.cdmCentinela = new System.Windows.Forms.Button();
            this.txtpasos = new System.Windows.Forms.TextBox();
            this.txtgrafico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdPlumaArr
            // 
            this.cmdPlumaArr.Location = new System.Drawing.Point(632, 72);
            this.cmdPlumaArr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdPlumaArr.Name = "cmdPlumaArr";
            this.cmdPlumaArr.Size = new System.Drawing.Size(183, 58);
            this.cmdPlumaArr.TabIndex = 0;
            this.cmdPlumaArr.Text = "Pluma Arriba";
            this.cmdPlumaArr.UseVisualStyleBackColor = true;
            this.cmdPlumaArr.Click += new System.EventHandler(this.cmdPlumaArr_Click);
            // 
            // cmdPlumaAba
            // 
            this.cmdPlumaAba.Location = new System.Drawing.Point(632, 140);
            this.cmdPlumaAba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdPlumaAba.Name = "cmdPlumaAba";
            this.cmdPlumaAba.Size = new System.Drawing.Size(183, 58);
            this.cmdPlumaAba.TabIndex = 1;
            this.cmdPlumaAba.Text = "Pluma Abajo";
            this.cmdPlumaAba.UseVisualStyleBackColor = true;
            this.cmdPlumaAba.Click += new System.EventHandler(this.cmdPlumaAba_Click);
            // 
            // cmdGiraD
            // 
            this.cmdGiraD.Location = new System.Drawing.Point(632, 208);
            this.cmdGiraD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGiraD.Name = "cmdGiraD";
            this.cmdGiraD.Size = new System.Drawing.Size(183, 58);
            this.cmdGiraD.TabIndex = 2;
            this.cmdGiraD.Text = "Gira Derecha";
            this.cmdGiraD.UseVisualStyleBackColor = true;
            this.cmdGiraD.Click += new System.EventHandler(this.cmdGiraD_Click);
            // 
            // cmdGiraIz
            // 
            this.cmdGiraIz.Location = new System.Drawing.Point(632, 276);
            this.cmdGiraIz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGiraIz.Name = "cmdGiraIz";
            this.cmdGiraIz.Size = new System.Drawing.Size(183, 58);
            this.cmdGiraIz.TabIndex = 3;
            this.cmdGiraIz.Text = "Gira Izquierda";
            this.cmdGiraIz.UseVisualStyleBackColor = true;
            this.cmdGiraIz.Click += new System.EventHandler(this.cmdGiraIz_Click);
            // 
            // cdmAvanza
            // 
            this.cdmAvanza.Location = new System.Drawing.Point(632, 344);
            this.cdmAvanza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdmAvanza.Name = "cdmAvanza";
            this.cdmAvanza.Size = new System.Drawing.Size(183, 58);
            this.cdmAvanza.TabIndex = 4;
            this.cdmAvanza.Text = "Avanza";
            this.cdmAvanza.UseVisualStyleBackColor = true;
            this.cdmAvanza.Click += new System.EventHandler(this.cdmAvanza_Click);
            // 
            // cdmImprime
            // 
            this.cdmImprime.Location = new System.Drawing.Point(632, 412);
            this.cdmImprime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdmImprime.Name = "cdmImprime";
            this.cdmImprime.Size = new System.Drawing.Size(183, 58);
            this.cdmImprime.TabIndex = 5;
            this.cdmImprime.Text = "Imprimir";
            this.cdmImprime.UseVisualStyleBackColor = true;
            this.cdmImprime.Click += new System.EventHandler(this.cdmImprime_Click);
            // 
            // cdmCentinela
            // 
            this.cdmCentinela.Location = new System.Drawing.Point(632, 480);
            this.cdmCentinela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdmCentinela.Name = "cdmCentinela";
            this.cdmCentinela.Size = new System.Drawing.Size(183, 58);
            this.cdmCentinela.TabIndex = 6;
            this.cdmCentinela.Text = "Fin de Datos";
            this.cdmCentinela.UseVisualStyleBackColor = true;
            this.cdmCentinela.Click += new System.EventHandler(this.cdmCentinela_Click);
            // 
            // txtpasos
            // 
            this.txtpasos.Location = new System.Drawing.Point(844, 372);
            this.txtpasos.Name = "txtpasos";
            this.txtpasos.Size = new System.Drawing.Size(127, 30);
            this.txtpasos.TabIndex = 7;
            // 
            // txtgrafico
            // 
            this.txtgrafico.Location = new System.Drawing.Point(40, 72);
            this.txtgrafico.Multiline = true;
            this.txtgrafico.Name = "txtgrafico";
            this.txtgrafico.Size = new System.Drawing.Size(508, 466);
            this.txtgrafico.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 658);
            this.Controls.Add(this.txtgrafico);
            this.Controls.Add(this.txtpasos);
            this.Controls.Add(this.cdmCentinela);
            this.Controls.Add(this.cdmImprime);
            this.Controls.Add(this.cdmAvanza);
            this.Controls.Add(this.cmdGiraIz);
            this.Controls.Add(this.cmdGiraD);
            this.Controls.Add(this.cmdPlumaAba);
            this.Controls.Add(this.cmdPlumaArr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPlumaArr;
        private System.Windows.Forms.Button cmdPlumaAba;
        private System.Windows.Forms.Button cmdGiraD;
        private System.Windows.Forms.Button cmdGiraIz;
        private System.Windows.Forms.Button cdmAvanza;
        private System.Windows.Forms.Button cdmImprime;
        private System.Windows.Forms.Button cdmCentinela;
        private System.Windows.Forms.TextBox txtpasos;
        private System.Windows.Forms.TextBox txtgrafico;
    }
}

