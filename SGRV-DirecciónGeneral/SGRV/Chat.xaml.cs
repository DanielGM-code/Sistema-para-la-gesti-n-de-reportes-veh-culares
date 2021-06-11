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
            label.Content = "Angel";
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


            gridChat.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            Label label2 = new Label();
            label2.Content = "Daniel";
            label2.Height = 25;
            label2.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetColumn(label2, 1);
            Grid.SetRow(label2, 2);
            gridChat.Children.Add(label2);
            
            gridChat.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            Label label3 = new Label();
            label3.Content = "Muy bien.\n¿Y tú?";
            label3.Height = 100;
            label3.Background = Brushes.Blue;
            label3.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetColumn(label3, 1);
            Grid.SetRow(label3, 3);
            gridChat.Children.Add(label3);


            int i = 3;
            Label label32 = new Label();
            for (i = 4; i<7; i++)
            {
                gridChat.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
                label32= new Label();
                label32.Content = "Muy bien.\n¿Y tú?" + i;
                label32.Height = 100;
                label32.Background = Brushes.Blue;
                label32.VerticalAlignment = VerticalAlignment.Top;
                Grid.SetColumn(label32, 1);
                Grid.SetRow(label32, i);
                gridChat.Children.Add(label32);
                MessageBox.Show(i.ToString());
            }

        }
    }
}
