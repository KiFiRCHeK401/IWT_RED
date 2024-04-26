using IWT_RED.Helpers;
using IWT_RED.Utilites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IWT_RED.ViewModels
{
    class ViewModelFrame1Commands: INotifyPropertyChanged
    {

        private RelayCommand? _GoToFrame2;
        public RelayCommand GoToFrame2 /*название команды из xaml файла*/
        {
            get
            {
                return _GoToFrame2 ??= new RelayCommand(obj =>
                {

                    Navigate.NavServ.Navigate(new Frame2());
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
