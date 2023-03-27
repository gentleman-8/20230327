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

namespace _20230327
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        

        private void txtCM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void binAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.#########################################################################}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.################################################################################}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.#######################################################################################}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##############################################################################################}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.#####################################################################################################}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.############################################################################################################}", _value / 91.44);
        }

        

   

     

        

   

        private void txtmg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtmg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput); // 事先將公尺轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtmg.Text = "";
            }
        }

        private void txtg_KeyUp(object sender, KeyEventArgs e)
        {

            strInput = txtg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100); // 事先將公尺轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtg.Text = "";
            }
        }

        private void txtkg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtkg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 100000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtkg.Text = "";
            }
        }

        private void txtt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtt.Text = "";
            }
        }

        private void txtoz_KeyUp(object sender, KeyEventArgs e)
        {

            strInput = txtoz.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtoz.Text = "";
            }
        }

        private void txtlp_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtlp.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtlp.Text = "";
            }
        }
    }

}
