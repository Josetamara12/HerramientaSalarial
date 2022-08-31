
namespace proyectoGrafico_trabajoFinal
{
    partial class pantallaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaLogin));
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.picboxLoginBasic = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblLoginBienvenida = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picboxNasalogin = new System.Windows.Forms.PictureBox();
            this.picboxCerrar = new System.Windows.Forms.PictureBox();
            this.picboxMinimizar = new System.Windows.Forms.PictureBox();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoginBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNasalogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelLogin.Controls.Add(this.picboxLoginBasic);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(250, 302);
            this.PanelLogin.TabIndex = 0;
            this.PanelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLogin_MouseDown);
            // 
            // picboxLoginBasic
            // 
            this.picboxLoginBasic.Image = ((System.Drawing.Image)(resources.GetObject("picboxLoginBasic.Image")));
            this.picboxLoginBasic.Location = new System.Drawing.Point(34, 41);
            this.picboxLoginBasic.Name = "picboxLoginBasic";
            this.picboxLoginBasic.Size = new System.Drawing.Size(159, 198);
            this.picboxLoginBasic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLoginBasic.TabIndex = 0;
            this.picboxLoginBasic.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsuario.Location = new System.Drawing.Point(338, 103);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(114, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "USUARIO : ";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.LightGray;
            this.lblContraseña.Location = new System.Drawing.Point(338, 148);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(160, 24);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "CONTRASEÑA :";
            // 
            // lblLoginBienvenida
            // 
            this.lblLoginBienvenida.AutoSize = true;
            this.lblLoginBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblLoginBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoginBienvenida.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginBienvenida.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoginBienvenida.Location = new System.Drawing.Point(470, 20);
            this.lblLoginBienvenida.Name = "lblLoginBienvenida";
            this.lblLoginBienvenida.Size = new System.Drawing.Size(120, 39);
            this.lblLoginBienvenida.TabIndex = 2;
            this.lblLoginBienvenida.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.txtUsuario.Location = new System.Drawing.Point(540, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 19);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.LightGray;
            this.txtContraseña.Location = new System.Drawing.Point(540, 153);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(210, 19);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Location = new System.Drawing.Point(342, 216);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(124, 37);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalir.Location = new System.Drawing.Point(531, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picboxNasalogin
            // 
            this.picboxNasalogin.Image = ((System.Drawing.Image)(resources.GetObject("picboxNasalogin.Image")));
            this.picboxNasalogin.Location = new System.Drawing.Point(672, 216);
            this.picboxNasalogin.Name = "picboxNasalogin";
            this.picboxNasalogin.Size = new System.Drawing.Size(103, 86);
            this.picboxNasalogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxNasalogin.TabIndex = 1;
            this.picboxNasalogin.TabStop = false;
            // 
            // picboxCerrar
            // 
            this.picboxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picboxCerrar.Image")));
            this.picboxCerrar.Location = new System.Drawing.Point(756, 0);
            this.picboxCerrar.Name = "picboxCerrar";
            this.picboxCerrar.Size = new System.Drawing.Size(19, 18);
            this.picboxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCerrar.TabIndex = 7;
            this.picboxCerrar.TabStop = false;
            this.picboxCerrar.Click += new System.EventHandler(this.picboxCerrar_Click);
            // 
            // picboxMinimizar
            // 
            this.picboxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picboxMinimizar.Image")));
            this.picboxMinimizar.Location = new System.Drawing.Point(743, 0);
            this.picboxMinimizar.Name = "picboxMinimizar";
            this.picboxMinimizar.Size = new System.Drawing.Size(17, 18);
            this.picboxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxMinimizar.TabIndex = 8;
            this.picboxMinimizar.TabStop = false;
            this.picboxMinimizar.Click += new System.EventHandler(this.picboxMinimizar_Click);
            // 
            // pantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(776, 302);
            this.Controls.Add(this.picboxMinimizar);
            this.Controls.Add(this.picboxCerrar);
            this.Controls.Add(this.picboxNasalogin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblLoginBienvenida);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.PanelLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pantallaLogin";
            this.Opacity = 0.8D;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pantallaLogin_MouseDown);
            this.PanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoginBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNasalogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblLoginBienvenida;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picboxLoginBasic;
        private System.Windows.Forms.PictureBox picboxNasalogin;
        private System.Windows.Forms.PictureBox picboxCerrar;
        private System.Windows.Forms.PictureBox picboxMinimizar;
    }
}

