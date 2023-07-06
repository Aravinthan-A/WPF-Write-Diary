using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using PageScreen.Dairy;

namespace PageScreen.Main
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
       // Name oname;
       // Content ocontent;
        public Create()
        {
            InitializeComponent();
           // oname = new Name();
            Content  content= new Content();
            frmfirst.Content = content;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ocontent = new Content();
            //frmsecond.Content = ocontent;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmfirst.GoBack();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frmfirst.GoForward();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Content = new Content();
            frmfirst.Content = Content;
        }
    }
}
