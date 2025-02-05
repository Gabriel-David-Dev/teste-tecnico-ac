using teste_tecnico.Controllers;

namespace teste_tecnico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmostraController controller = new AmostraController();
            controller.Executar();
        }
    }
}
