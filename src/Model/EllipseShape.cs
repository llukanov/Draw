using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът елипса е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(EllipseShape ellipse) : base(ellipse)
        {
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към елипсата.
        /// </summary>
        public override bool Contains(PointF point)
        {
            // Нормализиране на координатите спрямо елипсата
            float dx = point.X - (Rectangle.X + Rectangle.Width / 2);
            float dy = point.Y - (Rectangle.Y + Rectangle.Height / 2);

            float rx = Rectangle.Width / 2;
            float ry = Rectangle.Height / 2;

            // Уравнение на елипса: (x^2 / rx^2) + (y^2 / ry^2) <= 1
            return ((dx * dx) / (rx * rx) + (dy * dy) / (ry * ry)) <= 1;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
