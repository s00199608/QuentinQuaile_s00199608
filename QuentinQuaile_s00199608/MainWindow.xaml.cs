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
        static GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
            var query = from games in db.Games
                        select games;

            GameBox.ItemsSource = query.ToList();
                        
        }
    }
}
