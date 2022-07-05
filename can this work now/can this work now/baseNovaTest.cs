using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace can_this_work_now
{
	internal class baseNovaTest
	{
		public baseNovaTest()
		{
		}
		public baseNovaTest(string novaName)
		{
			this.novaName = novaName;
			//we need to make the human
			getStrings(); //nameing and looks stuffmight want to add this last, or let it be edited at the end
			getAttributes(); //need to start with pms, but absolutely pick out which goes where
			getAbilities(); // lets build the skills no more than 3 right now
			getBackground(); // you get so many background points
			getFlawed(); //optional if you want this
			getBonused(); //what makes human you so special
						  //check the human
			okayHuman(); // hey, are you happy with what you put down
						 //build the nova side
			errupt(); // lets build the nova side
			okayNova(); //are you happy with your nova now
			savefile(); //this should get saved somewhere
			Console.WriteLine("something is working " + novaName + " has a name?");

		}
		//lets get the name stuff out of the way
		string birthName;
		string novaName;
		string playerName;
		//these are going to be pulled from drop down menus
		string concepts;
		string nature;
		string archetype;
		//I am going to let them fill this shit out themselves
		string allegiance;
		//this is a place holder until i can figure out how to add armor and other shit.
		//they are set to 0 to make sure no junk is in them and also to be able to reset form
		int addInt = 0; //you can buy points and other stuff to make int bigger
		int addBash = 0; //mostly from armor i think
		int addpool = 0; //you can buy points to make your pool biller

		//lets get to attributes and abilities shall we
		//all humans have base stat one
		int pms = 0; //need to find a better way to store how many points for physical, mental, and social equaling some kind of 357
					 //Physical 
		int strength = 1;
		int dexterity = 1;
		int stamina = 1;
		//Mental
		int perception = 1;
		int intelligence = 1;
		int wits = 1;
		//Social
		int apperance = 1;
		int manipulation = 1;
		int charisma = 1;

		//ready to add the millions of ~skills~ abilities?

		//physical
		//strength
		int brawl = 0;
		int might = 0;
		int throwing = 0;
		//dexterity
		int athletics = 0;
		int archery = 0;
		int drive = 0;
		int firearms = 0;
		int gunnery = 0;
		int heavyWeapons = 0;
		int ledgerdemain = 0;
		int martialArts = 0;
		int melee = 0;
		int pilot = 0;
		int ride = 0;
		int stealth = 0;
		//stamina
		int endurance = 3;
		int resistance = 3;
		int thoughtDiscipline = 0;

		//mental
		//perception
		int artillery = 0;
		int awareness = 0;
		int navigation = 0;
		int investigation = 0;
		//intelligence
		int analysis = 0;
		int academics = 0;
		int bureaucracy = 0;
		int computer = 0;
		int demolitions = 0;
		int engineering = 0;
		int gambling = 0;
		int intrusion = 0;
		int linguistics = 0;
		int medicine = 0;
		int science = 0;
		int survival = 0;
		int tradecraft = 0;
		//wits
		int arts = 0;
		int biz = 0;
		int meditation = 0;
		int rapport = 0;
		int shadowing = 0;
		int tactics = 0;
		int weave = 0;

		//its time to deal with the smooth cats skills... social, its time for social skills
		//appearance
		int intidation = 0;
		int disguise = 0;
		int style = 0;
		//manipulation
		int diplomacy = 0;
		int hypnosis = 0;
		int interrogation = 0;
		int seduction = 0;
		int streetwise = 0;
		int subterfuge = 0;
		//charisma
		int animalTraining = 0;
		int command = 0;
		int etiquette = 0;
		int instruction = 0;
		int perform = 0;

		//backgrounds
		int node = 0; //if over 4 add taint,
		int eufiber = 0;
		int allies = 0;
		int attunement = 0;
		int backing = 0;
		int cipher = 0;
		int contacts = 0;
		int dormancy = 0;
		int followers = 0;
		int influences = 0;
		int mentor = 0;
		int resources = 0;

		//Will and quantum
		int willpower = 3;
		int quantum = 1; //if over 5 add taint
		int taint = 0; //there is a few reasons to get this
		string aberrations = ""; //need more info about this

		//the string is going to be grabbed from a function and applicable info will be applied to the char sheet then. 
		//merits and flaws
		string flaw1 = "";
		string flaw2 = "";
		string flaw3 = "";

		string merit1 = "";
		string merit2 = "";
		string merit3 = "";

		//who uses specialties?
		string specialty1 = "";
		string specialty2 = "";
		string specialty3 = "";

		//i need to build the looks of the char later
		//i need to figure out how to do equipment, armor and weapons later
		//there should be a whole section of notes
		//initiative, movement, and soak are all formulas, 
		//i need help learning how health works

		//lets build the nova side now
		// 
		//nova can have megas -built in one enhancement
		//Physical 
		int megaStrength = 0;
		string mstrenhance = "";
		int megaDexterity = 0;
		string mdenhance = "";
		int megaStamina = 0;
		string mstaenhance = "";
		//Mental
		int megaPerception = 0;
		string mpenhance = "";
		int megaIntelligence = 0;
		string mienhance = "";
		int megaWits = 0;
		string mwenhance = "";
		//Social
		int megaApperance = 0;
		string maenhance = "";
		int megaManipulation = 0;
		string mmenhance = "";
		int megaCharisma = 0;
		string mcenhance = "";

		//time for the powers
		string power1 = "";
		int power1dot = 0;
		string power2 = "";
		int power2dot = 0;
		string power3 = "";
		int power3dot = 0;
		string power4 = "";
		int power4dot = 0;
		string power5 = "";
		int power5dot = 0;
		string power6 = "";
		int power6dot = 0;
		string power7 = "";
		int power7dot = 0;
		string power8 = "";
		int power8dot = 0;
		string power9 = "";
		int power9dot = 0;

		//page 120 for building person - 

		static void getStrings()
		{
			//nameing and looks stuffmight want to add this last, or let it be edited at the end
		}
		static void getAttributes()
		{
			//need to start with pms, but absolutely pick out which goes where
		}
		static void getAbilities()
		{ 
			// lets build the skills no more than 3 right now
		
		}
		static void getBackground() 
		{
			// you get so many background points
		}
		static void	getFlawed()
		{
			//optional if you want this
		}
		static void	getBonused()
		{ 
			//what makes human you so special
		}
		
		static void okayHuman()
		{ 
			// hey, are you happy with what you put down
		}
		static void errupt()
		{ 
			// lets build the nova side
		}
		static void okayNova()
		{ 
			//are you happy with your nova now
		}
		static void savefile()
		{
			//this should get saved somewhere
		}

	};
	
}

