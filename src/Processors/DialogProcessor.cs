using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
        Random rnd = new Random();

        #region Constructor

        public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Избран елемент.
		/// </summary>
		private Shape selection;
		public Shape Selection {
			get { return selection; }
			set { selection = value; }
		}

		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}

		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}

		#endregion

		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 200, 100));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}

		public void AddSquare()
		{
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape square = new RectangleShape(new Rectangle(x, y, 150, 150));
			square.FillColor = Color.White;

			ShapeList.Add(square);
		}

		public void AddEllipse()
		{
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 350, 150));
			ellipse.FillColor = Color.White;

			ShapeList.Add(ellipse);
		}

		public void AddCicle()
		{
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape cicle = new EllipseShape(new Rectangle(x, y, 150, 150));
			cicle.FillColor = Color.White;

			ShapeList.Add(cicle);
		}

		public void AddTriangle()
		{
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape triangle = new TriangleShape(new RectangleF(x, y, 200, 200));
            triangle.FillColor = Color.White;

            ShapeList.Add(triangle);
        }

		public void GroupShapes(PointF p)
		{
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
                    shape.Group = true;
                }
            }
        }

		public void UnGroupShape(PointF p)
		{
			foreach(Shape shape in ShapeList)
			{
				if(shape.Contains(p))
				{
                    shape.Group = false;
                }
			}
		}

		public	void ColorShapeBlue(PointF p)
		{
			foreach (Shape shape in ShapeList)
			{
				if (shape.Contains(p))
				{
					shape.FillColor = Color.Blue;
				}
			}

		}

        public void ColorShapePink(PointF p)
        {
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
                    shape.FillColor = Color.Pink;
                }
            }
        }

        public void ColorShapeRed(PointF p)
        {
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
                    shape.FillColor = Color.Red;
                }
            }
        }

        public void ColorShapeRandom(PointF p)
        {
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
					Random random = new Random();
                    shape.FillColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
        }

        public void DoShapeSmaller(PointF p)
        {
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
					shape.Height -= 20;
					shape.Width -= 20;
                }
            }
        }

        public void DoShapeBigger(PointF p)
        {
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
                    shape.Height += 20;
                    shape.Width += 20;
                }
            }
        }

		public void DoShapeTransparent(PointF p)
		{
            foreach (Shape shape in ShapeList)
            {
                if (shape.Contains(p))
                {
                    shape.FillColor = Color.FromArgb(100, shape.FillColor);
                }
            }
        }

		public void DeleteShape(PointF p)
		{
			int count = ShapeList.Count;
			while (count > 0)
			{
                if (ShapeList[count-1].Contains(p))
                {
                    ShapeList.Remove(ShapeList[count - 1]);
                }
				count--;
            }
        }

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
						
					return ShapeList[i];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{


			if (selection.Group)
			{
				foreach (Shape shape in ShapeList)
				{
					if (shape.Group)
					{
						shape.Location = new PointF(shape.Location.X + p.X - lastLocation.X, shape.Location.Y + p.Y - lastLocation.Y);
					}
				}
			}
			else
			{
				if (selection != null)
				{
					selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
				}
			}
                lastLocation = p;
		}
	}
}
