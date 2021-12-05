using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_capitulo_09.Entities
{
    class OrderItem
    {
        public int Quantidade { get; set; }
        public double Price { get; private set; }
        public Product Produto { get; set; }
        public OrderItem()
        {

        }

        public OrderItem(double preco, int quantiti,Product p )
        {
            Quantidade = quantiti;
            Price = preco;
            Produto = p;
        }

        public double SubTotal()
        {
            return Price * Quantidade;
        }




    }
}
