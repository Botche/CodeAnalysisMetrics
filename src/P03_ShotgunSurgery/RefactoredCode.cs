namespace P03_ShotgunSurgery
{
	using System;

	public class RefactoredCode
	{
		public class Account
		{
			private string type;
			private string accountNumber;
			private int amount;

			public Account(string type, string accountNumber, int amount)
			{
				this.type = type;
				this.accountNumber = accountNumber;
				this.amount = amount;
			}


			public void Debit(int debit)
			{
				if (IsAccountUnderflow())
				{
					throw new InvalidOperationException("Minimum balance should be over 500");
				}

				this.amount -= debit;
				Console.WriteLine("Now amount is" + this.amount);
			}

			public void Transfer(Account from, Account to, int cerditAmount)
			{
				if (IsAccountUnderflow())
				{
					throw new InvalidOperationException("Minimum balance should be over 500");
				}

				to.amount = this.amount + cerditAmount;
			}

			public void SendWarningMessage()
			{
				if (IsAccountUnderflow())
				{
					Console.WriteLine("Amount should be over 500");
				}
			}

			private bool IsAccountUnderflow()
			{
				bool isAccountUnderflow = this.amount <= 500;

				return isAccountUnderflow;
			}
		}

		public static void Run()
		{
			Account acc = new Account("Personal", "AC1234", 1000);
			acc.Debit(500);
			acc.SendWarningMessage();
			acc.Debit(500);
		}
	}
}
