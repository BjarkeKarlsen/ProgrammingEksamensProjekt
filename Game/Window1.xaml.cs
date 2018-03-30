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
using System.Windows.Shapes;

namespace Game {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        private int ActivePlayer = 0;
        
        public Window1() {
            InitializeComponent();
        }

        public Window1(Object data):this() {
            Players = (dynamic)data;
            PlayerTurn.Text = "Player " + Players[ActivePlayer].Number + ": " + Players[ActivePlayer].Name; 
        }
        List<Player> Players { get; set; }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
            //kald metode onload
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //kald metode når der clikkes
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            //kald metode når der clikkes
        }
        /* public List<Grundstof> GetAllMolarMasses() {
             var List = new List<Grundstof>();
             */



        /* 
        public List<Spoergsmål> GetAllQuestions() {
            var List = new List<spoersmål>();
           using (var sr = new StreamReader("../../¨spørgsmål.txt")) {
               List.Add(
                        new Grundstof()
                        {
                            Number = int.Parse(line.Substring(0, line.IndexOf(','))),
                            Name = line.Substring(line.IndexOf(' ') + 1)
                        });
                }
            }
            return List;
        }   
        
            public string CalculateMolarMass(string reactants) {
            //Lav liste, der skriver hvert nummer på der har været
                  Random rnd = new Random();                                // hvordan den skal udvælge spørgsmålet
            int dice = rnd.Next(1, Number.Length);
            if (dice != //listen ) {                                        // husk den skal også finde et spørgsmål, hvis den ikke fandt det første gang
                 var List = GetAllQuestions();

                 if (reactants.Length == 1) {
                    subs = reactants.Substring(0, 1);
                    var grundstof = List.Find(m => m.Number == subs[0].ToString());
                    tempMolarmasse = grundstof.MolarMass;
                    reactants = reactants.Substring(1);
                }
                else {
                    if (Char.IsLower(reactants[1])) { 
                        subs = reactants.Substring(0, 2);
                        var grundstof = List.Find(m => m.Number == subs[1].ToString());
                        tempMolarmasse = grundstof.MolarMass;
                        reactants = reactants.Substring(1);
                    }
                    else {
                        subs = reactants.Substring(0, 2);
                        var grundstof = List.Find(m => m.Number == subs[0].ToString());
                        tempMolarmasse = grundstof.MolarMass;
                        reactants = reactants.Substring(1);
                    }
               
                }
            }
            else
                break;
                

    } */
    }
    
}
