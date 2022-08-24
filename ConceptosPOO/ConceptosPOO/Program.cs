
using ConceptosPOO;

Console.WriteLine("POO CONCEPTS");

try
{
    Console.WriteLine(new Date(2022, 8, 24));
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2015, 6, 12));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}



