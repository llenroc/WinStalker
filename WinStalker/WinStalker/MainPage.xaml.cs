using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco é documentado em http://go.microsoft.com/fwlink/?LinkId=391641

namespace WinStalker
{
    /// <resumo>
    /// Uma página vazia que pode ser usada sozinha ou por meio da navegação dentro de um quadro.
    /// </resumo>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <resumo>
        /// Chamado quando esta página é exibida num Frame.
        /// </resumo>
        /// <param name="e">Dados de evento que descrevem como essa página foi atingida.
        /// Este parâmetro normalmente é usado para configurar a página.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare a página para exibição aqui.

            // TODO: Se seu aplicativo contiver várias páginas certifique-se de que esteja
            // manipulando o botão Voltar do hardware ao fazer o registro para o
            // Evento Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Se estiver usando o NavigationHelper fornecido por alguns modelos,
            // este evento é manipulado para você.
        }
    }
}
