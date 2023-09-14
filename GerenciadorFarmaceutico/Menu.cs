using GerenciadorFarmaceutico.Classes;
using GerenciadorFarmaceutico.Classes.Pessoas;
using GerenciadorFarmaceutico.Classes.Produtos;
using GerenciadorFarmaceutico.Forms;

namespace GerenciadorFarmaceutico
{
    public partial class Menu : Form
    {
        //forms
        public CadastroPessoa formPessoa;
        public CadastrarProduto formProduto;
        public CadastrarVenda formVenda;
        //Gerenciador


        public Menu()
        {
            SubMain.AddPessoa(new Funcionario(SubMain.maxIdPessoa, "Eduardo", "112.505.729-75", new DateTime(2004, 12, 15), "eduardo.a.cristo2004"));
            SubMain.AddProduto(new Produto(SubMain.maxIdProduto, "Chiclete", "Trident", "3", new DateTime(2023, 11, 23), new DateTime(2024, 12, 15), "123123124", Convert.ToDouble(5.12)));
            SubMain.AddProduto(new Produto(SubMain.maxIdProduto, "Bala", "7belo", "7", new DateTime(2023, 11, 23), new DateTime(2024, 12, 15), "123123124", Convert.ToDouble(2.36)));
            SubMain.AddPessoa(new Cliente(SubMain.maxIdPessoa, "Higor", "12", new DateTime(2003, 12, 15), "aleatoriezando@hotmail.com"));
            formProduto = new CadastrarProduto();
            formPessoa = new CadastroPessoa();
            formVenda = new CadastrarVenda();
            InitializeComponent();
        }

        private void BNewUser_Click(object sender, EventArgs e)
        {
            formPessoa = new CadastroPessoa();
            formPessoa.Show();

        }


        private void B_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BListarClientes_Click(object sender, EventArgs e)
        {
            ListarPessoasTipo<Cliente>();
        }
        //metodo generica para listar especificamente o tipo de dado escolhido
        private void ListarPessoasTipo<T>() where T : Pessoa
        {
            DataHolder.Items.Clear();
            foreach (var Pessoa in SubMain.pessoas)
            {
                if (Pessoa is T typedPerson)
                {
                    DataHolder.Items.Add("Nome: " + typedPerson.nome);
                    DataHolder.Items.Add("id: " + typedPerson.id);
                    DataHolder.Items.Add("cpf: " + typedPerson.cpf);
                    DataHolder.Items.Add("data de nascimento: " + typedPerson.dataNascimento.Day + "/" + typedPerson.dataNascimento.Month + "/" + typedPerson.dataNascimento.Year);
                    DataHolder.Items.Add("Ctps/email: " + typedPerson.GetDataEspecial());
                    DataHolder.Items.Add("");
                }
            }
        }

        private void BListarFuncionarios_Click(object sender, EventArgs e)
        {
            ListarPessoasTipo<Funcionario>();
        }



        private void BNovoProduto_Click(object sender, EventArgs e)
        {
            formProduto = new CadastrarProduto();
            formProduto.Show();


        }

        private void BListarProduto_Click(object sender, EventArgs e)
        {
            ListarProdutosTipo<Produto>();
        }
        //metodo generica para listar especificamente o tipo de dado escolhido
        private void ListarProdutosTipo<T>() where T : Produto
        {
            DataHolder.Items.Clear();
            foreach (var Produto in SubMain.produtos)
            {
                if (typeof(T) == typeof(Produto) && !(Produto is Medicamento) && !(Produto is MedicamentoControlado) && !(Produto is MedicamentoInjetavel))
                {
                    DataOutputForProductListBox(Produto, 1);
                }
                else if (typeof(T) == typeof(Medicamento) && !(Produto is MedicamentoControlado) && !(Produto is MedicamentoInjetavel))
                {
                    if (Produto is Medicamento)
                    {
                        DataOutputForProductListBox(Produto, 2);
                    }
                }
                else if (typeof(T) == typeof(MedicamentoControlado) && !(Produto is MedicamentoInjetavel))
                {
                    if (Produto is MedicamentoControlado)
                    {
                        DataOutputForProductListBox(Produto, 3);
                    }
                }
                else if (typeof(T) == typeof(MedicamentoInjetavel))
                {
                    if (Produto is MedicamentoInjetavel)
                    {
                        DataOutputForProductListBox(Produto, 4);
                    }
                }
            }
        }

        private void BListarMedicamento_Click(object sender, EventArgs e)
        {
            ListarProdutosTipo<Medicamento>();
        }

        private void BListarControlados_Click(object sender, EventArgs e)
        {
            ListarProdutosTipo<MedicamentoControlado>();
        }

        private void BListarInjetaveis_Click(object sender, EventArgs e)
        {
            ListarProdutosTipo<MedicamentoInjetavel>();
        }
        private void DataOutputForProductListBox(Produto typedProduct, int productType)
        {
            DataHolder.Items.Add("Id: " + typedProduct.Id);
            DataHolder.Items.Add("Descrição: " + typedProduct.descricao);
            DataHolder.Items.Add("Marca: " + typedProduct.marca);
            DataHolder.Items.Add("Lote: " + typedProduct.lote);
            DataHolder.Items.Add("Fabricação: " + typedProduct.fabricacao.Day + "/" + typedProduct.fabricacao.Month + "/" + typedProduct.fabricacao.Year);
            DataHolder.Items.Add("Vencimento: " + typedProduct.vencimento.Day + "/" + typedProduct.vencimento.Month + "/" + typedProduct.vencimento.Year);
            DataHolder.Items.Add("Código de barra: " + typedProduct.codigoDeBarras);
            DataHolder.Items.Add("Valor: " + typedProduct.valor);
            if (productType > 1)
            {
                Medicamento medicamento;
                if (productType == 2)
                {
                    medicamento = (Medicamento)Convert.ChangeType(typedProduct, typeof(Medicamento));
                }
                else if (productType == 3)
                {
                    medicamento = (MedicamentoControlado)Convert.ChangeType(typedProduct, typeof(MedicamentoControlado));
                }
                else
                {
                    medicamento = (MedicamentoInjetavel)Convert.ChangeType(typedProduct, typeof(MedicamentoInjetavel));
                }
                DataHolder.Items.Add($"Registro Anvisa: {medicamento.numRegistroAnvisa}");
                DataHolder.Items.Add($"Composição: {medicamento.composicao}");
                DataHolder.Items.Add($"Dosagem: {medicamento.dosagem}");
            }
            DataHolder.Items.Add("");

        }

        private void BNovaVenda_Click(object sender, EventArgs e)
        {
            formVenda = new CadastrarVenda();
            formVenda.Show();
        }

        private void Cadastros_Click(object sender, EventArgs e)
        {

        }

        private void BListarVendas_Click(object sender, EventArgs e)
        {
            DataHolder.Items.Clear();
            foreach(var venda in SubMain.vendas)
            {
                DataHolder.Items.Add("Id Venda: " + venda.id);
                DataHolder.Items.Add("Funcionario Responsavel: " + venda.funcionario.nome);
                DataHolder.Items.Add("Cliente: " + venda.cliente.nome);
                DataHolder.Items.Add("Data da venda: " + venda.data.Day + "/" + venda.data.Month + "/" + venda.data.Year);
                DataHolder.Items.Add("-ITENS: ");
                foreach(var itensVenda in venda.itens)
                {
                    DataHolder.Items.Add("- Produto: " + itensVenda.produto.descricao);
                    DataHolder.Items.Add("-  Valor Unitario: " + itensVenda.produto.valor);
                    DataHolder.Items.Add("-  Quantidade: " + Convert.ToInt32(itensVenda.quantidade));
                }
                DataHolder.Items.Add("Valor dos produtos: " + venda.valorTotal);
                DataHolder.Items.Add("Valor do desconto: "+ venda.desconto);
                DataHolder.Items.Add("Valor final: " + venda.valorProduto);
            }
        }
    }
}