using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaDSNoite.Modelo
{
    public abstract class absPropriedades
    {
        public String mensagem;
        public String resposta;
        public String temp;
        public Double temperatura;
        public String tipo;

        public absPropriedades(String tipo, Double temperatura)
        {
            this.tipo = tipo;
            this.temperatura = temperatura;
        }
        public absPropriedades(String tipo, String temp)
        {
            this.tipo = tipo;
            this.temp = temp;
        }
        public absPropriedades(String temp)
        {
            this.temp = temp;
        }
    }
}
