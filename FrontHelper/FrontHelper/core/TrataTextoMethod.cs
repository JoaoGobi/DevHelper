using System;
using System.Collections.Generic;
using System.Text;

namespace FrontHelper.core
{
    public class TrataTextoMethod
    {
        public List<string> Texto { get; set; }

        public TrataTextoParameter Parameter { get; set; }

        public TrataTextoMethod(List<string> _texto, TrataTextoParameter _parameter)
        {
            this.Texto = _texto;
            this.Parameter = _parameter;
            this.TrataTexto(this);
        }

        public List<string> TrataTexto (TrataTextoMethod context)
        {
            if (Parameter.RemovePonto) this.RemovePonto(context);
            if (Parameter.RemoveTraco) this.RemoveTraco(context);
       
            //this.RemoveBarra(context);
            this.RemoveLinha(context);
            //this.RemoveAspas(context);
            this.RemoveEspaco(context);

            return context.Texto;
        }

        public void RemovePonto(TrataTextoMethod context)
        {
            List<string> aux = new List<string>();

            foreach(var i in context.Texto)
            {
                aux.Add(i.Replace(".", ""));
            }

            context.Texto = aux;
        } 

        public void RemoveBarra(TrataTextoMethod context)
        {
            List<string> aux = new List<string>();

            foreach(var i in context.Texto)
            {
                aux.Add(i.Replace("/", ""));
            }

            context.Texto = aux;
        } 
        
        public void RemoveTraco(TrataTextoMethod context)
        {
            List<string> aux = new List<string>();

            foreach(var i in context.Texto)
            {
                aux.Add(i.Replace("-", ""));
            }

            context.Texto = aux;
        }   
        
        public void RemoveLinha(TrataTextoMethod context)
        {
            List<string> aux = new List<string>();

            foreach(var i in context.Texto)
            {
                aux.Add(i.Replace("\r", ""));
            }

            context.Texto = aux;
        } 
        
        public void RemoveAspas(TrataTextoMethod context)
        {
            List<string> aux = new List<string>();

            foreach(var i in context.Texto)
            {
                aux.Add(i.Replace("\"", ""));
            }

            context.Texto = aux;
        } 
        
        public void RemoveEspaco(TrataTextoMethod context)
        {
            List<string> aux = new List<string>();

            foreach(var i in context.Texto)
            {
                aux.Add(i.Trim());
            }

            context.Texto = aux;
        }
    }

    public class TrataTextoParameter
    {
        public bool RemovePonto { get; set; }
        public bool RemoveTraco { get; set; }

        public TrataTextoParameter (bool _removePonto, bool _removeTraco){
            RemovePonto = _removePonto;
            RemoveTraco = _removeTraco;
        }
    }

}
