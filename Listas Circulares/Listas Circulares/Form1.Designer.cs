namespace Listas_Circulares
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
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdBusacr = new System.Windows.Forms.Button();
            this.cmdElimianrP = new System.Windows.Forms.Button();
            this.cmdEliminarU = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdInserta = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.comboxBases = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtpHoraI = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraF = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(47, 61);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(172, 67);
            this.cmdAgregar.TabIndex = 0;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdBusacr
            // 
            this.cmdBusacr.Location = new System.Drawing.Point(264, 61);
            this.cmdBusacr.Name = "cmdBusacr";
            this.cmdBusacr.Size = new System.Drawing.Size(172, 67);
            this.cmdBusacr.TabIndex = 1;
            this.cmdBusacr.Text = "Buscar";
            this.cmdBusacr.UseVisualStyleBackColor = true;
            this.cmdBusacr.Click += new System.EventHandler(this.cmdBusacr_Click);
            // 
            // cmdElimianrP
            // 
            this.cmdElimianrP.Location = new System.Drawing.Point(950, 161);
            this.cmdElimianrP.Name = "cmdElimianrP";
            this.cmdElimianrP.Size = new System.Drawing.Size(172, 67);
            this.cmdElimianrP.TabIndex = 2;
            this.cmdElimianrP.Text = "EliminarPrimero";
            this.cmdElimianrP.UseVisualStyleBackColor = true;
            this.cmdElimianrP.Click += new System.EventHandler(this.cmdElimianrP_Click);
            // 
            // cmdEliminarU
            // 
            this.cmdEliminarU.Location = new System.Drawing.Point(950, 234);
            this.cmdEliminarU.Name = "cmdEliminarU";
            this.cmdEliminarU.Size = new System.Drawing.Size(172, 67);
            this.cmdEliminarU.TabIndex = 3;
            this.cmdEliminarU.Text = "Eliminar Ultimo";
            this.cmdEliminarU.UseVisualStyleBackColor = true;
            this.cmdEliminarU.Click += new System.EventHandler(this.cmdEliminarU_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(950, 307);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(172, 67);
            this.cmdListar.TabIndex = 4;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdInserta
            // 
            this.cmdInserta.Location = new System.Drawing.Point(562, 47);
            this.cmdInserta.Name = "cmdInserta";
            this.cmdInserta.Size = new System.Drawing.Size(172, 67);
            this.cmdInserta.TabIndex = 5;
            this.cmdInserta.Text = "Insertar";
            this.cmdInserta.UseVisualStyleBackColor = true;
            this.cmdInserta.Click += new System.EventHandler(this.cmdInserta_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(950, 380);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(172, 67);
            this.cmdEliminar.TabIndex = 6;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(562, 416);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(172, 67);
            this.cmdMostrar.TabIndex = 7;
            this.cmdMostrar.Text = "Mostrar Ruta";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // comboxBases
            // 
            this.comboxBases.FormattingEnabled = true;
            this.comboxBases.Location = new System.Drawing.Point(776, 162);
            this.comboxBases.Name = "comboxBases";
            this.comboxBases.Size = new System.Drawing.Size(121, 33);
            this.comboxBases.TabIndex = 8;
            this.comboxBases.Tag = "sjfsnjl";
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleDescription = "";
            this.txtNombre.AccessibleName = "";
            this.txtNombre.Location = new System.Drawing.Point(47, 165);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(47, 238);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(172, 30);
            this.txtMinutos.TabIndex = 10;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(125, 329);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrar.Size = new System.Drawing.Size(387, 237);
            this.txtMostrar.TabIndex = 11;
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(562, 165);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(172, 30);
            this.txtInsertar.TabIndex = 12;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(264, 165);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 30);
            this.txtBuscar.TabIndex = 13;
            // 
            // dtpHoraI
            // 
            this.dtpHoraI.CustomFormat = "hh:mm";
            this.dtpHoraI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraI.Location = new System.Drawing.Point(776, 47);
            this.dtpHoraI.Name = "dtpHoraI";
            this.dtpHoraI.Size = new System.Drawing.Size(157, 30);
            this.dtpHoraI.TabIndex = 14;
            this.dtpHoraI.Value = new System.DateTime(2018, 6, 14, 18, 37, 14, 0);
            // 
            // dtpHoraF
            // 
            this.dtpHoraF.CustomFormat = "hh:mm";
            this.dtpHoraF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraF.Location = new System.Drawing.Point(776, 98);
            this.dtpHoraF.Name = "dtpHoraF";
            this.dtpHoraF.Size = new System.Drawing.Size(157, 30);
            this.dtpHoraF.TabIndex = 15;
            this.dtpHoraF.Value = new System.DateTime(2018, 6, 14, 18, 37, 26, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Posicion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 609);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraF);
            this.Controls.Add(this.dtpHoraI);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.comboxBases);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdInserta);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdEliminarU);
            this.Controls.Add(this.cmdElimianrP);
            this.Controls.Add(this.cmdBusacr);
            this.Controls.Add(this.cmdAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdBusacr;
        private System.Windows.Forms.Button cmdElimianrP;
        private System.Windows.Forms.Button cmdEliminarU;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdInserta;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.ComboBox comboxBases;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dtpHoraI;
        private System.Windows.Forms.DateTimePicker dtpHoraF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

