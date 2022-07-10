using ModeloConstrutor.Enum;

namespace ModeloConstrutor.ContentContext
{
    public class Estudante
    {

        public Estudante(DateTime mensalidade, string nome, string email, EFormacaoCursos formacao)
        {
            IdEstudante = Guid.NewGuid();
            Mensalidade = mensalidade;
            Nome = nome;
            Email = email;
            Formacao = formacao;
        }

        public Guid IdEstudante { get; set; }
        public DateTime Mensalidade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public EFormacaoCursos Formacao { get; set; }
    }

}