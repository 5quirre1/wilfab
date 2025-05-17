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
    static int bananaEnergy = 50;
    static int weirdnessMeter = 0;
    static bool hasLuckyPenny = false;
    static bool hasMysteriousToken = false;
    static bool hasSeenBananaVisions = false;
    static bool hasMetBananaOracle = false;
    static bool wearingBananaHat = false;
    static List<string> inventory = new List<string>();
    static List<string> bananaSecrets = new List<string>();

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

    static readonly string[] ExtraRandomEvents = new[]
    {
        "a man in a trenchcoat whispers, 'apples are better' before falling into a manhole.",
        "your phone autocorrects every word to 'banana' for five seconds.",
        "a woman carrying a bunch of bananas trips, but the bananas float in mid-air instead of falling.",
        "you notice that everyone in line is exactly the same height for some reason.",
        "a nearby puddle reflects a banana instead of your face.",
        "a bee buzzes by your ear and seems to say 'banana bananana banana'.",
        "you look over at the trees and see some random squirrel is coding.",
        "a street performer juggles invisible bananas. you can somehow hear them hitting his hands.",
        "someone's pet chihuahua barks the melody to 'i love banana banana is king'.",
        "you get a strong sense of Déjà vu, like you've waited in this exact line before.",
        "all the clocks in the area suddenly display 3:33, regardless of the actual time.",
        "a balloon shaped like a banana floats by. its string seems to be reaching toward you.",
        "you sneeze and someone across the street yells 'BANANA' instead of 'bless you'.",
        "a passing cyclist has wheels made of banana peels, but doesn't slip.",
        "a business man in a sharp suit walks by eating a banana with the peel still on."
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

    static readonly string[] ExtraMajorEvents = new[]
    {
        "the ground beneath the line briefly becomes translucent, revealing an underground banana cult performing a ritual directly below you.",
        "an elderly woman approaches you and whispers, 'i've tried to get the banana for 47 years.",
        "you have a weird sense of 'this is not real' but you disregard it.",
        "all electronic devices in the area simultaneously display a yellow screen with a banana emoji for exactly 12 seconds.",
        "a tour bus stops nearby and everyone on board takes photos of specifically you, not anyone else in line.",
        "a banana-shaped cloud forms directly overhead and seems to follow you when you move.",
        "a person in a lab coat approaches with a clipboard and asks, 'On a scale from 1 to banana, how yellow do you feel today?'",
        "you experience a vivid flashback to a childhood memory involving bananas that you're not sure actually happened.",
        "a small monkey in a bellhop uniform approaches and hands you a tiny banana phone, then scampers away giggling.",
        "a nearby drain grate emits yellow steam that smells strongly of bananas and forms the words 'JOIN US' before dissipating."
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

    static readonly string[] ExtraChoices = new[]
    {
        "meditate on the concept of banana",
        "try to remember why you wanted a banana in the first place",
        "attempt to start the wave with people in  line",
        "subtly smell the person in front of you",
        "practice your banana-holding pose",
        "pretend to receive an important banana-related phone call",
        "write a banana haiku in your head",
        "try to leave the line (but find you cannot)",
        "search for banana-shaped clouds in the sky",
        "whisper banana-related conspiracies to yourself",
        "try to calculate how many bananas exist in the world right now",
        "attempt to communicate telepathically with the banana at the end of the line",
        "balance on one foot for as long as possible",
        "try to taste the color yellow",
        "perform subtle banana-themed hand gestures to others in line"
    };

    static readonly Dictionary<string, string[]> ChoiceOutcomes = new Dictionary<string, string[]>
    {
        {
            "strike up a conversation with someone in line",
            new []
            {
                "they stare at you blankly and say 'Bananas don't talk. Why do you?' Your sanity decreases slightly.",
                "they enthusiastically tell you about their banana collection at home. You're not sure if they're joking.",
                "they reveal they've been in this line six times this week. 'The banana calls to us all,' they whisper.",
                "you make small talk about the weather. Mid-sentence, they suddenly forget you exist and look forward again."
            }
        },
        {
            "examine your surroundings more carefully",
            new []
            {
                "you notice all the buildings around you have subtle banana motifs in their architecture.",
                "the shadows don't quite line up with the light sources. how strange.",
                "you spot a mysterious token on the ground that might be useful later.",
                "everyone in line seems to be wearing at least one yellow item of clothing. Including you. When did you put that on?"
            }
        },
        {
            "check your pockets",
            new []
            {
                "you find a receipt for 'Banana Line Insurance' that you don't remember purchasing.",
                "there's a mysterious key with a banana-shaped head. You decide to keep it.",
                "your pockets are deeper than you remember. Much deeper.",
                "you find a note that says 'DON'T GET BANANA' in what appears to be your handwriting."
            }
        },
        {
            "do a little dance to pass the time",
            new []
            {
                "people in line join your dance. For a moment, everything seems normal and fun.",
                "as you dance, you notice your movements leave yellow trails in the air.",
                "your dancing seems to agitate the squirrels nearby. they begin to gather and watch you.",
                "no one reacts to your dance at all, as if they can't see you doing it."
            }
        },
        {
            "contemplate the meaning of bananas",
            new []
            {
                "you have a profound realization about the curved nature of space-time. Then you forget it immediately.",
                "you begin to wonder if bananas are contemplating you back.",
                "the word 'banana' starts to lose all meaning as you repeat it in your mind.",
                "you get an eerie feeling that the banana at the end of this line is the key to everything."
            }
        },
        {
            "close your eyes and count to ten",
            new []
            {
                "when you open your eyes, it seems like everyone in line has shifted position slightly.",
                "you hear a whisper at the count of 7 that says 'banana'.",
                "counting helps you center yourself. You feel more patient.",
                "You forget what comes after seven twice in a row, which might mean you're actually stupid."
            }
        },
        {
            "hum a tune to yourself",
            new []
            {
                "you realize you're humming the banana boat song. So is everyone else in line, in perfect harmony.",
                "your humming seems to repel the general weirdness for a moment. You feel slightly more sane.",
                "A nearby pigeon starts dancing to your tune.",
                "The person in front of you turns around and continues your exact melody when you stop."
            }
        },
        {
            "practice your banana peeling technique",
            new []
            {
                "Your fingers make the perfect peeling motion. You feel oddly prepared.",
                "someone notices and gives you a thumbs up. 'wow you are so good at banana peal,' they say weirdly.",
                "you practice opening banana. nothing happens",
                "Your hands seem to know the perfect technique, as if they've peeled cursed bananas before."
            }
        },
        {
            "try to peek ahead to see the banana",
            new []
            {
                "The line curves impossibly, preventing you from seeing the front.",
                "you get a brief glimpse of something yellow and glowing before someone blocks your view.",
                "as you stretch to see, the line seems to get longer. Your patience decreases.",
                "For a split second, you think you see yourself at the front of the line, already receiving the banana."
            }
        }
    };

    static readonly Dictionary<string, string[]> ExtraChoiceOutcomes = new Dictionary<string, string[]>
    {
        {
            "meditate on the concept of banana",
            new []
            {
                "you achieve banana zen. time seems to slow down and your banana energy increases.",
                "you feel a strange connection to every banana currently existing on earth. it's overwhelming.",
                "you see a vision of the great banana tree of cosmic knowledge. you learn a banana secret.",
                "your mind clears of all banana-related thoughts. it's frightfully empty in there."
            }
        },
        {
            "try to remember why you wanted a banana in the first place",
            new []
            {
                "you can't remember. in fact, you're not sure you ever knew. your sanity decreases slightly.",
                "you remember that bananas are full of potassium. that's probably it. how disappointingly mundane.",
                "you realized that you were just being a moron",
                "you suddenly recall a dream where a banana told you to come here today. this increases your unease."
            }
        },
        {
            "attempt to start the wave with people in line",
            new []
            {
                "everyone joins in perfectly, but their arms all turn yellow during the motion.",
                "no one participates except one old man who does it with disturbing enthusiasm.",
                "people join in, but they all do it in slow motion. your patience decreases.",
                "the wave moves through the line but continues into nearby buildings and streets, never stopping."
            }
        },
        {
            "subtly smell the person in front of you",
            new []
            {
                "they smell strongly of banana despite showing no evidence of having eaten one recently.",
                "they immediately turn around and smell you back. 'you smell like one of us,' they whisper.",
                "they smell like nothing at all. not like a lack of smell, but like the concept of nothingness.",
                "you detect seventeen distinct scents, none of which should be present in this location."
            }
        },
        {
            "practice your banana-holding pose",
            new []
            {
                "your hands naturally form the perfect banana-holding position. it's like they've been doing it for years.",
                "you notice others in line watching and nodding approvingly at your technique.",
                "your hands start trembling in anticipation. what is this banana going to be like?",
                "you suddenly can't remember how to hold things. are thumbs on the inside or outside? panic sets in."
            }
        },
        {
            "pretend to receive an important banana-related phone call",
            new []
            {
                "mid-fake conversation, your phone actually rings. the caller ID says 'BANANA AUTHORITY'.",
                "people around you start pretending to be on calls too, having the exact same conversation.",
                "you hear a real response from the phone despite it not being on. your sanity decreases.",
                "you accidentally say something clever about banana economics. a nearby businessman gives you his card."
            }
        },
        {
            "write a banana haiku in your head",
            new []
            {
                "your haiku is beautiful. a tear rolls down your cheek. it's yellow.",
                "you think of the perfect final line, but it contains the wrong number of syllables. typical.",
                "as you mentally recite your haiku, you notice everyone in line mouthing the words with you.",
                "your haiku wins an imaginary poetry contest. you imagine receiving a trophy shaped like a banana."
            }
        },
        {
            "try to leave the line (but find you cannot)",
            new []
            {
                "your feet won't move. it's like they're stuck in invisible banana pudding.",
                "whenever you try to step away, the line seems to warp around you, keeping you in place.",
                "you manage three steps away before an overwhelming guilt forces you back. the banana needs you.",
                "a security guard who wasn't there before gives you a stern look. 'no line cutting,' he says, despite you trying to leave."
            }
        },
        {
            "search for banana-shaped clouds in the sky",
            new []
            {
                "you spot one perfect banana cloud. it appears to be watching you.",
                "all the clouds are banana-shaped. has it always been this way?",
                "there are no clouds, just an empty blue sky with a faint yellow tint.",
                "you see a cloud that spells out 'BANANA SEES ALL' before dispersing in the wind."
            }
        },
        {
            "whisper banana-related conspiracies to yourself",
            new []
            {
                "someone nearby nods knowingly, as if they heard your exact thoughts.",
                "you accidentally discover a banana truth that makes too much sense. your weirdness meter increases.",
                "your conspiracy theories become increasingly elaborate and interconnected. it all makes sense now!",
                "mid-conspiracy, you forget what bananas are entirely for several seconds."
            }
        }
    };

    static readonly Dictionary<string, string[]> MoreExtraChoiceOutcomes = new Dictionary<string, string[]>
    {
        {
            "try to calculate how many bananas exist in the world right now",
            new []
            {
                "the number appears in your head: 87,624,123,995. it feels oddly specific and correct.",
                "you get confused by the math and accidentally start counting in a base-banana number system.",
                "you realize bananas exist in a quantum superposition. the actual number is unknowable.",
                "your mental calculations reveal the number of bananas equals the number of stars. coincidence?"
            }
        },
        {
            "attempt to communicate telepathically with the banana at the end of the line",
            new []
            {
                "you feel a faint response. it's either the banana or mild carbon monoxide poisoning.",
                "you make contact! the banana shows you a vision of its home planet. your sanity decreases.",
                "the banana seems to be telepathically transmitting the entire 'banana boat song' on loop.",
                "no response from the banana, but the person behind you whispers 'i intercepted that message'."
            }
        },
        {
            "balance on one foot for as long as possible",
            new []
            {
                "you maintain perfect balance. gravity seems to work differently in the banana line.",
                "you hover about half an inch off the ground. no one seems to notice, including you at first.",
                "you topple after 3 seconds and nearly fall into the person ahead. they've been balancing too.",
                "your balancing leg turns slightly yellow from the effort. probably just your imagination."
            }
        },
        {
            "try to taste the color yellow",
            new []
            {
                "it tastes exactly like bananas. this makes perfect sense to you now.",
                "you succeed and are immediately overwhelmed by all the yellow in the world. sensory overload!",
                "you taste something, but it's definitely not yellow. possibly plaid?",
                "you taste the concept of yellowness but get a distinct aftertaste of existential dread."
            }
        },
        {
            "perform subtle banana-themed hand gestures to others in line",
            new []
            {
                "someone responds with the secret banana handshake. how do you know the secret banana handshake?",
                "your hands move of their own accord, signing entire banana manifestos. what are they saying?",
                "people in line turn away nervously. apparently your 'subtle' gestures are actually obscene.",
                "the elderly woman ahead returns your gestures perfectly, then winks and shows you a golden banana pin."
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

    static readonly string[] BananaSecretLore = new[]
    {
        "Bananas aren't fruit, but actually sentient beings from the fifth dimension shaped like fruit.",
        "The curved shape of bananas is designed to match the curve of space-time itself.",
        "Bananas don't grow on trees, they materialize from a parallel dimension when no one's looking.",
        "The yellow color of banana skin is actually caused by quantum fluctuations in potassium.",
        "Bananas were planted on Earth by ancient aliens as monitoring devices.",
        "Each banana contains exactly one microscopic black hole.",
        "The strings on bananas are actually antennae that connect to the banana hivemind.",
        "If you eat a banana at exactly midnight during a full moon, you temporarily gain banana vision.",
        "Bananas are the only food that can be digested in four-dimensional space.",
        "The true purpose of the banana is to serve as a key to the universe."
    };

    static readonly Dictionary<string, string[]> SpecialNPCs = new Dictionary<string, string[]>
    {
        {
            "Banana Oracle",
            new []
            {
                "An ancient woman with yellow-tinged skin sits on a stool beside the line.",
                "Her eyes are completely yellow with no pupils. She beckons you closer.",
                "'I have awaited you, seeker of the curved fruit,' she whispers.",
                "'Do you wish to hear a truth of the banana realm?'"
            }
        },
        {
            "Banana Whisperer",
            new []
            {
                "A man in a professional suit with a banana lapel pin approaches you.",
                "'I can tell you're new to the banana line,' he says, adjusting his tie.",
                "'For a small fee, I can teach you the proper way to address the banana when you meet it.'",
                "'Many have failed due to improper banana etiquette. Are you willing to learn?'"
            }
        },
        {
            "Banana Prophet",
            new []
            {
                "A wild-eyed person with banana peels braided into their hair pushes a shopping cart past the line.",
                "They stop directly in front of you and stare intensely before speaking.",
                "'The Yellow Convergence approaches! The peels will fall away and the truth revealed!'",
                "They thrust a crudely drawn pamphlet into your hands before hurrying away."
            }
        }
    };

    static readonly Dictionary<string, Action> MiniGames = new Dictionary<string, Action>
    {
        {
            "Banana Counting Contest",
            BananaCountingGame
        },
        {
            "Banana Riddles",
            BananaRiddleGame
        },
        {
            "Spot the Fake Banana",
            SpotTheFakeBananaGame
        }
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
        Console.WriteLine($"Banana Energy: {bananaEnergy}%");
        Console.WriteLine($"Banana Tolerance: {bananaTolerance}/5");
        Console.WriteLine($"Weirdness Meter: {weirdnessMeter}/100");
        Console.Write("Inventory: ");
        if (inventory.Count == 0)
            Console.Write("Empty");
        else
            Console.Write(string.Join(", ", inventory));

        if (bananaSecrets.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Banana Secrets: {bananaSecrets.Count}/10");
        }

        Console.WriteLine("\n----------------------\n");
    }

    static int ShowChoices()
    {
        Console.Clear();
        ShowStats();

        Console.WriteLine("\nwhat would you like to do?");

        List<int> choiceIndices = new List<int>();
        Random rand = new Random();

        List<string> allChoices = new List<string>();
        allChoices.AddRange(Choices);
        allChoices.AddRange(ExtraChoices);

        while (choiceIndices.Count < 4)
        {
            int index = rand.Next(0, allChoices.Count);
            if (!choiceIndices.Contains(index))
                choiceIndices.Add(index);
        }

        for (int i = 0; i < choiceIndices.Count; i++)
        {
            Console.WriteLine("{i + 1}. {allChoices[choiceIndices[i]]}");
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
            string chosenAction = allChoices[choiceIndices[choice - 1]];
            string[] possibleOutcomes;

            if (ChoiceOutcomes.ContainsKey(chosenAction))
                possibleOutcomes = ChoiceOutcomes[chosenAction];
            else if (ExtraChoiceOutcomes.ContainsKey(chosenAction))
                possibleOutcomes = ExtraChoiceOutcomes[chosenAction];
            else
                possibleOutcomes = MoreExtraChoiceOutcomes[chosenAction];

            string outcome = possibleOutcomes[rand.Next(possibleOutcomes.Length)];

            Console.WriteLine($"\nYou {chosenAction.ToLower()}.");
            Thread.Sleep(1500);
            SlowPrint(outcome);

            ProcessOutcomeEffects(outcome, rand);

            ClampStats();
        }

        return choice;
    }

    static void ProcessOutcomeEffects(string outcome, Random rand)
    {
        if (outcome.Contains("sanity decreases"))
            sanity -= rand.Next(5, 15);
        else if (outcome.Contains("more sane"))
            sanity += rand.Next(5, 10);

        if (outcome.Contains("patience decreases"))
            patience -= rand.Next(5, 15);
        else if (outcome.Contains("more patient"))
            patience += rand.Next(5, 10);

        if (outcome.Contains("banana energy increases") || outcome.Contains("banana zen"))
            bananaEnergy += rand.Next(10, 20);

        if (outcome.Contains("weirdness meter increases"))
            weirdnessMeter += rand.Next(5, 15);

        if (outcome.Contains("mysterious token"))
            hasMysteriousToken = true;

        if (outcome.Contains("banana secret"))
        {
            string newSecret = BananaSecretLore[rand.Next(BananaSecretLore.Length)];
            if (!bananaSecrets.Contains(newSecret))
            {
                bananaSecrets.Add(newSecret);
                SlowPrint("\nYou learned a banana secret: " + newSecret);
                Thread.Sleep(2000);

                bananaTolerance += bananaSecrets.Count >= 5 ? 1 : 0;
            }
        }

        if (outcome.Contains("key with a banana-shaped head"))
            inventory.Add("Banana Key");
        if (outcome.Contains("note that says"))
            inventory.Add("Mysterious Note");
        if (outcome.Contains("business card"))
            inventory.Add("Banana Business Card");
        if (outcome.Contains("golden banana pin"))
            inventory.Add("Golden Banana Pin");
    }

    static void ClampStats()
    {
        sanity = Math.Max(0, Math.Min(100, sanity));
        patience = Math.Max(0, Math.Min(100, patience));
        bananaEnergy = Math.Max(0, Math.Min(100, bananaEnergy));
        weirdnessMeter = Math.Max(0, Math.Min(100, weirdnessMeter));
    }

    static void TriggerMajorEvent(Random random)
    {
        Console.Clear();
        SlowPrint("* * * * * * * * * * * * * * * * * * * *", 20);
        Thread.Sleep(500);

        List<string> allMajorEvents = new List<string>();
        allMajorEvents.AddRange(MajorEvents);
        allMajorEvents.AddRange(ExtraMajorEvents);

        string majorEvent = allMajorEvents[random.Next(allMajorEvents.Count)];
        SlowPrint(majorEvent, 30);

        Thread.Sleep(1000);
        SlowPrint("* * * * * * * * * * * * * * * * * * * *", 20);

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
            bananaEnergy += 10;
            SlowPrint("Your banana tolerance and energy have increased!!");
        }
        else if (majorEvent.Contains("monkey in a bellhop uniform"))
        {
            Console.WriteLine("\nDo you answer the tiny banana phone? (Y/N)");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                SlowPrint("You hear a bunch of monkey sounds, followed by 'The Banana Council has accepted your application.'");
                inventory.Add("Tiny Banana Phone");
                bananaEnergy += 15;
                SlowPrint("Your banana energy increases. You feel strangely honored.");
            }
            else
            {
                SlowPrint("You decline. The monkey looks disappointed and eats the phone before scampering away.");
            }
        }
        else if (majorEvent.Contains("banana-shaped cloud"))
        {
            SlowPrint("You feel a strange connection to the sky. Your weirdness meter increases substantially.");
            weirdnessMeter += random.Next(15, 25);
            hasSeenBananaVisions = true;
        }
        else if (majorEvent.Contains("underground banana cult"))
        {
            SlowPrint("One of the cultists makes eye contact with you and nods knowingly.");
            bananaSecrets.Add("The Banana Cult has existed since ancient times, waiting for the Ultimate Banana.");
            SlowPrint("You've gained a new banana secret!");
        }

        if (random.Next(100) < 30 && !hasMetBananaOracle)
        {
            TriggerSpecialNPC(random);
        }

        Thread.Sleep(2000);
        Console.Clear();
    }

    static void TriggerSpecialNPC(Random random)
    {
        string[] npcKeys = new string[]
        {
            "Banana Oracle",
            "Banana Whisperer",
            "Banana Prophet"
        };
        string npc = npcKeys[random.Next(npcKeys.Length)];

        Console.Clear();
        SlowPrint("* * * * * * * * * * * * * * * * * * * *", 20);
        Thread.Sleep(500);

        foreach (string line in SpecialNPCs[npc])
        {
            SlowPrint(line, 40);
            Thread.Sleep(800);
        }

        if (npc == "Banana Oracle")
        {
            Console.WriteLine("\nDo you wish to hear a banana truth? (Y/N)");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                string secret = BananaSecretLore[random.Next(BananaSecretLore.Length)];
                if (!bananaSecrets.Contains(secret))
                {
                    bananaSecrets.Add(secret);
                    SlowPrint("\nThe Oracle speaks in a haunting voice:");
                    SlowPrint("'" + secret + "'", 50);
                    SlowPrint("\nThis knowledge changes you somehow...");
                    bananaTolerance++;
                    bananaEnergy += 10;
                    weirdnessMeter += 15;
                    hasMetBananaOracle = true;
                }
                else
                {
                    SlowPrint("\nThe Oracle gazes into your soul.");
                    SlowPrint("'You already carry this knowledge within you. But take this gift instead.'");
                    inventory.Add("Oracle's Banana Charm");
                    SlowPrint("She hands you a small yellow charm. It hums slightly in your palm.");
                    bananaEnergy += 20;
                }
            }
            else
            {
                SlowPrint("\nThe Oracle nods slowly. 'The unready shall remain unready. Farewell.'");
                SlowPrint("She fades away like morning mist. Was she ever really there?");
            }
        }
        else if (npc == "Banana Whisperer")
        {
            Console.WriteLine("\nDo you want to learn proper banana etiquette? (Y/N)");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                SlowPrint("\n'Excellent choice,' he says, straightening his banana lapel pin.");
                SlowPrint("'The first rule of banana etiquette is to never look directly at the stem.'");
                SlowPrint("'The second rule is to always greet the banana with the traditional phrase.'");
                SlowPrint("He teaches you the phrase: 'Hail curved one, vessel of potassium, I am worthy.'");
                SlowPrint("\nYou practice the phrase several times until he's satisfied.");
                inventory.Add("Banana Etiquette Manual");
                bananaTolerance += 2;
                SlowPrint("Your banana tolerance has increased significantly!");
            }
            else
            {
                SlowPrint("\n'Your funeral,' he shrugs. 'Don't say I didn't warn you when the banana rejects you.'");
                SlowPrint("He hands you his business card anyway. 'Call if you change your mind.'");
                inventory.Add("Banana Whisperer's Card");
            }
        }
        else if (npc == "Banana Prophet")
        {
            SlowPrint("\nYou examine the crude pamphlet. It contains bizarre banana-related prophecies.");
            SlowPrint("Most of it is gibberish, but one sentence stands out:");
            SlowPrint("'When the Chosen One receives the Sacred Banana, all shall be peeled.'");

            Console.WriteLine("\nDo you want to keep the pamphlet? (Y/N)");
            if (Console.ReadLine().ToUpper().StartsWith("Y"))
            {
                inventory.Add("Banana Prophecy Pamphlet");
                SlowPrint("You carefully fold and pocket the pamphlet.");
                SlowPrint("It occasionally makes scratching sounds, as if trying to unfold itself.");
                weirdnessMeter += 10;
            }
            else
            {
                SlowPrint("You toss it away, but the wind brings it back to your feet.");
                SlowPrint("You toss it again, and this time it stays gone. For now.");
            }
        }

        Thread.Sleep(2000);
        Console.Clear();
    }

    static void BananaCountingGame()
    {
        Console.Clear();
        SlowPrint("A street vendor with a cart full of bananas stops by the line.", 40);
        SlowPrint("'Heya folks! Guess how many bananas I got here and win a prize!'", 40);
        Thread.Sleep(1000);

        Random random = new Random();
        int actualCount = random.Next(30, 101);

        Console.Write("\nMake your guess: ");
        int guess = 0;
        try
        {
            guess = int.Parse(Console.ReadLine());
        }
        catch
        {
            guess = -1;
        }

        int difference = Math.Abs(guess - actualCount);

        SlowPrint($"\n'I have exactly {actualCount} bananas!' the vendor announces.");

        if (difference == 0)
        {
            SlowPrint("'INCREDIBLE! You got it exactly right! Are you psychic?'");
            SlowPrint("The vendor hands you a special golden banana hat.");
            inventory.Add("Golden Banana Hat");
            bananaEnergy += 25;
            bananaTolerance += 1;
            SlowPrint("You feel like royalty among banana seekers.");
            wearingBananaHat = true;
        }
        else if (difference <= 5)
        {
            SlowPrint("'Wow, that's really close! You have a good banana sense!'");
            SlowPrint("The vendor gives you a banana keychain.");
            inventory.Add("Banana Keychain");
            bananaEnergy += 10;
        }
        else if (difference <= 15)
        {
            SlowPrint("'Not bad, not bad at all.'");
            SlowPrint("The vendor hands you a banana-flavored candy.");
            SlowPrint("It tastes nothing like banana, but somehow exactly like what yellow should taste like.");
        }
        else
        {
            SlowPrint("'Oof, not even close! Maybe bananas aren't your calling.'");
            SlowPrint("The vendor looks at you with suspicion before moving along.");
            patience -= 5;
        }

        Thread.Sleep(2500);
        Console.Clear();
    }

    static void BananaRiddleGame()
    {
        Console.Clear();
        SlowPrint("A mysterious figure in a banana-yellow cloak approaches the line.", 40);
        SlowPrint("'Greetings, banana seeker. Answer my riddle and gain banana wisdom.'", 40);
        Thread.Sleep(1000);

        string[] riddles = new[]
        {
            "I am yellow when I'm peeled, but my skin's not always so. What am I?",
            "I curve toward the earth but never touch it while on my tree. What am I?",
            "Monkeys love me, humans eat me, I'm curved but never straight. What am I?",
            "I come in hands but have no fingers. What am I?"
        };

        Random random = new Random();
        string riddle = riddles[random.Next(riddles.Length)];

        SlowPrint($"\nRiddle: {riddle}", 40);
        Console.Write("\nYour answer: ");
        string answer = Console.ReadLine().ToLower();

        if (answer.Contains("banana"))
        {
            SlowPrint("\n'Your banana wisdom is strong!' the figure says with approval.");
            SlowPrint("'Take this token of banana enlightenment.'");

            string[] rewards = new[]
            {
                "Riddle Master's Banana Badge",
                "Banana Wisdom Token",
                "Yellow Enigma Charm"
            };
            string reward = rewards[random.Next(rewards.Length)];

            inventory.Add(reward);
            bananaEnergy += 15;
            weirdnessMeter += 5;
            bananaTolerance += 1;

            SlowPrint($"You received: {reward}");
            SlowPrint("Your banana energy and tolerance increase!");
        }
        else
        {
            SlowPrint("\n'Incorrect! The answer is, of course, banana.'");
            SlowPrint("The figure looks disappointed and vanishes in a puff of yellow smoke.");
            SlowPrint("You feel like you've failed an important test.");
            sanity -= 5;
        }

        Thread.Sleep(2500);
        Console.Clear();
    }

    static void SpotTheFakeBananaGame()
    {
        Console.Clear();
        SlowPrint("A game show host mysteriously appears with three pedestals.", 40);
        SlowPrint("'Welcome to SPOT THE FAKE BANANA! One of these is not a real banana!'", 40);
        SlowPrint("Three identical-looking bananas rest on the pedestals labeled 1, 2, and 3.", 40);
        Thread.Sleep(1500);

        Random random = new Random();
        int fakeBanana = random.Next(1, 4);

        Console.Write("\nWhich banana is the fake? (1-3): ");
        int guess = 0;
        try
        {
            guess = int.Parse(Console.ReadLine());
        }
        catch
        {
            guess = -1;
        }

        if (guess < 1 || guess > 3)
        {
            SlowPrint("\n'That's not even an option! DISQUALIFIED!' shouts the host.");
            SlowPrint("The pedestals and host vanish in a puff of smoke.");
            patience -= 10;
        }
        else if (guess == fakeBanana)
        {
            SlowPrint("\n'CORRECT! You have a keen eye for authentic bananas!'");
            SlowPrint("The fake banana is revealed to be made of yellow wax.");
            SlowPrint("'Only true banana enthusiasts can tell the difference!'");
            SlowPrint("The host awards you a 'Banana Authenticator' badge.");
            inventory.Add("Banana Authenticator Badge");
            bananaEnergy += 15;
            bananaTolerance += 1;
        }
        else
        {
            SlowPrint($"\n'WRONG! Number {fakeBanana} was the fake!'");
            SlowPrint("The fake banana suddenly melts into yellow goo.");
            SlowPrint("'Better luck next time, banana novice!'");

            if (bananaEnergy > 10)
            {
                bananaEnergy -= 10;
                SlowPrint("Your banana energy decreases from shame.");
            }
        }

        SlowPrint("The game show set folds into itself and disappears.");
        Thread.Sleep(2500);
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

        if (weirdnessMeter >= 75)
        {
            WeirdBananaChallenge();
        }
        else
        {
            NormalBananaChallenge();
        }
    }

    static void NormalBananaChallenge()
    {
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

        if (answeredCorrectly >= 2 || hasLuckyPenny || hasMysteriousToken || inventory.Contains("Golden Banana Hat") || bananaSecrets.Count >= 5)
        {
            SlowPrint("\n'YOU HAVE PROVEN YOURSELF WORTHY OF THE SACRED FRUIT!'", 50);

            if (answeredCorrectly < 3 && hasLuckyPenny)
            {
                SlowPrint("The lucky penny in your pocket vibrates and turns into banana dust.");
            }

            if (inventory.Contains("Golden Banana Hat"))
            {
                SlowPrint("Your golden banana hat glows with powerful banana energy!");
                SlowPrint("The Banana Guardian looks impressed. 'A HAT-BEARER! MOST RARE!'");
            }

            if (bananaSecrets.Count >= 5)
            {
                SlowPrint("The Banana Guardian seems to sense your banana knowledge.");
                SlowPrint("'YOUR UNDERSTANDING OF BANANA LORE IS... ACCEPTABLE.'");
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

    static void WeirdBananaChallenge()
    {
        SlowPrint("The Banana Guardian narrows its eyes at you. 'YOU ARE... DIFFERENT.'", 50);
        SlowPrint("'I SENSE THE WEIRDNESS OF THE BANANA REALM WITHIN YOU.'", 50);
        SlowPrint("'FOR YOU, A DIFFERENT TEST IS REQUIRED...'", 50);

        Thread.Sleep(1500);
        Console.Clear();

        SlowPrint("The world around you melts away. You find yourself in a strange yellow void.", 40);
        SlowPrint("Three giant, floating, talking bananas appear before you.", 40);
        Thread.Sleep(1000);

        SlowPrint("\nBANANA #1: 'I am the true banana.'");
        SlowPrint("BANANA #2: 'Only one of us is lying.'");
        SlowPrint("BANANA #3: 'The other two are lying.'");
        Thread.Sleep(1500);

        SlowPrint("\nThe Banana Guardian's voice echoes in the void:");
        SlowPrint("'WHICH IS THE TRUE BANANA? CHOOSE WISELY.'");

        Console.Write("\nWhich banana speaks the truth? (1/2/3): ");
        string choice = Console.ReadLine().Trim();

        Console.Clear();
        SlowPrint("The void swirls around you as the giant bananas consider your answer...", 40);
        Thread.Sleep(2000);

        if (choice == "1")
        {
            SlowPrint("BANANA #1 glows with golden light!");
            SlowPrint("'YOU HAVE SEEN THROUGH THE PARADOX,' the Banana Guardian announces.");
            SlowPrint("'TRULY, YOU UNDERSTAND THE BANANA ON A DEEPER LEVEL.'");

            if (hasSeenBananaVisions)
            {
                SlowPrint("'AND YOUR VISIONS HAVE PREPARED YOU FOR THIS MOMENT.'");
                inventory.Add("Essence of Banana Vision");
                bananaEnergy = 100;
            }
        }
        else
        {
            SlowPrint("All three bananas begin laughing in unison.");
            SlowPrint("'THERE IS NO CORRECT ANSWER,' the Banana Guardian explains.");
            SlowPrint("'BUT YOUR WILLINGNESS TO CHOOSE IN THE FACE OF PARADOX IS... ACCEPTABLE.'");
        }

        Thread.Sleep(1500);
        SlowPrint("\nThe yellow void dissolves, and you find yourself back in the real world.");
        SlowPrint("The Banana Guardian steps aside, revealing a pedestal with a glowing banana...");
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
            SlowPrint("ENDING 1/10: RETURN TO BANANA", 100);
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
            SlowPrint("ENDING 2/10: TEMPORAL BANANA LOOP", 100);
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
            SlowPrint("ENDING 3/10: BANANA ASCENSION", 100);
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
            SlowPrint("ENDING 4/10: THE BANANAVERSE", 100);
        }
        else if (bananaEnergy >= 90 && weirdnessMeter >= 70)
        {
            SlowPrint("As you touch the banana, your accumulated banana energy and weirdness resonate.", 40);
            Thread.Sleep(1000);
            SlowPrint("The banana begins to levitate and so do you. Energy crackles between you.", 40);
            Thread.Sleep(1000);
            SlowPrint("You merge with the banana, becoming a being of pure yellow energy.", 40);
            Thread.Sleep(1000);
            SlowPrint("'I AM BANANAMAN!' you announce to the shocked onlookers.", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 5/10: BANANA SUPERHERO", 100);
        }
        else if (bananaSecrets.Count >= 7)
        {
            SlowPrint("Your vast banana knowledge allows you to see the banana's true form.", 40);
            Thread.Sleep(1000);
            SlowPrint("It's not just a fruit, but a key to the secrets of the universe.", 40);
            Thread.Sleep(1000);
            SlowPrint("You take the banana and whisper all its secret names.", 40);
            Thread.Sleep(1000);
            SlowPrint("Reality shifts as you become the Keeper of Banana Wisdom.", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 6/10: BANANA ENLIGHTENMENT", 100);
        }
        else if (inventory.Contains("Tiny Banana Phone"))
        {
            SlowPrint("The banana begins ringing. You hold it to your ear in confusion.", 40);
            Thread.Sleep(1000);
            SlowPrint("'Congratulations on your employment with Banana Corp,' says a voice.", 40);
            Thread.Sleep(1000);
            SlowPrint("'Please report to banana headquarters for orientation.'", 40);
            Thread.Sleep(1000);
            SlowPrint("You're now an agent for a secret banana intelligence agency.", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 7/10: BANANA OPERATIVE", 100);
        }
        else if (inventory.Contains("Oracle's Banana Charm") && hasMetBananaOracle)
        {
            SlowPrint("The charm in your pocket begins to glow as you touch the banana.", 40);
            Thread.Sleep(1000);
            SlowPrint("The Banana Oracle appears, smiling. 'You have completed the circle.'", 40);
            Thread.Sleep(1000);
            SlowPrint("She takes your hand and the banana, joining them together.", 40);
            Thread.Sleep(1000);
            SlowPrint("'You are now the new Banana Oracle. Guide the seekers wisely.'", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 8/10: BANANA PROPHET", 100);
        }
        else if (wearingBananaHat)
        {
            SlowPrint("Your golden banana hat begins to shine brightly as you touch the banana.", 40);
            Thread.Sleep(1000);
            SlowPrint("The banana rises and fuses with your hat, creating a crown.", 40);
            Thread.Sleep(1000);
            SlowPrint("People in line bow before you, their new banana monarch.", 40);
            Thread.Sleep(1000);
            SlowPrint("'Long live the Banana Sovereign!' they chant as you ascend your fruity throne.", 40);
            Thread.Sleep(2000);
            Console.Clear();
            SlowPrint("ENDING 9/10: BANANA ROYALTY", 100);
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
            SlowPrint("ENDING 10/10: YOU HAVE OBTAINED THE CURSED BANANA", 100);
        }

        Thread.Sleep(3000);
        Console.WriteLine("\n\nPress any key to exit.");
        Console.ReadKey();
    }

    static void Main()
    {
        Console.Title = "Wait In Line For a Banana";
        Random random = new Random();

        Intro();

        int peopleInLine = random.Next(15, 45);
        SlowPrint($"you are in line. People ahead of you: {peopleInLine}");

        string message = peopleInLine >= 20 ?
            "The line is incredibly long. This might take forever..." :
            peopleInLine >= 13 ?
            "The line is pretty long..." :
            "Wow, the line is pretty short!";

        SlowPrint(message);
        SlowPrint("\nWaiting in line... weird things start to happen...\n");
        Thread.Sleep(3000);

        int eventCounter = 0;
        int majorEventThreshold = random.Next(5, 8);
        int miniGameCounter = random.Next(3, 6);

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
                miniGameCounter--;
                Console.Clear();

                List<string> allRandomEvents = new List<string>();
                allRandomEvents.AddRange(RandomEvents);
                allRandomEvents.AddRange(AdditionalEvents);
                allRandomEvents.AddRange(ExtraRandomEvents);

                string randomEvent = allRandomEvents[random.Next(allRandomEvents.Count)];

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
                else if (randomEvent.Contains("something yellow and glowing"))
                {
                    bananaEnergy += random.Next(5, 10);
                    SlowPrint("The glimpse of something special energizes you. Banana energy increases.");
                }
                else if (randomEvent.Contains("forget how to spell"))
                {
                    weirdnessMeter += random.Next(3, 8);
                    SlowPrint("The word 'banana' seems to lose all meaning. Weirdness increases.");
                }

                Thread.Sleep(2000);
            }

            if (miniGameCounter <= 0 && peopleInLine > 5)
            {
                string[] games = new string[]
                {
                    "Banana Counting Contest",
                    "Banana Riddles",
                    "Spot the Fake Banana"
                };
                string game = games[random.Next(games.Length)];

                MiniGames[game].Invoke();

                miniGameCounter = random.Next(5, 10);
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

            if (random.Next(100) < 5)
            {
                bananaEnergy -= random.Next(3, 8);
                SlowPrint("Standing in line is draining your banana energy.");
            }

            if (random.Next(100) < 7)
            {
                weirdnessMeter += random.Next(1, 5);
                SlowPrint("Things continue to get stranger. Your weirdness meter increases.");
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
                SlowPrint("As you leave, you hear soft laughter coming from the line.");
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
