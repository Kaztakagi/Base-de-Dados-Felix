<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_FRM
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
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_FRM))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Login_Card = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.NovoUtilizador_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ErroLogin_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ProfileFoto_PictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Cancel_BTN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Login_BTN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Pass_TextBox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.Utilizador_TextBox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Header_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Logo_PictureBox = New System.Windows.Forms.PictureBox()
        Me.NovoUtilizador_card = New Bunifu.Framework.UI.BunifuCards()
        Me.Nivel_TextBox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.PassReg2_TextBox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Info_Label = New Bunifu.UI.WinForms.BunifuLabel()
        Me.CancelarReg_BTN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.CriarConta_BTN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.PassReg_TextBox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.UtilizadorReg_TextBox = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuTransition1 = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.Login_Card.SuspendLayout()
        CType(Me.ProfileFoto_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Header_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NovoUtilizador_card.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Login_Card
        '
        Me.Login_Card.BackColor = System.Drawing.Color.White
        Me.Login_Card.BorderRadius = 5
        Me.Login_Card.BottomSahddow = True
        Me.Login_Card.color = System.Drawing.Color.White
        Me.Login_Card.Controls.Add(Me.BunifuLabel1)
        Me.Login_Card.Controls.Add(Me.NovoUtilizador_Label)
        Me.Login_Card.Controls.Add(Me.ErroLogin_Label)
        Me.Login_Card.Controls.Add(Me.ProfileFoto_PictureBox)
        Me.Login_Card.Controls.Add(Me.Cancel_BTN)
        Me.Login_Card.Controls.Add(Me.Login_BTN)
        Me.Login_Card.Controls.Add(Me.Pass_TextBox)
        Me.Login_Card.Controls.Add(Me.Utilizador_TextBox)
        Me.BunifuTransition1.SetDecoration(Me.Login_Card, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Login_Card.LeftSahddow = False
        Me.Login_Card.Location = New System.Drawing.Point(101, 149)
        Me.Login_Card.Name = "Login_Card"
        Me.Login_Card.RightSahddow = True
        Me.Login_Card.ShadowDepth = 70
        Me.Login_Card.Size = New System.Drawing.Size(342, 405)
        Me.Login_Card.TabIndex = 1
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuTransition1.SetDecoration(Me.BunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel1.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuLabel1.Location = New System.Drawing.Point(163, 361)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(98, 19)
        Me.BunifuLabel1.TabIndex = 8
        Me.BunifuLabel1.Text = "Criar uma conta"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'NovoUtilizador_Label
        '
        Me.NovoUtilizador_Label.AutoEllipsis = False
        Me.NovoUtilizador_Label.CursorType = Nothing
        Me.BunifuTransition1.SetDecoration(Me.NovoUtilizador_Label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.NovoUtilizador_Label.Font = New System.Drawing.Font("Open Sans", 8.8!)
        Me.NovoUtilizador_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NovoUtilizador_Label.Location = New System.Drawing.Point(71, 362)
        Me.NovoUtilizador_Label.Name = "NovoUtilizador_Label"
        Me.NovoUtilizador_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NovoUtilizador_Label.Size = New System.Drawing.Size(89, 17)
        Me.NovoUtilizador_Label.TabIndex = 7
        Me.NovoUtilizador_Label.Text = "Novo Utilizador?"
        Me.NovoUtilizador_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'ErroLogin_Label
        '
        Me.ErroLogin_Label.AutoEllipsis = False
        Me.ErroLogin_Label.CursorType = Nothing
        Me.BunifuTransition1.SetDecoration(Me.ErroLogin_Label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ErroLogin_Label.Font = New System.Drawing.Font("Open Sans SemiBold", 11.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ErroLogin_Label.ForeColor = System.Drawing.Color.Red
        Me.ErroLogin_Label.Location = New System.Drawing.Point(40, 286)
        Me.ErroLogin_Label.Name = "ErroLogin_Label"
        Me.ErroLogin_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ErroLogin_Label.Size = New System.Drawing.Size(255, 14)
        Me.ErroLogin_Label.TabIndex = 6
        Me.ErroLogin_Label.Text = "Credenciais erradas, pf verifique os dados inseridos"
        Me.ErroLogin_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErroLogin_Label.Visible = False
        '
        'ProfileFoto_PictureBox
        '
        Me.ProfileFoto_PictureBox.AllowFocused = False
        Me.ProfileFoto_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProfileFoto_PictureBox.BorderRadius = 50
        Me.BunifuTransition1.SetDecoration(Me.ProfileFoto_PictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ProfileFoto_PictureBox.Image = Global.BaseDados.My.Resources.Resources.Profile
        Me.ProfileFoto_PictureBox.IsCircle = True
        Me.ProfileFoto_PictureBox.Location = New System.Drawing.Point(119, 40)
        Me.ProfileFoto_PictureBox.Name = "ProfileFoto_PictureBox"
        Me.ProfileFoto_PictureBox.Size = New System.Drawing.Size(100, 100)
        Me.ProfileFoto_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfileFoto_PictureBox.TabIndex = 5
        Me.ProfileFoto_PictureBox.TabStop = False
        Me.ProfileFoto_PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Cancel_BTN
        '
        Me.Cancel_BTN.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_BTN.BackgroundImage = CType(resources.GetObject("Cancel_BTN.BackgroundImage"), System.Drawing.Image)
        Me.Cancel_BTN.ButtonText = "CANCELAR"
        Me.Cancel_BTN.ButtonTextMarginLeft = 0
        Me.BunifuTransition1.SetDecoration(Me.Cancel_BTN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Cancel_BTN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Cancel_BTN.DisabledFillColor = System.Drawing.Color.Gray
        Me.Cancel_BTN.DisabledForecolor = System.Drawing.Color.White
        Me.Cancel_BTN.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_BTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Cancel_BTN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Cancel_BTN.IconPadding = 10
        Me.Cancel_BTN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Cancel_BTN.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Cancel_BTN.IdleBorderRadius = 1
        Me.Cancel_BTN.IdleBorderThickness = 0
        Me.Cancel_BTN.IdleFillColor = System.Drawing.Color.White
        Me.Cancel_BTN.IdleIconLeftImage = Nothing
        Me.Cancel_BTN.IdleIconRightImage = Nothing
        Me.Cancel_BTN.Location = New System.Drawing.Point(172, 317)
        Me.Cancel_BTN.Name = "Cancel_BTN"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.Cancel_BTN.onHoverState = StateProperties3
        Me.Cancel_BTN.Size = New System.Drawing.Size(137, 33)
        Me.Cancel_BTN.TabIndex = 4
        Me.Cancel_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login_BTN
        '
        Me.Login_BTN.BackColor = System.Drawing.Color.Transparent
        Me.Login_BTN.BackgroundImage = CType(resources.GetObject("Login_BTN.BackgroundImage"), System.Drawing.Image)
        Me.Login_BTN.ButtonText = "ENTRAR"
        Me.Login_BTN.ButtonTextMarginLeft = 0
        Me.BunifuTransition1.SetDecoration(Me.Login_BTN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Login_BTN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Login_BTN.DisabledFillColor = System.Drawing.Color.Gray
        Me.Login_BTN.DisabledForecolor = System.Drawing.Color.White
        Me.Login_BTN.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_BTN.ForeColor = System.Drawing.Color.White
        Me.Login_BTN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Login_BTN.IconPadding = 10
        Me.Login_BTN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Login_BTN.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Login_BTN.IdleBorderRadius = 1
        Me.Login_BTN.IdleBorderThickness = 0
        Me.Login_BTN.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Login_BTN.IdleIconLeftImage = Nothing
        Me.Login_BTN.IdleIconRightImage = Nothing
        Me.Login_BTN.Location = New System.Drawing.Point(29, 317)
        Me.Login_BTN.Name = "Login_BTN"
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.Login_BTN.onHoverState = StateProperties4
        Me.Login_BTN.Size = New System.Drawing.Size(137, 33)
        Me.Login_BTN.TabIndex = 1
        Me.Login_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pass_TextBox
        '
        Me.Pass_TextBox.AcceptsReturn = False
        Me.Pass_TextBox.AcceptsTab = False
        Me.Pass_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Pass_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Pass_TextBox.BackColor = System.Drawing.Color.Transparent
        Me.Pass_TextBox.BackgroundImage = CType(resources.GetObject("Pass_TextBox.BackgroundImage"), System.Drawing.Image)
        Me.Pass_TextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Pass_TextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Pass_TextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Pass_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pass_TextBox.BorderRadius = 30
        Me.Pass_TextBox.BorderThickness = 1
        Me.Pass_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.Pass_TextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Pass_TextBox.DefaultFont = New System.Drawing.Font("Open Sans SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_TextBox.DefaultText = ""
        Me.Pass_TextBox.FillColor = System.Drawing.Color.White
        Me.Pass_TextBox.HideSelection = True
        Me.Pass_TextBox.IconLeft = CType(resources.GetObject("Pass_TextBox.IconLeft"), System.Drawing.Image)
        Me.Pass_TextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Pass_TextBox.IconPadding = 10
        Me.Pass_TextBox.IconRight = Nothing
        Me.Pass_TextBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Pass_TextBox.Location = New System.Drawing.Point(68, 240)
        Me.Pass_TextBox.MaxLength = 8
        Me.Pass_TextBox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Pass_TextBox.Modified = False
        Me.Pass_TextBox.Name = "Pass_TextBox"
        Me.Pass_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass_TextBox.ReadOnly = False
        Me.Pass_TextBox.SelectedText = ""
        Me.Pass_TextBox.SelectionLength = 0
        Me.Pass_TextBox.SelectionStart = 0
        Me.Pass_TextBox.ShortcutsEnabled = True
        Me.Pass_TextBox.Size = New System.Drawing.Size(200, 35)
        Me.Pass_TextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Pass_TextBox.TabIndex = 3
        Me.Pass_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Pass_TextBox.TextMarginLeft = 10
        Me.Pass_TextBox.TextPlaceholder = "Palavra-Passe"
        Me.Pass_TextBox.UseSystemPasswordChar = False
        '
        'Utilizador_TextBox
        '
        Me.Utilizador_TextBox.AcceptsReturn = False
        Me.Utilizador_TextBox.AcceptsTab = False
        Me.Utilizador_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Utilizador_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Utilizador_TextBox.BackColor = System.Drawing.Color.Transparent
        Me.Utilizador_TextBox.BackgroundImage = CType(resources.GetObject("Utilizador_TextBox.BackgroundImage"), System.Drawing.Image)
        Me.Utilizador_TextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Utilizador_TextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Utilizador_TextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Utilizador_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Utilizador_TextBox.BorderRadius = 30
        Me.Utilizador_TextBox.BorderThickness = 1
        Me.Utilizador_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.Utilizador_TextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Utilizador_TextBox.DefaultFont = New System.Drawing.Font("Open Sans SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utilizador_TextBox.DefaultText = ""
        Me.Utilizador_TextBox.FillColor = System.Drawing.Color.White
        Me.Utilizador_TextBox.HideSelection = True
        Me.Utilizador_TextBox.IconLeft = CType(resources.GetObject("Utilizador_TextBox.IconLeft"), System.Drawing.Image)
        Me.Utilizador_TextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Utilizador_TextBox.IconPadding = 10
        Me.Utilizador_TextBox.IconRight = Nothing
        Me.Utilizador_TextBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Utilizador_TextBox.Location = New System.Drawing.Point(68, 183)
        Me.Utilizador_TextBox.MaxLength = 10
        Me.Utilizador_TextBox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Utilizador_TextBox.Modified = False
        Me.Utilizador_TextBox.Name = "Utilizador_TextBox"
        Me.Utilizador_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Utilizador_TextBox.ReadOnly = False
        Me.Utilizador_TextBox.SelectedText = ""
        Me.Utilizador_TextBox.SelectionLength = 0
        Me.Utilizador_TextBox.SelectionStart = 0
        Me.Utilizador_TextBox.ShortcutsEnabled = True
        Me.Utilizador_TextBox.Size = New System.Drawing.Size(200, 35)
        Me.Utilizador_TextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Utilizador_TextBox.TabIndex = 2
        Me.Utilizador_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Utilizador_TextBox.TextMarginLeft = 10
        Me.Utilizador_TextBox.TextPlaceholder = "Utilizador"
        Me.Utilizador_TextBox.UseSystemPasswordChar = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header_PictureBox
        Me.BunifuDragControl1.Vertical = True
        '
        'Header_PictureBox
        '
        Me.Header_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.Header_PictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Header_PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.Header_PictureBox.Name = "Header_PictureBox"
        Me.Header_PictureBox.Size = New System.Drawing.Size(544, 202)
        Me.Header_PictureBox.TabIndex = 0
        Me.Header_PictureBox.TabStop = False
        '
        'Logo_PictureBox
        '
        Me.Logo_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.Logo_PictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Logo_PictureBox.Image = CType(resources.GetObject("Logo_PictureBox.Image"), System.Drawing.Image)
        Me.Logo_PictureBox.Location = New System.Drawing.Point(213, 5)
        Me.Logo_PictureBox.Name = "Logo_PictureBox"
        Me.Logo_PictureBox.Size = New System.Drawing.Size(118, 138)
        Me.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo_PictureBox.TabIndex = 2
        Me.Logo_PictureBox.TabStop = False
        '
        'NovoUtilizador_card
        '
        Me.NovoUtilizador_card.BackColor = System.Drawing.Color.White
        Me.NovoUtilizador_card.BorderRadius = 5
        Me.NovoUtilizador_card.BottomSahddow = True
        Me.NovoUtilizador_card.color = System.Drawing.Color.White
        Me.NovoUtilizador_card.Controls.Add(Me.Nivel_TextBox)
        Me.NovoUtilizador_card.Controls.Add(Me.PassReg2_TextBox)
        Me.NovoUtilizador_card.Controls.Add(Me.BunifuLabel5)
        Me.NovoUtilizador_card.Controls.Add(Me.Info_Label)
        Me.NovoUtilizador_card.Controls.Add(Me.CancelarReg_BTN)
        Me.NovoUtilizador_card.Controls.Add(Me.CriarConta_BTN)
        Me.NovoUtilizador_card.Controls.Add(Me.PassReg_TextBox)
        Me.NovoUtilizador_card.Controls.Add(Me.UtilizadorReg_TextBox)
        Me.BunifuTransition1.SetDecoration(Me.NovoUtilizador_card, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.NovoUtilizador_card.LeftSahddow = False
        Me.NovoUtilizador_card.Location = New System.Drawing.Point(101, 149)
        Me.NovoUtilizador_card.Name = "NovoUtilizador_card"
        Me.NovoUtilizador_card.RightSahddow = True
        Me.NovoUtilizador_card.ShadowDepth = 70
        Me.NovoUtilizador_card.Size = New System.Drawing.Size(342, 405)
        Me.NovoUtilizador_card.TabIndex = 9
        '
        'Nivel_TextBox
        '
        Me.Nivel_TextBox.AcceptsReturn = False
        Me.Nivel_TextBox.AcceptsTab = False
        Me.Nivel_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Nivel_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Nivel_TextBox.BackColor = System.Drawing.Color.Transparent
        Me.Nivel_TextBox.BackgroundImage = CType(resources.GetObject("Nivel_TextBox.BackgroundImage"), System.Drawing.Image)
        Me.Nivel_TextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Nivel_TextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Nivel_TextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Nivel_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Nivel_TextBox.BorderRadius = 30
        Me.Nivel_TextBox.BorderThickness = 1
        Me.Nivel_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.Nivel_TextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Nivel_TextBox.DefaultFont = New System.Drawing.Font("Open Sans SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nivel_TextBox.DefaultText = "0"
        Me.Nivel_TextBox.FillColor = System.Drawing.Color.White
        Me.Nivel_TextBox.HideSelection = True
        Me.Nivel_TextBox.IconLeft = CType(resources.GetObject("Nivel_TextBox.IconLeft"), System.Drawing.Image)
        Me.Nivel_TextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Nivel_TextBox.IconPadding = 10
        Me.Nivel_TextBox.IconRight = Nothing
        Me.Nivel_TextBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Nivel_TextBox.Location = New System.Drawing.Point(168, 240)
        Me.Nivel_TextBox.MaxLength = 8
        Me.Nivel_TextBox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Nivel_TextBox.Modified = False
        Me.Nivel_TextBox.Name = "Nivel_TextBox"
        Me.Nivel_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nivel_TextBox.ReadOnly = False
        Me.Nivel_TextBox.SelectedText = ""
        Me.Nivel_TextBox.SelectionLength = 0
        Me.Nivel_TextBox.SelectionStart = 0
        Me.Nivel_TextBox.ShortcutsEnabled = True
        Me.Nivel_TextBox.Size = New System.Drawing.Size(100, 35)
        Me.Nivel_TextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Nivel_TextBox.TabIndex = 11
        Me.Nivel_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Nivel_TextBox.TextMarginLeft = 10
        Me.Nivel_TextBox.TextPlaceholder = ""
        Me.Nivel_TextBox.UseSystemPasswordChar = False
        Me.Nivel_TextBox.Visible = False
        '
        'PassReg2_TextBox
        '
        Me.PassReg2_TextBox.AcceptsReturn = False
        Me.PassReg2_TextBox.AcceptsTab = False
        Me.PassReg2_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PassReg2_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PassReg2_TextBox.BackColor = System.Drawing.Color.Transparent
        Me.PassReg2_TextBox.BackgroundImage = CType(resources.GetObject("PassReg2_TextBox.BackgroundImage"), System.Drawing.Image)
        Me.PassReg2_TextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PassReg2_TextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.PassReg2_TextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.PassReg2_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PassReg2_TextBox.BorderRadius = 30
        Me.PassReg2_TextBox.BorderThickness = 1
        Me.PassReg2_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.PassReg2_TextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PassReg2_TextBox.DefaultFont = New System.Drawing.Font("Open Sans SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassReg2_TextBox.DefaultText = ""
        Me.PassReg2_TextBox.FillColor = System.Drawing.Color.White
        Me.PassReg2_TextBox.HideSelection = True
        Me.PassReg2_TextBox.IconLeft = CType(resources.GetObject("PassReg2_TextBox.IconLeft"), System.Drawing.Image)
        Me.PassReg2_TextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.PassReg2_TextBox.IconPadding = 10
        Me.PassReg2_TextBox.IconRight = Nothing
        Me.PassReg2_TextBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.PassReg2_TextBox.Location = New System.Drawing.Point(71, 180)
        Me.PassReg2_TextBox.MaxLength = 8
        Me.PassReg2_TextBox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.PassReg2_TextBox.Modified = False
        Me.PassReg2_TextBox.Name = "PassReg2_TextBox"
        Me.PassReg2_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassReg2_TextBox.ReadOnly = False
        Me.PassReg2_TextBox.SelectedText = ""
        Me.PassReg2_TextBox.SelectionLength = 0
        Me.PassReg2_TextBox.SelectionStart = 0
        Me.PassReg2_TextBox.ShortcutsEnabled = True
        Me.PassReg2_TextBox.Size = New System.Drawing.Size(200, 35)
        Me.PassReg2_TextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.PassReg2_TextBox.TabIndex = 10
        Me.PassReg2_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PassReg2_TextBox.TextMarginLeft = 10
        Me.PassReg2_TextBox.TextPlaceholder = "Palavra-Passe"
        Me.PassReg2_TextBox.UseSystemPasswordChar = False
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuTransition1.SetDecoration(Me.BunifuLabel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel5.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuLabel5.Location = New System.Drawing.Point(53, 25)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(227, 28)
        Me.BunifuLabel5.TabIndex = 9
        Me.BunifuLabel5.Text = "REGISTRO NOVA CONTA"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Info_Label
        '
        Me.Info_Label.AutoEllipsis = False
        Me.Info_Label.CursorType = Nothing
        Me.BunifuTransition1.SetDecoration(Me.Info_Label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Info_Label.Font = New System.Drawing.Font("Open Sans SemiBold", 11.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Info_Label.ForeColor = System.Drawing.Color.Red
        Me.Info_Label.Location = New System.Drawing.Point(40, 286)
        Me.Info_Label.Name = "Info_Label"
        Me.Info_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Info_Label.Size = New System.Drawing.Size(255, 14)
        Me.Info_Label.TabIndex = 6
        Me.Info_Label.Text = "Credenciais erradas, pf verifique os dados inseridos"
        Me.Info_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Info_Label.Visible = False
        '
        'CancelarReg_BTN
        '
        Me.CancelarReg_BTN.BackColor = System.Drawing.Color.Transparent
        Me.CancelarReg_BTN.BackgroundImage = CType(resources.GetObject("CancelarReg_BTN.BackgroundImage"), System.Drawing.Image)
        Me.CancelarReg_BTN.ButtonText = "CANCELAR"
        Me.CancelarReg_BTN.ButtonTextMarginLeft = 0
        Me.BunifuTransition1.SetDecoration(Me.CancelarReg_BTN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.CancelarReg_BTN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.CancelarReg_BTN.DisabledFillColor = System.Drawing.Color.Gray
        Me.CancelarReg_BTN.DisabledForecolor = System.Drawing.Color.White
        Me.CancelarReg_BTN.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarReg_BTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CancelarReg_BTN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.CancelarReg_BTN.IconPadding = 10
        Me.CancelarReg_BTN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.CancelarReg_BTN.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.CancelarReg_BTN.IdleBorderRadius = 1
        Me.CancelarReg_BTN.IdleBorderThickness = 0
        Me.CancelarReg_BTN.IdleFillColor = System.Drawing.Color.White
        Me.CancelarReg_BTN.IdleIconLeftImage = Nothing
        Me.CancelarReg_BTN.IdleIconRightImage = Nothing
        Me.CancelarReg_BTN.Location = New System.Drawing.Point(172, 317)
        Me.CancelarReg_BTN.Name = "CancelarReg_BTN"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.CancelarReg_BTN.onHoverState = StateProperties1
        Me.CancelarReg_BTN.Size = New System.Drawing.Size(137, 33)
        Me.CancelarReg_BTN.TabIndex = 4
        Me.CancelarReg_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CriarConta_BTN
        '
        Me.CriarConta_BTN.BackColor = System.Drawing.Color.Transparent
        Me.CriarConta_BTN.BackgroundImage = CType(resources.GetObject("CriarConta_BTN.BackgroundImage"), System.Drawing.Image)
        Me.CriarConta_BTN.ButtonText = "CRIAR CONTA"
        Me.CriarConta_BTN.ButtonTextMarginLeft = 0
        Me.BunifuTransition1.SetDecoration(Me.CriarConta_BTN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.CriarConta_BTN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.CriarConta_BTN.DisabledFillColor = System.Drawing.Color.Gray
        Me.CriarConta_BTN.DisabledForecolor = System.Drawing.Color.White
        Me.CriarConta_BTN.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CriarConta_BTN.ForeColor = System.Drawing.Color.White
        Me.CriarConta_BTN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.CriarConta_BTN.IconPadding = 10
        Me.CriarConta_BTN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.CriarConta_BTN.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CriarConta_BTN.IdleBorderRadius = 1
        Me.CriarConta_BTN.IdleBorderThickness = 0
        Me.CriarConta_BTN.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CriarConta_BTN.IdleIconLeftImage = Nothing
        Me.CriarConta_BTN.IdleIconRightImage = Nothing
        Me.CriarConta_BTN.Location = New System.Drawing.Point(29, 317)
        Me.CriarConta_BTN.Name = "CriarConta_BTN"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.CriarConta_BTN.onHoverState = StateProperties2
        Me.CriarConta_BTN.Size = New System.Drawing.Size(137, 33)
        Me.CriarConta_BTN.TabIndex = 3
        Me.CriarConta_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PassReg_TextBox
        '
        Me.PassReg_TextBox.AcceptsReturn = False
        Me.PassReg_TextBox.AcceptsTab = False
        Me.PassReg_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PassReg_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PassReg_TextBox.BackColor = System.Drawing.Color.Transparent
        Me.PassReg_TextBox.BackgroundImage = CType(resources.GetObject("PassReg_TextBox.BackgroundImage"), System.Drawing.Image)
        Me.PassReg_TextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PassReg_TextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.PassReg_TextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.PassReg_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PassReg_TextBox.BorderRadius = 30
        Me.PassReg_TextBox.BorderThickness = 1
        Me.PassReg_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.PassReg_TextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PassReg_TextBox.DefaultFont = New System.Drawing.Font("Open Sans SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassReg_TextBox.DefaultText = ""
        Me.PassReg_TextBox.FillColor = System.Drawing.Color.White
        Me.PassReg_TextBox.HideSelection = True
        Me.PassReg_TextBox.IconLeft = CType(resources.GetObject("PassReg_TextBox.IconLeft"), System.Drawing.Image)
        Me.PassReg_TextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.PassReg_TextBox.IconPadding = 10
        Me.PassReg_TextBox.IconRight = Nothing
        Me.PassReg_TextBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.PassReg_TextBox.Location = New System.Drawing.Point(71, 128)
        Me.PassReg_TextBox.MaxLength = 8
        Me.PassReg_TextBox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.PassReg_TextBox.Modified = False
        Me.PassReg_TextBox.Name = "PassReg_TextBox"
        Me.PassReg_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassReg_TextBox.ReadOnly = False
        Me.PassReg_TextBox.SelectedText = ""
        Me.PassReg_TextBox.SelectionLength = 0
        Me.PassReg_TextBox.SelectionStart = 0
        Me.PassReg_TextBox.ShortcutsEnabled = True
        Me.PassReg_TextBox.Size = New System.Drawing.Size(200, 35)
        Me.PassReg_TextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.PassReg_TextBox.TabIndex = 2
        Me.PassReg_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PassReg_TextBox.TextMarginLeft = 10
        Me.PassReg_TextBox.TextPlaceholder = "Palavra-Passe"
        Me.PassReg_TextBox.UseSystemPasswordChar = False
        '
        'UtilizadorReg_TextBox
        '
        Me.UtilizadorReg_TextBox.AcceptsReturn = False
        Me.UtilizadorReg_TextBox.AcceptsTab = False
        Me.UtilizadorReg_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.UtilizadorReg_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.UtilizadorReg_TextBox.BackColor = System.Drawing.Color.Transparent
        Me.UtilizadorReg_TextBox.BackgroundImage = CType(resources.GetObject("UtilizadorReg_TextBox.BackgroundImage"), System.Drawing.Image)
        Me.UtilizadorReg_TextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UtilizadorReg_TextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.UtilizadorReg_TextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.UtilizadorReg_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.UtilizadorReg_TextBox.BorderRadius = 30
        Me.UtilizadorReg_TextBox.BorderThickness = 1
        Me.UtilizadorReg_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.UtilizadorReg_TextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.UtilizadorReg_TextBox.DefaultFont = New System.Drawing.Font("Open Sans SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtilizadorReg_TextBox.DefaultText = ""
        Me.UtilizadorReg_TextBox.FillColor = System.Drawing.Color.White
        Me.UtilizadorReg_TextBox.HideSelection = True
        Me.UtilizadorReg_TextBox.IconLeft = CType(resources.GetObject("UtilizadorReg_TextBox.IconLeft"), System.Drawing.Image)
        Me.UtilizadorReg_TextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.UtilizadorReg_TextBox.IconPadding = 10
        Me.UtilizadorReg_TextBox.IconRight = Nothing
        Me.UtilizadorReg_TextBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.UtilizadorReg_TextBox.Location = New System.Drawing.Point(71, 75)
        Me.UtilizadorReg_TextBox.MaxLength = 10
        Me.UtilizadorReg_TextBox.MinimumSize = New System.Drawing.Size(100, 35)
        Me.UtilizadorReg_TextBox.Modified = False
        Me.UtilizadorReg_TextBox.Name = "UtilizadorReg_TextBox"
        Me.UtilizadorReg_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UtilizadorReg_TextBox.ReadOnly = False
        Me.UtilizadorReg_TextBox.SelectedText = ""
        Me.UtilizadorReg_TextBox.SelectionLength = 0
        Me.UtilizadorReg_TextBox.SelectionStart = 0
        Me.UtilizadorReg_TextBox.ShortcutsEnabled = True
        Me.UtilizadorReg_TextBox.Size = New System.Drawing.Size(200, 35)
        Me.UtilizadorReg_TextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.UtilizadorReg_TextBox.TabIndex = 1
        Me.UtilizadorReg_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UtilizadorReg_TextBox.TextMarginLeft = 10
        Me.UtilizadorReg_TextBox.TextPlaceholder = "Utilizador"
        Me.UtilizadorReg_TextBox.UseSystemPasswordChar = False
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        Me.BunifuTransition1.MaxAnimationTime = 1000
        Me.BunifuTransition1.TimeStep = 0.01!
        '
        'Login_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 612)
        Me.Controls.Add(Me.NovoUtilizador_card)
        Me.Controls.Add(Me.Login_Card)
        Me.Controls.Add(Me.Logo_PictureBox)
        Me.Controls.Add(Me.Header_PictureBox)
        Me.BunifuTransition1.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_FRM"
        Me.Login_Card.ResumeLayout(False)
        Me.Login_Card.PerformLayout()
        CType(Me.ProfileFoto_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Header_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NovoUtilizador_card.ResumeLayout(False)
        Me.NovoUtilizador_card.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Login_Card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Utilizador_TextBox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Header_PictureBox As PictureBox
    Friend WithEvents Logo_PictureBox As PictureBox
    Friend WithEvents Pass_TextBox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Login_BTN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Cancel_BTN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ProfileFoto_PictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents ErroLogin_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents NovoUtilizador_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents NovoUtilizador_card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PassReg2_TextBox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Info_Label As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents CancelarReg_BTN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents CriarConta_BTN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PassReg_TextBox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents UtilizadorReg_TextBox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuTransition1 As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents Nivel_TextBox As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class
