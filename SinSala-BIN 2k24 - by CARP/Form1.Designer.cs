namespace SinSala_BIN_2k24___by_CARP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtArchivo = new TextBox();
            btnArchivo = new Button();
            groupBox2 = new GroupBox();
            dgvBIN = new DataGridView();
            popUp = new ContextMenuStrip(components);
            tsInsertarRAW = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            tsInsertarGrafico = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsInsertarBIN = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsInsertarPaleta = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsInsertarPaletaBIN = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            brnCrearBIN = new Button();
            colIndice = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colVRAMx = new DataGridViewTextBoxColumn();
            colVRAMy = new DataGridViewTextBoxColumn();
            colAncho = new DataGridViewTextBoxColumn();
            colAlto = new DataGridViewTextBoxColumn();
            colSize = new DataGridViewTextBoxColumn();
            colOffset = new DataGridViewTextBoxColumn();
            colTam = new DataGridViewTextBoxColumn();
            colTipoDato = new DataGridViewTextBoxColumn();
            colEsNuevo = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBIN).BeginInit();
            popUp.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArchivo);
            groupBox1.Controls.Add(btnArchivo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Archivo";
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(6, 22);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(657, 23);
            txtArchivo.TabIndex = 1;
            // 
            // btnArchivo
            // 
            btnArchivo.Location = new Point(669, 22);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(75, 23);
            btnArchivo.TabIndex = 0;
            btnArchivo.Text = "&Archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvBIN);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 411);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Composición del BIN";
            // 
            // dgvBIN
            // 
            dgvBIN.AllowUserToAddRows = false;
            dgvBIN.AllowUserToDeleteRows = false;
            dgvBIN.AllowUserToResizeColumns = false;
            dgvBIN.AllowUserToResizeRows = false;
            dgvBIN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvBIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBIN.Columns.AddRange(new DataGridViewColumn[] { colIndice, colID, colVRAMx, colVRAMy, colAncho, colAlto, colSize, colOffset, colTam, colTipoDato, colEsNuevo });
            dgvBIN.Location = new Point(6, 22);
            dgvBIN.MultiSelect = false;
            dgvBIN.Name = "dgvBIN";
            dgvBIN.ReadOnly = true;
            dgvBIN.RowHeadersVisible = false;
            dgvBIN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBIN.ShowCellToolTips = false;
            dgvBIN.ShowEditingIcon = false;
            dgvBIN.Size = new Size(738, 383);
            dgvBIN.TabIndex = 0;
            dgvBIN.CellClick += dgvBIN_CellClick;
            // 
            // popUp
            // 
            popUp.Items.AddRange(new ToolStripItem[] { tsInsertarRAW, toolStripSeparator5, tsInsertarGrafico, toolStripSeparator1, tsInsertarBIN, toolStripSeparator2, tsInsertarPaleta, toolStripSeparator3, tsInsertarPaletaBIN, toolStripSeparator4 });
            popUp.Name = "popUp";
            popUp.Size = new Size(238, 144);
            // 
            // tsInsertarRAW
            // 
            tsInsertarRAW.Name = "tsInsertarRAW";
            tsInsertarRAW.Size = new Size(237, 22);
            tsInsertarRAW.Text = "Insertar gráfico RAW ";
            tsInsertarRAW.Click += tsInsertarRAW_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(234, 6);
            // 
            // tsInsertarGrafico
            // 
            tsInsertarGrafico.Name = "tsInsertarGrafico";
            tsInsertarGrafico.Size = new Size(237, 22);
            tsInsertarGrafico.Text = "Insertar gráfico BMP";
            tsInsertarGrafico.Click += tsInsertarGrafico_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(234, 6);
            // 
            // tsInsertarBIN
            // 
            tsInsertarBIN.Name = "tsInsertarBIN";
            tsInsertarBIN.Size = new Size(237, 22);
            tsInsertarBIN.Text = "Insertar gráfico ya comprimido";
            tsInsertarBIN.Click += tsInsertarBIN_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(234, 6);
            // 
            // tsInsertarPaleta
            // 
            tsInsertarPaleta.Name = "tsInsertarPaleta";
            tsInsertarPaleta.Size = new Size(237, 22);
            tsInsertarPaleta.Text = "Insertar paleta desde BMP";
            tsInsertarPaleta.Click += tsInsertarPaleta_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(234, 6);
            // 
            // tsInsertarPaletaBIN
            // 
            tsInsertarPaletaBIN.Name = "tsInsertarPaletaBIN";
            tsInsertarPaletaBIN.Size = new Size(237, 22);
            tsInsertarPaletaBIN.Text = "Insertar paleta BIN";
            tsInsertarPaletaBIN.Click += tsInsertarPaletaBIN_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(234, 6);
            // 
            // brnCrearBIN
            // 
            brnCrearBIN.Location = new Point(351, 502);
            brnCrearBIN.Name = "brnCrearBIN";
            brnCrearBIN.Size = new Size(75, 23);
            brnCrearBIN.TabIndex = 2;
            brnCrearBIN.Text = "&Crer BIN";
            brnCrearBIN.UseVisualStyleBackColor = true;
            brnCrearBIN.Click += btnCrearBIN_Click;
            // 
            // colIndice
            // 
            colIndice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colIndice.HeaderText = "#";
            colIndice.Name = "colIndice";
            colIndice.ReadOnly = true;
            colIndice.Resizable = DataGridViewTriState.False;
            colIndice.SortMode = DataGridViewColumnSortMode.NotSortable;
            colIndice.Width = 20;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Resizable = DataGridViewTriState.False;
            colID.SortMode = DataGridViewColumnSortMode.NotSortable;
            colID.Width = 24;
            // 
            // colVRAMx
            // 
            colVRAMx.HeaderText = "VRAMx";
            colVRAMx.Name = "colVRAMx";
            colVRAMx.ReadOnly = true;
            colVRAMx.Resizable = DataGridViewTriState.False;
            colVRAMx.SortMode = DataGridViewColumnSortMode.NotSortable;
            colVRAMx.Width = 52;
            // 
            // colVRAMy
            // 
            colVRAMy.HeaderText = "VRAMy";
            colVRAMy.Name = "colVRAMy";
            colVRAMy.ReadOnly = true;
            colVRAMy.Resizable = DataGridViewTriState.False;
            colVRAMy.SortMode = DataGridViewColumnSortMode.NotSortable;
            colVRAMy.Width = 52;
            // 
            // colAncho
            // 
            colAncho.HeaderText = "Ancho";
            colAncho.Name = "colAncho";
            colAncho.ReadOnly = true;
            colAncho.Resizable = DataGridViewTriState.False;
            colAncho.SortMode = DataGridViewColumnSortMode.NotSortable;
            colAncho.Width = 48;
            // 
            // colAlto
            // 
            colAlto.HeaderText = "Alto";
            colAlto.Name = "colAlto";
            colAlto.ReadOnly = true;
            colAlto.Resizable = DataGridViewTriState.False;
            colAlto.SortMode = DataGridViewColumnSortMode.NotSortable;
            colAlto.Width = 35;
            // 
            // colSize
            // 
            colSize.HeaderText = "VRAMs";
            colSize.Name = "colSize";
            colSize.ReadOnly = true;
            colSize.Resizable = DataGridViewTriState.False;
            colSize.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSize.Width = 51;
            // 
            // colOffset
            // 
            colOffset.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colOffset.HeaderText = "Offset";
            colOffset.Name = "colOffset";
            colOffset.ReadOnly = true;
            colOffset.Resizable = DataGridViewTriState.False;
            colOffset.SortMode = DataGridViewColumnSortMode.NotSortable;
            colOffset.Width = 45;
            // 
            // colTam
            // 
            colTam.HeaderText = "Tamaño";
            colTam.Name = "colTam";
            colTam.ReadOnly = true;
            colTam.Resizable = DataGridViewTriState.False;
            colTam.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTam.Width = 55;
            // 
            // colTipoDato
            // 
            colTipoDato.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoDato.HeaderText = "Tipo de dato";
            colTipoDato.Name = "colTipoDato";
            colTipoDato.ReadOnly = true;
            colTipoDato.Resizable = DataGridViewTriState.False;
            colTipoDato.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEsNuevo
            // 
            colEsNuevo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colEsNuevo.HeaderText = "Nuevo";
            colEsNuevo.Name = "colEsNuevo";
            colEsNuevo.ReadOnly = true;
            colEsNuevo.Resizable = DataGridViewTriState.False;
            colEsNuevo.Visible = false;
            colEsNuevo.Width = 48;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(brnCrearBIN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SinSala-BN 2K24 -= by CARP =-";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBIN).EndInit();
            popUp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtArchivo;
        private Button btnArchivo;
        private GroupBox groupBox2;
        private DataGridView dgvBIN;
        private Button brnCrearBIN;
        private ContextMenuStrip popUp;
        private ToolStripMenuItem tsInsertarGrafico;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsInsertarBIN;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsInsertarPaleta;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsInsertarPaletaBIN;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsInsertarRAW;
        private ToolStripSeparator toolStripSeparator5;
        private DataGridViewTextBoxColumn colIndice;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colVRAMx;
        private DataGridViewTextBoxColumn colVRAMy;
        private DataGridViewTextBoxColumn colAncho;
        private DataGridViewTextBoxColumn colAlto;
        private DataGridViewTextBoxColumn colSize;
        private DataGridViewTextBoxColumn colOffset;
        private DataGridViewTextBoxColumn colTam;
        private DataGridViewTextBoxColumn colTipoDato;
        private DataGridViewCheckBoxColumn colEsNuevo;
    }
}
