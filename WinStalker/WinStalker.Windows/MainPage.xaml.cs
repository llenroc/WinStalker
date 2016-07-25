using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinStalker.Core.Model;
using WinStalker.Core.Services;

namespace WinStalker.Windows
{
    public sealed partial class MainPage : Page
    {
        private IStalkService _stalkService;
        private Person _person;

        public MainPage()
        {
            this.InitializeComponent();
            _stalkService = new StalkService();
        }

        private void ButtonStalk_OnClick(object sender, RoutedEventArgs e)
        {
            _person  = _stalkService.GetPerson(TextBoxEmail.Text);

            //TODO: Mapear os campos separadamente no XAML.
            TextBlockReturn.Text = "Nome: "+_person.FullName;
            TextBlockReturn.Text += "\nGênero: "+_person.Gender;
            TextBlockReturn.Text += "\n\n Social Networks:\n";

            foreach (SocialNetwork sn in _person.SocialNetworks)
            {
                TextBlockReturn.Text += "\n Name: " + sn.TypeName;
                TextBlockReturn.Text += "\n URL: " + sn.Url;
                TextBlockReturn.Text += "\n UserName: " + sn.Username;
                TextBlockReturn.Text += "\n";
            }
            
        }
    }
}
