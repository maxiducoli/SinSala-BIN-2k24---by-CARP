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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtArchivo = new TextBox();
            btnArchivo = new Button();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            btnSetear = new Button();
            txtSizePal = new TextBox();
            txtVRAMyPal = new TextBox();
            txtVRAMxPal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            txtAncho = new TextBox();
            txtAlto = new TextBox();
            btnObetener = new Button();
            txtVRAMy = new TextBox();
            txtVRAMx = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvBIN = new DataGridView();
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
            popUp = new ContextMenuStrip(components);
            tsInsertarRAWbmp = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            tsInsertarRAWbin = new ToolStripMenuItem();
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
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBIN).BeginInit();
            popUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArchivo);
            groupBox1.Controls.Add(btnArchivo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Archivo";
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(6, 22);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(624, 23);
            txtArchivo.TabIndex = 1;
            // 
            // btnArchivo
            // 
            btnArchivo.Location = new Point(638, 21);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(75, 23);
            btnArchivo.TabIndex = 0;
            btnArchivo.Text = "&Archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvBIN);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(726, 411);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Composición del BIN";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(btnSetear);
            groupBox4.Controls.Add(txtSizePal);
            groupBox4.Controls.Add(txtVRAMyPal);
            groupBox4.Controls.Add(txtVRAMxPal);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(519, 237);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(194, 168);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Alterar datos paleta";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(8, 105);
            label8.Name = "label8";
            label8.Size = new Size(186, 60);
            label8.TabIndex = 13;
            // 
            // btnSetear
            // 
            btnSetear.Location = new Point(16, 77);
            btnSetear.Name = "btnSetear";
            btnSetear.Size = new Size(158, 25);
            btnSetear.TabIndex = 8;
            btnSetear.Text = "Cambiar datos";
            btnSetear.UseVisualStyleBackColor = true;
            btnSetear.Click += btnSetear_Click;
            // 
            // txtSizePal
            // 
            txtSizePal.Location = new Point(124, 48);
            txtSizePal.Name = "txtSizePal";
            txtSizePal.Size = new Size(50, 23);
            txtSizePal.TabIndex = 12;
            // 
            // txtVRAMyPal
            // 
            txtVRAMyPal.Location = new Point(72, 48);
            txtVRAMyPal.Name = "txtVRAMyPal";
            txtVRAMyPal.Size = new Size(46, 23);
            txtVRAMyPal.TabIndex = 11;
            // 
            // txtVRAMxPal
            // 
            txtVRAMxPal.Location = new Point(16, 48);
            txtVRAMxPal.Name = "txtVRAMxPal";
            txtVRAMxPal.Size = new Size(50, 23);
            txtVRAMxPal.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 30);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "Tamaño";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 30);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 8;
            label6.Text = "VRAMy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 30);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 7;
            label7.Text = "VRAMx";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAncho);
            groupBox3.Controls.Add(txtAlto);
            groupBox3.Controls.Add(btnObetener);
            groupBox3.Controls.Add(txtVRAMy);
            groupBox3.Controls.Add(txtVRAMx);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(519, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(194, 202);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alterar datos imagen";
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(125, 87);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(48, 23);
            txtAncho.TabIndex = 7;
            // 
            // txtAlto
            // 
            txtAlto.Location = new Point(33, 87);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(50, 23);
            txtAlto.TabIndex = 6;
            // 
            // btnObetener
            // 
            btnObetener.Location = new Point(33, 116);
            btnObetener.Name = "btnObetener";
            btnObetener.Size = new Size(140, 25);
            btnObetener.TabIndex = 2;
            btnObetener.Text = "Cambiar datos";
            btnObetener.UseVisualStyleBackColor = true;
            btnObetener.Click += btnObetener_Click;
            // 
            // txtVRAMy
            // 
            txtVRAMy.Location = new Point(125, 42);
            txtVRAMy.Name = "txtVRAMy";
            txtVRAMy.Size = new Size(48, 23);
            txtVRAMy.TabIndex = 5;
            // 
            // txtVRAMx
            // 
            txtVRAMx.Location = new Point(33, 43);
            txtVRAMx.Name = "txtVRAMx";
            txtVRAMx.Size = new Size(50, 23);
            txtVRAMx.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 69);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Ancho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 69);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Alto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 24);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "VRAMy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "VRAMx";
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
            dgvBIN.Size = new Size(507, 383);
            dgvBIN.TabIndex = 0;
            dgvBIN.CellClick += dgvBIN_CellClick;
            dgvBIN.MouseDown += dgvBIN_MouseDown;
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
            // 
            // popUp
            // 
            popUp.Items.AddRange(new ToolStripItem[] { tsInsertarRAWbmp, toolStripSeparator6, tsInsertarRAWbin, toolStripSeparator5, tsInsertarGrafico, toolStripSeparator1, tsInsertarBIN, toolStripSeparator2, tsInsertarPaleta, toolStripSeparator3, tsInsertarPaletaBIN, toolStripSeparator4 });
            popUp.Name = "popUp";
            popUp.Size = new Size(238, 172);
            // 
            // tsInsertarRAWbmp
            // 
            tsInsertarRAWbmp.Name = "tsInsertarRAWbmp";
            tsInsertarRAWbmp.Size = new Size(237, 22);
            tsInsertarRAWbmp.Text = "Insertar RAW BMP";
            tsInsertarRAWbmp.Click += tsInsertarRAWbmp_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(234, 6);
            // 
            // tsInsertarRAWbin
            // 
            tsInsertarRAWbin.Name = "tsInsertarRAWbin";
            tsInsertarRAWbin.Size = new Size(237, 22);
            tsInsertarRAWbin.Text = "Insertar gráfico RAW ";
            tsInsertarRAWbin.Click += tsInsertarRAW_Click;
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
            brnCrearBIN.Location = new Point(355, 505);
            brnCrearBIN.Name = "brnCrearBIN";
            brnCrearBIN.Size = new Size(75, 23);
            brnCrearBIN.TabIndex = 2;
            brnCrearBIN.Text = "&Crer BIN";
            brnCrearBIN.UseVisualStyleBackColor = true;
            brnCrearBIN.Click += btnCrearBIN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 502);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(66, 513);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(270, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ayúdame con un cafecito - Help me with a coffee";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 537);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(brnCrearBIN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SinSala-BN 2K24 -= by CARP =- @maxiducoli";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBIN).EndInit();
            popUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem tsInsertarRAWbin;
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
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtSizePal;
        private TextBox txtVRAMyPal;
        private TextBox txtVRAMxPal;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnObetener;
        private Button btnSetear;
        private TextBox txtAncho;
        private TextBox txtAlto;
        private TextBox txtVRAMy;
        private TextBox txtVRAMx;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem tsInsertarRAWbmp;
        private ToolStripSeparator toolStripSeparator6;
        private Label label8;
    }
}
