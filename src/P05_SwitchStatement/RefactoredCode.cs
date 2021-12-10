namespace P05_SwitchStatement
{
	using System.Collections.Generic;

	using P05_SwitchStatement.CommonLogic;

	public class RefactoredCode
	{
		public abstract class Bird
		{
			public static Bird Create(BirdType birdType)
			{
				switch (birdType)
				{
					case BirdType.Cardinal:
						return new Cardinal();
					case BirdType.Chickadee:
						return new Chickadee();
					case BirdType.Goldfinch:
						return new Goldfinch();
					default:
						throw new InvalidBirdTypeException();
				}
			}

			public abstract List<BirdColor> GetColors();

			public abstract List<BirdFood> GetFoods();

			public abstract BirdSizeRange GetSizeRange();
		}

		public class Cardinal : Bird
		{
			public override List<BirdColor> GetColors()
			{
				return new List<BirdColor>() { BirdColor.Black, BirdColor.Red };
			}

			public override List<BirdFood> GetFoods()
			{
				return new List<BirdFood>() { BirdFood.Insects, BirdFood.Seeds, BirdFood.Fruit };
			}

			public override BirdSizeRange GetSizeRange()
			{
				return new BirdSizeRange() { Lower = 8, Upper = 9 };
			}
		}

		public class Chickadee : Bird
		{
			public override List<BirdColor> GetColors()
			{
				return new List<BirdColor>() { BirdColor.Black, BirdColor.White, BirdColor.Tan };
			}

			public override List<BirdFood> GetFoods()
			{
				return new List<BirdFood>() { BirdFood.Insects, BirdFood.Fruit, BirdFood.Seeds };
			}

			public override BirdSizeRange GetSizeRange()
			{
				return new BirdSizeRange() { Lower = 4.75, Upper = 5.75 };
			}
		}

		public class Goldfinch : Bird
		{
			public override List<BirdColor> GetColors()
			{
				return new List<BirdColor>() { BirdColor.Black, BirdColor.Yellow, BirdColor.White };
			}

			public override List<BirdFood> GetFoods()
			{
				return new List<BirdFood>() { BirdFood.Insects, BirdFood.Seeds };
			}

			public override BirdSizeRange GetSizeRange()
			{
				return new BirdSizeRange() { Lower = 4.5, Upper = 5.5 };
			}
		}
	}
}
