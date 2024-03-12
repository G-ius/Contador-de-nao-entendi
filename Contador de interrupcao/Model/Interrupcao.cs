using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_interrupcao.Model
{
    public class Interrupcao
    {
        public int id { get;set; }
        public int idInterruptor { get; set; }
        public DateTime Horario { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Interrupcao interrupcao &&
                   id == interrupcao.id &&
                   idInterruptor == interrupcao.idInterruptor &&
                   Horario == interrupcao.Horario;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Interrupcao(int idInterruptor, DateTime horario)
        {
            this.idInterruptor = idInterruptor;
            Horario = horario;
        }
    }
}
