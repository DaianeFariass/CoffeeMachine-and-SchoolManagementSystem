namespace TP_de_Avaliação_DaianeFarias
{
    partial class frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Terminar = new System.Windows.Forms.Button();
            this.btn_InserirDados = new System.Windows.Forms.Button();
            this.btn_GuardarFicheiro = new System.Windows.Forms.Button();
            this.btn_GerirDados = new System.Windows.Forms.Button();
            this.btn_LerFicheiro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestão de Dados Pessoais dos Alunos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.btn_Terminar);
            this.panel2.Controls.Add(this.btn_InserirDados);
            this.panel2.Controls.Add(this.btn_GuardarFicheiro);
            this.panel2.Controls.Add(this.btn_GerirDados);
            this.panel2.Controls.Add(this.btn_LerFicheiro);
            this.panel2.Location = new System.Drawing.Point(-1, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 376);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Terminar
            // 
            this.btn_Terminar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Terminar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Terminar.ForeColor = System.Drawing.Color.White;
            this.btn_Terminar.Location = new System.Drawing.Point(5, 245);
            this.btn_Terminar.Name = "btn_Terminar";
            this.btn_Terminar.Size = new System.Drawing.Size(250, 50);
            this.btn_Terminar.TabIndex = 2;
            this.btn_Terminar.Text = "Terminar";
            this.btn_Terminar.UseVisualStyleBackColor = false;
            this.btn_Terminar.Click += new System.EventHandler(this.btn_Terminar_Click);
            this.btn_Terminar.MouseEnter += new System.EventHandler(this.SelecionarBotao);
            this.btn_Terminar.MouseLeave += new System.EventHandler(this.DesmarcarBotao);
            // 
            // btn_InserirDados
            // 
            this.btn_InserirDados.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_InserirDados.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_InserirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserirDados.ForeColor = System.Drawing.Color.White;
            this.btn_InserirDados.Location = new System.Drawing.Point(5, 5);
            this.btn_InserirDados.Name = "btn_InserirDados";
            this.btn_InserirDados.Size = new System.Drawing.Size(250, 50);
            this.btn_InserirDados.TabIndex = 2;
            this.btn_InserirDados.Text = "Inserir Dados";
            this.btn_InserirDados.UseVisualStyleBackColor = false;
            this.btn_InserirDados.Click += new System.EventHandler(this.btn_InserirDados_Click);
            this.btn_InserirDados.MouseEnter += new System.EventHandler(this.SelecionarBotao);
            this.btn_InserirDados.MouseLeave += new System.EventHandler(this.DesmarcarBotao);
            // 
            // btn_GuardarFicheiro
            // 
            this.btn_GuardarFicheiro.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_GuardarFicheiro.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_GuardarFicheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarFicheiro.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarFicheiro.Location = new System.Drawing.Point(5, 185);
            this.btn_GuardarFicheiro.Name = "btn_GuardarFicheiro";
            this.btn_GuardarFicheiro.Size = new System.Drawing.Size(250, 50);
            this.btn_GuardarFicheiro.TabIndex = 2;
            this.btn_GuardarFicheiro.Text = "Guardar Ficheiro";
            this.btn_GuardarFicheiro.UseVisualStyleBackColor = false;
            this.btn_GuardarFicheiro.Click += new System.EventHandler(this.btn_GuardarFicheiro_Click);
            this.btn_GuardarFicheiro.MouseEnter += new System.EventHandler(this.SelecionarBotao);
            this.btn_GuardarFicheiro.MouseLeave += new System.EventHandler(this.DesmarcarBotao);
            // 
            // btn_GerirDados
            // 
            this.btn_GerirDados.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_GerirDados.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_GerirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerirDados.ForeColor = System.Drawing.Color.White;
            this.btn_GerirDados.Location = new System.Drawing.Point(5, 65);
            this.btn_GerirDados.Name = "btn_GerirDados";
            this.btn_GerirDados.Size = new System.Drawing.Size(250, 50);
            this.btn_GerirDados.TabIndex = 2;
            this.btn_GerirDados.Text = "Gerir Dados";
            this.btn_GerirDados.UseVisualStyleBackColor = false;
            this.btn_GerirDados.Click += new System.EventHandler(this.btn_GerirDados_Click);
            this.btn_GerirDados.MouseEnter += new System.EventHandler(this.SelecionarBotao);
            this.btn_GerirDados.MouseLeave += new System.EventHandler(this.DesmarcarBotao);
            // 
            // btn_LerFicheiro
            // 
            this.btn_LerFicheiro.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_LerFicheiro.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_LerFicheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LerFicheiro.ForeColor = System.Drawing.Color.White;
            this.btn_LerFicheiro.Location = new System.Drawing.Point(5, 125);
            this.btn_LerFicheiro.Name = "btn_LerFicheiro";
            this.btn_LerFicheiro.Size = new System.Drawing.Size(250, 50);
            this.btn_LerFicheiro.TabIndex = 2;
            this.btn_LerFicheiro.Text = "Ler Ficheiro";
            this.btn_LerFicheiro.UseVisualStyleBackColor = false;
            this.btn_LerFicheiro.Click += new System.EventHandler(this.btn_LerFicheiro_Click);
            this.btn_LerFicheiro.MouseEnter += new System.EventHandler(this.SelecionarBotao);
            this.btn_LerFicheiro.MouseLeave += new System.EventHandler(this.DesmarcarBotao);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_de_Avaliação_DaianeFarias.Properties.Resources.logotipo_da_escola_ícone_graduação_faculdade_educação_137290284__1_;
            this.pictureBox1.Location = new System.Drawing.Point(260, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Abrir Ficheiro";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Guardar Ficheiro";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Del Valle International School";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_Terminar;
        private Button btn_InserirDados;
        private Button btn_GuardarFicheiro;
        private Button btn_GerirDados;
        private Button btn_LerFicheiro;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}