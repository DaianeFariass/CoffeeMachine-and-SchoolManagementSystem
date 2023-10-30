using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_de_Avaliação_DaianeFarias
{
    public partial class frm_InserirDados : Form
    {
        // Referência para uma lista de objetos Aluno
        List<Aluno> alunos = null; 
        byte numeroAlunos = 0;
      
        public frm_InserirDados(ref List<Aluno> aln)
        {
            InitializeComponent();
            alunos = aln;
            IniciarControlos();
        }
        // Método para Iniciar os controlos
        private void IniciarControlos()
        {
            btn_InserirDados.Enabled = false;
            txt_NumeroAlunos.Enabled= false;
            txt_Nome.Enabled = false;
            txt_Codigo.Enabled = false;
            txt_Nota.Enabled = false;
            txt_Turma.Focus();
            
        }
        // Leitura e validação da turma
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
                txt_NumeroAlunos.Enabled = true;
                txt_NumeroAlunos.Focus();
                e.Handled = true;  // Evento executado
            }
        }
        // Leitura e validação do Número de Alunos
        private void txt_NumeroAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == (char)(Keys.Enter)) 
            {    
                 // Verifica se preencheu o campo Número de Alunos
                 if(txt_NumeroAlunos.Text.Length == 0) 
                 {
                    MessageBox.Show("Obrigatório preencher o campo Nº de Alunos...");
                    txt_NumeroAlunos.Focus();
                    return;

                 }
                 // Lê e Valida o número de Alunos
                 if(!byte.TryParse(txt_NumeroAlunos.Text, out numeroAlunos) || numeroAlunos > 15 )
                 {
                    MessageBox.Show("Entrada Inválida...");
                    txt_NumeroAlunos.ResetText();
                    txt_NumeroAlunos.Focus();
                    return;
                 }
                 txt_NumeroAlunos.Enabled=false; // Desativa a caixa de texto NumeroAlunos após ser preenchido com a quantidade de alunos na turma
                 txt_Nome.Enabled= true;    
                 txt_Nome.Focus();
                 e.Handled = true;
            }
        }
        // Leitura e validação dos Nome do Aluno
        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Enter)) 
            {   // Verifica se preencheu o campo nome
                if(txt_Nome.Text.Length == 0) 
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
                e.Handled = true;   

            }
        }
        // Leitura e validação do Código de cada aluno
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
                // Lê e Validação do Código do Aluno 
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
        // Método para leitura e validação da nota de cada aluno
        private void txt_Nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            double notas;
            
            if(e.KeyChar == (char)Keys.Enter)
            {    
                // Verifica se preencheu o campo nota
                if (txt_Nota.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório preencher o campo Nota...");
                    txt_Nota.Focus();
                    return;
                }
                // Lê e valida a nota ( entre 0 e 20 )
                if (!double.TryParse(txt_Nota.Text, out notas) || notas < 0 || notas > 20 )
                {
                    MessageBox.Show("Nota Inválida...");
                    txt_Nota.ResetText();
                    txt_Nota.Focus();
                    return;

                }
                txt_NumeroAlunos.Enabled= false;
                btn_InserirDados.Enabled = true;
                e.Handled = true;
              
            
            }
        }
        // Ao clicar no botão Inserir é preenchido os dados de cada aluno (um por vez) e guardado na lista
        private void btn_InserirDados_Click(object sender, EventArgs e)
        { 
            if(txt_Nota.Text.Length == 0)  // Verifica de o campo nota está preenchido
            {
                txt_Nota.Focus();
                return;
            }
            // Instancia um objeto da classe Aluno 
            Aluno alu = new Aluno();
            // Preenche os dados dos Alunos
            alu.Turma = txt_Turma.Text;
            alu.Nome = txt_Nome.Text;
            alu.Codigo = Convert.ToInt32(txt_Codigo.Text);
            alu.Nota = Convert.ToDouble(txt_Nota.Text);
            // Adiciona o aluno à lista de alunos
            alunos.Add(alu);
            if(alunos.Count == numeroAlunos)
            {
             
                MessageBox.Show("Turma Completa!");
                txt_Nome.Enabled= false;
                txt_Codigo.Enabled= false;
                txt_Nota.Enabled= false;
                btn_InserirDados.Enabled = false;
                btn_Terminar.Enabled= true;
                btn_Terminar.Focus();
                return;

            }

            LimparControlos();
            txt_Nome.Focus();
            
        }
        // Médodo para limpar os controlos para que o usuário possa inserir outro aluno novamente até chegar o número de alunos daquela turma
        private void LimparControlos()
        {
            txt_Nome.ResetText();
            txt_Codigo.ResetText();
            txt_Nota.ResetText();
            return;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
