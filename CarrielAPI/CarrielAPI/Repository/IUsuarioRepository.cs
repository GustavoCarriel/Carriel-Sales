using CarrielAPI.Model;

namespace CarrielAPI.Repository
{
    public interface IUsuarioRepository
    {

        void AddUser(Usuario usuario);

        Usuario GetUserByEmail(string email, string senha);

        Usuario GetExistUser(string email);

    }
}
