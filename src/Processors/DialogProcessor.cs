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
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}

        public void AddSquare()
        {

            RectangleShape square = new RectangleShape(new Rectangle(105, 155, 150, 150));
            square.FillColor = Color.White;
			
            ShapeList.Add(square);
        }

        public void AddEllipse()
        {

			EllipseShape ellipse = new EllipseShape(new Rectangle(105, 155, 350, 150));
			ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

        public void AddCicle()
        {

            EllipseShape cicle = new EllipseShape(new Rectangle(105, 155, 150, 150));
            cicle.FillColor = Color.White;

            ShapeList.Add(cicle);	
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
			while (ShapeList.Count > 0)
			{
                if (ShapeList[count - 1].Contains(p))
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
			if (selection != null) {
				selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
				lastLocation = p;
			}
		}
	}
}
