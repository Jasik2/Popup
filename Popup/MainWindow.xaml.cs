using System;
using System.ComponentModel;
using System.IO;
using System.Windows;

namespace Popup
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new mojpies();
        }

        private void BtnWyslij_Click(object sender, RoutedEventArgs e)
        {
            MyDog dog = DataContext as MyDog;
            string dane = $"Imię właściciela: {txtImieWlasciciela.Text}\n" +
                          $"Nazwisko właściciela: {txtNazwiskoWlasciciela.Text}\n" +
                          $"Nazwa psa: {txtNazwaPsa.Text}\n" +
                          $"Data urodzenia: {dog.DtB.ToShortDateString()}\n" +
                          $"Rodowod: {txtNazwaPsa.Text}";
            File.WriteAllText("dane.txt", dane);
            MessageBox.Show("Dane zapisane!");
        }
    }



    internal class MyDog : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;



        public void checkPropertyChangeEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private DateTime dtB;
        public DateTime DtB
        {
            get { return dtB; }
            set
            {
                dtB = value;
                checkPropertyChangeEvent("DtB");
            }
        }
    }
}
