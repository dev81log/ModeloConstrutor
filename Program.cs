using ModeloConstrutor.ContentContext;
using ModeloConstrutor.Enum;

namespace ModeloConstrutor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            var estudante = new Estudante(new DateTime(2022, 3, 1), "João", "joao@gmail.com", EFormacaoCursos.CursoElectronica);

            Console.WriteLine(estudante);
        }
    }
}

