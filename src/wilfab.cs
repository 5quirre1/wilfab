/*   /////////////////////////////////////////////////////////////////////////////
 *   
 *   wait in line for a banana - Made by 5quirre1 :3
 *   
 *   I randomly came up with this during tech and was like "this would be peak" so
 *   yea LMFAO I really hope you enjoy this game since it's actually sorta fun!!!
 *
 *
 *   tell me if you liked the game or if it was boring please 
 *   (tag me on pikdiary @squirrel or text me on discord) please!!!!!!!!!!!!!!!!!!
 *   
 *   /////////////////////////////////////////////////////////////////////////////
 *   ------------------------------------------------------------------------------
 *   MIT License
 *
 *   Copyright (c) 2025 Squirrel
 *
 *   Permission is hereby granted, free of charge, to any person obtaining a copy
 *   of this software and associated documentation files (the "Software"), to deal
 *   in the Software without restriction, including without limitation the rights
 *   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *   copies of the Software, and to permit persons to whom the Software is
 *   furnished to do so, subject to the following conditions:
 *
 *   The above copyright notice and this permission notice shall be included in all
 *   copies or substantial portions of the Software.
 *
 *   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *   SOFTWARE.
 *   ------------------------------------------------------------------------------
 *   
 */
 
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{

    static int bananaTolerance = 3;
    static int sanity = 100;
    static int patience = 100;
    static bool hasLuckyPenny = false;
    static bool hasMysteriousToken = false;
    static List<string> inventory = new List<string>();

    static readonly string[] RandomEvents = new[]
    {
        "a guy in a banana costume walks by and screams 'BANANA IS LIE!' and then gets eaten by some banana.",
        "someone starts playing the harmonica very badly..",
        "you suddenly remember you left the stove on. Wait... do you even have a stove?",
        "a squirrel was eating a banana before staring at you and calling you a slur.",
        "the guy in front of you evaporates into mist. Nobody notices.",
        "you hear whispers saying, 'banana is love banana is king i love big banana'.",
        "someone hands out free coupons for toe polish.",
        "a baby begins reciting Shakespeare flawlessly.",
        "someone tries to sell you an NFT of the banana."
    };

    static readonly string[] AdditionalEvents = new[]
    {
        "your shoelaces tie themselves into a perfect bow.",
        "a bird lands on your shoulder and whispers stock tips.",
        "you swear the lamppost just blinked at you.",
        "a business card appears in your pocket for 'Banana & Banana Co.'",
        "your reflection in a puddle winks at you.",
        "the person behind you keeps breathing down your neck, but when you turn around, they're standing 6 feet away.",
        "you feel a sudden craving for banana-flavored toothpaste.",
        "someone's ringtone is just the word 'banana' repeated in a monotone voice.",
        "an old lady offers you a cookie that smells like gasoline.",
        "your watch runs backward for 30 seconds.",
        "you feel like you're being watched by potassium-based lifeforms.",
        "a courier delivers a package to someone in line containing a single banana peel.",
        "two identical twins in matching banana shirts walk by, speaking in perfect unison.",
        "your shadow seems to be moving slightly out of sync with you.",
        "a small child points at you and says, 'The banana already knows your name.'",
        "you briefly forget how to spell 'banana' and it seems like the most hilarious thing ever.",
        "a butterfly lands on your nose and its wings display tiny banana patterns."
    };

    static readonly string[] MajorEvents = new[]
    {
        "a street performer dressed as a giant banana starts dancing. He stops, points at you and shouts, 'THE CHOSEN ONE HAS ARRIVED!'.",
        "a black cat crosses the line, looks directly at you, and meows what sounds suspiciously like 'banana'.",
        "a news crew arrives to interview people about 'The Banana Phenomenon'. They seem oddly interested in you.",
        "the sky darkens momentarily. When it brightens again, everyone in line has yellow-tinted skin.",
        "a mysterious figure in a trench coat offers you a 'lucky penny' that might 'help with the banana situation later'.",
        "you feel an odd vibration. Your phone has a text from an unknown number that just says 'THE BANANA AWAITS YOU'.",
        "a person walks backward through the entire line, handing out tiny slips of paper with banana stickers. Yours has a star on it.",
        "an ice cream truck plays a creepy version of its jingle as it circles the block three times before disappearing into an alley that wasn't there before.",
        "a group of scientists in hazmat suits take readings near the banana stand, then look at you with concerned expressions.",
        "a small tear seems to appear in the air itself, revealing what looks like another dimension full of bananas before quickly sealing shut."
    };

    static readonly string[] Choices = new[]
    {
        "strike up a conversation with someone in line",
        "examine your surroundings more carefully",
        "check your pockets",
        "do a little dance to pass the time",
        "contemplate the meaning of bananas",
        "close your eyes and count to ten",
        "hum a tune to yourself",
        "practice your banana peeling technique",
        "try to peek ahead to see the banana"
    };

    static readonly Dictionary<string, string[]> ChoiceOutcomes = new Dictionary<string, string[]>
    {
        {"strike up a conversation with someone in line", new[]
            {
                "they stare at you blankly and say 'Bananas don't talk. Why do you?' Your sanity decreases slightly.",
                "they enthusiastically tell you about their banana collection at home. You're not sure if they're joking.",
                "they reveal they've been in this line six times this week. 'The banana calls to us all,' they whisper.",
                "you make small talk about the weather. Mid-sentence, they suddenly forget you exist and look forward again."
            }
        },
        {"examine your surroundings more carefully", new[]
            {
                "you notice all the buildings around you have subtle banana motifs in their architecture.",
                "the shadows don't quite line up with the light sources. how strange.",
                "you spot a mysterious token on the ground that might be useful later.",
                "everyone in line seems to be wearing at least one yellow item of clothing. Including you. When did you put that on?"
            }
        },
        {"check your pockets", new[]
            {
                "you find a receipt for 'Banana Line Insurance' that you don't remember purchasing.",
                "there's a mysterious key with a banana-shaped head. You decide to keep it.",
                "your pockets are deeper than you remember. Much deeper.",
                "you find a note that says 'DON'T GET BANANA' in what appears to be your handwriting."
            }
        },
        {"do a little dance to pass the time", new[]
            {
                "people in line join your dance. For a moment, everything seems normal and fun.",
                "as you dance, you notice your movements leave yellow trails in the air.",
                "your dancing seems to agitate the squirrels nearby. they begin to gather and watch you.",
                "no one reacts to your dance at all, as if they can't see you doing it."
            }
        },
        {"contemplate the meaning of bananas", new[]
            {
                "you have a profound realization about the curved nature of space-time. Then you forget it immediately.",
                "you begin to wonder if bananas are contemplating you back.",
                "the word 'banana' starts to lose all meaning as you repeat it in your mind.",
                "you get an eerie feeling that the banana at the end of this line is the key to everything."
            }
        },
        {"close your eyes and count to ten", new[]
            {
                "when you open your eyes, it seems like everyone in line has shifted position slightly.",
                "you hear a whisper at the count of 7 that says 'banana'.",
                "counting helps you center yourself. You feel more patient.",
                "You forget what comes after seven twice in a row, which might mean you're actually stupid."
            }
        },
        {"hum a tune to yourself", new[]
            {
                "you realize you're humming the banana boat song. So is everyone else in line, in perfect harmony.",
                "your humming seems to repel the general weirdness for a moment. You feel slightly more sane.",
                "A nearby pigeon starts dancing to your tune.",
                "The person in front of you turns around and continues your exact melody when you stop."
            }
        },
        {"practice your banana peeling technique", new[]
            {
                "Your fingers make the perfect peeling motion. You feel oddly prepared.",
                "someone notices and gives you a thumbs up. 'wow you are so good at banana peal,' they say weirdly.",
                "you practice opening banana. nothing happens",
                "Your hands seem to know the perfect technique, as if they've peeled cursed bananas before."
            }
        },
        {"try to peek ahead to see the banana", new[]
            {
                "The line curves impossibly, preventing you from seeing the front.",
                "you get a brief glimpse of something yellow and glowing before someone blocks your view.",
                "as you stretch to see, the line seems to get longer. Your patience decreases.",
                "For a split second, you think you see yourself at the front of the line, already receiving the banana."
            }
        }
    };

    static readonly string[] BananaBossDialog = new[]
    {
        "THE BANANA GUARDIAN APPEARS! It's a 7-foot tall banana with muscular arms and sunglasses.",
        "'SO YOU SEEK THE SACRED YELLOW FRUIT OF DESTINY?' it booms.",
        "'MANY HAVE COME BEFORE YOU, FEW HAVE BEEN WORTHY!'",
        "The Banana Guardian looks you up and down. 'PERHAPS YOU ARE DIFFERENT... WE SHALL SEE!'"
    };

    public static void Intro()
    {
        Console.Clear(); 
        SlowPrint("you just got off work and is very tired", 40);
        Thread.Sleep(3000);
        SlowPrint("as you walk through the street, you see a random line with a sign above it: 'FREE BANANA' in a alleyway", 40);
        Thread.Sleep(3000);
        SlowPrint("you say to yourself 'banana yum' and walk into line", 40);
        Thread.Sleep(3000);
        SlowPrint("little did you know that banana is no yum", 40);
        Thread.Sleep(4000);
        Console.Clear();
    }

    static void SlowPrint(string text, int delay = 30)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    static void ShowStats()
    {
        Console.WriteLine("\n----------------------");
        Console.WriteLine($"Sanity: {sanity}%");
        Console.WriteLine($"Patience: {patience}%");
        Console.WriteLine($"Banana Tolerance: {bananaTolerance}/5");
        Console.Write("Inventory: ");
        if (inventory.Count == 0)
            Console.Write("Empty");
        else
            Console.Write(string.Join(", ", inventory));
        Console.WriteLine("\n----------------------\n");
    }

    static int ShowChoices()
    {
        Console.Clear(); 
        ShowStats(); 

        Console.WriteLine("\nwhat would you like to do?");

        List<int> choiceIndices = new List<int>();
        Random rand = new Random();

        while (choiceIndices.Count < 4)
        {
            int index = rand.Next(0, Choices.Length);
            if (!choiceIndices.Contains(index))
                choiceIndices.Add(index);
        }

        for (int i = 0; i < choiceIndices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Choices[choiceIndices[i]]}");
        }

        Console.WriteLine("5. Just wait in line");

        int choice = 0;
        while (choice < 1 || choice > 5)
        {
            Console.Write("\nEnter your choice (1-5): ");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("there's 5 choices");
            }
        }

        Console.Clear(); 

        if (choice < 5)
        {
            string chosenAction = Choices[choiceIndices[choice - 1]];
            string[] possibleOutcomes = ChoiceOutcomes[chosenAction];
            string outcome = possibleOutcomes[rand.Next(possibleOutcomes.Length)];

            Console.WriteLine($"\nYou {chosenAction.ToLower()}.");
            Thread.Sleep(1500);
            SlowPrint(outcome);

            if (outcome.Contains("sanity decreases"))
                sanity -= rand.Next(5, 15);
            else if (outcome.Contains("more sane"))
                sanity += rand.Next(5, 10);

            if (outcome.Contains("patience decreases"))
                patience -= rand.Next(5, 15);
            else if (outcome.Contains("more patient"))
                patience += rand.Next(5, 10);

            if (outcome.Contains("mysterious token"))
                hasMysteriousToken = true;

            if (outcome.Contains("key with a banana-shaped head"))
                inventory.Add("Banana Key");
            if (outcome.Contains("note that says"))
                inventory.Add("Mysterious Note");

            sanity = Math.Max(0, Math.Min(100, sanity));
            patience = Math.Max(0, Math.Min(100, patience));
        }

        return choice;
    }

    static void TriggerMajorEvent(Random random)
    {
        Console.Clear(); 
        SlowPrint("* * * * * * * * * * * * * * * * * * * *", 20);
        Thread.Sleep(500);
        SlowPrint(MajorEvents[random.Next(MajorEvents.Length)], 30);
        Thread.Sleep(1000);
        SlowPrint("* * * * * * * * * * * * * * * * * * * *", 20);

        string majorEvent = MajorEvents[random.Next(MajorEvents.Length)];

        if (majorEvent.Contains("lucky penny"))
        {
            Console.WriteLine("\nDo you accept the lucky penny? (Y/N)");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                hasLuckyPenny = true;
                inventory.Add("Lucky Penny");
                SlowPrint("You pocket the penny. It feels unusually warm.");
            }
            else
            {
                SlowPrint("You decline. The figure shrugs and disappears into the crowd.");
            }
        }
        else if (majorEvent.Contains("scientists"))
        {
            sanity -= random.Next(10, 20);
            SlowPrint("This disturbing sight makes you question everything. Your sanity decreases.");
        }
        else if (majorEvent.Contains("text from an unknown number"))
        {
            Console.WriteLine("\nDo you want to reply to the text? (Y/N)");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                SlowPrint("You type 'Who is this?' but the message fails to send. Your phone's wallpaper has changed to a banana.");
                inventory.Add("Cursed Phone");
            }
        }
        else if (majorEvent.Contains("star on it"))
        {
            SlowPrint("The star sticker begins to glow faintly. You feel special somehow.");
            bananaTolerance++;
            SlowPrint("Your banana tolerance has increased!");
        }

        Thread.Sleep(2000);
        Console.Clear(); 
    }

    static void BananaGuardianEncounter()
    {
        Console.Clear();
        SlowPrint("You finally reach the front of the line, but something's different...", 40);
        Thread.Sleep(1500);

        foreach (string dialog in BananaBossDialog)
        {
            SlowPrint(dialog, 50);
            Thread.Sleep(1200);
        }

        SlowPrint("The Banana Guardian crosses its muscular arms. 'YOU MUST ANSWER THREE RIDDLES TO PROVE YOUR WORTH!'");

        string[] riddles = new[]
        {
            "What is yellow on the outside, white on the inside, but is actually neither a color nor a vegi?",
            "I am curved but have no corners, eaten but never hungry. What am I?",
            "What do you call a banana that's too ripe, too green, and just right all at once?"
        };

        string[] answers = new[]
        {
            "banana",
            "banana",
            "banana"
        };

        int answeredCorrectly = 0;

        for (int i = 0; i < riddles.Length; i++)
        {
            Console.Clear(); 
            ShowStats(); 
            SlowPrint($"\nRIDDLE {i+1}: {riddles[i]}", 40);
            Console.Write("\nYour answer: ");
            string answer = Console.ReadLine().ToLower().Trim();

            if (answer == answers[i])
            {
                SlowPrint("'CORRECT!' booms the Guardian. 'MOST IMPRESSIVE!'", 30);
                answeredCorrectly++;
            }
            else
            {
                SlowPrint("'WRONG!' the Guardian shouts. 'THE ANSWER IS, OF COURSE, BANANA!'", 30);
            }

            Thread.Sleep(1500);
        }

        Console.Clear(); 

        if (answeredCorrectly >= 2 || hasLuckyPenny || hasMysteriousToken)
        {
            SlowPrint("\n'YOU HAVE PROVEN YOURSELF WORTHY OF THE SACRED FRUIT!'", 50);
            if (answeredCorrectly < 3 && hasLuckyPenny)
            {
                SlowPrint("The lucky penny in your pocket vibrates and turns into banana dust.");
            }
            SlowPrint("The Banana Guardian steps aside, revealing a pedestal with a glowing banana...");
        }
        else
        {
            SlowPrint("\n'YOU HAVE FAILED THE TRIALS!'", 50);
            SlowPrint("The Banana Guardian sighs. 'BUT COMPANY POLICY SAYS I HAVE TO GIVE YOU THE BANANA ANYWAY.'");
            SlowPrint("It grudgingly steps aside, revealing an ordinary-looking banana...");
        }

        Thread.Sleep(2000);
    }

    static void Ending()
    {
        Console.Clear(); 
        SlowPrint("You reach for the banana...", 50);
        Thread.Sleep(2000);

        if (sanity <= 20)
        {
            SlowPrint("As your hand touches the banana, you realize your hand is also a banana.", 40);
            Thread.Sleep(1000);
            SlowPrint("In fact, you've been a banana all along.", 40);
            Thread.Sleep(1000);
            SlowPrint("You've come home.", 70);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 1/5: RETURN TO BANANA", 100);
        }
        else if (patience <= 20)
        {
            SlowPrint("You grab the banana impatiently and take a huge bite without peeling it.", 40);
            Thread.Sleep(1000);
            SlowPrint("It tastes like... victory? No, just banana.", 40);
            Thread.Sleep(1000);
            SlowPrint("But as you swallow, the world begins to rewind around you...", 40);
            Thread.Sleep(1000);
            SlowPrint("You find yourself back at work, but this time, you just quit", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 2/5: TEMPORAL BANANA LOOP", 100);
        }
        else if (bananaTolerance >= 5)
        {
            SlowPrint("You take the banana with confidence. It doesn't wink - it bows to you.", 40);
            Thread.Sleep(1000);
            SlowPrint("'The student has become the master,' it whispers.", 40);
            Thread.Sleep(1000);
            SlowPrint("You are now the Banana Guardian. Your shift starts tomorrow at 9.", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 3/5: BANANA ASCENSION", 100);
        }
        else if (inventory.Contains("Banana Key"))
        {
            SlowPrint("The banana has a tiny keyhole at its stem. you insert your banana key.", 40);
            Thread.Sleep(1000);
            SlowPrint("The banana splits open, revealing a tiny door to another dimension.", 40);
            Thread.Sleep(1000);
            SlowPrint("Beyond it, a world of wonder awaits... bananaverse awaits!", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 4/5: THE BANANAVERSE", 100);
        }
        else
        {
            SlowPrint("You are handed the banana...", 40);
            Thread.Sleep(2000);
            SlowPrint("It winks at you.", 40);
            Thread.Sleep(2000);
            SlowPrint("then you disappears", 40);
            Thread.Sleep(3000);
            Console.Clear();
            SlowPrint("ENDING 5/5: YOU HAVE OBTAINED THE CURSED BANANA", 100);
        }

        Thread.Sleep(3000);
        Console.WriteLine("\n\nPress any key to exit.");
        Console.ReadKey();
    }

    static void Main()
    {
        Console.Title = "Wait in line for a banana";
        Random random = new Random();

        Intro();

        int peopleInLine = random.Next(15, 35);  
        SlowPrint($"you are in line. People ahead of you: {peopleInLine}");

        string message = peopleInLine >= 20
            ? "The line is incredibly long. This might take forever..."
            : peopleInLine >= 13
                ? "The line is pretty long..."
                : "Wow, the line is pretty short!";

        SlowPrint(message);
        SlowPrint("\nWaiting in line... weird things start to happen...\n");
        Thread.Sleep(3000);

        int eventCounter = 0;  
        int majorEventThreshold = random.Next(5, 8);  

        while (peopleInLine > 0)
        {
            Console.Clear(); 

            ShowStats();

            SlowPrint($"People ahead of you in line: {peopleInLine}\n");

            if (random.Next(100) < 70)
                ShowChoices();

            int waitTime = random.Next(2, 5);
            Thread.Sleep(waitTime * 1000);

            if (random.Next(100) < 60)
            {
                eventCounter++;
                Console.Clear(); 

                string randomEvent;
                if (random.Next(100) < 40)
                    randomEvent = RandomEvents[random.Next(RandomEvents.Length)];
                else
                    randomEvent = AdditionalEvents[random.Next(AdditionalEvents.Length)];

                SlowPrint($"{randomEvent}");
                Thread.Sleep(2000);

                if (randomEvent.Contains("BANANA IS LIE"))
                {
                    sanity -= random.Next(5, 10);
                    SlowPrint("This outburst disturbs you. Your sanity decreases slightly.");
                }
                else if (randomEvent.Contains("breathing down your neck"))
                {
                    patience -= random.Next(5, 10);
                    SlowPrint("This is really getting on your nerves. Your patience decreases.");
                }
                else if (randomEvent.Contains("cookie that smells like gasoline"))
                {
                    Console.WriteLine("\nDo you accept the cookie? (Y/N)");
                    if (Console.ReadLine().ToUpper().StartsWith("Y"))
                    {
                        SlowPrint("You don't eat it, but keep it for later. Might be useful.");
                        inventory.Add("Suspicious Cookie");
                        bananaTolerance++;
                    }
                }

                Thread.Sleep(2000);
            }

            if (eventCounter >= majorEventThreshold)
            {
                TriggerMajorEvent(random);
                eventCounter = 0;
                majorEventThreshold = random.Next(5, 8);
            }

            int lineChange = random.Next(100) < 80 ? -1 : random.Next(-1, 2);

            if (peopleInLine <= 5)
                lineChange = -1;

            peopleInLine += lineChange;

            peopleInLine = Math.Max(0, peopleInLine);

            Console.Clear(); 

            if (lineChange < 0)
                SlowPrint($"Someone left the line. People ahead of you: {peopleInLine}\n");
            else if (lineChange > 0)
                SlowPrint($"Someone joined ahead of you. How rude! People ahead of you: {peopleInLine}\n");
            else
                SlowPrint($"The line isn't moving. People ahead of you: {peopleInLine}\n");

            if (random.Next(100) < 10)
            {
                patience -= random.Next(3, 8);
                SlowPrint("The wait is getting to you. Your patience decreases a bit.");
            }

            Thread.Sleep(2000);

            if (sanity <= 0)
            {
                Console.Clear(); 
                SlowPrint("\nYou've lost your mind completely. You begin to hallucinate that you ARE a banana.");
                SlowPrint("Security escorts you away from the line as you try to peel your own skin off.");
                Thread.Sleep(3000);
                Console.Clear();
                SlowPrint("GAME OVER: SANITY FAILURE", 100);
                Console.WriteLine("\n\nPress any key to exit.");
                Console.ReadKey();
                return;
            }

            if (patience <= 0)
            {
                Console.Clear(); 
                SlowPrint("\nYou've had enough of this nonsense! You storm off, cursing bananas and everything they stand for.");
                SlowPrint("As you leave, you hear soft laughter coming from the banana stand.");
                Thread.Sleep(3000);
                Console.Clear();
                SlowPrint("GAME OVER: PATIENCE EXHAUSTED", 100);
                Console.WriteLine("\n\nPress any key to exit.");
                Console.ReadKey();
                return;
            }
        }

        BananaGuardianEncounter();

        Ending();
    }
}
