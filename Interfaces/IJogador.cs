using System.Collections.Generic;
using E_PlayersMVC.Models;

namespace E_PlayersMVC.Interfaces
{
    public interface IJogador
    {
         void Criar(Jogador j);
         List<Jogador> LerTodas();
         void Alterar(Jogador j);
         void Deletar(int id);
    }
}