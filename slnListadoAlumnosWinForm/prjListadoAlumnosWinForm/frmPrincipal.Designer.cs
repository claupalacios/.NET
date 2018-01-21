namespace prjListadoAlumnosWinForm
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPromedioGeneralTexto = new System.Windows.Forms.Label();
            this.lblCantidadTexto = new System.Windows.Forms.Label();
            this.lblPromedioGeneralValor = new System.Windows.Forms.Label();
            this.lblCantidadValor = new System.Windows.Forms.Label();
            this.lblPromedioValor = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblPuntajeTexto = new System.Windows.Forms.Label();
            this.lblApellidoTexto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 15);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(112, 41);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(153, 20);
            this.txtPromedio.TabIndex = 1;
            this.txtPromedio.TextChanged += new System.EventHandler(this.txtPromedio_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Enabled = false;
            this.btnIngresar.Location = new System.Drawing.Point(11, 72);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(253, 32);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 18);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(12, 41);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(84, 16);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedioGeneralTexto
            // 
            this.lblPromedioGeneralTexto.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioGeneralTexto.Location = new System.Drawing.Point(12, 139);
            this.lblPromedioGeneralTexto.Name = "lblPromedioGeneralTexto";
            this.lblPromedioGeneralTexto.Size = new System.Drawing.Size(84, 16);
            this.lblPromedioGeneralTexto.TabIndex = 6;
            this.lblPromedioGeneralTexto.Text = "Promedio General";
            this.lblPromedioGeneralTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadTexto
            // 
            this.lblCantidadTexto.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTexto.Location = new System.Drawing.Point(12, 116);
            this.lblCantidadTexto.Name = "lblCantidadTexto";
            this.lblCantidadTexto.Size = new System.Drawing.Size(84, 16);
            this.lblCantidadTexto.TabIndex = 5;
            this.lblCantidadTexto.Text = "Alumnos";
            this.lblCantidadTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedioGeneralValor
            // 
            this.lblPromedioGeneralValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromedioGeneralValor.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioGeneralValor.Location = new System.Drawing.Point(112, 140);
            this.lblPromedioGeneralValor.Name = "lblPromedioGeneralValor";
            this.lblPromedioGeneralValor.Size = new System.Drawing.Size(153, 15);
            this.lblPromedioGeneralValor.TabIndex = 8;
            this.lblPromedioGeneralValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadValor
            // 
            this.lblCantidadValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidadValor.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadValor.Location = new System.Drawing.Point(112, 117);
            this.lblCantidadValor.Name = "lblCantidadValor";
            this.lblCantidadValor.Size = new System.Drawing.Size(153, 15);
            this.lblCantidadValor.TabIndex = 7;
            this.lblCantidadValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedioValor
            // 
            this.lblPromedioValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromedioValor.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioValor.Location = new System.Drawing.Point(101, 49);
            this.lblPromedioValor.Name = "lblPromedioValor";
            this.lblPromedioValor.Size = new System.Drawing.Size(153, 15);
            this.lblPromedioValor.TabIndex = 12;
            this.lblPromedioValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellidoValor.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoValor.Location = new System.Drawing.Point(101, 26);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(153, 15);
            this.lblApellidoValor.TabIndex = 11;
            this.lblApellidoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuntajeTexto
            // 
            this.lblPuntajeTexto.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeTexto.Location = new System.Drawing.Point(7, 48);
            this.lblPuntajeTexto.Name = "lblPuntajeTexto";
            this.lblPuntajeTexto.Size = new System.Drawing.Size(84, 16);
            this.lblPuntajeTexto.TabIndex = 10;
            this.lblPuntajeTexto.Text = "Promedio";
            this.lblPuntajeTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellidoTexto
            // 
            this.lblApellidoTexto.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoTexto.Location = new System.Drawing.Point(7, 25);
            this.lblApellidoTexto.Name = "lblApellidoTexto";
            this.lblApellidoTexto.Size = new System.Drawing.Size(84, 16);
            this.lblApellidoTexto.TabIndex = 9;
            this.lblApellidoTexto.Text = "Apellido";
            this.lblApellidoTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPromedioValor);
            this.groupBox1.Controls.Add(this.lblApellidoValor);
            this.groupBox1.Controls.Add(this.lblPuntajeTexto);
            this.groupBox1.Controls.Add(this.lblApellidoTexto);
            this.groupBox1.Location = new System.Drawing.Point(11, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mejor Promedio";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPromedioGeneralValor);
            this.Controls.Add(this.lblCantidadValor);
            this.Controls.Add(this.lblPromedioGeneralTexto);
            this.Controls.Add(this.lblCantidadTexto);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtApellido);
            this.Name = "frmPrincipal";
            this.Text = "Listado de Alumnos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPromedioGeneralTexto;
        private System.Windows.Forms.Label lblCantidadTexto;
        private System.Windows.Forms.Label lblPromedioGeneralValor;
        private System.Windows.Forms.Label lblCantidadValor;
        private System.Windows.Forms.Label lblPromedioValor;
        private System.Windows.Forms.Label lblApellidoValor;
        private System.Windows.Forms.Label lblPuntajeTexto;
        private System.Windows.Forms.Label lblApellidoTexto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

