using System;

namespace UnitProject2.Models
{
    public class Birthdate
    {
        public DateTime BirthDate { get; set; }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
