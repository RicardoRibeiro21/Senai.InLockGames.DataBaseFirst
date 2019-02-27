using Microsoft.EntityFrameworkCore;
using Senai.InLock.DataBaseFirst.Solution.Domains;
using Senai.InLock.DataBaseFirst.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.DataBaseFirst.Solution.Repository
{
    public class JogoRepository : IJogoRepository
    {
        public void Atualizar(Jogos jogo)
        {
            using (InLockContext ctx = new InLockContext())
            {
                

                ctx.Jogos.Update(jogo);
                ctx.SaveChanges();
            }
        }

        public Jogos BuscaPorId(int id)
        {
            using (InLockContext ctx = new InLockContext())
            {
                return ctx.Jogos.Find(id);
            }
        }

        public void Cadastrar(Jogos jogo)
        {
            using(InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Add(jogo);
                ctx.SaveChanges();
            }
        }

        public void Deletar(Jogos jogo)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Remove(jogo);
                ctx.SaveChanges();
            }
        }

        public List<Jogos> ListaJogos()
        {
            using (InLockContext ctx = new InLockContext()) 
            {
                return ctx.Jogos.ToList();

            }
        }
    }
}
