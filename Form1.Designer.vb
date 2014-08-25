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
        Me.NsGroupBox2 = New Pioneer_VSX_Series_Remote_Control.NSGroupBox()
        Me.CustomSideButton5 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton8 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton6 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton7 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnHDZInputNext = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnHDZInputPrev = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnHDZPwr = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.cmbHDZInputs = New Pioneer_VSX_Series_Remote_Control.NSComboBox()
        Me.tabZone2 = New System.Windows.Forms.TabPage()
        Me.SliderZ2Volume = New Pioneer_VSX_Series_Remote_Control.NSTrackBar()
        Me.btnZ2VolumeDown = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnZ2VolumeUp = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnZ2Mute = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomMiddleBar2 = New Pioneer_VSX_Series_Remote_Control.CustomMiddleBar()
        Me.NsGroupBox3 = New Pioneer_VSX_Series_Remote_Control.NSGroupBox()
        Me.NsSeperator3 = New Pioneer_VSX_Series_Remote_Control.NSSeperator()
        Me.NsSeperator2 = New Pioneer_VSX_Series_Remote_Control.NSSeperator()
        Me.CustomSideButton14 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.CustomSideButton15 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnZ2InputNext = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnZ2InputPrev = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnZ2Pwr = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.cmbZ2Inputs = New Pioneer_VSX_Series_Remote_Control.NSComboBox()
        Me.tabSound = New System.Windows.Forms.TabPage()
        Me.NsGroupBox4 = New Pioneer_VSX_Series_Remote_Control.NSGroupBox()
        Me.btnSoundVirtualSB = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnSoundPhaseControl = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnSoundPassthrough = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnSoundEQ = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnSoundPQLS = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnSoundVirtualHeight = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMCACC = New Pioneer_VSX_Series_Remote_Control.NSComboBox()
        Me.cmbSoundModes = New Pioneer_VSX_Series_Remote_Control.NSComboBox()
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
        Me.tabHDZone.SuspendLayout()
        Me.NsGroupBox2.SuspendLayout()
        Me.tabZone2.SuspendLayout()
        Me.NsGroupBox3.SuspendLayout()
        Me.tabSound.SuspendLayout()
        Me.NsGroupBox4.SuspendLayout()
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
        Me.CustomTheme1.Movable = True
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
        Me.NsGroupBox1.DrawSeperator = True
        Me.NsGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(386, 189)
        Me.NsGroupBox1.SubTitle = "Select Main Zone input"
        Me.NsGroupBox1.TabIndex = 3
        Me.NsGroupBox1.Text = "NsGroupBox1"
        Me.NsGroupBox1.Title = "Main Zone Input Select"
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
        Me.cmbMainInputs.Size = New System.Drawing.Size(366, 28)
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
        Me.tabHDZone.Controls.Add(Me.NsGroupBox2)
        Me.tabHDZone.Location = New System.Drawing.Point(5, 4)
        Me.tabHDZone.Name = "tabHDZone"
        Me.tabHDZone.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHDZone.Size = New System.Drawing.Size(386, 189)
        Me.tabHDZone.TabIndex = 1
        Me.tabHDZone.Text = "tabHDZone"
        '
        'NsGroupBox2
        '
        Me.NsGroupBox2.Controls.Add(Me.CustomSideButton5)
        Me.NsGroupBox2.Controls.Add(Me.CustomSideButton8)
        Me.NsGroupBox2.Controls.Add(Me.CustomSideButton6)
        Me.NsGroupBox2.Controls.Add(Me.CustomSideButton7)
        Me.NsGroupBox2.Controls.Add(Me.btnHDZInputNext)
        Me.NsGroupBox2.Controls.Add(Me.btnHDZInputPrev)
        Me.NsGroupBox2.Controls.Add(Me.btnHDZPwr)
        Me.NsGroupBox2.Controls.Add(Me.cmbHDZInputs)
        Me.NsGroupBox2.DrawSeperator = True
        Me.NsGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.NsGroupBox2.Name = "NsGroupBox2"
        Me.NsGroupBox2.Size = New System.Drawing.Size(386, 189)
        Me.NsGroupBox2.SubTitle = "Select HD Zone input"
        Me.NsGroupBox2.TabIndex = 4
        Me.NsGroupBox2.Text = "NsGroupBox2"
        Me.NsGroupBox2.Title = "HDZone Input Select"
        '
        'CustomSideButton5
        '
        Me.CustomSideButton5.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton5.Customization = ""
        Me.CustomSideButton5.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton5.Image = Nothing
        Me.CustomSideButton5.Location = New System.Drawing.Point(194, 149)
        Me.CustomSideButton5.Name = "CustomSideButton5"
        Me.CustomSideButton5.NoRounding = True
        Me.CustomSideButton5.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton5.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton5.TabIndex = 33
        Me.CustomSideButton5.Text = "CUSTOM FAVORITE 4"
        Me.CustomSideButton5.Transparent = False
        '
        'CustomSideButton8
        '
        Me.CustomSideButton8.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton8.Customization = ""
        Me.CustomSideButton8.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton8.Image = Nothing
        Me.CustomSideButton8.Location = New System.Drawing.Point(8, 149)
        Me.CustomSideButton8.Name = "CustomSideButton8"
        Me.CustomSideButton8.NoRounding = True
        Me.CustomSideButton8.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton8.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton8.TabIndex = 34
        Me.CustomSideButton8.Text = "CUSTOM FAVORITE 3"
        Me.CustomSideButton8.Transparent = False
        '
        'CustomSideButton6
        '
        Me.CustomSideButton6.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton6.Customization = ""
        Me.CustomSideButton6.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton6.Image = Nothing
        Me.CustomSideButton6.Location = New System.Drawing.Point(194, 113)
        Me.CustomSideButton6.Name = "CustomSideButton6"
        Me.CustomSideButton6.NoRounding = True
        Me.CustomSideButton6.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton6.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton6.TabIndex = 31
        Me.CustomSideButton6.Text = "CUSTOM FAVORITE 2"
        Me.CustomSideButton6.Transparent = False
        '
        'CustomSideButton7
        '
        Me.CustomSideButton7.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton7.Customization = ""
        Me.CustomSideButton7.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton7.Image = Nothing
        Me.CustomSideButton7.Location = New System.Drawing.Point(8, 113)
        Me.CustomSideButton7.Name = "CustomSideButton7"
        Me.CustomSideButton7.NoRounding = True
        Me.CustomSideButton7.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton7.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton7.TabIndex = 32
        Me.CustomSideButton7.Text = "CUSTOM FAVORITE 1"
        Me.CustomSideButton7.Transparent = False
        '
        'btnHDZInputNext
        '
        Me.btnHDZInputNext.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnHDZInputNext.Customization = ""
        Me.btnHDZInputNext.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.btnHDZInputNext.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnHDZInputNext.Image = Nothing
        Me.btnHDZInputNext.Location = New System.Drawing.Point(194, 77)
        Me.btnHDZInputNext.Name = "btnHDZInputNext"
        Me.btnHDZInputNext.NoRounding = False
        Me.btnHDZInputNext.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnHDZInputNext.Size = New System.Drawing.Size(180, 30)
        Me.btnHDZInputNext.TabIndex = 29
        Me.btnHDZInputNext.Text = "INPUT NAME (NEXT)"
        Me.btnHDZInputNext.Transparent = False
        '
        'btnHDZInputPrev
        '
        Me.btnHDZInputPrev.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnHDZInputPrev.Customization = ""
        Me.btnHDZInputPrev.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.btnHDZInputPrev.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnHDZInputPrev.Image = Nothing
        Me.btnHDZInputPrev.Location = New System.Drawing.Point(8, 77)
        Me.btnHDZInputPrev.Name = "btnHDZInputPrev"
        Me.btnHDZInputPrev.NoRounding = False
        Me.btnHDZInputPrev.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnHDZInputPrev.Size = New System.Drawing.Size(180, 30)
        Me.btnHDZInputPrev.TabIndex = 30
        Me.btnHDZInputPrev.Text = "INPUT NAME (PREV)"
        Me.btnHDZInputPrev.Transparent = False
        '
        'btnHDZPwr
        '
        Me.btnHDZPwr.BackColor = System.Drawing.Color.Black
        Me.btnHDZPwr.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnHDZPwr.Customization = ""
        Me.btnHDZPwr.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnHDZPwr.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnHDZPwr.Image = Nothing
        Me.btnHDZPwr.Location = New System.Drawing.Point(252, 5)
        Me.btnHDZPwr.Name = "btnHDZPwr"
        Me.btnHDZPwr.NoRounding = False
        Me.btnHDZPwr.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Green
        Me.btnHDZPwr.Size = New System.Drawing.Size(122, 30)
        Me.btnHDZPwr.TabIndex = 28
        Me.btnHDZPwr.Text = " HDZONE ON"
        Me.btnHDZPwr.Transparent = False
        '
        'cmbHDZInputs
        '
        Me.cmbHDZInputs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbHDZInputs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbHDZInputs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHDZInputs.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHDZInputs.ForeColor = System.Drawing.Color.White
        Me.cmbHDZInputs.FormattingEnabled = True
        Me.cmbHDZInputs.Location = New System.Drawing.Point(8, 44)
        Me.cmbHDZInputs.Name = "cmbHDZInputs"
        Me.cmbHDZInputs.Size = New System.Drawing.Size(366, 28)
        Me.cmbHDZInputs.TabIndex = 0
        '
        'tabZone2
        '
        Me.tabZone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabZone2.Controls.Add(Me.SliderZ2Volume)
        Me.tabZone2.Controls.Add(Me.btnZ2VolumeDown)
        Me.tabZone2.Controls.Add(Me.btnZ2VolumeUp)
        Me.tabZone2.Controls.Add(Me.btnZ2Mute)
        Me.tabZone2.Controls.Add(Me.CustomMiddleBar2)
        Me.tabZone2.Controls.Add(Me.NsGroupBox3)
        Me.tabZone2.Location = New System.Drawing.Point(5, 4)
        Me.tabZone2.Name = "tabZone2"
        Me.tabZone2.Size = New System.Drawing.Size(386, 189)
        Me.tabZone2.TabIndex = 2
        Me.tabZone2.Text = "tabZone2"
        '
        'SliderZ2Volume
        '
        Me.SliderZ2Volume.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SliderZ2Volume.Location = New System.Drawing.Point(58, 158)
        Me.SliderZ2Volume.Maximum = 81
        Me.SliderZ2Volume.Minimum = 0
        Me.SliderZ2Volume.Name = "SliderZ2Volume"
        Me.SliderZ2Volume.Size = New System.Drawing.Size(155, 23)
        Me.SliderZ2Volume.TabIndex = 22
        Me.SliderZ2Volume.Value = 0
        '
        'btnZ2VolumeDown
        '
        Me.btnZ2VolumeDown.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZ2VolumeDown.Customization = ""
        Me.btnZ2VolumeDown.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnZ2VolumeDown.Image = Nothing
        Me.btnZ2VolumeDown.Location = New System.Drawing.Point(8, 154)
        Me.btnZ2VolumeDown.Name = "btnZ2VolumeDown"
        Me.btnZ2VolumeDown.NoRounding = False
        Me.btnZ2VolumeDown.Size = New System.Drawing.Size(44, 30)
        Me.btnZ2VolumeDown.TabIndex = 18
        Me.btnZ2VolumeDown.Text = "VOL -"
        Me.btnZ2VolumeDown.Transparent = False
        '
        'btnZ2VolumeUp
        '
        Me.btnZ2VolumeUp.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZ2VolumeUp.Customization = ""
        Me.btnZ2VolumeUp.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnZ2VolumeUp.Image = Nothing
        Me.btnZ2VolumeUp.Location = New System.Drawing.Point(219, 154)
        Me.btnZ2VolumeUp.Name = "btnZ2VolumeUp"
        Me.btnZ2VolumeUp.NoRounding = False
        Me.btnZ2VolumeUp.Size = New System.Drawing.Size(44, 30)
        Me.btnZ2VolumeUp.TabIndex = 19
        Me.btnZ2VolumeUp.Text = "VOL +"
        Me.btnZ2VolumeUp.Transparent = False
        '
        'btnZ2Mute
        '
        Me.btnZ2Mute.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZ2Mute.Customization = ""
        Me.btnZ2Mute.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Custom_Image
        Me.btnZ2Mute.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnZ2Mute.Image = CType(resources.GetObject("btnZ2Mute.Image"), System.Drawing.Image)
        Me.btnZ2Mute.Location = New System.Drawing.Point(282, 154)
        Me.btnZ2Mute.Name = "btnZ2Mute"
        Me.btnZ2Mute.NoRounding = False
        Me.btnZ2Mute.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnZ2Mute.Size = New System.Drawing.Size(92, 30)
        Me.btnZ2Mute.TabIndex = 20
        Me.btnZ2Mute.Text = "  MUTE"
        Me.btnZ2Mute.Transparent = False
        '
        'CustomMiddleBar2
        '
        Me.CustomMiddleBar2.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomMiddleBar2.Customization = ""
        Me.CustomMiddleBar2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomMiddleBar2.Image = Nothing
        Me.CustomMiddleBar2.Location = New System.Drawing.Point(8, 154)
        Me.CustomMiddleBar2.Name = "CustomMiddleBar2"
        Me.CustomMiddleBar2.NoRounding = False
        Me.CustomMiddleBar2.Size = New System.Drawing.Size(255, 31)
        Me.CustomMiddleBar2.TabIndex = 21
        Me.CustomMiddleBar2.Text = "CustomMiddleBar2"
        Me.CustomMiddleBar2.Transparent = False
        '
        'NsGroupBox3
        '
        Me.NsGroupBox3.Controls.Add(Me.NsSeperator3)
        Me.NsGroupBox3.Controls.Add(Me.NsSeperator2)
        Me.NsGroupBox3.Controls.Add(Me.CustomSideButton14)
        Me.NsGroupBox3.Controls.Add(Me.CustomSideButton15)
        Me.NsGroupBox3.Controls.Add(Me.btnZ2InputNext)
        Me.NsGroupBox3.Controls.Add(Me.btnZ2InputPrev)
        Me.NsGroupBox3.Controls.Add(Me.btnZ2Pwr)
        Me.NsGroupBox3.Controls.Add(Me.cmbZ2Inputs)
        Me.NsGroupBox3.DrawSeperator = True
        Me.NsGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.NsGroupBox3.Name = "NsGroupBox3"
        Me.NsGroupBox3.Size = New System.Drawing.Size(386, 189)
        Me.NsGroupBox3.SubTitle = "Select Zone 2 input"
        Me.NsGroupBox3.TabIndex = 5
        Me.NsGroupBox3.Text = "NsGroupBox3"
        Me.NsGroupBox3.Title = "Zone 2 Input Select"
        '
        'NsSeperator3
        '
        Me.NsSeperator3.Location = New System.Drawing.Point(5, 144)
        Me.NsSeperator3.Name = "NsSeperator3"
        Me.NsSeperator3.Size = New System.Drawing.Size(375, 23)
        Me.NsSeperator3.TabIndex = 34
        Me.NsSeperator3.Text = "NsSeperator3"
        '
        'NsSeperator2
        '
        Me.NsSeperator2.Location = New System.Drawing.Point(39, 151)
        Me.NsSeperator2.Name = "NsSeperator2"
        Me.NsSeperator2.Size = New System.Drawing.Size(75, 23)
        Me.NsSeperator2.TabIndex = 33
        Me.NsSeperator2.Text = "NsSeperator2"
        '
        'CustomSideButton14
        '
        Me.CustomSideButton14.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton14.Customization = ""
        Me.CustomSideButton14.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton14.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton14.Image = Nothing
        Me.CustomSideButton14.Location = New System.Drawing.Point(194, 113)
        Me.CustomSideButton14.Name = "CustomSideButton14"
        Me.CustomSideButton14.NoRounding = True
        Me.CustomSideButton14.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton14.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton14.TabIndex = 31
        Me.CustomSideButton14.Text = "CUSTOM FAVORITE 2"
        Me.CustomSideButton14.Transparent = False
        '
        'CustomSideButton15
        '
        Me.CustomSideButton15.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton15.Customization = ""
        Me.CustomSideButton15.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.CustomSideButton15.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton15.Image = Nothing
        Me.CustomSideButton15.Location = New System.Drawing.Point(8, 113)
        Me.CustomSideButton15.Name = "CustomSideButton15"
        Me.CustomSideButton15.NoRounding = True
        Me.CustomSideButton15.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Yellow
        Me.CustomSideButton15.Size = New System.Drawing.Size(180, 30)
        Me.CustomSideButton15.TabIndex = 32
        Me.CustomSideButton15.Text = "CUSTOM FAVORITE 1"
        Me.CustomSideButton15.Transparent = False
        '
        'btnZ2InputNext
        '
        Me.btnZ2InputNext.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZ2InputNext.Customization = ""
        Me.btnZ2InputNext.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.btnZ2InputNext.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnZ2InputNext.Image = Nothing
        Me.btnZ2InputNext.Location = New System.Drawing.Point(194, 77)
        Me.btnZ2InputNext.Name = "btnZ2InputNext"
        Me.btnZ2InputNext.NoRounding = False
        Me.btnZ2InputNext.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnZ2InputNext.Size = New System.Drawing.Size(180, 30)
        Me.btnZ2InputNext.TabIndex = 29
        Me.btnZ2InputNext.Text = "INPUT NAME (NEXT)"
        Me.btnZ2InputNext.Transparent = False
        '
        'btnZ2InputPrev
        '
        Me.btnZ2InputPrev.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZ2InputPrev.Customization = ""
        Me.btnZ2InputPrev.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.btnZ2InputPrev.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnZ2InputPrev.Image = Nothing
        Me.btnZ2InputPrev.Location = New System.Drawing.Point(8, 77)
        Me.btnZ2InputPrev.Name = "btnZ2InputPrev"
        Me.btnZ2InputPrev.NoRounding = False
        Me.btnZ2InputPrev.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnZ2InputPrev.Size = New System.Drawing.Size(180, 30)
        Me.btnZ2InputPrev.TabIndex = 30
        Me.btnZ2InputPrev.Text = "INPUT NAME (PREV)"
        Me.btnZ2InputPrev.Transparent = False
        '
        'btnZ2Pwr
        '
        Me.btnZ2Pwr.BackColor = System.Drawing.Color.Black
        Me.btnZ2Pwr.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnZ2Pwr.Customization = ""
        Me.btnZ2Pwr.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnZ2Pwr.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnZ2Pwr.Image = Nothing
        Me.btnZ2Pwr.Location = New System.Drawing.Point(252, 5)
        Me.btnZ2Pwr.Name = "btnZ2Pwr"
        Me.btnZ2Pwr.NoRounding = False
        Me.btnZ2Pwr.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Green
        Me.btnZ2Pwr.Size = New System.Drawing.Size(122, 30)
        Me.btnZ2Pwr.TabIndex = 28
        Me.btnZ2Pwr.Text = " ZONE 2 ON"
        Me.btnZ2Pwr.Transparent = False
        '
        'cmbZ2Inputs
        '
        Me.cmbZ2Inputs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbZ2Inputs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbZ2Inputs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZ2Inputs.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbZ2Inputs.ForeColor = System.Drawing.Color.White
        Me.cmbZ2Inputs.FormattingEnabled = True
        Me.cmbZ2Inputs.Location = New System.Drawing.Point(8, 44)
        Me.cmbZ2Inputs.Name = "cmbZ2Inputs"
        Me.cmbZ2Inputs.Size = New System.Drawing.Size(366, 28)
        Me.cmbZ2Inputs.TabIndex = 0
        '
        'tabSound
        '
        Me.tabSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabSound.Controls.Add(Me.NsGroupBox4)
        Me.tabSound.Location = New System.Drawing.Point(5, 4)
        Me.tabSound.Name = "tabSound"
        Me.tabSound.Size = New System.Drawing.Size(386, 189)
        Me.tabSound.TabIndex = 3
        Me.tabSound.Text = "tabSound"
        '
        'NsGroupBox4
        '
        Me.NsGroupBox4.Controls.Add(Me.btnSoundVirtualSB)
        Me.NsGroupBox4.Controls.Add(Me.btnSoundPhaseControl)
        Me.NsGroupBox4.Controls.Add(Me.btnSoundPassthrough)
        Me.NsGroupBox4.Controls.Add(Me.btnSoundEQ)
        Me.NsGroupBox4.Controls.Add(Me.btnSoundPQLS)
        Me.NsGroupBox4.Controls.Add(Me.btnSoundVirtualHeight)
        Me.NsGroupBox4.Controls.Add(Me.Label2)
        Me.NsGroupBox4.Controls.Add(Me.Label1)
        Me.NsGroupBox4.Controls.Add(Me.cmbMCACC)
        Me.NsGroupBox4.Controls.Add(Me.cmbSoundModes)
        Me.NsGroupBox4.DrawSeperator = True
        Me.NsGroupBox4.ForeColor = System.Drawing.Color.White
        Me.NsGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.NsGroupBox4.Name = "NsGroupBox4"
        Me.NsGroupBox4.Size = New System.Drawing.Size(386, 189)
        Me.NsGroupBox4.SubTitle = "Change Surround Settings"
        Me.NsGroupBox4.TabIndex = 4
        Me.NsGroupBox4.Text = "NsGroupBox4"
        Me.NsGroupBox4.Title = "Sound Configuration"
        '
        'btnSoundVirtualSB
        '
        Me.btnSoundVirtualSB.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSoundVirtualSB.Customization = ""
        Me.btnSoundVirtualSB.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSoundVirtualSB.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSoundVirtualSB.Image = Nothing
        Me.btnSoundVirtualSB.Location = New System.Drawing.Point(7, 113)
        Me.btnSoundVirtualSB.Name = "btnSoundVirtualSB"
        Me.btnSoundVirtualSB.NoRounding = False
        Me.btnSoundVirtualSB.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnSoundVirtualSB.Size = New System.Drawing.Size(120, 30)
        Me.btnSoundVirtualSB.TabIndex = 3
        Me.btnSoundVirtualSB.Text = "Virtual SB"
        Me.btnSoundVirtualSB.Transparent = False
        '
        'btnSoundPhaseControl
        '
        Me.btnSoundPhaseControl.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSoundPhaseControl.Customization = ""
        Me.btnSoundPhaseControl.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSoundPhaseControl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSoundPhaseControl.Image = Nothing
        Me.btnSoundPhaseControl.Location = New System.Drawing.Point(133, 113)
        Me.btnSoundPhaseControl.Name = "btnSoundPhaseControl"
        Me.btnSoundPhaseControl.NoRounding = False
        Me.btnSoundPhaseControl.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnSoundPhaseControl.Size = New System.Drawing.Size(120, 30)
        Me.btnSoundPhaseControl.TabIndex = 3
        Me.btnSoundPhaseControl.Text = "Phase Control"
        Me.btnSoundPhaseControl.Transparent = False
        '
        'btnSoundPassthrough
        '
        Me.btnSoundPassthrough.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSoundPassthrough.Customization = ""
        Me.btnSoundPassthrough.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSoundPassthrough.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSoundPassthrough.Image = Nothing
        Me.btnSoundPassthrough.Location = New System.Drawing.Point(259, 113)
        Me.btnSoundPassthrough.Name = "btnSoundPassthrough"
        Me.btnSoundPassthrough.NoRounding = False
        Me.btnSoundPassthrough.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnSoundPassthrough.Size = New System.Drawing.Size(120, 30)
        Me.btnSoundPassthrough.TabIndex = 3
        Me.btnSoundPassthrough.Text = "Passthrough"
        Me.btnSoundPassthrough.Transparent = False
        '
        'btnSoundEQ
        '
        Me.btnSoundEQ.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSoundEQ.Customization = ""
        Me.btnSoundEQ.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSoundEQ.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSoundEQ.Image = Nothing
        Me.btnSoundEQ.Location = New System.Drawing.Point(259, 77)
        Me.btnSoundEQ.Name = "btnSoundEQ"
        Me.btnSoundEQ.NoRounding = False
        Me.btnSoundEQ.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnSoundEQ.Size = New System.Drawing.Size(120, 30)
        Me.btnSoundEQ.TabIndex = 3
        Me.btnSoundEQ.Text = "   Equalizer"
        Me.btnSoundEQ.Transparent = False
        '
        'btnSoundPQLS
        '
        Me.btnSoundPQLS.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSoundPQLS.Customization = ""
        Me.btnSoundPQLS.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSoundPQLS.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSoundPQLS.Image = Nothing
        Me.btnSoundPQLS.Location = New System.Drawing.Point(133, 77)
        Me.btnSoundPQLS.Name = "btnSoundPQLS"
        Me.btnSoundPQLS.NoRounding = False
        Me.btnSoundPQLS.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnSoundPQLS.Size = New System.Drawing.Size(120, 30)
        Me.btnSoundPQLS.TabIndex = 3
        Me.btnSoundPQLS.Text = "     PQLS"
        Me.btnSoundPQLS.Transparent = False
        '
        'btnSoundVirtualHeight
        '
        Me.btnSoundVirtualHeight.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnSoundVirtualHeight.Customization = ""
        Me.btnSoundVirtualHeight.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnSoundVirtualHeight.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSoundVirtualHeight.Image = Nothing
        Me.btnSoundVirtualHeight.Location = New System.Drawing.Point(7, 77)
        Me.btnSoundVirtualHeight.Name = "btnSoundVirtualHeight"
        Me.btnSoundVirtualHeight.NoRounding = False
        Me.btnSoundVirtualHeight.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnSoundVirtualHeight.Size = New System.Drawing.Size(120, 30)
        Me.btnSoundVirtualHeight.TabIndex = 3
        Me.btnSoundVirtualHeight.Text = "Virtual Height"
        Me.btnSoundVirtualHeight.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surround Mode:"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MCACC Memory:"
        '
        'cmbMCACC
        '
        Me.cmbMCACC.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbMCACC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMCACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMCACC.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMCACC.ForeColor = System.Drawing.Color.White
        Me.cmbMCACC.FormattingEnabled = True
        Me.cmbMCACC.Items.AddRange(New Object() {"MCACC MEMORY 1", "MCACC MEMORY 2", "MCACC MEMORY 3", "MCACC MEMORY 4", "MCACC MEMORY 5", "MCACC MEMORY 6"})
        Me.cmbMCACC.Location = New System.Drawing.Point(130, 152)
        Me.cmbMCACC.Name = "cmbMCACC"
        Me.cmbMCACC.Size = New System.Drawing.Size(244, 28)
        Me.cmbMCACC.TabIndex = 1
        '
        'cmbSoundModes
        '
        Me.cmbSoundModes.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbSoundModes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSoundModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSoundModes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSoundModes.ForeColor = System.Drawing.Color.White
        Me.cmbSoundModes.FormattingEnabled = True
        Me.cmbSoundModes.Location = New System.Drawing.Point(128, 43)
        Me.cmbSoundModes.Name = "cmbSoundModes"
        Me.cmbSoundModes.Size = New System.Drawing.Size(246, 28)
        Me.cmbSoundModes.TabIndex = 1
        Me.cmbSoundModes.Visible = False
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
        Me.tabNavigation.Size = New System.Drawing.Size(386, 189)
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
        Me.tabPlayback.Size = New System.Drawing.Size(386, 189)
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
        Me.tabHDZone.ResumeLayout(False)
        Me.NsGroupBox2.ResumeLayout(False)
        Me.tabZone2.ResumeLayout(False)
        Me.NsGroupBox3.ResumeLayout(False)
        Me.tabSound.ResumeLayout(False)
        Me.NsGroupBox4.ResumeLayout(False)
        Me.NsGroupBox4.PerformLayout()
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
    Friend WithEvents NsGroupBox2 As Pioneer_VSX_Series_Remote_Control.NSGroupBox
    Friend WithEvents CustomSideButton6 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomSideButton7 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnHDZInputNext As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnHDZInputPrev As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnHDZPwr As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents cmbHDZInputs As Pioneer_VSX_Series_Remote_Control.NSComboBox
    Friend WithEvents CustomSideButton5 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomSideButton8 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents SliderZ2Volume As Pioneer_VSX_Series_Remote_Control.NSTrackBar
    Friend WithEvents btnZ2VolumeDown As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnZ2VolumeUp As Pioneer_VSX_Series_Remote_Control.CustomButton
    Friend WithEvents btnZ2Mute As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomMiddleBar2 As Pioneer_VSX_Series_Remote_Control.CustomMiddleBar
    Friend WithEvents NsGroupBox3 As Pioneer_VSX_Series_Remote_Control.NSGroupBox
    Friend WithEvents CustomSideButton14 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomSideButton15 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnZ2InputNext As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnZ2InputPrev As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnZ2Pwr As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents cmbZ2Inputs As Pioneer_VSX_Series_Remote_Control.NSComboBox
    Friend WithEvents NsSeperator2 As Pioneer_VSX_Series_Remote_Control.NSSeperator
    Friend WithEvents NsSeperator3 As Pioneer_VSX_Series_Remote_Control.NSSeperator
    Friend WithEvents cmbSoundModes As Pioneer_VSX_Series_Remote_Control.NSComboBox
    Friend WithEvents NsGroupBox4 As Pioneer_VSX_Series_Remote_Control.NSGroupBox
    Friend WithEvents btnSoundVirtualSB As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnSoundPhaseControl As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnSoundPassthrough As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnSoundPQLS As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents btnSoundVirtualHeight As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMCACC As Pioneer_VSX_Series_Remote_Control.NSComboBox
    Friend WithEvents btnSoundEQ As Pioneer_VSX_Series_Remote_Control.CustomSideButton

End Class
