﻿using System;
using System.Collections.Generic;

namespace Senai.InLock.DataBaseFirst.Solution.Domains
{
    public partial class Estudios
    {
        public Estudios()
        {
            Jogos = new HashSet<Jogos>();
        }

        public int EstudioId { get; set; }
        
        public string NomeEstudio { get; set; }

        public ICollection<Jogos> Jogos { get; set; }
    }
}
