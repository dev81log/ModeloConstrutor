using ModeloConstrutor.Enum;

namespace ModeloConstrutor.ContentContext
{
    public class Estudante
    {

        public Estudante(DateTime mensalidade, bool mensalidadePaga, string nome, string email, EFormacaoCursos formacao)
        {
            IdEstudante = Guid.NewGuid();
            MensalidadePaga = IsPa
            Nome = nome;
            Email = email;
            Formacao = formacao;
        }


        public Guid IdEstudante { get; set; }
        public bool MensalidadePaga { get; set; } = false;
        public DateTime Mensalidade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public EFormacaoCursos Formacao { get; set; }
    }

}