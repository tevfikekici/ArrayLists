using System;
using System.Collections;
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

namespace ArrayLists
{
    

    /* MOST COMMON ARRAYLIST METHODS */

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ArrayList names = new ArrayList();
        ArrayList secondNames = new ArrayList();
        ArrayList thirdNames = new ArrayList();
        private void button_Click(object sender, RoutedEventArgs e)
        {

            names.Add("Adam");
            names.Add("Bella");
            names.Add("Clara");
            names.Add("David");
            names.Add("Ewa");
            names.Add("Gerorge");
            names.Add("Hans");
            names.Add("Ivona");
            names.Add("John");
            names.Add("Kenny");
            names.Add("Maria");
            names.Add("Nadia");

            names.Insert(2, "Xavier"); // insert item into given index

            foreach (var item in names)
            {
                listBox.Items.Add(item);
            }

            MessageBox.Show("List count: " + names.Count); // count list items
        }

        private void button_Sort_Click(object sender, RoutedEventArgs e)
        {
            names.Sort(); // sort the list from min to max / A to Z

            names.Remove("Adam"); // remove given value
            names.RemoveAt(names.Count - 1); // remove from given index number (last index here)

            listBox.Items.Clear();

            foreach (var item in names)
            {
                listBox.Items.Add(item);
            }

            names.Reverse(); // reverse the list
        }

        private void button_Range_Click(object sender, RoutedEventArgs e)
        {
            secondNames = names.GetRange(0, 3); // add a given part of an arraylist into another

            secondNames.AddRange(names); // add an arraylist into another

            secondNames.InsertRange(4, names); // add an arraylist into another starting from a given index

            secondNames.RemoveRange(0, 2); // remove from given index in given amount

            thirdNames = (ArrayList)secondNames.Clone();

            string[] newArray = (string[])thirdNames.ToArray(typeof(string)); // create new array with copying data of an arraylist

            foreach (var item in thirdNames)
            {
                listBox_1.Items.Add(item);
            }
        }
    }
}
