using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context=new EF01Curso2023Entities())
            {
                context.Database.Log = Console.WriteLine;
                var listaCursos = context.Cursos.ToList();
                foreach (var curso in listaCursos)
                {
                    Console.WriteLine($"{curso.NombreCurso} {curso.Descripcion} {curso.Vacantes}");
                }
            }

            Console.ReadLine();
        }
    }
}
