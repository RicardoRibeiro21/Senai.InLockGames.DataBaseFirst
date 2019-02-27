using Senai.InLock.DataBaseFirst.Solution.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.DataBaseFirst.Solution.Interfaces
{
    interface IJogoRepository
    {
        void Cadastrar(Jogos jogo);

        List<Jogos> ListaJogos();

        void Atualizar(Jogos jogo);

        void Deletar(Jogos jogo);

        Jogos BuscaPorId(int id);
    }
}
