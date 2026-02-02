// Coin Flip Challenge

Random coin = new Random();
int flip = coin.Next(0, 11);

Console.WriteLine(flip % 2 == 0 ? "Heads!" : "Tails!");


// Decision Logic Challenge

string permission = "Admin";
int level = 255;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficiente privileges.");
}
else
{
    Console.WriteLine("You do not have sufficiente privileges.");
}