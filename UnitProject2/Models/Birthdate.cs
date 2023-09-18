using System;

namespace UnitProject2.Models
{
    //  Birthdates class that holds the calulate age method
    //  and does input validation the the age.
    public class Birthdate
    {
        
        public DateTime BirthDate { get; set; }


        public bool IsDateValid { get; private set; }
      

        public Birthdate()
        {
            IsDateValid = true;
        }

        // Calculate age method that  that performs the age calculation.
        // The age is calculated by subtracting the birth year from the current year,

        public int CalculateAge()
        {
            var today = DateTime.Today;

            if (BirthDate > today)
            {
                IsDateValid = false;
                
                return -1;  // Return -1 to indicate an invalid age
            }


            var age = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            //  This checks if the birthdate in the current year has passed.
            //  If it hasn't, it decrements the calculated age by 1
            //  to account for the fact that the birthday hasn't occurred yet in the current year.
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;



        }
    }
}
