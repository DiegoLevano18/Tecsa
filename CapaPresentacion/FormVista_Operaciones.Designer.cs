namespace CapaPresentacion
{
    partial class FormVista_Operaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cerrar_Operaciones = new System.Windows.Forms.Button();
            this.btnEliminar_Operaciones = new System.Windows.Forms.Button();
            this.btnEditar_Operaciones = new System.Windows.Forms.Button();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.btnNuevo_Operaciones = new System.Windows.Forms.Button();
            this.txtBuscar_Operaciones = new System.Windows.Forms.TextBox();
            this.lbl_Bucar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar_Operaciones
            // 
            this.Cerrar_Operaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cerrar_Operaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Cerrar_Operaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrar_Operaciones.ForeColor = System.Drawing.Color.Silver;
            this.Cerrar_Operaciones.Location = new System.Drawing.Point(913, 12);
            this.Cerrar_Operaciones.Name = "Cerrar_Operaciones";
            this.Cerrar_Operaciones.Size = new System.Drawing.Size(75, 23);
            this.Cerrar_Operaciones.TabIndex = 13;
            this.Cerrar_Operaciones.Text = "X";
            this.Cerrar_Operaciones.UseVisualStyleBackColor = false;
            this.Cerrar_Operaciones.Click += new System.EventHandler(this.Cerrar_Operaciones_Click);
            // 
            // btnEliminar_Operaciones
            // 
            this.btnEliminar_Operaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Operaciones.Location = new System.Drawing.Point(739, 316);
            this.btnEliminar_Operaciones.Name = "btnEliminar_Operaciones";
            this.btnEliminar_Operaciones.Size = new System.Drawing.Size(150, 33);
            this.btnEliminar_Operaciones.TabIndex = 12;
            this.btnEliminar_Operaciones.Text = "Eliminar Módulo";
            this.btnEliminar_Operaciones.UseVisualStyleBackColor = true;
            this.btnEliminar_Operaciones.Click += new System.EventHandler(this.btnEliminar_Operaciones_Click);
            // 
            // btnEditar_Operaciones
            // 
            this.btnEditar_Operaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar_Operaciones.Location = new System.Drawing.Point(739, 236);
            this.btnEditar_Operaciones.Name = "btnEditar_Operaciones";
            this.btnEditar_Operaciones.Size = new System.Drawing.Size(150, 33);
            this.btnEditar_Operaciones.TabIndex = 11;
            this.btnEditar_Operaciones.Text = "Editar Módulo";
            this.btnEditar_Operaciones.UseVisualStyleBackColor = true;
            this.btnEditar_Operaciones.Click += new System.EventHandler(this.btnEditar_Operaciones_Click);
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToResizeRows = false;
            this.dgvOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOperaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvOperaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvOperaciones.ColumnHeadersHeight = 35;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOperaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperaciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperaciones.Location = new System.Drawing.Point(92, 239);
            this.dgvOperaciones.MultiSelect = false;
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperaciones.RowHeadersVisible = false;
            this.dgvOperaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dgvOperaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperaciones.RowTemplate.Height = 30;
            this.dgvOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperaciones.Size = new System.Drawing.Size(542, 377);
            this.dgvOperaciones.TabIndex = 10;
            // 
            // btnNuevo_Operaciones
            // 
            this.btnNuevo_Operaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_Operaciones.Location = new System.Drawing.Point(739, 114);
            this.btnNuevo_Operaciones.Name = "btnNuevo_Operaciones";
            this.btnNuevo_Operaciones.Size = new System.Drawing.Size(150, 33);
            this.btnNuevo_Operaciones.TabIndex = 9;
            this.btnNuevo_Operaciones.Text = "+ Nuevo Módulo";
            this.btnNuevo_Operaciones.UseVisualStyleBackColor = true;
            this.btnNuevo_Operaciones.Click += new System.EventHandler(this.btnNuevo_Operaciones_Click);
            // 
            // txtBuscar_Operaciones
            // 
            this.txtBuscar_Operaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar_Operaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar_Operaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar_Operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_Operaciones.Location = new System.Drawing.Point(209, 117);
            this.txtBuscar_Operaciones.Name = "txtBuscar_Operaciones";
            this.txtBuscar_Operaciones.Size = new System.Drawing.Size(425, 26);
            this.txtBuscar_Operaciones.TabIndex = 8;
            this.txtBuscar_Operaciones.Click += new System.EventHandler(this.txtBuscar_Operaciones_TextChanged);
            this.txtBuscar_Operaciones.TextChanged += new System.EventHandler(this.txtBuscar_Operaciones_TextChanged);
            // 
            // lbl_Bucar
            // 
            this.lbl_Bucar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bucar.AutoSize = true;
            this.lbl_Bucar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bucar.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Bucar.Location = new System.Drawing.Point(88, 120);
            this.lbl_Bucar.Name = "lbl_Bucar";
            this.lbl_Bucar.Size = new System.Drawing.Size(97, 21);
            this.lbl_Bucar.TabIndex = 7;
            this.lbl_Bucar.Text = "Buscar po ID";
            // 
            // FormVista_Operaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Cerrar_Operaciones);
            this.Controls.Add(this.btnEliminar_Operaciones);
            this.Controls.Add(this.btnEditar_Operaciones);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.btnNuevo_Operaciones);
            this.Controls.Add(this.txtBuscar_Operaciones);
            this.Controls.Add(this.lbl_Bucar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVista_Operaciones";
            this.Text = "FormVista_Operaciones";
            this.Load += new System.EventHandler(this.FormVista_Operaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar_Operaciones;
        private System.Windows.Forms.Button btnEliminar_Operaciones;
        private System.Windows.Forms.Button btnEditar_Operaciones;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Button btnNuevo_Operaciones;
        private System.Windows.Forms.TextBox txtBuscar_Operaciones;
        private System.Windows.Forms.Label lbl_Bucar;
    }
}