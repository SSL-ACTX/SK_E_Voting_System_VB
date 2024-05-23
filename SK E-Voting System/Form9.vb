Public Class DashboardForm
    Dim isSidebarExpanded As Boolean = False ' To track the current state of the sidebar
    Dim sidebarExpandedWidth As Integer = 238 ' Width of the expanded sidebar
    Dim sidebarCollapsedWidth As Integer = 57 ' Width of the collapsed sidebar
    Dim transitionStep As Integer = 10 ' Width change step for each timer tick

    Private Sub CloseDashboard_Click(sender As Object, e As EventArgs) Handles CloseDashboard.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click

    End Sub

    Private Sub BtnVoterManagement_Click(sender As Object, e As EventArgs) Handles BtnVoterManagement.Click
        Dim voterManagementForm As New VoterManagementForm()
        Me.Hide()
        voterManagementForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnCandidateManagement_Click(sender As Object, e As EventArgs) Handles BtnCandidateManagement.Click
        Dim candidateManagementForm As New CandidateManagementForm()
        Me.Hide()
        candidateManagementForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnResultsTabulation_Click(sender As Object, e As EventArgs) Handles BtnResultsTabulation.Click
        Dim resultsTabulationForm As New ResultsTabulationForm()
        Me.Hide()
        resultsTabulationForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim loginForm As New LoginForm()
            Me.Hide()
            loginForm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        ToggleSidebar()
    End Sub

    Private Sub ToggleSidebar()
        isSidebarExpanded = Not isSidebarExpanded
        SidebarTransitionTimer.Start()
    End Sub

    Private Sub SidebarTransitionTimer_Tick(sender As Object, e As EventArgs) Handles SidebarTransitionTimer.Tick
        If isSidebarExpanded Then
            If sidebar.Width < sidebarExpandedWidth Then
                sidebar.Width += transitionStep
            Else
                SidebarTransitionTimer.Stop()
            End If
        Else
            If sidebar.Width > sidebarCollapsedWidth Then
                sidebar.Width -= transitionStep
            Else
                SidebarTransitionTimer.Stop()
            End If
        End If
    End Sub

    Private Sub SlideButton1_Click_1(sender As Object, e As EventArgs) Handles SlideButton1.Click
        If SlideButton1.IsOn Then
            BtnSwitch.Text = "     Dark Mode"
            ' Set colors for Dark Mode
            SetDarkMode()
        Else
            BtnSwitch.Text = "     Light Mode"
            ' Set colors for Light Mode
            SetLightMode()
        End If
    End Sub

    Private Sub BtnSwitch_Click(sender As Object, e As EventArgs) Handles BtnSwitch.Click
        ' You can handle BtnSwitch click event if needed
    End Sub

    Private Sub SetDarkMode()
        ' Set dark mode colors
        BtnDashboard.BackColor = Color.FromArgb(45, 45, 48)
        BtnDashboard.ForeColor = Color.White
        BtnVoterManagement.BackColor = Color.FromArgb(45, 45, 48)
        BtnVoterManagement.ForeColor = Color.White
        BtnCandidateManagement.BackColor = Color.FromArgb(45, 45, 48)
        BtnCandidateManagement.ForeColor = Color.White
        BtnResultsTabulation.BackColor = Color.FromArgb(45, 45, 48)
        BtnResultsTabulation.ForeColor = Color.White
        BtnLogout.BackColor = Color.FromArgb(45, 45, 48)
        BtnLogout.ForeColor = Color.White
        BtnSwitch.BackColor = Color.FromArgb(45, 45, 48)
        BtnSwitch.ForeColor = Color.White
        sidebar.BackColor = Color.FromArgb(45, 45, 48)
    End Sub

    Private Sub SetLightMode()
        ' Set light mode colors
        BtnDashboard.BackColor = Color.White
        BtnDashboard.ForeColor = Color.Black
        BtnVoterManagement.BackColor = Color.White
        BtnVoterManagement.ForeColor = Color.Black
        BtnCandidateManagement.BackColor = Color.White
        BtnCandidateManagement.ForeColor = Color.Black
        BtnResultsTabulation.BackColor = Color.White
        BtnResultsTabulation.ForeColor = Color.Black
        BtnLogout.BackColor = Color.White
        BtnLogout.ForeColor = Color.Black
        BtnSwitch.BackColor = Color.White
        BtnSwitch.ForeColor = Color.Black
        sidebar.BackColor = Color.White
    End Sub
End Class
