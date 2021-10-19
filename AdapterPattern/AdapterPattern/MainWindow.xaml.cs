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

namespace AdapterPattern
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;
        private bool status;
        private INHComm _nhic; //공단
        private HealthInsurance _healthInsurance;
        public MainWindow()
        {
            InitializeComponent();
            DB.InsSetting();
            DB.PatSetting();
            HIC.Setting();
            
            instance = this;
            status = true;
            
            cbPatient.ItemsSource = DB.PATLIST;
        }

        public void WriteTextbox(string msg)
        {
            tbResult.AppendText(msg + "\n");
            tbResult.ScrollToEnd();

        }

        private void cbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                if (cbStatus.SelectedIndex == 0) status = true;
                else status = false;
            }
            
        }

        private void btnCheckHealthIns_Click(object sender, RoutedEventArgs e)
        {
            if (status)
            {
                _nhic = new NHICComm();
            }
            else
            {
                _healthInsurance = new HealthInsurance();
                _nhic = new HealthInsAdapter(_healthInsurance);
            }

            DTOPatientPersonal pat = (DTOPatientPersonal)cbPatient.SelectedItem;
            string today = DateTime.Today.ToString("yyyyMMdd");
            DTOPatientHealthIns healthIns = _nhic.NHICCommRequest(pat.PatientID, pat.PatientJN, pat.PatientName, today);
            if(healthIns != null)
                WriteTextbox($"{pat.PatientName}님의 {today}일자 자격 조회:\n자격일자:{healthIns.InquiryDate}, 자격타입:{healthIns.QlfType},보험증번호:{healthIns.AsylmSym}, 자격정지일:{healthIns.PayRestricDt}, 공상 등 구분:{healthIns.GsType}");
            else
                WriteTextbox($"{pat.PatientName}님의 {today}일자 자격 조회 실패");

            DBSave(healthIns, today);
            WriteTextbox("=============================================================");
            
        }

        private void DBSave(DTOPatientHealthIns dto, string today)
        {
            if(dto != null)
            {
                dto.InquiryDate = today;
                DB.LIST.Add(dto);
            }
            
        }
    }
}
