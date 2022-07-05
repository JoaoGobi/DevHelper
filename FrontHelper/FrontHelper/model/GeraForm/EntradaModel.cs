using System;
using System.Collections.Generic;
using System.Text;

namespace FrontHelper.model.GeraForm
{
    public class EntradaModel
    {
        public string Tipo { get; set; }
        public string Campo { get; set; }
        public string FormInit { get; set; }
        public string FormRead { get; set; }
        public string FormModel { get; set; }
        public string ModelUse { get; set; }
    }

    public class EntradaModelList
    {
        public List<EntradaModel> entradaModel { get; set; }
        public List<string> formInit { get; set; }
        public List<string> formRead { get; set; }
        public List<string> formModel { get; set; }
        public List<string> modalUse { get; set; }
    }
}
