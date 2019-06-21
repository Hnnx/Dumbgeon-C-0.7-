using System;

public class DG
{
    public static void Main()
    {
        Console.WriteLine("Dumbgeon c# version");


        enterLevel();   


    }

    public static void enterLevel()
    {

        //random Hero Generator
        Random rhg = new Random();
        int randomHeroGen = rhg.Next(2, 8);

        //Number Of Enemies
        int enemyNum = rhg.Next(2, 5);

        //Levels
        string[] ranLevel = {"of the fallen souls","that kinda stinks ","of 'that guy'","Moonshine","of soviet conspiracy","with extra cheese","of brown beans",
                "<DLC_AREA_2> DEAR USER PLEASE UPGRADE TO PREMIUM ACCOUNT","abandoned Sears building with Vaporwave music faintly playing in the background","broken elevators (there's plenty of stairs though)",
                "... wait this is just a DVD rental store, nevermind"};
        int ranLevelNum = rhg.Next(0, ranLevel.Length - 1);

        //Enemizz
        string[] ranEnemy = {"skeletons", "bloated rats","fat chipmunks","one eyed donkeys","construction workers","lawyers","used car salesmen","Trip-Hop artists from downtown LA",
                "evil dark lords... FROM POLAND. Yeah, don't ask","members of the German \"Junge Wurst\" Quartet","cats on horse. The drug, not the animal.",
                "Scarecrows. Just scarecrows","Pro Life activists"};
        int ranEnemyNum = rhg.Next(0, ranEnemy.Length - 1);

        //Enemiz State
        string[] ranEnemyState = {"in shock ", "just chilling","confused?","listening to the latest Weezer album","reading Jane Austin","working on UNI","debunking alien myths","getting yelled at by the drunk uncle",
                "snoring oh God it's so loud make it STOP SOMEONE","calling child protection services","from the IRA and those YouTube monetization earnings are looking very suspicious"};
        int ranEnemyStateNum = rhg.Next(0, ranEnemyState.Length - 1);

        Console.WriteLine("\n Now entering the dungeon " + ranLevel[ranLevelNum]);
        Console.WriteLine("***HNRHG*** spots " + enemyNum + " " + ranEnemy[ranEnemyNum] + ", they are "
                         + ranEnemyState[ranEnemyStateNum]);


    }

}