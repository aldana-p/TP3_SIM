namespace TP3_SIM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grdMontecarlo = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTipoDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndCantidadDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPerdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoRecup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtOferta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMontecarlo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOferta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMontecarlo
            // 
            this.grdMontecarlo.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMontecarlo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.rndTipoDemanda,
            this.tipoDemanda,
            this.rndCantidadDemanda,
            this.cantDemanda,
            this.oferta,
            this.sobrante,
            this.costoFabricacion,
            this.costoPerdida,
            this.costoTotal,
            this.ingresoVenta,
            this.ingresoRecup,
            this.ingresoTotal,
            this.ganancia,
            this.gananciaAcum});
            this.grdMontecarlo.Location = new System.Drawing.Point(421, 53);
            this.grdMontecarlo.Name = "grdMontecarlo";
            this.grdMontecarlo.RowHeadersWidth = 10;
            this.grdMontecarlo.RowTemplate.Height = 24;
            this.grdMontecarlo.Size = new System.Drawing.Size(728, 453);
            this.grdMontecarlo.TabIndex = 0;
            // 
            // dia
            // 
            this.dia.HeaderText = "Día";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.Width = 125;
            // 
            // rndTipoDemanda
            // 
            this.rndTipoDemanda.HeaderText = "RND Tipo Demanda";
            this.rndTipoDemanda.MinimumWidth = 6;
            this.rndTipoDemanda.Name = "rndTipoDemanda";
            this.rndTipoDemanda.Width = 125;
            // 
            // tipoDemanda
            // 
            this.tipoDemanda.HeaderText = "Tipo Demanda";
            this.tipoDemanda.MinimumWidth = 6;
            this.tipoDemanda.Name = "tipoDemanda";
            this.tipoDemanda.Width = 125;
            // 
            // rndCantidadDemanda
            // 
            this.rndCantidadDemanda.HeaderText = "RND Cant. Demanda";
            this.rndCantidadDemanda.MinimumWidth = 6;
            this.rndCantidadDemanda.Name = "rndCantidadDemanda";
            this.rndCantidadDemanda.Width = 125;
            // 
            // cantDemanda
            // 
            this.cantDemanda.HeaderText = "Cant. Demanda";
            this.cantDemanda.MinimumWidth = 6;
            this.cantDemanda.Name = "cantDemanda";
            this.cantDemanda.Width = 125;
            // 
            // oferta
            // 
            this.oferta.HeaderText = "Oferta";
            this.oferta.MinimumWidth = 6;
            this.oferta.Name = "oferta";
            this.oferta.Width = 125;
            // 
            // sobrante
            // 
            this.sobrante.HeaderText = "Sobrante";
            this.sobrante.MinimumWidth = 6;
            this.sobrante.Name = "sobrante";
            this.sobrante.Width = 125;
            // 
            // costoFabricacion
            // 
            this.costoFabricacion.HeaderText = "Costo fabricación";
            this.costoFabricacion.MinimumWidth = 6;
            this.costoFabricacion.Name = "costoFabricacion";
            this.costoFabricacion.Width = 125;
            // 
            // costoPerdida
            // 
            this.costoPerdida.HeaderText = "Costo de pérdida";
            this.costoPerdida.MinimumWidth = 6;
            this.costoPerdida.Name = "costoPerdida";
            this.costoPerdida.Width = 125;
            // 
            // costoTotal
            // 
            this.costoTotal.HeaderText = "Costo Total";
            this.costoTotal.MinimumWidth = 6;
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Width = 125;
            // 
            // ingresoVenta
            // 
            this.ingresoVenta.HeaderText = "Ingreso Venta";
            this.ingresoVenta.MinimumWidth = 6;
            this.ingresoVenta.Name = "ingresoVenta";
            this.ingresoVenta.Width = 125;
            // 
            // ingresoRecup
            // 
            this.ingresoRecup.HeaderText = "Ingreso Recup.";
            this.ingresoRecup.MinimumWidth = 6;
            this.ingresoRecup.Name = "ingresoRecup";
            this.ingresoRecup.Width = 125;
            // 
            // ingresoTotal
            // 
            this.ingresoTotal.HeaderText = "Ingreso Total";
            this.ingresoTotal.MinimumWidth = 6;
            this.ingresoTotal.Name = "ingresoTotal";
            this.ingresoTotal.Width = 125;
            // 
            // ganancia
            // 
            this.ganancia.HeaderText = "Ganancia";
            this.ganancia.MinimumWidth = 6;
            this.ganancia.Name = "ganancia";
            this.ganancia.Width = 125;
            // 
            // gananciaAcum
            // 
            this.gananciaAcum.HeaderText = "Ganancia AC";
            this.gananciaAcum.MinimumWidth = 6;
            this.gananciaAcum.Name = "gananciaAcum";
            this.gananciaAcum.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.txtOferta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetro";
            // 
            // btnSimular
            // 
            this.btnSimular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSimular.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimular.Location = new System.Drawing.Point(188, 92);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(140, 45);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtOferta
            // 
            this.txtOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOferta.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtOferta.Location = new System.Drawing.Point(224, 39);
            this.txtOferta.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(92, 24);
            this.txtOferta.TabIndex = 1;
            this.txtOferta.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cant. de facturas ofertadas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(68, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.LightPink;
            this.txtResultado.Location = new System.Drawing.Point(141, 53);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(127, 26);
            this.txtResultado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ganancia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(52, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "VENTA DE FACTURAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdMontecarlo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.grdMontecarlo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOferta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMontecarlo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.NumericUpDown txtOferta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTipoDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndCantidadDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoFabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPerdida;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoRecup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaAcum;
        private System.Windows.Forms.Label label3;
    }
}

