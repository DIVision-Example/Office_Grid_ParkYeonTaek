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
            
            List<Data> list = new List<Data>();
            list.Add(new Data {name = "office1", xx=100, yy=100, area = 10000, tile=10 });
            list.Add(new Data { name = "office2", xx = 200, yy = 200, area = 40000, tile = 40 });
            list.Add(new Data { name = "office3", xx = 300, yy = 300, area = 90000, tile = 90 });

        }

    }
    public class Data 
    {
        public string name { get; set; }
        public double xx { get; set; }
        public double yy { get; set; }  
        public double area { get; set; }    
        public int tile { get; set; }
    }
}