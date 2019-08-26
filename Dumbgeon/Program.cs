using System;

public class DG
{
	static string[] hN = new string[3];
	public static void Main()
	{
		Console.WriteLine("Dumbgeon c# version");
	  
		//Prompt user for name
		hN[0] = retrieveName(0);
		hN[1] = retrieveName(1);
		hN[2] = retrieveName(2);

		//ease of use handles
		String knigName = hN[0];
		String magName = hN[1];
		String archName = hN[2];

		//Retrieve hero HP
		int knightHP = retrieveHP(0);
		int mageHP = retrieveHP(1);
		int archHP = retrieveHP(2);

		//Level/Hero
		String heroChoice;
		String levelChoice;

		//ENCOUNTER CHECK
		bool encounter = true;
		bool progress = false;
		bool lvlchoice = true;

		/*
		//Names prompt DEV TEST
		hN[0] = "a"	;	
		hN[1] = "b";				
		hN[2] = "c";
		*/

		//Death
		String cod = causeOfDeath();



		//Encounter 1
		while (encounter)
		{
			try
			{
				Console.WriteLine("\nRemember, you can use Knight, Mage or Archer to choose the unfortunate fool");
				heroChoice = Console.ReadLine();

				if( heroChoice == "Mage" || heroChoice == "M" || heroChoice == "m" || heroChoice == "mage")
				{
					Console.WriteLine(magName + " threw fireballs and hit the enemies. And a few walls. Mostly walls though. #JusticeForWalls");
					encounter = false;
					lvlchoice = true;
				}
				else if (heroChoice == "Archer" || heroChoice == "A" || heroChoice == "a" || heroChoice == "archer")
				{
					archHP--;
					Console.WriteLine(archName + " hit the enemy but they appear immune, lost 1 hp - current HP: "+ archHP);

					if(archHP == 0)
					{
						Console.WriteLine(archName+ " died, "+cod);
						Console.WriteLine("\nYou never left the dungeon");
						progress = false;
						lvlchoice = false;
						encounter = false;
						break;
					}
				}
				else if (heroChoice == "Knight" || heroChoice == "K" || heroChoice == "k" || heroChoice == "knight")
				{
					knightHP--;
					Console.WriteLine(knigName + " tried doing a plunging attack which resulted in a high medical bill. " + knigName + " lost 1 hp - current HP: " + knightHP);

					if(knightHP == 0)
					{
						Console.WriteLine(knigName + " Died, "+cod);
						Console.WriteLine("\nYou never left the dungeon");
						encounter = false;
						progress = false;
						lvlchoice = false;
						break;
					}
				}
				else
				{
					encounter = true;
					Console.WriteLine("Error! Pick a hero");
				}


			}
			catch(Exception)
			{
				Console.WriteLine("Runtime Error!");
				encounter = true;
			}
		}

		//Level Choice 1
		while (lvlchoice)
		{
			try
			{
				Console.WriteLine("Descend to lower floor? Y/N");
				levelChoice = Console.ReadLine();
				if(levelChoice == "Y" || levelChoice == "y")
				{
					Console.WriteLine("\nEntering floor 2...");
					progress = true;
					lvlchoice = false;
					encounter = true;
				}
				else if(levelChoice == "N" || levelChoice == "n")
				{
					Console.WriteLine("You acquired the following loot");
					setLoot(2); 
					Console.WriteLine("GAME OVER - YOU SURVIVED AND REACHED FLOOR 2");
					lvlchoice = false;
					break;
				}
				else
				{
					Console.WriteLine("Select Yes or No");
					progress = false;
					lvlchoice = true;
				}
			}
			catch(Exception)
			{
				Console.WriteLine("Error!");
				progress = false;
				lvlchoice = true;
			}
		}

		//Encounter 2
		if (progress)
		{
			enterLevel();
		}

		while (encounter)
		{
			try
			{
				Console.WriteLine("\nOk this looks bad, who should attack next?");
				heroChoice = Console.ReadLine();

				if ( heroChoice == "M" || heroChoice == "m" || heroChoice == "Mage" || heroChoice == "mage")
				{
					mageHP--;
					Console.WriteLine(magName + " got ran over by a bus. " + magName+" loses 1 hp, current HP: "+ mageHP );

					if(mageHP == 0)
					{
						Console.WriteLine(magName+ " died, "+cod);
						Console.WriteLine("\nYou never left the dungeon");
						lvlchoice = false;
						progress = false;
						encounter = false;
						break;
					}
				}
				else if(heroChoice == "A" || heroChoice == "a" || heroChoice == "Archer" || heroChoice == "archer")
				{
					Console.WriteLine(archName + " lands a clean shot right in the foot. It deals abysmall damage but fortunately for our team, the arrow incapacitated the enemy\n");
					encounter = false;
					lvlchoice = true;
				}
				else if (heroChoice == "K" || heroChoice == "k" || heroChoice == "Knight" || heroChoice == "knight")
				{
					knightHP--;
					Console.WriteLine("Karen took the kids. " + knigName + " begs her to stay but the lawyer made things very clear, he can see them twice a month on weekends. Lost 1 hp due to minor gardening injury  - current HP: " + knightHP);

					if(knightHP == 0)
					{
						Console.WriteLine(knigName + " died, "+cod);
						Console.WriteLine("\nYou never left the dungeon");
						progress = false;
						lvlchoice = false;
						encounter = false;
						break;
					}
				}
				else
				{
					encounter = true;
					Console.WriteLine("Select a hero");
				}

			}
			catch
			{
				Console.WriteLine("Runtime Error!");
				encounter = true;

			}
		}

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

		int ranHero = rhg.Next(0, 3);

		Console.WriteLine("\n Now entering the dungeon " + ranLevel[ranLevelNum]);
		Console.WriteLine(hN[ranHero] + " spots " + enemyNum + " " + ranEnemy[ranEnemyNum] + ", they are "
						 + ranEnemyState[ranEnemyStateNum]);
	}

	public static string retrieveName(int rotate)
	{
		bool checkName = true;
		string heroName = "";

		while (checkName)
		{
			if (rotate == 0)
			{
				Console.WriteLine("Knight: ");
			}
			else if (rotate == 1)
			{
				Console.WriteLine("Mage");
			}
			else
			{
				Console.WriteLine("Archer");
			}
			try
			{
				heroName = Console.ReadLine();
				checkName = false;
			}
			catch (Exception)
			{
				Console.WriteLine("Encountered error, type a name(text)");
				checkName = true;
			}
		}
		return heroName;
	}

	public static int retrieveHP(int heroPostion)
	{
		Random rnd = new Random();

		int[] hp = new int[3];
		//Health = base + rdm		
		int r1 = rnd.Next(3, 6);
		int r2 = rnd.Next(3, 6);
		int r3 = rnd.Next(3, 6);


		hp[0] = r1;
		hp[1] = r2;
		hp[2] = r3;

		if (heroPostion == 0)
		{
			return hp[0];
		}
		else if (heroPostion == 1)
		{
			return hp[1];
		}
		else
		{
			return hp[2];
		}

	}

	public static string getLoot(int l)
	{

		string[] loot1 = { "plastic fork", "cat", "sandal", "perfume", "keys", "money", "white out", "soap"};
		string[] loot2 = { "cell phone", "rubber duck", "sailboat", "playing card", "hair brush", "USB drive", "lip gloss", "credit card", "shawl", "bow" };
		string[] loot3 = { "purse", "deodorant", "plate", "food", "wallet", "drill press", "bookmark", "towel", "piano", "cork" };
		string[] loot4 = { "caviar", "pretzels", "quiche", "granola", "clam", "pepper", "paella", "relish", "sardines", "gatorade" };
		string[] loot5 = { "toothbrush", "photo album", "flag", "USB drive", "screw", "stockings", "nail file", "sidewalk", "bracelet", "bread" };
		string[] loot6 = { "cup", "buckel", "white out", "tooth picks", "glass", "thread", "chair", "clay pot", "playing card", "credit card" };
		string[] loot7 = { "toilet", "knife", "rusty nail", "twezzers", "car", "nail clippers", "lace", "chocolate", "canvas", "sand paper" };
		string[] loot8 = { "packing peanuts", "apple", "conditioner", "controller", "eye liner", "bananas", "sand paper", "outlet", "sofa", "keys" };
		string[] loot9 = { "archerfish", "leveret", "linnet", "crane", "smelt", "pigeon", "polarbear", "lizard", "hog", "porcupine" };
		string[] loot10 = { "limb", "nodule", "tissue", "plantar", "navel", "carpal", "rearend", "eyeballs", "palm", "ligament" };


		if (l == 1)
		{
			return loot1[l];
		}
		else if (l == 2)
		{
			return loot2[l];
		}
		else if (l == 3)
		{
			return loot3[l];
		}
		else if (l == 4)
		{
			return loot4[l];
		}
		else if (l == 5)
		{
			return loot5[l];
		}
		else if (l == 6)
		{
			return loot6[l];
		}
		else if (l == 7)
		{
			return loot7[l];
		}
		else if (l == 8)
		{
			return loot8[l];
		}
		else if (l == 9)
		{
			return loot9[l];
		}
		else
		{
			return loot10[l];
		}

	}

	static public void setLoot(int lootNum)
	{

		for (int x = 1; x < lootNum; x++)
		{
			getLoot(x);
			Console.WriteLine(getLoot(x));
		}

	}

	static public string causeOfDeath()
	{
		Random rnd = new Random();

		string[] cod = {
				"cause of death was a peculiar incident involving a box of tissues and a wine glass."
				,"cause of death was a peculiar incident involving a multitool and a piano."
				,"death was caused by an aneurysm.","death was caused by sharp force trauma to the chest."
				,"cause of death was blood loss resulting from a severed foot."
				,"cause of death was a peculiar incident involving a wishbone and a club."
				,"cause of death was a bizarre gardening accident","Killed trying to recreate something seen on YouTube",
				"Killed by a rival chess player"
		};

		int x = rnd.Next(0, cod.Length - 1);
		return cod[x];

	}

}