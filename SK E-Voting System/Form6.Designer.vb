<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CandidateManagementForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseCandidateManagement = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.SidebarTransitionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TBoxAddCandidate = New System.Windows.Forms.TextBox()
        Me.LBoxListOfCandidate = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCloseRegistration = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.BtnVoterManagement = New System.Windows.Forms.Button()
        Me.BtnResultsTabulation = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnSwitch = New System.Windows.Forms.Button()
        Me.SlideButton1 = New AltoControls.SlideButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.BtnCandidateManagement = New System.Windows.Forms.Button()
        Me.RejectCandidate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Controls.Add(Me.CloseCandidateManagement)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 34)
        Me.Panel1.TabIndex = 3
        '
        'CloseCandidateManagement
        '
        Me.CloseCandidateManagement.FlatAppearance.BorderSize = 0
        Me.CloseCandidateManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseCandidateManagement.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseCandidateManagement.ForeColor = System.Drawing.Color.Black
        Me.CloseCandidateManagement.Image = CType(resources.GetObject("CloseCandidateManagement.Image"), System.Drawing.Image)
        Me.CloseCandidateManagement.Location = New System.Drawing.Point(904, 8)
        Me.CloseCandidateManagement.Name = "CloseCandidateManagement"
        Me.CloseCandidateManagement.Size = New System.Drawing.Size(47, 18)
        Me.CloseCandidateManagement.TabIndex = 16
        Me.CloseCandidateManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseCandidateManagement.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(861, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 18)
        Me.Button2.TabIndex = 15
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(814, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 18)
        Me.Button3.TabIndex = 14
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.Image = CType(resources.GetObject("menu.Image"), System.Drawing.Image)
        Me.menu.Location = New System.Drawing.Point(12, 5)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(45, 23)
        Me.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.menu.TabIndex = 1
        Me.menu.TabStop = False
        '
        'SidebarTransitionTimer
        '
        Me.SidebarTransitionTimer.Interval = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.RejectCandidate)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.TBoxAddCandidate)
        Me.Panel3.Controls.Add(Me.LBoxListOfCandidate)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.BtnAdd)
        Me.Panel3.Controls.Add(Me.BtnCloseRegistration)
        Me.Panel3.Location = New System.Drawing.Point(53, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(903, 483)
        Me.Panel3.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 37)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "List of Candidate"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-57, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1026, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'TBoxAddCandidate
        '
        Me.TBoxAddCandidate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TBoxAddCandidate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxAddCandidate.ForeColor = System.Drawing.Color.Black
        Me.TBoxAddCandidate.Location = New System.Drawing.Point(564, 103)
        Me.TBoxAddCandidate.Multiline = True
        Me.TBoxAddCandidate.Name = "TBoxAddCandidate"
        Me.TBoxAddCandidate.Size = New System.Drawing.Size(300, 33)
        Me.TBoxAddCandidate.TabIndex = 15
        '
        'LBoxListOfCandidate
        '
        Me.LBoxListOfCandidate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBoxListOfCandidate.FormattingEnabled = True
        Me.LBoxListOfCandidate.ItemHeight = 20
        Me.LBoxListOfCandidate.Location = New System.Drawing.Point(56, 103)
        Me.LBoxListOfCandidate.Name = "LBoxListOfCandidate"
        Me.LBoxListOfCandidate.Size = New System.Drawing.Size(479, 344)
        Me.LBoxListOfCandidate.TabIndex = 13
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-34, 70)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(663, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Blue
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(612, 163)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 35)
        Me.BtnAdd.TabIndex = 16
        Me.BtnAdd.Text = "Approve"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCloseRegistration
        '
        Me.BtnCloseRegistration.BackColor = System.Drawing.Color.Red
        Me.BtnCloseRegistration.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseRegistration.ForeColor = System.Drawing.Color.White
        Me.BtnCloseRegistration.Location = New System.Drawing.Point(612, 412)
        Me.BtnCloseRegistration.Name = "BtnCloseRegistration"
        Me.BtnCloseRegistration.Size = New System.Drawing.Size(226, 35)
        Me.BtnCloseRegistration.TabIndex = 14
        Me.BtnCloseRegistration.Text = "Toggle Registration"
        Me.BtnCloseRegistration.UseVisualStyleBackColor = False
        '
        'BtnDashboard
        '
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.Location = New System.Drawing.Point(12, 103)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(226, 54)
        Me.BtnDashboard.TabIndex = 3
        Me.BtnDashboard.Text = "     Dashboard"
        Me.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashboard.UseVisualStyleBackColor = True
        '
        'BtnVoterManagement
        '
        Me.BtnVoterManagement.FlatAppearance.BorderSize = 0
        Me.BtnVoterManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoterManagement.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoterManagement.ForeColor = System.Drawing.Color.White
        Me.BtnVoterManagement.Image = CType(resources.GetObject("BtnVoterManagement.Image"), System.Drawing.Image)
        Me.BtnVoterManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVoterManagement.Location = New System.Drawing.Point(12, 163)
        Me.BtnVoterManagement.Name = "BtnVoterManagement"
        Me.BtnVoterManagement.Size = New System.Drawing.Size(226, 54)
        Me.BtnVoterManagement.TabIndex = 4
        Me.BtnVoterManagement.Text = "     Voters list"
        Me.BtnVoterManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVoterManagement.UseVisualStyleBackColor = True
        '
        'BtnResultsTabulation
        '
        Me.BtnResultsTabulation.FlatAppearance.BorderSize = 0
        Me.BtnResultsTabulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResultsTabulation.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResultsTabulation.ForeColor = System.Drawing.Color.White
        Me.BtnResultsTabulation.Image = CType(resources.GetObject("BtnResultsTabulation.Image"), System.Drawing.Image)
        Me.BtnResultsTabulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResultsTabulation.Location = New System.Drawing.Point(12, 283)
        Me.BtnResultsTabulation.Name = "BtnResultsTabulation"
        Me.BtnResultsTabulation.Size = New System.Drawing.Size(226, 54)
        Me.BtnResultsTabulation.TabIndex = 6
        Me.BtnResultsTabulation.Text = "     Result Tabulation"
        Me.BtnResultsTabulation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnResultsTabulation.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Location = New System.Drawing.Point(12, 380)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(226, 54)
        Me.BtnLogout.TabIndex = 8
        Me.BtnLogout.Text = "     Logout"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Crimson
        Me.Panel4.Location = New System.Drawing.Point(3, 223)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 54)
        Me.Panel4.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(53, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'BtnSwitch
        '
        Me.BtnSwitch.FlatAppearance.BorderSize = 0
        Me.BtnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSwitch.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwitch.ForeColor = System.Drawing.Color.White
        Me.BtnSwitch.Image = CType(resources.GetObject("BtnSwitch.Image"), System.Drawing.Image)
        Me.BtnSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSwitch.Location = New System.Drawing.Point(12, 425)
        Me.BtnSwitch.Name = "BtnSwitch"
        Me.BtnSwitch.Size = New System.Drawing.Size(209, 54)
        Me.BtnSwitch.TabIndex = 15
        Me.BtnSwitch.Text = "     Light Mode"
        Me.BtnSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSwitch.UseVisualStyleBackColor = True
        '
        'SlideButton1
        '
        Me.SlideButton1.BorderColor = System.Drawing.Color.LightGray
        Me.SlideButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SlideButton1.IsOn = True
        Me.SlideButton1.Location = New System.Drawing.Point(179, 443)
        Me.SlideButton1.Name = "SlideButton1"
        Me.SlideButton1.Size = New System.Drawing.Size(38, 21)
        Me.SlideButton1.TabIndex = 16
        Me.SlideButton1.Text = "SlideButton1"
        Me.SlideButton1.TextEnabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-96, 369)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.sidebar.Controls.Add(Me.BtnCandidateManagement)
        Me.sidebar.Controls.Add(Me.PictureBox1)
        Me.sidebar.Controls.Add(Me.SlideButton1)
        Me.sidebar.Controls.Add(Me.BtnSwitch)
        Me.sidebar.Controls.Add(Me.PictureBox2)
        Me.sidebar.Controls.Add(Me.Panel4)
        Me.sidebar.Controls.Add(Me.BtnLogout)
        Me.sidebar.Controls.Add(Me.BtnResultsTabulation)
        Me.sidebar.Controls.Add(Me.BtnVoterManagement)
        Me.sidebar.Controls.Add(Me.BtnDashboard)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 34)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(57, 483)
        Me.sidebar.TabIndex = 6
        '
        'BtnCandidateManagement
        '
        Me.BtnCandidateManagement.FlatAppearance.BorderSize = 0
        Me.BtnCandidateManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCandidateManagement.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCandidateManagement.ForeColor = System.Drawing.Color.White
        Me.BtnCandidateManagement.Image = CType(resources.GetObject("BtnCandidateManagement.Image"), System.Drawing.Image)
        Me.BtnCandidateManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCandidateManagement.Location = New System.Drawing.Point(12, 223)
        Me.BtnCandidateManagement.Name = "BtnCandidateManagement"
        Me.BtnCandidateManagement.Size = New System.Drawing.Size(226, 54)
        Me.BtnCandidateManagement.TabIndex = 18
        Me.BtnCandidateManagement.Text = "     Candidates list"
        Me.BtnCandidateManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCandidateManagement.UseVisualStyleBackColor = True
        '
        'RejectCandidate
        '
        Me.RejectCandidate.BackColor = System.Drawing.Color.Red
        Me.RejectCandidate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RejectCandidate.ForeColor = System.Drawing.Color.White
        Me.RejectCandidate.Location = New System.Drawing.Point(728, 163)
        Me.RejectCandidate.Name = "RejectCandidate"
        Me.RejectCandidate.Size = New System.Drawing.Size(110, 35)
        Me.RejectCandidate.TabIndex = 20
        Me.RejectCandidate.Text = "Reject"
        Me.RejectCandidate.UseVisualStyleBackColor = False
        '
        'CandidateManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 517)
        Me.Controls.Add(Me.sidebar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CandidateManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menu As PictureBox
    Friend WithEvents CloseCandidateManagement As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SidebarTransitionTimer As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCloseRegistration As Button
    Friend WithEvents LBoxListOfCandidate As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBoxAddCandidate As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents BtnVoterManagement As Button
    Friend WithEvents BtnResultsTabulation As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnSwitch As Button
    Friend WithEvents SlideButton1 As AltoControls.SlideButton
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents sidebar As Panel
    Friend WithEvents BtnCandidateManagement As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RejectCandidate As Button
End Class
