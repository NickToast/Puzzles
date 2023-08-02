Console.WriteLine("Choose what size of die you would like to roll with. Type 6, 12, or 20 and hit enter: ");
string dieSides = Console.ReadLine();
if (Int32.TryParse(dieSides, out int sides))
{
    Console.WriteLine($"You chose the {sides}-sided die.");
}
//Then use the variable, sides, for any dice rolling in next functions

//Coin Flip
/*We've likely all flipped a coin at least once in our lives when trying to decide on this or that.
Flipping a coin in person is easy. But how would you write your own coin flip function?
Write a function that returns "heads" or "tails" depending on the result you get.*/
static string CoinFlip()
{
    Random rand = new Random();
    if (rand.Next(2) == 0)
    {
        return "Heads";
    } else {
        return "Tails";
    }
}

Console.WriteLine("Coin Flip");
Console.WriteLine(CoinFlip());
Console.WriteLine("-------------------");

//Dice Roll
/*Once you have figured out coin flip, take your learning to the next level by creating a dice roller.
Once again, think about what it is like to roll a die in real life. How could you replicate those actions in code?*/
static int DiceRoll()
{
    Random rand = new Random();
    return rand.Next(1, 7);
}

Console.WriteLine("Dice Roll");
Console.WriteLine(DiceRoll());
Console.WriteLine("-------------------");

//Bonus: Can you rewrite your function to accept a parameter for the number of sides so you can roll any number-sided die?
static int DiceRollSides(int sides)
{
    Random rand = new Random();
    return rand.Next(1, sides+1);
}

Console.WriteLine("Dice Roll with Sides");
Console.WriteLine(DiceRollSides(12));
Console.WriteLine("-------------------");

//Stat Roll
/*Once you have your dice roller all worked out, write a new function that will roll your dice 4 times and returns a List of those 4 results.
You can write your function to hard-code 4 dice rolls.*/
static List<int> StatRoll()
{
    List<int> Stats = new List<int>();
    for (int i = 0; i < 4; i++)
    {
        Stats.Add(DiceRoll());
    }
    return Stats;
}

Console.WriteLine("Stat Roll");
Console.WriteLine(string.Join(", ", StatRoll()));
Console.WriteLine("-------------------");

//Bonus: Write function to roll any number of times you would like
//Bonus: After rolls, print largest value you rolled
static List<int> StatRollTimes(int numTimesRoll)
{
    List<int> Stats = new List<int>();
    int largestValue = 0;
    for (int i = 0; i < numTimesRoll; i++)
    {
        Stats.Add(DiceRoll());
        if (Stats[i] > largestValue)
        {
            largestValue = Stats[i];
        }
    }
    Console.WriteLine(largestValue);
    return Stats;
}

Console.WriteLine("Stat Roll as Many Times");
Console.WriteLine(string.Join(", ", StatRollTimes(6)));
Console.WriteLine("-------------------");


//Roll Until
/*Write a new function that will roll your 6-sided die until you land on a certain result and tracks how many rolls occurred until it lands on the given number.
For example, you could tell your code to keep rolling until your 6-sided die rolls the number 2.
When you land on the number, return a string that says "Rolled a {number} after {count} tries".
Tip: Do not hard-code the number you're looking for. Be able to accept any number.*/
static string RollUntil(int num)
{
    if (num > 6 || num < 1)
    {
        return $"Your number, {num}, is not on the 6-sided die.";
    }
    int count = 0;
    int temp = -1;
    while (temp != num)
    {
        temp = DiceRoll();
        count++;
    }
    return $"Rolled a {num} after {count} tries.";
}

Console.WriteLine("Roll Until");
Console.WriteLine(RollUntil(4));
Console.WriteLine(RollUntil(8));
Console.WriteLine("-------------------");
