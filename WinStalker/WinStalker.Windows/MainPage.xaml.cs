using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinStalker.Core.Model;
using WinStalker.Core.Services;


// O modelo do item de página em branco está documentado em http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WinStalker_Universal
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
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

            _person  = _stalkService.GetPerson(TextBoxEmail.Text );
            TextBlockReturn.Text = "Nome:"+_person.FullName;
            TextBlockReturn.Text += "\nGênero:"+_person.Gender;
            TextBlockReturn.Text += "\n\n Social Networks:\n";
            foreach ( SocialNetwork sn in _person.SocialNetworks)
            {
                TextBlockReturn.Text += "\n URL: " + sn.Url;
                TextBlockReturn.Text += "\n UserName: " + sn.Username;
            }
            
        }
    }
}
