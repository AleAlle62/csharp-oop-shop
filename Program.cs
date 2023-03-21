var p = new Product("Ogetto")
{
    Price = 100,
    Iva = 0.22,
    Description = "bo non lo so blabla",
};

Console.WriteLine(p);
Console.WriteLine($"price after iva: {p.GetPriceAfterIva()}; extended name: {p.GetExtendedName()}.");