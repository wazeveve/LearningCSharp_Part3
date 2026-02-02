// Coin Flip Challenge

Random coin = new Random();
int flip = coin.Next(0, 11);

Console.WriteLine(flip % 2 == 0 ? "Heads!" : "Tails!");
