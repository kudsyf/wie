
Namespace My
    
    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings
        Public WriteOnly Property RunTimeConnectionString() As String

            Set(ByVal Value As String)
                My.Settings("NewDBFConnectionString") = Value
            End Set
        End Property

        'Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
        '    Me.Item("NewDBFConnectionString") = "Data Source=NERDO\SQLEXPRESS;Initial Catalog=NewDBF;Integrated Security=True"
        'End Sub

    End Class
End Namespace
