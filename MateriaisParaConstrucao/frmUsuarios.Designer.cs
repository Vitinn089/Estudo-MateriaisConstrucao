namespace MateriaisParaConstrucao
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNiveis = new System.Windows.Forms.ToolStripButton();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripLabel2,
            this.btnSalvar,
            this.toolStripSeparator1,
            this.btnNiveis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(424, 68);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MateriaisParaConstrucao.Properties.Resources.novo;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 55);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 65);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 55);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // btnNiveis
            // 
            this.btnNiveis.Image = global::MateriaisParaConstrucao.Properties.Resources.niveis;
            this.btnNiveis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNiveis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNiveis.Name = "btnNiveis";
            this.btnNiveis.Size = new System.Drawing.Size(43, 65);
            this.btnNiveis.Text = "Níveis";
            this.btnNiveis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNiveis.Click += new System.EventHandler(this.btnNiveis_Click);
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(302, 80);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(105, 22);
            this.dtpDataCadastro.TabIndex = 105;
            this.dtpDataCadastro.TabStop = false;
            // 
            // txtSenha2
            // 
            this.txtSenha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSenha2.Location = new System.Drawing.Point(289, 169);
            this.txtSenha2.MaxLength = 50;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(118, 22);
            this.txtSenha2.TabIndex = 104;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSenha.Location = new System.Drawing.Point(88, 169);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(108, 22);
            this.txtSenha.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 102;
            this.label7.Text = "Nível:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Redigite:";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLogin.Location = new System.Drawing.Point(88, 140);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(108, 22);
            this.txtLogin.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Data de cadastro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 101;
            this.label5.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(88, 111);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 22);
            this.txtNome.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Login:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(88, 83);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(49, 22);
            this.txtCodigo.TabIndex = 97;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 96;
            this.label9.Text = "Código:";
            // 
            // cboNivel
            // 
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.ItemHeight = 16;
            this.cboNivel.Location = new System.Drawing.Point(260, 138);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(147, 24);
            this.cboNivel.TabIndex = 106;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 16;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(88, 197);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(108, 24);
            this.cboStatus.TabIndex = 106;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToResizeColumns = false;
            this.dtgUsuarios.AllowUserToResizeRows = false;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USUARIO,
            this.NOME_USUARIO,
            this.DATA_CADASTRO,
            this.LOGIN_USUARIO,
            this.SENHA_USUARIO,
            this.STATUS_USUARIO,
            this.ID_NIVEL,
            this.NOME_NIVEL,
            this.btnEditar,
            this.btnExcluir});
            this.dtgUsuarios.Location = new System.Drawing.Point(17, 238);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(390, 184);
            this.dtgUsuarios.TabIndex = 107;
            this.dtgUsuarios.TabStop = false;
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataPropertyName = "ID_USUARIO";
            this.ID_USUARIO.HeaderText = "Código";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.ReadOnly = true;
            this.ID_USUARIO.Visible = false;
            // 
            // NOME_USUARIO
            // 
            this.NOME_USUARIO.DataPropertyName = "NOME_USUARIO";
            this.NOME_USUARIO.HeaderText = "Nome";
            this.NOME_USUARIO.Name = "NOME_USUARIO";
            this.NOME_USUARIO.ReadOnly = true;
            this.NOME_USUARIO.Visible = false;
            // 
            // DATA_CADASTRO
            // 
            this.DATA_CADASTRO.DataPropertyName = "DATA_CADASTRO";
            this.DATA_CADASTRO.HeaderText = "Data";
            this.DATA_CADASTRO.Name = "DATA_CADASTRO";
            this.DATA_CADASTRO.ReadOnly = true;
            this.DATA_CADASTRO.Visible = false;
            // 
            // LOGIN_USUARIO
            // 
            this.LOGIN_USUARIO.DataPropertyName = "LOGIN_USUARIO";
            this.LOGIN_USUARIO.HeaderText = "Login";
            this.LOGIN_USUARIO.Name = "LOGIN_USUARIO";
            this.LOGIN_USUARIO.ReadOnly = true;
            this.LOGIN_USUARIO.Width = 120;
            // 
            // SENHA_USUARIO
            // 
            this.SENHA_USUARIO.DataPropertyName = "SENHA_USUARIO";
            this.SENHA_USUARIO.HeaderText = "Senha";
            this.SENHA_USUARIO.Name = "SENHA_USUARIO";
            this.SENHA_USUARIO.ReadOnly = true;
            this.SENHA_USUARIO.Visible = false;
            // 
            // STATUS_USUARIO
            // 
            this.STATUS_USUARIO.DataPropertyName = "STATUS_USUARIO";
            this.STATUS_USUARIO.HeaderText = "Status";
            this.STATUS_USUARIO.Name = "STATUS_USUARIO";
            this.STATUS_USUARIO.ReadOnly = true;
            // 
            // ID_NIVEL
            // 
            this.ID_NIVEL.DataPropertyName = "ID_NIVEL";
            this.ID_NIVEL.HeaderText = "id_Nivel";
            this.ID_NIVEL.Name = "ID_NIVEL";
            this.ID_NIVEL.ReadOnly = true;
            this.ID_NIVEL.Visible = false;
            // 
            // NOME_NIVEL
            // 
            this.NOME_NIVEL.DataPropertyName = "NOME_NIVEL";
            this.NOME_NIVEL.HeaderText = "Nível";
            this.NOME_NIVEL.Name = "NOME_NIVEL";
            this.NOME_NIVEL.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::MateriaisParaConstrucao.Properties.Resources.editar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Width = 30;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::MateriaisParaConstrucao.Properties.Resources.excluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Width = 30;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 434);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Usuário";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnNiveis;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGIN_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_NIVEL;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}