namespace CapaPresentacion
{
    partial class FormSabanaInternos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvProhibiciones = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.txtFechaAlojamiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInterno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txtJurisdiccionVer = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.txtEstadoProcesalVer = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txtOrganismoAlojamientoVer = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgvParentescos = new System.Windows.Forms.DataGridView();
            this.btnImprimirVinculos = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.txtDetalleProhibicionParentesco = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtVisita = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtIdVisita = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabSabana = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnImprimirSabana = new System.Windows.Forms.Button();
            this.dtgIngresos = new System.Windows.Forms.DataGridView();
            this.btnVerSabana = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProhibiciones)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 680);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.groupBox3);
            this.tabPrincipal.Controls.Add(this.groupBox6);
            this.tabPrincipal.Controls.Add(this.groupBox7);
            this.tabPrincipal.Controls.Add(this.groupBox5);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(1064, 654);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Inicio";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvProhibiciones);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(410, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 220);
            this.groupBox3.TabIndex = 256;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prohibiciones";
            // 
            // dtgvProhibiciones
            // 
            this.dtgvProhibiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProhibiciones.Location = new System.Drawing.Point(6, 20);
            this.dtgvProhibiciones.Name = "dtgvProhibiciones";
            this.dtgvProhibiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProhibiciones.Size = new System.Drawing.Size(622, 188);
            this.dtgvProhibiciones.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Indigo;
            this.groupBox6.Controls.Add(this.pictureFoto);
            this.groupBox6.Controls.Add(this.txtFechaAlojamiento);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtCausa);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txtInterno);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtProntuario);
            this.groupBox6.Controls.Add(this.label71);
            this.groupBox6.Controls.Add(this.label70);
            this.groupBox6.Controls.Add(this.txtJurisdiccionVer);
            this.groupBox6.Controls.Add(this.label69);
            this.groupBox6.Controls.Add(this.txtEstadoProcesalVer);
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.Controls.Add(this.txtOrganismoAlojamientoVer);
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
            // txtFechaAlojamiento
            // 
            this.txtFechaAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAlojamiento.Location = new System.Drawing.Point(561, 81);
            this.txtFechaAlojamiento.Name = "txtFechaAlojamiento";
            this.txtFechaAlojamiento.ReadOnly = true;
            this.txtFechaAlojamiento.Size = new System.Drawing.Size(135, 21);
            this.txtFechaAlojamiento.TabIndex = 258;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 257;
            this.label1.Text = "CAUSA";
            // 
            // txtCausa
            // 
            this.txtCausa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausa.Location = new System.Drawing.Point(10, 131);
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.ReadOnly = true;
            this.txtCausa.Size = new System.Drawing.Size(685, 21);
            this.txtCausa.TabIndex = 256;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(122, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 255;
            this.label12.Text = "INTERNO";
            // 
            // txtInterno
            // 
            this.txtInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterno.Location = new System.Drawing.Point(125, 35);
            this.txtInterno.Name = "txtInterno";
            this.txtInterno.ReadOnly = true;
            this.txtInterno.Size = new System.Drawing.Size(571, 21);
            this.txtInterno.TabIndex = 254;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 253;
            this.label11.Text = "PRONTUARIO";
            // 
            // txtProntuario
            // 
            this.txtProntuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuario.Location = new System.Drawing.Point(10, 35);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.ReadOnly = true;
            this.txtProntuario.Size = new System.Drawing.Size(103, 21);
            this.txtProntuario.TabIndex = 252;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(558, 65);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(137, 13);
            this.label71.TabIndex = 226;
            this.label71.Text = "FECHA ALOJAMIENTO";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(290, 65);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(172, 13);
            this.label70.TabIndex = 223;
            this.label70.Text = "ORGANISMO ALOJAMIENTO";
            // 
            // txtJurisdiccionVer
            // 
            this.txtJurisdiccionVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJurisdiccionVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurisdiccionVer.Location = new System.Drawing.Point(149, 82);
            this.txtJurisdiccionVer.Name = "txtJurisdiccionVer";
            this.txtJurisdiccionVer.ReadOnly = true;
            this.txtJurisdiccionVer.Size = new System.Drawing.Size(135, 21);
            this.txtJurisdiccionVer.TabIndex = 251;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(6, 65);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(126, 13);
            this.label69.TabIndex = 227;
            this.label69.Text = "ESTADO PROCESAL";
            // 
            // txtEstadoProcesalVer
            // 
            this.txtEstadoProcesalVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoProcesalVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoProcesalVer.Location = new System.Drawing.Point(10, 82);
            this.txtEstadoProcesalVer.Name = "txtEstadoProcesalVer";
            this.txtEstadoProcesalVer.ReadOnly = true;
            this.txtEstadoProcesalVer.Size = new System.Drawing.Size(135, 21);
            this.txtEstadoProcesalVer.TabIndex = 250;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(146, 65);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(94, 13);
            this.label67.TabIndex = 229;
            this.label67.Text = "JURISDICCION";
            // 
            // txtOrganismoAlojamientoVer
            // 
            this.txtOrganismoAlojamientoVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrganismoAlojamientoVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganismoAlojamientoVer.Location = new System.Drawing.Point(291, 82);
            this.txtOrganismoAlojamientoVer.Name = "txtOrganismoAlojamientoVer";
            this.txtOrganismoAlojamientoVer.ReadOnly = true;
            this.txtOrganismoAlojamientoVer.Size = new System.Drawing.Size(264, 21);
            this.txtOrganismoAlojamientoVer.TabIndex = 249;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgvParentescos);
            this.groupBox7.Controls.Add(this.btnImprimirVinculos);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(9, 186);
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
            this.groupBox5.Controls.Add(this.txtVisita);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtIdVisita);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(13, 426);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 220);
            this.groupBox5.TabIndex = 96;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parentesco actual";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(7, 109);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(144, 15);
            this.label42.TabIndex = 82;
            this.label42.Text = "DETALLE PROHIBICION:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentesco.Location = new System.Drawing.Point(10, 85);
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
            this.txtDetalleProhibicionParentesco.Location = new System.Drawing.Point(10, 128);
            this.txtDetalleProhibicionParentesco.Multiline = true;
            this.txtDetalleProhibicionParentesco.Name = "txtDetalleProhibicionParentesco";
            this.txtDetalleProhibicionParentesco.ReadOnly = true;
            this.txtDetalleProhibicionParentesco.Size = new System.Drawing.Size(372, 80);
            this.txtDetalleProhibicionParentesco.TabIndex = 81;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(6, 19);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 15);
            this.label39.TabIndex = 78;
            this.label39.Text = "ID VISITA:";
            // 
            // txtVisita
            // 
            this.txtVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisita.Location = new System.Drawing.Point(72, 39);
            this.txtVisita.Name = "txtVisita";
            this.txtVisita.ReadOnly = true;
            this.txtVisita.Size = new System.Drawing.Size(310, 21);
            this.txtVisita.TabIndex = 64;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(69, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 15);
            this.label26.TabIndex = 66;
            this.label26.Text = "VISITA";
            // 
            // txtIdVisita
            // 
            this.txtIdVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVisita.Location = new System.Drawing.Point(9, 39);
            this.txtIdVisita.Name = "txtIdVisita";
            this.txtIdVisita.ReadOnly = true;
            this.txtIdVisita.Size = new System.Drawing.Size(57, 21);
            this.txtIdVisita.TabIndex = 77;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 66);
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
            this.tabSabana.Size = new System.Drawing.Size(1064, 654);
            this.tabSabana.TabIndex = 1;
            this.tabSabana.Text = "Sabana";
            this.tabSabana.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnVerSabana);
            this.groupBox14.Controls.Add(this.dtpFechaInicio);
            this.groupBox14.Controls.Add(this.dtpFechaFin);
            this.groupBox14.Controls.Add(this.label4);
            this.groupBox14.Controls.Add(this.label5);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgIngresos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgIngresos.EnableHeadersVisualStyles = false;
            this.dtgIngresos.GridColor = System.Drawing.Color.DimGray;
            this.dtgIngresos.Location = new System.Drawing.Point(7, 71);
            this.dtgIngresos.MultiSelect = false;
            this.dtgIngresos.Name = "dtgIngresos";
            this.dtgIngresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dtgIngresos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIngresos.Size = new System.Drawing.Size(1035, 512);
            this.dtgIngresos.TabIndex = 2;
            // 
            // btnVerSabana
            // 
            this.btnVerSabana.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerSabana.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerSabana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSabana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSabana.ForeColor = System.Drawing.Color.White;
            this.btnVerSabana.Location = new System.Drawing.Point(302, 17);
            this.btnVerSabana.Name = "btnVerSabana";
            this.btnVerSabana.Size = new System.Drawing.Size(160, 45);
            this.btnVerSabana.TabIndex = 270;
            this.btnVerSabana.Text = "VER SABANAS";
            this.btnVerSabana.UseVisualStyleBackColor = false;
            this.btnVerSabana.Click += new System.EventHandler(this.btnVerSabana_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(8, 40);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(115, 22);
            this.dtpFechaInicio.TabIndex = 269;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(158, 40);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(115, 22);
            this.dtpFechaFin.TabIndex = 268;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(155, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 267;
            this.label4.Text = "FECHA FIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 266;
            this.label5.Text = "FECHA INICIO";
            // 
            // FormSabanaInternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 691);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSabanaInternos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SABANA INTERNOS";
            this.Load += new System.EventHandler(this.FormSabanaInternos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProhibiciones)).EndInit();
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
        private System.Windows.Forms.TabPage tabSabana;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.DataGridView dtgIngresos;
        private System.Windows.Forms.Button btnImprimirVinculos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtgvParentescos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.TextBox txtDetalleProhibicionParentesco;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtVisita;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtIdVisita;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtJurisdiccionVer;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txtEstadoProcesalVer;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txtOrganismoAlojamientoVer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInterno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.TextBox txtFechaAlojamiento;
        private System.Windows.Forms.Button btnImprimirSabana;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvProhibiciones;
        private System.Windows.Forms.Button btnVerSabana;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}