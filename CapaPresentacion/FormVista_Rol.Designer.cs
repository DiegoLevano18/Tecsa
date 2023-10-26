namespace CapaPresentacion
{
    partial class FormVista_Rol
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
            this.Cerrar_Rol = new System.Windows.Forms.Button();
            this.btnEliminar_Rol = new System.Windows.Forms.Button();
            this.btnEditar_Rol = new System.Windows.Forms.Button();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.btnNuevo_Rol = new System.Windows.Forms.Button();
            this.txtBuscar_Rol = new System.Windows.Forms.TextBox();
            this.lbl_Bucar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar_Rol
            // 
            this.Cerrar_Rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cerrar_Rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Cerrar_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrar_Rol.ForeColor = System.Drawing.Color.Silver;
            this.Cerrar_Rol.Location = new System.Drawing.Point(907, 13);
            this.Cerrar_Rol.Name = "Cerrar_Rol";
            this.Cerrar_Rol.Size = new System.Drawing.Size(75, 23);
            this.Cerrar_Rol.TabIndex = 20;
            this.Cerrar_Rol.Text = "X";
            this.Cerrar_Rol.UseVisualStyleBackColor = false;
            this.Cerrar_Rol.Click += new System.EventHandler(this.Cerrar_Rol_Click);
            // 
            // btnEliminar_Rol
            // 
            this.btnEliminar_Rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar_Rol.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Rol.Location = new System.Drawing.Point(733, 317);
            this.btnEliminar_Rol.Name = "btnEliminar_Rol";
            this.btnEliminar_Rol.Size = new System.Drawing.Size(150, 33);
            this.btnEliminar_Rol.TabIndex = 19;
            this.btnEliminar_Rol.Text = "Eliminar Módulo";
            this.btnEliminar_Rol.UseVisualStyleBackColor = true;
            this.btnEliminar_Rol.Click += new System.EventHandler(this.btnEliminar_Rol_Click);
            // 
            // btnEditar_Rol
            // 
            this.btnEditar_Rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar_Rol.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar_Rol.Location = new System.Drawing.Point(733, 237);
            this.btnEditar_Rol.Name = "btnEditar_Rol";
            this.btnEditar_Rol.Size = new System.Drawing.Size(150, 33);
            this.btnEditar_Rol.TabIndex = 18;
            this.btnEditar_Rol.Text = "Editar Módulo";
            this.btnEditar_Rol.UseVisualStyleBackColor = true;
            this.btnEditar_Rol.Click += new System.EventHandler(this.btnEditar_Rol_Click);
            // 
            // dgvRol
            // 
            this.dgvRol.AllowUserToAddRows = false;
            this.dgvRol.AllowUserToResizeRows = false;
            this.dgvRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvRol.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvRol.ColumnHeadersHeight = 35;
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRol.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRol.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRol.Location = new System.Drawing.Point(86, 240);
            this.dgvRol.MultiSelect = false;
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRol.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRol.RowHeadersVisible = false;
            this.dgvRol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dgvRol.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRol.RowTemplate.Height = 30;
            this.dgvRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRol.Size = new System.Drawing.Size(542, 377);
            this.dgvRol.TabIndex = 17;
            // 
            // btnNuevo_Rol
            // 
            this.btnNuevo_Rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo_Rol.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_Rol.Location = new System.Drawing.Point(733, 115);
            this.btnNuevo_Rol.Name = "btnNuevo_Rol";
            this.btnNuevo_Rol.Size = new System.Drawing.Size(150, 33);
            this.btnNuevo_Rol.TabIndex = 16;
            this.btnNuevo_Rol.Text = "+ Nuevo Módulo";
            this.btnNuevo_Rol.UseVisualStyleBackColor = true;
            this.btnNuevo_Rol.Click += new System.EventHandler(this.btnNuevo_Rol_Click);
            // 
            // txtBuscar_Rol
            // 
            this.txtBuscar_Rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar_Rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar_Rol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_Rol.Location = new System.Drawing.Point(203, 118);
            this.txtBuscar_Rol.Name = "txtBuscar_Rol";
            this.txtBuscar_Rol.Size = new System.Drawing.Size(425, 26);
            this.txtBuscar_Rol.TabIndex = 15;
            this.txtBuscar_Rol.Click += new System.EventHandler(this.txtBuscar_Rol_TextChanged);
            this.txtBuscar_Rol.TextChanged += new System.EventHandler(this.txtBuscar_Rol_TextChanged);
            // 
            // lbl_Bucar
            // 
            this.lbl_Bucar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bucar.AutoSize = true;
            this.lbl_Bucar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bucar.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Bucar.Location = new System.Drawing.Point(82, 121);
            this.lbl_Bucar.Name = "lbl_Bucar";
            this.lbl_Bucar.Size = new System.Drawing.Size(97, 21);
            this.lbl_Bucar.TabIndex = 14;
            this.lbl_Bucar.Text = "Buscar po ID";
            // 
            // FormVista_Rol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Cerrar_Rol);
            this.Controls.Add(this.btnEliminar_Rol);
            this.Controls.Add(this.btnEditar_Rol);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.btnNuevo_Rol);
            this.Controls.Add(this.txtBuscar_Rol);
            this.Controls.Add(this.lbl_Bucar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVista_Rol";
            this.Text = "FormVista_Rol";
            this.Load += new System.EventHandler(this.FormVista_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar_Rol;
        private System.Windows.Forms.Button btnEliminar_Rol;
        private System.Windows.Forms.Button btnEditar_Rol;
        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.Button btnNuevo_Rol;
        private System.Windows.Forms.TextBox txtBuscar_Rol;
        private System.Windows.Forms.Label lbl_Bucar;
    }
}