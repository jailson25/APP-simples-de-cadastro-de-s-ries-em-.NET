using System;
using System.Collections.Generic;
using CadastroSeries.interfaces;

namespace CadastroSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Atualizar(int id, Serie Objeto)
        {
            listaSerie[id] = Objeto;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Serie Objeto)
        {
            listaSerie.Add(Objeto);
        }
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public Serie RetornarPorId(int id)
        {
            return listaSerie[id];
        }
    }
}