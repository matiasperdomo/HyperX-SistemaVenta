namespace CapaPresentacion
{
    partial class frmProducto
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexportar = new FontAwesome.Sharp.IconButton();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btn_OpenImg = new FontAwesome.Sharp.IconButton();
            this.File = new System.Windows.Forms.PictureBox();
            this.labelMostrandoProd = new System.Windows.Forms.Label();
            this.comboPagsProd = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelCurrentPagProd = new System.Windows.Forms.Label();
            this.btnLastPagProd = new System.Windows.Forms.Button();
            this.btnFirstPagProd = new System.Windows.Forms.Button();
            this.btnPrevPagProd = new System.Windows.Forms.Button();
            this.btnNextPagProd = new System.Windows.Forms.Button();
            this.btnCloseRolUsua = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCategoriaProd = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCloseEstadoUsua = new FontAwesome.Sharp.IconButton();
            this.btnCloseNombreUsua = new FontAwesome.Sharp.IconButton();
            this.labelEstadoCat = new System.Windows.Forms.Label();
            this.cmbEstadoProd = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltrosProd = new System.Windows.Forms.Button();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.labelNombreCat = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeight = 47;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Img,
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(279, 93);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 60;
            this.dgvdata.Size = new System.Drawing.Size(841, 371);
            this.dgvdata.TabIndex = 47;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(206, 44);
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
            this.label10.Location = new System.Drawing.Point(279, 16);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.label10.Size = new System.Drawing.Size(841, 74);
            this.label10.TabIndex = 48;
            this.label10.Text = "Lista de Productos:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(175, 44);
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
            this.label9.Location = new System.Drawing.Point(35, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Detalle Producto";
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
            this.btneliminar.Location = new System.Drawing.Point(39, 470);
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
            this.btnlimpiar.Location = new System.Drawing.Point(39, 441);
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
            this.btnguardar.Location = new System.Drawing.Point(39, 412);
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
            this.label8.Location = new System.Drawing.Point(37, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(40, 347);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(192, 21);
            this.cboestado.TabIndex = 41;
            // 
            // cbocategoria
            // 
            this.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(40, 209);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(192, 21);
            this.cbocategoria.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Categoria:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(40, 164);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtdescripcion.TabIndex = 34;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(40, 118);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(192, 20);
            this.txtnombre.TabIndex = 33;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(40, 70);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(192, 20);
            this.txtcodigo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 584);
            this.label1.TabIndex = 28;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.Control;
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexportar.IconSize = 17;
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(289, 56);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(118, 21);
            this.btnexportar.TabIndex = 209;
            this.btnexportar.Text = "Descargar Excel";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(39, 257);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(192, 20);
            this.txtstock.TabIndex = 210;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 211;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 213;
            this.label6.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(39, 302);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(192, 20);
            this.txtprecio.TabIndex = 212;
            // 
            // btn_OpenImg
            // 
            this.btn_OpenImg.BackColor = System.Drawing.Color.Gray;
            this.btn_OpenImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_OpenImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenImg.ForeColor = System.Drawing.Color.White;
            this.btn_OpenImg.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btn_OpenImg.IconColor = System.Drawing.Color.White;
            this.btn_OpenImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_OpenImg.IconSize = 16;
            this.btn_OpenImg.Location = new System.Drawing.Point(39, 377);
            this.btn_OpenImg.Name = "btn_OpenImg";
            this.btn_OpenImg.Size = new System.Drawing.Size(192, 23);
            this.btn_OpenImg.TabIndex = 214;
            this.btn_OpenImg.Text = "Cargar Imagen";
            this.btn_OpenImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OpenImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OpenImg.UseVisualStyleBackColor = false;
            this.btn_OpenImg.Click += new System.EventHandler(this.Btn_OpenImg_Click);
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.Transparent;
            this.File.Location = new System.Drawing.Point(195, 10);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(51, 50);
            this.File.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.File.TabIndex = 215;
            this.File.TabStop = false;
            // 
            // labelMostrandoProd
            // 
            this.labelMostrandoProd.AutoSize = true;
            this.labelMostrandoProd.BackColor = System.Drawing.Color.Transparent;
            this.labelMostrandoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrandoProd.ForeColor = System.Drawing.Color.White;
            this.labelMostrandoProd.Location = new System.Drawing.Point(490, 476);
            this.labelMostrandoProd.Name = "labelMostrandoProd";
            this.labelMostrandoProd.Size = new System.Drawing.Size(221, 20);
            this.labelMostrandoProd.TabIndex = 223;
            this.labelMostrandoProd.Text = "Mostrando X páginas de Y";
            // 
            // comboPagsProd
            // 
            this.comboPagsProd.FormattingEnabled = true;
            this.comboPagsProd.Location = new System.Drawing.Point(407, 475);
            this.comboPagsProd.Name = "comboPagsProd";
            this.comboPagsProd.Size = new System.Drawing.Size(52, 21);
            this.comboPagsProd.TabIndex = 222;
            this.comboPagsProd.SelectedIndexChanged += new System.EventHandler(this.ComboPagsProd_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(317, 472);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 24);
            this.label14.TabIndex = 221;
            this.label14.Text = "Páginas";
            // 
            // labelCurrentPagProd
            // 
            this.labelCurrentPagProd.AutoSize = true;
            this.labelCurrentPagProd.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPagProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPagProd.ForeColor = System.Drawing.Color.White;
            this.labelCurrentPagProd.Location = new System.Drawing.Point(949, 469);
            this.labelCurrentPagProd.Name = "labelCurrentPagProd";
            this.labelCurrentPagProd.Size = new System.Drawing.Size(27, 29);
            this.labelCurrentPagProd.TabIndex = 220;
            this.labelCurrentPagProd.Text = "1";
            // 
            // btnLastPagProd
            // 
            this.btnLastPagProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnLastPagProd.FlatAppearance.BorderSize = 0;
            this.btnLastPagProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPagProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPagProd.ForeColor = System.Drawing.Color.White;
            this.btnLastPagProd.Location = new System.Drawing.Point(1038, 471);
            this.btnLastPagProd.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastPagProd.Name = "btnLastPagProd";
            this.btnLastPagProd.Size = new System.Drawing.Size(40, 25);
            this.btnLastPagProd.TabIndex = 219;
            this.btnLastPagProd.Text = ">>";
            this.btnLastPagProd.UseVisualStyleBackColor = false;
            this.btnLastPagProd.Click += new System.EventHandler(this.BtnLastPagProd_Click);
            // 
            // btnFirstPagProd
            // 
            this.btnFirstPagProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnFirstPagProd.FlatAppearance.BorderSize = 0;
            this.btnFirstPagProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPagProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPagProd.ForeColor = System.Drawing.Color.White;
            this.btnFirstPagProd.Location = new System.Drawing.Point(843, 471);
            this.btnFirstPagProd.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirstPagProd.Name = "btnFirstPagProd";
            this.btnFirstPagProd.Size = new System.Drawing.Size(40, 25);
            this.btnFirstPagProd.TabIndex = 218;
            this.btnFirstPagProd.Text = "<<";
            this.btnFirstPagProd.UseVisualStyleBackColor = false;
            this.btnFirstPagProd.Click += new System.EventHandler(this.BtnFirstPagProd_Click);
            // 
            // btnPrevPagProd
            // 
            this.btnPrevPagProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnPrevPagProd.FlatAppearance.BorderSize = 0;
            this.btnPrevPagProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPagProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPagProd.ForeColor = System.Drawing.Color.White;
            this.btnPrevPagProd.Location = new System.Drawing.Point(896, 471);
            this.btnPrevPagProd.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevPagProd.Name = "btnPrevPagProd";
            this.btnPrevPagProd.Size = new System.Drawing.Size(40, 25);
            this.btnPrevPagProd.TabIndex = 217;
            this.btnPrevPagProd.Text = "<";
            this.btnPrevPagProd.UseVisualStyleBackColor = false;
            this.btnPrevPagProd.Click += new System.EventHandler(this.BtnPrevPagProd_Click);
            // 
            // btnNextPagProd
            // 
            this.btnNextPagProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnNextPagProd.FlatAppearance.BorderSize = 0;
            this.btnNextPagProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPagProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPagProd.ForeColor = System.Drawing.Color.White;
            this.btnNextPagProd.Location = new System.Drawing.Point(984, 471);
            this.btnNextPagProd.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPagProd.Name = "btnNextPagProd";
            this.btnNextPagProd.Size = new System.Drawing.Size(40, 25);
            this.btnNextPagProd.TabIndex = 216;
            this.btnNextPagProd.Text = ">";
            this.btnNextPagProd.UseVisualStyleBackColor = false;
            this.btnNextPagProd.Click += new System.EventHandler(this.BtnNextPagProd_Click);
            // 
            // btnCloseRolUsua
            // 
            this.btnCloseRolUsua.BackColor = System.Drawing.Color.Red;
            this.btnCloseRolUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRolUsua.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseRolUsua.IconColor = System.Drawing.Color.White;
            this.btnCloseRolUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseRolUsua.IconSize = 20;
            this.btnCloseRolUsua.Location = new System.Drawing.Point(854, 30);
            this.btnCloseRolUsua.Name = "btnCloseRolUsua";
            this.btnCloseRolUsua.Size = new System.Drawing.Size(22, 23);
            this.btnCloseRolUsua.TabIndex = 236;
            this.btnCloseRolUsua.UseVisualStyleBackColor = false;
            this.btnCloseRolUsua.Click += new System.EventHandler(this.BtnCloseCategoriaoProd_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(791, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 235;
            this.label15.Text = "Categoria";
            // 
            // cmbCategoriaProd
            // 
            this.cmbCategoriaProd.FormattingEnabled = true;
            this.cmbCategoriaProd.Location = new System.Drawing.Point(794, 58);
            this.cmbCategoriaProd.Name = "cmbCategoriaProd";
            this.cmbCategoriaProd.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoriaProd.TabIndex = 234;
            this.cmbCategoriaProd.SelectedIndexChanged += new System.EventHandler(this.CmbCategoriaProd_SelectedIndexChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(644, 31);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(22, 23);
            this.iconButton1.TabIndex = 233;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.BtnCloseCodigoProd_Click);
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(583, 59);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProd.TabIndex = 232;
            this.txtCodigoProd.TextChanged += new System.EventHandler(this.TxtCodigoProd_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(580, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 231;
            this.label13.Text = "Codigo";
            // 
            // btnCloseEstadoUsua
            // 
            this.btnCloseEstadoUsua.BackColor = System.Drawing.Color.Red;
            this.btnCloseEstadoUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEstadoUsua.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseEstadoUsua.IconColor = System.Drawing.Color.White;
            this.btnCloseEstadoUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEstadoUsua.IconSize = 20;
            this.btnCloseEstadoUsua.Location = new System.Drawing.Point(944, 30);
            this.btnCloseEstadoUsua.Name = "btnCloseEstadoUsua";
            this.btnCloseEstadoUsua.Size = new System.Drawing.Size(22, 23);
            this.btnCloseEstadoUsua.TabIndex = 230;
            this.btnCloseEstadoUsua.UseVisualStyleBackColor = false;
            this.btnCloseEstadoUsua.Click += new System.EventHandler(this.BtnCloseEstadoProd_Click);
            // 
            // btnCloseNombreUsua
            // 
            this.btnCloseNombreUsua.BackColor = System.Drawing.Color.Red;
            this.btnCloseNombreUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNombreUsua.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCloseNombreUsua.IconColor = System.Drawing.Color.White;
            this.btnCloseNombreUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNombreUsua.IconSize = 20;
            this.btnCloseNombreUsua.Location = new System.Drawing.Point(734, 31);
            this.btnCloseNombreUsua.Name = "btnCloseNombreUsua";
            this.btnCloseNombreUsua.Size = new System.Drawing.Size(22, 23);
            this.btnCloseNombreUsua.TabIndex = 229;
            this.btnCloseNombreUsua.UseVisualStyleBackColor = false;
            this.btnCloseNombreUsua.Click += new System.EventHandler(this.BtnCloseNombreProd_Click);
            // 
            // labelEstadoCat
            // 
            this.labelEstadoCat.AutoSize = true;
            this.labelEstadoCat.BackColor = System.Drawing.Color.White;
            this.labelEstadoCat.Location = new System.Drawing.Point(897, 35);
            this.labelEstadoCat.Name = "labelEstadoCat";
            this.labelEstadoCat.Size = new System.Drawing.Size(40, 13);
            this.labelEstadoCat.TabIndex = 228;
            this.labelEstadoCat.Text = "Estado";
            // 
            // cmbEstadoProd
            // 
            this.cmbEstadoProd.FormattingEnabled = true;
            this.cmbEstadoProd.Location = new System.Drawing.Point(900, 58);
            this.cmbEstadoProd.Name = "cmbEstadoProd";
            this.cmbEstadoProd.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoProd.TabIndex = 227;
            this.cmbEstadoProd.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoProd_SelectedIndexChanged);
            // 
            // btnLimpiarFiltrosProd
            // 
            this.btnLimpiarFiltrosProd.Location = new System.Drawing.Point(1013, 45);
            this.btnLimpiarFiltrosProd.Name = "btnLimpiarFiltrosProd";
            this.btnLimpiarFiltrosProd.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarFiltrosProd.TabIndex = 226;
            this.btnLimpiarFiltrosProd.Text = "Limpiar filtros";
            this.btnLimpiarFiltrosProd.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltrosProd.Click += new System.EventHandler(this.BtnLimpiarFiltrosProd_Click);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(689, 59);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProd.TabIndex = 225;
            this.txtNombreProd.TextChanged += new System.EventHandler(this.TxtNombreProd_TextChanged);
            // 
            // labelNombreCat
            // 
            this.labelNombreCat.AutoSize = true;
            this.labelNombreCat.BackColor = System.Drawing.Color.White;
            this.labelNombreCat.Location = new System.Drawing.Point(686, 35);
            this.labelNombreCat.Name = "labelNombreCat";
            this.labelNombreCat.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCat.TabIndex = 224;
            this.labelNombreCat.Text = "Nombre";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Img
            // 
            this.Img.HeaderText = "Imagen";
            this.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            this.Img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Img.Width = 70;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Modelo";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 130;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 80;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 80;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 80;
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
            this.Estado.Width = 80;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.portada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 584);
            this.Controls.Add(this.btnCloseRolUsua);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbCategoriaProd);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCloseEstadoUsua);
            this.Controls.Add(this.btnCloseNombreUsua);
            this.Controls.Add(this.labelEstadoCat);
            this.Controls.Add(this.cmbEstadoProd);
            this.Controls.Add(this.btnLimpiarFiltrosProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.labelNombreCat);
            this.Controls.Add(this.labelMostrandoProd);
            this.Controls.Add(this.comboPagsProd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelCurrentPagProd);
            this.Controls.Add(this.btnLastPagProd);
            this.Controls.Add(this.btnFirstPagProd);
            this.Controls.Add(this.btnPrevPagProd);
            this.Controls.Add(this.btnNextPagProd);
            this.Controls.Add(this.File);
            this.Controls.Add(this.btn_OpenImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.btnexportar);
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
            this.Controls.Add(this.cbocategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File)).EndInit();
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
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnexportar;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private FontAwesome.Sharp.IconButton btn_OpenImg;
        private System.Windows.Forms.PictureBox File;
        private System.Windows.Forms.Label labelMostrandoProd;
        private System.Windows.Forms.ComboBox comboPagsProd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelCurrentPagProd;
        private System.Windows.Forms.Button btnLastPagProd;
        private System.Windows.Forms.Button btnFirstPagProd;
        private System.Windows.Forms.Button btnPrevPagProd;
        private System.Windows.Forms.Button btnNextPagProd;
        private FontAwesome.Sharp.IconButton btnCloseRolUsua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCategoriaProd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnCloseEstadoUsua;
        private FontAwesome.Sharp.IconButton btnCloseNombreUsua;
        private System.Windows.Forms.Label labelEstadoCat;
        private System.Windows.Forms.ComboBox cmbEstadoProd;
        private System.Windows.Forms.Button btnLimpiarFiltrosProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label labelNombreCat;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}