using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_interrupcao.Model
{
    public class Resumo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int interrupcoes { get; set; }
        public string setor { get; set; }
        public Resumo() { }

        public override bool Equals(object obj)
        {
            return obj is Resumo relatorio &&
                   nome == relatorio.nome &&
                   interrupcoes == relatorio.interrupcoes;
        }

        public override int GetHashCode()
        {
            int hashCode = 1831348966;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + interrupcoes.GetHashCode();
            return hashCode;
        }
    }
}
