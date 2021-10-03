using System;
using System.Collections.Generic;
using System.Text;

namespace ATIVIDADE_AVALIATIVA
{
    public class Funcionario
    {
        private string Nome { get; set; }
        private int CargaHorario { get; set; }
        private double ValorHora { get; set; }

        double Salario;

        public Funcionario( string nome, int cargahorario, double valorhora)
        {
            Nome = nome;
            CargaHorario = cargahorario;
            ValorHora = valorhora;
        }
        public Funcionario()
        {
        
        }
        public  double CalculaSalario(int cargaHorario, double valorHora)
        {
            Salario = cargaHorario * valorHora;
            return Salario;
        }
        public  void ImprimirDados( string nome, string salario)
        {
            salario = Convert.ToString(Salario);
            Console.WriteLine("Nome" + nome + " Salario:" + salario);
        }
        public class FuncionarioTerc : Funcionario
        {
            public string EmpresaOrigem { get; set; }
            public double TaxaServico { get; set; }

            public FuncionarioTerc()
            {

            }

            public FuncionarioTerc(string nome,int cargahorario, double valorhora, string empresaorigem, double taxaservico )
            {
                this.Nome = nome;
                this.CargaHorario = cargahorario;
                this.ValorHora = valorhora;
                this.EmpresaOrigem = empresaorigem;
                this.TaxaServico = taxaservico;

            }




            public double CalculaSalario(int cargaHorario, double valorHora)
            {
                Salario = cargaHorario * valorHora *0.10;
                return Salario;
            }
            public void ImprimirDados(string nome, string salario, string empresaorigem)
            {
                Console.WriteLine("Nome" + nome + " Salario:" + salario + "Empresa Origem:" + empresaorigem);
            }
        }
    }

   
}
