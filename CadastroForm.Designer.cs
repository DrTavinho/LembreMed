namespace LembreMed
{
    partial class CadastroForm
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
            btnSave = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            txtObservacoes = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAdicionarHora = new Button();
            btnRemoverHora = new Button();
            groupBox2 = new GroupBox();
            txtDose = new TextBox();
            groupBox1 = new GroupBox();
            txtNome = new TextBox();
            groupBox3 = new GroupBox();
            dtpHorario = new DateTimePicker();
            lstHorarios = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            chkAtivo = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(4, 3);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 0;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 5);
            tableLayoutPanel1.Location = new Point(14, 14);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.09302F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.86047F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.58139F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.372093F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.72093F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.372093F));
            tableLayoutPanel1.Size = new Size(348, 496);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(txtObservacoes);
            groupBox4.Location = new Point(4, 387);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(340, 62);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Observações";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.Location = new Point(7, 22);
            txtObservacoes.Margin = new Padding(4, 3, 4, 3);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(325, 23);
            txtObservacoes.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnAdicionarHora);
            flowLayoutPanel2.Controls.Add(btnRemoverHora);
            flowLayoutPanel2.Location = new Point(4, 346);
            flowLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(340, 35);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // btnAdicionarHora
            // 
            btnAdicionarHora.Location = new Point(4, 3);
            btnAdicionarHora.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarHora.Name = "btnAdicionarHora";
            btnAdicionarHora.Size = new Size(160, 27);
            btnAdicionarHora.TabIndex = 0;
            btnAdicionarHora.Text = "Adicionar Horário";
            btnAdicionarHora.UseVisualStyleBackColor = true;
            btnAdicionarHora.Click += btnAdicionarHora_Click;
            // 
            // btnRemoverHora
            // 
            btnRemoverHora.Location = new Point(172, 3);
            btnRemoverHora.Margin = new Padding(4, 3, 4, 3);
            btnRemoverHora.Name = "btnRemoverHora";
            btnRemoverHora.Size = new Size(161, 27);
            btnRemoverHora.TabIndex = 1;
            btnRemoverHora.Text = "Remover Horário";
            btnRemoverHora.UseVisualStyleBackColor = true;
            btnRemoverHora.Click += btnRemoverHora_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtDose);
            groupBox2.Location = new Point(4, 62);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(340, 52);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dose";
            // 
            // txtDose
            // 
            txtDose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDose.Location = new Point(7, 22);
            txtDose.Margin = new Padding(4, 3, 4, 3);
            txtDose.Name = "txtDose";
            txtDose.Size = new Size(325, 23);
            txtDose.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(340, 53);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medicamento";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(7, 22);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(325, 23);
            txtNome.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dtpHorario);
            groupBox3.Controls.Add(lstHorarios);
            groupBox3.Location = new Point(4, 120);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(340, 220);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Horários";
            // 
            // dtpHorario
            // 
            dtpHorario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpHorario.Format = DateTimePickerFormat.Time;
            dtpHorario.Location = new Point(7, 190);
            dtpHorario.Margin = new Padding(4, 3, 4, 3);
            dtpHorario.Name = "dtpHorario";
            dtpHorario.ShowUpDown = true;
            dtpHorario.Size = new Size(325, 23);
            dtpHorario.TabIndex = 6;
            // 
            // lstHorarios
            // 
            lstHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstHorarios.FormattingEnabled = true;
            lstHorarios.ItemHeight = 15;
            lstHorarios.Location = new Point(7, 22);
            lstHorarios.Margin = new Padding(4, 3, 4, 3);
            lstHorarios.Name = "lstHorarios";
            lstHorarios.Size = new Size(325, 139);
            lstHorarios.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(chkAtivo);
            flowLayoutPanel1.Location = new Point(4, 455);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(340, 38);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(100, 3);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(196, 3);
            chkAtivo.Margin = new Padding(4, 3, 4, 3);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(59, 19);
            chkAtivo.TabIndex = 2;
            chkAtivo.Text = "Ativo?";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 524);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(392, 563);
            Name = "CadastroForm";
            Text = "Formulário de Cadastro";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstHorarios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAdicionarHora;
        private System.Windows.Forms.Button btnRemoverHora;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}