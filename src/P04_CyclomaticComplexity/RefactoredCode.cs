namespace P04_CyclomaticComplexity
{
	using System;

	public class RefactoredCode
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
				FullEmployeeName(employee);

				GetCompleteAddress(employee);

				IsValidEmail(employee);

				GetPhone(employee);
			}
		}

		private static void GetPhone(Employee employee)
		{
			if (string.IsNullOrWhiteSpace(employee.Phone))
			{
				//Do Something  
			}
		}

		private static void IsValidEmail(Employee employee)
		{
			if (string.IsNullOrWhiteSpace(employee.Email))
			{
				//Check Valid Email..Regex check  
			}
		}

		private static void GetCompleteAddress(Employee employee)
		{
			if (string.IsNullOrWhiteSpace(employee.Address1) && string.IsNullOrWhiteSpace(employee.Address2) &&
			string.IsNullOrWhiteSpace(employee.Address3) && string.IsNullOrWhiteSpace(employee.City) &&
			string.IsNullOrWhiteSpace(employee.Country) && string.IsNullOrWhiteSpace(employee.ZipCode))
			{
				//Build complete address  
			}
		}

		private static void FullEmployeeName(Employee employee)
		{
			if (string.IsNullOrWhiteSpace(employee.FirstName) && string.IsNullOrWhiteSpace(employee.LastName))
			{
				//Build full name  
			}
		}
	}
}
