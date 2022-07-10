namespace ModeloConstrutor.ContentContext
{
    public class Pagamento
    {
        public Pagamento(int idPagamento, int idCurso, decimal valor)
        {
            IdPagamento = idPagamento;
            IdCurso = idCurso;
            Valor = valor;

        }

        public int IdPagamento { get; set; }
        public DateTime DataPagamento => new DateTime(2022, 2, 2);
        public int IdCurso { get; set; }
        public decimal Valor { get; set; }

        // Método que retorna se o pagamento foi realizado ou não que é passado pelo estudante
        public bool IsPago(DateTime mensalidade)
        {
            return DataPagamento.Date == mensalidade.Date;
        }


    }
}