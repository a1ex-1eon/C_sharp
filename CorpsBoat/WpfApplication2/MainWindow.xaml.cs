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
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/main.png"));
            txtBl.Text = "здесь текст";
            ///txtBl_about.Text = "about";
        }
        private void btn_about_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            about.Owner = this;
        }



        ///1st head
        private void lbl_hd1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/112.png"));
            txtBl.Text = "Вертикальная стенка внутри корпуса судна, кроме двойного борта, разделяющая внутреннее пространство на отсеки, а также наружные стенки надстроек и рубок";
        }

        private void lbl11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/11.png"));
            txtBl.Text = "Ограждение по краям наружной палубы судна,представляющее собой сплошную стенку без вырезов или со специальными вырезами для стока воды , швартовки (клюза) и прочими";
        }
        private void lbl12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/12.png"));
            txtBl.Text = "Крайний лист палубного настила, идущий параллельно обводу борта.Служит для обеспечения продольной прочности.";
        }
        private void lbl13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/13.png"));
            txtBl.Text = "Вертикальная конструкция для крепления фальшборта к палубе и для придания жёсткости фальшборту.";
        }
        private void lbl14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/14.png"));
            txtBl.Text = "Верхний пояс бортовой обшивки делается утолщенным. Угловое соединение ширстрека с палубным стрингером (крайним поясом настила палубы) усиливается палубным угольником";
        }
        private void lbl15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/15.png"));
            txtBl.Text = "Поперечные связи бортового набора. На бортовом перекрытии, имением поперечную систему набора, являются балками главного направления (часто расположенными балками с относительно небольшой жесткостью)";
        }
        private void lbl16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/16.png"));
            txtBl.Text = "Усиленные шпангоуты, предназначенные для местного усиления корпуса, а также можгут служить опорой для несущих продольных связей Обычно устанавливаются через 3–4 шпации";
        }
        private void lbl17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/17.png"));
            txtBl.Text = "Поперечные связи палубного перекрытия. При поперечной системе набора палубного перекрытия являются балками главного направления, опирающимися на перекрестные связи - карлингсы.";
        }
        private void lbl18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/18.png"));
            txtBl.Text = "Продольная связь бортового перекрытия. На бортовом перекрытии, имеющем поперечною систему набора, бортовой стрингер является перекрестной связью для шпангоутов - поперечных балок набора борта.";
        }
        private void lbl19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/19.png"));
            txtBl.Text = "Вертикально установленные балки на поперечной переборке, которые выполняют роль балок главного направления по отношению к шельфу - горизонтальной связи большой жесткостью.";
        }
        private void lbl111_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/111.png"));
            txtBl.Text = "Непроницаемая поперечная связь днищевого набора, герметично соединенная с обшивкой днища и настилом второго дна. Флоры(непроницаемые и сплошные) являются перекрестными связями днищевого перекрытия с продольной системой набора.";
        }
        private void lbl112_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/112.png"));
            txtBl.Text = "Поперечные связи днищевого набора, которые делаются из вертикальных листов с вырезами. Являются перекрестными связями днищевого перекрытия и продольной системой набора.";
        }
        private void lbl113_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/113.png"));
            txtBl.Text = "Продольная неразрезная балка, проходящая по всей длине судна от таранной до ахтерпиковой переборки. Герметично разделяет танки двойного дна правого и левого борта.";
        }
        private void lbl114_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/114.png"));
            txtBl.Text = "Пояс днищевой обшивки, имеющий наибольшую толщину, располагающийся по ДП судна и герметично  присоединенный к вертикальному килю - продольной связи днищевого перекрытия.";
        }
        private void lbl115_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/115.png"));
            txtBl.Text = "Продольные связи большой жесткости, установленные перпендикулярно к основной плоскости или нормально к наружной днищевой обшивке судна.";
        }
        private void lbl116_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/116.png"));
            txtBl.Text = "Ребра в виде профильных элементов, подкрепляющие листы обшивки, настила или стенку балки набора корпуса судна и обеспечивающие местную жёсткость конструкции.";
        }
        private void lbl117_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/1/117.png"));
            txtBl.Text = "Пластины, обеспечивающие жесткость соединения шпангоутов с опорами. Высота от верхней кромки флора должна быть не менее 0,1 пролета шпангоута от второго дна до палубы.";

        }


        ///2nd head
        private void lbl_hd2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/22.png"));
            txtBl.Text = "Оконечность, располагающаяся в нос от форпиковой (таранной) переборки. Имеет поперечною систему набора, которая обеспечивает ей повышенною местную прочность";
        }

        private void lbl21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/21.png"));
            txtBl.Text = "Верхний пояс бортовой обшивки делается утолщенным. Угловое соединение ширстрека с палубным стрингером (крайним поясом настила палубы) усиливается палубным угольником";
        }
        private void lbl22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/22.png"));
            txtBl.Text = "Крайний лист палубного настила, идущий параллельно обводу борта.Служит для обеспечения продольной прочности";
        }
        private void lbl23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/23.png"));
            txtBl.Text = "Выполняется в виде мощной литой, кованной или сварной балки. Листы обшивки правого и левого бортов соединяются с ним встык или в накрой. Продольные связи набора соединяются с ним брештуками";
        }
        private void lbl24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/24.png"));
            txtBl.Text = "Бракеты, служащие для соединения платформ или бортовых стрингеров с форштевнем - мощной литой, кованной или сварной балкой носовой оконечности корпуса судна";
        }
        private void lbl25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/25.png"));
            txtBl.Text = "Поперечные связи днищевого набора, которые в носовой и кормовой оконечностях выполняются в виде сварной тавровой конструкции. В носовой или кормовой оконечности с поперечной системой набора являются балками главного направления";
        }
        private void lbl26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/26.png"));
            txtBl.Text = "Ребра в виде профильных элементов, подкрепляющие листы обшивки, настила или стенку балки набора корпуса судна и обеспечивающие местную жёсткость конструкции";
        }
        private void lbl27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/27.png"));
            txtBl.Text = "Поперечные связи бортового набора. На бортовом перекрытии, имением поперечную систему набора, являются балками главного направления (часто расположенными балками с относительно небольшой жесткостью)";
        }
        private void lbl28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/28.png"));
            txtBl.Text = "Поперечные связи палубного перекрытия. При поперечной системе набора палубного перекрытия являются балками главного направления, опирающимися на перекрестные связи - карлингсы";
        }
        private void lbl29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/29.png"));
            txtBl.Text = "Пластины, обеспечивающие жесткость соединения бимсов и шпангоутов. Бимсы и шпангоуты (поперечные балки набора палубного и бортового перекрытия) при поперечной системе набора являются балками главного направления";
        }
        private void lbl211_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/2/211.png"));
            txtBl.Text = "Продольная связь большой жесткости на палубном перекрытии. При поперечной системе набора палубного перекрытия являются перекрестными связями для бимсов - поперечных балок палубного набора";
        }



        ///3th head
        private void lbl_hd3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/32.png"));
            txtBl.Text = "Оконечность, располагающаяся в корму от ахтерпиковой переборки. Для обеспечения необходимой местной прочности перекрытия в ней имеют поперечную систему набора";

        }



        ///4th head
        private void lbl_hd4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/42.png"));
            txtBl.Text = "Часть конструкции днища, опирающаяся на поперечные переборки и борта. На крупнотоннажных и быстроходных морских судах днищевые перекрытия имеют продольную систему набора";

        }

        ///5th head
        private void lbl_hd5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/52.png"));
            txtBl.Text = "Часть конструкции днища, опирающаяся на поперечные переборки и борта. На крупнотоннажных и быстроходных морских судах днищевые перекрытия имеют продольную систему набора";

        }

        ///6th head
        private void lbl_hd6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/62.png"));
            txtBl.Text = "Часть конструкции днища, опирающаяся на поперечные переборки и борта. На крупнотоннажных и быстроходных морских судах днищевые перекрытия имеют продольную систему набора";
                    }

        ///7th head
        private void lbl_hd7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            image1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/main/72.png"));
            txtBl.Text = "Часть конструкции днища, опирающаяся на поперечные переборки и борта. На крупнотоннажных и быстроходных морских судах днищевые перекрытия имеют продольную систему набора";
        }

        
    }

}       