# MVCshka
![image](https://user-images.githubusercontent.com/51385107/230904057-805315b7-a382-4e02-a85d-ade54f58bb46.png)

Этот код решает квадратное уравнение с помощью шаблона проектирования Model-View-Controller (MVC).
Пользователь вводит три коэффициента в консоль, а программа использует их для создания объекта Model, который содержит данные об уравнении и результате его решения.
View предназначен для отображения результата решения уравнения в консоли. Controller реализует логику решения уравнения, используя Model и обновляя его результат.
Когда пользователь вводит значения коэффициентов, Controller вызывает метод Equation для вычисления корней уравнения и сохранения результата в Model.
View затем отображает результат в консоли. Таким образом, приложение разделяет логику, данные и отображение между Model, View и Controller.
