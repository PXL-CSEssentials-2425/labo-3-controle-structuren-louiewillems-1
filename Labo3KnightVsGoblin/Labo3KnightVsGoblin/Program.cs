/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

using System.Diagnostics;

Console.WriteLine("Welcome dear player!!");


Random randomGenarator = new Random();
int knightHealth = 100; // eerste getal wordt meegeteld, laatste nummer niet
int goblinHealth = randomGenarator.Next(1, 101);


Console.Write("Enter the health for the knight(1-100): ");
string healthStr = Console.ReadLine();
bool isValidInput = int.TryParse(healthStr, out int healthInput);

int healKnight = 10;
int attackKnight = 10;
int attackGoblin = 5;

if ((isValidInput))
{
    if (healthInput > 0 && healthInput <= 100)
    {
        Console.WriteLine($"Incorrect input: Knight healt must be between 0 and 100. Default value 100 is used.");
        //knightHealth = 100;
    }
}
else
{
    Console.WriteLine($"Incorrect input, default value 100 is used.");
    //knightHealth = 100;
}

//GAME START

Console.WriteLine($"Knight health: {knightHealth}");
Console.WriteLine($"Goblin health: {goblinHealth}");
Console.WriteLine();

do
{
    Console.WriteLine("Available actions");
    Console.WriteLine("1 = Attack");
    Console.WriteLine("2 = Heal");
    Console.Write("Choose an action: ");
    string? action = Console.ReadLine();

    switch (action)
    {
        case "1":
            //attack
            goblinHealth -= attackKnight;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Knight attacked goblin!  Goblin health: {goblinHealth}");
            Console.ResetColor();
            break;
        case "2":
            //heal
            knightHealth += healKnight;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Knight heals himself! Knight health: {knightHealth}");
            Console.ResetColor();
            break;
        default:
            Console.WriteLine("This is not a valid action.");
            break;
    }

    // goblin attack
    if (goblinHealth > 0)
    {
        knightHealth -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Goblin attacked back! Knight health: {knightHealth}");
        Console.ResetColor();
    }


    if (knightHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("YOU LOOSE!! Knight died!");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"Knight: {knightHealth}");
    }

    if (goblinHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("YOU WIN!! The goblin died!");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"Goblin: {goblinHealth}");
    }
    Console.WriteLine();

} while (goblinHealth > 0 && knightHealth > 0);




/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
