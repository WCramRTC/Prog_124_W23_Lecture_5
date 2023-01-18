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
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_5.Sample
{
    /// <summary>
    /// Interaction logic for In_Class_Lecture.xaml
    /// </summary>
    public partial class In_Class_Lecture : Window
    {
        public In_Class_Lecture()
        {
            InitializeComponent();

            CheckingAccount ca = new CheckingAccount("12345", 123.54);

            
            
        }
    }
}
