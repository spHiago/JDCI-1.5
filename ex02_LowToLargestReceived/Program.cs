/*2. The application receives five numbers and returns them ordered from lowest to largest.
The numbers must be stored in an array as they are received;*/

int[] array = new int[5];
int i = 0;

Console.WriteLine("Novamente, escreva 5 numeros, e vou devolve-los em ordem crescente:");

while(i < 5)
{
    Console.WriteLine($"Digite o {i + 1}º numero:");
    array[i] = int.Parse(Console.ReadLine());
    i++;
}
Array.Sort(array);
Console.WriteLine("Aqui estao seus numeros em ordem crescente:");

i = 0;
while (i < 5)
{
    Console.WriteLine(array[i]);
    i++;
}
