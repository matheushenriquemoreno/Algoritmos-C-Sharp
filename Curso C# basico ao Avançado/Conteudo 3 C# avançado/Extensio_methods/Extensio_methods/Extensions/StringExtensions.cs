
namespace System
{
    static class StringExtensions
    {

        public static string Cut(this string objeto, int valor)
        {
            if(objeto.Length <= valor)
            {
                return objeto;
            }
            else
            {
                return objeto.Substring(0, valor) + "...";
            }
        }
    }
}
