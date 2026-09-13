using lab0.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab0
{
    public partial class MainWindow : Window
    {
        private readonly Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void DrawLine(Point2D p1, Point2D p2)
        {
            Line line = new Line();

            line.Stroke = Brushes.Red;
            line.StrokeThickness = 3;

            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;

            Scene.Children.Add(line);
        }

        public void DrawTriangle(Triangle triangle)
        {
            DrawLine(triangle.P1, triangle.P2);
            DrawLine(triangle.P2, triangle.P3);
            DrawLine(triangle.P3, triangle.P1);
        }

        public void ClearScene()
        {
            Scene.Children.Clear();
        }
        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            Point2D p1 = new Point2D(
                rnd.Next(20, (int)Scene.ActualWidth - 20),
                rnd.Next(20, (int)Scene.ActualHeight - 20));

            Point2D p2 = new Point2D(
                rnd.Next(20, (int)Scene.ActualWidth - 20),
                rnd.Next(20, (int)Scene.ActualHeight - 20));

            Point2D p3 = new Point2D(
                rnd.Next(20, (int)Scene.ActualWidth - 20),
                rnd.Next(20, (int)Scene.ActualHeight - 20));

            Triangle triangle = new Triangle(p1, p2, p3);

            DrawTriangle(triangle);
        }

        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            int width = rnd.Next(100, 300);
            int height = rnd.Next(100, 250);

            int x = rnd.Next(20, Math.Max(21, (int)Scene.ActualWidth - width));
            int y = rnd.Next(20, Math.Max(21, (int)Scene.ActualHeight - height));

            Point2D startPoint = new Point2D(x, y);

            RectangleShape rectangle =
                new RectangleShape(startPoint, width, height);

            DrawRectangle(rectangle);
        }

        public void DrawRectangle(RectangleShape rectangle)
        {
            DrawLine(rectangle.P1, rectangle.P2);
            DrawLine(rectangle.P2, rectangle.P3);
            DrawLine(rectangle.P3, rectangle.P4);
            DrawLine(rectangle.P4, rectangle.P1);
        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            int size = rnd.Next(100, 250);

            int x = rnd.Next(20, Math.Max(21, (int)Scene.ActualWidth - size));
            int y = rnd.Next(20, Math.Max(21, (int)Scene.ActualHeight - size));

            Point2D startPoint = new Point2D(x, y);

            RectangleShape square =
                new RectangleShape(startPoint, size, size);

            DrawRectangle(square);
        }

        private void CustomSquareButton_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            if (!int.TryParse(XInput.Text, out int x))
                return;

            if (!int.TryParse(YInput.Text, out int y))
                return;

            if (!int.TryParse(SizeInput.Text, out int size))
                return;

            Point2D startPoint = new Point2D(x, y);

            RectangleShape square =
                new RectangleShape(startPoint, size, size);

            DrawRectangle(square);
        }

        private void CustomTriangleButton_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            if (!int.TryParse(XInput.Text, out int x))
                return;

            if (!int.TryParse(YInput.Text, out int y))
                return;

            if (!int.TryParse(SizeInput.Text, out int size))
                return;

            Point2D p1 = new Point2D(x, y);
            Point2D p2 = new Point2D(x + size, y);
            Point2D p3 = new Point2D(x + size / 2, y - size);

            Triangle triangle = new Triangle(p1, p2, p3);

            DrawTriangle(triangle);
        }
    }
}