double[] mas = new double[4]; double av = 0;
Console.WriteLine("Введите 4 цифры:");
try
{
    mas[0] = Convert.ToDouble(Console.ReadLine()); mas[1] = Convert.ToDouble(Console.ReadLine());
    mas[2] = Convert.ToDouble(Console.ReadLine()); mas[3] = Convert.ToDouble(Console.ReadLine());
    av = (mas[0] + mas[1] + mas[2] + mas[3]) / mas.Length; Console.Write($"Среднее значение = {av}");
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}