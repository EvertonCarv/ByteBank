using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario // abstract palavra reservada modificador C# portanto não deve ser diretamente instanciada
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // 3 - Gerente de conta corrente
        // 4 - Coordenador
        // N - ...
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
                
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;  
            Salario = salario;  
            Console.WriteLine("Criando Funcionario");
            TotalDeFuncionarios++;
        }               
        public abstract void AumentarSalario();
        /*{
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }*/
        // Virtual palavra reservada usada para implementação que pode ser sobrescrita, precisamos apontar em Diretor que GetBonificacao() não é mais um método usando (override) após o public
        public abstract double GetBonificacao();
        /*{
            return Salario * 0.10;
        }*/
    }
}



