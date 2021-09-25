
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
            this.LV_SListo = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LV_SBloq = new System.Windows.Forms.ListView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LV_Bloq = new System.Windows.Forms.ListView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LV_Listo = new System.Windows.Forms.ListView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LVFin = new System.Windows.Forms.ListView();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Tiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // LV_SListo
            // 
            this.LV_SListo.HideSelection = false;
            this.LV_SListo.Location = new System.Drawing.Point(750, 116);
            this.LV_SListo.Name = "LV_SListo";
            this.LV_SListo.Size = new System.Drawing.Size(244, 280);
            this.LV_SListo.TabIndex = 0;
            this.LV_SListo.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(750, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Suspendido Listo";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(750, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(244, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Suspendido bloqueado";
            // 
            // LV_SBloq
            // 
            this.LV_SBloq.HideSelection = false;
            this.LV_SBloq.Location = new System.Drawing.Point(750, 449);
            this.LV_SBloq.Name = "LV_SBloq";
            this.LV_SBloq.Size = new System.Drawing.Size(244, 280);
            this.LV_SBloq.TabIndex = 2;
            this.LV_SBloq.UseCompatibleStateImageBehavior = false;
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
            // LV_Bloq
            // 
            this.LV_Bloq.HideSelection = false;
            this.LV_Bloq.Location = new System.Drawing.Point(472, 449);
            this.LV_Bloq.Name = "LV_Bloq";
            this.LV_Bloq.Size = new System.Drawing.Size(244, 280);
            this.LV_Bloq.TabIndex = 6;
            this.LV_Bloq.UseCompatibleStateImageBehavior = false;
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
            // LV_Listo
            // 
            this.LV_Listo.HideSelection = false;
            this.LV_Listo.Location = new System.Drawing.Point(472, 116);
            this.LV_Listo.Name = "LV_Listo";
            this.LV_Listo.Size = new System.Drawing.Size(244, 280);
            this.LV_Listo.TabIndex = 4;
            this.LV_Listo.UseCompatibleStateImageBehavior = false;
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
            // LVFin
            // 
            this.LVFin.HideSelection = false;
            this.LVFin.Location = new System.Drawing.Point(1021, 116);
            this.LVFin.Name = "LVFin";
            this.LVFin.Size = new System.Drawing.Size(244, 613);
            this.LVFin.TabIndex = 8;
            this.LVFin.UseCompatibleStateImageBehavior = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(71, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(244, 38);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Proceso actual";
            // 
            // DGV_Actual
            // 
            this.DGV_Actual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Actual.Location = new System.Drawing.Point(71, 203);
            this.DGV_Actual.Name = "DGV_Actual";
            this.DGV_Actual.Size = new System.Drawing.Size(244, 49);
            this.DGV_Actual.TabIndex = 11;
            // 
            // CB_Algoritmo
            // 
            this.CB_Algoritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Algoritmo.FormattingEnabled = true;
            this.CB_Algoritmo.Items.AddRange(new object[] {
            "FIFO",
            "SJN",
            "Round Robin",
            "SRT"});
            this.CB_Algoritmo.Location = new System.Drawing.Point(71, 69);
            this.CB_Algoritmo.Name = "CB_Algoritmo";
            this.CB_Algoritmo.Size = new System.Drawing.Size(244, 39);
            this.CB_Algoritmo.TabIndex = 12;
            this.CB_Algoritmo.Text = "FIFO";
            // 
            // TB_NProc
            // 
            this.TB_NProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NProc.Location = new System.Drawing.Point(71, 462);
            this.TB_NProc.Name = "TB_NProc";
            this.TB_NProc.Size = new System.Drawing.Size(244, 38);
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
            this.CB_Prior.Location = new System.Drawing.Point(71, 619);
            this.CB_Prior.Name = "CB_Prior";
            this.CB_Prior.Size = new System.Drawing.Size(244, 39);
            this.CB_Prior.TabIndex = 14;
            this.CB_Prior.Text = "Low";
            // 
            // SP_Tiempo
            // 
            this.SP_Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP_Tiempo.Location = new System.Drawing.Point(71, 542);
            this.SP_Tiempo.Name = "SP_Tiempo";
            this.SP_Tiempo.Size = new System.Drawing.Size(244, 38);
            this.SP_Tiempo.TabIndex = 15;
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
            this.labelPrefab2.Location = new System.Drawing.Point(66, 433);
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
            this.labelPrefab3.Location = new System.Drawing.Point(66, 513);
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
            this.labelPrefab4.Location = new System.Drawing.Point(66, 590);
            this.labelPrefab4.Name = "labelPrefab4";
            this.labelPrefab4.Size = new System.Drawing.Size(104, 26);
            this.labelPrefab4.TabIndex = 19;
            this.labelPrefab4.Text = "Prioridad";
            // 
            // botonThicc1
            // 
            this.botonThicc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonThicc1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic);
            this.botonThicc1.Location = new System.Drawing.Point(71, 682);
            this.botonThicc1.Name = "botonThicc1";
            this.botonThicc1.Size = new System.Drawing.Size(244, 47);
            this.botonThicc1.TabIndex = 20;
            this.botonThicc1.Text = "Agregar Proceso";
            this.botonThicc1.UseVisualStyleBackColor = false;
            // 
            // botonThicc2
            // 
            this.botonThicc2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonThicc2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic);
            this.botonThicc2.Location = new System.Drawing.Point(71, 281);
            this.botonThicc2.Name = "botonThicc2";
            this.botonThicc2.Size = new System.Drawing.Size(244, 69);
            this.botonThicc2.TabIndex = 21;
            this.botonThicc2.Text = "Agregar Procesos \r\n(10 aleatorios)";
            this.botonThicc2.UseVisualStyleBackColor = false;
            // 
            // labelPrefab5
            // 
            this.labelPrefab5.AutoSize = true;
            this.labelPrefab5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab5.ForeColor = System.Drawing.Color.Black;
            this.labelPrefab5.Location = new System.Drawing.Point(66, 369);
            this.labelPrefab5.Name = "labelPrefab5";
            this.labelPrefab5.Size = new System.Drawing.Size(200, 52);
            this.labelPrefab5.TabIndex = 22;
            this.labelPrefab5.Text = "Agregar procesos \r\nmanualmente";
            // 
            // botonThicc3
            // 
            this.botonThicc3.BackColor = System.Drawing.Color.LawnGreen;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 789);
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
            this.Controls.Add(this.LVFin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LV_Bloq);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LV_Listo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LV_SBloq);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LV_SListo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Administrador de procesos Fake";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Tiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_SListo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView LV_SBloq;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView LV_Bloq;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView LV_Listo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListView LVFin;
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
    }
}

