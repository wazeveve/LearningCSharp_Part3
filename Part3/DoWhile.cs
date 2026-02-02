Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 84151818);
    Console.WriteLine(current);
} while (current != 7);