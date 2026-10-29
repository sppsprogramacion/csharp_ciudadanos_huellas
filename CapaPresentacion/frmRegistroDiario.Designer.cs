namespace CapaPresentacion
{
    partial class frmRegistroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDiario));
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarDocumento = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbTipoAcceso = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.cmbOrganismoDestino = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbTipoAtencion = new System.Windows.Forms.ComboBox();
            this.txtNombreCiudadanoIngreso = new System.Windows.Forms.Label();
            this.txtDniCiudadanoIngreso = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNombreCiudadano = new System.Windows.Forms.TextBox();
            this.txtDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.txtIdCiudadanoIngreso = new System.Windows.Forms.TextBox();
            this.dgvCiudadanosRegistroDiario = new System.Windows.Forms.DataGridView();
            this.cmbMotivoAtencion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarInternos = new System.Windows.Forms.Button();
            this.btnCrearRegistroDiario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ptbFotoCiudadano = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarInternos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnProhibiciones = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanosRegistroDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoCiudadano)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(120, 32);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(281, 20);
            this.txtBuscarApellido.TabIndex = 0;
            this.txtBuscarApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarApellido_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar DNI:";
            // 
            // txtBuscarDocumento
            // 
            this.txtBuscarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDocumento.Location = new System.Drawing.Point(561, 28);
            this.txtBuscarDocumento.Name = "txtBuscarDocumento";
            this.txtBuscarDocumento.Size = new System.Drawing.Size(159, 20);
            this.txtBuscarDocumento.TabIndex = 3;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(70, 13);
            this.label33.TabIndex = 43;
            this.label33.Text = "Tipo Acceso:";
            // 
            // cmbTipoAcceso
            // 
            this.cmbTipoAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAcceso.FormattingEnabled = true;
            this.cmbTipoAcceso.Location = new System.Drawing.Point(6, 68);
            this.cmbTipoAcceso.Name = "cmbTipoAcceso";
            this.cmbTipoAcceso.Size = new System.Drawing.Size(251, 21);
            this.cmbTipoAcceso.TabIndex = 10;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 8);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 13);
            this.label30.TabIndex = 38;
            this.label30.Text = "Acceso Tipo:";
            // 
            // cmbSector
            // 
            this.cmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(281, 68);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(280, 21);
            this.cmbSector.TabIndex = 12;
            // 
            // cmbOrganismoDestino
            // 
            this.cmbOrganismoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganismoDestino.FormattingEnabled = true;
            this.cmbOrganismoDestino.Location = new System.Drawing.Point(281, 24);
            this.cmbOrganismoDestino.Name = "cmbOrganismoDestino";
            this.cmbOrganismoDestino.Size = new System.Drawing.Size(281, 21);
            this.cmbOrganismoDestino.TabIndex = 11;
            this.cmbOrganismoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbOrganismoDestino_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label29.Location = new System.Drawing.Point(186, 379);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "Nacionalidad:";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(189, 395);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(226, 20);
            this.txtNacionalidad.TabIndex = 30;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(278, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = " Organismo:";
            // 
            // cmbTipoAtencion
            // 
            this.cmbTipoAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAtencion.FormattingEnabled = true;
            this.cmbTipoAtencion.Location = new System.Drawing.Point(6, 24);
            this.cmbTipoAtencion.Name = "cmbTipoAtencion";
            this.cmbTipoAtencion.Size = new System.Drawing.Size(251, 21);
            this.cmbTipoAtencion.TabIndex = 9;
            // 
            // txtNombreCiudadanoIngreso
            // 
            this.txtNombreCiudadanoIngreso.AutoSize = true;
            this.txtNombreCiudadanoIngreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreCiudadanoIngreso.Location = new System.Drawing.Point(186, 340);
            this.txtNombreCiudadanoIngreso.Name = "txtNombreCiudadanoIngreso";
            this.txtNombreCiudadanoIngreso.Size = new System.Drawing.Size(101, 13);
            this.txtNombreCiudadanoIngreso.TabIndex = 27;
            this.txtNombreCiudadanoIngreso.Text = "Nombre Ciudadano:";
            // 
            // txtDniCiudadanoIngreso
            // 
            this.txtDniCiudadanoIngreso.AutoSize = true;
            this.txtDniCiudadanoIngreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDniCiudadanoIngreso.Location = new System.Drawing.Point(186, 301);
            this.txtDniCiudadanoIngreso.Name = "txtDniCiudadanoIngreso";
            this.txtDniCiudadanoIngreso.Size = new System.Drawing.Size(26, 13);
            this.txtDniCiudadanoIngreso.TabIndex = 26;
            this.txtDniCiudadanoIngreso.Text = "DNI";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label27.Location = new System.Drawing.Point(186, 262);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 13);
            this.label27.TabIndex = 25;
            this.label27.Text = "Id Ciudadano:";
            // 
            // txtNombreCiudadano
            // 
            this.txtNombreCiudadano.Enabled = false;
            this.txtNombreCiudadano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCiudadano.Location = new System.Drawing.Point(189, 355);
            this.txtNombreCiudadano.Name = "txtNombreCiudadano";
            this.txtNombreCiudadano.Size = new System.Drawing.Size(226, 20);
            this.txtNombreCiudadano.TabIndex = 24;
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.Enabled = false;
            this.txtDocumentoIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(189, 315);
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(226, 20);
            this.txtDocumentoIdentidad.TabIndex = 23;
            // 
            // txtIdCiudadanoIngreso
            // 
            this.txtIdCiudadanoIngreso.Enabled = false;
            this.txtIdCiudadanoIngreso.Location = new System.Drawing.Point(189, 276);
            this.txtIdCiudadanoIngreso.Name = "txtIdCiudadanoIngreso";
            this.txtIdCiudadanoIngreso.Size = new System.Drawing.Size(226, 20);
            this.txtIdCiudadanoIngreso.TabIndex = 22;
            // 
            // dgvCiudadanosRegistroDiario
            // 
            this.dgvCiudadanosRegistroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudadanosRegistroDiario.Location = new System.Drawing.Point(17, 64);
            this.dgvCiudadanosRegistroDiario.Name = "dgvCiudadanosRegistroDiario";
            this.dgvCiudadanosRegistroDiario.Size = new System.Drawing.Size(751, 192);
            this.dgvCiudadanosRegistroDiario.TabIndex = 5;
            this.dgvCiudadanosRegistroDiario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCiudadanosRegistroDiario_KeyDown);
            // 
            // cmbMotivoAtencion
            // 
            this.cmbMotivoAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoAtencion.FormattingEnabled = true;
            this.cmbMotivoAtencion.Location = new System.Drawing.Point(582, 24);
            this.cmbMotivoAtencion.Name = "cmbMotivoAtencion";
            this.cmbMotivoAtencion.Size = new System.Drawing.Size(307, 21);
            this.cmbMotivoAtencion.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Motivo Atención:";
            // 
            // btnBuscarInternos
            // 
            this.btnBuscarInternos.BackColor = System.Drawing.Color.White;
            this.btnBuscarInternos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInternos.Image")));
            this.btnBuscarInternos.Location = new System.Drawing.Point(565, 14);
            this.btnBuscarInternos.Name = "btnBuscarInternos";
            this.btnBuscarInternos.Size = new System.Drawing.Size(39, 33);
            this.btnBuscarInternos.TabIndex = 8;
            this.btnBuscarInternos.UseVisualStyleBackColor = false;
            this.btnBuscarInternos.Click += new System.EventHandler(this.btnBuscarInternos_Click);
            // 
            // btnCrearRegistroDiario
            // 
            this.btnCrearRegistroDiario.BackColor = System.Drawing.Color.White;
            this.btnCrearRegistroDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRegistroDiario.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearRegistroDiario.Image")));
            this.btnCrearRegistroDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearRegistroDiario.Location = new System.Drawing.Point(1031, 22);
            this.btnCrearRegistroDiario.Name = "btnCrearRegistroDiario";
            this.btnCrearRegistroDiario.Size = new System.Drawing.Size(143, 66);
            this.btnCrearRegistroDiario.TabIndex = 51;
            this.btnCrearRegistroDiario.Text = "Registrar Ingreso";
            this.btnCrearRegistroDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearRegistroDiario.UseCompatibleTextRendering = true;
            this.btnCrearRegistroDiario.UseVisualStyleBackColor = false;
            this.btnCrearRegistroDiario.Click += new System.EventHandler(this.btnCrearRegistroDiario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(407, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptbFotoCiudadano
            // 
            this.ptbFotoCiudadano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbFotoCiudadano.Image = ((System.Drawing.Image)(resources.GetObject("ptbFotoCiudadano.Image")));
            this.ptbFotoCiudadano.Location = new System.Drawing.Point(17, 262);
            this.ptbFotoCiudadano.Name = "ptbFotoCiudadano";
            this.ptbFotoCiudadano.Size = new System.Drawing.Size(162, 160);
            this.ptbFotoCiudadano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoCiudadano.TabIndex = 32;
            this.ptbFotoCiudadano.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBuscarInternos);
            this.panel1.Controls.Add(this.txtBuscarInternos);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 57);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Seleccionar Interno:";
            // 
            // txtBuscarInternos
            // 
            this.txtBuscarInternos.Location = new System.Drawing.Point(14, 26);
            this.txtBuscarInternos.Name = "txtBuscarInternos";
            this.txtBuscarInternos.Size = new System.Drawing.Size(543, 20);
            this.txtBuscarInternos.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(582, 68);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(439, 20);
            this.txtObservaciones.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCategorias);
            this.panel2.Controls.Add(this.btnProhibiciones);
            this.panel2.Controls.Add(this.btnIngresos);
            this.panel2.Controls.Add(this.dtgResultados);
            this.panel2.Controls.Add(this.btnBuscarDni);
            this.panel2.Controls.Add(this.dgvCiudadanosRegistroDiario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBuscarApellido);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBuscarDocumento);
            this.panel2.Controls.Add(this.ptbFotoCiudadano);
            this.panel2.Controls.Add(this.txtDocumentoIdentidad);
            this.panel2.Controls.Add(this.txtIdCiudadanoIngreso);
            this.panel2.Controls.Add(this.txtNombreCiudadano);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.txtDniCiudadanoIngreso);
            this.panel2.Controls.Add(this.txtNacionalidad);
            this.panel2.Controls.Add(this.txtNombreCiudadanoIngreso);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 445);
            this.panel2.TabIndex = 60;
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.White;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDni.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDni.Image")));
            this.btnBuscarDni.Location = new System.Drawing.Point(729, 24);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(39, 32);
            this.btnBuscarDni.TabIndex = 4;
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Sector:";
            // 
            // dtgResultados
            // 
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Location = new System.Drawing.Point(539, 276);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.Size = new System.Drawing.Size(640, 158);
            this.dtgResultados.TabIndex = 53;
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.White;
            this.btnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(439, 277);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(93, 43);
            this.btnIngresos.TabIndex = 62;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseCompatibleTextRendering = true;
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnProhibiciones
            // 
            this.btnProhibiciones.BackColor = System.Drawing.Color.White;
            this.btnProhibiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProhibiciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProhibiciones.Location = new System.Drawing.Point(440, 326);
            this.btnProhibiciones.Name = "btnProhibiciones";
            this.btnProhibiciones.Size = new System.Drawing.Size(93, 43);
            this.btnProhibiciones.TabIndex = 63;
            this.btnProhibiciones.Text = "Prohibiciones";
            this.btnProhibiciones.UseCompatibleTextRendering = true;
            this.btnProhibiciones.UseVisualStyleBackColor = false;
            this.btnProhibiciones.Click += new System.EventHandler(this.btnProhibiciones_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.White;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(439, 375);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(93, 43);
            this.btnCategorias.TabIndex = 64;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseCompatibleTextRendering = true;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Seleccionar ciudadano:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnCrearRegistroDiario);
            this.panel3.Controls.Add(this.cmbTipoAtencion);
            this.panel3.Controls.Add(this.txtObservaciones);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbOrganismoDestino);
            this.panel3.Controls.Add(this.cmbSector);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbTipoAcceso);
            this.panel3.Controls.Add(this.cmbMotivoAtencion);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Location = new System.Drawing.Point(13, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 113);
            this.panel3.TabIndex = 62;
            // 
            // frmRegistroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.ClientSize = new System.Drawing.Size(1221, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDiario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Registro Diario";
            this.Load += new System.EventHandler(this.frmRegistroDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanosRegistroDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoCiudadano)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarDocumento;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbTipoAcceso;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.ComboBox cmbOrganismoDestino;
        private System.Windows.Forms.PictureBox ptbFotoCiudadano;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbTipoAtencion;
        private System.Windows.Forms.Label txtNombreCiudadanoIngreso;
        private System.Windows.Forms.Label txtDniCiudadanoIngreso;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNombreCiudadano;
        private System.Windows.Forms.TextBox txtDocumentoIdentidad;
        private System.Windows.Forms.TextBox txtIdCiudadanoIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCiudadanosRegistroDiario;
        private System.Windows.Forms.Button btnBuscarInternos;
        private System.Windows.Forms.Button btnCrearRegistroDiario;
        private System.Windows.Forms.ComboBox cmbMotivoAtencion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBuscarInternos;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProhibiciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}