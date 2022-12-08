using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using Figures;
using Rectangle = Figures.Rectangle;

namespace Pr8v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. \r\nСоздать интерфейс – фигура (площадь, периметр). \r\nСоздать классы -" +
                "прямоугольник, круг. \r\nКлассы должны включать конструкторы, функцию для" +
                "\r\nформирования строки информации о фигуре. \r\nСравнение производить по площади.",
             "Разработчик:Десятов",
             MessageBoxButton.OK,
             MessageBoxImage.Information);
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка расчета периметра и площади прямоугольника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRectanglResult_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                Rectangle rectangle = new Rectangle(Convert.ToDouble(txtBoxRectangleSideA.Text), Convert.ToDouble(txtBoxRectangleSideB.Text));

                //Вывод периметра прямоугольника
                int perimetrResR = (int)rectangle.Perimetr();
                txtBoxRectanglPerimetr.Text = Convert.ToString(perimetrResR);

                //Вывод площади прямоугольника
                int squareResR = (int)rectangle.Square();
                txtBoxRectangleSquare.Text = Convert.ToString(squareResR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///  Кнопка расчета периметра и площади круга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCircleResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Circle circle = new Circle(Convert.ToDouble(txtBoxCircleRadius.Text));

                //Вывод периметра круга
                int perimetrResC = (int)circle.Perimetr();
                txtBoxCirclePerimetr.Text = Convert.ToString(perimetrResC);

                //Вывод площади круга
                int squareResC = (int)circle.Square();
                txtBoxCircleSquare.Text = Convert.ToString(squareResC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Очистить все поля, связанные с прямоугольником
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRectanglClear_Click(object sender, RoutedEventArgs e)
        {
            txtBoxRectangleSideA.Clear();
            txtBoxRectangleSideB.Clear();
            txtBoxRectanglPerimetr.Clear();
            txtBoxRectangleSquare.Clear();
        }

        /// <summary>
        /// Очистить все поля, связанные с кругом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCircleClear_Click(object sender, RoutedEventArgs e)
        {
            txtBoxCircleRadius.Clear();
            txtBoxCirclePerimetr.Clear();
            txtBoxCircleSquare.Clear();
        }

        /// <summary>
        /// Сравнение фигур по площади
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiguresCompare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int squareCompare = (Convert.ToDouble(txtBoxRectangleSquare.Text).CompareTo(Convert.ToDouble(txtBoxCircleSquare.Text)));
                if (squareCompare == 1) MessageBox.Show("Прямоугольник больше круга");
                if (squareCompare == -1) MessageBox.Show("Круг больше прямоугольника");
                if (squareCompare == 0) MessageBox.Show("Прямоугольник и круг равны");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Очистить поля: периметр и площадь (прямоугольника) при изменении поля: сторона а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxRectangleSideA_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBoxRectangleSquare.Clear();
            txtBoxRectanglPerimetr.Clear();
        }

        /// <summary>
        /// Очистить поля: периметр и площадь (прямоугольника) при изменении поля: сторона б
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxRectangleSideB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBoxRectangleSquare.Clear();
            txtBoxRectanglPerimetr.Clear();
        }

        /// <summary>
        /// Очистить поля: периметр и площадь (круга) при изменении поля: радиус
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxCircleRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBoxCircleSquare.Clear();
            txtBoxCirclePerimetr.Clear();
        }

        private void btnFiguresClon_Click(object sender, RoutedEventArgs e)
        {
            Circle c = new Circle(Convert.ToDouble(txtBoxCircleRadius.Text));
            //c.Clone();
            txtBoxCircleRadius2.Text = c.Clone().ToString();
        }
    }
}
