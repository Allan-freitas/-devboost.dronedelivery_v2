using System;
using System.Collections.Generic;

namespace devboost.Domain.Model
{
    public class Cliente
    {
        public Cliente(string nome, string email, double latitude, double longitude, string endereco)
        {
            Id = Guid.NewGuid();
            Latitude = latitude;
            Longitude = longitude;
            Endereco = endereco;
            Nome = nome;
            Email = email;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public double Latitude { get;  set; }

        public double Longitude { get;  set; }

        public string Endereco { get;  set; }        

        public User User { get; set; }

        public List<Pedido> Pedidos { get; set; }
        public bool IsValid()
        {
            return
                !string.IsNullOrEmpty(Nome) &&
                !string.IsNullOrEmpty(Email);           
        }

    }
}
