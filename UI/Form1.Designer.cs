using System.Threading.Tasks;

namespace UI
{
    partial class FrmPrincipal
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
            this.SuspendLayout();
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(508, 409);
            this.Name = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox txtNombreP;
        private MaterialSkin.Controls.MaterialTextBox txtCaracteristicaP;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtNombreI;
        private MaterialSkin.Controls.MaterialButton btnEnviarI;
        private MaterialSkin.Controls.MaterialButton BtnCalcular;
        private MaterialSkin.Controls.MaterialButton BtnEliminar;
        private MaterialSkin.Controls.MaterialListView dataGridView1;
        private System.Windows.Forms.DataGridView datagrid;
    }
}

