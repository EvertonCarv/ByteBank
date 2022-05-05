using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel  // Quando colocar : você herda tudo que tem na classe nesse caso Funcionario
    {
          
        public Diretor(string cpf) : base(5000, cpf) // que vai chamar a base passando cpf
        {
          Console.WriteLine("Criando Diretor");
        }    
                       
        public override void AumentarSalario()
        {
           Salario *= 1.15;
        }
        public override double GetBonificacao() // Usamos overrider para apontar em Diretor que GetBonificacao() não é mais um método usando (override) após o public
        {
            
            return Salario * 0.5;
        }        
    }
}
