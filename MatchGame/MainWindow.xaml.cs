using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🦕","🦕",
                "🦖","🦖",
                "🦦","🦦",
                "🦈","🦈",
                "🐊","🐊",
                "🐢","🐢",
                "🐍","🐍",
                "🐇","🐇",
            };
            Random random = new Random();
            // перебираем ячейки сетки и вставляем в них случайную картинку
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                // Берем случайный индекс в диапазоне длинны списка картинок
                int index = random.Next(animalEmoji.Count);
                // выбираем картинку по получивщемуся индексу
                string nextEmoji = animalEmoji[index];
                // вставляем картинку в ячейку
                textBlock.Text = nextEmoji;
                // Удаляем ячейку с индексом
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
