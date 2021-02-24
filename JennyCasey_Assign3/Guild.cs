/* CSCI473 
 * Assignment 3
 * DATE: 2/23/2021
 * TEAM: JennyCasey
 * Contributors: Jennifer Paul (z1878099) and Casey McDermott (z1878096)
 * PURPOSE: The purpose of this assignment is to perform queries on the player and guild dictionaries.
 *          Some examples of the queries are to check how many max players there are for each guild, all the guild
 *          types of a specific type, players who could fill a role but currently aren't, and so on. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JennyCasey_Assign3
{
    /**************************************************************************************************************************
     * Class - Guild
     * 
     * The player class is used store the information of each individual guild. 
     * 
     * - There are 3 private attributes that stores information about each individual guild, such as the guild ID, name, type, and
     *    server
     * - The huild class has an IComparable interface in order to sort the guild based on its name.
     * - Guild Class Methods: 
     *            BuildGuildDictionary => This method reads in the guild.txt file and then parses the information for each
     *                                    record into the class attributes, and then creates a new guild object, and adds
     *                                    that object to the guild dictionary.
     *            FindGuildName => The purpose of this method is to return the guild name when the guild ID is passed to it. 
     *            
     * ************************************************************************************************************************/
    public enum GuildType { Casual, Questing, Mythic, Raiding, PVP };

    class Guild : IComparable
    {
        private uint id;
        private GuildType type;
        private string name;
        private string server;
        public Guild()
        {
            id = 0;
            type = 0;
            name = "";
            server = "";
        }
        //alternate constructor
        public Guild(uint id, GuildType type, string name, string server)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.server = server;
        }
        public uint ID
        {
            //free read/write acess so getter and setters
            get { return id; }
            set { id = value; }
        }

        public GuildType Type
        {
            //free read/write access 
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            //free read/write acess so getter and setters
            get { return name; }
            set { name = value; }
        }
        public string Server
        {
            //free read/write acess so getter and setters
            get { return server; }
            set { server = value; }
        }

        //create a dictionary to store guild info
        public Dictionary<uint, Guild> BuildGuildDictionary()
        {
            string guildRecord;
            uint uintGuildId;
            GuildType type;
            var guilds = new Dictionary<uint, Guild>();
            using (StreamReader inFile = new StreamReader("../../guilds.txt"))
            {
                while ((guildRecord = inFile.ReadLine()) != null)
                {
                    string[] guildInfo = guildRecord.Split('\t', '-');
                    string guildId = guildInfo[0];
                    string guildType = guildInfo[1];
                    string guildName = guildInfo[2];
                    string guildServer = guildInfo[3];

                    //parse the guild ID to an unsigned integer
                    uint.TryParse(guildId, out uintGuildId);
                    Enum.TryParse(guildType, out type);

                    //add the guilds to a dictionary so we can access them
                    Guild newGuild = new Guild(uintGuildId, type, guildName, guildServer);
                    guilds.Add(uintGuildId, newGuild);
                }
            }
            return guilds;
        }
        public string FindGuildName(Dictionary<uint, Guild> dictionary, uint ID)
        {
            string name;
            //based on server selected, find all associated guild IDs, then search player dictionary for that
            foreach (var g in dictionary)
            {
                if (g.Key == ID)
                {
                    name = g.Value.Name;
                    return name;
                }
            }
            return "not found";
        }
        public int CompareTo(Object alpha)
        {
            //checking for null values
            if (alpha == null) throw new ArgumentNullException();

            //typecasting to a guild
            Guild guildToCompare = alpha as Guild;

            // Protect against a failed typecasting
            if (guildToCompare != null)
                return name.CompareTo(guildToCompare.name);
            else
                throw new ArgumentException("[Guild]:CompareTo argument is not a Guild");
        }

        public override string ToString()
        {
            return (this.Name.PadRight(30) + "\t" + "[" + this.Server + "]");
        }
    }
}
