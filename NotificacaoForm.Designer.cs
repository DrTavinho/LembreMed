namespace LembreMed
{
    partial class NotificacaoForm
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
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            btnTomei = new Button();
            btnNaoTomei = new Button();
            btnLembrarDepois = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(376, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hora do Remédio!";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(7, 22);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(362, 174);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(354, 87);
            label2.TabIndex = 1;
            label2.Text = "Horário: 08:00";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 87);
            label1.TabIndex = 0;
            label1.Text = "Losartana — 50mg";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTomei
            // 
            btnTomei.Location = new Point(4, 3);
            btnTomei.Margin = new Padding(4, 3, 4, 3);
            btnTomei.Name = "btnTomei";
            btnTomei.Size = new Size(117, 27);
            btnTomei.TabIndex = 1;
            btnTomei.Text = "Tomei";
            btnTomei.UseVisualStyleBackColor = true;
            btnTomei.Click += btnTomei_Click;
            // 
            // btnNaoTomei
            // 
            btnNaoTomei.Location = new Point(129, 3);
            btnNaoTomei.Margin = new Padding(4, 3, 4, 3);
            btnNaoTomei.Name = "btnNaoTomei";
            btnNaoTomei.Size = new Size(117, 27);
            btnNaoTomei.TabIndex = 2;
            btnNaoTomei.Text = "Não Tomei";
            btnNaoTomei.UseVisualStyleBackColor = true;
            btnNaoTomei.Click += btnNaoTomei_Click;
            // 
            // btnLembrarDepois
            // 
            btnLembrarDepois.Location = new Point(254, 3);
            btnLembrarDepois.Margin = new Padding(4, 3, 4, 3);
            btnLembrarDepois.Name = "btnLembrarDepois";
            btnLembrarDepois.Size = new Size(117, 27);
            btnLembrarDepois.TabIndex = 3;
            btnLembrarDepois.Text = "Lembrar Depois";
            btnLembrarDepois.UseVisualStyleBackColor = true;
            btnLembrarDepois.Click += btnLembrarDepois_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Location = new Point(14, 14);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.69014F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.30986F));
            tableLayoutPanel1.Size = new Size(384, 256);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnTomei);
            flowLayoutPanel1.Controls.Add(btnNaoTomei);
            flowLayoutPanel1.Controls.Add(btnLembrarDepois);
            flowLayoutPanel1.Location = new Point(4, 212);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 41);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // NotificacaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 284);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(412, 284);
            MinimumSize = new Size(412, 284);
            Name = "NotificacaoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificacaoForm";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTomei;
        private System.Windows.Forms.Button btnNaoTomei;
        private System.Windows.Forms.Button btnLembrarDepois;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}