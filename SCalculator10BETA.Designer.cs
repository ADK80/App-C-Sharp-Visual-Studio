namespace WindowsFormsApplication6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAp = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNmonta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtQtdt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNummj = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpBase = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboPerim = new System.Windows.Forms.ComboBox();
            this.txtRendm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtdjogo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAppcon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConcrs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAppan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMetr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtEmpr = new System.Windows.Forms.TextBox();
            this.lbObra = new System.Windows.Forms.Label();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.tabSobrado = new System.Windows.Forms.TabPage();
            this.tabCasa = new System.Windows.Forms.TabPage();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAp.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.grpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAp);
            this.tabControl1.Controls.Add(this.tabSobrado);
            this.tabControl1.Controls.Add(this.tabCasa);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 494);
            this.tabControl1.TabIndex = 1;
            // 
            // tabAp
            // 
            this.tabAp.Controls.Add(this.btnImprimir);
            this.tabAp.Controls.Add(this.grpResultado);
            this.tabAp.Controls.Add(this.btnCalc);
            this.tabAp.Controls.Add(this.grpBase);
            this.tabAp.Controls.Add(this.label1);
            this.tabAp.Controls.Add(this.txtResp);
            this.tabAp.Controls.Add(this.txtObra);
            this.tabAp.Controls.Add(this.txtEmpr);
            this.tabAp.Controls.Add(this.lbObra);
            this.tabAp.Controls.Add(this.lbEmpresa);
            this.tabAp.Location = new System.Drawing.Point(4, 22);
            this.tabAp.Name = "tabAp";
            this.tabAp.Padding = new System.Windows.Forms.Padding(3);
            this.tabAp.Size = new System.Drawing.Size(590, 468);
            this.tabAp.TabIndex = 0;
            this.tabAp.Text = "Apartamento";
            this.tabAp.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(243, 440);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir!";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.label15);
            this.grpResultado.Controls.Add(this.txtNmonta);
            this.grpResultado.Controls.Add(this.label14);
            this.grpResultado.Controls.Add(this.txtMeses);
            this.grpResultado.Controls.Add(this.label13);
            this.grpResultado.Controls.Add(this.txtDias);
            this.grpResultado.Controls.Add(this.txtQtdt);
            this.grpResultado.Controls.Add(this.label12);
            this.grpResultado.Controls.Add(this.txtNummj);
            this.grpResultado.Controls.Add(this.label11);
            this.grpResultado.Location = new System.Drawing.Point(6, 277);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(572, 157);
            this.grpResultado.TabIndex = 8;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Número total de montadores:";
            // 
            // txtNmonta
            // 
            this.txtNmonta.Location = new System.Drawing.Point(173, 122);
            this.txtNmonta.Name = "txtNmonta";
            this.txtNmonta.Size = new System.Drawing.Size(137, 20);
            this.txtNmonta.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Quantidade de meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(173, 96);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(137, 20);
            this.txtMeses.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Quantidade de dias:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(173, 70);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(137, 20);
            this.txtDias.TabIndex = 28;
            // 
            // txtQtdt
            // 
            this.txtQtdt.Location = new System.Drawing.Point(173, 44);
            this.txtQtdt.Name = "txtQtdt";
            this.txtQtdt.Size = new System.Drawing.Size(137, 20);
            this.txtQtdt.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Quantidade de torres:";
            // 
            // txtNummj
            // 
            this.txtNummj.Location = new System.Drawing.Point(173, 18);
            this.txtNummj.Name = "txtNummj";
            this.txtNummj.Size = new System.Drawing.Size(137, 20);
            this.txtNummj.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Número de montadores por jogo:";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(243, 247);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpBase
            // 
            this.grpBase.Controls.Add(this.label10);
            this.grpBase.Controls.Add(this.comboPerim);
            this.grpBase.Controls.Add(this.txtRendm);
            this.grpBase.Controls.Add(this.label9);
            this.grpBase.Controls.Add(this.txtQtdjogo);
            this.grpBase.Controls.Add(this.label8);
            this.grpBase.Controls.Add(this.txtAppcon);
            this.grpBase.Controls.Add(this.label7);
            this.grpBase.Controls.Add(this.txtConcrs);
            this.grpBase.Controls.Add(this.label6);
            this.grpBase.Controls.Add(this.txtAppan);
            this.grpBase.Controls.Add(this.label5);
            this.grpBase.Controls.Add(this.txtQtdan);
            this.grpBase.Controls.Add(this.label4);
            this.grpBase.Controls.Add(this.txtQtdap);
            this.grpBase.Controls.Add(this.label3);
            this.grpBase.Controls.Add(this.txtMetr);
            this.grpBase.Controls.Add(this.label2);
            this.grpBase.Location = new System.Drawing.Point(6, 84);
            this.grpBase.Name = "grpBase";
            this.grpBase.Size = new System.Drawing.Size(578, 157);
            this.grpBase.TabIndex = 6;
            this.grpBase.TabStop = false;
            this.grpBase.Text = "Cálculo Base";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Rend. do montador(%):";
            // 
            // comboPerim
            // 
            this.comboPerim.FormattingEnabled = true;
            this.comboPerim.Items.AddRange(new object[] {
            "Integral",
            "Meio"});
            this.comboPerim.Location = new System.Drawing.Point(435, 97);
            this.comboPerim.Name = "comboPerim";
            this.comboPerim.Size = new System.Drawing.Size(137, 21);
            this.comboPerim.TabIndex = 22;
            this.comboPerim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtRendm
            // 
            this.txtRendm.Location = new System.Drawing.Point(143, 123);
            this.txtRendm.Name = "txtRendm";
            this.txtRendm.Size = new System.Drawing.Size(137, 20);
            this.txtRendm.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Perímetro:";
            // 
            // txtQtdjogo
            // 
            this.txtQtdjogo.Location = new System.Drawing.Point(143, 97);
            this.txtQtdjogo.Name = "txtQtdjogo";
            this.txtQtdjogo.Size = new System.Drawing.Size(137, 20);
            this.txtQtdjogo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Qtd. de jogos:";
            // 
            // txtAppcon
            // 
            this.txtAppcon.Location = new System.Drawing.Point(435, 71);
            this.txtAppcon.Name = "txtAppcon";
            this.txtAppcon.Size = new System.Drawing.Size(137, 20);
            this.txtAppcon.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Aptos. por Concretagem:";
            // 
            // txtConcrs
            // 
            this.txtConcrs.Location = new System.Drawing.Point(143, 71);
            this.txtConcrs.Name = "txtConcrs";
            this.txtConcrs.Size = new System.Drawing.Size(137, 20);
            this.txtConcrs.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Concretagem por semana:";
            // 
            // txtAppan
            // 
            this.txtAppan.Location = new System.Drawing.Point(435, 45);
            this.txtAppan.Name = "txtAppan";
            this.txtAppan.Size = new System.Drawing.Size(137, 20);
            this.txtAppan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Qtd. de aptos. por andar:";
            // 
            // txtQtdan
            // 
            this.txtQtdan.Location = new System.Drawing.Point(143, 45);
            this.txtQtdan.Name = "txtQtdan";
            this.txtQtdan.Size = new System.Drawing.Size(137, 20);
            this.txtQtdan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qtd. de andares por torre:";
            // 
            // txtQtdap
            // 
            this.txtQtdap.Location = new System.Drawing.Point(435, 19);
            this.txtQtdap.Name = "txtQtdap";
            this.txtQtdap.Size = new System.Drawing.Size(137, 20);
            this.txtQtdap.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qtd. de Apartamentos:";
            // 
            // txtMetr
            // 
            this.txtMetr.Location = new System.Drawing.Point(143, 19);
            this.txtMetr.Name = "txtMetr";
            this.txtMetr.Size = new System.Drawing.Size(137, 20);
            this.txtMetr.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Área total de fôrmas(m²):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Responsável:";
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(84, 58);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(500, 20);
            this.txtResp.TabIndex = 4;
            // 
            // txtObra
            // 
            this.txtObra.Location = new System.Drawing.Point(84, 32);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(500, 20);
            this.txtObra.TabIndex = 3;
            // 
            // txtEmpr
            // 
            this.txtEmpr.Location = new System.Drawing.Point(84, 6);
            this.txtEmpr.Name = "txtEmpr";
            this.txtEmpr.Size = new System.Drawing.Size(500, 20);
            this.txtEmpr.TabIndex = 2;
            // 
            // lbObra
            // 
            this.lbObra.AutoSize = true;
            this.lbObra.Location = new System.Drawing.Point(45, 35);
            this.lbObra.Name = "lbObra";
            this.lbObra.Size = new System.Drawing.Size(33, 13);
            this.lbObra.TabIndex = 1;
            this.lbObra.Text = "Obra:";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(27, 9);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lbEmpresa.TabIndex = 0;
            this.lbEmpresa.Text = "Empresa:";
            // 
            // tabSobrado
            // 
            this.tabSobrado.Location = new System.Drawing.Point(4, 22);
            this.tabSobrado.Name = "tabSobrado";
            this.tabSobrado.Padding = new System.Windows.Forms.Padding(3);
            this.tabSobrado.Size = new System.Drawing.Size(590, 468);
            this.tabSobrado.TabIndex = 1;
            this.tabSobrado.Text = "Sobrado";
            this.tabSobrado.UseVisualStyleBackColor = true;
            // 
            // tabCasa
            // 
            this.tabCasa.Location = new System.Drawing.Point(4, 22);
            this.tabCasa.Name = "tabCasa";
            this.tabCasa.Size = new System.Drawing.Size(590, 468);
            this.tabCasa.TabIndex = 2;
            this.tabCasa.Text = "Casa";
            this.tabCasa.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.salvarToolStripMenuItem.Text = "Salvar...";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Calculator 1.0 BETA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAp.ResumeLayout(false);
            this.tabAp.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.grpBase.ResumeLayout(false);
            this.grpBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAp;
        private System.Windows.Forms.GroupBox grpBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.TextBox txtObra;
        private System.Windows.Forms.TextBox txtEmpr;
        private System.Windows.Forms.Label lbObra;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.TabPage tabSobrado;
        private System.Windows.Forms.TabPage tabCasa;
        private System.Windows.Forms.TextBox txtQtdap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMetr;
        private System.Windows.Forms.TextBox txtConcrs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAppan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtdan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPerim;
        private System.Windows.Forms.TextBox txtRendm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtdjogo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNmonta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtQtdt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNummj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

