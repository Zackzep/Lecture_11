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

namespace Lecture_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassRoster prog122 = new ClassRoster();
        ClassRoster prog124= new ClassRoster();
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayStudents();
        }
        //IEnumerable
        public void DisplayStudents()
        {
            lbStudents.Items.Clear();
            foreach (Student student in prog122)
            {
                lbStudents.Items.Add(student);
            }

        }
        public void Preload()
        {
            prog124.AddStudent(new Student("Dylan", "Register", 100, 100));
            prog124.AddStudent(new Student("Zack", "Zep", 101, 105));
            prog124.AddStudent(new Student("Bander", "Salah", 100, 100));
            prog124.AddStudent(new Student("Sulemen", "Seid", 100, 100));
            prog124.AddStudent(new Student("Anne", "Nguyen", 100, 100));

            prog122.AddStudent(new Student("Jon", "Reed", 100, 100));
            prog122.AddStudent(new Student("Hanna", "Angel", 100, 100));
            prog122.AddStudent(new Student("Krystin", "Taniguchi", 100, 100));


        }
        public void InterfaceExample()
        {
            Door door = new Door();
            Bottle bottle = new Bottle();
            Chest chest = new Chest();

            List<IOpen> openableItems = new List<IOpen>();
            openableItems.Add(door);
            openableItems.Add(bottle);
            openableItems.Add(chest);
            openableItems[0].Open();
        }
    }
}
