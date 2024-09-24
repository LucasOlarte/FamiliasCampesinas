namespace Familias_campesinas
{
    partial class InicioDeSesion
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
            this.TituloInicio = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloInicio
            // 
            this.TituloInicio.AutoSize = true;
            this.TituloInicio.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloInicio.Location = new System.Drawing.Point(16, 25);
            this.TituloInicio.Name = "TituloInicio";
            this.TituloInicio.Size = new System.Drawing.Size(772, 40);
            this.TituloInicio.TabIndex = 0;
            this.TituloInicio.Text = "Caracterización y diagnóstico de familias campesinas";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncion.Location = new System.Drawing.Point(289, 168);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(66, 20);
            this.lblFuncion.TabIndex = 1;
            this.lblFuncion.Text = "Función";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Items.AddRange(new object[] {
            "Familia campesina (Usuario)",
            "Encuestador",
            "Administrador"});
            this.cmbFuncion.Location = new System.Drawing.Point(423, 167);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncion.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(423, 231);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(423, 292);
            this.txtContraseña.MaxLength = 10;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(270, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(442, 357);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 41);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(338, 104);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(127, 21);
            this.lblInicioSesion.TabIndex = 9;
            this.lblInicioSesion.Text = "Inicio de sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(289, 229);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(289, 290);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(95, 20);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmbFuncion);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.TituloInicio);
            this.Name = "InicioDeSesion";
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloInicio;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
    }
}

