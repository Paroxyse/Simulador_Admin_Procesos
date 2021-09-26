
namespace Simulador_Admin_Procesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DGV_Actual = new System.Windows.Forms.DataGridView();
            this.CB_Algoritmo = new System.Windows.Forms.ComboBox();
            this.TB_NProc = new System.Windows.Forms.TextBox();
            this.CB_Prior = new System.Windows.Forms.ComboBox();
            this.SP_Tiempo = new System.Windows.Forms.NumericUpDown();
            this.labelPrefab1 = new LibComponentes.labelPrefab();
            this.labelPrefab2 = new LibComponentes.labelPrefab();
            this.labelPrefab3 = new LibComponentes.labelPrefab();
            this.labelPrefab4 = new LibComponentes.labelPrefab();
            this.botonThicc1 = new LibComponentes.BotonThicc();
            this.botonThicc2 = new LibComponentes.BotonThicc();
            this.labelPrefab5 = new LibComponentes.labelPrefab();
            this.botonThicc3 = new LibComponentes.BotonThicc();
            this.labelPrefab6 = new LibComponentes.labelPrefab();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblCrn = new LibComponentes.labelPrefab();
            this.DGV_L = new System.Windows.Forms.DataGridView();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_B = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_SL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_SB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_T = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPN_Quantum = new System.Windows.Forms.NumericUpDown();
            this.Quantum = new LibComponentes.labelPrefab();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Tiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_T)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPN_Quantum)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(750, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Suspendido Listo";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(750, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(244, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Suspendido bloqueado";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(472, 405);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(244, 38);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Bloqueado";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(472, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(244, 38);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Listo";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(1021, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(244, 38);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Terminado";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(71, 185);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(244, 38);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Proceso actual";
            // 
            // DGV_Actual
            // 
            this.DGV_Actual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Actual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr,
            this.Tr,
            this.Pri});
            this.DGV_Actual.Location = new System.Drawing.Point(71, 249);
            this.DGV_Actual.Name = "DGV_Actual";
            this.DGV_Actual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Actual.Size = new System.Drawing.Size(253, 59);
            this.DGV_Actual.TabIndex = 11;
            // 
            // CB_Algoritmo
            // 
            this.CB_Algoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Algoritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Algoritmo.FormattingEnabled = true;
            this.CB_Algoritmo.Items.AddRange(new object[] {
            "FIFO",
            "Round Robin",
            "Tiempo más corto"});
            this.CB_Algoritmo.Location = new System.Drawing.Point(71, 69);
            this.CB_Algoritmo.Name = "CB_Algoritmo";
            this.CB_Algoritmo.Size = new System.Drawing.Size(244, 39);
            this.CB_Algoritmo.TabIndex = 12;
            this.CB_Algoritmo.SelectedIndexChanged += new System.EventHandler(this.CB_Algoritmo_SelectedIndexChanged);
            // 
            // TB_NProc
            // 
            this.TB_NProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NProc.Location = new System.Drawing.Point(71, 529);
            this.TB_NProc.Name = "TB_NProc";
            this.TB_NProc.Size = new System.Drawing.Size(99, 38);
            this.TB_NProc.TabIndex = 13;
            // 
            // CB_Prior
            // 
            this.CB_Prior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Prior.FormattingEnabled = true;
            this.CB_Prior.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.CB_Prior.Location = new System.Drawing.Point(71, 679);
            this.CB_Prior.Name = "CB_Prior";
            this.CB_Prior.Size = new System.Drawing.Size(99, 39);
            this.CB_Prior.TabIndex = 14;
            this.CB_Prior.Text = "Low";
            // 
            // SP_Tiempo
            // 
            this.SP_Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP_Tiempo.Location = new System.Drawing.Point(71, 602);
            this.SP_Tiempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SP_Tiempo.Name = "SP_Tiempo";
            this.SP_Tiempo.Size = new System.Drawing.Size(99, 38);
            this.SP_Tiempo.TabIndex = 15;
            this.SP_Tiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPrefab1
            // 
            this.labelPrefab1.AutoSize = true;
            this.labelPrefab1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab1.Location = new System.Drawing.Point(66, 40);
            this.labelPrefab1.Name = "labelPrefab1";
            this.labelPrefab1.Size = new System.Drawing.Size(110, 26);
            this.labelPrefab1.TabIndex = 16;
            this.labelPrefab1.Text = "Algoritmo";
            // 
            // labelPrefab2
            // 
            this.labelPrefab2.AutoSize = true;
            this.labelPrefab2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab2.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrefab2.Location = new System.Drawing.Point(66, 500);
            this.labelPrefab2.Name = "labelPrefab2";
            this.labelPrefab2.Size = new System.Drawing.Size(218, 26);
            this.labelPrefab2.TabIndex = 17;
            this.labelPrefab2.Text = "Nombre del proceso";
            // 
            // labelPrefab3
            // 
            this.labelPrefab3.AutoSize = true;
            this.labelPrefab3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab3.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrefab3.Location = new System.Drawing.Point(66, 573);
            this.labelPrefab3.Name = "labelPrefab3";
            this.labelPrefab3.Size = new System.Drawing.Size(192, 26);
            this.labelPrefab3.TabIndex = 18;
            this.labelPrefab3.Text = "Tiempo requerido";
            // 
            // labelPrefab4
            // 
            this.labelPrefab4.AutoSize = true;
            this.labelPrefab4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab4.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrefab4.Location = new System.Drawing.Point(66, 650);
            this.labelPrefab4.Name = "labelPrefab4";
            this.labelPrefab4.Size = new System.Drawing.Size(104, 26);
            this.labelPrefab4.TabIndex = 19;
            this.labelPrefab4.Text = "Prioridad";
            // 
            // botonThicc1
            // 
            this.botonThicc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonThicc1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic);
            this.botonThicc1.Location = new System.Drawing.Point(235, 671);
            this.botonThicc1.Name = "botonThicc1";
            this.botonThicc1.Size = new System.Drawing.Size(123, 47);
            this.botonThicc1.TabIndex = 20;
            this.botonThicc1.Text = "Agregar Proceso";
            this.botonThicc1.UseVisualStyleBackColor = false;
            this.botonThicc1.Click += new System.EventHandler(this.botonThicc1_Click);
            // 
            // botonThicc2
            // 
            this.botonThicc2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonThicc2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic);
            this.botonThicc2.Location = new System.Drawing.Point(71, 339);
            this.botonThicc2.Name = "botonThicc2";
            this.botonThicc2.Size = new System.Drawing.Size(213, 69);
            this.botonThicc2.TabIndex = 21;
            this.botonThicc2.Text = "Agregar Procesos \r\n(10 aleatorios)";
            this.botonThicc2.UseVisualStyleBackColor = false;
            this.botonThicc2.Click += new System.EventHandler(this.botonThicc2_Click);
            // 
            // labelPrefab5
            // 
            this.labelPrefab5.AutoSize = true;
            this.labelPrefab5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab5.ForeColor = System.Drawing.Color.Black;
            this.labelPrefab5.Location = new System.Drawing.Point(66, 436);
            this.labelPrefab5.Name = "labelPrefab5";
            this.labelPrefab5.Size = new System.Drawing.Size(200, 52);
            this.labelPrefab5.TabIndex = 22;
            this.labelPrefab5.Text = "Agregar procesos \r\nmanualmente";
            // 
            // botonThicc3
            // 
            this.botonThicc3.BackColor = System.Drawing.Color.DarkRed;
            this.botonThicc3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic);
            this.botonThicc3.Location = new System.Drawing.Point(360, 61);
            this.botonThicc3.Name = "botonThicc3";
            this.botonThicc3.Size = new System.Drawing.Size(52, 49);
            this.botonThicc3.TabIndex = 23;
            this.botonThicc3.UseVisualStyleBackColor = false;
            this.botonThicc3.Click += new System.EventHandler(this.botonThicc3_Click);
            // 
            // labelPrefab6
            // 
            this.labelPrefab6.AutoSize = true;
            this.labelPrefab6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab6.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrefab6.Location = new System.Drawing.Point(288, 32);
            this.labelPrefab6.Name = "labelPrefab6";
            this.labelPrefab6.Size = new System.Drawing.Size(197, 26);
            this.labelPrefab6.TabIndex = 24;
            this.labelPrefab6.Text = "Detener/Reanudar";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblCrn
            // 
            this.lblCrn.AutoSize = true;
            this.lblCrn.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrn.Location = new System.Drawing.Point(1016, 29);
            this.lblCrn.Name = "lblCrn";
            this.lblCrn.Size = new System.Drawing.Size(70, 27);
            this.lblCrn.TabIndex = 25;
            this.lblCrn.Text = "00:00";
            // 
            // DGV_L
            // 
            this.DGV_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_L.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proceso,
            this.TiempoR,
            this.Prioridad});
            this.DGV_L.Location = new System.Drawing.Point(472, 116);
            this.DGV_L.Name = "DGV_L";
            this.DGV_L.Size = new System.Drawing.Size(244, 272);
            this.DGV_L.TabIndex = 26;
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            this.Proceso.ReadOnly = true;
            this.Proceso.Width = 71;
            // 
            // TiempoR
            // 
            this.TiempoR.HeaderText = "Tiempo Restante";
            this.TiempoR.Name = "TiempoR";
            this.TiempoR.Width = 71;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 69;
            // 
            // DGV_B
            // 
            this.DGV_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_B.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DGV_B.Location = new System.Drawing.Point(750, 116);
            this.DGV_B.Name = "DGV_B";
            this.DGV_B.Size = new System.Drawing.Size(244, 272);
            this.DGV_B.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tiempo Restante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prioridad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // DGV_SL
            // 
            this.DGV_SL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DGV_SL.Location = new System.Drawing.Point(472, 449);
            this.DGV_SL.Name = "DGV_SL";
            this.DGV_SL.Size = new System.Drawing.Size(244, 272);
            this.DGV_SL.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiempo Restante";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 71;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Prioridad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 69;
            // 
            // DGV_SB
            // 
            this.DGV_SB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.DGV_SB.Location = new System.Drawing.Point(750, 449);
            this.DGV_SB.Name = "DGV_SB";
            this.DGV_SB.Size = new System.Drawing.Size(244, 272);
            this.DGV_SB.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 71;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tiempo Restante";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 71;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Prioridad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 69;
            // 
            // DGV_T
            // 
            this.DGV_T.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_T.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.DGV_T.Location = new System.Drawing.Point(1021, 116);
            this.DGV_T.Name = "DGV_T";
            this.DGV_T.Size = new System.Drawing.Size(244, 605);
            this.DGV_T.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 71;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Tiempo Restante";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 71;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Prioridad";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 69;
            // 
            // pr
            // 
            this.pr.HeaderText = "Proceso";
            this.pr.Name = "pr";
            this.pr.ReadOnly = true;
            this.pr.Width = 70;
            // 
            // Tr
            // 
            this.Tr.HeaderText = "Tiempo Restante";
            this.Tr.Name = "Tr";
            this.Tr.ReadOnly = true;
            this.Tr.Width = 70;
            // 
            // Pri
            // 
            this.Pri.HeaderText = "Prioridad";
            this.Pri.Name = "Pri";
            this.Pri.ReadOnly = true;
            this.Pri.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reporteDetalladoDeProcesosTerminadosToolStripMenuItem
            // 
            this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem.Name = "reporteDetalladoDeProcesosTerminadosToolStripMenuItem";
            this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem.Size = new System.Drawing.Size(241, 20);
            this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem.Text = "Reporte detallado de procesos terminados";
            this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem.Click += new System.EventHandler(this.reporteDetalladoDeProcesosTerminadosToolStripMenuItem_Click);
            // 
            // SPN_Quantum
            // 
            this.SPN_Quantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPN_Quantum.Location = new System.Drawing.Point(185, 127);
            this.SPN_Quantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SPN_Quantum.Name = "SPN_Quantum";
            this.SPN_Quantum.Size = new System.Drawing.Size(99, 38);
            this.SPN_Quantum.TabIndex = 32;
            this.SPN_Quantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SPN_Quantum.Visible = false;
            this.SPN_Quantum.ValueChanged += new System.EventHandler(this.SPN_Quantum_ValueChanged);
            // 
            // Quantum
            // 
            this.Quantum.AutoSize = true;
            this.Quantum.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Quantum.ForeColor = System.Drawing.Color.DimGray;
            this.Quantum.Location = new System.Drawing.Point(110, 136);
            this.Quantum.Name = "Quantum";
            this.Quantum.Size = new System.Drawing.Size(42, 26);
            this.Quantum.TabIndex = 33;
            this.Quantum.Text = "Q=";
            this.Quantum.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(972, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(38, 52);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "💀";
            this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 789);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Quantum);
            this.Controls.Add(this.SPN_Quantum);
            this.Controls.Add(this.DGV_T);
            this.Controls.Add(this.DGV_SB);
            this.Controls.Add(this.DGV_SL);
            this.Controls.Add(this.DGV_B);
            this.Controls.Add(this.DGV_L);
            this.Controls.Add(this.lblCrn);
            this.Controls.Add(this.labelPrefab6);
            this.Controls.Add(this.botonThicc3);
            this.Controls.Add(this.labelPrefab5);
            this.Controls.Add(this.botonThicc2);
            this.Controls.Add(this.botonThicc1);
            this.Controls.Add(this.labelPrefab4);
            this.Controls.Add(this.labelPrefab3);
            this.Controls.Add(this.labelPrefab2);
            this.Controls.Add(this.labelPrefab1);
            this.Controls.Add(this.SP_Tiempo);
            this.Controls.Add(this.CB_Prior);
            this.Controls.Add(this.TB_NProc);
            this.Controls.Add(this.CB_Algoritmo);
            this.Controls.Add(this.DGV_Actual);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Administrador de procesos Fake";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Tiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_T)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPN_Quantum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView DGV_Actual;
        private System.Windows.Forms.ComboBox CB_Algoritmo;
        private System.Windows.Forms.TextBox TB_NProc;
        private System.Windows.Forms.ComboBox CB_Prior;
        private System.Windows.Forms.NumericUpDown SP_Tiempo;
        private LibComponentes.labelPrefab labelPrefab1;
        private LibComponentes.labelPrefab labelPrefab2;
        private LibComponentes.labelPrefab labelPrefab3;
        private LibComponentes.labelPrefab labelPrefab4;
        private LibComponentes.BotonThicc botonThicc1;
        private LibComponentes.BotonThicc botonThicc2;
        private LibComponentes.labelPrefab labelPrefab5;
        private LibComponentes.BotonThicc botonThicc3;
        private LibComponentes.labelPrefab labelPrefab6;
        private System.Windows.Forms.Timer Timer;
        private LibComponentes.labelPrefab lblCrn;
        private System.Windows.Forms.DataGridView DGV_L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridView DGV_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView DGV_SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView DGV_SB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView DGV_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pri;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteDetalladoDeProcesosTerminadosToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown SPN_Quantum;
        private LibComponentes.labelPrefab Quantum;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

