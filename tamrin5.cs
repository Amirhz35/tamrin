//amir hossein zarei

int x;
int y;
ConsoleKeyInfo digit;
string output;



do
{
    Console.WriteLine("please enter your grade:");
    x = 0;
    do
    {
        lockkeynum();
        Calculatex();

    } while (digit.Key.ToString() != "Enter");

    calculategrade();
    lockkeyyn();
} while (output.ToLower() == "y");
Console.WriteLine("thank you for using this program <3");







void calculategrade()
{
    if (20 < x || x < 0)
        Console.WriteLine("oh i think you made a mistake, your grade should be between 0 and 20");
    else
    {
        if (17 < x && x <= 20)
            Console.WriteLine("your grade rank is A");
        else if (15 < x && x <= 17)
            Console.WriteLine("your grade rank is B");
        else if (10 < x && x <= 15)
            Console.WriteLine("your grade rank is C");
        else
            Console.WriteLine("oh sorry you are failed");
        y = x * 5;
        Console.WriteLine($"you have achieved {y}% of the total grade");
    }
}



void lockkeynum()
{
    do
    {
        digit = Console.ReadKey(true);

    } while(digit.KeyChar.ToString() != "0" && digit.KeyChar.ToString() != "1" &&
            digit.KeyChar.ToString() != "2" && digit.KeyChar.ToString() != "3" &&
            digit.KeyChar.ToString() != "4" && digit.KeyChar.ToString() != "5" &&
            digit.KeyChar.ToString() != "6" && digit.KeyChar.ToString() != "7" &&
            digit.KeyChar.ToString() != "8" && digit.KeyChar.ToString() != "9" &&
            digit.Key.ToString() != "Enter");
}
void Calculatex()
{
    if (digit.Key.ToString() != "Enter")
        x = x * 10 + Convert.ToInt32(digit.KeyChar.ToString());
        Console.Write(digit.KeyChar);
}


void lockkeyyn()
{
    Console.WriteLine("do you want to continue?? pls press *y* \n" +
        "if you don't want to continue pls press *n*");
    do
    {
        output = Console.ReadKey(true).KeyChar.ToString();

    } while (output.ToLower() != "y" && output.ToLower() != "n");
}