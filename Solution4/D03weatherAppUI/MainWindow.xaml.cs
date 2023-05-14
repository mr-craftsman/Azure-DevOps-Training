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

namespace D03weatherAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// double click on button on designer to create this new method
    /// this is a different Weather Manager than in .Net
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // method created by double click i UI design window XAML
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cities = txtCityName.Text;
            WeatherManager weatherManager = new WeatherManager();

            string[] citiesArray = cities.Split("\n");
            txtLogs.Text = "";
            txtTemperature.Text = "";
            try
            {
                foreach (var city in citiesArray)
                {
                    int temperature = weatherManager.GetTemperature(city);
                    txtLogs.Text += $"Processing city {city}\n";
                    txtTemperature.Text += $"Temperature in city {city} is {temperature.ToString()}\n";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Input cannot be processed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            


        }
        // async
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string cities = txtCityName.Text;
            WeatherManager weatherManager = new WeatherManager();

            string[] citiesArray = cities.Split("\n");
            txtLogs.Text = "";
            txtTemperature.Text = "";
            try
            {
                foreach (var city in citiesArray)
                {
                    //int temperature = weatherManager.GetTemperature(city);
                    var t = Task.Run(() => weatherManager.GetTemperature(city));

                    t.GetAwaiter().OnCompleted(() =>
                    {
                        txtTemperature.Text += $"Temperature in city {city} is {t.Result.ToString()}\n";
                    });

                    txtLogs.Text += $"Processing city {city}\n";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Input cannot be processed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

                
            }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string cities = txtCityName.Text;
            WeatherManager wm = new WeatherManager();

            string[] citiesArray = cities.Split("\n");

            txtLogs.Text = "";
            txtTemperature.Text = "";

            try
            {
                foreach (var city in citiesArray)
                {
                    // int temp = wm.GetTemperature(city);
                    txtLogs.Text += $"Processing city {city}\n";

                    int t = await Task.Run(() => wm.GetTemperature(city));

                    txtTemperature.Text += $"Temperature in city {city} is {t}\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("We cannot process your data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
    
}
