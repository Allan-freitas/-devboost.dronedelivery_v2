namespace devboost.Domain.Handles.Commands.Request
{
    public class ClienteRequest
    {
        public string Nome { get; set; }

        public string Email { get; set; }      
        
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Endereco { get; set; }
    }
}
