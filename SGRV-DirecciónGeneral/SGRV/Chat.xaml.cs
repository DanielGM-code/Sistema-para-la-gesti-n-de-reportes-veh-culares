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
using System.Windows.Shapes;

namespace SGRV
{
    /// <summary>
    /// Lógica de interacción para Chat.xaml
    /// </summary>
    public partial class Chat : Window
    {
        public Chat()
        {
            InitializeComponent();
            gridChat.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            Label label = new Label();
            label.Height = 25;
            label.VerticalAlignment = VerticalAlignment.Top;
            label.Content = "Hola";
            Grid.SetColumn(label, 0);
            Grid.SetRow(label, 0);
            gridChat.Children.Add(label);

            gridChat.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            Label label1 = new Label();
            label1.Content = "Hola2\n¿Cómo estás?";
            label1.Height = 100;
            label1.Background = Brushes.Red;
            label1.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetColumn(label1, 0);
            Grid.SetRow(label1, 1);
            gridChat.Children.Add(label1);

        }
    }
}
