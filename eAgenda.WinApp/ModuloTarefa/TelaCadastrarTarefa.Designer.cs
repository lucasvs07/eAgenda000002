namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaCadastrarTarefa
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
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.textBoxTituloTarefa = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridades = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Location = new System.Drawing.Point(14, 12);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(50, 20);
            this.labelTituloTarefa.TabIndex = 0;
            this.labelTituloTarefa.Text = "Título:";
            // 
            // textBoxTituloTarefa
            // 
            this.textBoxTituloTarefa.Location = new System.Drawing.Point(14, 36);
            this.textBoxTituloTarefa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTituloTarefa.Name = "textBoxTituloTarefa";
            this.textBoxTituloTarefa.Size = new System.Drawing.Size(281, 27);
            this.textBoxTituloTarefa.TabIndex = 1;
            // 
            // comboBoxPrioridades
            // 
            this.comboBoxPrioridades.FormattingEnabled = true;
            this.comboBoxPrioridades.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.comboBoxPrioridades.Location = new System.Drawing.Point(14, 104);
            this.comboBoxPrioridades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPrioridades.Name = "comboBoxPrioridades";
            this.comboBoxPrioridades.Size = new System.Drawing.Size(138, 28);
            this.comboBoxPrioridades.TabIndex = 2;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Location = new System.Drawing.Point(14, 80);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(81, 20);
            this.labelPrioridade.TabIndex = 3;
            this.labelPrioridade.Text = "Prioridade:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(168, 248);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(137, 60);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(12, 248);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(137, 60);
            this.buttonInserir.TabIndex = 19;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Item";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 27);
            this.textBox1.TabIndex = 22;
            // 
            // TelaCadastrarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(317, 350);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.comboBoxPrioridades);
            this.Controls.Add(this.textBoxTituloTarefa);
            this.Controls.Add(this.labelTituloTarefa);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarTarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.TextBox textBoxTituloTarefa;
        private System.Windows.Forms.ComboBox comboBoxPrioridades;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}