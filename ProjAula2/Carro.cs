﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula2
{
    class Carro
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }

        #endregion Propriedades

        #region Métodos

        public string Imprimir()
        {
            return "Id: " + this.Id + "\nNome: " + this.Nome + 
                "\nCor: " + this.Cor;
        }

        #endregion Métodos
    }
}
