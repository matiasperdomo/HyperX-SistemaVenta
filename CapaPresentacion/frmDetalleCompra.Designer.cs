namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label26 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.dgvdatac = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlimpiarreporte = new FontAwesome.Sharp.IconButton();
            this.btnbuscarreporte = new FontAwesome.Sharp.IconButton();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatac)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(575, 10);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(545, 475);
            this.label10.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 25);
            this.label9.TabIndex = 194;
            this.label9.Text = "Ver Detalle Compra";
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(1025, 52);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(78, 21);
            this.btnborrar.TabIndex = 198;
            this.btnborrar.Text = "Limpiar";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 17;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(944, 52);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 21);
            this.btnbuscar.TabIndex = 196;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(704, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 13);
            this.label26.TabIndex = 197;
            this.label26.Text = "Numero de Compra:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(809, 52);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(129, 20);
            this.txtbusqueda.TabIndex = 195;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(585, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 75);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(319, 39);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(189, 21);
            this.txtusuario.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 92;
            this.label2.Text = "Usuario:";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipodocumento.Location = new System.Drawing.Point(175, 39);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.ReadOnly = true;
            this.txttipodocumento.Size = new System.Drawing.Size(127, 21);
            this.txttipodocumento.TabIndex = 87;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(23, 39);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(134, 21);
            this.txtfecha.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Documento:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnumerodocumento);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdocproveedor);
            this.groupBox2.Controls.Add(this.txtnombreproveedor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(585, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 75);
            this.groupBox2.TabIndex = 200;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(526, 39);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(54, 21);
            this.txtnumerodocumento.TabIndex = 194;
            this.txtnumerodocumento.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 15);
            this.label14.TabIndex = 84;
            this.label14.Text = "Número Documento:";
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocproveedor.Location = new System.Drawing.Point(22, 41);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.ReadOnly = true;
            this.txtdocproveedor.Size = new System.Drawing.Size(134, 21);
            this.txtdocproveedor.TabIndex = 85;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreproveedor.Location = new System.Drawing.Point(173, 41);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.ReadOnly = true;
            this.txtnombreproveedor.Size = new System.Drawing.Size(201, 21);
            this.txtnombreproveedor.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(171, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 83;
            this.label15.Text = "Razón Social:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dgvdata.Location = new System.Drawing.Point(585, 243);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(525, 198);
            this.dgvdata.TabIndex = 201;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 202;
            this.label1.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            this.txtmontototal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtmontototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontototal.Location = new System.Drawing.Point(670, 447);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.ReadOnly = true;
            this.txtmontototal.Size = new System.Drawing.Size(95, 21);
            this.txtmontototal.TabIndex = 203;
            this.txtmontototal.Text = "0";
            // 
            // dgvdatac
            // 
            this.dgvdatac.AllowUserToAddRows = false;
            this.dgvdatac.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvdatac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.idventa,
            this.NumeroDocumento,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.FechaRegistro});
            this.dgvdatac.Location = new System.Drawing.Point(27, 81);
            this.dgvdatac.MultiSelect = false;
            this.dgvdatac.Name = "dgvdatac";
            this.dgvdatac.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatac.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvdatac.RowTemplate.Height = 28;
            this.dgvdatac.Size = new System.Drawing.Size(522, 363);
            this.dgvdatac.TabIndex = 226;
            this.dgvdatac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatac_CellContentClick);
            this.dgvdatac.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdatac_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // idventa
            // 
            this.idventa.HeaderText = "IdVenta";
            this.idventa.Name = "idventa";
            this.idventa.ReadOnly = true;
            this.idventa.Visible = false;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Compra";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Documento Proveedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Razon Social";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 225;
            this.label8.Text = "Listado de Compras";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(550, 475);
            this.label7.TabIndex = 224;
            // 
            // btnlimpiarreporte
            // 
            this.btnlimpiarreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarreporte.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiarreporte.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarreporte.IconSize = 20;
            this.btnlimpiarreporte.Location = new System.Drawing.Point(466, 54);
            this.btnlimpiarreporte.Name = "btnlimpiarreporte";
            this.btnlimpiarreporte.Size = new System.Drawing.Size(78, 21);
            this.btnlimpiarreporte.TabIndex = 246;
            this.btnlimpiarreporte.Text = "Limpiar";
            this.btnlimpiarreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarreporte.UseVisualStyleBackColor = true;
            this.btnlimpiarreporte.Click += new System.EventHandler(this.btnlimpiarreporte_Click);
            // 
            // btnbuscarreporte
            // 
            this.btnbuscarreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarreporte.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarreporte.IconColor = System.Drawing.Color.Black;
            this.btnbuscarreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarreporte.IconSize = 17;
            this.btnbuscarreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscarreporte.Location = new System.Drawing.Point(379, 54);
            this.btnbuscarreporte.Name = "btnbuscarreporte";
            this.btnbuscarreporte.Size = new System.Drawing.Size(78, 21);
            this.btnbuscarreporte.TabIndex = 245;
            this.btnbuscarreporte.Text = "Buscar";
            this.btnbuscarreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarreporte.UseVisualStyleBackColor = true;
            this.btnbuscarreporte.Click += new System.EventHandler(this.btnbuscarreporte_Click);
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(267, 54);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(97, 20);
            this.txtfechafin.TabIndex = 244;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(101, 54);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 242;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 243;
            this.label11.Text = "Fecha Inicio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(202, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 241;
            this.label12.Text = "Fecha Fin:";
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.portada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 620);
            this.Controls.Add(this.btnlimpiarreporte);
            this.Controls.Add(this.btnbuscarreporte);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvdatac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frmDetalleCompra";
            this.Text = "frmDetalleCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridView dgvdatac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private FontAwesome.Sharp.IconButton btnlimpiarreporte;
        private FontAwesome.Sharp.IconButton btnbuscarreporte;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}