namespace CapaPresentacion
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.btnCloseEstadoUsua = new FontAwesome.Sharp.IconButton();
            this.btnCloseNombreUsua = new FontAwesome.Sharp.IconButton();
            this.labelEstadoCat = new System.Windows.Forms.Label();
            this.cmbEstadoUsu = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltrosUsu = new System.Windows.Forms.Button();
            this.txtNombreUsu = new System.Windows.Forms.TextBox();
            this.labelNombreCat = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtDocumentoUsu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelMostrandoUsu = new System.Windows.Forms.Label();
            this.comboPagsUsu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelCurrentPagUsu = new System.Windows.Forms.Label();
            this.btnLastPagUsu = new System.Windows.Forms.Button();
            this.btnFirstPagUsu = new System.Windows.Forms.Button();
            this.btnPrevPagUsu = new System.Windows.Forms.Button();
            this.btnNextPagUsu = new System.Windows.Forms.Button();
            this.btnCloseRolUsua = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbRolUsu = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtCorreoUsu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 503);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(30, 70);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(192, 20);
            this.txtdocumento.TabIndex = 4;
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(30, 118);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(192, 20);
            this.txtnombrecompleto.TabIndex = 5;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(30, 164);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(192, 20);
            this.txtcorreo.TabIndex = 6;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(30, 211);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(192, 20);
            this.txtclave.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rol:";
            // 
            // cborol
            // 
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(30, 261);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(192, 21);
            this.cborol.TabIndex = 12;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(30, 308);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(192, 21);
            this.cboestado.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(30, 347);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(192, 23);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.White;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(30, 376);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(192, 23);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 16;
            this.btneliminar.Location = new System.Drawing.Point(30, 405);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(192, 23);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detalle Usuario";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(288, 109);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(841, 327);
            this.dgvdata.TabIndex = 19;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 33);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(841, 57);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lista de Usuarios:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(196, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 21;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(165, 44);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 20);
            this.txtindice.TabIndex = 27;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // btnCloseEstadoUsua
            // 
            this.btnCloseEstadoUsua.BackColor = System.Drawing.Color.Red;
            this.btnCloseEstadoUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEstadoUsua.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseEstadoUsua.IconColor = System.Drawing.Color.White;
            this.btnCloseEstadoUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEstadoUsua.IconSize = 20;
            this.btnCloseEstadoUsua.Location = new System.Drawing.Point(958, 37);
            this.btnCloseEstadoUsua.Name = "btnCloseEstadoUsua";
            this.btnCloseEstadoUsua.Size = new System.Drawing.Size(22, 23);
            this.btnCloseEstadoUsua.TabIndex = 80;
            this.btnCloseEstadoUsua.UseVisualStyleBackColor = false;
            this.btnCloseEstadoUsua.Click += new System.EventHandler(this.BtnCloseEstadoUsua_Click);
            // 
            // btnCloseNombreUsua
            // 
            this.btnCloseNombreUsua.BackColor = System.Drawing.Color.Red;
            this.btnCloseNombreUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNombreUsua.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseNombreUsua.IconColor = System.Drawing.Color.White;
            this.btnCloseNombreUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNombreUsua.IconSize = 20;
            this.btnCloseNombreUsua.Location = new System.Drawing.Point(641, 38);
            this.btnCloseNombreUsua.Name = "btnCloseNombreUsua";
            this.btnCloseNombreUsua.Size = new System.Drawing.Size(22, 23);
            this.btnCloseNombreUsua.TabIndex = 79;
            this.btnCloseNombreUsua.UseVisualStyleBackColor = false;
            this.btnCloseNombreUsua.Click += new System.EventHandler(this.BtnCloseNombreUsua_Click);
            // 
            // labelEstadoCat
            // 
            this.labelEstadoCat.AutoSize = true;
            this.labelEstadoCat.BackColor = System.Drawing.Color.White;
            this.labelEstadoCat.Location = new System.Drawing.Point(911, 42);
            this.labelEstadoCat.Name = "labelEstadoCat";
            this.labelEstadoCat.Size = new System.Drawing.Size(40, 13);
            this.labelEstadoCat.TabIndex = 78;
            this.labelEstadoCat.Text = "Estado";
            // 
            // cmbEstadoUsu
            // 
            this.cmbEstadoUsu.FormattingEnabled = true;
            this.cmbEstadoUsu.Location = new System.Drawing.Point(914, 65);
            this.cmbEstadoUsu.Name = "cmbEstadoUsu";
            this.cmbEstadoUsu.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoUsu.TabIndex = 77;
            this.cmbEstadoUsu.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoUsu_SelectedIndexChanged);
            // 
            // btnLimpiarFiltrosUsu
            // 
            this.btnLimpiarFiltrosUsu.Location = new System.Drawing.Point(1027, 52);
            this.btnLimpiarFiltrosUsu.Name = "btnLimpiarFiltrosUsu";
            this.btnLimpiarFiltrosUsu.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarFiltrosUsu.TabIndex = 76;
            this.btnLimpiarFiltrosUsu.Text = "Limpiar filtros";
            this.btnLimpiarFiltrosUsu.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltrosUsu.Click += new System.EventHandler(this.BtnLimpiarFiltrosUsu_Click);
            // 
            // txtNombreUsu
            // 
            this.txtNombreUsu.Location = new System.Drawing.Point(596, 66);
            this.txtNombreUsu.Name = "txtNombreUsu";
            this.txtNombreUsu.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsu.TabIndex = 75;
            this.txtNombreUsu.TextChanged += new System.EventHandler(this.TxtNombreUsu_TextChanged);
            // 
            // labelNombreCat
            // 
            this.labelNombreCat.AutoSize = true;
            this.labelNombreCat.BackColor = System.Drawing.Color.White;
            this.labelNombreCat.Location = new System.Drawing.Point(593, 42);
            this.labelNombreCat.Name = "labelNombreCat";
            this.labelNombreCat.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCat.TabIndex = 74;
            this.labelNombreCat.Text = "Nombre";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(551, 38);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(22, 23);
            this.iconButton1.TabIndex = 84;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.BtnCloseDocumentoUsua_Click);
            // 
            // txtDocumentoUsu
            // 
            this.txtDocumentoUsu.Location = new System.Drawing.Point(490, 66);
            this.txtDocumentoUsu.Name = "txtDocumentoUsu";
            this.txtDocumentoUsu.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentoUsu.TabIndex = 83;
            this.txtDocumentoUsu.TextChanged += new System.EventHandler(this.TxtDocumentoUsu_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(487, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Documento";
            // 
            // labelMostrandoUsu
            // 
            this.labelMostrandoUsu.AutoSize = true;
            this.labelMostrandoUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelMostrandoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrandoUsu.ForeColor = System.Drawing.Color.White;
            this.labelMostrandoUsu.Location = new System.Drawing.Point(486, 458);
            this.labelMostrandoUsu.Name = "labelMostrandoUsu";
            this.labelMostrandoUsu.Size = new System.Drawing.Size(221, 20);
            this.labelMostrandoUsu.TabIndex = 92;
            this.labelMostrandoUsu.Text = "Mostrando X páginas de Y";
            // 
            // comboPagsUsu
            // 
            this.comboPagsUsu.FormattingEnabled = true;
            this.comboPagsUsu.Location = new System.Drawing.Point(403, 457);
            this.comboPagsUsu.Name = "comboPagsUsu";
            this.comboPagsUsu.Size = new System.Drawing.Size(52, 21);
            this.comboPagsUsu.TabIndex = 91;
            this.comboPagsUsu.SelectedIndexChanged += new System.EventHandler(this.ComboPagsUsu_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(313, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 24);
            this.label14.TabIndex = 90;
            this.label14.Text = "Páginas";
            // 
            // labelCurrentPagUsu
            // 
            this.labelCurrentPagUsu.AutoSize = true;
            this.labelCurrentPagUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPagUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPagUsu.ForeColor = System.Drawing.Color.White;
            this.labelCurrentPagUsu.Location = new System.Drawing.Point(945, 451);
            this.labelCurrentPagUsu.Name = "labelCurrentPagUsu";
            this.labelCurrentPagUsu.Size = new System.Drawing.Size(27, 29);
            this.labelCurrentPagUsu.TabIndex = 89;
            this.labelCurrentPagUsu.Text = "1";
            // 
            // btnLastPagUsu
            // 
            this.btnLastPagUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnLastPagUsu.FlatAppearance.BorderSize = 0;
            this.btnLastPagUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPagUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPagUsu.ForeColor = System.Drawing.Color.White;
            this.btnLastPagUsu.Location = new System.Drawing.Point(1034, 453);
            this.btnLastPagUsu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastPagUsu.Name = "btnLastPagUsu";
            this.btnLastPagUsu.Size = new System.Drawing.Size(40, 25);
            this.btnLastPagUsu.TabIndex = 88;
            this.btnLastPagUsu.Text = ">>";
            this.btnLastPagUsu.UseVisualStyleBackColor = false;
            this.btnLastPagUsu.Click += new System.EventHandler(this.BtnLastPagCat_Click);
            // 
            // btnFirstPagUsu
            // 
            this.btnFirstPagUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnFirstPagUsu.FlatAppearance.BorderSize = 0;
            this.btnFirstPagUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPagUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPagUsu.ForeColor = System.Drawing.Color.White;
            this.btnFirstPagUsu.Location = new System.Drawing.Point(839, 453);
            this.btnFirstPagUsu.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirstPagUsu.Name = "btnFirstPagUsu";
            this.btnFirstPagUsu.Size = new System.Drawing.Size(40, 25);
            this.btnFirstPagUsu.TabIndex = 87;
            this.btnFirstPagUsu.Text = "<<";
            this.btnFirstPagUsu.UseVisualStyleBackColor = false;
            this.btnFirstPagUsu.Click += new System.EventHandler(this.BtnFirstPagCat_Click);
            // 
            // btnPrevPagUsu
            // 
            this.btnPrevPagUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnPrevPagUsu.FlatAppearance.BorderSize = 0;
            this.btnPrevPagUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPagUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPagUsu.ForeColor = System.Drawing.Color.White;
            this.btnPrevPagUsu.Location = new System.Drawing.Point(892, 453);
            this.btnPrevPagUsu.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevPagUsu.Name = "btnPrevPagUsu";
            this.btnPrevPagUsu.Size = new System.Drawing.Size(40, 25);
            this.btnPrevPagUsu.TabIndex = 86;
            this.btnPrevPagUsu.Text = "<";
            this.btnPrevPagUsu.UseVisualStyleBackColor = false;
            this.btnPrevPagUsu.Click += new System.EventHandler(this.BtnPrevPagCat_Click);
            // 
            // btnNextPagUsu
            // 
            this.btnNextPagUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnNextPagUsu.FlatAppearance.BorderSize = 0;
            this.btnNextPagUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPagUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPagUsu.ForeColor = System.Drawing.Color.White;
            this.btnNextPagUsu.Location = new System.Drawing.Point(980, 453);
            this.btnNextPagUsu.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPagUsu.Name = "btnNextPagUsu";
            this.btnNextPagUsu.Size = new System.Drawing.Size(40, 25);
            this.btnNextPagUsu.TabIndex = 85;
            this.btnNextPagUsu.Text = ">";
            this.btnNextPagUsu.UseVisualStyleBackColor = false;
            this.btnNextPagUsu.Click += new System.EventHandler(this.BtnNextPagCat_Click);
            // 
            // btnCloseRolUsua
            // 
            this.btnCloseRolUsua.BackColor = System.Drawing.Color.Red;
            this.btnCloseRolUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRolUsua.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseRolUsua.IconColor = System.Drawing.Color.White;
            this.btnCloseRolUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseRolUsua.IconSize = 20;
            this.btnCloseRolUsua.Location = new System.Drawing.Point(852, 37);
            this.btnCloseRolUsua.Name = "btnCloseRolUsua";
            this.btnCloseRolUsua.Size = new System.Drawing.Size(22, 23);
            this.btnCloseRolUsua.TabIndex = 95;
            this.btnCloseRolUsua.UseVisualStyleBackColor = false;
            this.btnCloseRolUsua.Click += new System.EventHandler(this.BtnCloseCorreoUsua_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(805, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 94;
            this.label15.Text = "Rol";
            // 
            // cmbRolUsu
            // 
            this.cmbRolUsu.FormattingEnabled = true;
            this.cmbRolUsu.Location = new System.Drawing.Point(808, 65);
            this.cmbRolUsu.Name = "cmbRolUsu";
            this.cmbRolUsu.Size = new System.Drawing.Size(100, 21);
            this.cmbRolUsu.TabIndex = 93;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Red;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(747, 38);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(22, 23);
            this.iconButton2.TabIndex = 98;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.BtnCloseCorreoUsua_Click);
            // 
            // txtCorreoUsu
            // 
            this.txtCorreoUsu.Location = new System.Drawing.Point(702, 66);
            this.txtCorreoUsu.Name = "txtCorreoUsu";
            this.txtCorreoUsu.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoUsu.TabIndex = 97;
            this.txtCorreoUsu.TextChanged += new System.EventHandler(this.TxtCorreoUsu_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(699, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 96;
            this.label16.Text = "Correo";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.portada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 503);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtCorreoUsu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCloseRolUsua);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbRolUsu);
            this.Controls.Add(this.labelMostrandoUsu);
            this.Controls.Add(this.comboPagsUsu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelCurrentPagUsu);
            this.Controls.Add(this.btnLastPagUsu);
            this.Controls.Add(this.btnFirstPagUsu);
            this.Controls.Add(this.btnPrevPagUsu);
            this.Controls.Add(this.btnNextPagUsu);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtDocumentoUsu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCloseEstadoUsua);
            this.Controls.Add(this.btnCloseNombreUsua);
            this.Controls.Add(this.labelEstadoCat);
            this.Controls.Add(this.cmbEstadoUsu);
            this.Controls.Add(this.btnLimpiarFiltrosUsu);
            this.Controls.Add(this.txtNombreUsu);
            this.Controls.Add(this.labelNombreCat);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cborol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnCloseEstadoUsua;
        private FontAwesome.Sharp.IconButton btnCloseNombreUsua;
        private System.Windows.Forms.Label labelEstadoCat;
        private System.Windows.Forms.ComboBox cmbEstadoUsu;
        private System.Windows.Forms.Button btnLimpiarFiltrosUsu;
        private System.Windows.Forms.TextBox txtNombreUsu;
        private System.Windows.Forms.Label labelNombreCat;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtDocumentoUsu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelMostrandoUsu;
        private System.Windows.Forms.ComboBox comboPagsUsu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelCurrentPagUsu;
        private System.Windows.Forms.Button btnLastPagUsu;
        private System.Windows.Forms.Button btnFirstPagUsu;
        private System.Windows.Forms.Button btnPrevPagUsu;
        private System.Windows.Forms.Button btnNextPagUsu;
        private FontAwesome.Sharp.IconButton btnCloseRolUsua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbRolUsu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtCorreoUsu;
        private System.Windows.Forms.Label label16;
    }
}