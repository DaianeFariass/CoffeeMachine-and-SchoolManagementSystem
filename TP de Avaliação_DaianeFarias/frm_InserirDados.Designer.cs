namespace TP_de_Avaliação_DaianeFarias
{
    partial class frm_InserirDados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Terminar = new System.Windows.Forms.Button();
            this.btn_InserirDados = new System.Windows.Forms.Button();
            this.la = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Turma = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumeroAlunos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestão de Dados Pessoais dos Alunos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_Terminar);
            this.panel1.Controls.Add(this.btn_InserirDados);
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 69);
            this.panel1.TabIndex = 5;
            // 
            // btn_Terminar
            // 
            this.btn_Terminar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Terminar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Terminar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Terminar.ForeColor = System.Drawing.Color.White;
            this.btn_Terminar.Location = new System.Drawing.Point(306, 0);
            this.btn_Terminar.Name = "btn_Terminar";
            this.btn_Terminar.Size = new System.Drawing.Size(250, 50);
            this.btn_Terminar.TabIndex = 7;
            this.btn_Terminar.Text = "Terminar";
            this.btn_Terminar.UseVisualStyleBackColor = false;
            // 
            // btn_InserirDados
            // 
            this.btn_InserirDados.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_InserirDados.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_InserirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserirDados.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_InserirDados.ForeColor = System.Drawing.Color.White;
            this.btn_InserirDados.Location = new System.Drawing.Point(23, 2);
            this.btn_InserirDados.Name = "btn_InserirDados";
            this.btn_InserirDados.Size = new System.Drawing.Size(250, 50);
            this.btn_InserirDados.TabIndex = 6;
            this.btn_InserirDados.Text = "Inserir Dados";
            this.btn_InserirDados.UseVisualStyleBackColor = false;
            this.btn_InserirDados.Click += new System.EventHandler(this.btn_InserirDados_Click);
            // 
            // la
            // 
            this.la.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.la.Location = new System.Drawing.Point(12, 123);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(187, 35);
            this.la.TabIndex = 6;
            this.la.Text = "Nº de Alunos:";
            this.la.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota Final:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Turma
            // 
            this.txt_Turma.BackColor = System.Drawing.Color.Bisque;
            this.txt_Turma.Location = new System.Drawing.Point(219, 81);
            this.txt_Turma.Name = "txt_Turma";
            this.txt_Turma.Size = new System.Drawing.Size(147, 31);
            this.txt_Turma.TabIndex = 1;
            this.txt_Turma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Turma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Turma_KeyPress);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.Bisque;
            this.txt_Nome.Location = new System.Drawing.Point(219, 173);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(347, 31);
            this.txt_Nome.TabIndex = 3;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.Bisque;
            this.txt_Codigo.Location = new System.Drawing.Point(219, 219);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(147, 31);
            this.txt_Codigo.TabIndex = 4;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // txt_Nota
            // 
            this.txt_Nota.BackColor = System.Drawing.Color.Bisque;
            this.txt_Nota.Location = new System.Drawing.Point(219, 265);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(147, 31);
            this.txt_Nota.TabIndex = 5;
            this.txt_Nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nota_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turma:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_NumeroAlunos
            // 
            this.txt_NumeroAlunos.BackColor = System.Drawing.Color.Bisque;
            this.txt_NumeroAlunos.Location = new System.Drawing.Point(219, 127);
            this.txt_NumeroAlunos.Name = "txt_NumeroAlunos";
            this.txt_NumeroAlunos.Size = new System.Drawing.Size(147, 31);
            this.txt_NumeroAlunos.TabIndex = 2;
            this.txt_NumeroAlunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NumeroAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumeroAlunos_KeyPress);
            // 
            // frm_InserirDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 377);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_NumeroAlunos);
            this.Controls.Add(this.txt_Turma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.la);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimizeBox = false;
            this.Name = "frm_InserirDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_InserirDados";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label la;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Turma;
        private TextBox txt_Nome;
        private TextBox txt_Codigo;
        private TextBox txt_Nota;
        private Button btn_Terminar;
        private Button btn_InserirDados;
        private Label label2;
        private TextBox txt_NumeroAlunos;
    }
}