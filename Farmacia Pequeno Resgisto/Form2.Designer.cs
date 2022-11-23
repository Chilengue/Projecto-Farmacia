namespace Farmacia_Pequeno_Resgisto
{
    partial class frmVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEleminar = new System.Windows.Forms.Button();
            this.btnAdicinar = new System.Windows.Forms.Button();
            this.btnValorTot = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.GroupBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodgoFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnvendas = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MinMazGrand = new System.Windows.Forms.Button();
            this.exitProgramacao = new System.Windows.Forms.Button();
            this.Minizarcintaxe = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTrocos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Cliente.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtUnitario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Confirmar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoProduto);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(655, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter_1);
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(131, 144);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(141, 36);
            this.txtUnitario.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preco Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(22, 144);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(98, 36);
            this.txtQuantidade.TabIndex = 21;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(126, 60);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(418, 36);
            this.txtProduto.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Produto";
            // 
            // Confirmar
            // 
            this.Confirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Confirmar.FlatAppearance.BorderSize = 0;
            this.Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.ForeColor = System.Drawing.Color.Black;
            this.Confirmar.Location = new System.Drawing.Point(336, 143);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(132, 37);
            this.Confirmar.TabIndex = 14;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Codigo";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(22, 60);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(98, 36);
            this.txtCodigoProduto.TabIndex = 17;
            this.txtCodigoProduto.TextChanged += new System.EventHandler(this.TxtCodigoProduto_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.btnEleminar);
            this.groupBox2.Controls.Add(this.btnAdicinar);
            this.groupBox2.Controls.Add(this.btnValorTot);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1213, 190);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnEleminar
            // 
            this.btnEleminar.BackColor = System.Drawing.Color.White;
            this.btnEleminar.BackgroundImage = global::Farmacia_Pequeno_Resgisto.Properties.Resources.Cancel_48px;
            this.btnEleminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEleminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEleminar.FlatAppearance.BorderSize = 0;
            this.btnEleminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleminar.ForeColor = System.Drawing.Color.White;
            this.btnEleminar.Location = new System.Drawing.Point(946, 97);
            this.btnEleminar.Name = "btnEleminar";
            this.btnEleminar.Size = new System.Drawing.Size(71, 60);
            this.btnEleminar.TabIndex = 29;
            this.btnEleminar.UseVisualStyleBackColor = false;
            this.btnEleminar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnAdicinar
            // 
            this.btnAdicinar.BackColor = System.Drawing.Color.MintCream;
            this.btnAdicinar.BackgroundImage = global::Farmacia_Pequeno_Resgisto.Properties.Resources.Plus_48px;
            this.btnAdicinar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicinar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicinar.ForeColor = System.Drawing.Color.White;
            this.btnAdicinar.Location = new System.Drawing.Point(946, 38);
            this.btnAdicinar.Name = "btnAdicinar";
            this.btnAdicinar.Size = new System.Drawing.Size(71, 59);
            this.btnAdicinar.TabIndex = 28;
            this.btnAdicinar.UseVisualStyleBackColor = false;
            this.btnAdicinar.Click += new System.EventHandler(this.BtnAdicinar_Click);
            // 
            // btnValorTot
            // 
            this.btnValorTot.AutoSize = true;
            this.btnValorTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValorTot.Location = new System.Drawing.Point(1041, 27);
            this.btnValorTot.Name = "btnValorTot";
            this.btnValorTot.Size = new System.Drawing.Size(107, 25);
            this.btnValorTot.TabIndex = 25;
            this.btnValorTot.Text = "Valor Total";
            this.btnValorTot.Click += new System.EventHandler(this.BtnValorTot_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Total});
            this.dataGridView2.Location = new System.Drawing.Point(30, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(901, 156);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 400F;
            this.Column2.HeaderText = "Cliente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Produto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantidade";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Preco Unitario";
            this.Column5.Name = "Column5";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.txtFuncionario);
            this.Cliente.Controls.Add(this.label3);
            this.Cliente.Controls.Add(this.label4);
            this.Cliente.Controls.Add(this.txtCodgoFuncionario);
            this.Cliente.Controls.Add(this.txtNomeCliente);
            this.Cliente.Controls.Add(this.label2);
            this.Cliente.Controls.Add(this.label1);
            this.Cliente.Controls.Add(this.txtCodCliente);
            this.Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.Black;
            this.Cliente.Location = new System.Drawing.Point(22, 95);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(615, 207);
            this.Cliente.TabIndex = 19;
            this.Cliente.TabStop = false;
            this.Cliente.Text = "Cliente/Funcionario";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(126, 144);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(406, 36);
            this.txtFuncionario.TabIndex = 23;
            this.txtFuncionario.TextChanged += new System.EventHandler(this.TxtFuncionario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Codigo";
            // 
            // txtCodgoFuncionario
            // 
            this.txtCodgoFuncionario.Location = new System.Drawing.Point(22, 144);
            this.txtCodgoFuncionario.Name = "txtCodgoFuncionario";
            this.txtCodgoFuncionario.Size = new System.Drawing.Size(98, 36);
            this.txtCodgoFuncionario.TabIndex = 21;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNomeCliente.Location = new System.Drawing.Point(126, 60);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(406, 36);
            this.txtNomeCliente.TabIndex = 19;
            this.txtNomeCliente.Text = "                                                                                 " +
    "                                                     ";
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.TxtNomeCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(22, 60);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(98, 36);
            this.txtCodCliente.TabIndex = 17;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnvendas
            // 
            this.btnvendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnvendas.FlatAppearance.BorderSize = 0;
            this.btnvendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendas.ForeColor = System.Drawing.Color.Black;
            this.btnvendas.Location = new System.Drawing.Point(967, 53);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(162, 36);
            this.btnvendas.TabIndex = 26;
            this.btnvendas.Text = "Finalizar a venda";
            this.btnvendas.UseVisualStyleBackColor = false;
            this.btnvendas.Click += new System.EventHandler(this.Btnvendas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnMaximizar);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btnMinizar);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-36, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1748, 47);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox4.Controls.Add(this.MinMazGrand);
            this.groupBox4.Controls.Add(this.exitProgramacao);
            this.groupBox4.Controls.Add(this.Minizarcintaxe);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1290, 47);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // MinMazGrand
            // 
            this.MinMazGrand.FlatAppearance.BorderSize = 0;
            this.MinMazGrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinMazGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinMazGrand.Location = new System.Drawing.Point(1214, -13);
            this.MinMazGrand.Name = "MinMazGrand";
            this.MinMazGrand.Size = new System.Drawing.Size(38, 41);
            this.MinMazGrand.TabIndex = 3;
            this.MinMazGrand.Text = "o";
            this.MinMazGrand.UseVisualStyleBackColor = true;
            this.MinMazGrand.Click += new System.EventHandler(this.Button5_Click);
            // 
            // exitProgramacao
            // 
            this.exitProgramacao.FlatAppearance.BorderSize = 0;
            this.exitProgramacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitProgramacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitProgramacao.Location = new System.Drawing.Point(1239, -13);
            this.exitProgramacao.Name = "exitProgramacao";
            this.exitProgramacao.Size = new System.Drawing.Size(41, 41);
            this.exitProgramacao.TabIndex = 2;
            this.exitProgramacao.Text = "o";
            this.exitProgramacao.UseVisualStyleBackColor = true;
            this.exitProgramacao.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Minizarcintaxe
            // 
            this.Minizarcintaxe.FlatAppearance.BorderSize = 0;
            this.Minizarcintaxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minizarcintaxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minizarcintaxe.Location = new System.Drawing.Point(1189, -14);
            this.Minizarcintaxe.Name = "Minizarcintaxe";
            this.Minizarcintaxe.Size = new System.Drawing.Size(36, 43);
            this.Minizarcintaxe.TabIndex = 1;
            this.Minizarcintaxe.Text = "o";
            this.Minizarcintaxe.UseVisualStyleBackColor = true;
            this.Minizarcintaxe.Click += new System.EventHandler(this.Minizarcintaxe_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.Location = new System.Drawing.Point(1216, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 41);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.Text = "o";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1241, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 41);
            this.button4.TabIndex = 2;
            this.button4.Text = "o";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.FlatAppearance.BorderSize = 0;
            this.btnMinizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinizar.Location = new System.Drawing.Point(1191, 1);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(36, 43);
            this.btnMinizar.TabIndex = 1;
            this.btnMinizar.Text = "o";
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.BtnMinizar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(22, 518);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1213, 172);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Preco";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 710);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1262, 47);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.GroupBox6_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lavender;
            this.btnSearch.BackgroundImage = global::Farmacia_Pequeno_Resgisto.Properties.Resources.Search_48px1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1156, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 46);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnTrocos
            // 
            this.btnTrocos.BackColor = System.Drawing.Color.Tomato;
            this.btnTrocos.FlatAppearance.BorderSize = 0;
            this.btnTrocos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocos.ForeColor = System.Drawing.Color.Black;
            this.btnTrocos.Location = new System.Drawing.Point(807, 53);
            this.btnTrocos.Name = "btnTrocos";
            this.btnTrocos.Size = new System.Drawing.Size(120, 36);
            this.btnTrocos.TabIndex = 27;
            this.btnTrocos.Text = "Trocos";
            this.btnTrocos.UseVisualStyleBackColor = false;
            this.btnTrocos.Click += new System.EventHandler(this.Button3_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1262, 757);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTrocos);
            this.Controls.Add(this.btnvendas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cliente);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(197, 80);
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7654  v";
            this.Load += new System.EventHandler(this.Minizar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Cliente.ResumeLayout(false);
            this.Cliente.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Cliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodgoFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnTrocos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMinizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button MinMazGrand;
        private System.Windows.Forms.Button exitProgramacao;
        private System.Windows.Forms.Button Minizarcintaxe;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEleminar;
        private System.Windows.Forms.Button btnAdicinar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label btnValorTot;
        private System.Windows.Forms.Button btnSearch;
    }
}