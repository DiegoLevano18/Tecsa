namespace CapaPresentacion
{
    partial class FormVista_RolOperaciones
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
            this.Cerrar_RolOperaciones = new System.Windows.Forms.Button();
            this.btnEliminar_RolOperaciones = new System.Windows.Forms.Button();
            this.btnEditar_RolOperaciones = new System.Windows.Forms.Button();
            this.dgvRolOperaciones = new System.Windows.Forms.DataGridView();
            this.btnNuevo_RolOperaciones = new System.Windows.Forms.Button();
            this.txtBuscar_RolOperaciones = new System.Windows.Forms.TextBox();
            this.lbl_Bucar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar_RolOperaciones
            // 
            this.Cerrar_RolOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cerrar_RolOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Cerrar_RolOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrar_RolOperaciones.ForeColor = System.Drawing.Color.Silver;
            this.Cerrar_RolOperaciones.Location = new System.Drawing.Point(911, 13);
            this.Cerrar_RolOperaciones.Name = "Cerrar_RolOperaciones";
            this.Cerrar_RolOperaciones.Size = new System.Drawing.Size(75, 23);
            this.Cerrar_RolOperaciones.TabIndex = 20;
            this.Cerrar_RolOperaciones.Text = "X";
            this.Cerrar_RolOperaciones.UseVisualStyleBackColor = false;
            this.Cerrar_RolOperaciones.Click += new System.EventHandler(this.Cerrar_RolOperaciones_Click);
            // 
            // btnEliminar_RolOperaciones
            // 
            this.btnEliminar_RolOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar_RolOperaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_RolOperaciones.Location = new System.Drawing.Point(737, 317);
            this.btnEliminar_RolOperaciones.Name = "btnEliminar_RolOperaciones";
            this.btnEliminar_RolOperaciones.Size = new System.Drawing.Size(150, 33);
            this.btnEliminar_RolOperaciones.TabIndex = 19;
            this.btnEliminar_RolOperaciones.Text = "Eliminar Módulo";
            this.btnEliminar_RolOperaciones.UseVisualStyleBackColor = true;
            this.btnEliminar_RolOperaciones.Click += new System.EventHandler(this.btnEliminar_RolOperaciones_Click);
            // 
            // btnEditar_RolOperaciones
            // 
            this.btnEditar_RolOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar_RolOperaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar_RolOperaciones.Location = new System.Drawing.Point(737, 237);
            this.btnEditar_RolOperaciones.Name = "btnEditar_RolOperaciones";
            this.btnEditar_RolOperaciones.Size = new System.Drawing.Size(150, 33);
            this.btnEditar_RolOperaciones.TabIndex = 18;
            this.btnEditar_RolOperaciones.Text = "Editar Módulo";
            this.btnEditar_RolOperaciones.UseVisualStyleBackColor = true;
            this.btnEditar_RolOperaciones.Click += new System.EventHandler(this.btnEditar_RolOperaciones_Click);
            // 
            // dgvRolOperaciones
            // 
            this.dgvRolOperaciones.AllowUserToAddRows = false;
            this.dgvRolOperaciones.AllowUserToResizeRows = false;
            this.dgvRolOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRolOperaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvRolOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRolOperaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvRolOperaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvRolOperaciones.ColumnHeadersHeight = 35;
            this.dgvRolOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRolOperaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRolOperaciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRolOperaciones.Location = new System.Drawing.Point(90, 240);
            this.dgvRolOperaciones.MultiSelect = false;
            this.dgvRolOperaciones.Name = "dgvRolOperaciones";
            this.dgvRolOperaciones.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolOperaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRolOperaciones.RowHeadersVisible = false;
            this.dgvRolOperaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dgvRolOperaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRolOperaciones.RowTemplate.Height = 30;
            this.dgvRolOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRolOperaciones.Size = new System.Drawing.Size(542, 377);
            this.dgvRolOperaciones.TabIndex = 17;
            // 
            // btnNuevo_RolOperaciones
            // 
            this.btnNuevo_RolOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo_RolOperaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_RolOperaciones.Location = new System.Drawing.Point(737, 115);
            this.btnNuevo_RolOperaciones.Name = "btnNuevo_RolOperaciones";
            this.btnNuevo_RolOperaciones.Size = new System.Drawing.Size(150, 33);
            this.btnNuevo_RolOperaciones.TabIndex = 16;
            this.btnNuevo_RolOperaciones.Text = "+ Nuevo Módulo";
            this.btnNuevo_RolOperaciones.UseVisualStyleBackColor = true;
            this.btnNuevo_RolOperaciones.Click += new System.EventHandler(this.btnNuevo_RolOperaciones_Click);
            // 
            // txtBuscar_RolOperaciones
            // 
            this.txtBuscar_RolOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar_RolOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar_RolOperaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar_RolOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_RolOperaciones.Location = new System.Drawing.Point(207, 118);
            this.txtBuscar_RolOperaciones.Name = "txtBuscar_RolOperaciones";
            this.txtBuscar_RolOperaciones.Size = new System.Drawing.Size(425, 26);
            this.txtBuscar_RolOperaciones.TabIndex = 15;
            this.txtBuscar_RolOperaciones.Click += new System.EventHandler(this.txtBuscar_RolOperaciones_TextChanged);
            this.txtBuscar_RolOperaciones.TextChanged += new System.EventHandler(this.txtBuscar_RolOperaciones_TextChanged);
            // 
            // lbl_Bucar
            // 
            this.lbl_Bucar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bucar.AutoSize = true;
            this.lbl_Bucar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bucar.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Bucar.Location = new System.Drawing.Point(86, 121);
            this.lbl_Bucar.Name = "lbl_Bucar";
            this.lbl_Bucar.Size = new System.Drawing.Size(97, 21);
            this.lbl_Bucar.TabIndex = 14;
            this.lbl_Bucar.Text = "Buscar po ID";
            // 
            // FormVista_RolOperaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Cerrar_RolOperaciones);
            this.Controls.Add(this.btnEliminar_RolOperaciones);
            this.Controls.Add(this.btnEditar_RolOperaciones);
            this.Controls.Add(this.dgvRolOperaciones);
            this.Controls.Add(this.btnNuevo_RolOperaciones);
            this.Controls.Add(this.txtBuscar_RolOperaciones);
            this.Controls.Add(this.lbl_Bucar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVista_RolOperaciones";
            this.Text = "FormVista_RolOperaciones";
            this.Load += new System.EventHandler(this.FormVista_RolOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar_RolOperaciones;
        private System.Windows.Forms.Button btnEliminar_RolOperaciones;
        private System.Windows.Forms.Button btnEditar_RolOperaciones;
        private System.Windows.Forms.DataGridView dgvRolOperaciones;
        private System.Windows.Forms.Button btnNuevo_RolOperaciones;
        private System.Windows.Forms.TextBox txtBuscar_RolOperaciones;
        private System.Windows.Forms.Label lbl_Bucar;
    }
}