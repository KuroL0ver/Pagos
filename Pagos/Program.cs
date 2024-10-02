namespace Pagos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codigo = DateTime.Now.ToString("yyMMddHHmmss");
            Console.WriteLine(codigo);

            Console.WriteLine("Introduce tu código de verificación");
            string codigoEscrito = Console.ReadLine();

      if (codigoEscrito == codigo)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("codigo incorrecto");
            }
        }
    }
}
