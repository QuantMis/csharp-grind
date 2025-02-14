using System;
using System.Threading;

bool start = true;

Console.WriteLine("\n=============== NUMBER GUESSING ===============");
Console.WriteLine("Hello. Welcome to the game.");
Console.WriteLine("What is your name?");

string? playerName = Console.ReadLine();
string greetings = $"Hello {playerName}!";

Console.WriteLine(greetings);

Console.WriteLine("Please pick a number..");

int answer = (new Random()).Next(-100,100);
int guess = 0;
int attempt = 0;

bool validInput = false;

while (!validInput) {
    try {
        guess = Convert.ToInt32(Console.ReadLine());
        validInput = true;
    } catch (Exception) {
        Console.WriteLine("Invalid number, please pick again"); 
    }
}
while(start) {
    try {
        attempt += 1;

        int diff = guess - answer;

        if (diff == 0) {
            Console.WriteLine("You got that right.");
            start = false;
            break;

        } else if (diff > 0) {
            Console.WriteLine("Too High");
        } 
        else {
            Console.WriteLine("Too Low");
        }

        Console.WriteLine("Please pick again..");
        guess = Convert.ToInt32(Console.ReadLine());
    } catch (Exception) {
        continue;
    }
}

string totalAttempt = $"Your Total Attempt: {attempt}";
Console.WriteLine("Good game. You manage to find the number");
Console.WriteLine(totalAttempt);
Console.WriteLine("=============== NUMBER GUESSING ===============");
