using FrontHelper.core;
using FrontHelper.model.GeraTexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FrontHelper
{
    public partial class GeraTexto : Form
    {
        public GeraTexto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbEntradaFixo.Text != "" && tbEntradaFixo.Text != "")
            {
                var context = new GeraTextoEntradaModel(tbEntradaFixo.Text, tbEntradaVariavel.Text.Split("\n"), tbPath.Text);
                var response = this.RetornaTextoEditado(context);

                foreach (var i in response.TextoEditado)
                {
                    if(i != "")
                    {
                        tbSaida.Text += i + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite os valores para continuar!");
            }

        }

        public GeraTextoSaidaModel RetornaTextoEditado(GeraTextoEntradaModel context)
        {
            var texto = new GeraTextoSaidaModel(context.Fixo, new TrataTextoMethod(context.Variavel, new TrataTextoParameter(cbRemovePonto.Checked, cbRemoveTraco.Checked)).Texto, context.Path);

            return texto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbSaida.Text = "";
        }

        private void btnLerArquivos_Click(object sender, EventArgs e)
        {

        }
    }
}
