string userInput;
bool run = true;

//keep the program from crashing (simple ver.)
try
{
    //keep the program running
    while (run)
    {
        //instructions and type of game selection
        Console.WriteLine("\n===Madlib===\nPlease select a type of Madlib:\nShort\nMedium\nLong.\nEnter Quit to quit.\n");
        userInput = Console.ReadLine().Trim().ToLower(); //read in the player's response, trim any extra space, lowercase it to decrease error ability
        Console.WriteLine("\n");

        //if the player decides to quit: 
        if (userInput == "quit") //find a way to let it quit at any point in the program
        {
            Console.WriteLine("\nHave a good day :)\n");
            run = false; //program ends
        }
        //otherwise the program will keep running like normal
        else
        {
            //if the player selects a short game
            if (userInput == "short")
            {
                //string options for the short game
                string color, pluralNoun, adjective, title, name; //saves space and time?
                //prompt the player for a response, record the response for that option
                Console.WriteLine("\nPlease enter a color:");
                color = Console.ReadLine();
                Console.WriteLine($"\nEnter a plural noun:");
                pluralNoun = Console.ReadLine();
                Console.WriteLine($"\nEnter an adjective:");
                adjective = Console.ReadLine();
                Console.WriteLine($"\nEnter a title (friend, dog, etc.):");
                title = Console.ReadLine();
                Console.WriteLine($"\nEnter a name:");
                name = Console.ReadLine();
                //print the finished story
                Console.WriteLine($"\nHere is your story:\nMy favorite color is {color}. My {pluralNoun} are {adjective}. My {title}'s name is {name}.");
            }//end of short game
            //if the player selects a medium game
            else if (userInput == "medium")
            {
                //string options for the medium game
                string monsterPlural1, monsterVerb, monster1, monsterDesc1, monsterAdjective, monsterDesc2, emotion, area, monsterPlural2, monsterPlural3, monsterPlace, personGroupPlural, groupAction1, groupAction2, holiday;
                //prompt the player for a response, record the response for that option
                Console.WriteLine("\nPlease enter a plural monster:");
                monsterPlural1 = Console.ReadLine();
                Console.WriteLine("\nPlease enter a verb:");
                monsterVerb = Console.ReadLine();
                Console.WriteLine("\nPlease enter a monster:");
                monster1 = Console.ReadLine();
                Console.WriteLine("\nPlease enter a noun:");
                monsterDesc1 = Console.ReadLine();
                Console.WriteLine("\nPlease enter an adjective:");
                monsterAdjective = Console.ReadLine();
                Console.WriteLine("\nPlease enter a noun:");
                monsterDesc2 = Console.ReadLine();
                Console.WriteLine("\nPlease enter an emotion:");
                emotion = Console.ReadLine();
                Console.WriteLine("\nPlease enter an area of land/water:");
                area = Console.ReadLine();
                Console.WriteLine("\nPlease enter a plural monster:");
                monsterPlural2 = Console.ReadLine();
                Console.WriteLine("\nPlease enter a plural monster:");
                monsterPlural3 = Console.ReadLine();
                Console.WriteLine("\nPlease enter a place:");
                monsterPlace = Console.ReadLine();
                Console.WriteLine("\nPlease enter a group of things:");
                personGroupPlural = Console.ReadLine();
                Console.WriteLine("\nPlease enter an activity:");
                groupAction1 = Console.ReadLine();
                Console.WriteLine("\nPlease enter an activity:");
                groupAction2 = Console.ReadLine();
                Console.WriteLine("\nPlease enter a holiday:");
                holiday = Console.ReadLine();
                //print the finished story
                Console.WriteLine($"\nHere is your story:\nTonight is the night when all of the {monsterPlural1} come out to {monsterVerb}.\n{monster1} with big {monsterDesc1} and {monsterAdjective} {monsterDesc2} cause {emotion} across the {area}. \n{monsterPlural2} and {monsterPlural3} sometimes haunt the {monsterPlace}.\n{personGroupPlural} like to {groupAction1} and {groupAction2} all night.\nHappy {holiday}!");
            }//end of medium game
            //if a player selects a long game
            else if (userInput == "long")
            {
                //string options for the short game
                string friendName, time, activity, product, teacherName, creature, food, verb, timeAmount, pattern, clothes, noun, sauce, phrase, silverware, number, adjective, classNoun, properNoun1, properNoun2, pluralNoun1, gymVerb, pluralNoun2, ideaAdjective, adverb;
                //prompt the player for a response, record the response for that option
                Console.WriteLine($"\nEnter a name:");
                friendName = Console.ReadLine();
                Console.WriteLine($"\nEnter a time (1 am, 2 pm, etc):");
                time = Console.ReadLine();
                Console.WriteLine($"\nEnter an activity:");
                activity = Console.ReadLine();
                Console.WriteLine($"\nEnter a product:");
                product = Console.ReadLine();
                Console.WriteLine($"\nEnter another name:");
                teacherName = Console.ReadLine();
                Console.WriteLine($"\nEnter a creature/animal:");
                creature = Console.ReadLine();
                Console.WriteLine($"\nEnter a food:");
                food = Console.ReadLine();
                Console.WriteLine($"\nEnter a verb:");
                verb = Console.ReadLine();
                Console.WriteLine($"\nEnter a time (hour, second, minute, etc):");
                timeAmount = Console.ReadLine();
                Console.WriteLine($"\nEnter a pattern/color:");
                pattern = Console.ReadLine();
                Console.WriteLine($"\nEnter a type of clothing:");
                clothes = Console.ReadLine();
                Console.WriteLine($"\nEnter a noun:");
                noun = Console.ReadLine();
                Console.WriteLine($"\nEnter a souce:");
                sauce = Console.ReadLine();
                Console.WriteLine($"\nEnter a phrase:");
                phrase = Console.ReadLine();
                Console.WriteLine($"\nEnter a type of silverware:");
                silverware = Console.ReadLine();
                Console.WriteLine($"\nEnter a number:");
                number = Console.ReadLine();
                Console.WriteLine($"\nEnter an adjective:");
                adjective = Console.ReadLine();
                Console.WriteLine($"\nEnter a noun:");
                classNoun = Console.ReadLine();
                Console.WriteLine($"\nEnter a name:");
                properNoun1 = Console.ReadLine();
                Console.WriteLine($"\nEnter a name:");
                properNoun2 = Console.ReadLine();
                Console.WriteLine($"\nEnter a plural noun:");
                pluralNoun1 = Console.ReadLine();
                Console.WriteLine($"\nEnter a verb:");
                gymVerb = Console.ReadLine();
                Console.WriteLine($"\nEnter a plural noun:");
                pluralNoun2 = Console.ReadLine();
                Console.WriteLine($"\nEnter an adjective:");
                ideaAdjective = Console.ReadLine();
                Console.WriteLine($"\nEnter an adverb:");
                adverb = Console.ReadLine();

                //print the finished story
                Console.WriteLine($"\nHere is your story:\nOne beautiful summer morning {friendName} woke me up at {time}. \nIt was just near the end of the summer and I was trying to catch up on my {activity}. \n{friendName} said “Wake up {product}! It’s the first day of school! Let’s get going because my new teacher, {teacherName}, is really a {creature}. \nI can’t wait to throw {food} at her. I hear she can’t resist {verb}ing it with her teeth!” \nI groaned for {timeAmount}, but eventually, I woke and started getting dressed. \nI wore a {pattern} {clothes} with a very long {noun} attached to it. My shoes rocked hard! \nThey were covered in {sauce} from the night before. I flipped over the shoe and yelled “{phrase}!” \nI grabbed a {silverware} and had breakfast off of my shoes! \n\n{number} hours later, the bus came, and in a few minutes I was already at school. In school, I met two really {adjective} kids. \nAll of us became friends very fast. That day we had science, and luckily my friends and I were at the same {classNoun}. \nMy friends' names are {properNoun1} and {properNoun2}. At math, we weren't together, and that really bugged me. \nWe learned what {pluralNoun1} were, and when to use them. At snack and recess, we played 'Three - Square' together. \nIt was extremely fun. At P.E., we were {gymVerb} off of the ropes onto {pluralNoun2}. I thought it was a very {ideaAdjective} idea. In swimming class, we needed to swim extremely {adverb}, or else...we would get tortured. An hour went by and I gathered all my stuff and threw it in my back pack. The bus came screeching into the parking lot. Just before I got onto the bus, like a bull horn; I shouted, \"Goodbye, adios amigos, sayonara, and shalom,\" to my friends. In a flash the bus raced us home and the day had concluded! What a great day! ");
            }//end of long game
            //make sure the player can only select the given options
            else
            {
                Console.WriteLine("Please select one of the options listed.");
            }
        }//end of game
    }//end of loop
}
//catch general exceptions
catch (Exception)
{
    Console.WriteLine("Something went wrong. Please try again.");
}