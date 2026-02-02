Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 135);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);


/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 369);
}
Console.WriteLine($"Last number: {current}");

*/

// Chaalenge - Battle Game

int heroHealth = 10;
int monsterHealth = 10;
int attack = random.Next(1, 11);

while (heroHealth > 0 && monsterHealth > 0)
{
    attack = random.Next(1, 11);
    monsterHealth -= attack;
    Console.WriteLine($"Hero attacks!\nMonster has lost {attack} HP;\nMonster's HP: {monsterHealth}");
    if (monsterHealth <= 0) break;
    attack = random.Next(1, 11);
    heroHealth -= attack;
    Console.WriteLine($"Monster attacks!\nHero has lost {attack} HP;\nHero's HP: {heroHealth}");
    if (heroHealth <= 0) break;
}

if (heroHealth <= 0)
    Console.WriteLine("Monster Wins!!");
else
    Console.WriteLine("Hero Wins!!");