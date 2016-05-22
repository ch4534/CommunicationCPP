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

namespace CommunicationCPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int i = CppInterface.retInt();

            StringBuilder retStr = new StringBuilder();

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            CppInterface.retString(ref retStr);
            stopwatch.Stop();
            TimeSpan timespan = stopwatch.Elapsed;
            double millionSecond = timespan.TotalMilliseconds;

            string str = "";
            int j = 100000;

            stopwatch.Start();
            str = CppInterface.getIntPtr();
            stopwatch.Stop();
            timespan = stopwatch.Elapsed;
            millionSecond = timespan.TotalMilliseconds;
            stopwatch.Start();
            while (j-- > 0)
            {
                str = CppInterface.getIntPtr();
            }
            stopwatch.Stop();
            timespan = stopwatch.Elapsed;
            millionSecond = timespan.TotalMilliseconds;

            MessageBox.Show(str);
        }
    }
}
