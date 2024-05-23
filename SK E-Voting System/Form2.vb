Imports System.Xml

Public Class LoginForm
    Private settingsFile As String = "settings.xml"

    Private Sub CloseLogin_Click(sender As Object, e As EventArgs) Handles CloseLogin.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TBoxUsername.Text
        Dim password As String = TBoxPassword.Text

        If String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter your username and password.")
        ElseIf String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter your username.")
        ElseIf String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter your password.")
        ElseIf username = "admin" AndAlso password = "password" Then
            MessageBox.Show("Login successful!")
            ' Open DashboardForm here
            Dim dashboardForm As New DashboardForm()
            dashboardForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Your username or password is incorrect.")
        End If
    End Sub

    Private Sub CBoxRememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxRememberMe.CheckedChanged
        ' When the checkbox is checked, save the username, password, and remember state to XML file
        If CBoxRememberMe.Checked Then
            SaveSettings(TBoxUsername.Text, TBoxPassword.Text, True)
        Else
            SaveSettings("", "", False) ' Clear saved settings when "Remember Me" is unchecked
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load saved settings from XML file
        LoadSettings()
    End Sub

    Private Sub SaveSettings(username As String, password As String, rememberMe As Boolean)
        Try
            Dim xmlSettings As New XmlDocument()

            ' If the settings file exists, load it. Otherwise, create a new one.
            If IO.File.Exists(settingsFile) Then
                xmlSettings.Load(settingsFile)
            Else
                Dim declaration As XmlDeclaration = xmlSettings.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
                xmlSettings.AppendChild(declaration)
                Dim root As XmlElement = xmlSettings.CreateElement("Settings")
                xmlSettings.AppendChild(root)
            End If

            ' Add or update username, password, and rememberMe elements
            Dim rootElement As XmlElement = xmlSettings.SelectSingleNode("Settings")
            Dim userNode As XmlNode = rootElement.SelectSingleNode("Username")
            Dim passNode As XmlNode = rootElement.SelectSingleNode("Password")
            Dim rememberNode As XmlNode = rootElement.SelectSingleNode("RememberMe")

            If userNode Is Nothing Then
                userNode = xmlSettings.CreateElement("Username")
                rootElement.AppendChild(userNode)
            End If

            If passNode Is Nothing Then
                passNode = xmlSettings.CreateElement("Password")
                rootElement.AppendChild(passNode)
            End If

            If rememberNode Is Nothing Then
                rememberNode = xmlSettings.CreateElement("RememberMe")
                rootElement.AppendChild(rememberNode)
            End If

            ' Set inner text for username, password, and rememberMe nodes
            userNode.InnerText = username
            passNode.InnerText = password
            rememberNode.InnerText = rememberMe.ToString()

            ' Save the XML file
            xmlSettings.Save(settingsFile)
        Catch ex As Exception
            MessageBox.Show("Error saving settings: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSettings()
        Try
            Dim xmlSettings As New XmlDocument()

            ' If the settings file exists, load it
            If IO.File.Exists(settingsFile) Then
                xmlSettings.Load(settingsFile)

                Dim rootElement As XmlElement = xmlSettings.SelectSingleNode("Settings")
                Dim rememberNode As XmlNode = rootElement.SelectSingleNode("RememberMe")

                ' If rememberMe node exists and is true, set the checkbox state accordingly
                If rememberNode IsNot Nothing AndAlso Boolean.Parse(rememberNode.InnerText) Then
                    CBoxRememberMe.Checked = True

                    ' Retrieve username and password only when "Remember Me" is checked
                    Dim userNode As XmlNode = rootElement.SelectSingleNode("Username")
                    Dim passNode As XmlNode = rootElement.SelectSingleNode("Password")

                    ' If username and password nodes exist, populate the textboxes
                    If userNode IsNot Nothing AndAlso passNode IsNot Nothing Then
                        TBoxUsername.Text = userNode.InnerText
                        TBoxPassword.Text = passNode.InnerText
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading settings: " & ex.Message)
        End Try
    End Sub

    Private Sub LblForgotPassword_Click(sender As Object, e As EventArgs) Handles LblForgotPassword.Click

    End Sub
End Class
