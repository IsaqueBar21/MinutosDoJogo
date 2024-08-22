using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1047_TempoJogo
{
    class Program
    {
        static void Main(string[] args)
        {


            String[] vet = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(vet[0]);
            int minutoInicio = int.Parse(vet[1]);
            int horaFinal = int.Parse(vet[2]);
            int minutoFinal = int.Parse(vet[3]);

            int duracaoInicio = (horaInicio * 60) + minutoInicio;
            int duracaoFinal = (horaFinal * 60) + minutoFinal;

            int duracao;

            if ( duracaoInicio < duracaoFinal )
            {
                duracao = duracaoFinal - duracaoInicio;
            } 
            else
            {
                duracao = (24 * 60 - duracaoInicio) + duracaoFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTOS(S)");

            
        }
    }
}
