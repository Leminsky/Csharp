using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/*namespace CursoCsharp
{ class Program
    { static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 10;

            Console.WriteLine(p);
            p= new Point();
            Console.WriteLine(p);
           
       
        }

    }
    





}*///Struct
/*namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor ou o valor padrão do tipo da variável  
            Console.WriteLine(y.GetValueOrDefault()); 
            
            Console.WriteLine(x.HasValue); // Como se fosse um  Booleano para se tem valor ou não retorna tru or false
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value); //  Imprimi o valor da variável
            Console.WriteLine(y.Value);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is Null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is Null");
            }
            double a = x ?? 5;// ?? = Imprimi o valor da variável se for nulo imprimi oq está a direita
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}*/// Nullable
/*namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite o Valor de N");
              int n =int.Parse(Console.ReadLine());
              double f=0;
              double[] v= new double[n];
              for( int i=0 ; i<n; i++)
              {
                  Console.WriteLine("Digite um valor");
                  v[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                  Console.WriteLine("O valor digitado é " + v[i]);
                  f= f+ v[i];               


              }

              double m = f / n;
              Console.WriteLine("A media e:" + m.ToString("F2"),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade produtos");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i]= new Product { Nome=name ,Price=price};
                sum += vect[i].Price;
            }

            double media= sum/n;
            Console.WriteLine("Essa é a média dos produtos cadastrados: " + media.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}*/// Vetores
/*namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        { int n, s = 0, b;
            string name, email;

            Console.WriteLine("Digite o número de quartos disponíveis");
            n = int.Parse(Console.ReadLine().ToString());


            Aluguel[] vect = new Aluguel[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Deseja Alugar um quarto?\n1-Sim\n2-Não");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    Console.Write("Digite o nome do estudante\n");
                    name = Console.ReadLine().ToString();
                    Console.Write("Digite o email do estudante\n");
                    email = Console.ReadLine().ToString();
                    vect[i] = new Aluguel(n, name, email);

                }
                else
                {
                    vect[i] = null;
                }
                if (vect[i] != null)
                {
                    s++;
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lista atualizada\n" + vect[i].Name + "\n" + vect[i].Email);

            }
                
                
        }
    }

}*/ // Vetor com classe ( erro no programa principal, classe e leitura funcionando)


