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

namespace TemplateMethod
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow _instance;
        private VanTemplate van;
        public MainWindow()
        {
            InitializeComponent();
            _instance = this;
        }

        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                VanInit();
            }
        }
        
        private void VanInit()
        {
            if (cbType != null)
            {
                int type = cbType.SelectedIndex;
                switch (type)
                {
                    case 0:
                        van = new Kis();
                        break;
                    case 1:
                        van = new TPay();
                        break;
                    default:
                        van = new Kis();
                        break;

                }
                van.connection();
            }
            else
                return;
        }

        public void WriteTextbox(string msg)
        {
            tbResult.AppendText(msg +"\n");
            tbResult.ScrollToEnd();
            
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            if (van == null) VanInit();

            DTOPayment dto = new DTOPayment();
            dto.CUSTNAME = "홍길동";
            dto.AMOUNT = 10000;
            dto.TYPE = 0;
            van.Payment(dto);
        }

        private void btnPayment_Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (van == null) VanInit();

            DTOPayment dto = new DTOPayment();
            dto.CUSTNAME = "홍길동";
            dto.AMOUNT = 5000;
            dto.TYPE = -1;
            dto.OLDAUTHNUM = "12345678";
            van.Payment(dto, true);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            VanInit();
        }
    }
}
