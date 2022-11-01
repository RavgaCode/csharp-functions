// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


//void StampaArray(int[] array)
//{
//    Console.WriteLine(String.Join(",", array));
//}
//int Quadrato(int numero)
//{
//    return numero * numero;
//}
//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    int[] finalArray = new int[array.Length];
//    for (int index = 0; index < array.Length; index++)
//    {
//        finalArray[index] = Quadrato(array[index]);
//    }
//    return finalArray;
//}
//int SommaElementiArray(int[] array)
//{
//    int sum = 0;
//    for (int index = 0; index < array.Length; index++)
//    {
//        sum += array[index];
//    }
//    return sum;
//}

//int[] sampleArray = { 2, 6, 7, 5, 3, 9 };
//StampaArray(sampleArray);
//int[] elevatedNumbersArray = ElevaArrayAlQuadrato(sampleArray);
//StampaArray(sampleArray);
//Console.WriteLine(SommaElementiArray(sampleArray));
//StampaArray(elevatedNumbersArray);


//Bonus con array creato dall'utente
//Console.Write("Quanti numeri vuoi che contenga il tuo array?: ");
//int arrayLength = Int32.Parse(Console.ReadLine());
//int[] userArray = new int[arrayLength];

//for(int index = 0; index < arrayLength; index++)
//{
//    Console.Write("Digita un numero: ");
//    int userNumber = Int32.Parse(Console.ReadLine());
//    userArray[index] = userNumber;
//}

//StampaArray(userArray);
//for (int index = 0; index < userArray.Length; index++)
//{
//    int arrayNumber = userArray[index];
//    Quadrato(arrayNumber);
//}
//StampaArray(userArray);
//Console.WriteLine(SommaElementiArray(userArray));
//int[] elevatedNumbersArray = ElevaArrayAlQuadrato(userArray);
//StampaArray(elevatedNumbersArray);


//Snack Bonus 2

//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
//1 - Fattoriale di un numero
//2 - La sequenza di fibonacci di un numero


//Funzione 1
//int getFactorialNumber(int number)
//{
//    int[] array = new int[number];
//    for (int index = 0; index < number; index++)
//    {
//        array[index] = index + 1;
//    }
//    int factorialNumber = 1;

//    for (int index = 0; index < array.Length; index++)
//    {
//        factorialNumber *= array[index];
//    }
//    return factorialNumber;
//}
//Console.Write("Digita un numero di cui vuoi sapere il fattoriale: ");
//int userNumber = Int32.Parse(Console.ReadLine());
//Console.WriteLine(getFactorialNumber(userNumber));


//Funzione 2


//int getFibonacciNumberFromPosition (int position)
//{
//    if(position == 1 || position == 2)
//    {
//        return 1;
//    }
//    int[] sequence = new int[position];
//    sequence[0] = 1;
//    sequence[1] = 1;
//    for (int index = 2; index < sequence.Length; index++)
//    {
//        int firstNumber = sequence[index - 1];
//        int secondNumber = sequence[index - 2];
//        sequence[index] = firstNumber + secondNumber;
//    }
//    int finalNumber = sequence.Last();
//    return finalNumber;
//}
//Console.Write("Digita la posizione della sequenza di Fibonacci di cui vuoi sapere il numero: ");
//int userPositionNumber = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Il numero della sequenza di Fibonacci nella posizione scelta è: " + getFibonacciNumberFromPosition(userPositionNumber));


//Snack bonus 3

//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita nell’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//Mi raccomando ci sono diversi modi di integrarlo, scegliete una strategia semplice in base a quello che abbiamo spiegato:
//l’utente inserisce una stringa da criptare / decriptare
//l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita

//Console.Write("Scrivi la frase da cifrare/decifrare: ");
//string userString = Console.ReadLine();
//char[] userStringArray = userString.ToCharArray();
//Console.Write("Digita il numero della tua chiave numerica: ");
//int key = Int32.Parse(Console.ReadLine());
//char[] finalArray = new char[userStringArray.Length];
//for(int i = 0; i < userStringArray.Length; i++)
//{
//    char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
//    char charToSearch = userStringArray[i];
//    int indexOfCharIntoAlphabet = Array.IndexOf(alphabet, charToSearch);
//    if(indexOfCharIntoAlphabet + key > 26)
//    {
//        int newKey = (indexOfCharIntoAlphabet + key) - 26;
//        finalArray[i] = alphabet[newKey];
//    }
//    else if(indexOfCharIntoAlphabet + key == 26)
//    {
//        finalArray[i] = alphabet[0];
//    }
//    else
//    {
//        finalArray[i] = alphabet[indexOfCharIntoAlphabet + key];
//    }
//}

//Console.WriteLine(String.Concat(finalArray));