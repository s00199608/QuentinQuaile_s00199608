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

namespace QuentinQuaile_s00199608
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    

    public partial class MainWindow : Window
    {
        List<Game> GameList = new List<Game>();
        List<Game> FilterGameList = new List<Game>();
        static GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
            var query = from games in db.Games
                        select games;

            GameList = query.ToList();
            GameBox.ItemsSource = GameList;
                        
        }

        private void GameBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selected = GameBox.SelectedItem as Game;

            if(selected != null)
            {
                DescriptionBlock.Text = selected.Description;

                GamerImage.Source = new BitmapImage(new Uri(selected.GameImage, UriKind.Relative));
            }
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            GameBox.ItemsSource = null;
            GameBox.ItemsSource = GameList;
        }

        private void radioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
            FilterGameList = null;

            var query = from games in db.Games
                        where games.Platform.Contains("Xbox")
                        select games;

            FilterGameList = query.ToList();

            GameBox.ItemsSource = null;
            GameBox.ItemsSource = FilterGameList;
        }

        private void radioButton_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            FilterGameList = null;

            var query = from games in db.Games
                        where games.Platform.Contains("PS")
                        select games;
            FilterGameList = query.ToList();

            GameBox.ItemsSource = null;
            GameBox.ItemsSource = FilterGameList;
        }

        private void radioButton_Copy2_Checked(object sender, RoutedEventArgs e)
        {
            FilterGameList = null;

            var query = from games in db.Games
                        where games.Platform.Contains("PC")
                        select games;
            FilterGameList = query.ToList();

            GameBox.ItemsSource = null;
            GameBox.ItemsSource = FilterGameList;
        }
    }
}
