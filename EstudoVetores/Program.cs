
using System.Globalization;

namespace EstudoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average heigth: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


/*
 Array ou vetores, é o nome dado a arranjos unidimensionais.

Arranjo é uma estrutura de dados

- Homogênea (dados do mesmo tipo, double, int, string etc).
- Ordenada (elementos acessados por meio de posições)
- Alocada de uma vez só, em um bloco contíguo de memória.

Vantagens

- Acesso imediato aos elementos pela sua posição (0, 1, 2, 3, etc)

Desvantagens

- Tamanho fixo
- Dificuldade para se realizar inserções e deleções.
 
-----------------------------------------------------

Para o uso de array em string a função básica é :

string [] nomes = Console.ReadLine().Split(' ');

------------------------------------------------------

Para o uso de array em int a função básica é :

string [] numeros = Console.ReadLine().Split(' ');
int n1 = int.Parse(numeros[0]);
int n2 = int.Parse(numeros[1]);

------------------------------------------------------

Para o uso de array em double a função básica é :

string [] dados = Console.ReadLine().Split(' ');
double precoPeca = double.Parse(dados[0], CultureInfo.InvariantCulture);
double codigoPeca = double.Parse(dados[1], cultureInfo.InvariantCulture);

*/