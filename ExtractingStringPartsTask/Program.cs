namespace ExtractingStringPartsTask
{
     internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";

            int StateLength = state.Length;
            Console.WriteLine("state length: " + StateLength);

            string CityAndLandmark = city + " " + landmark;
            Console.WriteLine("City and landmark : " + CityAndLandmark);

            char firstLetterOfCountry = country[0];
            Console.WriteLine("First letter of country: " + firstLetterOfCountry);

            char firstLetterOfCity = city[0];
            char lastLetterOfCity = city[city.Length - 1];
            Console.WriteLine("First and last letters of city: " + firstLetterOfCity + lastLetterOfCity);

            int positionOfLetterC = landmark.IndexOf('c');
            if (positionOfLetterC >= 0)
            {
                string partOfLandmarkFromC = landmark.Substring(positionOfLetterC);
                Console.WriteLine("Part of landmark from 'c': " + partOfLandmarkFromC);
            }

            int positionOfLetterS = country.IndexOf('S');
            int positionOfLetterA = country.IndexOf('A', positionOfLetterS);
            if (positionOfLetterS >= 0 && positionOfLetterA >= 0)
            {
                string partOfCountryFromSToA = country.Substring(positionOfLetterS, positionOfLetterA - positionOfLetterS + 1);
                Console.WriteLine("Part of country from 'S' to 'A': " + partOfCountryFromSToA);
            }

            int f = state.IndexOf('f');
            Console.WriteLine("Position of 'f' in California: " + f);

            Console.ReadLine();
        }
    }
}

// output the length of state

// Concatenate the contents of city and landmark * don't forget to add a space

// output the first character of county

// output a concatenation of the first and last characters of city

// output the substring of landmark starting at c and outputting to the end

// output the substring of country starting at the first S and ending at the first A

// output the position of f in California

//************CHALLENGE****************//
// Output how many vowels are in each of the strings in the format
// California has n vowels




// Show your evidence of the program running in the Readme file
