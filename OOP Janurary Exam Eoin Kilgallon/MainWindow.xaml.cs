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

namespace OOP_Janurary_Exam_Eoin_Kilgallon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  

    /// Link to Github - https://github.com/s00223854/OOP-Janurary-Exam-Eoin-Kilgallon
    public partial class MainWindow : Window
    {
       
        //teams
        Team t1 = new Team() { TeamName = "France" };
        Team t2 = new Team() { TeamName = "Italy" };
        Team t3 = new Team() { TeamName = "Spain" };


        //French players
        Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
        Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
        Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

        //Italian players
        Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
        Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
        Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

        //Spanish players
        Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
        Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
        Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //displaying teams

            List<Team> AllTeams = new List<Team>();

            AllTeams.Add(t1);
            AllTeams.Add(t2);
            AllTeams.Add(t3);

            LbxTeams.ItemsSource = AllTeams;
            
            //Adding players to teams
            List<Player> FrenchPlayers = new List<Player>();

            FrenchPlayers.Add(p1);
            FrenchPlayers.Add(p2);
            FrenchPlayers.Add(p3);

            List<Player> ItalianPlayers = new List<Player>();

            ItalianPlayers.Add(p4);
            ItalianPlayers.Add(p5);
            ItalianPlayers.Add(p6);

            List<Player> SpanishPlayers = new List<Player>();

            SpanishPlayers.Add(p7);
            SpanishPlayers.Add(p8);
            SpanishPlayers.Add(p9);


            //displaying players
           

            if (LbxPlayers.SelectedItem == t1)
            {
                LbxPlayers.ItemsSource = FrenchPlayers;
            }

        }

        
    }
}
