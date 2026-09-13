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

        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}