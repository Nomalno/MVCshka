using MVCshka;
using System.Reflection;

Console.WriteLine("Введите коэффициэнты квадратного уравнение");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
Model model = new Model(a, b, c);
View view = new View(model);
Controller controller = new Controller(view, model);
controller.Equation(a,b,c);
view.DisplayResult();
Console.ReadKey();