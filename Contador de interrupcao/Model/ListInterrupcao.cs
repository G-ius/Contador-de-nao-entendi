using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_interrupcao.Model
{
    public class ListInterrupcao
    { 
       public int id { get; set; }

       public string nome { get; set; }

       public DateTime? horario { get; set; }

        public ListInterrupcao(int id, string nome, DateTime? horario)
        {
            this.id = id;
            this.nome = nome;
            this.horario = horario;
        }

        public override bool Equals(object obj)
        {
            return obj is ListInterrupcao interrupcao &&
                   id == interrupcao.id &&
                   nome == interrupcao.nome &&
                   horario == interrupcao.horario;
        }

    }
}
