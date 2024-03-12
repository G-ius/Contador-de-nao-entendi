using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_interrupcao.Model
{
    public class Interruptor
    {
        public Interruptor()
        {
        }

        public int id { get;set; }
        public string nome { get; set; }
        public string setor { get; set; }



        public override bool Equals(object obj)
        {
            return obj is Interruptor interruptor &&
                   nome == interruptor.nome &&
                   setor == interruptor.setor;
        }

        public Interruptor(string nome, string setor)
        {
            this.nome = nome;
            this.setor = setor;
        }

        public override int GetHashCode()
        {
            int hashCode = 1861100978;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(setor);
            return hashCode;
        }
    }
}
