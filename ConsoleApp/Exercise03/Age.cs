using System;
namespace Exercise03
{
	public class Age
	{
		public int CalculateAge(DateTime dob)
		{
			var today = DateTime.Today;
			int age = today.Year - dob.Year;
            if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
                age--;
            return age;
        }
	}
}

