using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Interface;
using minimal_api.Infraestrutura.Db;

namespace minimal_api.Dominio.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly DbContexto _contexto;

        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public Administrador? Login(LoginDto loginDto)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDto.Email && a.Senha == loginDto.Senha).FirstOrDefault();

            return adm;
        }
    }
}
