using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FrontHelper.model.GeraTexto
{
    public class GeraTextoEntradaModel
    {
        public string Fixo { get; set; }
        public List<string> Variavel { get; set; }
        public string Path { get; set; }

        public GeraTextoEntradaModel(string fixo, string[] variavel, string path)
        {
            this.Fixo = fixo;
            this.Variavel = new List<string>(variavel);
            this.Path = path;
        }
    }

    public class GeraTextoSaidaModel
    {
        public List<string> TextoEditado { get; set; }
        public GeraTextoSaidaModel(string _fixo, List<string> _variavel, string _path)
        {
            this.TextoEditado = new List<string>();

            foreach(var i in _variavel)
            {
                if(i.Trim() != "" &&  i != null)
                {
                    string texto = _fixo;

                    var split = i.Split("@");

                    for(var x = 0; x < split.Length; x++)
                    {
                        if (split[x] != null)
                            texto = texto.Replace("#" + x.ToString(), split[x].Trim());
                    }

                    //if (split[1] != null)
                    //    texto = texto.Replace("#1", split[1]);


                    if (_path != null && _path != "")
                    {
                        String path = _path + $@"{i}.html";

                        using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                        {
                            texto = texto.Replace("link", reader.ReadToEnd());
                        }
                    }

                    TextoEditado.Add(texto);
                }
            }
        }
    }
}
