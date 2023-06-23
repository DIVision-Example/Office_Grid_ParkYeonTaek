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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Office> officeList = new ObservableCollection<Office>();
        public MainWindow()
        {
            InitializeComponent();
            /*
            OfficeList.Add(new Office("Office1", Office1.ActualHeight, Office1.ActualWidth));
            OfficeList.Add(new Office("Office2", Office2.ActualHeight, Office2.ActualWidth));
            OfficeList.Add(new Office("Office3", Office3.ActualHeight, Office3.ActualWidth));
            */
            officeList.Add(new Office { name = "Office1", height = Office1.ActualHeight, width = Office1.ActualWidth });
        
        }

    }

    public class Office
    {
        public string name { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public double size { get; set; }
        /*
        public Office(string name, double height, double width)
        {
            this.name = name;
            this.height = height;
            this.width = width;

            size = height * width;
        }
        private string getName() { return name; }
        private double getHeight() { return height; }
        private double getWidth() { return width; }
        private double getSize() { return size; }
        */
    }
}