namespace _3gSolucoesAutomacao
{
    partial class FrmOrdemServicoConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDataEntrada = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricaoProblema = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoEquipamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(252, 152);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDataEntrada);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricaoProblema);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescricaoEquipamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDataEntrada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chkDataEntrada
            // 
            this.chkDataEntrada.AutoSize = true;
            this.chkDataEntrada.Location = new System.Drawing.Point(631, 75);
            this.chkDataEntrada.Name = "chkDataEntrada";
            this.chkDataEntrada.Size = new System.Drawing.Size(15, 14);
            this.chkDataEntrada.TabIndex = 40;
            this.chkDataEntrada.UseVisualStyleBackColor = true;
            this.chkDataEntrada.CheckedChanged += new System.EventHandler(this.chkDataEntrada_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(59, 19);
            this.txtID.MaxLength = 6;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 20);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "Text";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(59, 72);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(220, 21);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.ValueMember = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descrição Problema";
            // 
            // txtDescricaoProblema
            // 
            this.txtDescricaoProblema.Location = new System.Drawing.Point(404, 45);
            this.txtDescricaoProblema.MaxLength = 50;
            this.txtDescricaoProblema.Name = "txtDescricaoProblema";
            this.txtDescricaoProblema.Size = new System.Drawing.Size(220, 20);
            this.txtDescricaoProblema.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Equipamento";
            // 
            // txtDescricaoEquipamento
            // 
            this.txtDescricaoEquipamento.Location = new System.Drawing.Point(404, 19);
            this.txtDescricaoEquipamento.MaxLength = 50;
            this.txtDescricaoEquipamento.Name = "txtDescricaoEquipamento";
            this.txtDescricaoEquipamento.Size = new System.Drawing.Size(220, 20);
            this.txtDescricaoEquipamento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data de Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Enabled = false;
            this.dtpDataEntrada.Location = new System.Drawing.Point(404, 71);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(220, 20);
            this.dtpDataEntrada.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Código";
            // 
            // cbCliente
            // 
            this.cbCliente.DisplayMember = "Nome";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(59, 45);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(220, 21);
            this.cbCliente.TabIndex = 1;
            this.cbCliente.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cliente";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClienteNome,
            this.DataEntrada,
            this.DescricaoEquipamento,
            this.Status});
            this.dgvConsulta.Location = new System.Drawing.Point(12, 194);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(658, 396);
            this.dgvConsulta.TabIndex = 8;
            this.dgvConsulta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvConsulta_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Format = "#000000";
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // ClienteNome
            // 
            this.ClienteNome.DataPropertyName = "ClienteNome";
            this.ClienteNome.HeaderText = "Cliente";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.ReadOnly = true;
            this.ClienteNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClienteNome.Width = 190;
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DataEntrada";
            this.DataEntrada.HeaderText = "Data de Entrada";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            this.DataEntrada.Width = 110;
            // 
            // DescricaoEquipamento
            // 
            this.DescricaoEquipamento.DataPropertyName = "DescricaoEquipamento";
            this.DescricaoEquipamento.HeaderText = "Equipamento";
            this.DescricaoEquipamento.Name = "DescricaoEquipamento";
            this.DescricaoEquipamento.ReadOnly = true;
            this.DescricaoEquipamento.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(344, 152);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmOrdemServicoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 602);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOrdemServicoConsulta";
            this.Text = "Ordem de Serviço";
            this.Activated += new System.EventHandler(this.FrmOrdemServicoConsulta_Activated);
            this.Load += new System.EventHandler(this.FrmOrdemServicoConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoProblema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricaoEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnLimpar;
    }
}