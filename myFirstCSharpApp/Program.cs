// See https://aka.ms/new-console-template for more information



using System.Data;

int a, b, c, x, y;
string str;
Console.Write("Введите сторону A: ");
str = Console.ReadLine();
a = Convert.ToInt32(str);
Console.Write("Введите сторону B: ");
str = Console.ReadLine();
b = Convert.ToInt32(str);
Console.Write("Введите сторону C: ");
str = Console.ReadLine();
c = Convert.ToInt32(str);

x = b / c;
y = a / c;

if (x == 0 || y == 0) {
    str = "Нет квадратов";
} else {
    str = string.Format("В прямоугольник вмещается {0} квадратов, не занятая площадь {1}", x * y, (a * b - c * c * x * y));
}

Console.WriteLine(str);