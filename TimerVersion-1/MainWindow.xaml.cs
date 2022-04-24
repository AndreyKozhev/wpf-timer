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
using System.Windows.Threading;

namespace TimerVersion_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Создание переменных
        int sec = 0;
        bool started = false;
        //Главный класс окна
        public MainWindow()
        {
            InitializeComponent();
        }
        //Создание таймера
        DispatcherTimer second_timer = new DispatcherTimer();
        private void timerStart()
        {
            sec = 0;
            started = true;
            second_timer.Start();
        }
        private void timerStop()
        {
            second_timer.Stop();
            started = false;
            sec = 0;
        }
        private void timerTick(object sender, EventArgs e)
        {
            sec++;
            second.Text = sec.ToString();
            Console.WriteLine(sec);
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button click");
            if (started)
            {
                timerStop();
                start.Content = "ПУСК";
                second.Text = "Нажми кнопку ПУСК";
            }
            else
            {
                timerStart();
                start.Content = "СТОП";
                second.Text = "0";
            }
        }
        private void Window_Initialized(object sender, EventArgs e)
        {
            second_timer.Tick += new EventHandler(timerTick);
            second_timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            Console.WriteLine("Welcome");
            Console.WriteLine("Version: 1.0");
        }
    }
}
