namespace P04_CyclomaticComplexity
{
	public class ProblematicCode
	{
		public class Employee
		{
			public string FirstName { get; set; }

			public string LastName { get; set; }

			public string Address1 { get; set; }

			public string Address2 { get; set; }

			public string Address3 { get; set; }

			public string City { get; set; }

			public string Country { get; set; }

			public string ZipCode { get; set; }

			public string Email { get; set; }

			public string Phone { get; set; }
		}

		public static void GetFormattedEmployeeDetails(Employee employee)
		{
			if (employee != null)
			{
				if (string.IsNullOrWhiteSpace(employee.FirstName) && string.IsNullOrWhiteSpace(employee.LastName))
				{
					//Build full name  
				}

				if (string.IsNullOrWhiteSpace(employee.Address1) && string.IsNullOrWhiteSpace(employee.Address2) 
							&& string.IsNullOrWhiteSpace(employee.Address3) && string.IsNullOrWhiteSpace(employee.City) 
							&& string.IsNullOrWhiteSpace(employee.Country) && string.IsNullOrWhiteSpace(employee.ZipCode))
				{
					//Build complete address  
				}

				if (string.IsNullOrWhiteSpace(employee.Email))
				{
					//Check Valid Email..Regex check  
				}

				if (string.IsNullOrWhiteSpace(employee.Phone))
				{
					//Do Something  
				}
			}
		}
	}
}
