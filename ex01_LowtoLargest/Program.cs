/* 1. The application receives five numbers and returns them ordered from lowest to largest.
The numbers before being displayed must be stored in an array;*/

Console.WriteLine("Digite 5 numeros e eu lhe devolverei em um array em ordem crescente: (obs, aperte (Enter) apos cada numero digitado)");

int[] array = new int[5];
int i = 0;
int j = 0;

while (i < 5)
{
    array[i] = int.Parse(Console.ReadLine());
    i++;
}

Array.Sort(array);

Console.WriteLine("Otimo, aqui esta o seu array em ordem crescente:");
while (j < 5)
{
    Console.WriteLine(array[j]);
    j++;
}