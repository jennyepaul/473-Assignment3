using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JennyCasey_Assign3
{
    public partial class Form1 : Form
    {
        private Dictionary<uint, Player> playerDictionary;
        private Dictionary<uint, Guild> guildDictionary;

        public Form1()
        {
            InitializeComponent();

            //create a new player and guild object and build the two dictionaries
            Player newplayer = new Player();
            Guild newguild = new Guild();
            playerDictionary = newplayer.BuildPlayerDictionary();
            guildDictionary = newguild.BuildGuildDictionary();

            //load the class & server drop down in the "All Class Type from Single Server" query area
            classDropDown.Items.Add(Classes.Druid);
            classDropDown.Items.Add(Classes.Hunter);
            classDropDown.Items.Add(Classes.Mage);
            classDropDown.Items.Add(Classes.Paladin);
            classDropDown.Items.Add(Classes.Priest);
            classDropDown.Items.Add(Classes.Rogue);
            classDropDown.Items.Add(Classes.Shaman);
            classDropDown.Items.Add(Classes.Warlock);
            classDropDown.Items.Add(Classes.Warrior);

            serverDropDown.Items.Add("Beta4Azeroth");
            serverDropDown.Items.Add("TKWasASetback");
            serverDropDown.Items.Add("ZappyBoi");

            //load the server and role drop down for the "All Players of a Single Role in a Single Server in
            //a Level Range" query area
            serverRangeDropDown.Items.Add("Beta4Azeroth");
            serverRangeDropDown.Items.Add("TKWasASetback");
            serverRangeDropDown.Items.Add("ZappyBoi");

            roleDropDown.Items.Add(Role.Damage);
            roleDropDown.Items.Add(Role.Healer);
            roleDropDown.Items.Add(Role.Tank);

            serverPercentDropDown.Items.Add("Beta4Azeroth");
            serverPercentDropDown.Items.Add("TKWasASetback");
            serverPercentDropDown.Items.Add("ZappyBoi");

            guildTypeDropDown.Items.Add("Casual");
            guildTypeDropDown.Items.Add("Questing");
            guildTypeDropDown.Items.Add("Mythic");
            guildTypeDropDown.Items.Add("Raiding");
            guildTypeDropDown.Items.Add("PVP");


        }

        //the following event will print out the query results for "All Class Types from a Single Server"
        private void showClassResultButton_Click(object sender, EventArgs e)
        {
            //clear the query result box
            queryResultBox.Clear();

            Guild newGuild = new Guild();

            if(classDropDown.SelectedIndex != -1 && serverDropDown.SelectedIndex != -1)
            {
                Classes classSelected = (Classes)classDropDown.SelectedItem;
                string serverSelected = (string)serverDropDown.SelectedItem;

                //query the guild dictionary
                var ServerQuery =
                    from guild in guildDictionary
                    where guild.Value.Server == serverSelected
                    select guild;

                //query the player dictionary
                var ClassQuery =
                    from player in playerDictionary
                    where (player.Value.PlayerClass == classSelected)
                    select player;

                //output the info to the query box
                queryResultBox.AppendText("All " + classSelected + " from " + serverSelected + "\n");
                queryResultBox.AppendText("---------------------------------------------------------------------------------------------------------------------------------\n");

                //go through the Class Query
                foreach (var p in ClassQuery)
                {
                    //go through the Server Query
                    foreach (var g in ServerQuery)
                    {
                        //if the guild from the Server Query's ID matches the guildID of the player from the Player Query, print out the info
                        if (g.Key == p.Value.GuildID)
                        {
                            queryResultBox.AppendText(p.Value + "\t\t<" + g.Value.Name + ">\n");
                        }
                    }
                }
                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
            }
            else
            {
                queryResultBox.Text = "Please select a class and server to see query results!";
;           }
            
        }

        //the following event will print out the query results for "All Role Types from a Single Server w/in a Level Range"
        private void roleServerLevelResultButton_Click(object sender, EventArgs e)
        {
            //clear the query result box
            queryResultBox.Clear();

            Guild newGuild = new Guild();
            
            //if the user has selected a role and server 
            if(roleDropDown.SelectedIndex != -1 && serverRangeDropDown.SelectedIndex != -1)
            {
                //set the selected values to a variable
                int min =(int)minimumLevel.Value;
                int max = (int)maximumLevel.Value;
                Role roleSelected = (Role)roleDropDown.SelectedItem;
                string serverSelected = (string)serverRangeDropDown.SelectedItem;

                //query the guild dictionary
                var ServerQuery =
                    from guild in guildDictionary
                    where guild.Value.Server == serverSelected
                    select guild;

                //query the player dictionary
                var RoleQuery =
                    from player in playerDictionary
                    where (player.Value.PlayerRole == roleSelected) && 
                          (player.Value.Level >= min) && 
                          (player.Value.Level <= max)
                    orderby player.Value.Level ascending
                    select player;

                //output the info to the query box
                queryResultBox.AppendText("All " + roleSelected + " from [" + serverSelected + "]," +
                                           " Levels " + min + " to " + max+ "\n");
                queryResultBox.AppendText("---------------------------------------------------------------------------------------------------------------------------------\n");

                //go through the Class Query
                foreach (var p in RoleQuery)
                {
                    //go through the Server Query
                    foreach (var guild in ServerQuery)
                    {
                        //if the guild from the Server Query's ID matches the guildID of the player from the Player Query, print out the info
                        if (guild.Key == p.Value.GuildID)
                        {
                            queryResultBox.AppendText(p.Value + "\t\t<" + guild.Value.Name + ">\n");
                        }
                    }
                }
                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
            }
            //otherwise they forgot to select something so output message
            else if(roleDropDown.SelectedIndex == -1 || serverRangeDropDown.SelectedIndex == -1)
            {
               if(roleDropDown.SelectedIndex == -1)
               {
                    queryResultBox.Text = "Please select a role";
               }
               if (serverRangeDropDown.SelectedIndex == -1)
               {
                   queryResultBox.Text = "Please select a server";
               }  
            }
        }

        //the following event will print out the query results for "All Players Who can Fill a Role but Currently Aren't"
        private void roleResultButton_Click(object sender, EventArgs e)
        {
            //clear the output box
            queryResultBox.Clear();
            Guild newGuild = new Guild();
            //check what button was selected
            //TANK ROLE
            if(tankRadioButton.Checked)
            {
                //the player can have a class of: Druid, Warrior, Paladin, so search for those players
                //who have that class in the dictionary
                var ClassQuery =
                    from player in playerDictionary
                    where  (player.Value.PlayerClass == Classes.Druid)
                           || (player.Value.PlayerClass == Classes.Warrior)
                           || (player.Value.PlayerClass == Classes.Paladin)
                    select player;

                //now search through the class query to find those players who are not a Tank already
                var TankQuery =
                    from player in ClassQuery
                    where (player.Value.PlayerRole != Role.Tank)
                    orderby player.Value.Level ascending
                    select player;
               
                //output to the query box
                queryResultBox.AppendText("All Eligible Players Not Fulfilling the Tank Role\n");
                queryResultBox.AppendText("---------------------------------------------------------------------------------------------------------------------------------\n");
                
                //go through the Tank Query
                foreach (var p in TankQuery)
                {
                    string guildName = newGuild.FindGuildName(guildDictionary, p.Value.GuildID);
                    queryResultBox.AppendText(p.Value + "\t\t<" + guildName + ">\n");              
                }
                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
            }
            //HEALER ROLE
            if(healerRadioButton.Checked)
            {
                //the player can have a class of: Druid, Priest, Paladin, Shaman, so go through 
                //dictionary and find all players who have those classes
                var ClassQuery =
                    from player in playerDictionary
                    where (player.Value.PlayerClass == Classes.Druid) ||
                           (player.Value.PlayerClass == Classes.Shaman) ||
                           (player.Value.PlayerClass == Classes.Paladin) ||
                           (player.Value.PlayerClass == Classes.Priest)
                    select player;

                //now search through the class query to find those players who are not a Healer already
                var HealerQuery = 
                    from player in ClassQuery
                    where (player.Value.PlayerRole != Role.Healer)
                    orderby player.Value.Level ascending
                    select player;

                //output to the query box
                queryResultBox.AppendText("All Eligible Players Not Fulfilling the Healer Role\n");
                queryResultBox.AppendText("---------------------------------------------------------------------------------------------------------------------------------\n");

                //go through the Healer Query
                foreach (var p in HealerQuery)
                {
                    string guildName = newGuild.FindGuildName(guildDictionary, p.Value.GuildID);
                    queryResultBox.AppendText(p.Value + "\t\t<" + guildName + ">\n");
                }
                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
            }
            //DAMAGE ROLE
            if (damageRadioButton.Checked)
            {
                //the player can have a class of: everyone
                var DamageQuery =
                    from player in playerDictionary
                    where (player.Value.PlayerRole != Role.Damage)
                    select player;

                //output to the query box
                queryResultBox.AppendText("All Eligible Players Not Fulfilling the Damage Role\n");
                queryResultBox.AppendText("---------------------------------------------------------------------------------------------------------------------------------\n");

                //go through the Damage Query
                foreach (var p in DamageQuery)
                {
                    string guildName = newGuild.FindGuildName(guildDictionary, p.Value.GuildID);
                    queryResultBox.AppendText(p.Value + "\t\t<" + guildName + ">\n");
                }
                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
            }
        }


        //FOLLOWING 3 ARE WHAT IS LEFT :)

        //the following event will print out the query result for "Percentage of Each Race from a Single Server" query
        private void showPercentResultButton_Click(object sender, EventArgs e)
        {
            //clear the query result box
            queryResultBox.Clear();

            //make sure that a server has been selected from the server drop down 
            if (serverPercentDropDown.SelectedIndex != -1)
            {
                queryResultBox.AppendText("Percentage of Each Race from " + serverPercentDropDown.SelectedItem + "\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");

                //create a query to get the guild ID's that are associated with the server chosen
                var serverToGuildID = from x in guildDictionary
                                      where x.Value.Server.Contains((string)serverPercentDropDown.SelectedItem)
                                      select x;

                //use the previous query to find which players are from the server chosen
                var guildIDMatch = from x in playerDictionary
                                   join c in serverToGuildID
                                   on x.Value.GuildID equals c.Value.ID
                                   select x;

                //keep track of the total number of players associated with the server chosen
                double total = guildIDMatch.Count();

                //group the players associated with that server by their race and count the amount of 
                //player from each individual race 
                var CountinRace = from x in guildIDMatch
                                  group x by x.Value.Race into RaceGroup
                                  select new
                                  {
                                      Race = RaceGroup.Key,
                                      Count = RaceGroup.Count(),
                                  };

                //divide the amount of players associated with the specific server, that are from a specific race 
                //by the total number of player from the server chosen to retrieve the percentage of each race from 
                //the server chosen
                var getPercentage = from x in CountinRace
                                    orderby x.Count ascending
                                    select new
                                    {
                                        Race = x.Race,
                                        Percent = ((x.Count / total) * 100),
                                    };


                //print the name of the race and each percentage 
                foreach (var x in getPercentage)
                {
                    queryResultBox.AppendText(String.Format("{0}\t\t{1:00.00}%\n", x.Race, x.Percent));
                }

                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");

            }
            else
            {
                //if no server was selected print error message to text box 
                queryResultBox.AppendText("Please select a server.");
            }
        }

        //the following event will print out the query reault for "All Guilds of a Single Type" query
        private void guildTypeResultButton_Click(object sender, EventArgs e)
        {
            //clear the query result box
            queryResultBox.Clear();

            //check to see if a guild type was selected 
            if (guildTypeDropDown.SelectedIndex != -1)
            {
                queryResultBox.AppendText("All " + guildTypeDropDown.SelectedItem + "-Type of Guilds" + "\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");


                //creates a query to retrieve the guilds that are of the type selected in the dropdown
                //group the names of each guild by the server and then orders them by the server in 
                //descending order 
                var GuildsofSelectedType = from x in guildDictionary
                                           where x.Value.Type == ((GuildType)guildTypeDropDown.SelectedIndex)
                                           group new { x.Value.Name } by x.Value.Server into servergroup
                                           orderby servergroup.Key descending
                                           select servergroup;


                //print out the server and any names associated with that server
                foreach (var server in GuildsofSelectedType)
                {
                    queryResultBox.AppendText(server.Key + "\n");
                    foreach (var name in server)
                    {
                        queryResultBox.AppendText("\t<" + name.Name + ">\n");
                    }
                }

                queryResultBox.AppendText("\nEND RESULTS\n");
                queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
            }
            else
            {
                //if no guild type was selected from drop down
                queryResultBox.AppendText("Please select a guild type.");
            }
        }

        //the following event will print out the query result for "Percentage of Max Level Players in All Guilds"
        private void maxLvlPercentButton_Click(object sender, EventArgs e)
        {



            //clear the query result box
            queryResultBox.Clear();

            queryResultBox.AppendText("Percentage of Max Level Players in All Guilds" + "\n");
            queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");



            //create a query to find the amount of players in each guild
            var totalplayers = from x in playerDictionary
                               group x by x.Value.GuildID into totalamtplayers
                               select new
                               {
                                   IDnum = totalamtplayers.Key,
                                   Count = totalamtplayers.Count(),

                               };


            //create a query to find the amount of max level player in each guild 
            var maxlvlplayer = from x in playerDictionary
                               where x.Value.Level == 60
                               group x by x.Value.GuildID into maxlvlgroup
                               select new
                               {
                                   IDnum = maxlvlgroup.Key,
                                   Count = maxlvlgroup.Count(),
                               };

            

            Guild guild1 = new Guild();

            //create a query to get the percentage of max players in each guild by dividing the amount of max
            //level players in each guild by the amount of total players in each guild
            var percentages = from x in maxlvlplayer
                              join c in totalplayers
                              on x.IDnum equals c.IDnum
                              select new
                              {
                                  Percent = (((double)x.Count / (double)c.Count) * 100),
                                  IDNum = x.IDnum,
                              };


            //create a query to put the guilds in order according to the guild dictionary
            var InOrder = from x in guildDictionary
                            join c in totalplayers
                            on x.Value.ID equals c.IDnum
                            select new
                            {
                                IDNum = c.IDnum,
                            };


            bool percent = false;

            foreach (var guildid in InOrder)
            {
                queryResultBox.AppendText(String.Format("<{0, -40}\t", guild1.FindGuildName(guildDictionary, guildid.IDNum) + ">"));
                foreach (var x in percentages)
                {
                    if (guildid.IDNum == x.IDNum)
                    {
                        percent = true;
                        queryResultBox.AppendText(String.Format("{0: 0.00}%\n\n", x.Percent));
                        break;
                    }
                    else
                    {
                        percent = false;
                    }
                }
                if (percent == false)
                {
                    decimal value = 0;
                    queryResultBox.AppendText(String.Format("{0: 0.00}%\n\n", value));
                }
               
            }
           

                queryResultBox.AppendText("\nEND RESULTS\n");
            queryResultBox.AppendText("--------------------------------------------------------------------------------------------------------------------------------\n");
        }
    }
}
