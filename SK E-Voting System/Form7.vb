' ResultsTabulationForm.vb
Imports System.TimeZoneInfo
Imports MySql.Data.MySqlClient

Public Class ResultsTabulationForm
    Dim isSidebarExpanded As Boolean = False ' To track the current state of the sidebar
    Dim sidebarExpandedWidth As Integer = 238 ' Width of the expanded sidebar
    Dim sidebarCollapsedWidth As Integer = 57 ' Width of the collapsed sidebar
    Dim transitionStep As Integer = 10 ' Width change step for each timer tick
    Dim connectionString As String = "server=localhost;user=root;password=;database=sk_e_voting"

    ' Define MySqlConnection object
    Dim connection As New MySqlConnection(connectionString)

    Private Sub ResultsTabulationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            LoadVoteResults()
            Timer()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to database: " & ex.Message)
        End Try
    End Sub

    Private Sub CloseResultsTabulation_Click(sender As Object, e As EventArgs) Handles CloseResultsTabulation.Click
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

    Private Sub BtnCandidateManagement_Click(sender As Object, e As EventArgs) Handles BtnCandidateManagement.Click
        Dim candidateManagementForm As New CandidateManagementForm()
        Me.Hide()
        candidateManagementForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnResultsTabulation_Click(sender As Object, e As EventArgs) Handles BtnResultsTabulation.Click

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

    Private Sub Timer()
        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 5000 ' 5000 milliseconds = 5 seconds
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        LoadVoteResults()
    End Sub

    Private Sub LoadVoteResults()
        ' Clear existing data from the DataGridView
        DataGridView1.DataSource = Nothing

        ' Retrieve data from the database with ranking
        Dim query As String = "SELECT c.name AS CandidateName, c.party_affiliation AS PartyAffiliation, v.position, COUNT(v.candidate_id) AS vote_count, " &
                              "ROW_NUMBER() OVER (PARTITION BY v.position ORDER BY COUNT(v.candidate_id) DESC) AS rank " &
                              "FROM votes v " &
                              "INNER JOIN candidates c ON v.candidate_id = c.id " &
                              "GROUP BY c.name, c.party_affiliation, v.position " &
                              "ORDER BY v.position, rank"
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim voteResultsTable As New DataTable()

        Try
            ' Fill the DataTable with the data retrieved from the database
            adapter.Fill(voteResultsTable)

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = voteResultsTable

            ' Set DataGridView properties to make it read-only and properly arranged
            With DataGridView1
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

            ' Resize columns to fit content
            DataGridView1.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class
