namespace Practica_1_Binarios
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
            this.cmdprocesar = new System.Windows.Forms.Button();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.lblentrada = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnuevafch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.picbsensor1 = new System.Windows.Forms.PictureBox();
            this.picbsensor2 = new System.Windows.Forms.PictureBox();
            this.picbtanque = new System.Windows.Forms.PictureBox();
            this.picbdireccion = new System.Windows.Forms.PictureBox();
            this.lblllenadnose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbsensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbsensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbdireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdprocesar
            // 
            this.cmdprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprocesar.Location = new System.Drawing.Point(740, 77);
            this.cmdprocesar.Name = "cmdprocesar";
            this.cmdprocesar.Size = new System.Drawing.Size(124, 36);
            this.cmdprocesar.TabIndex = 0;
            this.cmdprocesar.Text = "Procesar!!";
            this.cmdprocesar.UseVisualStyleBackColor = true;
            this.cmdprocesar.Click += new System.EventHandler(this.cmdprocesar_Click);
            // 
            // txtentrada
            // 
            this.txtentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentrada.Location = new System.Drawing.Point(533, 83);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(179, 30);
            this.txtentrada.TabIndex = 1;
            // 
            // lblentrada
            // 
            this.lblentrada.AutoSize = true;
            this.lblentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentrada.Location = new System.Drawing.Point(408, 88);
            this.lblentrada.Name = "lblentrada";
            this.lblentrada.Size = new System.Drawing.Size(89, 25);
            this.lblentrada.TabIndex = 2;
            this.lblentrada.Text = "DATOS:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(528, 475);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(86, 25);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "FECHA:";
            // 
            // lblnuevafch
            // 
            this.lblnuevafch.AutoSize = true;
            this.lblnuevafch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevafch.Location = new System.Drawing.Point(638, 483);
            this.lblnuevafch.Name = "lblnuevafch";
            this.lblnuevafch.Size = new System.Drawing.Size(0, 25);
            this.lblnuevafch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1352, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(1062, 362);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(0, 29);
            this.lbldireccion.TabIndex = 8;
            // 
            // picbsensor1
            // 
            this.picbsensor1.Location = new System.Drawing.Point(15, 156);
            this.picbsensor1.Name = "picbsensor1";
            this.picbsensor1.Size = new System.Drawing.Size(237, 192);
            this.picbsensor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbsensor1.TabIndex = 11;
            this.picbsensor1.TabStop = false;
            // 
            // picbsensor2
            // 
            this.picbsensor2.Location = new System.Drawing.Point(323, 156);
            this.picbsensor2.Name = "picbsensor2";
            this.picbsensor2.Size = new System.Drawing.Size(251, 192);
            this.picbsensor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbsensor2.TabIndex = 10;
            this.picbsensor2.TabStop = false;
            // 
            // picbtanque
            // 
            this.picbtanque.Location = new System.Drawing.Point(674, 156);
            this.picbtanque.Name = "picbtanque";
            this.picbtanque.Size = new System.Drawing.Size(247, 192);
            this.picbtanque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbtanque.TabIndex = 9;
            this.picbtanque.TabStop = false;
            // 
            // picbdireccion
            // 
            this.picbdireccion.Location = new System.Drawing.Point(1016, 156);
            this.picbdireccion.Name = "picbdireccion";
            this.picbdireccion.Size = new System.Drawing.Size(261, 192);
            this.picbdireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbdireccion.TabIndex = 3;
            this.picbdireccion.TabStop = false;
            // 
            // lblllenadnose
            // 
            this.lblllenadnose.AutoSize = true;
            this.lblllenadnose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblllenadnose.Location = new System.Drawing.Point(758, 362);
            this.lblllenadnose.Name = "lblllenadnose";
            this.lblllenadnose.Size = new System.Drawing.Size(0, 29);
            this.lblllenadnose.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 597);
            this.Controls.Add(this.lblllenadnose);
            this.Controls.Add(this.picbsensor1);
            this.Controls.Add(this.picbsensor2);
            this.Controls.Add(this.picbtanque);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnuevafch);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.picbdireccion);
            this.Controls.Add(this.lblentrada);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.cmdprocesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbsensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbsensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbdireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdprocesar;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.Label lblentrada;
        private System.Windows.Forms.PictureBox picbdireccion;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnuevafch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.PictureBox picbtanque;
        private System.Windows.Forms.PictureBox picbsensor2;
        private System.Windows.Forms.PictureBox picbsensor1;
        private System.Windows.Forms.Label lblllenadnose;
    }
}

