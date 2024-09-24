namespace Familias_campesinas
{
    partial class MenuPrincipal
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
            this.TituloMenu = new System.Windows.Forms.Label();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnComponenteSocial = new System.Windows.Forms.Button();
            this.btnComponenteProductivo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInformacionGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloMenu
            // 
            this.TituloMenu.AutoSize = true;
            this.TituloMenu.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloMenu.Location = new System.Drawing.Point(12, 30);
            this.TituloMenu.Name = "TituloMenu";
            this.TituloMenu.Size = new System.Drawing.Size(772, 40);
            this.TituloMenu.TabIndex = 1;
            this.TituloMenu.Text = "Caracterización y diagnóstico de familias campesinas";
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(298, 112);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(209, 35);
            this.lblMenuPrincipal.TabIndex = 2;
            this.lblMenuPrincipal.Text = "Menú principal";
            // 
            // btnComponenteSocial
            // 
            this.btnComponenteSocial.BackColor = System.Drawing.Color.Silver;
            this.btnComponenteSocial.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponenteSocial.Location = new System.Drawing.Point(304, 226);
            this.btnComponenteSocial.Name = "btnComponenteSocial";
            this.btnComponenteSocial.Size = new System.Drawing.Size(190, 56);
            this.btnComponenteSocial.TabIndex = 59;
            this.btnComponenteSocial.Text = "Componente social";
            this.btnComponenteSocial.UseVisualStyleBackColor = false;
            this.btnComponenteSocial.Click += new System.EventHandler(this.btnComponenteSocial_Click);
            // 
            // btnComponenteProductivo
            // 
            this.btnComponenteProductivo.BackColor = System.Drawing.Color.Silver;
            this.btnComponenteProductivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponenteProductivo.Location = new System.Drawing.Point(563, 226);
            this.btnComponenteProductivo.Name = "btnComponenteProductivo";
            this.btnComponenteProductivo.Size = new System.Drawing.Size(190, 56);
            this.btnComponenteProductivo.TabIndex = 60;
            this.btnComponenteProductivo.Text = "Componente productivo";
            this.btnComponenteProductivo.UseVisualStyleBackColor = false;
            this.btnComponenteProductivo.Click += new System.EventHandler(this.btnComponenteProductivo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(333, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 56);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInformacionGeneral
            // 
            this.btnInformacionGeneral.BackColor = System.Drawing.Color.Silver;
            this.btnInformacionGeneral.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacionGeneral.Location = new System.Drawing.Point(47, 226);
            this.btnInformacionGeneral.Name = "btnInformacionGeneral";
            this.btnInformacionGeneral.Size = new System.Drawing.Size(190, 56);
            this.btnInformacionGeneral.TabIndex = 62;
            this.btnInformacionGeneral.Text = "Información general";
            this.btnInformacionGeneral.UseVisualStyleBackColor = false;
            this.btnInformacionGeneral.Click += new System.EventHandler(this.btnInformacionGeneral_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInformacionGeneral);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnComponenteProductivo);
            this.Controls.Add(this.btnComponenteSocial);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.TituloMenu);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloMenu;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnComponenteSocial;
        private System.Windows.Forms.Button btnComponenteProductivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInformacionGeneral;
    }
}