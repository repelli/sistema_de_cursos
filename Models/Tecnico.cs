using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA_DE_CURSOS_MVC.Models
{
    public class Tecnico : Curso
    {
        public Tecnico() { }//construtor vazio - método de sobrecarga


        public Tecnico(string nomeConstrutor, int horasConstrutor) : base(nomeConstrutor, horasConstrutor) // busca parametros de curso
        {

        }
        // metodo de sobreescrita
        public override double CalcularPreco()
        {
            return Horas * 20;
        }

    }
}