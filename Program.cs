using System;
using ProjetoElevador.CONTROLLER;

namespace Projeto_Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controllerElevador = new ControllerElevador();

            controllerElevador.Inicializando();
        }
    }
}
