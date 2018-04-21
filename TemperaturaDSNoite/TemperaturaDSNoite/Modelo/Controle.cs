using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaDSNoite.Modelo
{
    public class Controle : absPropriedades, intMetodos
    {
        public Controle(String tipo, String temp)
            : base(tipo, temp)
        {
            Executar();
        }

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.temp);
            if (validacao.mensagem.Equals(""))
            {
                Conversao conversao = new Conversao(this.tipo, validacao.temperatura);
                this.resposta = conversao.resposta;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
