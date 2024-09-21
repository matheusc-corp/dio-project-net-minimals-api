using System.ComponentModel.DataAnnotations;

namespace minimal_api.Dominio.DTOs
{
    public record VeiculoDto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
    }
}
