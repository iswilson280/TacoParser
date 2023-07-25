namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogWarning("The cells elements are less than 3");// Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var nameCity = cells[2];


            // grab the longitude from your array at index 1
            // grab the name from your array at index 2

            // Your going to need to parse your string as a `double`


            // which is similar to parsing a string as an `int`
            //bool parseLatitude = double.TryParse(latitude, out double latNumber);
            //bool parseLongitude = double.TryParse(longitude, out double longNumber);


            //if (!parseLatitude)
            //{
            //    logger.LogWarning("Was unable to parse Latitude.");
            //}


            //if (!parseLongitude)
            //{
            //    logger.LogWarning("Was unable to parse Latitude.");
            //}

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            Point point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;


            TacoBell tacoBell = new TacoBell()
            //tacoBell.Name = nameCity;
            //tacoBell.Location = point;
            {
                Name = nameCity,
                Location = point
            };



            // Then, return the instance of your TacoBell class
            return tacoBell;

            // Since it conforms to ITrackable

            
        }

        
    }

}