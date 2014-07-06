<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon1Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowInterface = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CustomTheme1 = New Pioneer_VSX_Series_Remote_Control.CustomTheme()
        Me.btnPlayback = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnNavigation = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnSound = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.tabControls = New Pioneer_VSX_Series_Remote_Control.NSTabControl()
        Me.tabMainZone = New System.Windows.Forms.TabPage()
        Me.NsGroupBox1 = New Pioneer_VSX_Series_Remote_Control.NSGroupBox()
        Me.CustomSideButton4 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton2 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton3 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton1 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.cmbMainInputs = New Pioneer_VSX_Series_Remote_Control.NSComboBox()
        Me.btnMainInputNext = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnMainInputPrev = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.tabHDZone = New System.Windows.Forms.TabPage()
        Me.tabZone2 = New System.Windows.Forms.TabPage()
        Me.tabSound = New System.Windows.Forms.TabPage()
        Me.tabNavigation = New System.Windows.Forms.TabPage()
        Me.btnNavDown = New System.Windows.Forms.PictureBox()
        Me.btnNavRight = New System.Windows.Forms.PictureBox()
        Me.btnNavLeft = New System.Windows.Forms.PictureBox()
        Me.btnNavUp = New System.Windows.Forms.PictureBox()
        Me.btnNavAudio = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnNavHome = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnNavReturn = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnNavSleep = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnNavInfo = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnNavVideo = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnNavOK = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.tabPlayback = New System.Windows.Forms.TabPage()
        Me.btnZone2 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnHDZone = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnMainZone = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMVolume = New System.Windows.Forms.Label()
        Me.lblMainInput = New System.Windows.Forms.Label()
        Me.lblOSD = New System.Windows.Forms.Label()
        Me.SliderMVolume = New Pioneer_VSX_Series_Remote_Control.NSTrackBar()
        Me.btnPwr = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnAutoHide = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnHide = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnMVolumeDown = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnMVolumeUp = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnMute = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomMiddleBar1 = New Pioneer_VSX_Series_Remote_Control.CustomMiddleBar()
        Me.NsSeperator1 = New Pioneer_VSX_Series_Remote_Control.NSSeperator()
        Me.btnpwer = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.NotifyIcon1Menu.SuspendLayout()
        Me.CustomTheme1.SuspendLayout()
        Me.tabControls.SuspendLayout()
        Me.tabMainZone.SuspendLayout()
        Me.NsGroupBox1.SuspendLayout()
        Me.tabNavigation.SuspendLayout()
        CType(Me.btnNavDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNavRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNavLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNavUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Connected to 192.168.XXX.XXX"
        Me.NotifyIcon1.BalloonTipTitle = "VSX Remote"
        Me.NotifyIcon1.ContextMenuStrip = Me.NotifyIcon1Menu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "VSX Remote"
        Me.NotifyIcon1.Visible = True
        '
        'NotifyIcon1Menu
        '
        Me.NotifyIcon1Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowInterface, Me.ToolStripSeparator1, Me.ExitApplication})
        Me.NotifyIcon1Menu.Name = "NotifyIcon1Menu"
        Me.NotifyIcon1Menu.Size = New System.Drawing.Size(160, 54)
        '
        'ShowInterface
        '
        Me.ShowInterface.Name = "ShowInterface"
        Me.ShowInterface.Size = New System.Drawing.Size(159, 22)
        Me.ShowInterface.Text = "Show Interface"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
        '
        'ExitApplication
        '
        Me.ExitApplication.Name = "ExitApplication"
        Me.ExitApplication.Size = New System.Drawing.Size(159, 22)
        Me.ExitApplication.Text = "Exit VSX Remote"
        '
        'Timer1
        '
        Me.Timer1.Interval = 7000
        '
        'CustomTheme1
        '
        Me.CustomTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.CustomTheme1.Controls.Add(Me.btnPlayback)
        Me.CustomTheme1.Controls.Add(Me.btnNavigation)
        Me.CustomTheme1.Controls.Add(Me.btnSound)
        Me.CustomTheme1.Controls.Add(Me.tabControls)
        Me.CustomTheme1.Controls.Add(Me.btnZone2)
        Me.CustomTheme1.Controls.Add(Me.btnHDZone)
        Me.CustomTheme1.Controls.Add(Me.btnMainZone)
        Me.CustomTheme1.Controls.Add(Me.Panel1)
        Me.CustomTheme1.Controls.Add(Me.SliderMVolume)
        Me.CustomTheme1.Controls.Add(Me.btnPwr)
        Me.CustomTheme1.Controls.Add(Me.btnAutoHide)
        Me.CustomTheme1.Controls.Add(Me.btnHide)
        Me.CustomTheme1.Controls.Add(Me.btnMVolumeDown)
        Me.CustomTheme1.Controls.Add(Me.btnMVolumeUp)
        Me.CustomTheme1.Controls.Add(Me.btnMute)
        Me.CustomTheme1.Controls.Add(Me.CustomMiddleBar1)
        Me.CustomTheme1.Controls.Add(Me.NsSeperator1)
        Me.CustomTheme1.Customization = "6Ojo//z8/P/y8vL//////1BQUP//////AAAA////////////lpaW/w=="
        Me.CustomTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomTheme1.Image = Nothing
        Me.CustomTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CustomTheme1.Movable = False
        Me.CustomTheme1.Name = "CustomTheme1"
        Me.CustomTheme1.NoRounding = False
        Me.CustomTheme1.Sizable = False
        Me.CustomTheme1.Size = New System.Drawing.Size(400, 200)
        Me.CustomTheme1.SmartBounds = True
        Me.CustomTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.CustomTheme1.TabIndex = 3
        Me.CustomTheme1.Text = "VSX Remote - Pre Release"
        Me.CustomTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CustomTheme1.Transparent = False
        '
        'btnPlayback
        '
        Me.btnPlayback.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnPlayback.Customization = ""
        Me.btnPlayback.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnPlayback.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayback.Image = Nothing
        Me.btnPlayback.Location = New System.Drawing.Point(270, 164)
        Me.btnPlayback.Name = "btnPlayback"
        Me.btnPlayback.NoRounding = True
        Me.btnPlayback.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.btnPlayback.Size = New System.Drawing.Size(125, 30)
        Me.btnPlayback.TabIndex = 27
        Me.btnPlayback.Text = " PLAYBACK"
        Me.btnPlayback.Transparent = True
        '
        'btnNavigation
        '
        Me.btnNavigation.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavigation.Customization = ""
        Me.btnNavigation.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnNavigation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavigation.Image = Nothing
        Me.btnNavigation.Location = New System.Drawing.Point(138, 164)
        Me.btnNavigation.Name = "btnNavigation"
        Me.btnNavigation.NoRounding = True
        Me.btnNavigation.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.btnNavigation.Size = New System.Drawing.Size(125, 30)
        Me.btnNavigation.TabIndex = 27
        Me.btnNavigation.Text = "NAVIGATION"
        Me.btnNavigation.Transparent = True
        '
        'btnSound
        '
        Me.btnSound.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSound.Customization = ""
        Me.btnSound.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSound.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSound.Image = Nothing
        Me.btnSound.Location = New System.Drawing.Point(6, 164)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.NoRounding = True
        Me.btnSound.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.btnSound.Size = New System.Drawing.Size(125, 30)
        Me.btnSound.TabIndex = 27
        Me.btnSound.Text = "    SOUND"
        Me.btnSound.Transparent = True
        '
        'tabControls
        '
        Me.tabControls.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabControls.Controls.Add(Me.tabMainZone)
        Me.tabControls.Controls.Add(Me.tabHDZone)
        Me.tabControls.Controls.Add(Me.tabZone2)
        Me.tabControls.Controls.Add(Me.tabSound)
        Me.tabControls.Controls.Add(Me.tabNavigation)
        Me.tabControls.Controls.Add(Me.tabPlayback)
        Me.tabControls.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabControls.ItemSize = New System.Drawing.Size(0, 1)
        Me.tabControls.Location = New System.Drawing.Point(3, 200)
        Me.tabControls.MinimumSize = New System.Drawing.Size(0, 1)
        Me.tabControls.Multiline = True
        Me.tabControls.Name = "tabControls"
        Me.tabControls.SelectedIndex = 0
        Me.tabControls.Size = New System.Drawing.Size(395, 197)
        Me.tabControls.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControls.TabIndex = 26
        '
        'tabMainZone
        '
        Me.tabMainZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabMainZone.Controls.Add(Me.NsGroupBox1)
        Me.tabMainZone.ForeColor = System.Drawing.Color.White
        Me.tabMainZone.Location = New System.Drawing.Point(5, 4)
        Me.tabMainZone.Name = "tabMainZone"
        Me.tabMainZone.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMainZone.Size = New System.Drawing.Size(386, 189)
        Me.tabMainZone.TabIndex = 0
        Me.tabMainZone.Text = "tabMainZone"
        '
        'NsGroupBox1
        '
        Me.NsGroupBox1.Controls.Add(Me.CustomSideButton4)
        Me.NsGroupBox1.Controls.Add(Me.CustomSideButton2)
        Me.NsGroupBox1.Controls.Add(Me.CustomSideButton3)
        Me.NsGroupBox1.Controls.Add(Me.CustomSideButton1)
        Me.NsGroupBox1.Controls.Add(Me.cmbMainInputs)
        Me.NsGroupBox1.Controls.Add(Me.btnMainInputNext)
        Me.NsGroupBox1.Controls.Add(Me.btnMainInputPrev)
        Me.NsGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsGroupBox1.DrawSeperator = True
        Me.NsGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(380, 183)
        Me.NsGroupBox1.SubTitle = "Select Main Zone input"
        Me.NsGroupBox1.TabIndex = 3
        Me.NsGroupBox1.Text = "NsGroupBox1"
        Me.NsGroupBox1.Title = "Input Select"
        '
        'CustomSideButton4
        '
        Me.CustomSideButton4.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton4.Customization = ""
        Me.CustomSideButton4.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton4.Image = Nothing
        Me.CustomSideButton4.Location = New System.Drawing.Point(194, 149)
        Me.CustomSideButton4.Name = "CustomSideButton4"
        Me.CustomSideButton4.NoRounding = True
        Me.CustomSideButton4.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton4.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton4.TabIndex = 3
        Me.CustomSideButton4.Text = "CUSTOM FAVORITE 4"
        Me.CustomSideButton4.Transparent = False
        '
        'CustomSideButton2
        '
        Me.CustomSideButton2.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton2.Customization = ""
        Me.CustomSideButton2.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton2.Image = Nothing
        Me.CustomSideButton2.Location = New System.Drawing.Point(194, 113)
        Me.CustomSideButton2.Name = "CustomSideButton2"
        Me.CustomSideButton2.NoRounding = True
        Me.CustomSideButton2.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton2.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton2.TabIndex = 3
        Me.CustomSideButton2.Text = "CUSTOM FAVORITE 2"
        Me.CustomSideButton2.Transparent = False
        '
        'CustomSideButton3
        '
        Me.CustomSideButton3.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton3.Customization = ""
        Me.CustomSideButton3.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton3.Image = Nothing
        Me.CustomSideButton3.Location = New System.Drawing.Point(8, 149)
        Me.CustomSideButton3.Name = "CustomSideButton3"
        Me.CustomSideButton3.NoRounding = True
        Me.CustomSideButton3.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton3.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton3.TabIndex = 3
        Me.CustomSideButton3.Text = "CUSTOM FAVORITE 3"
        Me.CustomSideButton3.Transparent = False
        '
        'CustomSideButton1
        '
        Me.CustomSideButton1.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton1.Customization = ""
        Me.CustomSideButton1.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton1.Image = Nothing
        Me.CustomSideButton1.Location = New System.Drawing.Point(8, 113)
        Me.CustomSideButton1.Name = "CustomSideButton1"
        Me.CustomSideButton1.NoRounding = True
        Me.CustomSideButton1.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton1.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton1.TabIndex = 3
        Me.CustomSideButton1.Text = "CUSTOM FAVORITE 1"
        Me.CustomSideButton1.Transparent = False
        '
        'cmbMainInputs
        '
        Me.cmbMainInputs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbMainInputs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMainInputs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainInputs.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMainInputs.ForeColor = System.Drawing.Color.White
        Me.cmbMainInputs.FormattingEnabled = True
        Me.cmbMainInputs.Location = New System.Drawing.Point(8, 44)
        Me.cmbMainInputs.Name = "cmbMainInputs"
        Me.cmbMainInputs.Size = New System.Drawing.Size(370, 28)
        Me.cmbMainInputs.TabIndex = 0
        '
        'btnMainInputNext
        '
        Me.btnMainInputNext.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnMainInputNext.Customization = ""
        Me.btnMainInputNext.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.btnMainInputNext.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMainInputNext.Image = Nothing
        Me.btnMainInputNext.Location = New System.Drawing.Point(194, 77)
        Me.btnMainInputNext.Name = "btnMainInputNext"
        Me.btnMainInputNext.NoRounding = False
        Me.btnMainInputNext.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnMainInputNext.Size = New System.Drawing.Size(180, 30)
        Me.btnMainInputNext.TabIndex = 2
        Me.btnMainInputNext.Text = "INPUT NAME (NEXT)"
        Me.btnMainInputNext.Transparent = False
        '
        'btnMainInputPrev
        '
        Me.btnMainInputPrev.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnMainInputPrev.Customization = ""
        Me.btnMainInputPrev.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.btnMainInputPrev.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMainInputPrev.Image = Nothing
        Me.btnMainInputPrev.Location = New System.Drawing.Point(8, 77)
        Me.btnMainInputPrev.Name = "btnMainInputPrev"
        Me.btnMainInputPrev.NoRounding = False
        Me.btnMainInputPrev.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnMainInputPrev.Size = New System.Drawing.Size(180, 30)
        Me.btnMainInputPrev.TabIndex = 2
        Me.btnMainInputPrev.Text = "INPUT NAME (PREV)"
        Me.btnMainInputPrev.Transparent = False
        '
        'tabHDZone
        '
        Me.tabHDZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabHDZone.Location = New System.Drawing.Point(5, 4)
        Me.tabHDZone.Name = "tabHDZone"
        Me.tabHDZone.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHDZone.Size = New System.Drawing.Size(386, 191)
        Me.tabHDZone.TabIndex = 1
        Me.tabHDZone.Text = "tabHDZone"
        '
        'tabZone2
        '
        Me.tabZone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabZone2.Location = New System.Drawing.Point(5, 4)
        Me.tabZone2.Name = "tabZone2"
        Me.tabZone2.Size = New System.Drawing.Size(386, 191)
        Me.tabZone2.TabIndex = 2
        Me.tabZone2.Text = "tabZone2"
        '
        'tabSound
        '
        Me.tabSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabSound.Location = New System.Drawing.Point(5, 4)
        Me.tabSound.Name = "tabSound"
        Me.tabSound.Size = New System.Drawing.Size(386, 191)
        Me.tabSound.TabIndex = 3
        Me.tabSound.Text = "tabSound"
        '
        'tabNavigation
        '
        Me.tabNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabNavigation.Controls.Add(Me.btnNavDown)
        Me.tabNavigation.Controls.Add(Me.btnNavRight)
        Me.tabNavigation.Controls.Add(Me.btnNavLeft)
        Me.tabNavigation.Controls.Add(Me.btnNavUp)
        Me.tabNavigation.Controls.Add(Me.btnNavAudio)
        Me.tabNavigation.Controls.Add(Me.btnNavHome)
        Me.tabNavigation.Controls.Add(Me.btnNavReturn)
        Me.tabNavigation.Controls.Add(Me.btnNavSleep)
        Me.tabNavigation.Controls.Add(Me.btnNavInfo)
        Me.tabNavigation.Controls.Add(Me.btnNavVideo)
        Me.tabNavigation.Controls.Add(Me.btnNavOK)
        Me.tabNavigation.Location = New System.Drawing.Point(5, 4)
        Me.tabNavigation.Name = "tabNavigation"
        Me.tabNavigation.Size = New System.Drawing.Size(386, 191)
        Me.tabNavigation.TabIndex = 4
        Me.tabNavigation.Text = "tabNavigation"
        '
        'btnNavDown
        '
        Me.btnNavDown.BackColor = System.Drawing.Color.Transparent
        Me.btnNavDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavDown.Image = CType(resources.GetObject("btnNavDown.Image"), System.Drawing.Image)
        Me.btnNavDown.Location = New System.Drawing.Point(169, 119)
        Me.btnNavDown.Name = "btnNavDown"
        Me.btnNavDown.Size = New System.Drawing.Size(48, 48)
        Me.btnNavDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnNavDown.TabIndex = 0
        Me.btnNavDown.TabStop = False
        '
        'btnNavRight
        '
        Me.btnNavRight.BackColor = System.Drawing.Color.Transparent
        Me.btnNavRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavRight.Image = CType(resources.GetObject("btnNavRight.Image"), System.Drawing.Image)
        Me.btnNavRight.Location = New System.Drawing.Point(220, 68)
        Me.btnNavRight.Name = "btnNavRight"
        Me.btnNavRight.Size = New System.Drawing.Size(48, 48)
        Me.btnNavRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnNavRight.TabIndex = 0
        Me.btnNavRight.TabStop = False
        '
        'btnNavLeft
        '
        Me.btnNavLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnNavLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLeft.Image = CType(resources.GetObject("btnNavLeft.Image"), System.Drawing.Image)
        Me.btnNavLeft.Location = New System.Drawing.Point(118, 68)
        Me.btnNavLeft.Name = "btnNavLeft"
        Me.btnNavLeft.Size = New System.Drawing.Size(48, 48)
        Me.btnNavLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnNavLeft.TabIndex = 0
        Me.btnNavLeft.TabStop = False
        '
        'btnNavUp
        '
        Me.btnNavUp.BackColor = System.Drawing.Color.Transparent
        Me.btnNavUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavUp.Image = CType(resources.GetObject("btnNavUp.Image"), System.Drawing.Image)
        Me.btnNavUp.Location = New System.Drawing.Point(169, 17)
        Me.btnNavUp.Name = "btnNavUp"
        Me.btnNavUp.Size = New System.Drawing.Size(48, 48)
        Me.btnNavUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnNavUp.TabIndex = 0
        Me.btnNavUp.TabStop = False
        '
        'btnNavAudio
        '
        Me.btnNavAudio.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavAudio.Customization = ""
        Me.btnNavAudio.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavAudio.Image = Nothing
        Me.btnNavAudio.Location = New System.Drawing.Point(61, 3)
        Me.btnNavAudio.Name = "btnNavAudio"
        Me.btnNavAudio.NoRounding = False
        Me.btnNavAudio.Size = New System.Drawing.Size(96, 48)
        Me.btnNavAudio.TabIndex = 1
        Me.btnNavAudio.Text = "AUDIO"
        Me.btnNavAudio.Transparent = False
        '
        'btnNavHome
        '
        Me.btnNavHome.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavHome.Customization = ""
        Me.btnNavHome.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavHome.Image = Nothing
        Me.btnNavHome.Location = New System.Drawing.Point(61, 135)
        Me.btnNavHome.Name = "btnNavHome"
        Me.btnNavHome.NoRounding = False
        Me.btnNavHome.Size = New System.Drawing.Size(96, 48)
        Me.btnNavHome.TabIndex = 1
        Me.btnNavHome.Text = "MENU"
        Me.btnNavHome.Transparent = False
        '
        'btnNavReturn
        '
        Me.btnNavReturn.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavReturn.Customization = ""
        Me.btnNavReturn.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavReturn.Image = Nothing
        Me.btnNavReturn.Location = New System.Drawing.Point(229, 135)
        Me.btnNavReturn.Name = "btnNavReturn"
        Me.btnNavReturn.NoRounding = False
        Me.btnNavReturn.Size = New System.Drawing.Size(96, 48)
        Me.btnNavReturn.TabIndex = 1
        Me.btnNavReturn.Text = "RETURN"
        Me.btnNavReturn.Transparent = False
        '
        'btnNavSleep
        '
        Me.btnNavSleep.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavSleep.Customization = ""
        Me.btnNavSleep.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavSleep.Image = Nothing
        Me.btnNavSleep.Location = New System.Drawing.Point(285, 67)
        Me.btnNavSleep.Name = "btnNavSleep"
        Me.btnNavSleep.NoRounding = False
        Me.btnNavSleep.Size = New System.Drawing.Size(96, 48)
        Me.btnNavSleep.TabIndex = 1
        Me.btnNavSleep.Text = "SLEEP"
        Me.btnNavSleep.Transparent = False
        '
        'btnNavInfo
        '
        Me.btnNavInfo.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavInfo.Customization = ""
        Me.btnNavInfo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavInfo.Image = Nothing
        Me.btnNavInfo.Location = New System.Drawing.Point(5, 67)
        Me.btnNavInfo.Name = "btnNavInfo"
        Me.btnNavInfo.NoRounding = False
        Me.btnNavInfo.Size = New System.Drawing.Size(96, 48)
        Me.btnNavInfo.TabIndex = 1
        Me.btnNavInfo.Text = "INFO"
        Me.btnNavInfo.Transparent = False
        '
        'btnNavVideo
        '
        Me.btnNavVideo.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavVideo.Customization = ""
        Me.btnNavVideo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavVideo.Image = Nothing
        Me.btnNavVideo.Location = New System.Drawing.Point(229, 3)
        Me.btnNavVideo.Name = "btnNavVideo"
        Me.btnNavVideo.NoRounding = False
        Me.btnNavVideo.Size = New System.Drawing.Size(96, 48)
        Me.btnNavVideo.TabIndex = 1
        Me.btnNavVideo.Text = "VIDEO"
        Me.btnNavVideo.Transparent = False
        '
        'btnNavOK
        '
        Me.btnNavOK.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnNavOK.Customization = ""
        Me.btnNavOK.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavOK.Image = Nothing
        Me.btnNavOK.Location = New System.Drawing.Point(169, 67)
        Me.btnNavOK.Name = "btnNavOK"
        Me.btnNavOK.NoRounding = False
        Me.btnNavOK.Size = New System.Drawing.Size(48, 48)
        Me.btnNavOK.TabIndex = 1
        Me.btnNavOK.Text = "OK"
        Me.btnNavOK.Transparent = False
        '
        'tabPlayback
        '
        Me.tabPlayback.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabPlayback.Location = New System.Drawing.Point(5, 4)
        Me.tabPlayback.Name = "tabPlayback"
        Me.tabPlayback.Size = New System.Drawing.Size(386, 191)
        Me.tabPlayback.TabIndex = 5
        Me.tabPlayback.Text = "tabPlayback"
        '
        'btnZone2
        '
        Me.btnZone2.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZone2.Customization = ""
        Me.btnZone2.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnZone2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZone2.Image = Nothing
        Me.btnZone2.Location = New System.Drawing.Point(270, 129)
        Me.btnZone2.Name = "btnZone2"
        Me.btnZone2.NoRounding = False
        Me.btnZone2.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.btnZone2.Size = New System.Drawing.Size(125, 30)
        Me.btnZone2.TabIndex = 22
        Me.btnZone2.Text = "   ZONE 2"
        Me.btnZone2.Transparent = False
        '
        'btnHDZone
        '
        Me.btnHDZone.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnHDZone.Customization = ""
        Me.btnHDZone.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnHDZone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHDZone.Image = Nothing
        Me.btnHDZone.Location = New System.Drawing.Point(138, 129)
        Me.btnHDZone.Name = "btnHDZone"
        Me.btnHDZone.NoRounding = False
        Me.btnHDZone.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.btnHDZone.Size = New System.Drawing.Size(125, 30)
        Me.btnHDZone.TabIndex = 22
        Me.btnHDZone.Text = "   HDZONE"
        Me.btnHDZone.Transparent = False
        '
        'btnMainZone
        '
        Me.btnMainZone.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnMainZone.Customization = ""
        Me.btnMainZone.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnMainZone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainZone.Image = Nothing
        Me.btnMainZone.Location = New System.Drawing.Point(6, 129)
        Me.btnMainZone.Name = "btnMainZone"
        Me.btnMainZone.NoRounding = False
        Me.btnMainZone.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.btnMainZone.Size = New System.Drawing.Size(125, 30)
        Me.btnMainZone.TabIndex = 22
        Me.btnMainZone.Text = "MAIN ZONE"
        Me.btnMainZone.Transparent = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblMVolume)
        Me.Panel1.Controls.Add(Me.lblMainInput)
        Me.Panel1.Controls.Add(Me.lblOSD)
        Me.Panel1.Location = New System.Drawing.Point(3, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 57)
        Me.Panel1.TabIndex = 21
        '
        'lblMVolume
        '
        Me.lblMVolume.BackColor = System.Drawing.Color.Transparent
        Me.lblMVolume.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMVolume.ForeColor = System.Drawing.Color.Lime
        Me.lblMVolume.Location = New System.Drawing.Point(269, 2)
        Me.lblMVolume.Name = "lblMVolume"
        Me.lblMVolume.Size = New System.Drawing.Size(126, 19)
        Me.lblMVolume.TabIndex = 2
        Me.lblMVolume.Text = "-00.0dB"
        Me.lblMVolume.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMVolume.UseCompatibleTextRendering = True
        Me.lblMVolume.UseMnemonic = False
        '
        'lblMainInput
        '
        Me.lblMainInput.BackColor = System.Drawing.Color.Transparent
        Me.lblMainInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainInput.ForeColor = System.Drawing.Color.Lime
        Me.lblMainInput.Location = New System.Drawing.Point(3, 2)
        Me.lblMainInput.Name = "lblMainInput"
        Me.lblMainInput.Size = New System.Drawing.Size(150, 19)
        Me.lblMainInput.TabIndex = 20
        Me.lblMainInput.Text = "INPUT NAME"
        Me.lblMainInput.UseCompatibleTextRendering = True
        Me.lblMainInput.UseMnemonic = False
        '
        'lblOSD
        '
        Me.lblOSD.BackColor = System.Drawing.Color.Transparent
        Me.lblOSD.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSD.ForeColor = System.Drawing.Color.Lime
        Me.lblOSD.Location = New System.Drawing.Point(2, 20)
        Me.lblOSD.Name = "lblOSD"
        Me.lblOSD.Size = New System.Drawing.Size(393, 40)
        Me.lblOSD.TabIndex = 18
        Me.lblOSD.Text = "SCANNING INPUTS"
        Me.lblOSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOSD.UseCompatibleTextRendering = True
        Me.lblOSD.UseMnemonic = False
        '
        'SliderMVolume
        '
        Me.SliderMVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SliderMVolume.Location = New System.Drawing.Point(136, 92)
        Me.SliderMVolume.Maximum = 185
        Me.SliderMVolume.Minimum = 0
        Me.SliderMVolume.Name = "SliderMVolume"
        Me.SliderMVolume.Size = New System.Drawing.Size(105, 23)
        Me.SliderMVolume.TabIndex = 17
        Me.SliderMVolume.Value = 0
        '
        'btnPwr
        '
        Me.btnPwr.BackColor = System.Drawing.Color.Black
        Me.btnPwr.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnPwr.Customization = ""
        Me.btnPwr.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnPwr.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnPwr.Image = Nothing
        Me.btnPwr.Location = New System.Drawing.Point(5, 88)
        Me.btnPwr.Name = "btnPwr"
        Me.btnPwr.NoRounding = False
        Me.btnPwr.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Green
        Me.btnPwr.Size = New System.Drawing.Size(65, 30)
        Me.btnPwr.TabIndex = 8
        Me.btnPwr.Text = " ON"
        Me.btnPwr.Transparent = False
        '
        'btnAutoHide
        '
        Me.btnAutoHide.BackColor = System.Drawing.Color.Black
        Me.btnAutoHide.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnAutoHide.Customization = ""
        Me.btnAutoHide.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAutoHide.Image = Nothing
        Me.btnAutoHide.Location = New System.Drawing.Point(5, 5)
        Me.btnAutoHide.Name = "btnAutoHide"
        Me.btnAutoHide.NoRounding = False
        Me.btnAutoHide.Size = New System.Drawing.Size(97, 19)
        Me.btnAutoHide.TabIndex = 10
        Me.btnAutoHide.Text = "Always Show"
        Me.btnAutoHide.Transparent = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Black
        Me.btnHide.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnHide.Customization = ""
        Me.btnHide.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnHide.Image = Nothing
        Me.btnHide.Location = New System.Drawing.Point(349, 5)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.NoRounding = False
        Me.btnHide.Size = New System.Drawing.Size(46, 19)
        Me.btnHide.TabIndex = 10
        Me.btnHide.Text = "Hide"
        Me.btnHide.Transparent = False
        '
        'btnMVolumeDown
        '
        Me.btnMVolumeDown.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnMVolumeDown.Customization = ""
        Me.btnMVolumeDown.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMVolumeDown.Image = Nothing
        Me.btnMVolumeDown.Location = New System.Drawing.Point(86, 88)
        Me.btnMVolumeDown.Name = "btnMVolumeDown"
        Me.btnMVolumeDown.NoRounding = False
        Me.btnMVolumeDown.Size = New System.Drawing.Size(44, 30)
        Me.btnMVolumeDown.TabIndex = 7
        Me.btnMVolumeDown.Text = "VOL -"
        Me.btnMVolumeDown.Transparent = False
        '
        'btnMVolumeUp
        '
        Me.btnMVolumeUp.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnMVolumeUp.Customization = ""
        Me.btnMVolumeUp.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMVolumeUp.Image = Nothing
        Me.btnMVolumeUp.Location = New System.Drawing.Point(247, 88)
        Me.btnMVolumeUp.Name = "btnMVolumeUp"
        Me.btnMVolumeUp.NoRounding = False
        Me.btnMVolumeUp.Size = New System.Drawing.Size(44, 30)
        Me.btnMVolumeUp.TabIndex = 7
        Me.btnMVolumeUp.Text = "VOL +"
        Me.btnMVolumeUp.Transparent = False
        '
        'btnMute
        '
        Me.btnMute.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnMute.Customization = ""
        Me.btnMute.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Custom_Image
        Me.btnMute.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMute.Image = CType(resources.GetObject("btnMute.Image"), System.Drawing.Image)
        Me.btnMute.Location = New System.Drawing.Point(303, 88)
        Me.btnMute.Name = "btnMute"
        Me.btnMute.NoRounding = False
        Me.btnMute.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnMute.Size = New System.Drawing.Size(92, 30)
        Me.btnMute.TabIndex = 12
        Me.btnMute.Text = "  MUTE"
        Me.btnMute.Transparent = False
        '
        'CustomMiddleBar1
        '
        Me.CustomMiddleBar1.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomMiddleBar1.Customization = ""
        Me.CustomMiddleBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomMiddleBar1.Image = Nothing
        Me.CustomMiddleBar1.Location = New System.Drawing.Point(86, 88)
        Me.CustomMiddleBar1.Name = "CustomMiddleBar1"
        Me.CustomMiddleBar1.NoRounding = False
        Me.CustomMiddleBar1.Size = New System.Drawing.Size(205, 31)
        Me.CustomMiddleBar1.TabIndex = 14
        Me.CustomMiddleBar1.Text = "CustomMiddleBar1"
        Me.CustomMiddleBar1.Transparent = False
        '
        'NsSeperator1
        '
        Me.NsSeperator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.NsSeperator1.Location = New System.Drawing.Point(6, 118)
        Me.NsSeperator1.Name = "NsSeperator1"
        Me.NsSeperator1.Size = New System.Drawing.Size(390, 11)
        Me.NsSeperator1.TabIndex = 23
        Me.NsSeperator1.Text = "NsSeperator1"
        '
        'btnpwer
        '
        Me.btnpwer.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnpwer.Customization = ""
        Me.btnpwer.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnpwer.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnpwer.Image = Nothing
        Me.btnpwer.Location = New System.Drawing.Point(205, 29)
        Me.btnpwer.Name = "btnpwer"
        Me.btnpwer.NoRounding = False
        Me.btnpwer.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnpwer.Size = New System.Drawing.Size(61, 30)
        Me.btnpwer.TabIndex = 6
        Me.btnpwer.Text = "ON"
        Me.btnpwer.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.CustomTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "VSX Remote"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NotifyIcon1Menu.ResumeLayout(False)
        Me.CustomTheme1.ResumeLayout(False)
        Me.tabControls.ResumeLayout(False)
        Me.tabMainZone.ResumeLayout(False)
        Me.NsGroupBox1.ResumeLayout(False)
        Me.tabNavigation.ResumeLayout(False)
        Me.tabNavigation.PerformLayout()
        CType(Me.btnNavDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNavRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNavLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNavUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMVolume As System.Windows.Forms.Label
    Friend WithEvents CustomTheme1 As Pioneer_VSX_Series_Remote_Control.CustomTheme
    Friend WithEvents btnpwer As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnMVolumeDown As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnMVolumeUp As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnPwr As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnHide As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotifyIcon1Menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowInterface As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitApplication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMute As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomMiddleBar1 As Pioneer_VSX_Series_Remote_Control.CustomMiddleBar
    Friend WithEvents SliderMVolume As Pioneer_VSX_Series_Remote_Control.NSTrackBar
    Friend WithEvents lblOSD As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAutoHide As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents lblMainInput As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnZone2 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnHDZone As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnMainZone As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents NsSeperator1 As Pioneer_VSX_Series_Remote_Control.NSSeperator
    Friend WithEvents tabControls As Pioneer_VSX_Series_Remote_Control.NSTabControl
    Friend WithEvents tabMainZone As System.Windows.Forms.TabPage
    Friend WithEvents tabHDZone As System.Windows.Forms.TabPage
    Friend WithEvents tabZone2 As System.Windows.Forms.TabPage
    Friend WithEvents cmbMainInputs As Pioneer_VSX_Series_Remote_Control.NSComboBox
    Friend WithEvents btnMainInputNext As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnMainInputPrev As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents NsGroupBox1 As Pioneer_VSX_Series_Remote_Control.NSGroupBox
    Friend WithEvents CustomSideButton4 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomSideButton2 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomSideButton3 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomSideButton1 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnPlayback As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnNavigation As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnSound As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents tabSound As System.Windows.Forms.TabPage
    Friend WithEvents tabNavigation As System.Windows.Forms.TabPage
    Friend WithEvents tabPlayback As System.Windows.Forms.TabPage
    Friend WithEvents btnNavUp As System.Windows.Forms.PictureBox
    Friend WithEvents btnNavDown As System.Windows.Forms.PictureBox
    Friend WithEvents btnNavLeft As System.Windows.Forms.PictureBox
    Friend WithEvents btnNavRight As System.Windows.Forms.PictureBox
    Friend WithEvents btnNavOK As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnNavAudio As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnNavReturn As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnNavVideo As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnNavHome As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnNavInfo As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnNavSleep As Pioneer_VSX_Series_Remote_Control.CustomButton

End Class
