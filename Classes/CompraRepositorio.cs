using System;
using System.Collections.Generic;
using DIO.Supermercados.Interfaces;

namespace DIO.Supermercados
{

    public class CompraRepositorio : IRepositorio<Compra>
    {
        private List<Compra> listaCompra = new List<Compra>();
        public void Atualiza(int id, Compra objeto)
        {
            listaCompra[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaCompra[id].Excluir();
        }

        public void Insere(Compra objeto)
        {
            listaCompra.Add(objeto);
        }

        public List<Compra> Lista()
        {
            return listaCompra;
        }

        public int ProximoId()
        {
            return listaCompra.Count;
        }

        public Compra RetornaPorId(int id)
        {
            return listaCompra[id];

        }

    }
}