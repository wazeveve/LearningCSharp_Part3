/*
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


// Challenge - Battle Game

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

// Challenge - Code 1 - Write code that validates integer input

string? readResult;
int choosenNumber;
bool validNumber = false;
bool validChoice = false;
do
{
    Console.WriteLine("Please, insert a number beetween 5 and 10: ");
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out choosenNumber);
    if (choosenNumber >= 5 && choosenNumber <= 10)
    {
        validChoice = true;
        continue;
    }
    else
        Console.WriteLine("Choose a number beetween 5 and 10");
} while (validChoice == false);
Console.WriteLine($"Your input: {choosenNumber} was accepted!");



// Challenge - Code 2 - Write code that validates string input


string? choosenOption;
bool validString = false;
string[] validOptions = { "administrator", "manager", "user" };
Console.WriteLine("Choose an option:\nAdministrator | Manager | User");
do
{
    choosenOption = Console.ReadLine();
    choosenOption = choosenOption.Trim();
    choosenOption = choosenOption.ToLower();
    foreach (var option in validOptions)
    {
        if (option != choosenOption)
        {
            
            continue;
        }
        

        if(option == choosenOption)
        {
            validString = true;
            continue;
        }
    }
    if (validString == false)
        Console.WriteLine("Invalid Input! Try Again!");



} while (validString == false);

Console.WriteLine($"Your input was accepted! Welcome {choosenOption}");
