using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerContract.Entities
{
    class Department
    {
        //classe responsavel pelo departamento do trabalhador
        //inicio propriedades
        public string Name { get; set; }
        //fim propriedades

        //inicio dos contrutores
        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
        //fim dos construtores
    }
}
