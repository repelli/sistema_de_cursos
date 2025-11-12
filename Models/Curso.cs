

using System.ComponentModel.DataAnnotations;

namespace SISTEMA_DE_CURSOS_MVC.Models
{
    public abstract class Curso
    {
        [Key] //chave para o banco de dados
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Horas { get; set; }


        public Curso() { } //construtor vazio obrigatório


        public Curso(string nomeConstrutor, int horasConstrutor)
        {
            Nome = nomeConstrutor;
            Horas = horasConstrutor;

        }

        public abstract double CalcularPreco(); //metodo

    }
}