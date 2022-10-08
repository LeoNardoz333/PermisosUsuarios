
namespace PresentacionPermisosUsuarios
{
    partial class FrmPermisosAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdUsuario = new System.Windows.Forms.ComboBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModificarU = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMostrar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAgregar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModificar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // cmbIdUsuario
            // 
            this.cmbIdUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdUsuario.FormattingEnabled = true;
            this.cmbIdUsuario.Location = new System.Drawing.Point(87, 10);
            this.cmbIdUsuario.Name = "cmbIdUsuario";
            this.cmbIdUsuario.Size = new System.Drawing.Size(155, 28);
            this.cmbIdUsuario.TabIndex = 1;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Items.AddRange(new object[] {
            "Productos",
            "Herramientas"});
            this.cmbCodigo.Location = new System.Drawing.Point(340, 10);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(155, 28);
            this.cmbCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Módulo:";
            // 
            // cmbModificarU
            // 
            this.cmbModificarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModificarU.FormattingEnabled = true;
            this.cmbModificarU.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbModificarU.Location = new System.Drawing.Point(12, 83);
            this.cmbModificarU.Name = "cmbModificarU";
            this.cmbModificarU.Size = new System.Drawing.Size(155, 28);
            this.cmbModificarU.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modificar Permisos:";
            // 
            // cmbMostrar
            // 
            this.cmbMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMostrar.FormattingEnabled = true;
            this.cmbMostrar.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbMostrar.Location = new System.Drawing.Point(184, 83);
            this.cmbMostrar.Name = "cmbMostrar";
            this.cmbMostrar.Size = new System.Drawing.Size(155, 28);
            this.cmbMostrar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mostrar:";
            // 
            // cmbAgregar
            // 
            this.cmbAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAgregar.FormattingEnabled = true;
            this.cmbAgregar.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbAgregar.Location = new System.Drawing.Point(348, 83);
            this.cmbAgregar.Name = "cmbAgregar";
            this.cmbAgregar.Size = new System.Drawing.Size(155, 28);
            this.cmbAgregar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agregar:";
            // 
            // cmbModificar
            // 
            this.cmbModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModificar.FormattingEnabled = true;
            this.cmbModificar.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbModificar.Location = new System.Drawing.Point(12, 148);
            this.cmbModificar.Name = "cmbModificar";
            this.cmbModificar.Size = new System.Drawing.Size(155, 28);
            this.cmbModificar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modificar:";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbEliminar.Location = new System.Drawing.Point(184, 148);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(155, 28);
            this.cmbEliminar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Eliminar";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Thistle;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::PresentacionPermisosUsuarios.Properties.Resources.cerrar_sesion;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 40);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::PresentacionPermisosUsuarios.Properties.Resources.disquete;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(396, 183);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 40);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPermisosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 235);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbModificarU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIdUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisosAdd";
            this.Text = "Agregar/modificar permisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdUsuario;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModificarU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}