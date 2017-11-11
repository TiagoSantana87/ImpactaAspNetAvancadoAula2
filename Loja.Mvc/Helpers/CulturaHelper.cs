using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Loja.Mvc.Helpers
{
    public class CulturaHelper
    {
        public const string LinguagemPadrao = "pt-BR";

        private List<string> LinguagemSuportadas { get; } = new List<string> { LinguagemPadrao, "es", "en-US" };

        private void PbterRegiao()
        {
            var linguagem = LinguagemPadrao;
            var linguagemSelecioda = HttpContext.Current.Request.Cookies[Cookie.LinguagemSelecionada];

            if (linguagemSelecioda != null && LinguagemSuportadas.Contains(linguagemSelecioda.Value));
            {

            }
        }
    }
}