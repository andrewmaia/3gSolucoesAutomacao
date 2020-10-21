namespace _3gSolucoesAutomacao
{
    partial class FrmOrdemServicoCadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataRetirada = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricaoProblema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpDataRetirada);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdicionarCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEquipamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricaoProblema);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDataEntrada);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 298);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data de Retirada";
            // 
            // dtpDataRetirada
            // 
            this.dtpDataRetirada.Enabled = false;
            this.dtpDataRetirada.Location = new System.Drawing.Point(113, 259);
            this.dtpDataRetirada.Name = "dtpDataRetirada";
            this.dtpDataRetirada.Size = new System.Drawing.Size(220, 20);
            this.dtpDataRetirada.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 26);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(220, 20);
            this.txtID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Código";
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(339, 53);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(28, 23);
            this.btnAdicionarCliente.TabIndex = 2;
            this.btnAdicionarCliente.Text = "...";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "Text";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aguardando Orçamento",
            "Em Aprovação",
            "Aguardando Peça para Orçamento",
            "Aprovado",
            "Pronto para Retirada",
            "Finalizada"});
            this.cbStatus.Location = new System.Drawing.Point(113, 221);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(220, 21);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.ValueMember = "Value";
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Equipamento";
            // 
            // txtEquipamento
            // 
            this.txtEquipamento.Location = new System.Drawing.Point(113, 108);
            this.txtEquipamento.MaxLength = 200;
            this.txtEquipamento.Name = "txtEquipamento";
            this.txtEquipamento.Size = new System.Drawing.Size(220, 20);
            this.txtEquipamento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descrição Problema";
            // 
            // txtDescricaoProblema
            // 
            this.txtDescricaoProblema.Location = new System.Drawing.Point(113, 134);
            this.txtDescricaoProblema.Multiline = true;
            this.txtDescricaoProblema.Name = "txtDescricaoProblema";
            this.txtDescricaoProblema.Size = new System.Drawing.Size(220, 81);
            this.txtDescricaoProblema.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data de Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(113, 82);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(220, 20);
            this.dtpDataEntrada.TabIndex = 3;
            // 
            // cbCliente
            // 
            this.cbCliente.DisplayMember = "Nome";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(113, 55);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(220, 21);
            this.cbCliente.TabIndex = 1;
            this.cbCliente.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(83, 332);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(164, 332);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Nova";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(245, 332);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmOrdemServicoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 371);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOrdemServicoCadastro";
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.FrmOrdemServicoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEquipamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricaoProblema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataRetirada;
    }
}