
namespace FrontHelper
{
    partial class GeraTexto
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
            this.tbEntradaFixo = new System.Windows.Forms.TextBox();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.tbEntradaVariavel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbRemovePonto = new System.Windows.Forms.CheckBox();
            this.cbRemoveTraco = new System.Windows.Forms.CheckBox();
            this.btnLerArquivos = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEntradaFixo
            // 
            this.tbEntradaFixo.Location = new System.Drawing.Point(23, 84);
            this.tbEntradaFixo.Multiline = true;
            this.tbEntradaFixo.Name = "tbEntradaFixo";
            this.tbEntradaFixo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEntradaFixo.Size = new System.Drawing.Size(637, 190);
            this.tbEntradaFixo.TabIndex = 1;
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(780, 84);
            this.tbSaida.Multiline = true;
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSaida.Size = new System.Drawing.Size(284, 401);
            this.tbSaida.TabIndex = 2;
            // 
            // tbEntradaVariavel
            // 
            this.tbEntradaVariavel.Location = new System.Drawing.Point(23, 295);
            this.tbEntradaVariavel.Multiline = true;
            this.tbEntradaVariavel.Name = "tbEntradaVariavel";
            this.tbEntradaVariavel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEntradaVariavel.Size = new System.Drawing.Size(751, 190);
            this.tbEntradaVariavel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbRemovePonto
            // 
            this.cbRemovePonto.AutoSize = true;
            this.cbRemovePonto.Checked = true;
            this.cbRemovePonto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemovePonto.Location = new System.Drawing.Point(23, 30);
            this.cbRemovePonto.Name = "cbRemovePonto";
            this.cbRemovePonto.Size = new System.Drawing.Size(109, 19);
            this.cbRemovePonto.TabIndex = 6;
            this.cbRemovePonto.Text = "Remove Pontos";
            this.cbRemovePonto.UseVisualStyleBackColor = true;
            // 
            // cbRemoveTraco
            // 
            this.cbRemoveTraco.AutoSize = true;
            this.cbRemoveTraco.Checked = true;
            this.cbRemoveTraco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveTraco.Location = new System.Drawing.Point(138, 30);
            this.cbRemoveTraco.Name = "cbRemoveTraco";
            this.cbRemoveTraco.Size = new System.Drawing.Size(105, 19);
            this.cbRemoveTraco.TabIndex = 7;
            this.cbRemoveTraco.Text = "Remove Traços";
            this.cbRemoveTraco.UseVisualStyleBackColor = true;
            // 
            // btnLerArquivos
            // 
            this.btnLerArquivos.Location = new System.Drawing.Point(666, 182);
            this.btnLerArquivos.Name = "btnLerArquivos";
            this.btnLerArquivos.Size = new System.Drawing.Size(108, 23);
            this.btnLerArquivos.TabIndex = 8;
            this.btnLerArquivos.Text = "Ler Arquivos";
            this.btnLerArquivos.UseVisualStyleBackColor = true;
            this.btnLerArquivos.Click += new System.EventHandler(this.btnLerArquivos_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(249, 28);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(283, 23);
            this.tbPath.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Path";
            // 
            // GeraTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnLerArquivos);
            this.Controls.Add(this.cbRemoveTraco);
            this.Controls.Add(this.cbRemovePonto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEntradaVariavel);
            this.Controls.Add(this.tbSaida);
            this.Controls.Add(this.tbEntradaFixo);
            this.Name = "GeraTexto";
            this.Text = "GeraTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEntradaFixo;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.TextBox tbEntradaVariavel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbRemovePonto;
        private System.Windows.Forms.CheckBox cbRemoveTraco;
        private System.Windows.Forms.Button btnLerArquivos;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
    }
}