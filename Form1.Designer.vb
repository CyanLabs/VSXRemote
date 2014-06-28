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
        Me.CustomTheme1 = New Pioneer_VSX_Series_Remote_Control.CustomTheme()
        Me.SliderMVolume = New Pioneer_VSX_Series_Remote_Control.NSTrackBar()
        Me.CustomSideButton1 = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnPwr = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.btnHide = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnMVolumeDown = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnMVolumeUp = New Pioneer_VSX_Series_Remote_Control.CustomButton()
        Me.btnMute = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.lblPowerOff = New System.Windows.Forms.Label()
        Me.lblMuted = New System.Windows.Forms.Label()
        Me.lblMVolume = New System.Windows.Forms.Label()
        Me.CustomMiddleBar1 = New Pioneer_VSX_Series_Remote_Control.CustomMiddleBar()
        Me.btnpwer = New Pioneer_VSX_Series_Remote_Control.CustomSideButton()
        Me.NotifyIcon1Menu.SuspendLayout()
        Me.CustomTheme1.SuspendLayout()
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
        'CustomTheme1
        '
        Me.CustomTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.CustomTheme1.Controls.Add(Me.SliderMVolume)
        Me.CustomTheme1.Controls.Add(Me.CustomSideButton1)
        Me.CustomTheme1.Controls.Add(Me.btnPwr)
        Me.CustomTheme1.Controls.Add(Me.btnHide)
        Me.CustomTheme1.Controls.Add(Me.btnMVolumeDown)
        Me.CustomTheme1.Controls.Add(Me.btnMVolumeUp)
        Me.CustomTheme1.Controls.Add(Me.btnMute)
        Me.CustomTheme1.Controls.Add(Me.lblPowerOff)
        Me.CustomTheme1.Controls.Add(Me.lblMuted)
        Me.CustomTheme1.Controls.Add(Me.lblMVolume)
        Me.CustomTheme1.Controls.Add(Me.CustomMiddleBar1)
        Me.CustomTheme1.Customization = "6Ojo//z8/P/y8vL//////1BQUP//////AAAA////////////lpaW/w=="
        Me.CustomTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomTheme1.Image = Nothing
        Me.CustomTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CustomTheme1.Movable = True
        Me.CustomTheme1.Name = "CustomTheme1"
        Me.CustomTheme1.NoRounding = False
        Me.CustomTheme1.Sizable = True
        Me.CustomTheme1.Size = New System.Drawing.Size(261, 348)
        Me.CustomTheme1.SmartBounds = True
        Me.CustomTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.CustomTheme1.TabIndex = 3
        Me.CustomTheme1.Text = "VSX Remote"
        Me.CustomTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CustomTheme1.Transparent = False
        '
        'SliderMVolume
        '
        Me.SliderMVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SliderMVolume.Location = New System.Drawing.Point(12, 103)
        Me.SliderMVolume.Maximum = 10
        Me.SliderMVolume.Minimum = 0
        Me.SliderMVolume.Name = "SliderMVolume"
        Me.SliderMVolume.Size = New System.Drawing.Size(237, 23)
        Me.SliderMVolume.TabIndex = 17
        Me.SliderMVolume.Text = "NsTrackBar1"
        Me.SliderMVolume.Value = 0
        '
        'CustomSideButton1
        '
        Me.CustomSideButton1.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomSideButton1.Customization = ""
        Me.CustomSideButton1.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Square
        Me.CustomSideButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomSideButton1.Image = Nothing
        Me.CustomSideButton1.Location = New System.Drawing.Point(22, 306)
        Me.CustomSideButton1.Name = "CustomSideButton1"
        Me.CustomSideButton1.NoRounding = False
        Me.CustomSideButton1.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.CustomSideButton1.Size = New System.Drawing.Size(237, 30)
        Me.CustomSideButton1.TabIndex = 15
        Me.CustomSideButton1.Text = "Input 1"
        Me.CustomSideButton1.Transparent = False
        '
        'btnPwr
        '
        Me.btnPwr.BackColor = System.Drawing.Color.Black
        Me.btnPwr.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnPwr.Customization = ""
        Me.btnPwr.DisplayIcon = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Icon.Circle
        Me.btnPwr.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnPwr.Image = Nothing
        Me.btnPwr.Location = New System.Drawing.Point(4, 28)
        Me.btnPwr.Name = "btnPwr"
        Me.btnPwr.NoRounding = False
        Me.btnPwr.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnPwr.Size = New System.Drawing.Size(63, 30)
        Me.btnPwr.TabIndex = 8
        Me.btnPwr.Text = "OFF"
        Me.btnPwr.Transparent = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Black
        Me.btnHide.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.btnHide.Customization = ""
        Me.btnHide.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnHide.Image = Nothing
        Me.btnHide.Location = New System.Drawing.Point(210, 5)
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
        Me.btnMVolumeDown.Location = New System.Drawing.Point(10, 65)
        Me.btnMVolumeDown.Name = "btnMVolumeDown"
        Me.btnMVolumeDown.NoRounding = False
        Me.btnMVolumeDown.Size = New System.Drawing.Size(58, 30)
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
        Me.btnMVolumeUp.Location = New System.Drawing.Point(74, 65)
        Me.btnMVolumeUp.Name = "btnMVolumeUp"
        Me.btnMVolumeUp.NoRounding = False
        Me.btnMVolumeUp.Size = New System.Drawing.Size(58, 30)
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
        Me.btnMute.Location = New System.Drawing.Point(148, 65)
        Me.btnMute.Name = "btnMute"
        Me.btnMute.NoRounding = False
        Me.btnMute.SideColor = Pioneer_VSX_Series_Remote_Control.CustomSideButton._Color.Red
        Me.btnMute.Size = New System.Drawing.Size(101, 30)
        Me.btnMute.TabIndex = 12
        Me.btnMute.Text = "   MUTE"
        Me.btnMute.Transparent = False
        '
        'lblPowerOff
        '
        Me.lblPowerOff.BackColor = System.Drawing.Color.Black
        Me.lblPowerOff.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerOff.ForeColor = System.Drawing.Color.Red
        Me.lblPowerOff.Location = New System.Drawing.Point(3, 27)
        Me.lblPowerOff.Name = "lblPowerOff"
        Me.lblPowerOff.Size = New System.Drawing.Size(256, 33)
        Me.lblPowerOff.TabIndex = 13
        Me.lblPowerOff.Text = "DEVICE OFF"
        Me.lblPowerOff.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMuted
        '
        Me.lblMuted.BackColor = System.Drawing.Color.Black
        Me.lblMuted.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuted.ForeColor = System.Drawing.Color.Red
        Me.lblMuted.Location = New System.Drawing.Point(3, 27)
        Me.lblMuted.Name = "lblMuted"
        Me.lblMuted.Size = New System.Drawing.Size(256, 33)
        Me.lblMuted.TabIndex = 11
        Me.lblMuted.Text = "VOLUME MUTED"
        Me.lblMuted.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMuted.Visible = False
        '
        'lblMVolume
        '
        Me.lblMVolume.BackColor = System.Drawing.Color.Black
        Me.lblMVolume.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMVolume.ForeColor = System.Drawing.Color.Lime
        Me.lblMVolume.Location = New System.Drawing.Point(3, 27)
        Me.lblMVolume.Name = "lblMVolume"
        Me.lblMVolume.Size = New System.Drawing.Size(256, 33)
        Me.lblMVolume.TabIndex = 2
        Me.lblMVolume.Text = "VOLUME 000%"
        Me.lblMVolume.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CustomMiddleBar1
        '
        Me.CustomMiddleBar1.Colors = New Pioneer_VSX_Series_Remote_Control.Bloom(-1) {}
        Me.CustomMiddleBar1.Customization = ""
        Me.CustomMiddleBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CustomMiddleBar1.Image = Nothing
        Me.CustomMiddleBar1.Location = New System.Drawing.Point(10, 65)
        Me.CustomMiddleBar1.Name = "CustomMiddleBar1"
        Me.CustomMiddleBar1.NoRounding = False
        Me.CustomMiddleBar1.Size = New System.Drawing.Size(122, 31)
        Me.CustomMiddleBar1.TabIndex = 14
        Me.CustomMiddleBar1.Text = "CustomMiddleBar1"
        Me.CustomMiddleBar1.Transparent = False
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
        Me.ClientSize = New System.Drawing.Size(261, 348)
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
    Friend WithEvents lblMuted As System.Windows.Forms.Label
    Friend WithEvents btnMute As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents lblPowerOff As System.Windows.Forms.Label
    Friend WithEvents CustomSideButton1 As Pioneer_VSX_Series_Remote_Control.CustomSideButton
    Friend WithEvents CustomMiddleBar1 As Pioneer_VSX_Series_Remote_Control.CustomMiddleBar
    Friend WithEvents SliderMVolume As Pioneer_VSX_Series_Remote_Control.NSTrackBar

End Class
