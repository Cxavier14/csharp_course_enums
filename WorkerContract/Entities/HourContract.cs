using System;


namespace WorkerContract
{
    class HourContract
    {
        //classe responsavel pelo contrato do trabalhador
        //inicio das propriedades
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        //fim das propriedades

        //inicio dos construtores
        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        //fim dos construtores

        //funcao que calcula o total do contrato de trabalho(exceto salario base)
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
