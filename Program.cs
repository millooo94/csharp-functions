//Array di prova
var numbers = new[] { 2, 6, 7, 5, 3, 9 };
//printArray(numbers);
//Console.WriteLine(ElevaArrayAlQuadrato(numbers));
//Console.WriteLine(sommaElementiArray(numbers));
//Console.WriteLine(sommaElementiArrayAlQuadrato(numbers));


//1)
void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

//2)
var number = 5;

Quadrato(number);

int Quadrato(int numero)
{
    return numero * numero;
}




//3)
ElevaArrayAlQuadrato(numbers);

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for(var i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }

    return copiaArray;
}


//4)
sommaElementiArray(numbers);

int sommaElementiArray(int[] array)
{
    var sum = 0;
    
    for(var i = 0; i < array.Length; ++i)
    {
        sum += array[i];
    }

    return sum;
}

//5)
int sommaElementiArrayAlQuadrato(int[] array)
{
    var sum = 0;

    for (var i = 0; i < array.Length; ++i)
    {
        sum += array[i] * array[i];
    }

    return sum;
}


//BONUS

//Console.WriteLine("Hei, dammi una lunghezza per l'array...");

//var arrLength = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[arrLength];

//for (int i = 0; i < arrLength; i++)
//{
//    Console.WriteLine("Dammi un numero...");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//programma(arr);
//void programma(int[] array)
//{
//    Console.WriteLine("Array Originale:");
//    printArray(array);
//    Console.WriteLine("Array elevato al quadrato:");
//    Console.WriteLine(arrayToString(ElevaArrayAlQuadrato(array)));
//    Console.WriteLine("Somma elementi array originale:");
//    Console.WriteLine(sommaElementiArray(array));
//    Console.WriteLine("Somma elementi array elevati al quadrato:");
//    Console.WriteLine(sommaElementiArrayAlQuadrato(array));
//}


//SUPERBONUS
 int TrovaNumeroMinimo(int[] array, int i = 0, int min = int.MaxValue)
{
    if (i == array.Length)
    {
        return min;
    }

    if (min > array[i])
    {
        min = array[i];
    }

    return TrovaNumeroMinimo(array, i + 1, min);
}

int[] numeri = { 98, 5, 2, 9, 87, 7 };
int minimo = TrovaNumeroMinimo(numeri);
Console.WriteLine($"Il numero minimo nell'array è: {minimo}");










