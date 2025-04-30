namespace PedidosApp
{
    partial class HistorialForm
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbFiltroEntrega = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(240, 66);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(297, 328);
            this.dgvHistorial.TabIndex = 0;
            // 
            // cmbFiltroEntrega
            // 
            this.cmbFiltroEntrega.FormattingEnabled = true;
            this.cmbFiltroEntrega.Location = new System.Drawing.Point(33, 137);
            this.cmbFiltroEntrega.Name = "cmbFiltroEntrega";
            this.cmbFiltroEntrega.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroEntrega.TabIndex = 1;
            this.cmbFiltroEntrega.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEntrega_SelectedIndexChanged);
            // 
            // HistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.cmbFiltroEntrega);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "HistorialForm";
            this.Text = "HistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cmbFiltroEntrega;
    }
}