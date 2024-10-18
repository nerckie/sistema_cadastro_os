using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace projeto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            p3.Visible = false;
            dgvtodos.Visible = false;
            lbto.Visible = false;
            bttodos.Visible = false;
            btbuscaatt.Visible = false;
            btExcluir.Visible = false;
            mtxbCpf.Enabled = true;
            p1.Visible = true;
            limpartxb();
            btConfirmar.Visible = true;
            btAtualizar.Visible = false;
            mtxbCpf.Enabled = true;
            btAdicionar.Visible = true;
            p2.Visible = false;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            p3.Visible = false;
            dgvtodos.Visible = false;
            lbto.Visible = true;
            bttodos.Visible = true;
            btbusca.Visible = true;
            btbuscaatt.Visible = false;
            btExcluir.Visible = false;
            p1.Visible = false;
            p2.Visible = true;
            btAdicionar.Visible = false;
            lbpesq.Text = "Digite o CPF para consultar:";
            btAtualizar.Visible = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            p3.Visible = false;
            dgvtodos.Visible = false;
            lbto.Visible = false;
            bttodos.Visible = false;
            btbusca.Visible = false;
            btbuscaatt.Visible = true;
            btConfirmar.Visible = true;
            btExcluir.Visible = false;
            p1.Visible = false;
            p2.Visible = true;
            btAdicionar.Visible = false;
            lbpesq.Text = "Digite o CPF para atualizar:";
            btAtualizar.Visible = true;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            conf();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            p1.Visible = true;

            Cliente ncliente = new Cliente(txbNome.Text, mtxbCpf.Text, txbTelefone.Text); ;

            Veiculo nveiculo = new Veiculo(txbCarro.Text, txbPlaca.Text);

            Serviço serviço1 = new Serviço(tbdesc01.Text, Convert.ToDouble(tbvalor01.Text), Convert.ToInt32(tbqte01.Text));

            Serviço serviço2 = new Serviço(tbdesc02.Text, Convert.ToDouble(tbvalor02.Text), Convert.ToInt32(tbqte02.Text));

            Serviço serviço3 = new Serviço(tbdesc03.Text, Convert.ToDouble(tbvalor03.Text), Convert.ToInt32(tbqte03.Text));

            Serviço serviço4 = new Serviço(tbdesc04.Text, Convert.ToDouble(tbvalor04.Text), Convert.ToInt32(tbqte04.Text));

            Serviço serviço5 = new Serviço(tbdesc05.Text, Convert.ToDouble(tbvalor05.Text), Convert.ToInt32(tbqte05.Text));

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            con.Open();

            string cpf = mtxbCpf.Text;

            DataTable dt = new DataTable();

            string commandTextt = "SELECT * FROM cliente where cpf_cliente = '" + cpf + "'";
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandTextt, con))
            {
                Adpt.Fill(dt);
            }
            dgvteste.DataSource = dt;

            string teste = Convert.ToString(dgvteste.Rows[0].Cells[0].Value);

            if (teste == cpf)
            {
                MessageBox.Show("Já existe OS com este cpf: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpartxb();          
            }
            else
            {
                string commandTextc = String.Format("INSERT INTO cliente(cpf_cliente,nome_cliente,telefone_cliente)" + "values('{0}', '{1}', '{2}')", ncliente.Cpf, ncliente.Nome, ncliente.Telefone);

                string commandTextv = String.Format("INSERT INTO veiculo(cpf_cliente,nome_veiculo,placa_veiculo)" + "values('{0}', '{1}', '{2}')", ncliente.Cpf, nveiculo.Modelo, nveiculo.Placa);

                string commandText1 = String.Format("INSERT INTO serviço(cpf_cliente,nome_serviço,qte_serviço,valor_serviço)" + "values('{0}', '{1}', {2}, {3})", ncliente.Cpf, serviço1.Nome, serviço1.Qte, serviço1.Valor);

                string commandText2 = String.Format("INSERT INTO serviço(cpf_cliente,nome_serviço,qte_serviço,valor_serviço)" + "values('{0}', '{1}', {2}, {3})", ncliente.Cpf, serviço2.Nome, serviço2.Qte, serviço2.Valor);

                string commandText3 = String.Format("INSERT INTO serviço(cpf_cliente,nome_serviço,qte_serviço,valor_serviço)" + "values('{0}', '{1}', {2}, {3})", ncliente.Cpf, serviço3.Nome, serviço3.Qte, serviço3.Valor);

                string commandText4 = String.Format("INSERT INTO serviço(cpf_cliente,nome_serviço,qte_serviço,valor_serviço)" + "values('{0}', '{1}', {2}, {3})", ncliente.Cpf, serviço4.Nome, serviço4.Qte, serviço4.Valor);

                string commandText5 = String.Format("INSERT INTO serviço(cpf_cliente,nome_serviço,qte_serviço,valor_serviço)" + "values('{0}', '{1}', {2}, {3})", ncliente.Cpf, serviço5.Nome, serviço5.Qte, serviço5.Valor);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandTextc, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandTextv, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText1, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText2, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText3, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText4, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText5, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                con.Close();

                MessageBox.Show("Cadastro inserido com sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpartxb();
            }
           
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

            string cpf = mtxbCpf.Text;

            string serv1 = Convert.ToString(dgvServiço.Rows[0].Cells[2].Value);

            string serv2 = Convert.ToString(dgvServiço.Rows[1].Cells[2].Value);

            string serv3 = Convert.ToString(dgvServiço.Rows[2].Cells[2].Value);

            string serv4 = Convert.ToString(dgvServiço.Rows[3].Cells[2].Value);

            string serv5 = Convert.ToString(dgvServiço.Rows[4].Cells[2].Value);

            Cliente ncliente = new Cliente(txbNome.Text, mtxbCpf.Text, txbTelefone.Text); ;

            Veiculo nveiculo = new Veiculo(txbCarro.Text, txbPlaca.Text);

            Serviço serviço1 = new Serviço(tbdesc01.Text, Convert.ToDouble(tbvalor01.Text), Convert.ToInt32(tbqte01.Text));

            Serviço serviço2 = new Serviço(tbdesc02.Text, Convert.ToDouble(tbvalor02.Text), Convert.ToInt32(tbqte02.Text));

            Serviço serviço3 = new Serviço(tbdesc03.Text, Convert.ToDouble(tbvalor03.Text), Convert.ToInt32(tbqte03.Text));

            Serviço serviço4 = new Serviço(tbdesc04.Text, Convert.ToDouble(tbvalor04.Text), Convert.ToInt32(tbqte04.Text));

            Serviço serviço5 = new Serviço(tbdesc05.Text, Convert.ToDouble(tbvalor05.Text), Convert.ToInt32(tbqte05.Text));

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandTextc = String.Format("UPDATE cliente SET nome_cliente = '" + ncliente.Nome + "', telefone_cliente = '" + ncliente.Telefone + "' Where cpf_cliente = '" + cpf + "'");

            string commandTextv = String.Format("UPDATE veiculo SET nome_veiculo = '" + nveiculo.Modelo + "', placa_veiculo = '" + nveiculo.Placa + "' Where cpf_cliente = '" + cpf + "'");

            string commandText1 = String.Format("UPDATE serviço SET nome_serviço = '" + serviço1.Nome + "', qte_serviço = '" + serviço1.Qte + "', valor_serviço = '" + serviço1.Valor + "' Where cpf_cliente = '" + cpf + "' and  nome_serviço = '" + serv1 + "'");

            string commandText2 = String.Format("UPDATE serviço SET nome_serviço = '" + serviço2.Nome + "', qte_serviço = '" + serviço2.Qte + "', valor_serviço = '" + serviço2.Valor + "' Where cpf_cliente = '" + cpf + "' and  nome_serviço = '" + serv2 + "'");

            string commandText3 = String.Format("UPDATE serviço SET nome_serviço = '" + serviço3.Nome + "', qte_serviço = '" + serviço3.Qte + "', valor_serviço = '" + serviço3.Valor + "' Where cpf_cliente = '" + cpf + "' and  nome_serviço = '" + serv3 + "'");

            string commandText4 = String.Format("UPDATE serviço SET nome_serviço = '" + serviço4.Nome + "', qte_serviço = '" + serviço4.Qte + "', valor_serviço = '" + serviço4.Valor + "' Where cpf_cliente = '" + cpf + "' and  nome_serviço = '" + serv4 + "'");

            string commandText5 = String.Format("UPDATE serviço SET nome_serviço = '" + serviço5.Nome + "', qte_serviço = '" + serviço5.Qte + "', valor_serviço = '" + serviço5.Valor + "' Where cpf_cliente = '" + cpf + "' and  nome_serviço = '" + serv5 + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandTextc, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandTextv, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText1, con))
            {
                pgsqlcommand.ExecuteNonQueryAsync();
            }
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText2, con))
            {
                pgsqlcommand.ExecuteNonQueryAsync();
            }
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText3, con))
            {
                pgsqlcommand.ExecuteNonQueryAsync();
            }
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText4, con))
            {
                pgsqlcommand.ExecuteNonQueryAsync();
            }
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText5, con))
            {
                pgsqlcommand.ExecuteNonQueryAsync();
            }
            con.Close();

            MessageBox.Show("Cadastro atualizado com sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpartxb();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string cpf = mtxbCpf.Text;
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            con.Open();
            string commandText = String.Format("DELETE FROM cliente WHERE cpf_cliente = '{0}'", cpf);
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            string commandTextv = String.Format("DELETE FROM veiculo WHERE cpf_cliente = '{0}'", cpf);
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandTextv, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            string commandTexts = String.Format("DELETE FROM serviço WHERE cpf_cliente = '{0}'", cpf);
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandTexts, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            con.Close();

            MessageBox.Show("OS excluida com sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            p1.Visible = false;
            p2.Visible = true;

            limpartxb();
        }

        private void btbusca_Click(object sender, EventArgs e)
        {
            mtxbCpf.Enabled = false;
            string cpf = mtxbCpfB.Text;
            mtxbCpfB.Text = String.Empty;
            p2.Visible = false;
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            con.Open();
            DataTable dt = new DataTable();
            string commandText = "SELECT * FROM cliente where cpf_cliente = '" + cpf + "'";
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }
            dgvcliente.DataSource = dt;

            string teste = Convert.ToString(dgvcliente.Rows[0].Cells[0].Value);

            if (teste == String.Empty)
            {
                MessageBox.Show("Não existe OS com este cpf ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                p2.Visible = true;
            }
            else
            {
                DataTable dtv = new DataTable();
                string commandText1 = "SELECT * FROM veiculo where cpf_cliente = '" + cpf + "'";
                using (NpgsqlDataAdapter Adptv = new NpgsqlDataAdapter(commandText1, con))
                {
                    Adptv.Fill(dtv);
                }
                dgvveiculo.DataSource = dtv;

                DataTable dtc = new DataTable();
                string commandText2 = "SELECT * FROM serviço where cpf_cliente = '" + cpf + "'";
                using (NpgsqlDataAdapter Adpts = new NpgsqlDataAdapter(commandText2, con))
                {
                    Adpts.Fill(dtc);
                }
                dgvServiço.DataSource = dtc;

                con.Close();

                p1.Visible = true;

                btConfirmar.Visible = false;

                mostrar();

                conf();

            }
        }

        private void btbuscaatt_Click(object sender, EventArgs e)
        {
            mtxbCpf.Enabled = false;
            string cpf = mtxbCpfB.Text;
            mtxbCpfB.Text = String.Empty;
            p2.Visible = false;
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            con.Open();
            DataTable dt = new DataTable();
            string commandText = "SELECT * FROM cliente where cpf_cliente = '" + cpf + "'";
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }
            dgvcliente.DataSource = dt;

            string teste = Convert.ToString(dgvcliente.Rows[0].Cells[0].Value);

            if(teste == String.Empty)
            {
                MessageBox.Show("Não existe OS com este cpf ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                p2.Visible = true;
            }
            else
            {
                DataTable dtv = new DataTable();
                string commandText1 = "SELECT * FROM veiculo where cpf_cliente = '" + cpf + "'";
                using (NpgsqlDataAdapter Adptv = new NpgsqlDataAdapter(commandText1, con))
                {
                    Adptv.Fill(dtv);
                }
                dgvveiculo.DataSource = dtv;

                DataTable dtc = new DataTable();
                string commandText2 = "SELECT * FROM serviço where cpf_cliente = '" + cpf + "'";
                using (NpgsqlDataAdapter Adpts = new NpgsqlDataAdapter(commandText2, con))
                {
                    Adpts.Fill(dtc);
                }
                dgvServiço.DataSource = dtc;

                con.Close();

                p1.Visible = true;

                mostrar();
            }

            
        }

        private void btDelet_Click(object sender, EventArgs e)
        {
            p3.Visible = false;
            dgvtodos.Visible = false;
            lbto.Visible = false;
            bttodos.Visible = false;
            btbusca.Visible = true;
            btbuscaatt.Visible = false;
            btExcluir.Visible = true;
            p1.Visible = false;
            p2.Visible = true;
            btAdicionar.Visible = false;
            lbpesq.Text = "Digite o CPF para excluir:";
            btAtualizar.Visible = false;
        }
        public void limpartxb()
        {
            mtxbCpf.Text = String.Empty;
            txbNome.Text = String.Empty;
            txbTelefone.Text = String.Empty;
            txbCarro.Text = String.Empty;
            txbPlaca.Text = String.Empty;
            lbValorTot.Text = "--------";
            tbqte01.Text = String.Empty;
            tbqte02.Text = String.Empty;
            tbqte03.Text = String.Empty;
            tbqte04.Text = String.Empty;
            tbqte05.Text = String.Empty;
            tbdesc01.Text = String.Empty;
            tbdesc02.Text = String.Empty;
            tbdesc03.Text = String.Empty;
            tbdesc04.Text = String.Empty;
            tbdesc05.Text = String.Empty;
            tbvalor01.Text = String.Empty;
            tbvalor02.Text = String.Empty;
            tbvalor03.Text = String.Empty;
            tbvalor04.Text = String.Empty;
            tbvalor05.Text = String.Empty;
        }
        public void mostrar()
        {
            mtxbCpf.Text = Convert.ToString(dgvcliente.Rows[0].Cells[0].Value);
            txbNome.Text = Convert.ToString(dgvcliente.Rows[0].Cells[1].Value);
            txbTelefone.Text = Convert.ToString(dgvcliente.Rows[0].Cells[2].Value);

            txbCarro.Text = Convert.ToString(dgvveiculo.Rows[0].Cells[1].Value);
            txbPlaca.Text = Convert.ToString(dgvveiculo.Rows[0].Cells[2].Value);

            tbqte01.Text = Convert.ToString(dgvServiço.Rows[0].Cells[3].Value);
            tbqte02.Text = Convert.ToString(dgvServiço.Rows[1].Cells[3].Value);
            tbqte03.Text = Convert.ToString(dgvServiço.Rows[2].Cells[3].Value);
            tbqte04.Text = Convert.ToString(dgvServiço.Rows[3].Cells[3].Value);
            tbqte05.Text = Convert.ToString(dgvServiço.Rows[4].Cells[3].Value);

            tbdesc01.Text = Convert.ToString(dgvServiço.Rows[0].Cells[2].Value);
            tbdesc02.Text = Convert.ToString(dgvServiço.Rows[1].Cells[2].Value);
            tbdesc03.Text = Convert.ToString(dgvServiço.Rows[2].Cells[2].Value);
            tbdesc04.Text = Convert.ToString(dgvServiço.Rows[3].Cells[2].Value);
            tbdesc05.Text = Convert.ToString(dgvServiço.Rows[4].Cells[2].Value);

            tbvalor01.Text = Convert.ToString(dgvServiço.Rows[0].Cells[4].Value);
            tbvalor02.Text = Convert.ToString(dgvServiço.Rows[1].Cells[4].Value);
            tbvalor03.Text = Convert.ToString(dgvServiço.Rows[2].Cells[4].Value);
            tbvalor04.Text = Convert.ToString(dgvServiço.Rows[3].Cells[4].Value);
            tbvalor05.Text = Convert.ToString(dgvServiço.Rows[4].Cells[4].Value);
        }
        public void conf()
        {
            if (tbqte01.Text == String.Empty)
            {
                tbqte01.Text = "0";
                tbdesc01.Text = "-";
                tbvalor01.Text = "0";
            }
            if (tbqte02.Text == String.Empty)
            {
                tbqte02.Text = "0";
                tbdesc02.Text = "--";
                tbvalor02.Text = "0";
            }
            if (tbqte03.Text == String.Empty)
            {
                tbqte03.Text = "0";
                tbdesc03.Text = "---";
                tbvalor03.Text = "0";
            }
            if (tbqte04.Text == String.Empty)
            {
                tbqte04.Text = "0";
                tbdesc04.Text = "----";
                tbvalor04.Text = "0";
            }
            if (tbqte05.Text == String.Empty)
            {
                tbqte05.Text = "0";
                tbdesc05.Text = "-----";
                tbvalor05.Text = "0";
            }

            double vtot = (Convert.ToDouble(tbvalor01.Text) * Convert.ToDouble(tbqte01.Text)) + (Convert.ToDouble(tbvalor02.Text) * Convert.ToDouble(tbqte02.Text)) + (Convert.ToDouble(tbvalor03.Text) * Convert.ToDouble(tbqte03.Text)) + (Convert.ToDouble(tbvalor04.Text) * Convert.ToDouble(tbqte04.Text)) + (Convert.ToDouble(tbvalor05.Text) * Convert.ToDouble(tbqte05.Text));
            lbValorTot.Text = Convert.ToString(vtot);
        }

        private void bttodos_Click(object sender, EventArgs e)
        {
            p3.Visible = true;
            p1.Visible = false;
            p2.Visible = false;

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            con.Open();
            DataTable dt = new DataTable();
            string commandText = "SELECT * FROM cliente ORDER BY cpf_cliente";
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }
            dgvtodos.Visible = true;
            dgvtodos.DataSource = dt;

            con.Close();
        }
    }

}

