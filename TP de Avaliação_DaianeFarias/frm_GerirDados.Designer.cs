namespace TP_de_Avaliação_DaianeFarias
{
    partial class frm_GerirDados
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Terminar = new System.Windows.Forms.Button();
            this.btn_ListarDados = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.lst_DadosALunos = new System.Windows.Forms.ListView();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Turma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Media = new System.Windows.Forms.Button();
            this.btn_NotaMaxima = new System.Windows.Forms.Button();
            this.btn_NotaMinima = new System.Windows.Forms.Button();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.lbl_Maxima = new System.Windows.Forms.Label();
            this.lbl_Minima = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestão de Dados de Alunos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.btn_Terminar);
            this.panel2.Controls.Add(this.btn_ListarDados);
            this.panel2.Controls.Add(this.btn_Adicionar);
            this.panel2.Controls.Add(this.btn_Alterar);
            this.panel2.Controls.Add(this.btn_Procurar);
            this.panel2.Controls.Add(this.btn_Remover);
            this.panel2.Location = new System.Drawing.Point(-3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 503);
            this.panel2.TabIndex = 6;
            // 
            // btn_Terminar
            // 
            this.btn_Terminar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Terminar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Terminar.ForeColor = System.Drawing.Color.White;
            this.btn_Terminar.Location = new System.Drawing.Point(5, 441);
            this.btn_Terminar.Name = "btn_Terminar";
            this.btn_Terminar.Size = new System.Drawing.Size(197, 50);
            this.btn_Terminar.TabIndex = 2;
            this.btn_Terminar.Text = "Terminar";
            this.btn_Terminar.UseVisualStyleBackColor = false;
            this.btn_Terminar.Click += new System.EventHandler(this.btn_Terminar_Click);
            // 
            // btn_ListarDados
            // 
            this.btn_ListarDados.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ListarDados.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_ListarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListarDados.ForeColor = System.Drawing.Color.White;
            this.btn_ListarDados.Location = new System.Drawing.Point(5, 9);
            this.btn_ListarDados.Name = "btn_ListarDados";
            this.btn_ListarDados.Size = new System.Drawing.Size(197, 50);
            this.btn_ListarDados.TabIndex = 2;
            this.btn_ListarDados.Text = "Listar";
            this.btn_ListarDados.UseVisualStyleBackColor = false;
            this.btn_ListarDados.Click += new System.EventHandler(this.btn_ListarDados_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_Adicionar.Location = new System.Drawing.Point(5, 253);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(197, 50);
            this.btn_Adicionar.TabIndex = 2;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Alterar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.btn_Alterar.Location = new System.Drawing.Point(5, 192);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(197, 50);
            this.btn_Alterar.TabIndex = 2;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Procurar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Procurar.ForeColor = System.Drawing.Color.White;
            this.btn_Procurar.Location = new System.Drawing.Point(5, 70);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(197, 50);
            this.btn_Procurar.TabIndex = 2;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = false;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Remover.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.ForeColor = System.Drawing.Color.White;
            this.btn_Remover.Location = new System.Drawing.Point(5, 131);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(197, 50);
            this.btn_Remover.TabIndex = 2;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // lst_DadosALunos
            // 
            this.lst_DadosALunos.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_DadosALunos.Location = new System.Drawing.Point(225, 66);
            this.lst_DadosALunos.Name = "lst_DadosALunos";
            this.lst_DadosALunos.Size = new System.Drawing.Size(659, 319);
            this.lst_DadosALunos.TabIndex = 7;
            this.lst_DadosALunos.UseCompatibleStateImageBehavior = false;
            // 
            // txt_Nota
            // 
            this.txt_Nota.BackColor = System.Drawing.Color.Bisque;
            this.txt_Nota.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nota.Location = new System.Drawing.Point(364, 530);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(147, 31);
            this.txt_Nota.TabIndex = 11;
            this.txt_Nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nota_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.Bisque;
            this.txt_Codigo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Codigo.Location = new System.Drawing.Point(364, 483);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(147, 31);
            this.txt_Codigo.TabIndex = 10;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.Bisque;
            this.txt_Nome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nome.Location = new System.Drawing.Point(354, 436);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(170, 31);
            this.txt_Nome.TabIndex = 9;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota Final:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Código:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Turma
            // 
            this.txt_Turma.BackColor = System.Drawing.Color.Bisque;
            this.txt_Turma.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Turma.Location = new System.Drawing.Point(364, 389);
            this.txt_Turma.Name = "txt_Turma";
            this.txt_Turma.Size = new System.Drawing.Size(147, 31);
            this.txt_Turma.TabIndex = 15;
            this.txt_Turma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Turma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Turma_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Turma:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Media
            // 
            this.btn_Media.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Media.ForeColor = System.Drawing.Color.White;
            this.btn_Media.Location = new System.Drawing.Point(542, 394);
            this.btn_Media.Name = "btn_Media";
            this.btn_Media.Size = new System.Drawing.Size(170, 46);
            this.btn_Media.TabIndex = 16;
            this.btn_Media.Text = "Média Notas:";
            this.btn_Media.UseVisualStyleBackColor = false;
            this.btn_Media.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_NotaMaxima
            // 
            this.btn_NotaMaxima.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_NotaMaxima.ForeColor = System.Drawing.Color.White;
            this.btn_NotaMaxima.Location = new System.Drawing.Point(542, 454);
            this.btn_NotaMaxima.Name = "btn_NotaMaxima";
            this.btn_NotaMaxima.Size = new System.Drawing.Size(170, 46);
            this.btn_NotaMaxima.TabIndex = 16;
            this.btn_NotaMaxima.Text = "Nota Máxima:";
            this.btn_NotaMaxima.UseVisualStyleBackColor = false;
            this.btn_NotaMaxima.Click += new System.EventHandler(this.btn_NotaMaxima_Click);
            // 
            // btn_NotaMinima
            // 
            this.btn_NotaMinima.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_NotaMinima.ForeColor = System.Drawing.Color.White;
            this.btn_NotaMinima.Location = new System.Drawing.Point(542, 507);
            this.btn_NotaMinima.Name = "btn_NotaMinima";
            this.btn_NotaMinima.Size = new System.Drawing.Size(170, 46);
            this.btn_NotaMinima.TabIndex = 16;
            this.btn_NotaMinima.Text = "Nota Miníma:";
            this.btn_NotaMinima.UseVisualStyleBackColor = false;
            this.btn_NotaMinima.Click += new System.EventHandler(this.btn_NotaMinima_Click);
            // 
            // lbl_Media
            // 
            this.lbl_Media.BackColor = System.Drawing.Color.Bisque;
            this.lbl_Media.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Media.Location = new System.Drawing.Point(734, 394);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(121, 46);
            this.lbl_Media.TabIndex = 17;
            this.lbl_Media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Maxima
            // 
            this.lbl_Maxima.BackColor = System.Drawing.Color.Bisque;
            this.lbl_Maxima.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Maxima.Location = new System.Drawing.Point(734, 450);
            this.lbl_Maxima.Name = "lbl_Maxima";
            this.lbl_Maxima.Size = new System.Drawing.Size(121, 46);
            this.lbl_Maxima.TabIndex = 17;
            this.lbl_Maxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Minima
            // 
            this.lbl_Minima.BackColor = System.Drawing.Color.Bisque;
            this.lbl_Minima.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Minima.Location = new System.Drawing.Point(734, 506);
            this.lbl_Minima.Name = "lbl_Minima";
            this.lbl_Minima.Size = new System.Drawing.Size(121, 46);
            this.lbl_Minima.TabIndex = 17;
            this.lbl_Minima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_GerirDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 567);
            this.Controls.Add(this.lbl_Minima);
            this.Controls.Add(this.lbl_Maxima);
            this.Controls.Add(this.lbl_Media);
            this.Controls.Add(this.btn_NotaMinima);
            this.Controls.Add(this.btn_NotaMaxima);
            this.Controls.Add(this.btn_Media);
            this.Controls.Add(this.txt_Turma);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_DadosALunos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.Name = "frm_GerirDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_GerirDados";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button btn_Terminar;
        private Button btn_ListarDados;
        private Button btn_Alterar;
        private Button btn_Procurar;
        private Button btn_Remover;
        private Button btn_Adicionar;
        private ListView lst_DadosALunos;
        private TextBox txt_Nota;
        private TextBox txt_Codigo;
        private TextBox txt_Nome;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_Turma;
        private Label label2;
        private Button btn_Media;
        private Button btn_NotaMaxima;
        private Button btn_NotaMinima;
        private Label lbl_Media;
        private Label lbl_Maxima;
        private Label lbl_Minima;
    }
}