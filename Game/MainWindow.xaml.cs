using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Game {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        ObservableCollection<Player> Players = new ObservableCollection<Player>();

        public MainWindow() {
            InitializeComponent();
            
            playerList.ItemsSource = Players;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            if (Players.Count > 1) {

                var window1 = new Window1(Players.ToList());
                window1.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Der er ikke nok spillere. ");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        //public string SetName(string Name) {
        //    string Number;
        //    string FullName;
        //    int i = 1;
        //    if ( i > 0; i++;) {
        //        Number = i.ToString();
        //        FullName = "Player" + Number +": " + Name;
        //        PlayerOne.Text = FullName;
        //    }
        //    return FullName; //skal returne navnet på spilleren
        //}
        

        private void Button_Click_2(object sender, RoutedEventArgs e) {
           
            if(name.Text != null) {
                Players.Add(new Player() { Name = name.Text, Number = Players.Count + 1 });
            }


        }
    }
}
