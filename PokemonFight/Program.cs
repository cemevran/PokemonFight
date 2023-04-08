Console.WriteLine(@"POKEMON FIGHT!!!
                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|


Enter the name of first Pokemon:");
string pokemon1 = Console.ReadLine();
Console.WriteLine("Enter the second pokemon: ");
string pokemon2 = Console.ReadLine();

int j = 1;

int hp1 = 100;
int hp2 = 100;

int dmg1 = 0;
int dmg2 = 0;

int dmg1Temp = 0;
int dmg2Temp = 0;

Random rng = new Random();

while (hp1 > 0 && hp2 > 0)
{
    Console.WriteLine("\n-------------------ROUND " + j + "-------------------\n");
    #region Pokemon 1 Attack Type Selection
    Console.WriteLine("Choose the attack type for " + pokemon1 + @"
    a) Razor Leaves
    b) Multi Attack");
    string attackType1 = Console.ReadLine();
    dmg1Temp = 0;
    if (attackType1 == "a")
    {
        dmg1 = rng.Next(1, 20);
        hp2 -= dmg1;
        Thread.Sleep(1000);
        Console.WriteLine("\n" + pokemon1 + " threw razor blades to " + pokemon2 + " and dealt " + dmg1 + " damage!\n");
        Console.WriteLine("Remainig HPs\n\n" + pokemon1 + ": " + hp1 + "hp\n" + pokemon2 + ": " + hp2 + "hp\n");
        if (hp2 < 0)
            break;
    }
    else if (attackType1 == "b")
    {
        for (int i = 0; i < 3; i++)
        {
            dmg1 = rng.Next(1, 20);
            hp2 -= dmg1;
            dmg1Temp += dmg1;
        }
        Thread.Sleep(1000);
        Console.WriteLine("\n" + pokemon1 + " attacked multiple times to " + pokemon2 + " and dealt " + dmg1Temp + " damage!\n");
        Console.WriteLine("Remainig HPs\n\n" + pokemon1 + ": " + hp1 + "hp\n" + pokemon2 + ": " + hp2 + "hp\n");
        if (hp2 < 0)
        {
            hp2 = 0;
            break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid entry, try again!");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    #endregion

    #region Pokemon 2 Attack Type Selection
    Console.WriteLine("Choose the attack type for " + pokemon2 + @"
    a) Electricity Shockwave
    b) Multi Attack");
    string attackType2 = Console.ReadLine();
    dmg2Temp = 0;
    if (attackType2 == "a")
    {
        dmg2 = rng.Next(1, 20);
        hp1 -= dmg2;
        Thread.Sleep(1000);
        Console.WriteLine("\n" + pokemon2 + " electroshocked " + pokemon1 + " and dealt " + dmg2 + " damage!\n");
        Console.WriteLine("Remainig HPs\n\n" + pokemon1 + ": " + hp1 + "hp\n" + pokemon2 + ": " + hp2 + "hp\n");
        if (hp1 < 0)
        {
            hp1 = 0;
            break;
        }
    }
    else if (attackType2 == "b")
    {
        for (int i = 0; i < 3; i++)
        {
            dmg2 = rng.Next(1, 20);
            hp1 -= dmg2;
            dmg2Temp += dmg2;
        }
        Thread.Sleep(1000);
        Console.WriteLine("\n" + pokemon2 + " electroshocked " + pokemon1 + " and dealt " + dmg2Temp + " damage!\n");
        Console.WriteLine("Remainig HPs\n\n" + pokemon1 + ": " + hp1 + "hp\n" + pokemon2 + ": " + hp2 + "hp\n");
        if (hp1 < 0)
            break;
    }
    else
    {
        if (attackType1 == "a")
            hp2 += dmg1;
        else if (attackType1 == "b")
            hp2 += dmg1Temp;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid entry, try again!");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    j++;
    #endregion
}
#region Deciding Winner
if (hp1 > hp2)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(pokemon1 + " has won the battle!!!");
    Console.WriteLine(@"
                                           /
                        _,.------....___,.' ',.-.
                     ,-'          _,.--""        |
                   ,'         _.-'              .
                  /   ,     ,'                   `
                 .   /     /                     ``.
                 |  |     .                       \.\
       ____      |___._.  |       __               \ `.
     .'    `---""""       ``""-.--""'`  \               .  \
    .  ,            __               `              |   .
    `,'         ,-""'  .               \             |    L
   ,'          '    _.'                -._          /    |
  ,`-.    ,"".   `--'                      >.      ,'     |
 . .'\'   `-'       __    ,  ,-.         /  `.__.-      ,'
 ||:, .           ,'  ;  /  / \ `        `.    .      .'/
 j|:D  \          `--'  ' ,'_  . .         `.__, \   , /
/ L:_  |                 .  ""' :_;                `.'.'
.    """"'                  """"""""""'                    V
 `.                                 .    `.   _,..  `
   `,_   .    .                _,-'/    .. `,'   __  `
    ) \`._        ___....----""'  ,'   .'  \ |   '  \  .
   /   `. ""`-.--""'         _,' ,'     `---' |    `./  |
  .   _  `""""'--.._____..--""   ,             '         |
  | ."" `. `-.                /-.           /          ,
  | `._.'    `,_            ;  /         ,'          .
 .'          /| `-.        . ,'         ,           ,
 '-.__ __ _,','    '`-..___;-...__   ,.'\ ____.___.'
 `""^--'..'   '-`-^-'""--    `-^-'`.''""""""""""`.,^.`.--' mh");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(pokemon2 + " has won the battle!!!");
    Console.WriteLine(@"
`;-.          ___,
  `.`\_...._/`.-""`
    \        /      ,
    /()   () \    .' `-._
   |)  .    ()\  /   _.'
   \  -'-     ,; '. <
    ;.__     ,;|   > \
   / ,    / ,  |.-'.-'
  (_/    (_/ ,;|.<`
    \    ,     ;-`
     >   \    /
    (_,-'`> .'
         (_,");
    Console.ForegroundColor = ConsoleColor.White;
}
#endregion