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
    /// Interaction logic for MainWindow.xaml  1123ewete홍길동
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            List<Office> list = new List<Office>();
            list.Add(new Office { name = "office1", width=100, area = 10000, tile=10, myRectange = Office1 });
            list.Add(new Office { name = "office2", width = 200, area = 40000, tile = 40, myRectange = Office2});
            list.Add(new Office { name = "office3", width = 300, area = 90000, tile = 90, myRectange = Office3});

            OfficeList.ItemsSource = list;
        }

    }
    public class Office 
    {
        public string name { get; set; }
        public double height
        {
            get
            {
                return myRectange.Height;
            }
         
        }
        public double width { get; set; }  
        public double area { get; set; }    
        public int tile { get; set; }

        public Rectangle myRectange;
    }
}