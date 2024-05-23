' CandidateManagementForm.vb
Imports System.TimeZoneInfo
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class CandidateManagementForm
    Dim isSidebarExpanded As Boolean = False ' To track the current state of the sidebar
    Dim sidebarExpandedWidth As Integer = 238 ' Width of the expanded sidebar
    Dim sidebarCollapsedWidth As Integer = 57 ' Width of the collapsed sidebar
    Dim transitionStep As Integer = 10 ' Width change step for each timer tick
    Private connectionString As String = "server=localhost;user=root;password=;database=sk_e_voting;"
    Private connection As MySqlConnection


    Private Sub CandidateManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection = New MySqlConnection(connectionString)
        Try
            connection.Open()
            Timer()
            LoadCandidateList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CloseCandidateManagement_Click(sender As Object, e As EventArgs) Handles CloseCandidateManagement.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Dim dashboardForm As New DashboardForm()
        Me.Hide()
        dashboardForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnVoterManagement_Click(sender As Object, e As EventArgs) Handles BtnVoterManagement.Click
        Dim voterManagementForm As New VoterManagementForm()
        Me.Hide()
        voterManagementForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnCandidateManagement_Click(sender As Object, e As EventArgs)
        ' No need to do anything as already on CandidateManagementForm
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

    Private Sub BtnCloseRegistration_Click(sender As Object, e As EventArgs) Handles BtnCloseRegistration.Click
        Dim currentStatus As Integer = GetCandidacyRegistrationStatus()

        If currentStatus = 1 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure to close the candidacy registration?", "Close Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                UpdateCandidacyRegistrationStatus(0)
                MessageBox.Show("Candidacy registration is now closed.", "Registration Closed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf currentStatus = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure to open the candidacy registration?", "Open Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                UpdateCandidacyRegistrationStatus(1)
                MessageBox.Show("Candidacy registration is now open.", "Registration Opened", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Function GetCandidacyRegistrationStatus() As Integer
        Dim status As Integer = 0
        Dim query As String = "SELECT candidacy FROM status"
        Dim command As New MySqlCommand(query, connection)

        Try
            status = Convert.ToInt32(command.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return status
    End Function

    Private Sub UpdateCandidacyRegistrationStatus(ByVal status As Integer)
        Dim query As String = "UPDATE status SET candidacy = @status"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@status", status)

        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer()
        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 5000 ' 5000 milliseconds = 5 seconds
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        LoadCandidateList()
    End Sub

    Private Sub LoadCandidateList()
        LBoxListOfCandidate.Items.Clear() ' Clear existing items

        Dim query As String = "SELECT candidate_id, name, approval_status FROM candidates"
        Dim command As New MySqlCommand(query, connection)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim candidateInfo As String = reader("candidate_id").ToString() + ": " + reader("name").ToString() + " (Status: " + reader("approval_status").ToString() + ")"
                LBoxListOfCandidate.Items.Add(candidateInfo)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub LBoxListOfCandidate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxListOfCandidate.SelectedIndexChanged
        ' Handle selection change here
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim selectedIndex As Integer = LBoxListOfCandidate.SelectedIndex
        If selectedIndex <> -1 Then
            Dim selectedCandidate As String = LBoxListOfCandidate.SelectedItem.ToString()
            Dim candidateId As String = selectedCandidate.Split(":")(0).Trim()

            ' Perform approval action for candidate with candidateId
            ' For example, you can update the approval_status in the database
            Dim query As String = "UPDATE candidates SET approval_status = '1' WHERE candidate_id = @candidateId"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@candidateId", candidateId)

            Try
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Candidate approved successfully!")
                Else
                    MessageBox.Show("Failed to approve candidate.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a candidate to approve.")
        End If
    End Sub

    Private Sub RejectCandidate_Click(sender As Object, e As EventArgs) Handles RejectCandidate.Click
        Dim selectedIndex As Integer = LBoxListOfCandidate.SelectedIndex
        If selectedIndex <> -1 Then
            Dim selectedCandidate As String = LBoxListOfCandidate.SelectedItem.ToString()
            Dim candidateId As String = selectedCandidate.Split(":")(0).Trim()

            ' Perform approval action for candidate with candidateId
            ' For example, you can update the approval_status in the database
            Dim query As String = "UPDATE candidates SET approval_status = '0' WHERE candidate_id = @candidateId"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@candidateId", candidateId)

            Try
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Candidate rejected successfully!")
                Else
                    MessageBox.Show("Failed to reject candidate.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a candidate to reject.")
        End If
    End Sub
End Class