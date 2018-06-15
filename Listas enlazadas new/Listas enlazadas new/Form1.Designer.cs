namespace Listas_enlazadas_new
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
            this.cmdEiminarinicio = new System.Windows.Forms.Button();
            this.cmdEliminarultimo = new System.Windows.Forms.Button();
            this.cmdReporteinverso = new System.Windows.Forms.Button();
            this.cmdInvertirlista = new System.Windows.Forms.Button();
            this.txtListar = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApmaterno = new System.Windows.Forms.TextBox();
            this.txtApepaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblapmaterno = new System.Windows.Forms.Label();
            this.lblappaterno = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdEiminarinicio
            // 
            this.cmdEiminarinicio.Location = new System.Drawing.Point(655, 276);
            this.cmdEiminarinicio.Name = "cmdEiminarinicio";
            this.cmdEiminarinicio.Size = new System.Drawing.Size(157, 48);
            this.cmdEiminarinicio.TabIndex = 1;
            this.cmdEiminarinicio.Text = "Eliminar Inicio";
            this.cmdEiminarinicio.UseVisualStyleBackColor = true;
            this.cmdEiminarinicio.Click += new System.EventHandler(this.cmdEiminarinicio_Click);
            // 
            // cmdEliminarultimo
            // 
            this.cmdEliminarultimo.Location = new System.Drawing.Point(655, 339);
            this.cmdEliminarultimo.Name = "cmdEliminarultimo";
            this.cmdEliminarultimo.Size = new System.Drawing.Size(157, 48);
            this.cmdEliminarultimo.TabIndex = 2;
            this.cmdEliminarultimo.Text = "Eliminar Ultimo";
            this.cmdEliminarultimo.UseVisualStyleBackColor = true;
            this.cmdEliminarultimo.Click += new System.EventHandler(this.cmdEliminarultimo_Click);
            // 
            // cmdReporteinverso
            // 
            this.cmdReporteinverso.Location = new System.Drawing.Point(655, 403);
            this.cmdReporteinverso.Name = "cmdReporteinverso";
            this.cmdReporteinverso.Size = new System.Drawing.Size(157, 48);
            this.cmdReporteinverso.TabIndex = 3;
            this.cmdReporteinverso.Text = "Reporte inverso";
            this.cmdReporteinverso.UseVisualStyleBackColor = true;
            this.cmdReporteinverso.Click += new System.EventHandler(this.cmdReporteinverso_Click);
            // 
            // cmdInvertirlista
            // 
            this.cmdInvertirlista.Location = new System.Drawing.Point(655, 470);
            this.cmdInvertirlista.Name = "cmdInvertirlista";
            this.cmdInvertirlista.Size = new System.Drawing.Size(157, 48);
            this.cmdInvertirlista.TabIndex = 4;
            this.cmdInvertirlista.Text = "Invertir Lista";
            this.cmdInvertirlista.UseVisualStyleBackColor = true;
            this.cmdInvertirlista.Click += new System.EventHandler(this.cmdInvertirlista_Click);
            // 
            // txtListar
            // 
            this.txtListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtListar.Location = new System.Drawing.Point(90, 317);
            this.txtListar.Multiline = true;
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(416, 232);
            this.txtListar.TabIndex = 39;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(655, 210);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(157, 46);
            this.cmdListar.TabIndex = 36;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(655, 145);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(157, 46);
            this.cmdEliminar.TabIndex = 34;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(655, 88);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(157, 46);
            this.cmdBuscar.TabIndex = 33;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(655, 24);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(157, 46);
            this.cmdAgregar.TabIndex = 32;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(281, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 30);
            this.txtEmail.TabIndex = 31;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(281, 193);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(225, 30);
            this.txtEdad.TabIndex = 30;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(281, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(225, 30);
            this.txtTelefono.TabIndex = 29;
            // 
            // txtApmaterno
            // 
            this.txtApmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApmaterno.Location = new System.Drawing.Point(281, 104);
            this.txtApmaterno.Name = "txtApmaterno";
            this.txtApmaterno.Size = new System.Drawing.Size(225, 30);
            this.txtApmaterno.TabIndex = 28;
            // 
            // txtApepaterno
            // 
            this.txtApepaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApepaterno.Location = new System.Drawing.Point(281, 61);
            this.txtApepaterno.Name = "txtApepaterno";
            this.txtApepaterno.Size = new System.Drawing.Size(225, 30);
            this.txtApepaterno.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(281, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 30);
            this.txtNombre.TabIndex = 26;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(85, 247);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(66, 25);
            this.lblemail.TabIndex = 25;
            this.lblemail.Text = "Email:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(85, 198);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(64, 25);
            this.lbledad.TabIndex = 24;
            this.lbledad.Text = "Edad:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(85, 156);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(95, 25);
            this.lbltelefono.TabIndex = 23;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lblapmaterno
            // 
            this.lblapmaterno.AutoSize = true;
            this.lblapmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapmaterno.Location = new System.Drawing.Point(85, 109);
            this.lblapmaterno.Name = "lblapmaterno";
            this.lblapmaterno.Size = new System.Drawing.Size(165, 25);
            this.lblapmaterno.TabIndex = 22;
            this.lblapmaterno.Text = "Apellido Materno:";
            // 
            // lblappaterno
            // 
            this.lblappaterno.AutoSize = true;
            this.lblappaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappaterno.Location = new System.Drawing.Point(85, 66);
            this.lblappaterno.Name = "lblappaterno";
            this.lblappaterno.Size = new System.Drawing.Size(161, 25);
            this.lblappaterno.TabIndex = 21;
            this.lblappaterno.Text = "Apellido Paterno:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(85, 24);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(87, 25);
            this.lblnombre.TabIndex = 20;
            this.lblnombre.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApmaterno);
            this.Controls.Add(this.txtApepaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblapmaterno);
            this.Controls.Add(this.lblappaterno);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.cmdInvertirlista);
            this.Controls.Add(this.cmdReporteinverso);
            this.Controls.Add(this.cmdEliminarultimo);
            this.Controls.Add(this.cmdEiminarinicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdEiminarinicio;
        private System.Windows.Forms.Button cmdEliminarultimo;
        private System.Windows.Forms.Button cmdReporteinverso;
        private System.Windows.Forms.Button cmdInvertirlista;
        private System.Windows.Forms.TextBox txtListar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApmaterno;
        private System.Windows.Forms.TextBox txtApepaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblapmaterno;
        private System.Windows.Forms.Label lblappaterno;
        private System.Windows.Forms.Label lblnombre;
    }
}

