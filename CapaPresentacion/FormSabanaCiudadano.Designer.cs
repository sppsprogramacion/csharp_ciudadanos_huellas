namespace CapaPresentacion
{
    partial class FormSabanaCiudadano
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVisita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgvParentescos = new System.Windows.Forms.DataGridView();
            this.btnImprimirVinculos = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.txtDetalleProhibicionParentesco = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtInternoVinculado = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtIdInterno = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabSabana = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnVerSabana = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimirSabana = new System.Windows.Forms.Button();
            this.dtgIngresos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvParentescos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabSabana.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrincipal);
            this.tabControl1.Controls.Add(this.tabSabana);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 637);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.groupBox6);
            this.tabPrincipal.Controls.Add(this.groupBox7);
            this.tabPrincipal.Controls.Add(this.groupBox5);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(1064, 611);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Inicio";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Indigo;
            this.groupBox6.Controls.Add(this.pictureFoto);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txtVisita);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtDni);
            this.groupBox6.Controls.Add(this.label70);
            this.groupBox6.Controls.Add(this.txtEdad);
            this.groupBox6.Controls.Add(this.label69);
            this.groupBox6.Controls.Add(this.txtSexo);
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.Controls.Add(this.txtDomicilio);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(13, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(970, 161);
            this.groupBox6.TabIndex = 255;
            this.groupBox6.TabStop = false;
            // 
            // pictureFoto
            // 
            this.pictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureFoto.Image = global::CapaPresentacion.Properties.Resources.persona_icono;
            this.pictureFoto.Location = new System.Drawing.Point(822, 19);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(122, 133);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFoto.TabIndex = 259;
            this.pictureFoto.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(115, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 255;
            this.label12.Text = "VISITA";
            // 
            // txtVisita
            // 
            this.txtVisita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisita.Location = new System.Drawing.Point(118, 35);
            this.txtVisita.Name = "txtVisita";
            this.txtVisita.ReadOnly = true;
            this.txtVisita.Size = new System.Drawing.Size(684, 21);
            this.txtVisita.TabIndex = 254;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 253;
            this.label11.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(10, 35);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(103, 21);
            this.txtDni.TabIndex = 252;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(181, 65);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(71, 13);
            this.label70.TabIndex = 223;
            this.label70.Text = "DOMICILIO";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(118, 82);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(59, 21);
            this.txtEdad.TabIndex = 251;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(6, 65);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(40, 13);
            this.label69.TabIndex = 227;
            this.label69.Text = "SEXO";
            // 
            // txtSexo
            // 
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(10, 82);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(103, 21);
            this.txtSexo.TabIndex = 250;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(115, 65);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(41, 13);
            this.label67.TabIndex = 229;
            this.label67.Text = "EDAD";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(182, 82);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(620, 21);
            this.txtDomicilio.TabIndex = 249;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgvParentescos);
            this.groupBox7.Controls.Add(this.btnImprimirVinculos);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(9, 191);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(974, 229);
            this.groupBox7.TabIndex = 97;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Vinculos";
            // 
            // dtgvParentescos
            // 
            this.dtgvParentescos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvParentescos.Location = new System.Drawing.Point(6, 65);
            this.dtgvParentescos.Name = "dtgvParentescos";
            this.dtgvParentescos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvParentescos.Size = new System.Drawing.Size(959, 151);
            this.dtgvParentescos.TabIndex = 63;
            this.dtgvParentescos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvParentescos_KeyDown);
            // 
            // btnImprimirVinculos
            // 
            this.btnImprimirVinculos.BackColor = System.Drawing.Color.White;
            this.btnImprimirVinculos.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnImprimirVinculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirVinculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirVinculos.ForeColor = System.Drawing.Color.Indigo;
            this.btnImprimirVinculos.Location = new System.Drawing.Point(771, 19);
            this.btnImprimirVinculos.Name = "btnImprimirVinculos";
            this.btnImprimirVinculos.Size = new System.Drawing.Size(194, 40);
            this.btnImprimirVinculos.TabIndex = 98;
            this.btnImprimirVinculos.Text = "Imprimir vinculos";
            this.btnImprimirVinculos.UseVisualStyleBackColor = false;
            this.btnImprimirVinculos.Click += new System.EventHandler(this.btnImprimirVinculos_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.txtParentesco);
            this.groupBox5.Controls.Add(this.txtDetalleProhibicionParentesco);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.txtInternoVinculado);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtIdInterno);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(13, 426);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(740, 181);
            this.groupBox5.TabIndex = 96;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parentesco actual";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(6, 72);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(144, 15);
            this.label42.TabIndex = 82;
            this.label42.Text = "DETALLE PROHIBICION:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentesco.Location = new System.Drawing.Point(485, 38);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.ReadOnly = true;
            this.txtParentesco.Size = new System.Drawing.Size(227, 21);
            this.txtParentesco.TabIndex = 80;
            // 
            // txtDetalleProhibicionParentesco
            // 
            this.txtDetalleProhibicionParentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalleProhibicionParentesco.Enabled = false;
            this.txtDetalleProhibicionParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleProhibicionParentesco.Location = new System.Drawing.Point(9, 91);
            this.txtDetalleProhibicionParentesco.Multiline = true;
            this.txtDetalleProhibicionParentesco.Name = "txtDetalleProhibicionParentesco";
            this.txtDetalleProhibicionParentesco.ReadOnly = true;
            this.txtDetalleProhibicionParentesco.Size = new System.Drawing.Size(312, 65);
            this.txtDetalleProhibicionParentesco.TabIndex = 81;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(6, 19);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(79, 15);
            this.label39.TabIndex = 78;
            this.label39.Text = "ID INTERNO:";
            // 
            // txtInternoVinculado
            // 
            this.txtInternoVinculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternoVinculado.Location = new System.Drawing.Point(103, 39);
            this.txtInternoVinculado.Name = "txtInternoVinculado";
            this.txtInternoVinculado.ReadOnly = true;
            this.txtInternoVinculado.Size = new System.Drawing.Size(372, 21);
            this.txtInternoVinculado.TabIndex = 64;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(100, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 15);
            this.label26.TabIndex = 66;
            this.label26.Text = "INTERNO:";
            // 
            // txtIdInterno
            // 
            this.txtIdInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInterno.Location = new System.Drawing.Point(9, 39);
            this.txtIdInterno.Name = "txtIdInterno";
            this.txtIdInterno.ReadOnly = true;
            this.txtIdInterno.Size = new System.Drawing.Size(80, 21);
            this.txtIdInterno.TabIndex = 77;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(481, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 15);
            this.label25.TabIndex = 72;
            this.label25.Text = "PARENTESCO:";
            // 
            // tabSabana
            // 
            this.tabSabana.Controls.Add(this.groupBox14);
            this.tabSabana.Location = new System.Drawing.Point(4, 22);
            this.tabSabana.Name = "tabSabana";
            this.tabSabana.Padding = new System.Windows.Forms.Padding(3);
            this.tabSabana.Size = new System.Drawing.Size(1064, 611);
            this.tabSabana.TabIndex = 1;
            this.tabSabana.Text = "Sabana";
            this.tabSabana.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnVerSabana);
            this.groupBox14.Controls.Add(this.dtpFechaInicio);
            this.groupBox14.Controls.Add(this.dtpFechaFin);
            this.groupBox14.Controls.Add(this.label3);
            this.groupBox14.Controls.Add(this.label2);
            this.groupBox14.Controls.Add(this.btnImprimirSabana);
            this.groupBox14.Controls.Add(this.dtgIngresos);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.ForeColor = System.Drawing.Color.Black;
            this.groupBox14.Location = new System.Drawing.Point(3, 10);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1051, 595);
            this.groupBox14.TabIndex = 116;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Entradas de visitas";
            // 
            // btnVerSabana
            // 
            this.btnVerSabana.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerSabana.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerSabana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSabana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSabana.ForeColor = System.Drawing.Color.White;
            this.btnVerSabana.Location = new System.Drawing.Point(303, 15);
            this.btnVerSabana.Name = "btnVerSabana";
            this.btnVerSabana.Size = new System.Drawing.Size(160, 45);
            this.btnVerSabana.TabIndex = 265;
            this.btnVerSabana.Text = "VER SABANAS";
            this.btnVerSabana.UseVisualStyleBackColor = false;
            this.btnVerSabana.Click += new System.EventHandler(this.btnVerSabana_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(9, 38);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(115, 22);
            this.dtpFechaInicio.TabIndex = 264;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(159, 38);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(115, 22);
            this.dtpFechaFin.TabIndex = 263;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(156, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 261;
            this.label3.Text = "FECHA FIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 259;
            this.label2.Text = "FECHA INICIO";
            // 
            // btnImprimirSabana
            // 
            this.btnImprimirSabana.BackColor = System.Drawing.Color.White;
            this.btnImprimirSabana.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnImprimirSabana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirSabana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirSabana.ForeColor = System.Drawing.Color.Indigo;
            this.btnImprimirSabana.Location = new System.Drawing.Point(848, 14);
            this.btnImprimirSabana.Name = "btnImprimirSabana";
            this.btnImprimirSabana.Size = new System.Drawing.Size(194, 40);
            this.btnImprimirSabana.TabIndex = 117;
            this.btnImprimirSabana.Text = "Imprimir sabana";
            this.btnImprimirSabana.UseVisualStyleBackColor = false;
            this.btnImprimirSabana.Click += new System.EventHandler(this.btnImprimirSabana_Click);
            // 
            // dtgIngresos
            // 
            this.dtgIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgIngresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgIngresos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgIngresos.EnableHeadersVisualStyles = false;
            this.dtgIngresos.GridColor = System.Drawing.Color.DimGray;
            this.dtgIngresos.Location = new System.Drawing.Point(7, 71);
            this.dtgIngresos.MultiSelect = false;
            this.dtgIngresos.Name = "dtgIngresos";
            this.dtgIngresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgIngresos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIngresos.Size = new System.Drawing.Size(1035, 512);
            this.dtgIngresos.TabIndex = 2;
            // 
            // FormSabanaCiudadano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 664);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSabanaCiudadano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SABANA CIUDADANO";
            this.Load += new System.EventHandler(this.FormSabanaCiudadano_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvParentescos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabSabana.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVisita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtgvParentescos;
        private System.Windows.Forms.Button btnImprimirVinculos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.TextBox txtDetalleProhibicionParentesco;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtInternoVinculado;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtIdInterno;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabSabana;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimirSabana;
        private System.Windows.Forms.DataGridView dtgIngresos;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnVerSabana;
    }
}