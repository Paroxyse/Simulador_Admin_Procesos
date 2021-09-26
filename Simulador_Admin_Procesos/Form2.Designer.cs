
namespace Simulador_Admin_Procesos
{
    partial class Form2
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DVG_datos = new System.Windows.Forms.DataGridView();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ind_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVG_stats = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPrefab1 = new LibComponentes.labelPrefab();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_stats)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(244, 38);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Historial";
            // 
            // DVG_datos
            // 
            this.DVG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proceso,
            this.ti,
            this.t,
            this.tf,
            this.Ts,
            this.Wt,
            this.Ind_s});
            this.DVG_datos.Location = new System.Drawing.Point(12, 78);
            this.DVG_datos.Name = "DVG_datos";
            this.DVG_datos.Size = new System.Drawing.Size(731, 229);
            this.DVG_datos.TabIndex = 7;
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            this.Proceso.ReadOnly = true;
            // 
            // ti
            // 
            this.ti.HeaderText = "Instante de llegada";
            this.ti.Name = "ti";
            this.ti.ReadOnly = true;
            // 
            // t
            // 
            this.t.HeaderText = "Tiempo de ejecución";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            // 
            // tf
            // 
            this.tf.HeaderText = "Instante de fin";
            this.tf.Name = "tf";
            this.tf.ReadOnly = true;
            // 
            // Ts
            // 
            this.Ts.HeaderText = "Tiempo de servicio";
            this.Ts.Name = "Ts";
            this.Ts.ReadOnly = true;
            // 
            // Wt
            // 
            this.Wt.HeaderText = "Tiempo de espera";
            this.Wt.Name = "Wt";
            this.Wt.ReadOnly = true;
            // 
            // Ind_s
            // 
            this.Ind_s.HeaderText = "Índice de servicio";
            this.Ind_s.Name = "Ind_s";
            this.Ind_s.ReadOnly = true;
            // 
            // DVG_stats
            // 
            this.DVG_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.DVG_stats.Location = new System.Drawing.Point(400, 313);
            this.DVG_stats.Name = "DVG_stats";
            this.DVG_stats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DVG_stats.Size = new System.Drawing.Size(343, 54);
            this.DVG_stats.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiempo de servicio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tiempo de espera";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Índice de servicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // labelPrefab1
            // 
            this.labelPrefab1.AutoSize = true;
            this.labelPrefab1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrefab1.Location = new System.Drawing.Point(253, 329);
            this.labelPrefab1.Name = "labelPrefab1";
            this.labelPrefab1.Size = new System.Drawing.Size(122, 26);
            this.labelPrefab1.TabIndex = 9;
            this.labelPrefab1.Text = "Promedios";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrefab1);
            this.Controls.Add(this.DVG_stats);
            this.Controls.Add(this.DVG_datos);
            this.Controls.Add(this.textBox4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DVG_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_stats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView DVG_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ti;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ind_s;
        private System.Windows.Forms.DataGridView DVG_stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private LibComponentes.labelPrefab labelPrefab1;
    }
}