int[] rar = new int[11];
Random rnd = new Random();

rar[0] = 7;
for (int i = 1; i < a.Length; i++)
{
   rar[i] = rnd.Next(0, 9);
}
Console.Write('+' + rar[0] + " ("+rar[1]+rar[2] +rar[3] + ") "+rar[4]+rar[5]+rar[6] + " - "+rar[7]+rar[8]+" "+rar[9]+rar[10] + "\n" + "\n");





Console.Write("Вводим строку: ");
string c = Console.ReadLine();
if (c.Length <= 3)
{
    Console.WriteLine(c[0] + "...");
}
else if (15 >= c.Length)
{
    Console.WriteLine(c);
}
else
{
    String str = "";
    for (int i = 0; 15 > i; i++)
    {
        str += c[i];
    }
    Console.WriteLine(str + "..." + "\n");
}
Console.WriteLine();




Console.Write("Введите число: ");
string bob = Console.ReadLine();

for (int i = 0; i < bob.Length; i++)
{
    int n = (int)bob[i];
    Console.WriteLine(n * n);
}

