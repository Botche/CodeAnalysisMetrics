namespace P01_DataClumps
{
	public class ProblematicCode
	{
		public class Rectangle
		{
			public Rectangle(double x1, double y1, double x2, double y2)
			{
				this.X1 = x1;
				this.Y1 = y1;

				this.X2 = x2;
				this.Y2 = y2;
			}

			public double X1 { get; }

			public double Y1 { get; }

			public double X2 { get; }

			public double Y2 { get; }
		}

		public class Triangle
		{
			public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
			{
				this.X1 = x1;
				this.Y1 = y1;

				this.X2 = x2;
				this.Y2 = y2;

				this.X3 = x3;
				this.Y3 = y3;
			}

			public double X1 { get; }

			public double Y1 { get; }

			public double X2 { get; }

			public double Y2 { get; }

			public double X3 { get; }

			public double Y3 { get; }
		}
	}
}
