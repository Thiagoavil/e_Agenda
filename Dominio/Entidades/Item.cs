﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Item 
    {
        public string Titulo { get; set; }
        public bool itemConcluido { get; set; }

        public override string ToString()
        {
            return Titulo;

        }

        public void Concluir()
        {
            itemConcluido = true;
        }

        internal void MarcarPendente()
        {
            itemConcluido = false;
        }

    }
}