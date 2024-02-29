using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionario cadFuncionarios = new cadastroFuncionario();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCPF.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionario {cadFuncionarios.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastar funcionário!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals(""))
                {
                    cadastroFuncionario cadFuncionarios = new cadastroFuncionario();
                    cadFuncionarios.Cpf = txtCPF.Text;

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado!");
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtCPF.Clear();
                            txtEndereco.Clear();
                            txtCPF.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF para realizar a pesquisa!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao encontrar funcionário: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionario cadFuncionario = new cadastroFuncionario();
                    cadFuncionario.Id = int.Parse(lblId.Text);
                    cadFuncionario.Email = txtEmail.Text;
                    cadFuncionario.Endereco = txtEndereco.Text;

                    if (cadFuncionario.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcionário foram atualizados com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                        txtCPF.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do funcionário!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                        txtCPF.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor localizar o funcionário que deseja atualizar as informações!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    lblId.Text = "";
                    txtCPF.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);
            }
        }
    }
}
