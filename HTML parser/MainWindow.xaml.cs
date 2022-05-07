using HTML_parser.Core;
using HTML_parser.Core.Habr;
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


namespace HTML_parser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ParserWorker<string[]> Parser;
        public MainWindow()
        {
            InitializeComponent();
            Parser = new ParserWorker<string[]>(
                new HabrParser()
                );
            Parser.OnCompleted += Parser_OnCompleted;
            Parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            foreach(var item in arg2)
            ListBox1.Items.Add(item);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All work done!");
        }

        private void Sart_Click(object sender, RoutedEventArgs e)
        {
            Parser.Settings = new HabrSettings(int.Parse(TextBox1.Text),
                                               int.Parse(TextBox2.Text));
           
            Parser.Start();
        }

        private void Abort_Click(object sender, RoutedEventArgs e)
        {
            Parser.Abort();
        }

        private void List1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
