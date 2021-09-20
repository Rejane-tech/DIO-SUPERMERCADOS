using System;

namespace DIO.Supermercados

{

    public class Compra : EntidadeBase
    {
        public Compra(Secao secao, string produto, string composicao, int mes, bool excluido)
        {
            this.Secao = secao;
            this.Produto = produto;
            this.Composicao = composicao;
            this.Mes = mes;
            this.Excluido = excluido;

        }

        private Secao Secao { get; set; }

        private string Produto { get; set; }

        private string Composicao { get; set; }

        private int Mes { get; set; }

        private bool Excluido { get; set; }

        public Compra(int id, Secao secao, string produto, string composicao, int mes)
        {
            this.Id = id;
            this.Secao = secao;
            this.Produto = produto;
            this.Composicao = composicao;
            this.Mes = mes;
            this.Excluido = false;

        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Secao: " + this.Secao + Environment.NewLine;
            retorno += "Produto: " + this.Produto + Environment.NewLine;
            retorno += "Composicao: " + this.Composicao + Environment.NewLine;
            retorno += "Mes de fabricacao produto: " + this.Mes + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaProduto()
        {
            return this.Produto;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}