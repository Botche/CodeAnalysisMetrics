namespace P02_LongParameterList
{
	public class RefactoredCode
	{
		public class Rectangle
		{
			public Rectangle(Point pointA, Point pointB)
			{
				this.PointA = pointA;
				this.PointB = pointB;
			}

			public Point PointA { get; }

			public Point PointB { get; }
		}

		public class Triangle
		{
			public Triangle(Point pointA, Point pointB, Point pointC)
			{
				this.PointA = pointA;
				this.PointB = pointB;
				this.PointC = pointC;
			}

			public Point PointA { get; }

			public Point PointB { get; }

			public Point PointC { get; }
		}

		public class Point
		{
			public Point(double x, double y)
			{
				this.X = x;
				this.Y = y;
			}

			public double X { get; }

			public double Y { get; }
		}
	}
}
