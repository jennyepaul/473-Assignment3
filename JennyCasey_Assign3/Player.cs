using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JennyCasey_Assign3
{
    public enum Race { Orc, Troll, Tauren, Forsaken };
    public enum Classes
    {
        Warrior, Mage, Druid, Priest, Warlock,
        Rogue, Paladin, Hunter, Shaman
    };
    public enum Role { Tank, Healer, Damage };

    class Player : IComparable
    {//constants for program
        private static uint MAX_LEVEL = 60;

        //private attributes
        private uint id;
        private string name;
        private Race race;
        private Classes playerClass;
        private Role playerRole;
        private uint level;
        private uint exp;
        private uint guildId;

        // default constructor 
        public Player()
        {
            id = 0;
            name = "";
            race = 0;
            playerRole = 0;
            playerClass = 0;
            level = 0;
            exp = 0;
            guildId = 0;
        }


        //alternate constructor
        public Player(uint id, string name, Race race, Role playerRole, Classes playerClass, uint level, uint exp, uint guildId)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.playerRole = playerRole;
            this.playerClass = playerClass;
            this.level = level;
            this.exp = exp;
            this.guildId = guildId;
        }

        //only a getter, since only readonly
        public uint ID
        {
            get { return id; }
            set { id = value; }
        }

        //only a getter, since only readonly
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //only a getter, since only readonly
        public Race Race
        {
            get { return race; }
            set { race = value; }
        }

        public Classes PlayerClass
        {
            get { return playerClass; }
            set { playerClass = value; }
        }

        public Role PlayerRole
        {
            get { return playerRole; }
            set { playerRole = value; }
        }
        public uint Level
        {
            //free read/write acess so getter and setters
            get { return level; }
            set { level = value; }
        }

        public uint Exp
        {
            //free read/write acess so getter and setters
            get
            { return exp; }
            set
            {
                //nextLevel would be the current Level * 100)
                //set newLevel to Level since we don't want to alter the Level variable
                uint nextLevel = (Level * 1000);
                uint newLevel = Level;

                //if the experience is greater than the value of what the nextLevel would be, we would level up
                //so calculate what the ~possible~ newLevel of the player would be
                if (exp >= nextLevel)
                {
                    exp /= nextLevel;
                    newLevel += exp;

                }
                //if the current level OR the new level after experience is less than MAX_LEVEL
                //we can add the experience
                if ((Level < MAX_LEVEL) || (newLevel < MAX_LEVEL))
                {
                    //only incremnt exp if it does not exceed MAX_LEVEL
                    exp += value;
                }
                else
                {
                    //if its >= MAX_LEVEL then we just return
                    Console.WriteLine("Player already at max level");
                    exp += 0;
                    return;
                }
            }
        }

        public uint GuildID
        {
            //free read/write acess so getter and setters
            get { return guildId; }
            set { guildId = value; }
        }

        public Dictionary<uint, Player> BuildPlayerDictionary()
        {
            string playerRecord;
            var players = new Dictionary<uint, Player>();

            //read the player file
            using (StreamReader inFile = new StreamReader("../../players.txt"))
            {
                while ((playerRecord = inFile.ReadLine()) != null)
                {
                    uint parsed_id;
                    Race parsed_race;
                    Classes parsed_classes;
                    Role parsed_role;
                    uint parsed_level;
                    uint parsed_exp;
                    uint parsed_guildID;

                    string[] parameter = playerRecord.Split('\t');

                    //grab all the info
                    uint.TryParse(parameter[0], out parsed_id);
                    Enum.TryParse(parameter[2], out parsed_race);
                    Enum.TryParse(parameter[3], out parsed_classes);
                    Enum.TryParse(parameter[4], out parsed_role);
                    uint.TryParse(parameter[5], out parsed_level);
                    uint.TryParse(parameter[6], out parsed_exp);
                    uint.TryParse(parameter[7], out parsed_guildID);

                    //create a new player object
                    Player newPlayer = new Player(parsed_id, parameter[1], parsed_race, parsed_role, parsed_classes, parsed_level, parsed_exp, parsed_guildID);

                    //add object to the dictionary
                    players.Add(parsed_id, newPlayer);
                }
            }
            return players;
        }

        public void PlayerLeaveGuild(Dictionary<uint, Player> dictionary, string playerName)
        {
            //search through the players dictionary for the username entered
            foreach (var player in dictionary)
            {
                //once we find it, set the flag, then set the guild to 0 since we want to leave
                if (player.Value.Name == playerName)
                {
                    dictionary[player.Key].GuildID = 0;
                }
            }

        }
        public void PlayerJoinGuild(Dictionary<uint, Player> dictionary, string playerName, uint guildID)
        {
            //search for the name that the user entered in the players dictionary
            foreach (var player in dictionary)
            {
                //if we find the player name in the dictionary
                if (player.Value.Name == playerName)
                {
                    //set the guild to the guild ID and print out that player joined
                    dictionary[player.Key].GuildID = guildID;
                }
            }
        }

        public int CompareTo(Object alpha)
        {
            //checking for null values
            if (alpha == null) throw new ArgumentNullException();
            //typecasting to a Player
            Player playerToCompare = alpha as Player;
            // Protect against a failed typecasting
            if (playerToCompare != null)
                return name.CompareTo(playerToCompare.name);
            else
                throw new ArgumentException("[Player]:CompareTo argument is not an Player");
        }

        public override string ToString()
        {
            return ("Name: " + this.Name + "\t(" + this.PlayerClass + " - " + this.PlayerRole + ")"
                                                + "\tRace: " + this.Race + "\tLevel: " + this.Level);
        }
    }
}
