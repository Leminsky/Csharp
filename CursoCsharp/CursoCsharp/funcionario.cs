using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCsharp
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }


        
        public Funcionario(int id, string name, double salary)
        { Id= id; 
          Name = name;
          Salary = salary; 
        }

        public Funcionario()
        {
        }

        public void Increase(double n)
        {
            Salary += Salary * (n / 100);
            
        }
        public override string ToString()
         {
            return "ID:" + Id+"\nNome:"+ Name+"\nSalario:R$ "+ Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}

