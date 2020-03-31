using System;
using System.Collections.Generic;
using System.Text;

namespace Cap06_Struct
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto(String nome, double valor)
        {
            Nome = nome;
            Valor = valor;

        }


    }
}
