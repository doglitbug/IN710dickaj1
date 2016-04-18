using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class XMLManager
    {
        private XDocument pubsAndClubsDoc;
        public void openFile(String filename)
        {
            //TODO Check file is valid
            //Load file
          pubsAndClubsDoc = XDocument.Load(filename);
        }

        public List<Gig> loadUpcomingGigs()
        {
            //Hold data for output
            List < Gig > output = new List<Gig>();

            //Load root node
            XElement Event_Guide = pubsAndClubsDoc.Element("Event_Guide");
            //Loop over all the Gigs
            foreach (XElement gig in Event_Guide.Elements("Gig"))
            {
                //Get the Gigs Venue
                String venue = gig.Element("Venue").Value.Trim();

                //Get and build the gigs date
                XElement dateElement = gig.Element("Date");
                String day = dateElement.Attribute("day").Value;
                String month = dateElement.Attribute("month").Value;
                String year = dateElement.Attribute("year").Value;
                String time = gig.Element("Time").Value;
                //Construct the DataTime
                String entireDateTime = day + "/" + month + "/" + year + " " + time;
                DateTime gigDateTime = DateTime.Parse(entireDateTime);

                //Get the Band
                XElement band = gig.Element("Band");
                //Get the bands name
                String name = band.Element("Name").Value.Trim();
                String genre = band.Element("Genre").Value.Trim();

                //Construct the object
                Gig newGig = new Gig(name, genre, venue, gigDateTime);
                output.Add(newGig);
            }
            return output;
        }

        public List<Gig> loadHardRockGigs()
        {
            //Hold data for output
            List<Gig> output = new List<Gig>();

            //Load root node
            XElement Event_Guide = pubsAndClubsDoc.Element("Event_Guide");
            //Loop over all the Gigs
            foreach (XElement gig in Event_Guide.Elements("Gig"))
            {
                //Get the Band
                XElement band = gig.Element("Band");
                //Get the Genre
                String genre = band.Element("Genre").Value.Trim();
                if (genre.Equals("Hard Rock"))
                {
                    //Get the Gigs Venue
                    String venue = gig.Element("Venue").Value.Trim();

                    //Get and build the gigs date
                    XElement dateElement = gig.Element("Date");
                    String day = dateElement.Attribute("day").Value;
                    String month = dateElement.Attribute("month").Value;
                    String year = dateElement.Attribute("year").Value;
                    String time = gig.Element("Time").Value;
                    //Construct the DataTime
                    String entireDateTime = day + "/" + month + "/" + year + " " + time;
                    DateTime gigDateTime = DateTime.Parse(entireDateTime);


                    //Get the bands name
                    String name = band.Element("Name").Value.Trim();


                    //Construct the object
                    Gig newGig = new Gig(name, genre, venue, gigDateTime);
                    output.Add(newGig);
                }
            }
            return output;
        }

        public List<Gig> loadCurrentMonth()
        {
            //Hold data for output
            List<Gig> output = new List<Gig>();

            //Load root node
            XElement Event_Guide = pubsAndClubsDoc.Element("Event_Guide");
            //Loop over all the Gigs
            foreach (XElement gig in Event_Guide.Elements("Gig"))
            {
                //Get and build the gigs date
                XElement dateElement = gig.Element("Date");

                String month = dateElement.Attribute("month").Value;
                String year = dateElement.Attribute("year").Value;

                //Check it is within this month
                //Convert to Int16 to compare as "04" != "4"
                if (int.Parse(month)==DateTime.Now.Month && int.Parse(year)==DateTime.Now.Year)
                {
                    //Get the Rest of the date time data
                    String day = dateElement.Attribute("day").Value;
                    String time = gig.Element("Time").Value;
                    //Construct the DataTime
                    String entireDateTime = day + "/" + month + "/" + year + " " + time;
                    DateTime gigDateTime = DateTime.Parse(entireDateTime);

                    //Get the Band
                    XElement band = gig.Element("Band");
                    //Get the Genre
                    String genre = band.Element("Genre").Value.Trim();
                    //Get the Gigs Venue
                    String venue = gig.Element("Venue").Value.Trim();

                    //Get the bands name
                    String name = band.Element("Name").Value.Trim();

                    //Construct the object
                    Gig newGig = new Gig(name, genre, venue, gigDateTime);
                    output.Add(newGig);
                }
            }
            return output;
        }
    }
}
