/*4. The application receives an X number of inputs. It must return the correspondent value on
request; after each request it must ask the user if it desires another retrieval. The
information must be stored in an array;*/

Console.WriteLine("Bem vindo, nós vamos criar um array, para começar, digite o tamanho de espaço desejado: ");
int space = Convert.ToInt32(Console.ReadLine());
int[] array = new int[space];

int i = 0;
while (i < space)
{
    Console.WriteLine($"Digite o valor para a {i}º posiçao:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
string continuar;
do
{
    Console.WriteLine($"Digite o índice do valor que deseja consultar (0 a {space}).");
    int indice = Convert.ToInt32(Console.ReadLine());

    if (indice >= 0 && indice < space)
    {
        Console.WriteLine($"Valor na posição {indice}: {array[indice]}");
    }
    else
    {
        Console.WriteLine("Índice inválido.");
    }

    Console.WriteLine("Deseja consultar outro valor? (s/n)");
    continuar = Console.ReadLine();
}while (continuar?.ToLower() == "s");