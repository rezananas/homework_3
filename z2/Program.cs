/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber (string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine (message);

        if (int.TryParse (Console.ReadLine (), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine ("Вы ввели не число.");
        }
    }

    return result;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
}

int x1 = GetNumber("Введите x-координату 1-ой точки: ");
int y1 = GetNumber("Введите y-координату 1-ой точки: ");
int z1 = GetNumber("Введите z-координату 1-ой точки: ");
int x2 = GetNumber("Введите x-координату 2-ой точки: ");
int y2 = GetNumber("Введите y-координату 2-ой точки: ");
int z2 = GetNumber("Введите z-координату 2-ой точки: ");

double distance = GetDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние от точки A({x1},{y1},{z1}) до точки B({x2},{y2},{z2}) составляет {distance}");