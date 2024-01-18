using System.Diagnostics;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace CSharp_Windows_Aid
{
    internal class ClassMonitor
    {
        private readonly MainPage mainPage;

        public ClassMonitor(MainPage mainPage)
        {
            this.mainPage = mainPage;
        }

        public void Activate()
        {
            _ = new MessageDialog("Class Monitor Activated").ShowAsync();
            _ = Task.Run(() =>
            {
                while (true)
                {
                    //s
                }
            });
        }
    }
}