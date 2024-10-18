namespace projeto_final
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInserir = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelet = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.lbValorTot = new System.Windows.Forms.Label();
            this.tbvalor05 = new System.Windows.Forms.TextBox();
            this.tbdesc05 = new System.Windows.Forms.TextBox();
            this.tbqte05 = new System.Windows.Forms.TextBox();
            this.tbvalor04 = new System.Windows.Forms.TextBox();
            this.tbdesc04 = new System.Windows.Forms.TextBox();
            this.tbqte04 = new System.Windows.Forms.TextBox();
            this.tbvalor03 = new System.Windows.Forms.TextBox();
            this.tbdesc03 = new System.Windows.Forms.TextBox();
            this.tbqte03 = new System.Windows.Forms.TextBox();
            this.tbvalor02 = new System.Windows.Forms.TextBox();
            this.tbdesc02 = new System.Windows.Forms.TextBox();
            this.tbqte02 = new System.Windows.Forms.TextBox();
            this.tbvalor01 = new System.Windows.Forms.TextBox();
            this.tbdesc01 = new System.Windows.Forms.TextBox();
            this.tbqte01 = new System.Windows.Forms.TextBox();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbCarro = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.bttodos = new System.Windows.Forms.Button();
            this.lbto = new System.Windows.Forms.Label();
            this.btbuscaatt = new System.Windows.Forms.Button();
            this.btbusca = new System.Windows.Forms.Button();
            this.mtxbCpfB = new System.Windows.Forms.MaskedTextBox();
            this.lbpesq = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.dgvveiculo = new System.Windows.Forms.DataGridView();
            this.dgvServiço = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvteste = new System.Windows.Forms.DataGridView();
            this.dgvtodos = new System.Windows.Forms.DataGridView();
            this.p3 = new System.Windows.Forms.Panel();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvveiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiço)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodos)).BeginInit();
            this.p3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(59, 73);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(140, 73);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Consultar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(221, 73);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Atualizar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelet
            // 
            this.btDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelet.Location = new System.Drawing.Point(302, 73);
            this.btDelet.Name = "btDelet";
            this.btDelet.Size = new System.Drawing.Size(75, 23);
            this.btDelet.TabIndex = 3;
            this.btDelet.Text = "Excluir";
            this.btDelet.UseVisualStyleBackColor = true;
            this.btDelet.Click += new System.EventHandler(this.btDelet_Click);
            // 
            // p1
            // 
            this.p1.Controls.Add(this.label13);
            this.p1.Controls.Add(this.label12);
            this.p1.Controls.Add(this.label11);
            this.p1.Controls.Add(this.label10);
            this.p1.Controls.Add(this.label9);
            this.p1.Controls.Add(this.label8);
            this.p1.Controls.Add(this.label7);
            this.p1.Controls.Add(this.label6);
            this.p1.Controls.Add(this.label5);
            this.p1.Controls.Add(this.label4);
            this.p1.Controls.Add(this.btExcluir);
            this.p1.Controls.Add(this.btAtualizar);
            this.p1.Controls.Add(this.btAdicionar);
            this.p1.Controls.Add(this.btConfirmar);
            this.p1.Controls.Add(this.lbValorTot);
            this.p1.Controls.Add(this.tbvalor05);
            this.p1.Controls.Add(this.tbdesc05);
            this.p1.Controls.Add(this.tbqte05);
            this.p1.Controls.Add(this.tbvalor04);
            this.p1.Controls.Add(this.tbdesc04);
            this.p1.Controls.Add(this.tbqte04);
            this.p1.Controls.Add(this.tbvalor03);
            this.p1.Controls.Add(this.tbdesc03);
            this.p1.Controls.Add(this.tbqte03);
            this.p1.Controls.Add(this.tbvalor02);
            this.p1.Controls.Add(this.tbdesc02);
            this.p1.Controls.Add(this.tbqte02);
            this.p1.Controls.Add(this.tbvalor01);
            this.p1.Controls.Add(this.tbdesc01);
            this.p1.Controls.Add(this.tbqte01);
            this.p1.Controls.Add(this.txbPlaca);
            this.p1.Controls.Add(this.txbCarro);
            this.p1.Controls.Add(this.txbTelefone);
            this.p1.Controls.Add(this.mtxbCpf);
            this.p1.Controls.Add(this.txbNome);
            this.p1.Location = new System.Drawing.Point(12, 114);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(415, 447);
            this.p1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(210, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Valor Total: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(314, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Valor (UN)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Descrição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Qte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Serviços:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Placa: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Veiculo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "CPF : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nome : ";
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(34, 351);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(111, 23);
            this.btExcluir.TabIndex = 24;
            this.btExcluir.Text = "Excluir OS";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Visible = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(34, 365);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(111, 23);
            this.btAtualizar.TabIndex = 23;
            this.btAtualizar.Text = "Atualizar OS";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Visible = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Location = new System.Drawing.Point(34, 365);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(111, 23);
            this.btAdicionar.TabIndex = 22;
            this.btAdicionar.Text = "Adiconar OS";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.Location = new System.Drawing.Point(34, 336);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(111, 23);
            this.btConfirmar.TabIndex = 21;
            this.btConfirmar.Text = "Confirmar OS";
            this.btConfirmar.UseVisualStyleBackColor = true;
            // 
            // lbValorTot
            // 
            this.lbValorTot.AutoSize = true;
            this.lbValorTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTot.Location = new System.Drawing.Point(308, 342);
            this.lbValorTot.Name = "lbValorTot";
            this.lbValorTot.Size = new System.Drawing.Size(68, 17);
            this.lbValorTot.TabIndex = 20;
            this.lbValorTot.Text = "------------";
            // 
            // tbvalor05
            // 
            this.tbvalor05.Location = new System.Drawing.Point(317, 296);
            this.tbvalor05.Name = "tbvalor05";
            this.tbvalor05.Size = new System.Drawing.Size(65, 20);
            this.tbvalor05.TabIndex = 19;
            // 
            // tbdesc05
            // 
            this.tbdesc05.Location = new System.Drawing.Point(71, 296);
            this.tbdesc05.Name = "tbdesc05";
            this.tbdesc05.Size = new System.Drawing.Size(238, 20);
            this.tbdesc05.TabIndex = 18;
            // 
            // tbqte05
            // 
            this.tbqte05.Location = new System.Drawing.Point(30, 296);
            this.tbqte05.Name = "tbqte05";
            this.tbqte05.Size = new System.Drawing.Size(32, 20);
            this.tbqte05.TabIndex = 17;
            // 
            // tbvalor04
            // 
            this.tbvalor04.Location = new System.Drawing.Point(317, 270);
            this.tbvalor04.Name = "tbvalor04";
            this.tbvalor04.Size = new System.Drawing.Size(65, 20);
            this.tbvalor04.TabIndex = 16;
            // 
            // tbdesc04
            // 
            this.tbdesc04.Location = new System.Drawing.Point(71, 270);
            this.tbdesc04.Name = "tbdesc04";
            this.tbdesc04.Size = new System.Drawing.Size(238, 20);
            this.tbdesc04.TabIndex = 15;
            // 
            // tbqte04
            // 
            this.tbqte04.Location = new System.Drawing.Point(30, 270);
            this.tbqte04.Name = "tbqte04";
            this.tbqte04.Size = new System.Drawing.Size(32, 20);
            this.tbqte04.TabIndex = 14;
            // 
            // tbvalor03
            // 
            this.tbvalor03.Location = new System.Drawing.Point(317, 244);
            this.tbvalor03.Name = "tbvalor03";
            this.tbvalor03.Size = new System.Drawing.Size(65, 20);
            this.tbvalor03.TabIndex = 13;
            // 
            // tbdesc03
            // 
            this.tbdesc03.Location = new System.Drawing.Point(71, 244);
            this.tbdesc03.Name = "tbdesc03";
            this.tbdesc03.Size = new System.Drawing.Size(238, 20);
            this.tbdesc03.TabIndex = 12;
            // 
            // tbqte03
            // 
            this.tbqte03.Location = new System.Drawing.Point(30, 244);
            this.tbqte03.Name = "tbqte03";
            this.tbqte03.Size = new System.Drawing.Size(32, 20);
            this.tbqte03.TabIndex = 11;
            // 
            // tbvalor02
            // 
            this.tbvalor02.Location = new System.Drawing.Point(317, 218);
            this.tbvalor02.Name = "tbvalor02";
            this.tbvalor02.Size = new System.Drawing.Size(65, 20);
            this.tbvalor02.TabIndex = 10;
            // 
            // tbdesc02
            // 
            this.tbdesc02.Location = new System.Drawing.Point(71, 218);
            this.tbdesc02.Name = "tbdesc02";
            this.tbdesc02.Size = new System.Drawing.Size(238, 20);
            this.tbdesc02.TabIndex = 9;
            // 
            // tbqte02
            // 
            this.tbqte02.Location = new System.Drawing.Point(30, 218);
            this.tbqte02.Name = "tbqte02";
            this.tbqte02.Size = new System.Drawing.Size(32, 20);
            this.tbqte02.TabIndex = 8;
            // 
            // tbvalor01
            // 
            this.tbvalor01.Location = new System.Drawing.Point(317, 192);
            this.tbvalor01.Name = "tbvalor01";
            this.tbvalor01.Size = new System.Drawing.Size(65, 20);
            this.tbvalor01.TabIndex = 7;
            // 
            // tbdesc01
            // 
            this.tbdesc01.Location = new System.Drawing.Point(71, 192);
            this.tbdesc01.Name = "tbdesc01";
            this.tbdesc01.Size = new System.Drawing.Size(238, 20);
            this.tbdesc01.TabIndex = 6;
            // 
            // tbqte01
            // 
            this.tbqte01.Location = new System.Drawing.Point(30, 192);
            this.tbqte01.Name = "tbqte01";
            this.tbqte01.Size = new System.Drawing.Size(32, 20);
            this.tbqte01.TabIndex = 5;
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(264, 95);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(118, 20);
            this.txbPlaca.TabIndex = 4;
            // 
            // txbCarro
            // 
            this.txbCarro.Location = new System.Drawing.Point(91, 95);
            this.txbCarro.Name = "txbCarro";
            this.txbCarro.Size = new System.Drawing.Size(100, 20);
            this.txbCarro.TabIndex = 3;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(266, 59);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(116, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Location = new System.Drawing.Point(78, 57);
            this.mtxbCpf.Mask = "000.000.000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtxbCpf.TabIndex = 1;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(94, 10);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(288, 20);
            this.txbNome.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Controls.Add(this.bttodos);
            this.p2.Controls.Add(this.lbto);
            this.p2.Controls.Add(this.btbuscaatt);
            this.p2.Controls.Add(this.btbusca);
            this.p2.Controls.Add(this.mtxbCpfB);
            this.p2.Controls.Add(this.lbpesq);
            this.p2.Location = new System.Drawing.Point(12, 106);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(415, 87);
            this.p2.TabIndex = 5;
            this.p2.Visible = false;
            // 
            // bttodos
            // 
            this.bttodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttodos.Location = new System.Drawing.Point(220, 56);
            this.bttodos.Name = "bttodos";
            this.bttodos.Size = new System.Drawing.Size(163, 23);
            this.bttodos.TabIndex = 5;
            this.bttodos.Text = "Exibir Todos";
            this.bttodos.UseVisualStyleBackColor = true;
            this.bttodos.Visible = false;
            this.bttodos.Click += new System.EventHandler(this.bttodos_Click);
            // 
            // lbto
            // 
            this.lbto.AutoSize = true;
            this.lbto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbto.Location = new System.Drawing.Point(16, 59);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(190, 17);
            this.lbto.TabIndex = 4;
            this.lbto.Text = "Consultar todos os Registros";
            this.lbto.Visible = false;
            // 
            // btbuscaatt
            // 
            this.btbuscaatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscaatt.Location = new System.Drawing.Point(308, 12);
            this.btbuscaatt.Name = "btbuscaatt";
            this.btbuscaatt.Size = new System.Drawing.Size(75, 23);
            this.btbuscaatt.TabIndex = 3;
            this.btbuscaatt.Text = "Buscar";
            this.btbuscaatt.UseVisualStyleBackColor = true;
            this.btbuscaatt.Click += new System.EventHandler(this.btbuscaatt_Click);
            // 
            // btbusca
            // 
            this.btbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbusca.Location = new System.Drawing.Point(308, 12);
            this.btbusca.Name = "btbusca";
            this.btbusca.Size = new System.Drawing.Size(75, 23);
            this.btbusca.TabIndex = 2;
            this.btbusca.Text = "Buscar";
            this.btbusca.UseVisualStyleBackColor = true;
            this.btbusca.Click += new System.EventHandler(this.btbusca_Click);
            // 
            // mtxbCpfB
            // 
            this.mtxbCpfB.Location = new System.Drawing.Point(202, 14);
            this.mtxbCpfB.Mask = "000.000.000-00";
            this.mtxbCpfB.Name = "mtxbCpfB";
            this.mtxbCpfB.Size = new System.Drawing.Size(100, 20);
            this.mtxbCpfB.TabIndex = 1;
            // 
            // lbpesq
            // 
            this.lbpesq.AutoSize = true;
            this.lbpesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpesq.Location = new System.Drawing.Point(16, 18);
            this.lbpesq.Name = "lbpesq";
            this.lbpesq.Size = new System.Drawing.Size(83, 17);
            this.lbpesq.TabIndex = 0;
            this.lbpesq.Text = "digite o -----";
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(530, 9);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(289, 118);
            this.dgvcliente.TabIndex = 6;
            this.dgvcliente.Visible = false;
            // 
            // dgvveiculo
            // 
            this.dgvveiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvveiculo.Location = new System.Drawing.Point(530, 133);
            this.dgvveiculo.Name = "dgvveiculo";
            this.dgvveiculo.Size = new System.Drawing.Size(289, 133);
            this.dgvveiculo.TabIndex = 7;
            this.dgvveiculo.Visible = false;
            // 
            // dgvServiço
            // 
            this.dgvServiço.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiço.Location = new System.Drawing.Point(530, 272);
            this.dgvServiço.Name = "dgvServiço";
            this.dgvServiço.Size = new System.Drawing.Size(289, 118);
            this.dgvServiço.TabIndex = 8;
            this.dgvServiço.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "--- SISTEMA DE CADASTRO ---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "O que deseja fazer?";
            // 
            // dgvteste
            // 
            this.dgvteste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteste.Location = new System.Drawing.Point(530, 396);
            this.dgvteste.Name = "dgvteste";
            this.dgvteste.Size = new System.Drawing.Size(289, 120);
            this.dgvteste.TabIndex = 27;
            this.dgvteste.Visible = false;
            // 
            // dgvtodos
            // 
            this.dgvtodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtodos.Location = new System.Drawing.Point(31, 27);
            this.dgvtodos.Name = "dgvtodos";
            this.dgvtodos.Size = new System.Drawing.Size(346, 100);
            this.dgvtodos.TabIndex = 28;
            this.dgvtodos.Visible = false;
            // 
            // p3
            // 
            this.p3.Controls.Add(this.dgvtodos);
            this.p3.Location = new System.Drawing.Point(11, 102);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(416, 154);
            this.p3.TabIndex = 29;
            this.p3.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(442, 569);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.dgvteste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServiço);
            this.Controls.Add(this.dgvveiculo);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.btDelet);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btInserir);
            this.Name = "Form1";
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvveiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiço)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodos)).EndInit();
            this.p3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbveic;
        private System.Windows.Forms.TextBox tbplaca;
        private System.Windows.Forms.TextBox tbvalor5;
        private System.Windows.Forms.TextBox tbdesc5;
        private System.Windows.Forms.TextBox tbqte5;
        private System.Windows.Forms.TextBox tbvalor4;
        private System.Windows.Forms.TextBox tbdesc4;
        private System.Windows.Forms.TextBox tbqte4;
        private System.Windows.Forms.TextBox tbvalor3;
        private System.Windows.Forms.TextBox tbdesc3;
        private System.Windows.Forms.TextBox tbqte3;
        private System.Windows.Forms.TextBox tbvalor2;
        private System.Windows.Forms.TextBox tbdesc2;
        private System.Windows.Forms.TextBox tbqte2;
        private System.Windows.Forms.TextBox tbvalor1;
        private System.Windows.Forms.TextBox tbdesc1;
        private System.Windows.Forms.TextBox tbqte1;
        private System.Windows.Forms.Label lbvtot;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btbuscaratt;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btatt;
        private System.Windows.Forms.MaskedTextBox mtbCpfb;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.DataGridView dgvCarro;
        private System.Windows.Forms.DataGridView dgvserv;
        private System.Windows.Forms.Button btconf;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btins;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelet;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.MaskedTextBox mtxbCpf;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.TextBox txbCarro;
        private System.Windows.Forms.Label lbValorTot;
        private System.Windows.Forms.TextBox tbvalor05;
        private System.Windows.Forms.TextBox tbdesc05;
        private System.Windows.Forms.TextBox tbqte05;
        private System.Windows.Forms.TextBox tbvalor04;
        private System.Windows.Forms.TextBox tbdesc04;
        private System.Windows.Forms.TextBox tbqte04;
        private System.Windows.Forms.TextBox tbvalor03;
        private System.Windows.Forms.TextBox tbdesc03;
        private System.Windows.Forms.TextBox tbqte03;
        private System.Windows.Forms.TextBox tbvalor02;
        private System.Windows.Forms.TextBox tbdesc02;
        private System.Windows.Forms.TextBox tbqte02;
        private System.Windows.Forms.TextBox tbvalor01;
        private System.Windows.Forms.TextBox tbdesc01;
        private System.Windows.Forms.TextBox tbqte01;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label lbpesq;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btbuscaatt;
        private System.Windows.Forms.Button btbusca;
        private System.Windows.Forms.MaskedTextBox mtxbCpfB;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.DataGridView dgvveiculo;
        private System.Windows.Forms.DataGridView dgvServiço;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvteste;
        private System.Windows.Forms.Button bttodos;
        private System.Windows.Forms.Label lbto;
        private System.Windows.Forms.DataGridView dgvtodos;
        private System.Windows.Forms.Panel p3;
    }
}

