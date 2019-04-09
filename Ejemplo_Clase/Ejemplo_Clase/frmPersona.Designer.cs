namespace Ejemplo_Clase
{
    partial class frmPersona
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxSueldo = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLlamarForma = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(34, 116);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(34, 157);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // txtbxID
            // 
            this.txtbxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxID.Location = new System.Drawing.Point(106, 22);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(100, 20);
            this.txtbxID.TabIndex = 1;
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(106, 66);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(217, 20);
            this.txtbxNombre.TabIndex = 2;
            // 
            // txtbxSueldo
            // 
            this.txtbxSueldo.Location = new System.Drawing.Point(106, 109);
            this.txtbxSueldo.Name = "txtbxSueldo";
            this.txtbxSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtbxSueldo.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(343, 47);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(343, 84);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(343, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 20);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(427, 47);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(427, 84);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLlamarForma
            // 
            this.btnLlamarForma.Location = new System.Drawing.Point(427, 120);
            this.btnLlamarForma.Name = "btnLlamarForma";
            this.btnLlamarForma.Size = new System.Drawing.Size(75, 23);
            this.btnLlamarForma.TabIndex = 10;
            this.btnLlamarForma.Text = "Llamar forma";
            this.btnLlamarForma.UseVisualStyleBackColor = true;
            this.btnLlamarForma.Click += new System.EventHandler(this.btnLlamarForma_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(106, 157);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(217, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(343, 152);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 188);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnLlamarForma);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtbxSueldo);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmPersona";
            this.Text = "Persona";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersona_FormClosed);
            this.Load += new System.EventHandler(this.frmPersona_Load);
            this.Leave += new System.EventHandler(this.frmPersona_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxSueldo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLlamarForma;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnSalir;
    }
}

