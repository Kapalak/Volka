using System.Threading.Tasks;
using VolkaApp.Utils;
using Windows.UI.Xaml.Controls;

namespace VolkaApp.Mvvm
{
    public class ViewModelBase : BindableBase
    {
        private Page _host;
        public Page Host
        {
            get { return _host; }
            set
            {
                _host = value;
                HostLoaded.Invoke(value);
            }
        }
        public DeferedAction<Page> HostLoaded { get; } = new DeferedAction<Page>();

        public virtual async void OnNavigatedTo(object paramter) { await Task.CompletedTask; }
        public virtual async void OnNavigatedFrom(object paramter) { await Task.CompletedTask; }
    }
}
