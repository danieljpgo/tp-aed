﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class Placa
    {
        private string nome;
        private int tipo;

        public Placa()
        { }

        public Placa(string nome, int tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public string Nome
        { get { return nome; } }

        public int Tipo
        { get { return tipo; } }

    }
}
