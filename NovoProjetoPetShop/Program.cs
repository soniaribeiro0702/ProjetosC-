﻿using NovoProjetoPetShop.Repositorios;
using NovoProjetoPetShop.Servicos;

namespace NovoProjetoPetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.BaseDeDados();
            menu.OpcaoMenu();

        }
    }
}