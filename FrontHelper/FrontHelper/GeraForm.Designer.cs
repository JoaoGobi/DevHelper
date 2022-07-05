
namespace FrontHelper
{
    partial class GeraForm
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
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPrimeiraLetra = new System.Windows.Forms.CheckBox();
            this.tbNomeForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(34, 37);
            this.tbEntrada.Multiline = true;
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEntrada.Size = new System.Drawing.Size(284, 401);
            this.tbEntrada.TabIndex = 0;
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(471, 37);
            this.tbSaida.Multiline = true;
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSaida.Size = new System.Drawing.Size(284, 401);
            this.tbSaida.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPrimeiraLetra
            // 
            this.cbPrimeiraLetra.AutoSize = true;
            this.cbPrimeiraLetra.Checked = true;
            this.cbPrimeiraLetra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrimeiraLetra.Location = new System.Drawing.Point(34, 12);
            this.cbPrimeiraLetra.Name = "cbPrimeiraLetra";
            this.cbPrimeiraLetra.Size = new System.Drawing.Size(153, 19);
            this.cbPrimeiraLetra.TabIndex = 3;
            this.cbPrimeiraLetra.Text = "PrimeiraLetraLowerCase";
            this.cbPrimeiraLetra.UseVisualStyleBackColor = true;
            this.cbPrimeiraLetra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbNomeForm
            // 
            this.tbNomeForm.Location = new System.Drawing.Point(346, 58);
            this.tbNomeForm.Name = "tbNomeForm";
            this.tbNomeForm.Size = new System.Drawing.Size(100, 23);
            this.tbNomeForm.TabIndex = 4;
            this.tbNomeForm.TextChanged += new System.EventHandler(this.tbNomeForm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Model";
            // 
            // tbNomeModel
            // 
            this.tbNomeModel.Location = new System.Drawing.Point(346, 114);
            this.tbNomeModel.Name = "tbNomeModel";
            this.tbNomeModel.Size = new System.Drawing.Size(100, 23);
            this.tbNomeModel.TabIndex = 6;
            // 
            // GeraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomeForm);
            this.Controls.Add(this.cbPrimeiraLetra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSaida);
            this.Controls.Add(this.tbEntrada);
            this.Name = "GeraForm";
            this.Text = "GeraForm";
            this.Load += new System.EventHandler(this.GeraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbPrimeiraLetra;
        private System.Windows.Forms.TextBox tbNomeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeModel;
    }
}