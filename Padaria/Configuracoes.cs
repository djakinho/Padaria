using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Configuracoes
    {
        public static string Secret { get; } = "myUltraSecretKeyForPadariaApi"; // Tem que ter pelo menos 16 caracteres
    }
}
