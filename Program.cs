



//void PlotSin(double x0, double x1, double dx)
//{
//	for (double x = x0; x < x1; x +=dx) 
//	{
//		double y = Math.Sin(x);
//        Console.WriteLine($"x: {x}, {y:N2}");
//    }

//}

//void PlotSinEnhanced(MathsFunction f, double x0, double x1, double dx)
//{
//    for (double x = x0; x < x1; x += dx)
//    {
//        double y =f(x);
//        Console.WriteLine($"x: {x}, {y:N2}");
//    }
//}

//double Double( double x)
//{
//    return x * 2;
//}

//double Triple(double x)
//{
//    return x * 3;
//}

//// PlotSin(0.0, Math.PI / 2, 0.01);

//// PlotSinEnhanced(Math.Cos, 0.0, Math.PI / 2, 0.01);

////PlotSinEnhanced(Double, 0.0, Math.PI / 2, 0.01);

////var randomGenerator = new Random();

////for (int i = 0; i < 100; i++)
////{
////    MathsFunction f = Triple;
////    if (randomGenerator.NextDouble() > 0.5)
////    {
////        f += Double;
////    } else
////    {
////        f = Triple;
////    }
////    double result = f(2);
////    Console.WriteLine($"result: {result}");

////}

////void PlotSuperEnhanced(Func<double, double> f, double x0, double x1, double dx)
////{
////    for (double x = x0; x < x1; x += dx)
////    {
////        double y = f(x);
////        Console.WriteLine($"x: {x}, {y:N2}");
////    }
////}


//using DemoCorsoCSharp;

////var lista = new List<int>();
////for (int i = 0; i < 1000; i++)
////{
////    lista.Add(i);
////}

////var somma = lista.SommaElementiPari();
////var sommaSpeciale = lista.SommaElementiPariConParametro(12);


//var listaPersone = new List<Person>();




//var x = listaPersone.DoSomething(s => s.ToLower(), s => s.ToUpper(), "A");


//var skip = 10;
//var take = 5;

//var persone = listaPersone
//    .Where(p  => { return p.Name != null ? p.Name.ToUpper().StartsWith("S") : false; })
//    .OrderBy(p => p.Name)
//    .Skip(skip)
//    .Take(take)
//    .Select(p => new PersonDTO
//{
// Id = p.Id, FullName = $"{p.Name} {p.Surname}",
//  FullAddress = $"{p.Address.StreetName} {p.Address.PostalCode}"
//});

//persone.ToList().ForEach(Console.WriteLine);




////var numeriPari = lista.FindAll( delegate(int n) { return n % 2 == 0; });
//var numeriPari = lista.FindAll(n => n % 2 == 0);


//numeriPari.ForEach(Console.WriteLine);




//// PlotSuperEnhanced(Double, 0, 10, 0.1);
////Action<int> g;

//delegate double MathsFunction(double x);
//delegate int D1(double a, string b);
//// Func<double, string, int>,

using DemoCorsoCSharp;

var account = new BankAccount();
account.WithDrawn += (s, e) => Console.WriteLine($"Messaggio: {e.Message}");

account.Deposit(500);
account.Withdraw(1000);

Console.WriteLine($"Balance: {account.Balance}");





