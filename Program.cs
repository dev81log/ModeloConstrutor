using ModeloConstrutor.ContentContext;
using ModeloConstrutor.Enum;

namespace ModeloConstrutor
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.Clear();
            var estudante = new Estudante(new DateTime(2022, 1, 1), "João", "joao@gmail.com", EFormacaoCursos.CursoMecatronica);
            Console.WriteLine($"Id: {estudante.IdEstudante}");
            Console.WriteLine($"Inscrição: {estudante.Mensalidade}");
            Console.WriteLine($"Nome: {estudante.Nome}");
            Console.WriteLine($"Email: {estudante.Email}");
            Console.WriteLine($"Curso: {estudante.Formacao}");

        }
    }
}

