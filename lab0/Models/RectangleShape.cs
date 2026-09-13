using lab0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0.Models
{
    public class RectangleShape
    {
        public Point2D StartPoint { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public RectangleShape(Point2D startPoint, int width, int height)
        {
            StartPoint = startPoint;
            Width = width;
            Height = height;
        }

        public Point2D P1
        {
            get
            {
                return new Point2D(
                    StartPoint.X,
                    StartPoint.Y);
            }
        }

        public Point2D P2
        {
            get
            {
                return new Point2D(
                    StartPoint.X + Width,
                    StartPoint.Y);
            }
        }

        public Point2D P3
        {
            get
            {
                return new Point2D(
                    StartPoint.X + Width,
                    StartPoint.Y + Height);
            }
        }

        public Point2D P4
        {
            get
            {
                return new Point2D(
                    StartPoint.X,
                    StartPoint.Y + Height);
            }
        }

        public void AddX(int x)
        {
            StartPoint.AddX(x);
        }

        public void AddY(int y)
        {
            StartPoint.AddY(y);
        }
    }
}
