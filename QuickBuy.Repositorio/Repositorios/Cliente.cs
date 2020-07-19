using QuickBuy.Dominio;
using QuickBuy.Dominio.Entidades;
using System.Net.Http.Headers;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepostitorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            var produto = new Produto();

            usuarioRepostitorio.Adicionar(new Usuario() { Id = 1, Nome = "Allan", SobreNome = "Reis", Senha = "123", Email = "allan1985@gmail.com" });

        }
    }
}
