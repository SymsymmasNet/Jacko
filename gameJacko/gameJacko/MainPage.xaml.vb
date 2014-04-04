Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructeur
    Public Sub New()
        InitializeComponent()

        SupportedOrientations = SupportedPageOrientation.Portrait Or SupportedPageOrientation.Landscape

        ' Exemple de code pour la localisation d'ApplicationBar
        'BuildLocalizedApplicationBar()

    End Sub

    ' Exemple de code pour la conception d'une ApplicationBar localisée
    'Private Sub BuildLocalizedApplicationBar()
    '    ' Définit l'ApplicationBar de la page sur une nouvelle instance d'ApplicationBar.
    '    ApplicationBar = New ApplicationBar()

    '    ' Crée un bouton et définit la valeur du texte sur la chaîne localisée issue d'AppResources.
    '    Dim appBarButton As New ApplicationBarIconButton(New Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative))
    '    appBarButton.Text = AppResources.AppBarButtonText
    '    ApplicationBar.Buttons.Add(appBarButton)

    '    ' Crée un nouvel élément de menu avec la chaîne localisée d'AppResources.
    '    Dim appBarMenuItem As New ApplicationBarMenuItem(AppResources.AppBarMenuItemText)
    '    ApplicationBar.MenuItems.Add(appBarMenuItem)
    'End Sub

End Class