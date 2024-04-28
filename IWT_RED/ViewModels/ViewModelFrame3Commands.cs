using IWT_RED.Utilites;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using IWT_RED.Helpers;
using System.Windows.Threading;
using System;

namespace IWT_RED.ViewModels
{
    class ViewModelFrame3Commands:INotifyPropertyChanged
    {
        
        private RelayCommand? _getCodeAgain;
        public RelayCommand GetCodeAgain /*название команды из xaml файла*/
        {
            get
            {
                return _getCodeAgain ??= new RelayCommand(obj =>
                {

                    MessageBox.Show("Code: 000");
                });

            }

        }




        private string _TB4Text;
        private string _TB5Text;
        private string _TB6Text;
        private RelayCommand? _verificationCode;
        public RelayCommand VerificationCode
        {
            get
            {
                return _verificationCode ??= new RelayCommand(obj =>
                {
                    string CorrCode = "000";
                    string EntrCode = TB4Text + TB5Text + TB6Text;
                    //MessageBox.Show(EntrCode);
                    if (CorrCode == EntrCode)
                    {
                        Navigate.NavServ.Navigate(new Frame4());
                        timerStart();
                    }
                    else
                    {
                        MessageBox.Show("Неверный код");
                    }
                });
            }
        }

        public string TB6Text
        {
            get { return _TB6Text; }
            set
            {
                _TB6Text = value;
                OnPropertyChanged("TB6Text");
            }
        }
        public string TB5Text
        {
            get { return _TB5Text; }
            set
            {
                _TB5Text = value;
                OnPropertyChanged("TB5Text");
            }
        }
        public string TB4Text
        {
            get { return _TB4Text; }
            set
            {
                _TB4Text = value;
                OnPropertyChanged("TB4Text");
            }
        }




        DispatcherTimer timer = new DispatcherTimer();



        private void timerStart()
        {

            timer.Interval = TimeSpan.FromSeconds(20);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            Navigate.NavServ.Navigate(new Frame1());
        }




        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }


    }
}
