using System;

namespace devboost.Domain.Commands.Request
{
    public class CadastrarUserRequest
    {
        public Guid Id { get; private set; }

        public string UserName { get; private set; }

        public string Paswword { get; private set; }

        public string Role { get; private set; }
    }
}
