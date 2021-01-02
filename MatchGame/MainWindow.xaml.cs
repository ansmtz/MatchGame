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
    /// Логика взаимодействия для MainWindow.xaml
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
            // список с 8 парами
            List<string> emojis = new List<string>()
            {
                "🍕", "🍕",
                "🍔","🍔",
                "🌭","🌭",
                "🍿","🍿",
                "🥓","🥓",
                "🥚","🥚",
                "🥨","🥨",
                "🧀","🧀"

            };
            // новый объект генератора чисел
            Random random = new Random();
            // для каждого текстового блока в сетке с текстовыми блоками
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                // сгенерить число int ограниченное числом элментов в списке
                int index = random.Next(emojis.Count);
                // взять случайный emoji из списка
                string nextEmoji = emojis[index];
                // и прописать в тектовый блок
                textBlock.Text = nextEmoji;
                // удалить случаный emoji из списка
                emojis.RemoveAt(index);
            }
            // таким образом, допустим что при первой итерации index = 2
            // тогда nextEmoji = emojis[2] = "🍔"
            // нулевая колонка и нулевой ряд будут иметь значение "🍔"
            // список станет короче на 1 элемент
            // так до тех пор пока не закончится число ячеек, равное числу элементов
            // в списке
        }
    }
}
