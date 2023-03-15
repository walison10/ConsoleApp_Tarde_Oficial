using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Heranca
{
    public class Veiculo
    {
        public string cor;
        public int quantidadeRoda;
        public int quantidadeAcento;
        public bool TemMotor;
        public string ExibirDados()
        {
            if (TemMotor)
            {
               return cor + " Tem motor" + quantidadeAcento + " " + quantidadeRoda;
            }
            else
            {
               return cor + " " + quantidadeAcento + " " + quantidadeRoda;
            }
           
        }
    }
}
