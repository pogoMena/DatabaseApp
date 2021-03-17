using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

/*
 *  * I, Michael Mena, 000817498 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 * 
 * Date: 12/10/2020
 * 
 * This is a program that connects to a database and lets you select a doctor
 * The fields relating to the doctor are all filled in appropriately
 * depending on the radio button that is selected, you can accomplish this using sql or Linq
 */

namespace Lab5b
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>(); // List of doctors
        List<Companion> companions = new List<Companion>(); //List of companions
        List<Episode> episodes = new List<Episode>(); //List of episodes
        
        SqlConnection Connection;
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True"; //Connection string to proper database
        public Form1()
        {
            InitializeComponent();

            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString; // The initial connection to the proper database is made
                Connection.Open();
                openForm();
                dbDoctor.SelectedIndex = 0;// Sets the selected index to the inital spot
            }
            catch (Exception ex)
            {
                this.tbActor.Text = "Database Connection failed " + ex.Message;
            }



        }
        
        /// <summary>
        /// The openForm function goes through the process of filling all of the lists(doctors,companions, episodes) with the proper information to fit their parameters 
        /// </summary>
        public void openForm()
        {
            try
            {
                SqlDataReader sqlDatareaderID = new SqlCommand("SELECT * FROM DOCTOR", Connection).ExecuteReader();
                while (sqlDatareaderID.Read())
                {
                    
                    //All of the parameters are filled and then the doctors are created and added to the "doctors" list
                    int position = (int)sqlDatareaderID["DOCTORID"];
                    string actor = (string)sqlDatareaderID["ACTOR"];
                    int age = (int)sqlDatareaderID["AGE"];
                    int series = (int)sqlDatareaderID["SERIES"];
                    string debut = (string)sqlDatareaderID["DEBUT"];
                    byte[] photo = (byte[])sqlDatareaderID["PICTURE"];
                    MemoryStream stream = new MemoryStream(photo);
                    Image image = Image.FromStream(stream);
                    doctors.Add(new Doctor(position, actor, series, age, debut, image));
                }
                sqlDatareaderID.Close(); //Closes the connection
                



                SqlDataReader sqlDataReaderEpisode = new SqlCommand("SELECT * FROM EPISODE", Connection).ExecuteReader();
                while (sqlDataReaderEpisode.Read())
                {
                    //All of the parameters are filled and then the episodes are created and added to the "episodes" list
                    string story = sqlDataReaderEpisode["STORYID"].ToString();
                    int season = int.Parse(sqlDataReaderEpisode["SEASON"].ToString());
                    int year = int.Parse(sqlDataReaderEpisode["SEASONYEAR"].ToString());
                    string title = sqlDataReaderEpisode["TITLE"].ToString();

                    episodes.Add(new Episode(story, season, year, title));
                }
                sqlDataReaderEpisode.Close(); //Closes the connection
                SqlDataReader sqlDataReaderCompanion = new SqlCommand("SELECT * FROM COMPANION", Connection).ExecuteReader();
                while (sqlDataReaderCompanion.Read())
                {
                    //All of the parameters are filled and then the companions are created and added to the "companions" list
                    string name = sqlDataReaderCompanion["NAME"].ToString();
                    string actor = sqlDataReaderCompanion["ACTOR"].ToString();
                    int doctor = int.Parse(sqlDataReaderCompanion["DOCTORID"].ToString());
                    string debut = sqlDataReaderCompanion["STORYID"].ToString();

                    companions.Add(new Companion(name,actor,doctor,debut));
                }
                sqlDataReaderCompanion.Close(); //Closes the connection
            }

            catch(Exception e)
            {
                lbCompanions.Text = "Database connection failed" + e.Message;
            }
        }
        
        
        /// <summary>
        /// This is what handles the index change of the  Doctor combo box
        /// This is where you would select whichever doctor you please and 
        /// the parameters around the screen will be filled with the proper information
        /// </summary>
        private void dbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //These 6 lines handle clearing all fields before refilling them
            lbCompanions.Items.Clear();
            tbActor.Text = "";
            tbAge.Text = "";
            tbFirstEpisode.Text = "";
            tbYear.Text = "";
            tbSeries.Text = "";
            

            if (rbSQL.Checked) //Checks if the SQL radiobutton is selected
            {
                
                try
                {
                    //SQL statement that is used to query the information that fills all fields on the screen besides the Companions listbox
                    SqlDataReader sqlDataReader1 = new SqlCommand("" +
                        "SELECT DOCTOR.ACTOR, DOCTOR.SERIES, DOCTOR.AGE, DOCTOR.PICTURE, EPISODE.TITLE, EPISODE.SEASONYEAR" +
                        " FROM DOCTOR INNER JOIN EPISODE ON DOCTOR.DEBUT = EPISODE.STORYID WHERE DOCTOR.Debut = " +
                        "" + doctors[dbDoctor.SelectedIndex].Debut, Connection).ExecuteReader();
                    
                    if (sqlDataReader1.Read())
                    {
                        tbActor.Text = sqlDataReader1[0].ToString(); //Fills the "Played by:" textbox
                        tbSeries.Text = sqlDataReader1[1].ToString();// Fills the "Series" textbox
                        tbAge.Text = sqlDataReader1[2].ToString(); // Fills the "Age at start:" textbox 
                        pbDoctor.Image = Image.FromStream((Stream)new MemoryStream((byte[])sqlDataReader1["Picture"])); // sets the appropriate Doctors image to the picturebox
                        tbFirstEpisode.Text = sqlDataReader1[4].ToString(); //Fills the "First full episode" textbox
                        tbYear.Text = sqlDataReader1[5].ToString(); // Fills the "Year: " textbox
                        sqlDataReader1.Close();
                    }

                    //SQL statement that is used to fill the Companions listbox
                    SqlDataReader sqlDataReader2 = new SqlCommand("SELECT COMPANION.NAME, COMPANION.ACTOR, EPISODE.TITLE, EPISODE.SEASONYEAR" +
                        " FROM COMPANION  INNER JOIN EPISODE ON COMPANION.STORYID = EPISODE.STORYID  WHERE COMPANION.DOCTORID = "
                        + doctors[dbDoctor.SelectedIndex].Position.ToString() + " ORDER BY EPISODE.SEASONYEAR, EPISODE.STORYID", Connection).ExecuteReader();

                    //This function reads and then properly formats the information about the companions
                    while (sqlDataReader2.Read())
                    {
                        lbCompanions.Items.Add((sqlDataReader2[0].ToString() + " (" + sqlDataReader2[1].ToString() + ")"));
                        lbCompanions.Items.Add(("\"" + sqlDataReader2[2].ToString() + "\" (" + sqlDataReader2[3].ToString() + ")"));
                        lbCompanions.Items.Add("");
                    }
                    sqlDataReader2.Close(); // Closes connection
                }

                catch (Exception we)
                {
                    tbActor.Text = we.Message;
                }
            }
            else
            {




                
                int selection = dbDoctor.SelectedIndex; //Saves the index value to "selection"
                
                //Fills all of the fields that are directly related to the Doctor class
                tbActor.Text = doctors[selection].Actor;
                tbSeries.Text = doctors[selection].Series.ToString();
                tbAge.Text = doctors[selection].Age.ToString();
                pbDoctor.Image = doctors[selection].Picture;

                //Is used to have the companion/first full episode/ year fields line up properly
                if (selection != doctors.Count())
                {
                    selection++;
                }

                // LINQ statement that fills the ACTOR parameter with information that will fill the rest of the fields
                var Actor = from Doctor in doctors
                where Doctor.Position == selection
                join Companion in companions on Doctor.Position equals Companion.Doctor
                join Episode in episodes on Companion.Debut equals Episode.Story
                orderby Episode.Story
                select new { name = Companion.Name, actorName = Companion.Actor, title = Episode.Title, year = Episode.Year };


                int random = 0;// Makes an if statement only true on the first rotation of the following foreach loop

                //Fills the companion fields aswell as the year and firstEpisode fields
                foreach (var variable in Actor)
                {
                    //If statement that only fills the year/first episode fields with the first value
                    if (random == 0)
                    {
                        tbYear.Text = variable.year.ToString();
                        tbFirstEpisode.Text = variable.title.ToString();
                        random = 2;
                    }
                    //Fills the Companions listbox with the properly formatted information
                    lbCompanions.Items.Add((variable.name + " (" + variable.actorName + ")"));
                    lbCompanions.Items.Add(("\"" + variable.title + "\" (" +variable.year + ")"));
                    lbCompanions.Items.Add("");
                    
                    
                }

                
            }
    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
