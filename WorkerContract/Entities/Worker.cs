using System;
using System.Collections.Generic;
using WorkerContract.Entities.Enums;

namespace WorkerContract.Entities
{
    class Worker
    {
        //classe responsavel por gerenciar os dados do trabalhador
        //inicio das propriedades
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        //referencia a classe HourContract gerando uma lista de contratos associados ao trabalhador em questao
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        //fim das propriedades

        //inicio dos construtores
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        //fim dos construtores

        public void AddContract(HourContract contract)
        {
            //metodo responsavel por adicionar um contrato a lista de contratos
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            //metodo responsavel por remover um contrato a lista de contratos
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            //funcao responsavel por calcular o ganho do trabalhador dado um mes e ano(somado com salario base)
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
