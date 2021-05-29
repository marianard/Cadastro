﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
     public class Cliente
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public bool PossuiInvestimento { get; set; }
        public char Sexo { get; set; }
    }
}
