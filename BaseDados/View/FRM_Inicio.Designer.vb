<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Inicio))
        Me.BunifuFormDock1 = New Bunifu.UI.WinForms.BunifuFormDock()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.PServico_Card = New Bunifu.Framework.UI.BunifuCards()
        Me.PServico_TopPanel = New System.Windows.Forms.Panel()
        Me.PServico_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Pessoas_Card = New Bunifu.Framework.UI.BunifuCards()
        Me.Pessoas_TopPanel = New System.Windows.Forms.Panel()
        Me.Pessoas_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Definicoes_Card = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Definicoes_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Home_Card = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Home_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Home_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.PServico_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Pessoas_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Definicoes_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Panel_Menu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Sair_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Definicoes_BTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Pessoas_BTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PServico_BTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Home_BTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel_Top = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Notification_Tile = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Search_Textbox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.Notification_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Email_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserName_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.UserProfileFoto_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Panel_Main.SuspendLayout()
        Me.PServico_Card.SuspendLayout()
        Me.PServico_TopPanel.SuspendLayout()
        Me.Pessoas_Card.SuspendLayout()
        Me.Pessoas_TopPanel.SuspendLayout()
        Me.Definicoes_Card.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Home_Card.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Home_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PServico_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pessoas_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Definicoes_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Menu.SuspendLayout()
        CType(Me.Sair_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Top.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notification_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Email_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UserProfileFoto_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuFormDock1
        '
        Me.BunifuFormDock1.AllowFormDragging = True
        Me.BunifuFormDock1.AllowFormResizing = True
        Me.BunifuFormDock1.AllowOpacityChangesWhileDragging = False
        Me.BunifuFormDock1.ContainerControl = Me
        Me.BunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BunifuFormDock1.DockingIndicatorsOpacity = 0.5R
        Me.BunifuFormDock1.DockingOptions.DockAll = True
        Me.BunifuFormDock1.DockingOptions.DockBottomLeft = True
        Me.BunifuFormDock1.DockingOptions.DockBottomRight = True
        Me.BunifuFormDock1.DockingOptions.DockFullScreen = True
        Me.BunifuFormDock1.DockingOptions.DockLeft = True
        Me.BunifuFormDock1.DockingOptions.DockRight = True
        Me.BunifuFormDock1.DockingOptions.DockTopLeft = True
        Me.BunifuFormDock1.DockingOptions.DockTopRight = True
        Me.BunifuFormDock1.FormDraggingOpacity = 0.9R
        Me.BunifuFormDock1.ParentForm = Me
        Me.BunifuFormDock1.ShowCursorChanges = True
        Me.BunifuFormDock1.ShowDockingIndicators = True
        Me.BunifuFormDock1.TitleBarOptions.AllowFormDragging = True
        Me.BunifuFormDock1.TitleBarOptions.BunifuFormDock = Me.BunifuFormDock1
        Me.BunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = True
        Me.BunifuFormDock1.TitleBarOptions.TitleBarControl = Me.Panel_Top
        Me.BunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Main.Controls.Add(Me.Home_Card)
        Me.Panel_Main.Controls.Add(Me.PServico_Card)
        Me.Panel_Main.Controls.Add(Me.Pessoas_Card)
        Me.Panel_Main.Controls.Add(Me.Definicoes_Card)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(250, 65)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(780, 580)
        Me.Panel_Main.TabIndex = 2
        '
        'PServico_Card
        '
        Me.PServico_Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PServico_Card.BorderRadius = 10
        Me.PServico_Card.BottomSahddow = True
        Me.PServico_Card.color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PServico_Card.Controls.Add(Me.PServico_TopPanel)
        Me.PServico_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PServico_Card.LeftSahddow = False
        Me.PServico_Card.Location = New System.Drawing.Point(0, 0)
        Me.PServico_Card.Name = "PServico_Card"
        Me.PServico_Card.RightSahddow = True
        Me.PServico_Card.ShadowDepth = 20
        Me.PServico_Card.Size = New System.Drawing.Size(780, 580)
        Me.PServico_Card.TabIndex = 2
        '
        'PServico_TopPanel
        '
        Me.PServico_TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PServico_TopPanel.Controls.Add(Me.PServico_Label)
        Me.PServico_TopPanel.Controls.Add(Me.PServico_PictureBox)
        Me.PServico_TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PServico_TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.PServico_TopPanel.Name = "PServico_TopPanel"
        Me.PServico_TopPanel.Size = New System.Drawing.Size(780, 66)
        Me.PServico_TopPanel.TabIndex = 8
        '
        'PServico_Label
        '
        Me.PServico_Label.AutoEllipsis = False
        Me.PServico_Label.CursorType = Nothing
        Me.PServico_Label.Font = New System.Drawing.Font("Open Sans", 8.24!)
        Me.PServico_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PServico_Label.Location = New System.Drawing.Point(56, 10)
        Me.PServico_Label.Name = "PServico_Label"
        Me.PServico_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PServico_Label.Size = New System.Drawing.Size(315, 45)
        Me.PServico_Label.TabIndex = 4
        Me.PServico_Label.Text = "Passagem de Serviço"
        Me.PServico_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Pessoas_Card
        '
        Me.Pessoas_Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Pessoas_Card.BorderRadius = 10
        Me.Pessoas_Card.BottomSahddow = True
        Me.Pessoas_Card.color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Pessoas_Card.Controls.Add(Me.Pessoas_TopPanel)
        Me.Pessoas_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pessoas_Card.LeftSahddow = False
        Me.Pessoas_Card.Location = New System.Drawing.Point(0, 0)
        Me.Pessoas_Card.Name = "Pessoas_Card"
        Me.Pessoas_Card.RightSahddow = True
        Me.Pessoas_Card.ShadowDepth = 20
        Me.Pessoas_Card.Size = New System.Drawing.Size(780, 580)
        Me.Pessoas_Card.TabIndex = 1
        '
        'Pessoas_TopPanel
        '
        Me.Pessoas_TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Pessoas_TopPanel.Controls.Add(Me.Pessoas_Label)
        Me.Pessoas_TopPanel.Controls.Add(Me.Pessoas_PictureBox)
        Me.Pessoas_TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pessoas_TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.Pessoas_TopPanel.Name = "Pessoas_TopPanel"
        Me.Pessoas_TopPanel.Size = New System.Drawing.Size(780, 66)
        Me.Pessoas_TopPanel.TabIndex = 7
        '
        'Pessoas_Label
        '
        Me.Pessoas_Label.AutoEllipsis = False
        Me.Pessoas_Label.CursorType = Nothing
        Me.Pessoas_Label.Font = New System.Drawing.Font("Open Sans", 8.24!)
        Me.Pessoas_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Pessoas_Label.Location = New System.Drawing.Point(56, 10)
        Me.Pessoas_Label.Name = "Pessoas_Label"
        Me.Pessoas_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Pessoas_Label.Size = New System.Drawing.Size(122, 45)
        Me.Pessoas_Label.TabIndex = 4
        Me.Pessoas_Label.Text = "Pessoas"
        Me.Pessoas_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Definicoes_Card
        '
        Me.Definicoes_Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Definicoes_Card.BorderRadius = 10
        Me.Definicoes_Card.BottomSahddow = True
        Me.Definicoes_Card.color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Definicoes_Card.Controls.Add(Me.Panel3)
        Me.Definicoes_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Definicoes_Card.LeftSahddow = False
        Me.Definicoes_Card.Location = New System.Drawing.Point(0, 0)
        Me.Definicoes_Card.Name = "Definicoes_Card"
        Me.Definicoes_Card.RightSahddow = True
        Me.Definicoes_Card.ShadowDepth = 20
        Me.Definicoes_Card.Size = New System.Drawing.Size(780, 580)
        Me.Definicoes_Card.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Definicoes_Label)
        Me.Panel3.Controls.Add(Me.Definicoes_PictureBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(780, 66)
        Me.Panel3.TabIndex = 9
        '
        'Definicoes_Label
        '
        Me.Definicoes_Label.AutoEllipsis = False
        Me.Definicoes_Label.CursorType = Nothing
        Me.Definicoes_Label.Font = New System.Drawing.Font("Open Sans", 8.24!)
        Me.Definicoes_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Definicoes_Label.Location = New System.Drawing.Point(56, 10)
        Me.Definicoes_Label.Name = "Definicoes_Label"
        Me.Definicoes_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Definicoes_Label.Size = New System.Drawing.Size(158, 45)
        Me.Definicoes_Label.TabIndex = 4
        Me.Definicoes_Label.Text = "Definições"
        Me.Definicoes_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Home_Card
        '
        Me.Home_Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Home_Card.BorderRadius = 10
        Me.Home_Card.BottomSahddow = True
        Me.Home_Card.color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Home_Card.Controls.Add(Me.Panel2)
        Me.Home_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_Card.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_Card.LeftSahddow = False
        Me.Home_Card.Location = New System.Drawing.Point(0, 0)
        Me.Home_Card.Name = "Home_Card"
        Me.Home_Card.RightSahddow = True
        Me.Home_Card.ShadowDepth = 20
        Me.Home_Card.Size = New System.Drawing.Size(780, 580)
        Me.Home_Card.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Home_Label)
        Me.Panel2.Controls.Add(Me.Home_PictureBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 66)
        Me.Panel2.TabIndex = 6
        '
        'Home_Label
        '
        Me.Home_Label.AutoEllipsis = False
        Me.Home_Label.CursorType = Nothing
        Me.Home_Label.Font = New System.Drawing.Font("Open Sans", 8.24!)
        Me.Home_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Home_Label.Location = New System.Drawing.Point(56, 10)
        Me.Home_Label.Name = "Home_Label"
        Me.Home_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Home_Label.Size = New System.Drawing.Size(94, 45)
        Me.Home_Label.TabIndex = 4
        Me.Home_Label.Text = "Home"
        Me.Home_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Home_PictureBox
        '
        Me.Home_PictureBox.AllowFocused = False
        Me.Home_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Home_PictureBox.BorderRadius = 20
        Me.Home_PictureBox.Image = CType(resources.GetObject("Home_PictureBox.Image"), System.Drawing.Image)
        Me.Home_PictureBox.IsCircle = True
        Me.Home_PictureBox.Location = New System.Drawing.Point(9, 10)
        Me.Home_PictureBox.Name = "Home_PictureBox"
        Me.Home_PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.Home_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Home_PictureBox.TabIndex = 5
        Me.Home_PictureBox.TabStop = False
        Me.Home_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'PServico_PictureBox
        '
        Me.PServico_PictureBox.AllowFocused = False
        Me.PServico_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PServico_PictureBox.BorderRadius = 20
        Me.PServico_PictureBox.Image = CType(resources.GetObject("PServico_PictureBox.Image"), System.Drawing.Image)
        Me.PServico_PictureBox.IsCircle = True
        Me.PServico_PictureBox.Location = New System.Drawing.Point(9, 11)
        Me.PServico_PictureBox.Name = "PServico_PictureBox"
        Me.PServico_PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.PServico_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PServico_PictureBox.TabIndex = 5
        Me.PServico_PictureBox.TabStop = False
        Me.PServico_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Pessoas_PictureBox
        '
        Me.Pessoas_PictureBox.AllowFocused = False
        Me.Pessoas_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Pessoas_PictureBox.BorderRadius = 20
        Me.Pessoas_PictureBox.Image = CType(resources.GetObject("Pessoas_PictureBox.Image"), System.Drawing.Image)
        Me.Pessoas_PictureBox.IsCircle = True
        Me.Pessoas_PictureBox.Location = New System.Drawing.Point(10, 11)
        Me.Pessoas_PictureBox.Name = "Pessoas_PictureBox"
        Me.Pessoas_PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.Pessoas_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pessoas_PictureBox.TabIndex = 5
        Me.Pessoas_PictureBox.TabStop = False
        Me.Pessoas_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Definicoes_PictureBox
        '
        Me.Definicoes_PictureBox.AllowFocused = False
        Me.Definicoes_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Definicoes_PictureBox.BorderRadius = 20
        Me.Definicoes_PictureBox.Image = CType(resources.GetObject("Definicoes_PictureBox.Image"), System.Drawing.Image)
        Me.Definicoes_PictureBox.IsCircle = True
        Me.Definicoes_PictureBox.Location = New System.Drawing.Point(9, 11)
        Me.Definicoes_PictureBox.Name = "Definicoes_PictureBox"
        Me.Definicoes_PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.Definicoes_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Definicoes_PictureBox.TabIndex = 5
        Me.Definicoes_PictureBox.TabStop = False
        Me.Definicoes_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackgroundImage = CType(resources.GetObject("Panel_Menu.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Menu.Controls.Add(Me.Sair_PictureBox)
        Me.Panel_Menu.Controls.Add(Me.Definicoes_BTN)
        Me.Panel_Menu.Controls.Add(Me.Pessoas_BTN)
        Me.Panel_Menu.Controls.Add(Me.PServico_BTN)
        Me.Panel_Menu.Controls.Add(Me.Home_BTN)
        Me.Panel_Menu.Controls.Add(Me.BunifuSeparator3)
        Me.Panel_Menu.Controls.Add(Me.BunifuSeparator4)
        Me.Panel_Menu.Controls.Add(Me.BunifuSeparator5)
        Me.Panel_Menu.Controls.Add(Me.BunifuSeparator6)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Menu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Menu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Menu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 65)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Quality = 10
        Me.Panel_Menu.Size = New System.Drawing.Size(250, 580)
        Me.Panel_Menu.TabIndex = 1
        '
        'Sair_PictureBox
        '
        Me.Sair_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sair_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Sair_PictureBox.Image = CType(resources.GetObject("Sair_PictureBox.Image"), System.Drawing.Image)
        Me.Sair_PictureBox.Location = New System.Drawing.Point(12, 542)
        Me.Sair_PictureBox.Name = "Sair_PictureBox"
        Me.Sair_PictureBox.Size = New System.Drawing.Size(26, 26)
        Me.Sair_PictureBox.TabIndex = 8
        Me.Sair_PictureBox.TabStop = False
        '
        'Definicoes_BTN
        '
        Me.Definicoes_BTN.Active = False
        Me.Definicoes_BTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Definicoes_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Definicoes_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Definicoes_BTN.BorderRadius = 0
        Me.Definicoes_BTN.ButtonText = "        Definições"
        Me.Definicoes_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Definicoes_BTN.DisabledColor = System.Drawing.Color.Gray
        Me.Definicoes_BTN.Iconcolor = System.Drawing.Color.Transparent
        Me.Definicoes_BTN.Iconimage = CType(resources.GetObject("Definicoes_BTN.Iconimage"), System.Drawing.Image)
        Me.Definicoes_BTN.Iconimage_right = Nothing
        Me.Definicoes_BTN.Iconimage_right_Selected = Nothing
        Me.Definicoes_BTN.Iconimage_Selected = Nothing
        Me.Definicoes_BTN.IconMarginLeft = 20
        Me.Definicoes_BTN.IconMarginRight = 0
        Me.Definicoes_BTN.IconRightVisible = True
        Me.Definicoes_BTN.IconRightZoom = 0R
        Me.Definicoes_BTN.IconVisible = True
        Me.Definicoes_BTN.IconZoom = 50.0R
        Me.Definicoes_BTN.IsTab = True
        Me.Definicoes_BTN.Location = New System.Drawing.Point(0, 155)
        Me.Definicoes_BTN.Name = "Definicoes_BTN"
        Me.Definicoes_BTN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Definicoes_BTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Definicoes_BTN.OnHoverTextColor = System.Drawing.Color.White
        Me.Definicoes_BTN.selected = False
        Me.Definicoes_BTN.Size = New System.Drawing.Size(250, 48)
        Me.Definicoes_BTN.TabIndex = 6
        Me.Definicoes_BTN.Text = "        Definições"
        Me.Definicoes_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Definicoes_BTN.Textcolor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Definicoes_BTN.TextFont = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Bold)
        '
        'Pessoas_BTN
        '
        Me.Pessoas_BTN.Active = False
        Me.Pessoas_BTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Pessoas_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pessoas_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pessoas_BTN.BorderRadius = 0
        Me.Pessoas_BTN.ButtonText = "        Pessoas"
        Me.Pessoas_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pessoas_BTN.DisabledColor = System.Drawing.Color.Gray
        Me.Pessoas_BTN.Iconcolor = System.Drawing.Color.Transparent
        Me.Pessoas_BTN.Iconimage = CType(resources.GetObject("Pessoas_BTN.Iconimage"), System.Drawing.Image)
        Me.Pessoas_BTN.Iconimage_right = Nothing
        Me.Pessoas_BTN.Iconimage_right_Selected = Nothing
        Me.Pessoas_BTN.Iconimage_Selected = Nothing
        Me.Pessoas_BTN.IconMarginLeft = 20
        Me.Pessoas_BTN.IconMarginRight = 0
        Me.Pessoas_BTN.IconRightVisible = True
        Me.Pessoas_BTN.IconRightZoom = 0R
        Me.Pessoas_BTN.IconVisible = True
        Me.Pessoas_BTN.IconZoom = 50.0R
        Me.Pessoas_BTN.IsTab = True
        Me.Pessoas_BTN.Location = New System.Drawing.Point(0, 59)
        Me.Pessoas_BTN.Name = "Pessoas_BTN"
        Me.Pessoas_BTN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pessoas_BTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Pessoas_BTN.OnHoverTextColor = System.Drawing.Color.White
        Me.Pessoas_BTN.selected = False
        Me.Pessoas_BTN.Size = New System.Drawing.Size(250, 48)
        Me.Pessoas_BTN.TabIndex = 2
        Me.Pessoas_BTN.Text = "        Pessoas"
        Me.Pessoas_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pessoas_BTN.Textcolor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Pessoas_BTN.TextFont = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Bold)
        '
        'PServico_BTN
        '
        Me.PServico_BTN.Active = False
        Me.PServico_BTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PServico_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PServico_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PServico_BTN.BorderRadius = 0
        Me.PServico_BTN.ButtonText = "        Passagem de Serviço"
        Me.PServico_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PServico_BTN.DisabledColor = System.Drawing.Color.Gray
        Me.PServico_BTN.Iconcolor = System.Drawing.Color.Transparent
        Me.PServico_BTN.Iconimage = CType(resources.GetObject("PServico_BTN.Iconimage"), System.Drawing.Image)
        Me.PServico_BTN.Iconimage_right = Nothing
        Me.PServico_BTN.Iconimage_right_Selected = Nothing
        Me.PServico_BTN.Iconimage_Selected = Nothing
        Me.PServico_BTN.IconMarginLeft = 20
        Me.PServico_BTN.IconMarginRight = 0
        Me.PServico_BTN.IconRightVisible = True
        Me.PServico_BTN.IconRightZoom = 0R
        Me.PServico_BTN.IconVisible = True
        Me.PServico_BTN.IconZoom = 50.0R
        Me.PServico_BTN.IsTab = True
        Me.PServico_BTN.Location = New System.Drawing.Point(0, 107)
        Me.PServico_BTN.Name = "PServico_BTN"
        Me.PServico_BTN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PServico_BTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PServico_BTN.OnHoverTextColor = System.Drawing.Color.White
        Me.PServico_BTN.selected = False
        Me.PServico_BTN.Size = New System.Drawing.Size(250, 48)
        Me.PServico_BTN.TabIndex = 1
        Me.PServico_BTN.Text = "        Passagem de Serviço"
        Me.PServico_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PServico_BTN.Textcolor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PServico_BTN.TextFont = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Bold)
        '
        'Home_BTN
        '
        Me.Home_BTN.Active = True
        Me.Home_BTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Home_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Home_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Home_BTN.BorderRadius = 0
        Me.Home_BTN.ButtonText = "        Home"
        Me.Home_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_BTN.DisabledColor = System.Drawing.Color.Gray
        Me.Home_BTN.Iconcolor = System.Drawing.Color.Transparent
        Me.Home_BTN.Iconimage = CType(resources.GetObject("Home_BTN.Iconimage"), System.Drawing.Image)
        Me.Home_BTN.Iconimage_right = Nothing
        Me.Home_BTN.Iconimage_right_Selected = Nothing
        Me.Home_BTN.Iconimage_Selected = Nothing
        Me.Home_BTN.IconMarginLeft = 20
        Me.Home_BTN.IconMarginRight = 0
        Me.Home_BTN.IconRightVisible = True
        Me.Home_BTN.IconRightZoom = 0R
        Me.Home_BTN.IconVisible = True
        Me.Home_BTN.IconZoom = 50.0R
        Me.Home_BTN.IsTab = True
        Me.Home_BTN.Location = New System.Drawing.Point(0, 11)
        Me.Home_BTN.Name = "Home_BTN"
        Me.Home_BTN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Home_BTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Home_BTN.OnHoverTextColor = System.Drawing.Color.White
        Me.Home_BTN.selected = True
        Me.Home_BTN.Size = New System.Drawing.Size(250, 48)
        Me.Home_BTN.TabIndex = 1
        Me.Home_BTN.Text = "        Home"
        Me.Home_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Home_BTN.Textcolor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Home_BTN.TextFont = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(0, 53)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(250, 10)
        Me.BunifuSeparator3.TabIndex = 3
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(0, 101)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(250, 10)
        Me.BunifuSeparator4.TabIndex = 4
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(0, 149)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(250, 10)
        Me.BunifuSeparator5.TabIndex = 5
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 1
        Me.BunifuSeparator6.Location = New System.Drawing.Point(0, 197)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(250, 10)
        Me.BunifuSeparator6.TabIndex = 7
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel_Top.BackgroundImage = CType(resources.GetObject("Panel_Top.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Top.Controls.Add(Me.PictureBox1)
        Me.Panel_Top.Controls.Add(Me.BunifuLabel2)
        Me.Panel_Top.Controls.Add(Me.BunifuLabel1)
        Me.Panel_Top.Controls.Add(Me.BunifuTileButton1)
        Me.Panel_Top.Controls.Add(Me.Notification_Tile)
        Me.Panel_Top.Controls.Add(Me.Search_Textbox)
        Me.Panel_Top.Controls.Add(Me.Notification_PictureBox)
        Me.Panel_Top.Controls.Add(Me.Email_PictureBox)
        Me.Panel_Top.Controls.Add(Me.BunifuSeparator2)
        Me.Panel_Top.Controls.Add(Me.BunifuSeparator1)
        Me.Panel_Top.Controls.Add(Me.Panel1)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Top.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Top.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Top.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Quality = 10
        Me.Panel_Top.Size = New System.Drawing.Size(1030, 65)
        Me.Panel_Top.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Open Sans SemiBold", 5.8!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuLabel2.Location = New System.Drawing.Point(43, 42)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(79, 17)
        Me.BunifuLabel2.TabIndex = 8
        Me.BunifuLabel2.Text = "Base de Dados"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Open Sans ExtraBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(40, 12)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(111, 35)
        Me.BunifuLabel1.TabIndex = 8
        Me.BunifuLabel1.Text = "VIRGULA"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Nothing
        Me.BunifuTileButton1.ImagePosition = 0
        Me.BunifuTileButton1.ImageZoom = 0
        Me.BunifuTileButton1.LabelPosition = 18
        Me.BunifuTileButton1.LabelText = "10"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(825, 12)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(23, 23)
        Me.BunifuTileButton1.TabIndex = 9
        '
        'Notification_Tile
        '
        Me.Notification_Tile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notification_Tile.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Notification_Tile.color = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Notification_Tile.colorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Notification_Tile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Notification_Tile.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Notification_Tile.ForeColor = System.Drawing.Color.White
        Me.Notification_Tile.Image = Nothing
        Me.Notification_Tile.ImagePosition = 0
        Me.Notification_Tile.ImageZoom = 0
        Me.Notification_Tile.LabelPosition = 18
        Me.Notification_Tile.LabelText = "10"
        Me.Notification_Tile.Location = New System.Drawing.Point(760, 12)
        Me.Notification_Tile.Name = "Notification_Tile"
        Me.Notification_Tile.Size = New System.Drawing.Size(23, 23)
        Me.Notification_Tile.TabIndex = 8
        '
        'Search_Textbox
        '
        Me.Search_Textbox.AcceptsReturn = True
        Me.Search_Textbox.AcceptsTab = False
        Me.Search_Textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_Textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Search_Textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Search_Textbox.BackColor = System.Drawing.Color.Transparent
        Me.Search_Textbox.BackgroundImage = CType(resources.GetObject("Search_Textbox.BackgroundImage"), System.Drawing.Image)
        Me.Search_Textbox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Search_Textbox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Search_Textbox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Search_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Search_Textbox.BorderRadius = 30
        Me.Search_Textbox.BorderThickness = 0
        Me.Search_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Search_Textbox.DefaultFont = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Textbox.DefaultText = ""
        Me.Search_Textbox.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Search_Textbox.ForeColor = System.Drawing.Color.White
        Me.Search_Textbox.HideSelection = True
        Me.Search_Textbox.IconLeft = Global.BaseDados.My.Resources.Resources.icons8_Search_24px_1
        Me.Search_Textbox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Search_Textbox.IconPadding = 10
        Me.Search_Textbox.IconRight = Nothing
        Me.Search_Textbox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Search_Textbox.Location = New System.Drawing.Point(470, 12)
        Me.Search_Textbox.MaxLength = 100
        Me.Search_Textbox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Search_Textbox.Modified = False
        Me.Search_Textbox.Name = "Search_Textbox"
        Me.Search_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_Textbox.ReadOnly = False
        Me.Search_Textbox.SelectedText = ""
        Me.Search_Textbox.SelectionLength = 0
        Me.Search_Textbox.SelectionStart = 0
        Me.Search_Textbox.ShortcutsEnabled = True
        Me.Search_Textbox.Size = New System.Drawing.Size(241, 35)
        Me.Search_Textbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Search_Textbox.TabIndex = 0
        Me.Search_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Search_Textbox.TextMarginLeft = 7
        Me.Search_Textbox.TextPlaceholder = "Procurar por algo..."
        Me.Search_Textbox.UseSystemPasswordChar = False
        '
        'Notification_PictureBox
        '
        Me.Notification_PictureBox.AllowFocused = False
        Me.Notification_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notification_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Notification_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Notification_PictureBox.BorderRadius = 1
        Me.Notification_PictureBox.Image = CType(resources.GetObject("Notification_PictureBox.Image"), System.Drawing.Image)
        Me.Notification_PictureBox.IsCircle = False
        Me.Notification_PictureBox.Location = New System.Drawing.Point(746, 23)
        Me.Notification_PictureBox.Name = "Notification_PictureBox"
        Me.Notification_PictureBox.Size = New System.Drawing.Size(24, 24)
        Me.Notification_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Notification_PictureBox.TabIndex = 6
        Me.Notification_PictureBox.TabStop = False
        Me.Notification_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Email_PictureBox
        '
        Me.Email_PictureBox.AllowFocused = False
        Me.Email_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Email_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Email_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Email_PictureBox.BorderRadius = 0
        Me.Email_PictureBox.Image = CType(resources.GetObject("Email_PictureBox.Image"), System.Drawing.Image)
        Me.Email_PictureBox.IsCircle = False
        Me.Email_PictureBox.Location = New System.Drawing.Point(811, 23)
        Me.Email_PictureBox.Name = "Email_PictureBox"
        Me.Email_PictureBox.Size = New System.Drawing.Size(24, 24)
        Me.Email_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Email_PictureBox.TabIndex = 5
        Me.Email_PictureBox.TabStop = False
        Me.Email_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(698, 0)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(61, 65)
        Me.BunifuSeparator2.TabIndex = 4
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(760, 0)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(61, 65)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.UserName_Label)
        Me.Panel1.Controls.Add(Me.UserProfileFoto_PictureBox)
        Me.Panel1.Location = New System.Drawing.Point(854, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 65)
        Me.Panel1.TabIndex = 0
        '
        'UserName_Label
        '
        Me.UserName_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserName_Label.AutoEllipsis = False
        Me.UserName_Label.CursorType = Nothing
        Me.UserName_Label.Font = New System.Drawing.Font("Open Sans", 11.12!, System.Drawing.FontStyle.Bold)
        Me.UserName_Label.ForeColor = System.Drawing.Color.White
        Me.UserName_Label.Location = New System.Drawing.Point(12, 23)
        Me.UserName_Label.Name = "UserName_Label"
        Me.UserName_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName_Label.Size = New System.Drawing.Size(61, 24)
        Me.UserName_Label.TabIndex = 6
        Me.UserName_Label.Text = "#Nome"
        Me.UserName_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'UserProfileFoto_PictureBox
        '
        Me.UserProfileFoto_PictureBox.AllowFocused = False
        Me.UserProfileFoto_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserProfileFoto_PictureBox.BorderRadius = 17
        Me.UserProfileFoto_PictureBox.Image = CType(resources.GetObject("UserProfileFoto_PictureBox.Image"), System.Drawing.Image)
        Me.UserProfileFoto_PictureBox.IsCircle = True
        Me.UserProfileFoto_PictureBox.Location = New System.Drawing.Point(128, 18)
        Me.UserProfileFoto_PictureBox.Name = "UserProfileFoto_PictureBox"
        Me.UserProfileFoto_PictureBox.Size = New System.Drawing.Size(35, 35)
        Me.UserProfileFoto_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserProfileFoto_PictureBox.TabIndex = 0
        Me.UserProfileFoto_PictureBox.TabStop = False
        Me.UserProfileFoto_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'FRM_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 645)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel_Main.ResumeLayout(False)
        Me.PServico_Card.ResumeLayout(False)
        Me.PServico_TopPanel.ResumeLayout(False)
        Me.PServico_TopPanel.PerformLayout()
        Me.Pessoas_Card.ResumeLayout(False)
        Me.Pessoas_TopPanel.ResumeLayout(False)
        Me.Pessoas_TopPanel.PerformLayout()
        Me.Definicoes_Card.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Home_Card.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Home_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PServico_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pessoas_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Definicoes_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Menu.ResumeLayout(False)
        CType(Me.Sair_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notification_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Email_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserProfileFoto_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuFormDock1 As Bunifu.UI.WinForms.BunifuFormDock
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel_Menu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel_Top As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Home_BTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Pessoas_BTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PServico_BTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Notification_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Email_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Search_Textbox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents UserName_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents UserProfileFoto_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Home_Card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Definicoes_BTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Definicoes_Card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PServico_Card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Pessoas_Card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Home_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Home_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Pessoas_TopPanel As Panel
    Friend WithEvents Pessoas_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Pessoas_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents PServico_TopPanel As Panel
    Friend WithEvents PServico_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PServico_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Definicoes_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Definicoes_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Notification_Tile As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Sair_PictureBox As PictureBox
End Class
