namespace P02_LongParameterList
{
	public class ProblematicCode
	{
		public class Rectangle
		{
			public Rectangle(double x1, double y1, double x2, double y2)
			{
				this.PointA = new Point(x1, y1);
				this.PointB = new Point(x2, y2);
			}

			public Point PointA { get; }

			public Point PointB { get; }
		}

		public class Triangle
		{
			public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
			{
				this.PointA = new Point(x1, y1);
				this.PointB = new Point(x2, y2);
				this.PointC = new Point(x3, y3);
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
