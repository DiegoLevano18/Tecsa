namespace CapaPresentacion
{
    partial class FormNuevo_Rol
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
            this.txtId_Rol = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.btnGuardar_Rol = new System.Windows.Forms.Button();
            this.lbl_Nombre_Operaciones = new System.Windows.Forms.Label();
            this.txtNombre_Rol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId_Rol
            // 
            this.txtId_Rol.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Rol.Location = new System.Drawing.Point(198, 41);
            this.txtId_Rol.Name = "txtId_Rol";
            this.txtId_Rol.Size = new System.Drawing.Size(145, 24);
            this.txtId_Rol.TabIndex = 18;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.Location = new System.Drawing.Point(104, 42);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(25, 19);
            this.Lbl_Id.TabIndex = 17;
            this.Lbl_Id.Text = "Id:";
            this.Lbl_Id.UseWaitCursor = true;
            // 
            // btnGuardar_Rol
            // 
            this.btnGuardar_Rol.Location = new System.Drawing.Point(340, 164);
            this.btnGuardar_Rol.Name = "btnGuardar_Rol";
            this.btnGuardar_Rol.Size = new System.Drawing.Size(102, 32);
            this.btnGuardar_Rol.TabIndex = 16;
            this.btnGuardar_Rol.Text = "Guardar";
            this.btnGuardar_Rol.UseVisualStyleBackColor = true;
            this.btnGuardar_Rol.Click += new System.EventHandler(this.btnGuardar_Rol_Click);
            // 
            // lbl_Nombre_Operaciones
            // 
            this.lbl_Nombre_Operaciones.AutoSize = true;
            this.lbl_Nombre_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Operaciones.Location = new System.Drawing.Point(62, 96);
            this.lbl_Nombre_Operaciones.Name = "lbl_Nombre_Operaciones";
            this.lbl_Nombre_Operaciones.Size = new System.Drawing.Size(67, 19);
            this.lbl_Nombre_Operaciones.TabIndex = 15;
            this.lbl_Nombre_Operaciones.Text = "Nombre:";
            // 
            // txtNombre_Rol
            // 
            this.txtNombre_Rol.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Rol.Location = new System.Drawing.Point(198, 96);
            this.txtNombre_Rol.Name = "txtNombre_Rol";
            this.txtNombre_Rol.Size = new System.Drawing.Size(145, 24);
            this.txtNombre_Rol.TabIndex = 14;
            // 
            // FormNuevo_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 226);
            this.Controls.Add(this.txtId_Rol);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.btnGuardar_Rol);
            this.Controls.Add(this.lbl_Nombre_Operaciones);
            this.Controls.Add(this.txtNombre_Rol);
            this.Name = "FormNuevo_Rol";
            this.Text = "FormNuevo_Rol";
            this.Load += new System.EventHandler(this.FormNuevo_Rol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId_Rol;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Button btnGuardar_Rol;
        private System.Windows.Forms.Label lbl_Nombre_Operaciones;
        private System.Windows.Forms.TextBox txtNombre_Rol;
    }
}