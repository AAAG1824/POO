<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuCheckBox1 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuPictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 23)
        Me.Panel2.TabIndex = 2
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 11
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(777, 0)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 2
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(278, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash
        Me.BunifuButton2.ButtonText = "Aceptar"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = False
        BorderEdges1.BottomRight = False
        BorderEdges1.TopLeft = False
        BorderEdges1.TopRight = False
        Me.BunifuButton2.CustomizableEdges = BorderEdges1
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.Empty
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.Empty
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.IconLeft = Nothing
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRight = Nothing
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 25
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton2.IdleBorderRadius = 0
        Me.BunifuButton2.IdleBorderThickness = 0
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.Empty
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(330, 399)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 1
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 1
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton2.onHoverState.BorderRadius = 1
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 1
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.Firebrick
        Me.BunifuButton2.OnIdleState.BorderRadius = 1
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash
        Me.BunifuButton2.OnIdleState.BorderThickness = 1
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton2.OnPressedState.BorderRadius = 1
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 1
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(150, 39)
        Me.BunifuButton2.TabIndex = 6
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(330, 344)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 7
        '
        'BunifuCheckBox1
        '
        Me.BunifuCheckBox1.AllowBindingControlAnimation = True
        Me.BunifuCheckBox1.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox1.AllowBindingControlLocation = True
        Me.BunifuCheckBox1.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox1.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox1.AllowOnHoverStates = True
        Me.BunifuCheckBox1.AutoCheck = True
        Me.BunifuCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.BackgroundImage = CType(resources.GetObject("BunifuCheckBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox1.BorderRadius = 12
        Me.BunifuCheckBox1.Checked = False
        Me.BunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.BunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCheckBox1.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox1.Location = New System.Drawing.Point(486, 343)
        Me.BunifuCheckBox1.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox1.Name = "BunifuCheckBox1"
        Me.BunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCheckBox1.OnCheck.BorderRadius = 12
        Me.BunifuCheckBox1.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.BorderRadius = 12
        Me.BunifuCheckBox1.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.BorderRadius = 12
        Me.BunifuCheckBox1.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1
        Me.BunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.BunifuCheckBox1.OnUncheck.BorderRadius = 12
        Me.BunifuCheckBox1.OnUncheck.BorderThickness = 1
        Me.BunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round
        Me.BunifuCheckBox1.TabIndex = 9
        Me.BunifuCheckBox1.ThreeState = False
        Me.BunifuCheckBox1.ToolTipText = Nothing
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuCheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel2.ResumeLayout(False)
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuCheckBox1 As Bunifu.UI.WinForms.BunifuCheckBox
End Class
