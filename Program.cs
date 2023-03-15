



void PlotSin(double x0, double x1, double dx)
{
	for (double x = x0; x < x1; x +=dx) 
	{
		double y = Math.Sin(x);
        Console.WriteLine($"x: {x}, {y:N2}");
    }

}

void PlotSinEnhanced(MathsFunction f, double x0, double x1, double dx)
{
    for (double x = x0; x < x1; x += dx)
    {
        double y =f(x);
        Console.WriteLine($"x: {x}, {y:N2}");
    }
}

double Double( double x)
{
    return x * 2;
}

double Triple(double x)
{
    return x * 3;
}

// PlotSin(0.0, Math.PI / 2, 0.01);

// PlotSinEnhanced(Math.Cos, 0.0, Math.PI / 2, 0.01);

//PlotSinEnhanced(Double, 0.0, Math.PI / 2, 0.01);

var randomGenerator = new Random();

for (int i = 0; i < 100; i++)
{
    MathsFunction f = Triple;
    if (randomGenerator.NextDouble() > 0.5)
    {
        f += Double;
    } else
    {
        f = Triple;
    }
    double result = f(2);
    Console.WriteLine($"result: {result}");

}

void PlotSuperEnhanced(Func<double, double> f, double x0, double x1, double dx)
{
    for (double x = x0; x < x1; x += dx)
    {
        double y = f(x);
        Console.WriteLine($"x: {x}, {y:N2}");
    }
}


var lista = new List<int>();
for (int i = 0; i < 1000; i++)
{
    lista.Add(i);
}


//var numeriPari = lista.FindAll( delegate(int n) { return n % 2 == 0; });
var numeriPari = lista.FindAll(n => n % 2 == 0);


numeriPari.ForEach(Console.WriteLine);




// PlotSuperEnhanced(Double, 0, 10, 0.1);
//Action<int> g;

delegate double MathsFunction(double x);
delegate int D1(double a, string b);
// Func<double, string, int>,








