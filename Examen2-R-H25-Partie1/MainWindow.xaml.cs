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

namespace Examen2_R_H25_Partie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employe> les_employes;

        public MainWindow()
        {
            InitializeComponent();
            les_employes = new List<Employe>() {
                new Employe("12345", "Smith", "Bob", "819-555-5555", "2222", "bob.smith@cegep.com", (float)45.50),
                new Employe("12346", "Tremblay", "Ginette", "819-555-5555", "1122", "ginette.tremblay@cegep.com", 60)
            };
            // TODO : Afficher la liste d'employés
        }

        // TODO : Gérer le bouton Ajouter pour qu'il ajoute un employé dans la liste
        // le nouvel employé doit aussi s'afficher dans la ListBox sur l'interface.
    }
}
