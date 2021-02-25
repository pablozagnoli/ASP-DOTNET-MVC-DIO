﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descrição { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
