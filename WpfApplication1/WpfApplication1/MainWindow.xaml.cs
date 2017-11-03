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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();

           Page0 page0 = new Page0();
           frame1.Navigate(page0);
          
            page0.ViewTrainer.Click += new RoutedEventHandler(ViewTrainerFucntion);
           page0.ViewQuestion.Click += new RoutedEventHandler(ViewQuestionFucntion);
            page0.Validation.Click += new RoutedEventHandler(ValidationFunction);

        }
        private void ViewTrainerFucntion(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
           frame1.Navigate(page1); 
        }
            private void ViewQuestionFucntion(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
           frame1.Navigate(page2); 
         }
        private void ValidationFunction(object sender, RoutedEventArgs e)
        {
            Page3 page3 = new Page3();
           frame1.Navigate(page3); }


    }
    
    
    }



