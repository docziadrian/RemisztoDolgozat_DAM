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

namespace RemisztoDolgozat_DAM
{
    /// <summary>
    /// Interaction logic for NameCardWindow.xaml
    /// </summary>
    public partial class NameCardWindow : Window
    {
        public NameCardWindow(string adottNev, string adottEmail, string adottSzul, string adottTelo)
        {
            InitializeComponent();
            EgyTetszolegesNameCardWindowMetodus(adottNev, adottEmail, adottSzul, adottTelo);
        }

        private void EgyTetszolegesNameCardWindowMetodus(string adottNev, string adottEmail, string adottSzul, string adottTelo)
        {
            //throw new NotImplementedException();
            cardName.Text = adottNev;
            cardEmail.Text = adottEmail;
            cardBirthDate.Text = adottSzul;
            cardPhoneNumber.Text = adottTelo;
        }
    }
}
