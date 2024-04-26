using IWT_RED.Utilites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IWT_RED.Helpers;
using System.Windows;

namespace IWT_RED.ViewModels
{
    class ViewModelFrame2Commands: INotifyPropertyChanged
    {




        private RelayCommand? _placeHolder1Vis;
        public RelayCommand PlaceHolder1Vis /*название команды из xaml файла*/
        {
            get => _placeHolder1Vis;
            set
            {
                _placeHolder1Vis = value;
                OnPropertyChanged();
            }

        }
        private RelayCommand? _placeHolder2Vis;
        public RelayCommand PlaceHolder2Vis /*название команды из xaml файла*/
        {
            get => _placeHolder2Vis;
            set
            {
                _placeHolder2Vis = value;
                OnPropertyChanged();
            }

        }
        private RelayCommand? _placeHolder3Vis;
        public RelayCommand PlaceHolder3Vis /*название команды из xaml файла*/
        {
            get => _placeHolder3Vis;
            set
            {
                _placeHolder3Vis = value;
                OnPropertyChanged();
            }

        }









        private RelayCommand? _acceptFrame2Com;
        public RelayCommand AcceptFrame2Com /*название команды из xaml файла*/
        {
            get
            {
                return _acceptFrame2Com ??= new RelayCommand(obj =>
                {

                    Navigate.NavServ.Navigate(new Frame3());
                });
            }
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
    }
}
