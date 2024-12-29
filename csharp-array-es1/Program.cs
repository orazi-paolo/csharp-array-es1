// dichiaro la variabile numeroMaggiore e la inizializzo a 0
int numeroMaggiore = 0;
// leggo gli argomenti passati in input
foreach (string arg in args)
{
    // se l'argomento è maggiore del numeroMaggiore
    if (numeroMaggiore < (int.Parse(arg)))
    {
        // assegno il valore dell'argomento a numeroMaggiore
        numeroMaggiore = int.Parse(arg);
    }
}
// stampo il numero maggiore
Console.WriteLine($"Il numero più grande è: {numeroMaggiore}");