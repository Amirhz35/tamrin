//amir hossein zarei


using System.Diagnostics;

string ans,ans1;


Console.WriteLine("please notice that you can only use *Y/y* or *N/n*");
do
{
    Console.WriteLine("are you married??");
    lockkey();
    switch (ans)
    {
        case "y":
        case "Y":
            Console.WriteLine("have you any kids??");
            lockkey();
            switch (ans)
            {
                case "y":
                case "Y":
                    Console.WriteLine("do you want more kids??");
                    lockkey();
                    switch (ans)
                    {
                        case "y":
                        case "Y":
                            Console.WriteLine("is your wife ok with that??");
                            lockkey();
                            switch (ans)
                            {
                                case "y":
                                case "Y":
                                    Console.WriteLine("I'll hope your kid will be safe.");
                                    break;
                                case "n":
                                case "N":
                                    Console.WriteLine("I'll hope you can convince your wife.");
                                    break;
                            }
                            break;
                        case "n":
                        case "N":
                            Console.WriteLine("I'll hope you have happy life.");
                            break;
                    }
                    break;
                case "n":
                case "N":
                    Console.WriteLine("don't you want a kid??");
                    lockkey();
                    switch (ans)
                    {
                        case "y":
                        case "Y":
                            Console.WriteLine("I'll hope someday you reach your wish.");
                            break;
                        case "n":
                        case "N":
                            Console.WriteLine("ohh that's a sad thing to hear kids are so sweat.");
                            break;
                    }
                    break;
            }
            break;
        case "n":
        case "N":
            Console.WriteLine("are you going to married??");
            lockkey();
            switch (ans)
            {
                case "y":
                case "Y":
                    Console.WriteLine("do you find right person??");
                    lockkey();
                    switch (ans)
                    {
                        case "y":
                        case "Y":
                            Console.WriteLine("I'll hope you marry her someday.");
                            break;
                        case "n":
                        case "N":
                            Console.WriteLine("I'll hope you find right person.");
                            break;
                    }
                    break;
                case "n":
                case "N":
                    Console.WriteLine("alright i wont disturb you any more.");
                    break;
            }
            break;
    }
    lockkeyend();
} while (ans1.ToLower() == "y");
Console.WriteLine("thank you for using this program <3");







void lockkeyend()
{

    Console.WriteLine("do you want to try again?? pls press *y* \nif you don't want to try again pls press *n*");
    do
    {
        ans1 = Console.ReadKey(true).KeyChar.ToString();

    } while (ans1.ToLower() != "y" && ans1.ToLower() != "n");
}





    void lockkey()
{
    do
    {
        ans = Console.ReadKey(true).KeyChar.ToString();

    } while (ans.ToLower() != "y" && ans.ToLower() != "n");
}


