namespace TelaPrincipal
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPostos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.btnConsultarSegundo = new System.Windows.Forms.Button();
            this.btnConsultarPrimeiro = new System.Windows.Forms.Button();
            this.gbPersonalizado = new System.Windows.Forms.GroupBox();
            this.btnConsultaPersonalizada = new System.Windows.Forms.Button();
            this.tpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.tpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.tpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.tpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lbFinalConsulta = new System.Windows.Forms.Label();
            this.lbInicioConsulta = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.chkReteste = new System.Windows.Forms.CheckBox();
            this.rbConsultaRapida = new System.Windows.Forms.RadioButton();
            this.rbPersonalizado = new System.Windows.Forms.RadioButton();
            this.rbTurno = new System.Windows.Forms.RadioButton();
            this.lbSetup = new System.Windows.Forms.Label();
            this.lbRelatorio = new System.Windows.Forms.ListBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.gbQuantitativo = new System.Windows.Forms.GroupBox();
            this.gbFalhasTestador = new System.Windows.Forms.GroupBox();
            this.lbRelDetalhado = new System.Windows.Forms.ListBox();
            this.gbRelTestador = new System.Windows.Forms.GroupBox();
            this.lbRelTestador = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTurno.SuspendLayout();
            this.gbPersonalizado.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.gbQuantitativo.SuspendLayout();
            this.gbFalhasTestador.SuspendLayout();
            this.gbRelTestador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbTurno);
            this.panel1.Controls.Add(this.gbPersonalizado);
            this.panel1.Controls.Add(this.gbConsulta);
            this.panel1.Controls.Add(this.lbSetup);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 595);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPostos);
            this.groupBox2.Location = new System.Drawing.Point(13, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posto";
            // 
            // cbPostos
            // 
            this.cbPostos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostos.FormattingEnabled = true;
            this.cbPostos.Items.AddRange(new object[] {
            "AFI0",
            "AFI1",
            "WLAN",
            "OTA",
            "FINAL"});
            this.cbPostos.Location = new System.Drawing.Point(11, 20);
            this.cbPostos.Name = "cbPostos";
            this.cbPostos.Size = new System.Drawing.Size(218, 21);
            this.cbPostos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn60);
            this.groupBox1.Controls.Add(this.btn45);
            this.groupBox1.Controls.Add(this.btn30);
            this.groupBox1.Controls.Add(this.btn15);
            this.groupBox1.Location = new System.Drawing.Point(13, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta rápida";
            // 
            // btn60
            // 
            this.btn60.Enabled = false;
            this.btn60.Location = new System.Drawing.Point(127, 49);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(104, 23);
            this.btn60.TabIndex = 3;
            this.btn60.Text = "Últimos 60 minutos";
            this.btn60.UseVisualStyleBackColor = true;
            this.btn60.Click += new System.EventHandler(this.btnConsultaRapida_Click);
            // 
            // btn45
            // 
            this.btn45.Enabled = false;
            this.btn45.Location = new System.Drawing.Point(7, 49);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(104, 23);
            this.btn45.TabIndex = 2;
            this.btn45.Text = "Últimos 45 minutos";
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Click += new System.EventHandler(this.btnConsultaRapida_Click);
            // 
            // btn30
            // 
            this.btn30.Enabled = false;
            this.btn30.Location = new System.Drawing.Point(127, 20);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(104, 23);
            this.btn30.TabIndex = 1;
            this.btn30.Text = "Últimos 30 minutos";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btnConsultaRapida_Click);
            // 
            // btn15
            // 
            this.btn15.Enabled = false;
            this.btn15.Location = new System.Drawing.Point(7, 20);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(104, 23);
            this.btn15.TabIndex = 0;
            this.btn15.Text = "Últimos 15 minutos";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btnConsultaRapida_Click);
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.btnConsultarSegundo);
            this.gbTurno.Controls.Add(this.btnConsultarPrimeiro);
            this.gbTurno.Location = new System.Drawing.Point(13, 240);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(241, 55);
            this.gbTurno.TabIndex = 7;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Consultar turno";
            // 
            // btnConsultarSegundo
            // 
            this.btnConsultarSegundo.Location = new System.Drawing.Point(127, 20);
            this.btnConsultarSegundo.Name = "btnConsultarSegundo";
            this.btnConsultarSegundo.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarSegundo.TabIndex = 1;
            this.btnConsultarSegundo.Text = "Consultar 2º turno";
            this.btnConsultarSegundo.UseVisualStyleBackColor = true;
            this.btnConsultarSegundo.Click += new System.EventHandler(this.btnConsultarSegundo_Click);
            // 
            // btnConsultarPrimeiro
            // 
            this.btnConsultarPrimeiro.Location = new System.Drawing.Point(7, 20);
            this.btnConsultarPrimeiro.Name = "btnConsultarPrimeiro";
            this.btnConsultarPrimeiro.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarPrimeiro.TabIndex = 0;
            this.btnConsultarPrimeiro.Text = "Consultar 1º turno";
            this.btnConsultarPrimeiro.UseVisualStyleBackColor = true;
            this.btnConsultarPrimeiro.Click += new System.EventHandler(this.btnConsultarPrimeiro_Click);
            // 
            // gbPersonalizado
            // 
            this.gbPersonalizado.Controls.Add(this.btnConsultaPersonalizada);
            this.gbPersonalizado.Controls.Add(this.tpHoraFinal);
            this.gbPersonalizado.Controls.Add(this.tpDataFinal);
            this.gbPersonalizado.Controls.Add(this.tpHoraInicio);
            this.gbPersonalizado.Controls.Add(this.tpDataInicio);
            this.gbPersonalizado.Controls.Add(this.lbFinalConsulta);
            this.gbPersonalizado.Controls.Add(this.lbInicioConsulta);
            this.gbPersonalizado.Location = new System.Drawing.Point(13, 309);
            this.gbPersonalizado.Name = "gbPersonalizado";
            this.gbPersonalizado.Size = new System.Drawing.Size(241, 161);
            this.gbPersonalizado.TabIndex = 6;
            this.gbPersonalizado.TabStop = false;
            this.gbPersonalizado.Text = "Personalizado:";
            // 
            // btnConsultaPersonalizada
            // 
            this.btnConsultaPersonalizada.Enabled = false;
            this.btnConsultaPersonalizada.Location = new System.Drawing.Point(11, 125);
            this.btnConsultaPersonalizada.Name = "btnConsultaPersonalizada";
            this.btnConsultaPersonalizada.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaPersonalizada.TabIndex = 0;
            this.btnConsultaPersonalizada.Text = "Consultar";
            this.btnConsultaPersonalizada.UseVisualStyleBackColor = true;
            this.btnConsultaPersonalizada.Click += new System.EventHandler(this.btnConsultaPersonalizada_Click);
            // 
            // tpHoraFinal
            // 
            this.tpHoraFinal.Enabled = false;
            this.tpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpHoraFinal.Location = new System.Drawing.Point(122, 91);
            this.tpHoraFinal.Name = "tpHoraFinal";
            this.tpHoraFinal.ShowUpDown = true;
            this.tpHoraFinal.Size = new System.Drawing.Size(108, 20);
            this.tpHoraFinal.TabIndex = 7;
            // 
            // tpDataFinal
            // 
            this.tpDataFinal.Enabled = false;
            this.tpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpDataFinal.Location = new System.Drawing.Point(10, 91);
            this.tpDataFinal.Name = "tpDataFinal";
            this.tpDataFinal.ShowUpDown = true;
            this.tpDataFinal.Size = new System.Drawing.Size(105, 20);
            this.tpDataFinal.TabIndex = 6;
            // 
            // tpHoraInicio
            // 
            this.tpHoraInicio.Enabled = false;
            this.tpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpHoraInicio.Location = new System.Drawing.Point(121, 43);
            this.tpHoraInicio.Name = "tpHoraInicio";
            this.tpHoraInicio.ShowUpDown = true;
            this.tpHoraInicio.Size = new System.Drawing.Size(108, 20);
            this.tpHoraInicio.TabIndex = 5;
            // 
            // tpDataInicio
            // 
            this.tpDataInicio.Enabled = false;
            this.tpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpDataInicio.Location = new System.Drawing.Point(9, 43);
            this.tpDataInicio.Name = "tpDataInicio";
            this.tpDataInicio.ShowUpDown = true;
            this.tpDataInicio.Size = new System.Drawing.Size(106, 20);
            this.tpDataInicio.TabIndex = 1;
            // 
            // lbFinalConsulta
            // 
            this.lbFinalConsulta.AutoSize = true;
            this.lbFinalConsulta.Location = new System.Drawing.Point(8, 75);
            this.lbFinalConsulta.Name = "lbFinalConsulta";
            this.lbFinalConsulta.Size = new System.Drawing.Size(128, 13);
            this.lbFinalConsulta.TabIndex = 4;
            this.lbFinalConsulta.Text = "Período final de consulta:";
            // 
            // lbInicioConsulta
            // 
            this.lbInicioConsulta.AutoSize = true;
            this.lbInicioConsulta.Location = new System.Drawing.Point(8, 27);
            this.lbInicioConsulta.Name = "lbInicioConsulta";
            this.lbInicioConsulta.Size = new System.Drawing.Size(135, 13);
            this.lbInicioConsulta.TabIndex = 2;
            this.lbInicioConsulta.Text = "Período inicial de consulta:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.chkReteste);
            this.gbConsulta.Controls.Add(this.rbConsultaRapida);
            this.gbConsulta.Controls.Add(this.rbPersonalizado);
            this.gbConsulta.Controls.Add(this.rbTurno);
            this.gbConsulta.Location = new System.Drawing.Point(13, 105);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(241, 121);
            this.gbConsulta.TabIndex = 5;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta:";
            // 
            // chkReteste
            // 
            this.chkReteste.AutoSize = true;
            this.chkReteste.Location = new System.Drawing.Point(7, 94);
            this.chkReteste.Name = "chkReteste";
            this.chkReteste.Size = new System.Drawing.Size(94, 17);
            this.chkReteste.TabIndex = 3;
            this.chkReteste.Text = "Incluir retestes";
            this.chkReteste.UseVisualStyleBackColor = true;
            // 
            // rbConsultaRapida
            // 
            this.rbConsultaRapida.AutoSize = true;
            this.rbConsultaRapida.Location = new System.Drawing.Point(7, 66);
            this.rbConsultaRapida.Name = "rbConsultaRapida";
            this.rbConsultaRapida.Size = new System.Drawing.Size(98, 17);
            this.rbConsultaRapida.TabIndex = 2;
            this.rbConsultaRapida.Text = "Consulta rápida";
            this.rbConsultaRapida.UseVisualStyleBackColor = true;
            // 
            // rbPersonalizado
            // 
            this.rbPersonalizado.AutoSize = true;
            this.rbPersonalizado.Location = new System.Drawing.Point(7, 43);
            this.rbPersonalizado.Name = "rbPersonalizado";
            this.rbPersonalizado.Size = new System.Drawing.Size(131, 17);
            this.rbPersonalizado.TabIndex = 1;
            this.rbPersonalizado.Text = "Período personalizado";
            this.rbPersonalizado.UseVisualStyleBackColor = true;
            this.rbPersonalizado.CheckedChanged += new System.EventHandler(this.rbTurno_CheckedChanged);
            // 
            // rbTurno
            // 
            this.rbTurno.AutoSize = true;
            this.rbTurno.Checked = true;
            this.rbTurno.Location = new System.Drawing.Point(7, 20);
            this.rbTurno.Name = "rbTurno";
            this.rbTurno.Size = new System.Drawing.Size(53, 17);
            this.rbTurno.TabIndex = 0;
            this.rbTurno.TabStop = true;
            this.rbTurno.Text = "Turno";
            this.rbTurno.UseVisualStyleBackColor = true;
            this.rbTurno.CheckedChanged += new System.EventHandler(this.rbTurno_CheckedChanged);
            // 
            // lbSetup
            // 
            this.lbSetup.AutoSize = true;
            this.lbSetup.Location = new System.Drawing.Point(15, 11);
            this.lbSetup.Name = "lbSetup";
            this.lbSetup.Size = new System.Drawing.Size(118, 13);
            this.lbSetup.TabIndex = 0;
            this.lbSetup.Text = "Configure sua consulta:";
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRelatorio.BackColor = System.Drawing.Color.Linen;
            this.lbRelatorio.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelatorio.FormattingEnabled = true;
            this.lbRelatorio.HorizontalScrollbar = true;
            this.lbRelatorio.ItemHeight = 15;
            this.lbRelatorio.Items.AddRange(new object[] {
            "AGUARDANDO CONSULTA..."});
            this.lbRelatorio.Location = new System.Drawing.Point(6, 19);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(611, 139);
            this.lbRelatorio.TabIndex = 1;
            this.lbRelatorio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRelatorio_MouseDoubleClick_1);
            // 
            // lbAutor
            // 
            this.lbAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(674, 608);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(239, 16);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Desenvolvido por Gutto França";
            // 
            // gbQuantitativo
            // 
            this.gbQuantitativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuantitativo.Controls.Add(this.lbRelatorio);
            this.gbQuantitativo.Location = new System.Drawing.Point(290, 7);
            this.gbQuantitativo.Name = "gbQuantitativo";
            this.gbQuantitativo.Size = new System.Drawing.Size(623, 163);
            this.gbQuantitativo.TabIndex = 3;
            this.gbQuantitativo.TabStop = false;
            this.gbQuantitativo.Text = "Quantitativo de falhas:";
            // 
            // gbFalhasTestador
            // 
            this.gbFalhasTestador.Controls.Add(this.lbRelDetalhado);
            this.gbFalhasTestador.Location = new System.Drawing.Point(290, 173);
            this.gbFalhasTestador.Name = "gbFalhasTestador";
            this.gbFalhasTestador.Size = new System.Drawing.Size(623, 168);
            this.gbFalhasTestador.TabIndex = 4;
            this.gbFalhasTestador.TabStop = false;
            this.gbFalhasTestador.Text = "Relatório detalhado";
            // 
            // lbRelDetalhado
            // 
            this.lbRelDetalhado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRelDetalhado.BackColor = System.Drawing.Color.Linen;
            this.lbRelDetalhado.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelDetalhado.FormattingEnabled = true;
            this.lbRelDetalhado.HorizontalScrollbar = true;
            this.lbRelDetalhado.ItemHeight = 15;
            this.lbRelDetalhado.Items.AddRange(new object[] {
            "AGUARDANDO CONSULTA..."});
            this.lbRelDetalhado.Location = new System.Drawing.Point(7, 20);
            this.lbRelDetalhado.Name = "lbRelDetalhado";
            this.lbRelDetalhado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRelDetalhado.Size = new System.Drawing.Size(611, 139);
            this.lbRelDetalhado.TabIndex = 0;
            this.lbRelDetalhado.TabStop = false;
            this.lbRelDetalhado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRelDetalhado_MouseDoubleClick);
            // 
            // gbRelTestador
            // 
            this.gbRelTestador.Controls.Add(this.lbRelTestador);
            this.gbRelTestador.Location = new System.Drawing.Point(290, 344);
            this.gbRelTestador.Name = "gbRelTestador";
            this.gbRelTestador.Size = new System.Drawing.Size(623, 261);
            this.gbRelTestador.TabIndex = 5;
            this.gbRelTestador.TabStop = false;
            this.gbRelTestador.Text = "Realatório testador:";
            // 
            // lbRelTestador
            // 
            this.lbRelTestador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRelTestador.BackColor = System.Drawing.Color.Linen;
            this.lbRelTestador.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelTestador.FormattingEnabled = true;
            this.lbRelTestador.HorizontalScrollbar = true;
            this.lbRelTestador.ItemHeight = 15;
            this.lbRelTestador.Items.AddRange(new object[] {
            "AGUARDANDO CONSULTA..."});
            this.lbRelTestador.Location = new System.Drawing.Point(7, 19);
            this.lbRelTestador.Name = "lbRelTestador";
            this.lbRelTestador.Size = new System.Drawing.Size(610, 229);
            this.lbRelTestador.TabIndex = 0;
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 628);
            this.Controls.Add(this.gbRelTestador);
            this.Controls.Add(this.gbFalhasTestador);
            this.Controls.Add(this.gbQuantitativo);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acompanhamento de falhas - HITRON";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbTurno.ResumeLayout(false);
            this.gbPersonalizado.ResumeLayout(false);
            this.gbPersonalizado.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbQuantitativo.ResumeLayout(false);
            this.gbFalhasTestador.ResumeLayout(false);
            this.gbRelTestador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tpDataInicio;
        private System.Windows.Forms.Label lbSetup;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Label lbFinalConsulta;
        private System.Windows.Forms.Label lbInicioConsulta;
        private System.Windows.Forms.RadioButton rbPersonalizado;
        private System.Windows.Forms.RadioButton rbTurno;
        private System.Windows.Forms.GroupBox gbPersonalizado;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.Button btnConsultarSegundo;
        private System.Windows.Forms.Button btnConsultarPrimeiro;
        private System.Windows.Forms.ListBox lbRelatorio;
        private System.Windows.Forms.DateTimePicker tpHoraFinal;
        private System.Windows.Forms.DateTimePicker tpDataFinal;
        private System.Windows.Forms.DateTimePicker tpHoraInicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.ComboBox cbPostos;
        private System.Windows.Forms.RadioButton rbConsultaRapida;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.CheckBox chkReteste;
        private System.Windows.Forms.GroupBox gbQuantitativo;
        private System.Windows.Forms.GroupBox gbFalhasTestador;
        private System.Windows.Forms.ListBox lbRelDetalhado;
        private System.Windows.Forms.GroupBox gbRelTestador;
        private System.Windows.Forms.ListBox lbRelTestador;
        private System.Windows.Forms.Button btnConsultaPersonalizada;
    }
}