using ConstrLeo;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/image001.png"));
            txtBl.Text = "здесь текст";
            ///txtBl_about.Text = "about";
        }
        private void btn_about_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            about.Owner = this;
        }




        private void lbl_hd1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtBl.Text = "Вертикальная стенка внутри корпуса судна, кроме двойного борта, разделяющая внутреннее пространство на отсеки, а также наружные стенки надстроек и рубок";
        }

        private void lbl11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/image002.png"));
            txtBl.Text = "Ограждение по краям наружной палубы судна,представляющее собой сплошную стенку без вырезов или со специальными вырезами для стока воды , швартовки (клюза) и прочими";
        }

        private void lbl12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/image003.png"));
            txtBl.Text = "Крайний лист палубного настила, идущий параллельно обводу борта.Служит для обеспечения продольной прочности.";
        }

        private void lbl13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/image004.png"));
            txtBl.Text = "Верхний пояс бортовой обшивки делается утолщенным. Угловое соединение ширстрека с палубным стрингером (крайним поясом настила палубы) усиливается палубным угольником";
        }


        private void lbl14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtBl.Text = "Поперечные связи бортового набора. На бортовом перекрытии, имением поперечную систему набора, являются балками главного направления (часто расположенными балками с относительно небольшой жесткостью)";
        }

        private void lbl_hd2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtBl.Text = "Оконечность, располагающаяся в нос от форпиковой (таранной) переборки. Имеет поперечною систему набора, которая обеспечивает ей повышенною местную прочность";
        }

        private void lbl_hd3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtBl.Text = "Оконечность, располагающаяся в корму от ахтерпиковой переборки. Для обеспечения необходимой местной прочности перекрытия в ней имеют поперечную систему набора";

        }
        
        private void lbl_hd4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtBl.Text = "Часть конструкции днища, опирающаяся на поперечные переборки и борта. На крупнотоннажных и быстроходных морских судах днищевые перекрытия имеют продольную систему набора";

        }

        
    }

}       