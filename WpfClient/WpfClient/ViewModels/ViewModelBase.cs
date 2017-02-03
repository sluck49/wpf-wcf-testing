using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.ViewModels
{
    public abstract class ViewModelBase:INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanging(string propertyName)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<TValue>(string propertyName, TValue newValue, Action doSet)
        {
            var currentValue = GetType().GetProperty(propertyName).GetValue(this);
            if (currentValue?.Equals(newValue) ?? newValue == null)
                return;
            
            OnPropertyChanging(propertyName);
            doSet();
            OnPropertyChanged(propertyName);
        }
    }
}
