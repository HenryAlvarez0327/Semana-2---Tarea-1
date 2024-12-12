namespace _01_Mi_Primera_Vez.Presentacion
{
    partial class CUUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnAgregarNuevoPersonal = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(205, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(271, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(205, 145);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(271, 22);
            this.textContraseña.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textContraseña);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 244);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(704, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 695);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_01_Mi_Primera_Vez.Properties.Resources.interfaz_de_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(121, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPersonal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Image = global::_01_Mi_Primera_Vez.Properties.Resources.usuario;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(40, 412);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(278, 79);
            this.btnPersonal.TabIndex = 9;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnAgregarNuevoPersonal
            // 
            this.btnAgregarNuevoPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregarNuevoPersonal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevoPersonal.Image = global::_01_Mi_Primera_Vez.Properties.Resources.contacto;
            this.btnAgregarNuevoPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevoPersonal.Location = new System.Drawing.Point(40, 314);
            this.btnAgregarNuevoPersonal.Name = "btnAgregarNuevoPersonal";
            this.btnAgregarNuevoPersonal.Size = new System.Drawing.Size(278, 79);
            this.btnAgregarNuevoPersonal.TabIndex = 6;
            this.btnAgregarNuevoPersonal.Text = "Agregar Nuevo Personal";
            this.btnAgregarNuevoPersonal.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoPersonal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIngresar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Image = global::_01_Mi_Primera_Vez.Properties.Resources.la_mejor_experiencia_del_cliente;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(363, 314);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(278, 79);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // CUUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarNuevoPersonal);
            this.Controls.Add(this.btnIngresar);
            this.Name = "CUUsuario";
            this.Size = new System.Drawing.Size(1113, 695);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnAgregarNuevoPersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
