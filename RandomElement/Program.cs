string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonigth are going to eat {snacks[randomIndex]}.");
