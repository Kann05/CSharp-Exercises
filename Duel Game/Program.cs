public class Luna
{
    public string name;
    public double health;
    public double damage;
    public double ultimateDamage;

    public bool UltimateUsed = false;

    public string element;
    
    public Luna()
    {
        name = "Luna";
        health = 200;
        damage = 50;
        ultimateDamage = damage + 15; 
        element = "electricity";
    }
}
public class Drake
{
    public string name;
    public double health;
    public double damage;
    public double ultimateDamage;
    public string element;
    public bool UltimateUsed = false;
    
    public Drake()
    {
        name = "Drake";
        health = 400;
        damage = 22;
        ultimateDamage = damage + 10; 
        element = "fire";
    }
}
public class Aurora
{
    public string name;
    public double health;
    public double damage;
    public double ultimateDamage;
    public string element;
    public bool UltimateUsed = false;
    
    public Aurora()
    {
        name = "Aurora";
        health = 150;
        damage = 60;
        ultimateDamage = damage + 30; 
        element = "water";
    }
}
public class Rook
{
    public string name;
    public double health;
    public double damage;
    public double ultimateDamage;
    public string element;
    public bool UltimateUsed = false;
    
    public Rook()
    {
        name = "Rook";
        health = 350;
        damage = 30;
        ultimateDamage = damage + 10; 
        element = "ground";
    }
}
public class Vega
{
    public string name;
    public double health;
    public double damage;
    public double ultimateDamage;
    public string element;
    public bool UltimateUsed = false;
    
    public Vega()
    {
        name = "Vega";
        health = 120;
        damage = 40;
        ultimateDamage = damage + 55; 
        element = "air";
    }
}
public class Atlas
{
    public string name;
    public double health;
    public double damage;
    public double ultimateDamage;
    public string element;
    public bool UltimateUsed = false;
    
    public Atlas()
    {
       name = "Atlas";
        health = 220;
        damage = 30;
        ultimateDamage = damage + 20; 
        element = "ice";
    }
}

public class Display{

    public void UI()
    {
        Dictionary<string, Type> heroChoose = new Dictionary<string, Type>
        {
            { "1", typeof(Luna) },
            { "2", typeof(Drake) },
            { "3", typeof(Aurora) },
            { "4", typeof(Rook) },
            { "5", typeof(Vega) },
            { "6", typeof(Atlas) }
        };
//--------------------------------------------SELECT PLAYER 1-------------------------------------------------------------//
        Console.WriteLine("Select hero for Player 1:");
        Console.WriteLine("1. Luna");
        Console.WriteLine("2. Drake");
        Console.WriteLine("3. Aurora");
        Console.WriteLine("4. Rook");
        Console.WriteLine("5. Vega");
        Console.WriteLine("6. Atlas");

        string player1ChampionInput = Console.ReadLine();

//--------------------------------------------SELECT PLAYER 2-------------------------------------------------------------//
        System.Console.WriteLine("Select hero for Player 2:");
        Console.WriteLine("1. Luna");
        Console.WriteLine("2. Drake");
        Console.WriteLine("3. Aurora");
        Console.WriteLine("4. Rook");
        Console.WriteLine("5. Vega");
        Console.WriteLine("6. Atlas");

        string player2ChampionInput = Console.ReadLine();
        if (heroChoose.ContainsKey(player1ChampionInput) && heroChoose.ContainsKey(player2ChampionInput))
        {
            Type heroTypePlayer1 = heroChoose[player1ChampionInput];
            Type heroTypePlayer2 = heroChoose[player2ChampionInput];
            object hero1 = Activator.CreateInstance(heroTypePlayer1);
            object hero2 = Activator.CreateInstance(heroTypePlayer2);

            dynamic player1Hero = Convert.ChangeType(hero1, heroTypePlayer1);
            dynamic player2Hero = Convert.ChangeType(hero2, heroTypePlayer2);

            System.Console.WriteLine();
            System.Console.WriteLine($"Player 1 Statistics -> Name: {player1Hero.name} | Health: {player1Hero.health} | Damage: {player1Hero.damage} | UltimateDamage: {player1Hero.ultimateDamage} | Element: {player1Hero.element}");
            System.Console.WriteLine($"Player 2 Statistics -> Name: {player2Hero.name} | Health: {player2Hero.health} | Damage: {player2Hero.damage} | UltimateDamage: {player2Hero.ultimateDamage} | Element: {player2Hero.element}");
            System.Console.WriteLine();
            System.Console.WriteLine("Ultimate CAN BE USED ONLY ONCE !!!");
            System.Console.WriteLine();
            System.Console.WriteLine("Press ENTER to start the Match");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("TOURNAMENT STARTED");
            System.Console.WriteLine();
            System.Console.WriteLine($"{player1Hero.name} vs {player2Hero.name}");
            System.Console.WriteLine();
            System.Console.WriteLine("ROUND 1 FIGHT !");
            System.Console.WriteLine();

//---------------------------------------- Round 1 --------------------------------------------------------------------//
//--------------------------------------------- PLAYER 1 MOVE -------------------------------------------------------------------//

            while (player1Hero.health > 0 && player2Hero.health > 0)
            {
                System.Console.WriteLine($"{player1Hero.name} Move: Attack/Defense/Ultimate");
                string player1SecondMove = Console.ReadLine().ToLower();

                System.Console.WriteLine($"{player2Hero.name} Move: Attack/Defense/Ultimate");
                string player2SecondMove = Console.ReadLine().ToLower();
                System.Console.WriteLine();

                if (player1SecondMove == "attack")
                {
                    if (player2SecondMove == "defense"){
                        System.Console.WriteLine($"{player2Hero.name} blocked your attack !");
                    }
                    if (player2SecondMove != "defense"){
                        System.Console.WriteLine($"{player1Hero.name} did {player1Hero.damage} damage to {player2Hero.name}");
                        player2Hero.health -= player1Hero.damage;
                        System.Console.WriteLine($"{player2Hero.name} health = {player2Hero.health}");
                        System.Console.WriteLine();

                        if (player2Hero.health <= 0){
                            System.Console.WriteLine($"GAME OVER !");
                            System.Console.WriteLine($"{player1Hero.name} WIN !!!");
                            break;
                        }
                    }
                    
                }
                if (player1SecondMove == "defense"){
                    System.Console.WriteLine($"{player1Hero.name} is using defense");
                }

                if(player1SecondMove == "ultimate")
                {
                    if (player2SecondMove == "defense"){
                        System.Console.WriteLine($"{player1Hero.name} blocked your attack !");
                    }
                    if (player2SecondMove != "defense" && player1Hero.UltimateUsed == false){
                        System.Console.WriteLine($"{player1Hero.name} did {player1Hero.ultimateDamage} damage to {player2Hero.name}");
                        player2Hero.health -= player1Hero.ultimateDamage;
                        System.Console.WriteLine($"{player2Hero.name} health = {player2Hero.health}");
                        System.Console.WriteLine();
                    }
                    if (player2SecondMove != "defense" && player1Hero.UltimateUsed == true){
                        System.Console.WriteLine($"{player1Hero.name} did {player1Hero.damage} damage to {player2Hero.name}");
                        player2Hero.health -= player1Hero.damage;
                        System.Console.WriteLine($"{player2Hero.name} health = {player2Hero.health}");
                        System.Console.WriteLine();

                        if (player2Hero.health <= 0){
                            System.Console.WriteLine($"GAME OVER !");
                            System.Console.WriteLine($"{player1Hero.name} WIN !!!");
                            break;
                        }
                    }
                }
    //--------------------------------------------- PLAYER 2 MOVE -------------------------------------------------------------------//
                if (player2SecondMove == "attack")
                {
                    if (player1SecondMove == "defense"){
                        System.Console.WriteLine($"{player1Hero.name} blocked your attack !");
                    }
                    if (player1SecondMove != "defense"){
                        System.Console.WriteLine($"{player2Hero.name} did {player2Hero.damage} damage to {player1Hero.name}");
                        player1Hero.health -= player2Hero.damage;
                        System.Console.WriteLine($"{player1Hero.name} health = {player1Hero.health}");
                        System.Console.WriteLine();

                        if (player1Hero.health <= 0){
                            System.Console.WriteLine($"GAME OVER !");
                            System.Console.WriteLine($"{player2Hero.name} WIN !!!");
                            break;
                        }
                    }
                    
                }
                if (player2SecondMove == "defense"){
                    System.Console.WriteLine($"{player2Hero.name} is using defense");
                }

                if(player2SecondMove == "ultimate")
                {
                    if (player1SecondMove == "defense"){
                        System.Console.WriteLine($"{player1Hero.name} blocked your attack !");
                    }
                    if (player1SecondMove != "defense" && player2Hero.UltimateUsed == false){
                        System.Console.WriteLine($"{player2Hero.name} did {player2Hero.ultimateDamage} damage to {player1Hero.name}");
                        player1Hero.health -= player2Hero.ultimateDamage;
                        System.Console.WriteLine($"{player1Hero.name} health = {player1Hero.health}");
                        System.Console.WriteLine();
                    }
                    if (player1SecondMove != "defense" && player2Hero.UltimateUsed == true){
                        System.Console.WriteLine($"{player2Hero.name} did {player2Hero.damage} damage to {player1Hero.name}");
                        player1Hero.health -= player2Hero.damage;
                        System.Console.WriteLine($"{player1Hero.name} health = {player1Hero.health}");
                        System.Console.WriteLine();
                        
                        if (player1Hero.health <= 0){
                            System.Console.WriteLine($"GAME OVER !");
                            System.Console.WriteLine($"{player2Hero.name} WIN !!!");
                            break;
                        }
                    }
                }
                if (player1SecondMove == "ultimate"){
                    player1Hero.UltimateUsed = true;
                }
                if (player2SecondMove == "ultimate"){
                    player2Hero.UltimateUsed = true;
                }
            }
        }
    }
}
class Program
{
    public static void Main()
    {
        Display display = new Display();

        display.UI();
    }
}