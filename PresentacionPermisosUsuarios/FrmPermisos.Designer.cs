
namespace PresentacionPermisosUsuarios
{
    partial class FrmPermisos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbCambio = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(13, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos.Location = new System.Drawing.Point(13, 48);
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.Size = new System.Drawing.Size(722, 266);
            this.dtgPermisos.TabIndex = 2;
            this.dtgPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisos_CellClick);
            this.dtgPermisos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisos_CellEnter);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 317);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "1: Productos";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(9, 340);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 20);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "2: Herramientas";
            // 
            // cmbCambio
            // 
            this.cmbCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCambio.FormattingEnabled = true;
            this.cmbCambio.Items.AddRange(new object[] {
            "Permisos",
            "Usuarios"});
            this.cmbCambio.Location = new System.Drawing.Point(542, 14);
            this.cmbCambio.Name = "cmbCambio";
            this.cmbCambio.Size = new System.Drawing.Size(155, 28);
            this.cmbCambio.TabIndex = 6;
            this.cmbCambio.TextChanged += new System.EventHandler(this.cmbCambio_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Thistle;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::PresentacionPermisosUsuarios.Properties.Resources.cerrar_sesion;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(616, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::PresentacionPermisosUsuarios.Properties.Resources.anadir;
            this.btnAgregar.Location = new System.Drawing.Point(703, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 368);
            this.Controls.Add(this.cmbCambio);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgPermisos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar permisos de los usuarios";
            this.Load += new System.EventHandler(this.FrmPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbCambio;
    }
}