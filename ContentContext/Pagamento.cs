using ModeloConstrutor.Enum;

namespace ModeloConstrutor.ContentContext
{
    public class Pagamento
    {
        public Pagamento() { }
        public Pagamento(int IdFormacaoCurso)
        {
            IdCurso = IdFormacaoCurso;
            Valor = FormacaoValor(IdFormacaoCurso);
        }

        private int IdPagamento { get; set; }
        private DateTime DataPagamento => new DateTime(2022, 3, 1);
        private int IdCurso { get; set; }
        private decimal Valor { get; set; }

        public bool IsPago(DateTime mensalidade)
        {
            if (mensalidade.Month == DataPagamento.Month)
                return true;
            else
                return false;
        }

        public decimal FormacaoValor(int idCursoSelecionado)
        {
            switch (idCursoSelecionado)
            {
                case 1:
                    IdCurso = ((int)EFormacaoCursos.CursoMecatronica);
                    return Valor = 100;
                case 2:
                    IdCurso = ((int)EFormacaoCursos.CursoElectronica);
                    return Valor = 150;
                case 3:
                    IdCurso = ((int)EFormacaoCursos.CursoInformatica);
                    return Valor = 200;
                case 4:
                    IdCurso = ((int)EFormacaoCursos.CursoSocial);
                    return Valor = 250;
                default: break;
            }
            return 0;
        }
    }
}