using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TDDLesson.UI
{
    // INotifyPropertyChangedを継承することで自動的に
    // データバインディングの処理が行える
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(
            ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            if(Equals(field,value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if(h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }

            return true;
        }
    }
}
