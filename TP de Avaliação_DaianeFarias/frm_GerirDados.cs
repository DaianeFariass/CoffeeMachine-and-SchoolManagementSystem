using System.Linq;
using System.Text.RegularExpressions;

namespace TP_de_Avaliação_DaianeFarias
{
    public partial class frm_GerirDados : Form
    {
        // Referência para uma lista de objetos Aluno
        List<Aluno> alunos;
        public frm_GerirDados(ref List<Aluno> aln)
        {
            InitializeComponent();
            alunos = aln;


        }

        // Cria e Inicializa a ListView adicionando as colunas de cabeçalho
        private void InicializarListView()
        {
            lst_DadosALunos.Columns.Clear();     // Remove os cabeçalhos da coleção
            lst_DadosALunos.View = View.Details; // Visualiza os ítens organizados em colunas 
            lst_DadosALunos.GridLines = true;     // Visualiza as linhas de grelha em modo Details
            lst_DadosALunos.FullRowSelect = true; // Seleciona a linha completa

            // Adiciona os cabeçalho de coluna (4) e defini as dimensões e o alinhamento do texto em cada coluna
            lst_DadosALunos.Columns.Add("Turma", 100, HorizontalAlignment.Center);
            lst_DadosALunos.Columns.Add("Nome", 350, HorizontalAlignment.Left);
            lst_DadosALunos.Columns.Add("Código", 100, HorizontalAlignment.Left);
            lst_DadosALunos.Columns.Add("Nota", 100, HorizontalAlignment.Left);

        }

        // Preenche a listView
        private void PreencherListView()
        {
            // Percorrer a Lista 
            for (int i = 0; i < alunos.Count; i++)
            {
                // Criar um array de 4 strings para armazenar os 4 subitens de cada ítem
                string[] alns = new string[4];
                alns[0] = alunos[i].Turma;
                alns[1] = alunos[i].Nome;
                alns[2] = alunos[i].Codigo.ToString();
                alns[3] = alunos[i].Nota.ToString();

                // Criar uma nova instancia da classe ListViewItem com o array de strings representando os subitens de cada aluno
                // E adiciona esse novo ítem a listview

                lst_DadosALunos.Items.Add(new ListViewItem(alns));

            }

        }
        // Ao clilcar no botão listar inicializa a listview e mostra preenchida com os dados inseridor e salvos 
        private void btn_ListarDados_Click(object sender, EventArgs e)
        {
            lst_DadosALunos.Clear();
            InicializarListView();
            PreencherListView();

        }
        private void txt_Turma_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Faz o cast para char
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Verifica se preencheu a Turma
                if (txt_Turma.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório preencher o campo turma...");
                    txt_Turma.Focus();
                    return;

                }
                // Valida podendo aceitar somente letra
                if (!Regex.IsMatch(txt_Turma.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Entrada Inválida...");
                    txt_Turma.ResetText();
                    txt_Turma.Focus();
                    return;
                }
                txt_Turma.Enabled = false;    // Desativa a caixa de texto Turma após ser preenchida com a letra da Turma
                txt_Nome.Focus();
                e.Handled = true;  // Evento executado
            }


        }


        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo nome
                if (txt_Nome.Text.Length == 0)
                {

                    MessageBox.Show("Obrigatório preencher o campo Nome...");
                    txt_Nome.Focus();
                    return;

                }
                // Lê e Valida podendo aceitar todo o tipo de letra
                if (!Regex.IsMatch(txt_Nome.Text, @"^[a-zà-úA-ZÀ-Ú-'\s]+$"))
                {
                    MessageBox.Show("Entrada Inválida...");
                    txt_Nome.ResetText();
                    txt_Nome.Focus();
                    return;
                }
                txt_Codigo.Enabled = true;
                txt_Codigo.Focus();
                e.Handled = true;  // evento executado


            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                // Verifica se preencheu o campo código
                if (txt_Codigo.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório preencher o campo Código...");
                    txt_Codigo.Focus();
                    return;
                }
                // Lê e Valida do Código do Aluno não podendo repetir
                if (!Regex.IsMatch(txt_Codigo.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_Codigo.ResetText();
                    txt_Codigo.Focus();
                    return;

                }
                txt_Nota.Enabled = true;
                txt_Nota.Focus();
                e.Handled = true;

            }
        }

        private void txt_Nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            double notas;

            if (e.KeyChar == (char)Keys.Enter)
            {
                // Verifica se preencheu o campo nota
                if (txt_Nota.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório preencher o campo Nota...");
                    txt_Nota.Focus();
                    return;
                }
                // Lê e valida a nota ( entre 0 e 20 )
                if (!double.TryParse(txt_Nota.Text, out notas) || notas < 0 || notas > 20)
                {
                    MessageBox.Show("Nota Inválida...");
                    txt_Nota.ResetText();
                    txt_Nota.Focus();
                    return;

                }
                e.Handled = true;


            }
        }
        
        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            // Verifica se preencheu o nome a procurar
            if (txt_Nome.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome a procurar...");
                txt_Nome.Focus();
                return;
            }
            // Procura o nome que é digitado pelo usúario no campo txt_Nome
            foreach (ListViewItem item in lst_DadosALunos.Items)
            {
                if (item.SubItems[1].Text.ToLower().Contains(txt_Nome.Text.ToLower()))
                {
                    lst_DadosALunos.Focus();   // Realça a linha selecionada
                    item.Selected = true;      // Seleciona a linha correspondente ao item
                    lst_DadosALunos.TopItem = item;  // Faz scroll de modo a visualizar o ítem selecionado
                    return;

                }

            }
            // Apresenta mensagem de erro caso o nome não exista na lista
            MessageBox.Show("Não existe na lista...");
            LimparControlos();
            
        }
        // Termina o programa
        private void btn_Terminar_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Remove o ítem/linha selecionada pelo usuário
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (lst_DadosALunos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleciona a pessoa a remover..."); // Nenhum ítem estava selecionado
                return;

            }
            ListViewItem item = lst_DadosALunos.SelectedItems[0];  // Obtém o ítem selecionado
            alunos.RemoveAt(item.Index);                           // Remove o aluno da lista
            lst_DadosALunos.Items.Remove(item);                    // Remove o ítem
            LimparControlos();
        }
        // Permite alterar o nome do aluno
        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            if (lst_DadosALunos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione o aluno para alterar o nome...");
                return;

            }
            if (txt_Nome.Text.Length == 0)
            {
                MessageBox.Show(" Selecione o dado que quer alterar ...."); // Nenhum ítem selecionado
            }
            ListViewItem item = lst_DadosALunos.SelectedItems[0]; // Obtem o ítem selecionado
            lst_DadosALunos.FocusedItem.SubItems[1].Text = txt_Nome.Text; // Altera o nome do aluno no subitem que tem o focus
          

            // Atualiza as alterações no aluno selecionado
            alunos[item.Index].Nome = txt_Nome.Text;
            LimparControlos();
            txt_Nome.Focus();
        }
        // Adiciona um novo aluno a lista
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if ((txt_Turma.Text == "") || (txt_Nome.Text == "") || (txt_Codigo.Text == "") || (txt_Nota.Text == ""))
            {
                MessageBox.Show("Obrigatório preencher todos os campos para adicionar aluno...");
                txt_Turma.Focus();
                return;

            }
            string[] als =
            {
                txt_Turma.Text,
                txt_Nome.Text,
                txt_Codigo.Text,
                txt_Nota.Text,
            };
            // Cria uma nova instancia da classe ListViewItem com o array de strings representando os subítems de cada aluno e adiciona esse novo ítem a ListView
            lst_DadosALunos.Items.Add(new ListViewItem(als));
            //Instancia um novo aluno para depois adicionar a lista
            Aluno aln = new Aluno(txt_Turma.Text, txt_Nome.Text, Convert.ToInt32(txt_Codigo.Text), Convert.ToDouble(txt_Nota.Text));
            alunos.Add(aln);
            LimparControlos();
            txt_Turma.Focus();
        }
        // Método para limpar os controlos
        private void LimparControlos()
        {
            txt_Turma.ResetText();
            txt_Nome.ResetText();
            txt_Codigo.ResetText();
            txt_Nota.ResetText();
            return;


        }
        // Calcula a média dos alunos e exibe na label
        private void button1_Click(object sender, EventArgs e)
        {
            double[] notaFinal = new double[alunos.Count];
            for (int i = 0; i < alunos.Count; i++)
            {
                notaFinal[i] = alunos[i].Nota;


            }
            lbl_Media.Text = (Math.Round(notaFinal.Average(),2)).ToString();
            

        }
        // Verifica e seleciona a nota máxima 
        private void btn_NotaMaxima_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_DadosALunos.Items)
            {
               
                    item.Selected = false;      

            }
            
            double[] notaMaxima = new double[alunos.Count];
            for (int i = 0; i < alunos.Count; i++)
            {
                notaMaxima[i] = alunos[i].Nota;
               

            }
            lbl_Maxima.Text = (Math.Round(notaMaxima.Max(),2).ToString());
            foreach (ListViewItem item in lst_DadosALunos.Items)
            {
                if (item.SubItems[3].Text.Equals(Math.Round(notaMaxima.Max(), 2).ToString()))
                {
                    lst_DadosALunos.Focus();   // Realça a linha selecionada
                    item.Selected = true;      // Seleciona a linha correspondente ao item
                    lst_DadosALunos.TopItem = item;  // Faz scroll de modo a visualizar o ítem selecionado
                    

                }
            }


        }
        // Verifica e seleciona a nota miníma
        private void btn_NotaMinima_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_DadosALunos.Items)
            {

                item.Selected = false;      // Seleciona a linha correspondente ao item

            }
            double[] notaMinima = new double[alunos.Count];
            for (int i = 0; i < alunos.Count; i++)
            {
                notaMinima[i] = alunos[i].Nota;
                
            }
            lbl_Minima.Text = (Math.Round(notaMinima.Min(), 2).ToString());
            foreach (ListViewItem item in lst_DadosALunos.Items)
            {
                if (item.SubItems[3].Text.Equals(Math.Round(notaMinima.Min(), 2).ToString()))
                {
                    lst_DadosALunos.Focus();   // Realça a linha selecionada
                    item.Selected = true;      // Seleciona a linha correspondente ao item
                    lst_DadosALunos.TopItem = item;  // Faz scroll de modo a visualizar o ítem selecionado
                    

                }
            }

        }
    }

}
