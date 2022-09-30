// ------ 2. Välkomnande meddelande
// ------ 1. En lista för att spara historik för räkningar
// ------ 3. Användaren matar in tal och matematiska operation
// OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// ------ 4. Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
// ------ 5. Lägga resultat till listan
// Visa resultat
// Fråga användaren om den vill visa tidigare resultat.
// ------ 6. Visa tidigare resultat
// Fråga användaren om den vill avsluta eller fortsätta.

public class program
{

    static void Main(string[] args)
    {

        // Changes the color of the program code texture.
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;

        // 1. A List to save history of recent calculated answers.
        List<string> recentresult = new List<string>();

        // Operations of set counting methods.
        double total = 0;
        double urnum1 = 0;
        double urnum2 = 0;
        string result = "";
        string calcsymbol = "";
        int o = 1;

        // 2. Welcome message
        Console.WriteLine("Welcome to the Ultra Deluxe Calculator, maybe the greatest build ever..");
        Console.WriteLine("Make sure now to input two digits to execute the calculation\n");

        // 3. User input first number (urnum2) of the calculation.
        while (true)
        {
            Console.WriteLine("Input the first number: ");
            try
            {
                urnum1 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("U have succeded the calculation! NICE");
                Console.ReadKey();
                return;
            }
        // 3. User should now choose between the diffrent "operations"
            Console.WriteLine("Choose between the diffrent methods (+ , - , * , / ");
            calcsymbol = Console.ReadLine();

        // 3. User should now input the second number (urnum2) and operation
            Console.WriteLine("You may now input the second number:");
            urnum2 = Convert.ToDouble(Console.ReadLine());

        // 4. Error message if user trying to "/" with 0 / 0 = error
            if (calcsymbol == "/" && urnum2 == 0)
            {
                Console.WriteLine("Cannot execute inputed value...");
                Console.WriteLine("The calculator shutting down.....");
                Console.ReadKey();
                break;
            }
            else
        // Now, saving the selected result in "total" with methods (+,-,*,/)
            {
                switch (calcsymbol)
                {
                    case "+":
                        total = urnum1 + urnum2;
                        break;
                    case "-":
                        total = urnum1 - urnum2;
                        break;
                    case "*":
                        total = urnum1 * urnum2;
                        break;
                    case "/":
                        total = urnum1 / urnum2;
                        break;
                }
                if (calcsymbol == "+")
                {
                    result = urnum1 + "+" + urnum2 + "=" + total.ToString();
                    Console.WriteLine($"{urnum1} + {urnum2} = " + (urnum1 + urnum2));
                }
                else if (calcsymbol == "-")
                {
                    result = urnum1 + "-" + urnum2 + "=" + total.ToString();
                    Console.WriteLine($"{urnum1} + {urnum2} = " + (urnum1 - urnum2));
                }
                else if (calcsymbol == "*")
                {
                    result = urnum1 + "*" + urnum2 + "=" + total.ToString();
                    Console.WriteLine($"{urnum1} + {urnum2} = " + (urnum1 * urnum2));
                }
                else if (calcsymbol == "/")
                {
                    result = urnum1 + "/" + urnum2 + "=" + total.ToString();
                    Console.WriteLine($"{urnum1} + {urnum2} = " + (urnum1 / urnum2));
                }
            }
        // 5. Saving every string to the list (LIBRARY)   
                recentresult.Add(result);

        // 6. Asking the User if he/she wants to see previous calculations.
            Console.WriteLine("Do you want to see a list of previous calucations? \nYes: (y) No: (n)");
            string urAnswer = Console.ReadLine();

        // Output a list of library answers from previous calculations
            if (urAnswer == "y")
                foreach (var count in recentresult)
                {
                    Console.WriteLine(count);
                }
                o++;

        // Ask the user if he/she wants to continue or Exit program app
            Console.WriteLine("You want to Continue or Exit? \nContinue: (y) Exit: (n)");
            string urAnswerTwo = Console.ReadLine();

            if (urAnswerTwo != "y")
            {
                Console.WriteLine("Thanks for the indata and cya again, hopefully soon!\nIt's now safe to shut down the application");
                Console.ReadKey();
                break;
            }
        }
        Console.ReadKey();
    }
}