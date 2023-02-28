// Написать цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.
// 3, 5 -> 243 (3 в степени 5)

int Promt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;

}

int Power( int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }

    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Поаказатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Promt("Введите основание: ");
int exponent = Promt("Введите показатель: ");
if(ValidateExponent(exponent))
{
    System.Console.WriteLine ($"Число {powerBase} в строке {exponent} равно {Power(powerBase, exponent)}");
}
