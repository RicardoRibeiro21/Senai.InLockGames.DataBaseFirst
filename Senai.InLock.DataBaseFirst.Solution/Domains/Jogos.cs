using System;
using System.Collections.Generic;

namespace Senai.InLock.DataBaseFirst.Solution.Domains
{
    public partial class Jogos
    {
        public int JogoId { get; set; }
        public string NomeJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Valor { get; set; }
        //Campo pode ser nulo
        public int? EstudioId { get; set; }

        public Estudios Estudio { get; set; }
    }
}
