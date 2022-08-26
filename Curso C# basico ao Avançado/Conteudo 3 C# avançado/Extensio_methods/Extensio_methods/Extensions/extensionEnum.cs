using System;
using System.Collections.Generic;
using System.Text;

namespace Extensio_methods.Extensions
{
    public static class extensionEnum
    {

        public static string ObtemNomeEnum(this testeEnum valor)
        {
            switch (valor)
            {
                case testeEnum.teste:
                    return "teste1";
                case testeEnum.teste3:
                    return "Teste2";
                default:
                    return "nenhum";
            }
        }


    }
}
