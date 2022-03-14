using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Encapsulamento.Entities
{
    class Cliente
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Endereco { get; private set; }


        public Cliente(int id, string name, string endereco)
        {
            if (id < 0)
                throw new InvalidationExeption("Erro! id invalido");

            if (string.IsNullOrEmpty(Name))
                throw new InvalidationExeption("Erro! Name vazio.");

            if (string.IsNullOrEmpty(Endereco))
                throw new InvalidationExeption("Erro! Endereço vazio.");

            this.Id = id;
            this.Name = name;
            this.Endereco = endereco;
        }

    }
}
