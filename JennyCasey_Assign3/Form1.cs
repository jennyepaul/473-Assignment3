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

        }

        //the following event will print out the query results for "All Class Types from a Single Server"
        private void showClassResultButton_Click(object sender, EventArgs e)
        {
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

                //NEED TO SORT BY LEVEL

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
                            queryResultBox.AppendText("Name: " + p.Value.Name + "\t(" + p.Value.PlayerClass + " - " + p.Value.PlayerRole + ")"
                                                + "\tRace: " + p.Value.Race + "\tLevel: " + p.Value.Level + "\t\t<" + g.Value.Name + ">" +
                                                "\n");
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

                /*
                queryResultBox.AppendText("ROLE SELECTED: " + roleSelected + "\tSERVER: " + serverSelected +
                                            "\tMIN LEVEL SELECTED: " + min + "\tMAX LEVEL SELECTED: " + max);
                */

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
                            queryResultBox.AppendText("Name: " + p.Value.Name + "\t(" + p.Value.PlayerClass + " - " + p.Value.PlayerRole + ")"
                                                + "\tRace: " + p.Value.Race + "\tLevel: " + p.Value.Level + "\t\t<" + guild.Value.Name + ">" +
                                                "\n");
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
    }
}
