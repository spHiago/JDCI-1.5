/*3. The application receives five numbers and returns the average. The initial numbers must
be stored in a array;*/

int[] array = new int[5];
int i = 0;

Console.WriteLine("De novo, escreva 5 numeros e vou devolver a media dos mesmos");

while (i < 5)
{
    Console.WriteLine($"Digite o {i + 1}º numero:");
    array[i] = int.Parse(Console.ReadLine());
    i++;
}

Console.WriteLine("Voce criou o seguinte array:");
i = 0;
while (i < 5)
{
    Console.WriteLine(array[i]);
    i++;
}
int j = 0;
double media = 0;
int soma = 0;
while (j < 5)
{
    soma += array[j];
    j++;
}
media = soma / 5.0;

Console.WriteLine($"A media do seu array é {media}.");