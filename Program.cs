// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


void StampaArray(int[] array)
{
    Console.WriteLine(String.Join(",", array));
}
int Quadrato(int numero)
{
    return numero * numero;
}
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] finalArray = new int[array.Length];
    for(int index = 0; index < array.Length; index++)
    {
        finalArray[index] = array[index] * array[index];
    }
    return finalArray;
}
int SommaElementiArray(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        sum += array[index];
    }
    return sum;
}

//int[] sampleArray = { 2, 6, 7, 5, 3, 9 };
//StampaArray(sampleArray);
//for(int index = 0; index < sampleArray.Length; index++)
//{
//    int arrayNumber = sampleArray[index];
//    Quadrato(arrayNumber);
//}
//StampaArray(sampleArray);
//Console.WriteLine(SommaElementiArray(sampleArray));
//int[] elevatedNumbersArray = ElevaArrayAlQuadrato(sampleArray);
//StampaArray(elevatedNumbersArray);


//Bonus con array creato dall'utente
Console.Write("Quanti numeri vuoi che contenga il tuo array?: ");
int arrayLength = Int32.Parse(Console.ReadLine());
int[] userArray = new int[arrayLength];

for(int index = 0; index < arrayLength; index++)
{
    Console.Write("Digita un numero: ");
    int userNumber = Int32.Parse(Console.ReadLine());
    userArray[index] = userNumber;
}

StampaArray(userArray);
for (int index = 0; index < userArray.Length; index++)
{
    int arrayNumber = userArray[index];
    Quadrato(arrayNumber);
}
StampaArray(userArray);
Console.WriteLine(SommaElementiArray(userArray));
int[] elevatedNumbersArray = ElevaArrayAlQuadrato(userArray);
StampaArray(elevatedNumbersArray);

