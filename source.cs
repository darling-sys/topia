using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Diagnostics; // for "Process" type
using System.Globalization;
using System.Media;
namespace topia
{
	public class constance // helpful constance gives us info
	{
		public static readonly string version = "0.0.1";
		public static readonly string[] ethics = {"liberty", "authority", "industry", "ecology", "mysticism", "materialism", "spiritualism", "secularism", "egality", "stratificy", "cooperation", "competition", "militarism", "pacifism", "impulsion", "manipulation", "xenophobia", "xenophilia", "bioessentialism", "bioprogressivism", "populism", "elitism", "transparency", "secrecy"};
		public static readonly string[] authorities = {"democracy", "republic", "oligarchy", "dictatorship", "monarchy"};
		public static readonly string[] rulerTitles = {"speaker", "president", "overseer", "chancellor", "empress"};
		public static readonly string[] subRulers = {"minister", "secretary", "supervisor", "governor", "duchess"};
		public static readonly string[] rulershipBuildings = {"parliament", "congress", "diet", "palace", "royal palace"};
		public static readonly string[] subrulersBuildings = {"council", "city hall", "office", "chateau", "noble estate"};
		public static readonly string[] stances = {"paternal", "helpful", "responsible", "cooperative", "diplomatic", "beligerent", "expansionist", "domineering", "supremacist", "exterminationist"};
		public static readonly string[] settlementTiers = {"encampment", "outpost", "village", "town", "city", "grand city"};
		/*
		public static readonly string[] developments = {"farm", "pasture", "plantation", "quarry", "mine", "manufactory"};
		public static readonly string[] forestDevelopments = {"camp", "lumber mill", "hunting lodge"};
		public static readonly string[] militaryDevelopments = {"fort", "castle", "citadel"};
		public static readonly string[] spiritualDevelopments = {"shrine", "temple", "observatory", "academy"};
		*/
		public static building getBuilding(string buildingType)
		{
			switch(buildingType)
			{
				case "farm":
				{
					building farm = new building();
					farm.name = "farm";
					farm.resources.food = 4;
					return farm;
				}
				default:
				{
					return null;
				}
			}
		}
	}
	public class Program // program starting point
	{
		public static void Main(string[] args)
		{
			//
		}
	}
	public class playerEntity
	{
		string name;
		string id;
		nation playerNation = new nation();
		int lastSeen;
		List<tradeDeal> trades = new List<tradeDeal>();
		
	}
	public class tradeDeal
	{
		string initiatingPartyID;
		string confirmingPartyID;
		physicalResources offer = new physicalResources();
		physicalResources request = new physicalResources();
		int lastSent;
		int expirationAfter = 60*60*24*8;
	}
	public class physicalResources
	{
		int food;
		int gold;
		int silver;
		int copper;
		int tin;
		int iron;
		int bronze;
		int textiles;
		int lumber;
		int blades;
		int ships;
		int weapons;
		int armor;
	}
	public class fleet
	{
		string name;
		int staffedShips;
		int understaffedShips;
		int sparePopulation;
		List<division> divisions = new List<division>();
		string currentOrder;
		string target;
	}
	public class unit
	{
		string name;
		int population;
		int attack;
		int defense;
	}
	public class division
	{
		string name;
		List<unit> units = new List<unit>();
		string currentOrder;
		string target;
	}
	public class nation
	{
		string name;
		bool[] ethics = new bool[24];
		int authority;
		int stance;
		List<settlement> settlements = new List<settlement>();
		List<unit> units = new List<unit>();
		List<division> divisions = new List<division>();
		List<fleet> fleets = new List<fleet>();
		// mana
		int popPower;
		int politicalPower;
		int stability;
		physicalResources resources = new physicalResources();
	}
	public class settlement
	{
		int id;
		string name;
		bool isCapitol;
		List<building> buildings = new List<building>();
		int population;
		int specialization = 0;
	}
	public class building
	{
		int id;
		string name;
		bool active;
		string effect;
		// mana
		int popPower;
		int politicalPower;
		int stability;
		physicalResources resources = new physicalResources();
	}
}

