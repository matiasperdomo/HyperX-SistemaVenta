namespace CapaPresentacion
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextPagCat = new System.Windows.Forms.Button();
            this.btnPrevPagCat = new System.Windows.Forms.Button();
            this.btnFirstPagCat = new System.Windows.Forms.Button();
            this.btnLastPagCat = new System.Windows.Forms.Button();
            this.labelCurrentPagCat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPagsCat = new System.Windows.Forms.ComboBox();
            this.labelMostrandoCat = new System.Windows.Forms.Label();
            this.labelEstadoCat = new System.Windows.Forms.Label();
            this.cmbEstadoCat = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltrosCat = new System.Windows.Forms.Button();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.labelNombreCat = new System.Windows.Forms.Label();
            this.btnCloseNombreCats = new FontAwesome.Sharp.IconButton();
            this.btnCloseEstadoCats = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Descripcion,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(276, 109);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(841, 276);
            this.dgvdata.TabIndex = 47;
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
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
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
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(184, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 49;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 33);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(841, 57);
            this.label10.TabIndex = 48;
            this.label10.Text = "Lista de Categorias:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(153, 44);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 20);
            this.txtindice.TabIndex = 55;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Detalle Categoria";
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
            this.btneliminar.Location = new System.Drawing.Point(32, 211);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(192, 23);
            this.btneliminar.TabIndex = 45;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.btnlimpiar.Location = new System.Drawing.Point(32, 182);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(192, 23);
            this.btnlimpiar.TabIndex = 44;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
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
            this.btnguardar.Location = new System.Drawing.Point(32, 153);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(192, 23);
            this.btnguardar.TabIndex = 43;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(32, 114);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(192, 21);
            this.cboestado.TabIndex = 41;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(32, 70);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtdescripcion.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 552);
            this.label1.TabIndex = 28;
            // 
            // btnNextPagCat
            // 
            this.btnNextPagCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnNextPagCat.FlatAppearance.BorderSize = 0;
            this.btnNextPagCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPagCat.ForeColor = System.Drawing.Color.White;
            this.btnNextPagCat.Location = new System.Drawing.Point(980, 429);
            this.btnNextPagCat.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPagCat.Name = "btnNextPagCat";
            this.btnNextPagCat.Size = new System.Drawing.Size(40, 25);
            this.btnNextPagCat.TabIndex = 56;
            this.btnNextPagCat.Text = ">";
            this.btnNextPagCat.UseVisualStyleBackColor = false;
            this.btnNextPagCat.Click += new System.EventHandler(this.BtnNextPagCat_Click);
            // 
            // btnPrevPagCat
            // 
            this.btnPrevPagCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnPrevPagCat.FlatAppearance.BorderSize = 0;
            this.btnPrevPagCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPagCat.ForeColor = System.Drawing.Color.White;
            this.btnPrevPagCat.Location = new System.Drawing.Point(892, 429);
            this.btnPrevPagCat.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevPagCat.Name = "btnPrevPagCat";
            this.btnPrevPagCat.Size = new System.Drawing.Size(40, 25);
            this.btnPrevPagCat.TabIndex = 57;
            this.btnPrevPagCat.Text = "<";
            this.btnPrevPagCat.UseVisualStyleBackColor = false;
            this.btnPrevPagCat.Click += new System.EventHandler(this.BtnPrevPagCat_Click);
            // 
            // btnFirstPagCat
            // 
            this.btnFirstPagCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnFirstPagCat.FlatAppearance.BorderSize = 0;
            this.btnFirstPagCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPagCat.ForeColor = System.Drawing.Color.White;
            this.btnFirstPagCat.Location = new System.Drawing.Point(839, 429);
            this.btnFirstPagCat.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirstPagCat.Name = "btnFirstPagCat";
            this.btnFirstPagCat.Size = new System.Drawing.Size(40, 25);
            this.btnFirstPagCat.TabIndex = 58;
            this.btnFirstPagCat.Text = "<<";
            this.btnFirstPagCat.UseVisualStyleBackColor = false;
            this.btnFirstPagCat.Click += new System.EventHandler(this.BtnFirstPagCat_Click);
            // 
            // btnLastPagCat
            // 
            this.btnLastPagCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnLastPagCat.FlatAppearance.BorderSize = 0;
            this.btnLastPagCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPagCat.ForeColor = System.Drawing.Color.White;
            this.btnLastPagCat.Location = new System.Drawing.Point(1034, 429);
            this.btnLastPagCat.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastPagCat.Name = "btnLastPagCat";
            this.btnLastPagCat.Size = new System.Drawing.Size(40, 25);
            this.btnLastPagCat.TabIndex = 59;
            this.btnLastPagCat.Text = ">>";
            this.btnLastPagCat.UseVisualStyleBackColor = false;
            this.btnLastPagCat.Click += new System.EventHandler(this.BtnLastPagCat_Click);
            // 
            // labelCurrentPagCat
            // 
            this.labelCurrentPagCat.AutoSize = true;
            this.labelCurrentPagCat.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPagCat.ForeColor = System.Drawing.Color.White;
            this.labelCurrentPagCat.Location = new System.Drawing.Point(945, 427);
            this.labelCurrentPagCat.Name = "labelCurrentPagCat";
            this.labelCurrentPagCat.Size = new System.Drawing.Size(27, 29);
            this.labelCurrentPagCat.TabIndex = 60;
            this.labelCurrentPagCat.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(313, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Páginas";
            // 
            // comboPagsCat
            // 
            this.comboPagsCat.FormattingEnabled = true;
            this.comboPagsCat.Location = new System.Drawing.Point(403, 433);
            this.comboPagsCat.Name = "comboPagsCat";
            this.comboPagsCat.Size = new System.Drawing.Size(52, 21);
            this.comboPagsCat.TabIndex = 62;
            this.comboPagsCat.SelectedIndexChanged += new System.EventHandler(this.ComboPagsCat_SelectedIndexChanged);
            // 
            // labelMostrandoCat
            // 
            this.labelMostrandoCat.AutoSize = true;
            this.labelMostrandoCat.BackColor = System.Drawing.Color.Transparent;
            this.labelMostrandoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrandoCat.ForeColor = System.Drawing.Color.White;
            this.labelMostrandoCat.Location = new System.Drawing.Point(486, 434);
            this.labelMostrandoCat.Name = "labelMostrandoCat";
            this.labelMostrandoCat.Size = new System.Drawing.Size(221, 20);
            this.labelMostrandoCat.TabIndex = 63;
            this.labelMostrandoCat.Text = "Mostrando X páginas de Y";
            // 
            // labelEstadoCat
            // 
            this.labelEstadoCat.AutoSize = true;
            this.labelEstadoCat.BackColor = System.Drawing.Color.White;
            this.labelEstadoCat.Location = new System.Drawing.Point(836, 42);
            this.labelEstadoCat.Name = "labelEstadoCat";
            this.labelEstadoCat.Size = new System.Drawing.Size(40, 13);
            this.labelEstadoCat.TabIndex = 70;
            this.labelEstadoCat.Text = "Estado";
            // 
            // cmbEstadoCat
            // 
            this.cmbEstadoCat.FormattingEnabled = true;
            this.cmbEstadoCat.Location = new System.Drawing.Point(839, 65);
            this.cmbEstadoCat.Name = "cmbEstadoCat";
            this.cmbEstadoCat.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoCat.TabIndex = 69;
            this.cmbEstadoCat.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoCat_SelectedIndexChanged);
            // 
            // btnLimpiarFiltrosCat
            // 
            this.btnLimpiarFiltrosCat.Location = new System.Drawing.Point(995, 53);
            this.btnLimpiarFiltrosCat.Name = "btnLimpiarFiltrosCat";
            this.btnLimpiarFiltrosCat.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarFiltrosCat.TabIndex = 68;
            this.btnLimpiarFiltrosCat.Text = "Limpiar filtros";
            this.btnLimpiarFiltrosCat.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltrosCat.Click += new System.EventHandler(this.BtnLimpiarFiltrosCat_Click);
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(717, 66);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCat.TabIndex = 66;
            this.txtNombreCat.TextChanged += new System.EventHandler(this.TxtNombreCat_TextChanged);
            // 
            // labelNombreCat
            // 
            this.labelNombreCat.AutoSize = true;
            this.labelNombreCat.BackColor = System.Drawing.Color.White;
            this.labelNombreCat.Location = new System.Drawing.Point(714, 42);
            this.labelNombreCat.Name = "labelNombreCat";
            this.labelNombreCat.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCat.TabIndex = 64;
            this.labelNombreCat.Text = "Nombre";
            // 
            // btnCloseNombreCats
            // 
            this.btnCloseNombreCats.BackColor = System.Drawing.Color.Red;
            this.btnCloseNombreCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNombreCats.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseNombreCats.IconColor = System.Drawing.Color.White;
            this.btnCloseNombreCats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNombreCats.IconSize = 20;
            this.btnCloseNombreCats.Location = new System.Drawing.Point(762, 38);
            this.btnCloseNombreCats.Name = "btnCloseNombreCats";
            this.btnCloseNombreCats.Size = new System.Drawing.Size(22, 23);
            this.btnCloseNombreCats.TabIndex = 71;
            this.btnCloseNombreCats.UseVisualStyleBackColor = false;
            this.btnCloseNombreCats.Click += new System.EventHandler(this.BtnCloseNombreCats_Click);
            // 
            // btnCloseEstadoCats
            // 
            this.btnCloseEstadoCats.BackColor = System.Drawing.Color.Red;
            this.btnCloseEstadoCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEstadoCats.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseEstadoCats.IconColor = System.Drawing.Color.White;
            this.btnCloseEstadoCats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEstadoCats.IconSize = 20;
            this.btnCloseEstadoCats.Location = new System.Drawing.Point(883, 37);
            this.btnCloseEstadoCats.Name = "btnCloseEstadoCats";
            this.btnCloseEstadoCats.Size = new System.Drawing.Size(22, 23);
            this.btnCloseEstadoCats.TabIndex = 72;
            this.btnCloseEstadoCats.UseVisualStyleBackColor = false;
            this.btnCloseEstadoCats.Click += new System.EventHandler(this.BtnCloseEstadoCats_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Filtrar por:";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.portada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCloseEstadoCats);
            this.Controls.Add(this.btnCloseNombreCats);
            this.Controls.Add(this.labelEstadoCat);
            this.Controls.Add(this.cmbEstadoCat);
            this.Controls.Add(this.btnLimpiarFiltrosCat);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.labelNombreCat);
            this.Controls.Add(this.labelMostrandoCat);
            this.Controls.Add(this.comboPagsCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrentPagCat);
            this.Controls.Add(this.btnLastPagCat);
            this.Controls.Add(this.btnFirstPagCat);
            this.Controls.Add(this.btnPrevPagCat);
            this.Controls.Add(this.btnNextPagCat);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnNextPagCat;
        private System.Windows.Forms.Button btnPrevPagCat;
        private System.Windows.Forms.Button btnFirstPagCat;
        private System.Windows.Forms.Button btnLastPagCat;
        private System.Windows.Forms.Label labelCurrentPagCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPagsCat;
        private System.Windows.Forms.Label labelMostrandoCat;
        private System.Windows.Forms.Label labelEstadoCat;
        private System.Windows.Forms.ComboBox cmbEstadoCat;
        private System.Windows.Forms.Button btnLimpiarFiltrosCat;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Label labelNombreCat;
        private FontAwesome.Sharp.IconButton btnCloseNombreCats;
        private FontAwesome.Sharp.IconButton btnCloseEstadoCats;
        private System.Windows.Forms.Label label4;
    }
}