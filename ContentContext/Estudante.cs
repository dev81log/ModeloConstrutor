using ModeloConstrutor.Enum;

namespace ModeloConstrutor.ContentContext
{
    public class Estudante
    {
        Pagamento pagamento = new Pagamento();

        public Estudante(DateTime inscricao, string nome, string email, EFormacaoCursos formacao)
        {
            IdEstudante = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Formacao = formacao;
            Mensalidade = inscricao;
        }

        private Guid IdEstudante { get; set; }
        private bool MensalidadePaga => pagamento.IsPago(Mensalidade);
        private DateTime Mensalidade { get; set; }
        private decimal ValorMensalidade => pagamento.FormacaoValor((int)Formacao);
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Resposta => RespostaPagamento();
        private EFormacaoCursos Formacao { get; set; }

        private string RespostaPagamento()
        {
            if (MensalidadePaga)
            {
                return "Status pago!";
            }
            else
            {
                return "Status pendente!";
            }
        }

        public override string ToString()
        {
            return $"Id: {IdEstudante}\nMensalidade Paga? {Resposta}\nInscrição: {Mensalidade}\nNome: {Nome}\nEmail: {Email}\nCurso: {Formacao}\nValor Mensalidade: {ValorMensalidade}";
        }
    }

}