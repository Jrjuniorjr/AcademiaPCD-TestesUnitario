using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.model
{
    public class Conta
    {
        public int Id { get; private set; }
        public string Matricula { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int id, string matricula)
        {
            this.Id = id;
            this.Matricula = matricula;
            this.Saldo = 0;
        }

        public void Debitar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo = Saldo - valor;
                Console.WriteLine("Operação de debitar feita com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Creditar(double valor)
        {
            this.Saldo = Saldo + valor;

        }
    }
}
