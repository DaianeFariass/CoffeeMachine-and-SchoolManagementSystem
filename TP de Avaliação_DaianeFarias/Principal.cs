namespace TP_de_Avaliação_DaianeFarias
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        // Lista de Alunos da Classe Alunos para armazenar os dados que forem sendo inseridos ou lidos do ficheiro de texto

        List<Aluno> alunos = new List<Aluno>();


        // Método para destacar o botão selecionado mudando a cor de fundo e da letra

        private void SelecionarBotao(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.MidnightBlue;
        }

        //  Método para retirar o realce depois de deixar o botão voltando às cores originais
        private void DesmarcarBotao(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.ForestGreen;
            btn.ForeColor = Color.White;
        }
        // Ao clicar no botão inserir dados abre-se o frm_InserirDados
        private void btn_InserirDados_Click(object sender, EventArgs e)
        {
            frm_InserirDados frmnovo = new frm_InserirDados(ref alunos); // Instância o frm_InserirDados com um novo nome para ser reconhecido no Principal
            frmnovo.ShowDialog(); // Abre o frm_InserirDados 
        }
        // Ao clicar no botão gerir dados abre-se o frm_gerirDados
        private void btn_GerirDados_Click(object sender, EventArgs e)
        {
            frm_GerirDados frmnovo = new frm_GerirDados(ref alunos); // Instância o frm_GerirrDados com um novo nome para ser reconhecido no Principal
            frmnovo.ShowDialog(); // Abre o frm_GerirDados 
            btn_GuardarFicheiro.PerformClick(); // Desencadeia o método guardar ficheiro
        }

        // Carrega o ficheiro de texto selecionado na caixa de diálogo lendo para campo do aluno os dados armazenados
        private void btn_LerFicheiro_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    // Instância um objeto da classe aluno 
                    Aluno al = new Aluno();
                    // Preenche o aluno com os dados lidos do ficheiro
                    al.Turma = sr.ReadLine();
                    al.Nome = sr.ReadLine();
                    al.Codigo = Convert.ToInt32(sr.ReadLine());
                    al.Nota = Convert.ToDouble(sr.ReadLine());
                    // Adiciona o aluno à lista de alunos
                    alunos.Add(al);
                }
                sr.Close();
            }
            else
                MessageBox.Show("Erro na leitura do Ficheiro...");

        }
        // Ao Clicar no botão Guardar Ficheiro é aberto o explorador de ficheiros do pc
        private void btn_GuardarFicheiro_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create); 
                StreamWriter sw = new StreamWriter(fs);

                // Percorrer toda a lista alunos 
                foreach (Aluno al in alunos)
                {
                    sw.WriteLine(al.Turma);
                    sw.WriteLine(al.Nome);
                    sw.WriteLine(al.Codigo.ToString());
                    sw.WriteLine(al.Nota.ToString());
                }
                sw.Close();
            }
            else
                MessageBox.Show("Erro na escrita do ficheiro...");
        }

        private void btn_Terminar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Termina o programa fechando todas as janelas
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}