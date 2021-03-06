﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagensValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string msg)
        {
            mensagensValidacao.Add(string.Concat("Crítica: ", msg));
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagensValidacao.Any(); }
        }
    }
}
