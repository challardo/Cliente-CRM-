namespace Cliente__CRM_
{
    partial class ClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rfcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_clienteDataSet = new Cliente__CRM_.factura_clienteDataSet();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.DGVTotalProductos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter1 = new Cliente__CRM_.factura_clienteDataSet1TableAdapters.ProductosTableAdapter();
            this.fillByIdPToolStrip = new System.Windows.Forms.ToolStrip();
            this.idProductoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idProductoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIdPToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DGVAux = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtIpServer = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidad_P = new System.Windows.Forms.Label();
            this.preFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Cliente__CRM_.factura_clienteDataSetTableAdapters.clienteTableAdapter();
            this.productosTableAdapter = new Cliente__CRM_.factura_clienteDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new Cliente__CRM_.factura_clienteDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter1 = new Cliente__CRM_.factura_clienteDataSetTableAdapters.clienteTableAdapter();
            this.factura_clienteDataSetNuevo = new Cliente__CRM_.factura_clienteDataSet();
            this.preFacturaTableAdapter = new Cliente__CRM_.factura_clienteDataSetTableAdapters.PreFacturaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.preFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_PDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_clienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.fillByIdPToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_clienteDataSetNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFacturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rfcDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(300, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 77);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // rfcDataGridViewTextBoxColumn
            // 
            this.rfcDataGridViewTextBoxColumn.DataPropertyName = "rfc";
            this.rfcDataGridViewTextBoxColumn.HeaderText = "rfc";
            this.rfcDataGridViewTextBoxColumn.Name = "rfcDataGridViewTextBoxColumn";
            this.rfcDataGridViewTextBoxColumn.Width = 200;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 300;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.factura_clienteDataSet;
            // 
            // factura_clienteDataSet
            // 
            this.factura_clienteDataSet.DataSetName = "factura_clienteDataSet";
            this.factura_clienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Enabled = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(33, 390);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(158, 59);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // DGVTotalProductos
            // 
            this.DGVTotalProductos.AllowUserToAddRows = false;
            this.DGVTotalProductos.AllowUserToDeleteRows = false;
            this.DGVTotalProductos.AutoGenerateColumns = false;
            this.DGVTotalProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTotalProductos.ColumnHeadersVisible = false;
            this.DGVTotalProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.productoDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1});
            this.DGVTotalProductos.DataSource = this.productosBindingSource;
            this.DGVTotalProductos.Location = new System.Drawing.Point(33, 220);
            this.DGVTotalProductos.Name = "DGVTotalProductos";
            this.DGVTotalProductos.Size = new System.Drawing.Size(405, 150);
            this.DGVTotalProductos.TabIndex = 3;
            this.DGVTotalProductos.Visible = false;
            this.DGVTotalProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTotalProductos_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn1
            // 
            this.productoDataGridViewTextBoxColumn1.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn1.HeaderText = "producto";
            this.productoDataGridViewTextBoxColumn1.Name = "productoDataGridViewTextBoxColumn1";
            this.productoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.factura_clienteDataSet;
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByIdPToolStrip
            // 
            this.fillByIdPToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idProductoToolStripLabel,
            this.idProductoToolStripTextBox,
            this.fillByIdPToolStripButton});
            this.fillByIdPToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIdPToolStrip.Name = "fillByIdPToolStrip";
            this.fillByIdPToolStrip.Size = new System.Drawing.Size(957, 25);
            this.fillByIdPToolStrip.TabIndex = 4;
            this.fillByIdPToolStrip.Text = "fillByIdPToolStrip";
            this.fillByIdPToolStrip.Visible = false;
            // 
            // idProductoToolStripLabel
            // 
            this.idProductoToolStripLabel.Name = "idProductoToolStripLabel";
            this.idProductoToolStripLabel.Size = new System.Drawing.Size(69, 22);
            this.idProductoToolStripLabel.Text = "IdProducto:";
            // 
            // idProductoToolStripTextBox
            // 
            this.idProductoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idProductoToolStripTextBox.Name = "idProductoToolStripTextBox";
            this.idProductoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIdPToolStripButton
            // 
            this.fillByIdPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIdPToolStripButton.Name = "fillByIdPToolStripButton";
            this.fillByIdPToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.fillByIdPToolStripButton.Text = "FillByIdP";
            // 
            // DGVAux
            // 
            this.DGVAux.AllowUserToAddRows = false;
            this.DGVAux.AllowUserToDeleteRows = false;
            this.DGVAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAux.ColumnHeadersVisible = false;
            this.DGVAux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.producto,
            this.cantidad,
            this.precio});
            this.DGVAux.Location = new System.Drawing.Point(444, 220);
            this.DGVAux.Name = "DGVAux";
            this.DGVAux.ReadOnly = true;
            this.DGVAux.Size = new System.Drawing.Size(445, 150);
            this.DGVAux.TabIndex = 5;
            this.DGVAux.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAux_CellClick);
            this.DGVAux.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGVAux_RowsAdded);
            this.DGVAux.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVAux_RowsRemoved);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Respuesta:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(762, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(12, 111);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(271, 20);
            this.txtRFC.TabIndex = 8;
            this.txtRFC.Text = "GADC98PDRR12";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(12, 154);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 20);
            this.txtCorreo.TabIndex = 9;
            this.txtCorreo.Text = "Carlos@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Correo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(220, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 59);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(957, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtIpServer
            // 
            this.txtIpServer.Location = new System.Drawing.Point(73, 39);
            this.txtIpServer.Name = "txtIpServer";
            this.txtIpServer.Size = new System.Drawing.Size(100, 20);
            this.txtIpServer.TabIndex = 13;
            this.txtIpServer.Text = "127.0.0.1";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(73, 65);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtPuerto.TabIndex = 14;
            this.txtPuerto.Text = "1433";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Server IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Port";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(193, 65);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 17;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Enabled = false;
            this.btnCorreo.Location = new System.Drawing.Point(126, 180);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(142, 23);
            this.btnCorreo.TabIndex = 18;
            this.btnCorreo.Text = "Enviar Correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Visible = false;
            this.btnCorreo.Click += new System.EventHandler(this.BtnCorreo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total: $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cantidad total productos:";
            // 
            // lblCantidad_P
            // 
            this.lblCantidad_P.AutoSize = true;
            this.lblCantidad_P.Location = new System.Drawing.Point(806, 436);
            this.lblCantidad_P.Name = "lblCantidad_P";
            this.lblCantidad_P.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad_P.TabIndex = 21;
            this.lblCantidad_P.Text = "_";
            // 
            // preFacturaBindingSource
            // 
            this.preFacturaBindingSource.DataMember = "PreFactura";
            this.preFacturaBindingSource.DataSource = this.factura_clienteDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.PreFacturaTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cliente__CRM_.factura_clienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // factura_clienteDataSetNuevo
            // 
            this.factura_clienteDataSetNuevo.DataSetName = "factura_clienteDataSet";
            this.factura_clienteDataSetNuevo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preFacturaTableAdapter
            // 
            this.preFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "RFC";
            // 
            // preFacturaDataGridView
            // 
            this.preFacturaDataGridView.AllowUserToAddRows = false;
            this.preFacturaDataGridView.AutoGenerateColumns = false;
            this.preFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Nombre_PDF});
            this.preFacturaDataGridView.DataSource = this.preFacturaBindingSource;
            this.preFacturaDataGridView.Location = new System.Drawing.Point(300, 139);
            this.preFacturaDataGridView.Name = "preFacturaDataGridView";
            this.preFacturaDataGridView.Size = new System.Drawing.Size(645, 75);
            this.preFacturaDataGridView.TabIndex = 22;
            this.preFacturaDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RFC";
            this.dataGridViewTextBoxColumn2.HeaderText = "RFC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CantidadP";
            this.dataGridViewTextBoxColumn4.HeaderText = "CantidadP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Nombre_PDF
            // 
            this.Nombre_PDF.DataPropertyName = "Nombre_PDF";
            this.Nombre_PDF.HeaderText = "Nombre_PDF";
            this.Nombre_PDF.Name = "Nombre_PDF";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 475);
            this.Controls.Add(this.preFacturaDataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCantidad_P);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIpServer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVAux);
            this.Controls.Add(this.fillByIdPToolStrip);
            this.Controls.Add(this.DGVTotalProductos);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClienteForm";
            this.Text = "CLIENTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClienteForm_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_clienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.fillByIdPToolStrip.ResumeLayout(false);
            this.fillByIdPToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_clienteDataSetNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFacturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private factura_clienteDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private factura_clienteDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridView DGVTotalProductos;
        private factura_clienteDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByIdPToolStrip;
        private System.Windows.Forms.ToolStripLabel idProductoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idProductoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIdPToolStripButton;
        private System.Windows.Forms.DataGridView DGVAux;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private factura_clienteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public factura_clienteDataSet factura_clienteDataSet;
        private System.Windows.Forms.TextBox txtIpServer;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConectar;
        private factura_clienteDataSetTableAdapters.clienteTableAdapter clienteTableAdapter1;
        public factura_clienteDataSet factura_clienteDataSetNuevo;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidad_P;
        private System.Windows.Forms.BindingSource preFacturaBindingSource;
        private factura_clienteDataSetTableAdapters.PreFacturaTableAdapter preFacturaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView preFacturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_PDF;
    }
}

