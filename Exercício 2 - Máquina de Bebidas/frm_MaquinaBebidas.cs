namespace Exercício_2___Máquina_de_Bebidas
{
    public partial class frm_MaquinaBebidas : Form
    {  // Variáveis Globais
        double bebidas = 0;
        string moedas = "";
        double saldo = 0;
        double saldoTotal = 0;
        double troco = 0;

        public frm_MaquinaBebidas()
        {  
            InitializeComponent();
            AtivarControlos(); 
            gBox_Moedas.Enabled= false;
            gbox_Troco.Enabled= false;  


        } // Método para ativar os botões das bebibas
        private void AtivarControlos()
        {
            btn_Cafe.Enabled = true;
            btn_Cappuccino.Enabled = true;
            btn_Chocolate.Enabled = true;
            btn_Cha.Enabled = true;

        }
         // Método para inibir os botões das bebidas
        private void InibirControlos()
        {
               
            btn_Cafe.Enabled = false;
            btn_Cappuccino.Enabled = false;
            btn_Chocolate.Enabled = false;
            btn_Cha.Enabled = false;

        }
         // Método para solicitar que o usúario insira a moeda na máquina enquanto desativa os botões para que a máquina
         // libere uma bebida por vez
        private void InserirMoedas()
        {
            MessageBox.Show("Insira a moeda...!");
            gBox_Moedas.Enabled = true;
            InibirControlos();
        
        } 
        // Ao clicar no botão café, cappuccino, chocolate ou chá  é chamado o método insira a moeda
        // onde mostra a messagebox com o texto "Insira a moeda"
        private void btn_Cafe_Click(object sender, EventArgs e)
        {
            bebidas = 0.25;
            InserirMoedas();
           

        }
        private void btn_Cappuccino_Click(object sender, EventArgs e)
        {
            bebidas = 0.30;
            InserirMoedas();
            


        }

        private void btn_Chocolate_Click(object sender, EventArgs e)
        {
            bebidas = 0.35;
            InserirMoedas();
            
        }

        private void btn_Cha_Click(object sender, EventArgs e)
        {
            bebidas = 0.20;
            InserirMoedas();
            
        }
        // Leitura e Validação do RadioButton onde é convertido o sender para o RadioButton
        private void rdButton_CheckedChanged(object sender, EventArgs e) 
        {
            RadioButton rdbt = sender as RadioButton; // Convert o sender para um RadioButton
            if(rdbt != null) 
            {
                if (rdbt.Checked == true) 
                {

                    moedas = rdbt.Text; // Na váriavel global moeda é inserido o valor do RadioButton selecionado
                  

                }

            }

            
        }
        // Ao clicar no botão inserir moeda é realizado a soma dos saldos , apresenta a soma total na label e chama o método comparar saldo
        private void btn_InserirMoedas_Click(object sender, EventArgs e)
        {
            saldo += Convert.ToDouble(moedas); // Soma do saldo conforme for inserindo as moedas
            saldoTotal += Convert.ToDouble(saldo); // Soma do saldo total atualizado
            lbl_SomaMoedas.Text =Math.Round(saldoTotal,2).ToString(); // Apresenta o saldo total na label
            gbox_Troco.Enabled = true;        
            CompararSaldo();

        }
        // Método para comparar o saldo das moedas inseridas com o valor da bebida selecionada
        private void CompararSaldo()
        {
            if (saldo == bebidas)
            {
                lbl_Troco.Text = "Pagamento Concluído";
                btn_InserirMoedas.Enabled = false;
                lbl_FaltaTroco.Text = "Não há troco";
                MessageBox.Show("Muito Obrigado!\nRetire sua bebida :)");

            }
            if (saldo < bebidas)
            {
                
                Math.Round((bebidas -= saldo),2);
                lbl_FaltaTroco.Text = "Falta Moedas:   " +bebidas;
                saldo = 0;
                
            }
            if (saldo > bebidas)
            {
               
                lbl_Troco.Text = "Pagamento Concluído"; 
                troco = Math.Round(saldo - bebidas, 2);
                lbl_FaltaTroco.Text = "Retire seu troco: " + troco;
                MessageBox.Show("Muito Obrigado!\nRetire sua bebida :)");
                DevolverTroco();
            }

        }
        // Método para devolver o troco
        private void DevolverTroco()
        {
            // Array para guardar cada moeda aceita pela máquina.
            double[] moedas2 = new double[6];
            int i = 0;
            while (troco > 0) // Calcúlo do troco de acordo com o pagamento (total de moedas inseridas pelo usúario)
            {
                // Verifica se o troco é maior do que cada moeda guardada no array da maior para a menor)
                if (troco >= 2.0)
                {

                    moedas2[i] = 2.0;
                    troco = Math.Round(troco - 2.00, 2);
                    i++;
                }
                else if (troco >= 1.0)
                {

                    moedas2[i] = 1.0;
                    troco = Math.Round(troco - 1.00, 2);
                    i++;
                }
                else if (troco >= 0.50)
                {


                    moedas2[i] = 0.50;
                    troco = Math.Round(troco - 0.50, 2);
                    i++;
                }
                else if (troco >= 0.20)
                {

                    moedas2[i] = 0.20;
                    troco = Math.Round(troco - 0.20, 2);
                    i++;
                }
                else if (troco >= 0.10)
                {

                    moedas2[i] = 0.10;
                    troco = Math.Round(troco - 0.10, 2);
                    i++;
                }
                else if (troco >= 0.05)
                {

                    moedas2[i] = 0.05;
                    troco = Math.Round(troco - 0.05, 2);
                    i++;
                }
            

            }
            // Devolve o troco com o menor número de moedas possíveis.
            for (int x = 0; x < moedas2.GetLength(0); x++)
            {
                if (moedas2[x] > 0)
                {
                   
                    lbl_Troco.Text = Convert.ToString($"{moedas2[x]} ");
                    MessageBox.Show($" 1 moeda de {moedas2[x]}€");

                }


            }


        }
        // Método para retornar a fazer outro pedido.
        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            saldo = 0;
            saldoTotal= 0;
            if (saldo == 0 && saldoTotal == 0) 
            {
                lbl_SomaMoedas.ResetText();
                lbl_Troco.ResetText();
                lbl_FaltaTroco.ResetText();
                AtivarControlos();
                gBox_Moedas.Enabled = true;
                gbox_Troco.Enabled = true;
                btn_InserirMoedas.Enabled = true;   
                
              
            
  
            }


        }
        // Método para terminar o programa.
        private void btn_Sair_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
