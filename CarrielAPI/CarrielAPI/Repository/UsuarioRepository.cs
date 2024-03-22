using CarrielAPI.Infraestrutura;
using CarrielAPI.Model;

namespace CarrielAPI.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly ConnectionContext _context = new ConnectionContext();
        public void AddUser(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario GetExistUser(string email)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.email == email);

            return usuario;
        }

        public Usuario GetUserByEmail(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.email == email && u.senha == senha);
        }
    }
}
