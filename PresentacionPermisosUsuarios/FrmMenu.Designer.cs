
namespace PresentacionPermisosUsuarios
{
    partial class FrmMenu
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
            this.tlMenu = new System.Windows.Forms.ToolStrip();
            this.optPermisos = new System.Windows.Forms.ToolStripButton();
            this.optProductos = new System.Windows.Forms.ToolStripButton();
            this.optHerramientas = new System.Windows.Forms.ToolStripButton();
            this.tlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMenu
            // 
            this.tlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optPermisos,
            this.optProductos,
            this.optHerramientas});
            this.tlMenu.Location = new System.Drawing.Point(0, 0);
            this.tlMenu.Name = "tlMenu";
            this.tlMenu.Size = new System.Drawing.Size(141, 303);
            this.tlMenu.TabIndex = 0;
            this.tlMenu.Text = "toolStrip1";
            // 
            // optPermisos
            // 
            this.optPermisos.Image = global::PresentacionPermisosUsuarios.Properties.Resources.Usuario;
            this.optPermisos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optPermisos.Name = "optPermisos";
            this.optPermisos.Size = new System.Drawing.Size(138, 20);
            this.optPermisos.Text = "Administrar Permisos";
            // 
            // optProductos
            // 
            this.optProductos.Image = global::PresentacionPermisosUsuarios.Properties.Resources.caja;
            this.optProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optProductos.Name = "optProductos";
            this.optProductos.Size = new System.Drawing.Size(138, 20);
            this.optProductos.Text = "Productos";
            // 
            // optHerramientas
            // 
            this.optHerramientas.Image = global::PresentacionPermisosUsuarios.Properties.Resources.configuraciones;
            this.optHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optHerramientas.Name = "optHerramientas";
            this.optHerramientas.Size = new System.Drawing.Size(138, 20);
            this.optHerramientas.Text = "Herramientas";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 303);
            this.Controls.Add(this.tlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Módulos disponibles";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.tlMenu.ResumeLayout(false);
            this.tlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlMenu;
        private System.Windows.Forms.ToolStripButton optPermisos;
        private System.Windows.Forms.ToolStripButton optProductos;
        private System.Windows.Forms.ToolStripButton optHerramientas;
    }
}