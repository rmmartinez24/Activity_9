using System;

public class DiceRoll
{
    private int roll;
    private static Random rnd = new Random();

    public DiceRoll(int roll)
    {
        if (roll < 4 || roll > 20)
        {
            throw new ArgumentOutOfRangeException("Between the numbers 4 and 20");
        }
        this.roll = roll;
    }

    public int diceRoll()
    {
        return rnd.Next(1, roll + 1);
    }
}

public class DiceRolls
{
    public static void Main()
    {
        DiceRoll dieone = new DiceRoll(6);
        DiceRoll dietwo = new DiceRoll(6);

        int die1;
        int die2;
        int numberOfRolls = 0;

        do
        {
            die1 = dieone.diceRoll();
            die2 = dieone.diceRoll();

            Console.WriteLine("Roll Number: " + numberOfRolls);
            Console.WriteLine("Dice 1: " + die1);
            Console.WriteLine("Dice 2: " + die2);
            Console.WriteLine("");

            ++numberOfRolls;
        }

        while (die1 != 1 || die2 != 1);

        Console.WriteLine("It took " + numberOfRolls + " rolls to get to snake eyes");
    }
}
