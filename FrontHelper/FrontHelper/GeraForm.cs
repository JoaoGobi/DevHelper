using FrontHelper.model.GeraForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontHelper
{
    public partial class GeraForm : Form
    {
        public GeraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSaida.Text = "";
            var entrada = tbEntrada.Text;
            if (entrada != "" && entrada != null)
            {
                var entradaModelList = RetornaEntradaModel(entrada.Split("\n"));

                //LISTA FormModel
                tbSaida.Text += "export interface " + tbNomeModel.Text+ " {\r\n";
                foreach (var item in entradaModelList.formModel)
                {
                    tbSaida.Text += item + Environment.NewLine;
                }
                tbSaida.Text += "}\r\n\r\n";        
                
                //LISTA ModalUser
                tbSaida.Text += "const modal: " + tbNomeModel.Text+ " = {\r\n";
                foreach (var item in entradaModelList.modalUse)
                {
                    tbSaida.Text += item + Environment.NewLine;
                }
                tbSaida.Text += "};\r\n\r\n";       
                
                //LISTA FormInit
                tbSaida.Text += "this."+ tbNomeForm.Text + " = this._" + tbNomeForm.Text + ".group({\r\n";
                foreach (var item in entradaModelList.formInit)
                {
                    tbSaida.Text += item + Environment.NewLine;
                }
                tbSaida.Text += "});\r\n\r\n"; 
                
                //LISTA FormInit
                tbSaida.Text += "this.service.BuscarPeloId(this.id).then((dados) => {\r\n";
                foreach (var item in entradaModelList.formRead)
                {
                    tbSaida.Text += item + Environment.NewLine;
                }
                tbSaida.Text += "});\r\n\r\n";
            }
            else
            {
                MessageBox.Show("Digite um valor de entrada!");
            }
        }

        public EntradaModelList RetornaEntradaModel(string[] array)
        {
            var entradaRetorno = new EntradaModelList();
            entradaRetorno.entradaModel = new List<EntradaModel>();
            entradaRetorno.formInit = new List<string>();
            entradaRetorno.formRead = new List<string>();
            entradaRetorno.formModel = new List<string>();
            entradaRetorno.modalUse = new List<string>();



            for (var i = 0; i < array.Length; i++)
            {
                var entrada = new EntradaModel();

                var value = array[i];

                //REMOVE OS PUBLIC
                if (value.Contains("public"))
                {
                    value = value.Replace("public", "");
                }

                //REMOVE OS ""
                if (value.Contains('"'))
                {
                    value = value.Replace("\"", "");
                }        
                
                //REMOVE OS :
                if (value.Contains(':'))
                {
                    value = value.Replace(":", "");
                } 
                
                //REMOVE OS ;
                if (value.Contains(';'))
                {
                    value = value.Replace(";", "");
                }   

                //REMOVE OS ,
                if (value.Contains(','))
                {
                    value = value.Replace(",", "");
                }

                //REMOVE OS { get; set; }
                if (value.Contains("{ get; set; }"))
                {
                    value = value.Replace("{ get; set; }", "");
                }

                if (value.Contains("long") || value.Contains("number") || value.Contains("0"))
                {
                    entrada.Tipo = "number";


                    //REMOVE O TIPO
                    value = value.Replace("long", "").Trim();
                    value = value.Replace("number", "").Trim();
                    value = value.Replace("0", "").Trim();

                    //VERIFICA SE É OBRIGATÓRIO
                    var obrigatorio = VerificaObrigatorio(value);
                    value = value.Replace("?", "").Trim();

                    value = VerificaPrimeiraLetra(value);

                    if (obrigatorio)
                    {
                        entrada.Campo = value;
                        entrada.FormInit = value + ": " + "[0, [Validators.required]],";
                        entrada.FormRead = "this.form.controls['"+ value + "'].setValue(dados.model.value." + value + ");";
                        entrada.FormModel = value + ": number;";
                        entrada.ModelUse = value + ": this." + tbNomeForm.Text + "." + value + ".value,";
                    }
                    else
                    {
                        entrada.Campo = value;
                        entrada.FormInit = value + ": " + "[0],";
                        entrada.FormRead = "this.form.controls['" + value + "'].setValue(dados.model.value." + value + ");";
                        entrada.FormModel = value + "?: number;";
                        entrada.ModelUse = value + ": this." + tbNomeForm.Text + "." + value + ".value,";
                    }

                    entradaRetorno.entradaModel.Add(entrada);
                    entradaRetorno.formInit.Add(entrada.FormInit);
                    entradaRetorno.formRead.Add(entrada.FormRead);
                    entradaRetorno.formModel.Add(entrada.FormModel);
                    entradaRetorno.modalUse.Add(entrada.ModelUse);
                }
                else if (value.Contains("string"))
                {
                    entrada.Tipo = "string";

                    //REMOVE O TIPO
                    value = value.Replace("string", "").Trim();

                    //VERIFICA SE É OBRIGATÓRIO
                    var obrigatorio = VerificaObrigatorio(value);
                    value = value.Replace("?", "").Trim();

                    value = VerificaPrimeiraLetra(value);

                    if (obrigatorio)
                    {
                        entrada.Campo = value;
                        entrada.FormInit = value + ": " + "['', [Validators.required]],";
                        entrada.FormRead = "this.form.controls['" + value + "'].setValue(dados.model.value." + value + ");";
                        entrada.FormModel = value + ": string;";
                        entrada.FormModel = value + ": string;";
                        entrada.ModelUse = value + ": this." + tbNomeForm.Text + "." + value + ".value,";
                    }
                    else
                    {
                        entrada.Campo = value;
                        entrada.FormInit = value + ": " + "[''],";
                        entrada.FormRead = "this.form.controls['" + value + "'].setValue(dados.model.value." + value + ");";
                        entrada.FormModel = value + "?: string;";
                        entrada.ModelUse = value + ": this." + tbNomeForm.Text + "." + value + ".value,";
                    }

                    entradaRetorno.entradaModel.Add(entrada);
                    entradaRetorno.formInit.Add(entrada.FormInit);
                    entradaRetorno.formRead.Add(entrada.FormRead);
                    entradaRetorno.formModel.Add(entrada.FormModel);
                    entradaRetorno.modalUse.Add(entrada.ModelUse);
                }
                else if (value.Contains("bool") || value.Contains("true"))
                {
                    entrada.Tipo = "boolean";


                    //REMOVE O TIPO
                    value = value.Replace("boolean", "").Trim();
                    value = value.Replace("bool", "").Trim();
                    value = value.Replace("true", "").Trim();

                    //VERIFICA SE É OBRIGATÓRIO
                    var obrigatorio = VerificaObrigatorio(value);
                    value = value.Replace("?", "").Trim();

                    value = VerificaPrimeiraLetra(value);

                    if (obrigatorio)
                    {
                        entrada.Campo = value;
                        entrada.FormInit = value + ": " + "[false, [Validators.required]],";
                        entrada.FormRead = "this.form.controls['" + value + "'].setValue(dados.model.value." + value + ");";
                        entrada.FormModel = value + ": boolean;";
                        entrada.ModelUse = value + ": this." + tbNomeForm.Text + "." + value + ".value,";
                    }
                    else
                    {
                        entrada.Campo = value;
                        entrada.FormInit = value + ": " + "[false],";
                        entrada.FormRead = "this.form.controls['" + value + "'].setValue(dados.model.value." + value + ");";
                        entrada.FormModel = value + "?: boolean;";
                        entrada.ModelUse = value + ": this." + tbNomeForm.Text + "." + value + ".value,";
                    }

                    entradaRetorno.entradaModel.Add(entrada);
                    entradaRetorno.formInit.Add(entrada.FormInit);
                    entradaRetorno.formRead.Add(entrada.FormRead);
                    entradaRetorno.formModel.Add(entrada.FormModel);
                    entradaRetorno.modalUse.Add(entrada.ModelUse);
                }
            }
            return entradaRetorno;
        }

        public bool VerificaObrigatorio(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (!value.Contains("?")){
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public string VerificaPrimeiraLetra(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (cbPrimeiraLetra.Checked)
                {
                    value = (value[0].ToString().ToLower() + value.Substring(1, value.Length-1)) ;
                    return value;
                }
                else
                {
                    return value;
                }
            }
            else
            {
                return value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GeraForm_Load(object sender, EventArgs e)
        {
            tbNomeForm.Text = "form";
            tbNomeModel.Text = "nomeModel";
        }

        private void tbNomeForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
