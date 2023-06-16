Console.Title = "Function";

static void bodyTempC()
{
    Console.WriteLine("Body Temperature...");
    Console.WriteLine("Centigrade:\t37C");
}
static double bodyTempF()
{
    double temperature = 98.6;
    return temperature;
}

static int bodyTempK()
{
    int temperature = 310;
    return temperature;
}

bodyTempC();
Console.WriteLine("Fahrenheit:\t" + bodyTempF() + "F");
Console.WriteLine("Kelvin:\t"+ bodyTempK() + "K");
Console.ReadKey();


