using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JennyCasey_Assign3
{
    class Guild : IComparable
    {
        private uint id;
        private string name;
        private string server;
        public Guild()
        {
            id = 0;
            name = "";
            server = "";
        }
        //alternate constructor
        public Guild(uint id, string name, string server)
        {
            this.id = id;
            this.name = name;
            this.server = server;
        }
        public uint ID
        {
            //free read/write acess so getter and setters
            get { return id; }
            set { id = value; }
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
            var guilds = new Dictionary<uint, Guild>();
            using (StreamReader inFile = new StreamReader("../../guilds.txt"))
            {
                while ((guildRecord = inFile.ReadLine()) != null)
                {
                    string[] guildInfo = guildRecord.Split('\t', '-');
                    string guildId = guildInfo[0];
                    string guildName = guildInfo[1];
                    string guildServer = guildInfo[2];

                    //parse the guild ID to an unsigned integer
                    uint.TryParse(guildId, out uintGuildId);

                    //add the guilds to a dictionary so we can access them
                    Guild newGuild = new Guild(uintGuildId, guildName, guildServer);
                    guilds.Add(uintGuildId, newGuild);
                }
            }
            return guilds;
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
