using System;
using System.Collections.Generic;
using projFinal.Interfaces;

namespace projFinal
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
           listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
           listaSerie[id].Excluir();
        }

        public void Isere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public List<Serie> Lista()
        {
           return listaSerie;
        }

        public int ProximoId()
        {
           return listaSerie.Count;
        }

        public Serie RetornaId(int id)
        {
            return listaSerie[id];
        }
    }
}