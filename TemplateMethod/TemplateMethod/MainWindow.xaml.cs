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
            ComboBox cb = sender as ComboBox;
            int type = cb.SelectedIndex;

            switch (type)
            {
                case 0:
                    van = new Kis();
                    break;
                case 1:
                    van = new TPay();
                    break;
                default:
                    break;

            }
        }

        public void WriteTextbox(string msg)
        {
            tbResult.AppendText(msg +"\n");
            tbResult.ScrollToEnd();
            
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            if (van == null) return;

            DTOPayment dto = new DTOPayment();
            dto.CUSTNAME = "홍길동";
            dto.AMOUNT = 10000;
            dto.TYPE = 0;
            van.Payment(dto);
        }

        private void btnPayment_Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (van == null) return;

            DTOPayment dto = new DTOPayment();
            dto.CUSTNAME = "홍길동";
            dto.AMOUNT = 5000;
            dto.TYPE = -1;
            van.CancelPayment(dto);
        }

        private void btnCashReceipt_Click(object sender, RoutedEventArgs e)
        {
            if (van == null) return;

            DTOPayment dto = new DTOPayment();
            dto.CUSTNAME = "홍길동";
            dto.AMOUNT = 12000;
            dto.TYPE = 7;
            van.CashApproval(dto);
        }
    }
}
