﻿using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("I really am enthusiastic");

    // Ask some questions
    Question();
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}


void Question()
{
    bool isTrue = MooseAsks("is Canada real?");
        if (isTrue)
        {
            MooseSays("Really? Seems very unlikely.");
        }
        else
        {
            MooseSays("I  K N E W  I T !!!");
        }

    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
        if (isEnthusiastic)
        {
            MooseSays("Yay!");
        }
        else
        {
            MooseSays("You should try it!");
        }

    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
        if (doesLoveCSharp)
        {
            MooseSays("Good job sucking up to your instructor!");
        }
        else
        {
            MooseSays("You will...oh, yes, you will...");
        }

    bool wantsSecret = MooseAsks("Do you want to know a secret?");
        if (wantsSecret)
        {
            MooseSays("ME TOO!!!! I love secrets...tell me one!");
        }
        else
        {
            MooseSays("Oh, no...secrets are the best, I love to share them!");
        }
}







