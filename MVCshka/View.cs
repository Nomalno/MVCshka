using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCshka
{
    internal class View
    {
        private Model model_;

        private Controller controller;

        public View(Model model)
        {
            model_ = model;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"Результат:{model_.result} ");
        }
    }
}

