using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrielAPI.Model
{
    [Table("usuarios")]
    public class Usuario
    {

        [Key]
        public int id { get; private set; }
        public string email { get; private set; }
        public string senha { get; private set; }
        public string nome { get; private set; }
        public DateTime data_criacao { get; private set; }


        // Construtor
        public Usuario(string email, string senha, string nome, DateTime data_criacao)
        {
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.senha = senha ?? throw new ArgumentNullException(nameof(senha));
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.data_criacao = data_criacao;
        }

        public Usuario() { }
    }
}
