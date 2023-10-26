namespace CapaPresentacion
{
    partial class FormNuevo_Operaciones
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
            this.txtId_Operaciones = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.btnGuardar_Operaciones = new System.Windows.Forms.Button();
            this.lbl_Nombre_Operaciones = new System.Windows.Forms.Label();
            this.txtNombre_Operaciones = new System.Windows.Forms.TextBox();
            this.lblIdModuloSistema_Operaciones = new System.Windows.Forms.Label();
            this.txtIdModuloSistema_Operaciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId_Operaciones
            // 
            this.txtId_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Operaciones.Location = new System.Drawing.Point(189, 31);
            this.txtId_Operaciones.Name = "txtId_Operaciones";
            this.txtId_Operaciones.Size = new System.Drawing.Size(145, 24);
            this.txtId_Operaciones.TabIndex = 11;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.Location = new System.Drawing.Point(95, 32);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(25, 19);
            this.Lbl_Id.TabIndex = 10;
            this.Lbl_Id.Text = "Id:";
            this.Lbl_Id.UseWaitCursor = true;
            // 
            // btnGuardar_Operaciones
            // 
            this.btnGuardar_Operaciones.Location = new System.Drawing.Point(332, 208);
            this.btnGuardar_Operaciones.Name = "btnGuardar_Operaciones";
            this.btnGuardar_Operaciones.Size = new System.Drawing.Size(102, 32);
            this.btnGuardar_Operaciones.TabIndex = 9;
            this.btnGuardar_Operaciones.Text = "Guardar";
            this.btnGuardar_Operaciones.UseVisualStyleBackColor = true;
            this.btnGuardar_Operaciones.Click += new System.EventHandler(this.btnGuardar_Operaciones_Click);
            // 
            // lbl_Nombre_Operaciones
            // 
            this.lbl_Nombre_Operaciones.AutoSize = true;
            this.lbl_Nombre_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Operaciones.Location = new System.Drawing.Point(53, 86);
            this.lbl_Nombre_Operaciones.Name = "lbl_Nombre_Operaciones";
            this.lbl_Nombre_Operaciones.Size = new System.Drawing.Size(67, 19);
            this.lbl_Nombre_Operaciones.TabIndex = 8;
            this.lbl_Nombre_Operaciones.Text = "Nombre:";
            // 
            // txtNombre_Operaciones
            // 
            this.txtNombre_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Operaciones.Location = new System.Drawing.Point(189, 86);
            this.txtNombre_Operaciones.Name = "txtNombre_Operaciones";
            this.txtNombre_Operaciones.Size = new System.Drawing.Size(145, 24);
            this.txtNombre_Operaciones.TabIndex = 7;
            // 
            // lblIdModuloSistema_Operaciones
            // 
            this.lblIdModuloSistema_Operaciones.AutoSize = true;
            this.lblIdModuloSistema_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdModuloSistema_Operaciones.Location = new System.Drawing.Point(39, 139);
            this.lblIdModuloSistema_Operaciones.Name = "lblIdModuloSistema_Operaciones";
            this.lblIdModuloSistema_Operaciones.Size = new System.Drawing.Size(81, 19);
            this.lblIdModuloSistema_Operaciones.TabIndex = 13;
            this.lblIdModuloSistema_Operaciones.Text = "Id Modulo:";
            this.lblIdModuloSistema_Operaciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdModuloSistema_Operaciones
            // 
            this.txtIdModuloSistema_Operaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdModuloSistema_Operaciones.Location = new System.Drawing.Point(189, 139);
            this.txtIdModuloSistema_Operaciones.Name = "txtIdModuloSistema_Operaciones";
            this.txtIdModuloSistema_Operaciones.Size = new System.Drawing.Size(145, 24);
            this.txtIdModuloSistema_Operaciones.TabIndex = 12;
            this.txtIdModuloSistema_Operaciones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormNuevo_Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 263);
            this.Controls.Add(this.lblIdModuloSistema_Operaciones);
            this.Controls.Add(this.txtIdModuloSistema_Operaciones);
            this.Controls.Add(this.txtId_Operaciones);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.btnGuardar_Operaciones);
            this.Controls.Add(this.lbl_Nombre_Operaciones);
            this.Controls.Add(this.txtNombre_Operaciones);
            this.Name = "FormNuevo_Operaciones";
            this.Text = "FormNuevo_Operaciones";
            this.Load += new System.EventHandler(this.FormNuevo_Operaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId_Operaciones;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Button btnGuardar_Operaciones;
        private System.Windows.Forms.Label lbl_Nombre_Operaciones;
        private System.Windows.Forms.TextBox txtNombre_Operaciones;
        private System.Windows.Forms.Label lblIdModuloSistema_Operaciones;
        private System.Windows.Forms.TextBox txtIdModuloSistema_Operaciones;
    }
}