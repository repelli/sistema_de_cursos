using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA_DE_CURSOS_MVC.Models
{
    public class Superior : Curso
    {


        public Superior() { }

        public Superior(string nomeConstrutor, int horasConstrutor) : base(nomeConstrutor, horasConstrutor)
        {

        }

        public override double CalcularPreco()
        {
            return Horas * 40;
        }
        
    }
}