using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCshka
{
    internal class Controller
    {
        private View view;
        private Model model;


        public Controller(View view, Model model)
        {
            this.view = view;
            this.model = model;
        }
        
        public void Equation(double firstValue, double secondValue, double thirdValue)
        {            
            if (firstValue == 0)
            {
                Console.WriteLine("Первый коэффициент не может быть =0");
            }
           model.result = -1*secondValue + Math.Sqrt(Math.Pow(secondValue, 2) - (4 * firstValue * thirdValue)) / 2 * firstValue;
        }
    }
}
