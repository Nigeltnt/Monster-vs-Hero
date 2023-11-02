// See https://aka.ms/new-console-template for more information
using System;

int heroHealth = 10;
int monsterHealth = 10;


Random dice = new Random();

//this is another way of coming up with the same functionality

/*do
{
    int heroRoll = dice.Next(1, 11);
    monsterHealth = monsterHealth - heroRoll;
    Console.WriteLine($"Monster damaged and lost {heroRoll} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    int monsterRoll = dice.Next(1, 11);
    heroHealth = heroHealth - monsterRoll;
    Console.WriteLine($"Hero damaged and lost {monsterRoll} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");*/


while (heroHealth > 0 && monsterHealth > 0)
{
    int heroRoll = dice.Next(1, 11);
    monsterHealth = monsterHealth - heroRoll;
    Console.WriteLine($"Monster damaged and lost {heroRoll} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    int monsterRoll = dice.Next(1, 11);
    heroHealth = heroHealth - monsterRoll;
    Console.WriteLine($"Hero damaged and lost {monsterRoll} health and now has {heroHealth} health.");
}
Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");