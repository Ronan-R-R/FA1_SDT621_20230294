using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(idNumber);
        }

        private int CalculateAge(string idNumber)
        {
            if (idNumber == null || idNumber.Length < 6)
                return 0;

            try
            {
                int yy = int.Parse(idNumber.Substring(0, 2));
                int mm = int.Parse(idNumber.Substring(2, 2));
                int dd = int.Parse(idNumber.Substring(4, 2));

                int currentYear = DateTime.Now.Year;
                int century = (yy <= currentYear % 100) ? 2000 : 1900;
                int birthYear = century + yy;

                DateTime birthDate = new DateTime(birthYear, mm, dd);
                int age = currentYear - birthYear;

                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return 0;
            }
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID: Must be exactly 13 digits.";

            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                    return "Invalid ID: ID number must be fully numeric.";
            }

            if (Age <= 0)
                return "Invalid ID: Could not determine a valid age from the ID number.";

            return $"Valid ID: Citizen is {Age} years old.";
        }
    }
}