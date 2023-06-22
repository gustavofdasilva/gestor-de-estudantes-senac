namespace gestor_de_estudantes
{
    partial class FormInserirEstudante
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
            this.components = new System.ComponentModel.Container();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelFoto = new System.Windows.Forms.Label();
            this.buttonEnviarFoto = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(29, 30);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(62, 24);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(225, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(223, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(225, 73);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(223, 20);
            this.textBoxSobrenome.TabIndex = 3;
            this.textBoxSobrenome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.Location = new System.Drawing.Point(29, 73);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(110, 24);
            this.labelSobrenome.TabIndex = 2;
            this.labelSobrenome.Text = "Sobrenome";
            this.labelSobrenome.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(225, 123);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerNascimento.TabIndex = 4;
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(29, 119);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(176, 24);
            this.labelNascimento.TabIndex = 5;
            this.labelNascimento.Text = "Data de nascimento";
            this.labelNascimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(29, 175);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(74, 24);
            this.labelGenero.TabIndex = 6;
            this.labelGenero.Text = "Gênero";
            this.labelGenero.Click += new System.EventHandler(this.label4_Click);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 7);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 7;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(150, 7);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 8;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(225, 228);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(223, 20);
            this.textBoxTelefone.TabIndex = 10;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(29, 228);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(85, 24);
            this.labelTelefone.TabIndex = 9;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(225, 272);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(223, 24);
            this.textBoxEndereco.TabIndex = 12;
            this.textBoxEndereco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(29, 272);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(94, 24);
            this.labelEndereco.TabIndex = 11;
            this.labelEndereco.Text = "Endereço";
            this.labelEndereco.Click += new System.EventHandler(this.label6_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(268, 315);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(139, 123);
            this.pictureBoxFoto.TabIndex = 13;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoto.Location = new System.Drawing.Point(29, 315);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(48, 24);
            this.labelFoto.TabIndex = 14;
            this.labelFoto.Text = "Foto";
            // 
            // buttonEnviarFoto
            // 
            this.buttonEnviarFoto.Location = new System.Drawing.Point(268, 444);
            this.buttonEnviarFoto.Name = "buttonEnviarFoto";
            this.buttonEnviarFoto.Size = new System.Drawing.Size(139, 23);
            this.buttonEnviarFoto.TabIndex = 15;
            this.buttonEnviarFoto.Text = "Enviar foto";
            this.buttonEnviarFoto.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(33, 514);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(200, 64);
            this.buttonCadastrar.TabIndex = 16;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(239, 514);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(209, 64);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Location = new System.Drawing.Point(225, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 31);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEnviarFoto);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.MaximumSize = new System.Drawing.Size(476, 629);
            this.MinimumSize = new System.Drawing.Size(476, 629);
            this.Name = "FormInserirEstudante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInserirEstudante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Button buttonEnviarFoto;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}