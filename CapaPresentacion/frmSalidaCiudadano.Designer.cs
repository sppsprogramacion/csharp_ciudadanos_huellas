namespace CapaPresentacion
{
    partial class frmSalidaCiudadano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalidaCiudadano));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdRegistroDiario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            this.dgvListaRegistroDiario = new System.Windows.Forms.DataGridView();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.btnVerListadoPendiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistroDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formuario para dar salida a ciudadanos:";
            // 
            // txtIdRegistroDiario
            // 
            this.txtIdRegistroDiario.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtIdRegistroDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRegistroDiario.ForeColor = System.Drawing.Color.White;
            this.txtIdRegistroDiario.Location = new System.Drawing.Point(14, 567);
            this.txtIdRegistroDiario.Name = "txtIdRegistroDiario";
            this.txtIdRegistroDiario.ReadOnly = true;
            this.txtIdRegistroDiario.Size = new System.Drawing.Size(50, 29);
            this.txtIdRegistroDiario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar por Fecha:";
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.BackColor = System.Drawing.Color.White;
            this.btnBuscarApellido.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarApellido.Image")));
            this.btnBuscarApellido.Location = new System.Drawing.Point(223, 76);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(132, 33);
            this.btnBuscarApellido.TabIndex = 3;
            this.btnBuscarApellido.Text = "Buscar";
            this.btnBuscarApellido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarApellido.UseVisualStyleBackColor = false;
            this.btnBuscarApellido.Click += new System.EventHandler(this.btnBuscarApellido_Click);
            // 
            // dgvListaRegistroDiario
            // 
            this.dgvListaRegistroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRegistroDiario.Location = new System.Drawing.Point(14, 112);
            this.dgvListaRegistroDiario.Name = "dgvListaRegistroDiario";
            this.dgvListaRegistroDiario.Size = new System.Drawing.Size(905, 428);
            this.dgvListaRegistroDiario.TabIndex = 4;
            this.dgvListaRegistroDiario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListaCiudadanos_KeyDown);
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.BackColor = System.Drawing.Color.White;
            this.btnRegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarSalida.Image")));
            this.btnRegistrarSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSalida.Location = new System.Drawing.Point(757, 546);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(162, 47);
            this.btnRegistrarSalida.TabIndex = 6;
            this.btnRegistrarSalida.Text = "Registrar Horario Salida ";
            this.btnRegistrarSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarSalida.UseVisualStyleBackColor = false;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hora Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hora Fin:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(111, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(111, 58);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(106, 20);
            this.dtpHoraInicio.TabIndex = 1;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(111, 86);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(106, 20);
            this.dtpHoraFin.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(72, 567);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(576, 29);
            this.txtNombre.TabIndex = 18;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(654, 567);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(97, 26);
            this.dtpHoraSalida.TabIndex = 10;
            // 
            // btnVerListadoPendiente
            // 
            this.btnVerListadoPendiente.BackColor = System.Drawing.Color.White;
            this.btnVerListadoPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerListadoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListadoPendiente.Image = ((System.Drawing.Image)(resources.GetObject("btnVerListadoPendiente.Image")));
            this.btnVerListadoPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerListadoPendiente.Location = new System.Drawing.Point(375, 75);
            this.btnVerListadoPendiente.Name = "btnVerListadoPendiente";
            this.btnVerListadoPendiente.Size = new System.Drawing.Size(217, 33);
            this.btnVerListadoPendiente.TabIndex = 19;
            this.btnVerListadoPendiente.Text = "Pendiente Salida del dia";
            this.btnVerListadoPendiente.UseVisualStyleBackColor = false;
            this.btnVerListadoPendiente.Click += new System.EventHandler(this.btnVerListadoPendiente_Click);
            // 
            // frmSalidaCiudadano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 620);
            this.Controls.Add(this.btnVerListadoPendiente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dgvListaRegistroDiario);
            this.Controls.Add(this.btnBuscarApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdRegistroDiario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalidaCiudadano";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Salidas de Ciudadano";
            this.Load += new System.EventHandler(this.frmSalidaCiudadano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistroDiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdRegistroDiario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarApellido;
        private System.Windows.Forms.DataGridView dgvListaRegistroDiario;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Button btnVerListadoPendiente;
    }
}