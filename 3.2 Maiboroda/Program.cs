// 3 вар, сложный уровень
Console.Write("Введите n:");
double n = double.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    var quadro = i * i;
    var k = Math.Floor(Math.Log(i) / Math.Log(10)) + 1;
    var d = 1;
    for (var j = 1; j <= k; j++) d *= 10;
    if (quadro % d == i) {
        Console.WriteLine(i.ToString(), "2=", quadro, ", digits: ", Math.Floor(Math.Log(quadro) / Math.Log(10)) + 1);

    }
}
