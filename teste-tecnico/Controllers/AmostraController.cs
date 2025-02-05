using System;
using teste_tecnico.Models;
using teste_tecnico.Views;

namespace teste_tecnico.Controllers
{
    internal class AmostraController
    {
        private readonly ConsoleView _view;

        public AmostraController()
        {
            _view = new ConsoleView();
        }

        public void Executar()
        {
            string entrada = _view.SolicitarEntrada();

            try
            {
                AmostraModel amostra = new AmostraModel(entrada);
                amostra.CalcularEficiencia();
                _view.MostrarResultado(amostra);
            }
            catch (Exception)
            {
                _view.MostrarErro();
            }
        }
    }
}
