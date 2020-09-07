<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGouraud
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
        Me.grpTranslate = New System.Windows.Forms.GroupBox()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnResetTranslate = New System.Windows.Forms.Button()
        Me.btnTranslateMinY = New System.Windows.Forms.Button()
        Me.btnTranslatePlusY = New System.Windows.Forms.Button()
        Me.btnTranslateMinX = New System.Windows.Forms.Button()
        Me.btnTranslatePlusX = New System.Windows.Forms.Button()
        Me.txtTranslateY = New System.Windows.Forms.TextBox()
        Me.txtTranslateX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBoxAmbient = New System.Windows.Forms.GroupBox()
        Me.btnChangeAmbient = New System.Windows.Forms.Button()
        Me.btnMinAmbient = New System.Windows.Forms.Button()
        Me.btnPlusAmbient = New System.Windows.Forms.Button()
        Me.txtCoefAmbient = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxDiffuse = New System.Windows.Forms.GroupBox()
        Me.btnChangeDiffuse = New System.Windows.Forms.Button()
        Me.btnMinDiffuse = New System.Windows.Forms.Button()
        Me.btnPlusDiffuse = New System.Windows.Forms.Button()
        Me.txtCoefDiffuse = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBoxSpecular = New System.Windows.Forms.GroupBox()
        Me.btnChangeSpecular = New System.Windows.Forms.Button()
        Me.btnMinReflectSpecular = New System.Windows.Forms.Button()
        Me.btnPlusReflectSpecular = New System.Windows.Forms.Button()
        Me.txtRExponentSpecular = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnMinSpecular = New System.Windows.Forms.Button()
        Me.btnPlusSpecular = New System.Windows.Forms.Button()
        Me.txtCoefSpecular = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxLightSource = New System.Windows.Forms.GroupBox()
        Me.btnChangeLight = New System.Windows.Forms.Button()
        Me.btnResetLight = New System.Windows.Forms.Button()
        Me.btnMinLightZ = New System.Windows.Forms.Button()
        Me.btnPlusLightZ = New System.Windows.Forms.Button()
        Me.btnMinLightY = New System.Windows.Forms.Button()
        Me.btnPlusLightY = New System.Windows.Forms.Button()
        Me.btnMinLightX = New System.Windows.Forms.Button()
        Me.btnPlusLightX = New System.Windows.Forms.Button()
        Me.txtLightZ = New System.Windows.Forms.TextBox()
        Me.txtLightY = New System.Windows.Forms.TextBox()
        Me.txtLightX = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCenter = New System.Windows.Forms.Label()
        Me.grpTranslate.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAmbient.SuspendLayout()
        Me.GroupBoxDiffuse.SuspendLayout()
        Me.GroupBoxSpecular.SuspendLayout()
        Me.GroupBoxLightSource.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTranslate
        '
        Me.grpTranslate.Controls.Add(Me.btnTranslate)
        Me.grpTranslate.Controls.Add(Me.btnResetTranslate)
        Me.grpTranslate.Controls.Add(Me.btnTranslateMinY)
        Me.grpTranslate.Controls.Add(Me.btnTranslatePlusY)
        Me.grpTranslate.Controls.Add(Me.btnTranslateMinX)
        Me.grpTranslate.Controls.Add(Me.btnTranslatePlusX)
        Me.grpTranslate.Controls.Add(Me.txtTranslateY)
        Me.grpTranslate.Controls.Add(Me.txtTranslateX)
        Me.grpTranslate.Controls.Add(Me.Label2)
        Me.grpTranslate.Controls.Add(Me.Label1)
        Me.grpTranslate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grpTranslate.Location = New System.Drawing.Point(433, 12)
        Me.grpTranslate.Name = "grpTranslate"
        Me.grpTranslate.Size = New System.Drawing.Size(219, 181)
        Me.grpTranslate.TabIndex = 0
        Me.grpTranslate.TabStop = False
        Me.grpTranslate.Text = "Translate"
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(19, 110)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(182, 23)
        Me.btnTranslate.TabIndex = 14
        Me.btnTranslate.Text = "Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnResetTranslate
        '
        Me.btnResetTranslate.Location = New System.Drawing.Point(19, 141)
        Me.btnResetTranslate.Name = "btnResetTranslate"
        Me.btnResetTranslate.Size = New System.Drawing.Size(182, 23)
        Me.btnResetTranslate.TabIndex = 13
        Me.btnResetTranslate.Text = "Reset"
        Me.btnResetTranslate.UseVisualStyleBackColor = True
        '
        'btnTranslateMinY
        '
        Me.btnTranslateMinY.Location = New System.Drawing.Point(175, 66)
        Me.btnTranslateMinY.Name = "btnTranslateMinY"
        Me.btnTranslateMinY.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslateMinY.TabIndex = 9
        Me.btnTranslateMinY.Text = "-"
        Me.btnTranslateMinY.UseVisualStyleBackColor = True
        '
        'btnTranslatePlusY
        '
        Me.btnTranslatePlusY.Location = New System.Drawing.Point(143, 66)
        Me.btnTranslatePlusY.Name = "btnTranslatePlusY"
        Me.btnTranslatePlusY.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslatePlusY.TabIndex = 8
        Me.btnTranslatePlusY.Text = "+"
        Me.btnTranslatePlusY.UseVisualStyleBackColor = True
        '
        'btnTranslateMinX
        '
        Me.btnTranslateMinX.Location = New System.Drawing.Point(175, 32)
        Me.btnTranslateMinX.Name = "btnTranslateMinX"
        Me.btnTranslateMinX.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslateMinX.TabIndex = 7
        Me.btnTranslateMinX.Text = "-"
        Me.btnTranslateMinX.UseVisualStyleBackColor = True
        '
        'btnTranslatePlusX
        '
        Me.btnTranslatePlusX.Location = New System.Drawing.Point(143, 32)
        Me.btnTranslatePlusX.Name = "btnTranslatePlusX"
        Me.btnTranslatePlusX.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslatePlusX.TabIndex = 6
        Me.btnTranslatePlusX.Text = "+"
        Me.btnTranslatePlusX.UseVisualStyleBackColor = True
        '
        'txtTranslateY
        '
        Me.txtTranslateY.Location = New System.Drawing.Point(49, 68)
        Me.txtTranslateY.Name = "txtTranslateY"
        Me.txtTranslateY.Size = New System.Drawing.Size(86, 20)
        Me.txtTranslateY.TabIndex = 4
        '
        'txtTranslateX
        '
        Me.txtTranslateX.Location = New System.Drawing.Point(49, 34)
        Me.txtTranslateX.Name = "txtTranslateX"
        Me.txtTranslateX.Size = New System.Drawing.Size(86, 20)
        Me.txtTranslateX.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X: "
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.WindowText
        Me.PictureBox.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'GroupBoxAmbient
        '
        Me.GroupBoxAmbient.Controls.Add(Me.btnChangeAmbient)
        Me.GroupBoxAmbient.Controls.Add(Me.btnMinAmbient)
        Me.GroupBoxAmbient.Controls.Add(Me.btnPlusAmbient)
        Me.GroupBoxAmbient.Controls.Add(Me.txtCoefAmbient)
        Me.GroupBoxAmbient.Controls.Add(Me.Label7)
        Me.GroupBoxAmbient.Location = New System.Drawing.Point(658, 139)
        Me.GroupBoxAmbient.Name = "GroupBoxAmbient"
        Me.GroupBoxAmbient.Size = New System.Drawing.Size(216, 112)
        Me.GroupBoxAmbient.TabIndex = 29
        Me.GroupBoxAmbient.TabStop = False
        Me.GroupBoxAmbient.Text = "Ambient"
        '
        'btnChangeAmbient
        '
        Me.btnChangeAmbient.Location = New System.Drawing.Point(19, 71)
        Me.btnChangeAmbient.Name = "btnChangeAmbient"
        Me.btnChangeAmbient.Size = New System.Drawing.Size(182, 23)
        Me.btnChangeAmbient.TabIndex = 26
        Me.btnChangeAmbient.Text = "Change"
        Me.btnChangeAmbient.UseVisualStyleBackColor = True
        '
        'btnMinAmbient
        '
        Me.btnMinAmbient.Location = New System.Drawing.Point(173, 29)
        Me.btnMinAmbient.Name = "btnMinAmbient"
        Me.btnMinAmbient.Size = New System.Drawing.Size(26, 23)
        Me.btnMinAmbient.TabIndex = 14
        Me.btnMinAmbient.Text = "-"
        Me.btnMinAmbient.UseVisualStyleBackColor = True
        '
        'btnPlusAmbient
        '
        Me.btnPlusAmbient.Location = New System.Drawing.Point(141, 29)
        Me.btnPlusAmbient.Name = "btnPlusAmbient"
        Me.btnPlusAmbient.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusAmbient.TabIndex = 24
        Me.btnPlusAmbient.Text = "+"
        Me.btnPlusAmbient.UseVisualStyleBackColor = True
        '
        'txtCoefAmbient
        '
        Me.txtCoefAmbient.Location = New System.Drawing.Point(76, 31)
        Me.txtCoefAmbient.Name = "txtCoefAmbient"
        Me.txtCoefAmbient.Size = New System.Drawing.Size(59, 20)
        Me.txtCoefAmbient.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Coeficient"
        '
        'GroupBoxDiffuse
        '
        Me.GroupBoxDiffuse.Controls.Add(Me.btnChangeDiffuse)
        Me.GroupBoxDiffuse.Controls.Add(Me.btnMinDiffuse)
        Me.GroupBoxDiffuse.Controls.Add(Me.btnPlusDiffuse)
        Me.GroupBoxDiffuse.Controls.Add(Me.txtCoefDiffuse)
        Me.GroupBoxDiffuse.Controls.Add(Me.Label8)
        Me.GroupBoxDiffuse.Location = New System.Drawing.Point(658, 13)
        Me.GroupBoxDiffuse.Name = "GroupBoxDiffuse"
        Me.GroupBoxDiffuse.Size = New System.Drawing.Size(216, 120)
        Me.GroupBoxDiffuse.TabIndex = 30
        Me.GroupBoxDiffuse.TabStop = False
        Me.GroupBoxDiffuse.Text = "Diffuse"
        '
        'btnChangeDiffuse
        '
        Me.btnChangeDiffuse.Location = New System.Drawing.Point(17, 79)
        Me.btnChangeDiffuse.Name = "btnChangeDiffuse"
        Me.btnChangeDiffuse.Size = New System.Drawing.Size(182, 23)
        Me.btnChangeDiffuse.TabIndex = 29
        Me.btnChangeDiffuse.Text = "Change"
        Me.btnChangeDiffuse.UseVisualStyleBackColor = True
        '
        'btnMinDiffuse
        '
        Me.btnMinDiffuse.Location = New System.Drawing.Point(173, 36)
        Me.btnMinDiffuse.Name = "btnMinDiffuse"
        Me.btnMinDiffuse.Size = New System.Drawing.Size(26, 23)
        Me.btnMinDiffuse.TabIndex = 14
        Me.btnMinDiffuse.Text = "-"
        Me.btnMinDiffuse.UseVisualStyleBackColor = True
        '
        'btnPlusDiffuse
        '
        Me.btnPlusDiffuse.Location = New System.Drawing.Point(141, 36)
        Me.btnPlusDiffuse.Name = "btnPlusDiffuse"
        Me.btnPlusDiffuse.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusDiffuse.TabIndex = 24
        Me.btnPlusDiffuse.Text = "+"
        Me.btnPlusDiffuse.UseVisualStyleBackColor = True
        '
        'txtCoefDiffuse
        '
        Me.txtCoefDiffuse.Location = New System.Drawing.Point(76, 38)
        Me.txtCoefDiffuse.Name = "txtCoefDiffuse"
        Me.txtCoefDiffuse.Size = New System.Drawing.Size(59, 20)
        Me.txtCoefDiffuse.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Coeficient"
        '
        'GroupBoxSpecular
        '
        Me.GroupBoxSpecular.Controls.Add(Me.btnChangeSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.btnMinReflectSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.btnPlusReflectSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.txtRExponentSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.Label13)
        Me.GroupBoxSpecular.Controls.Add(Me.btnMinSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.btnPlusSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.txtCoefSpecular)
        Me.GroupBoxSpecular.Controls.Add(Me.Label9)
        Me.GroupBoxSpecular.Location = New System.Drawing.Point(658, 257)
        Me.GroupBoxSpecular.Name = "GroupBoxSpecular"
        Me.GroupBoxSpecular.Size = New System.Drawing.Size(216, 156)
        Me.GroupBoxSpecular.TabIndex = 31
        Me.GroupBoxSpecular.TabStop = False
        Me.GroupBoxSpecular.Text = "Specular"
        '
        'btnChangeSpecular
        '
        Me.btnChangeSpecular.Location = New System.Drawing.Point(19, 115)
        Me.btnChangeSpecular.Name = "btnChangeSpecular"
        Me.btnChangeSpecular.Size = New System.Drawing.Size(182, 23)
        Me.btnChangeSpecular.TabIndex = 25
        Me.btnChangeSpecular.Text = "Change"
        Me.btnChangeSpecular.UseVisualStyleBackColor = True
        '
        'btnMinReflectSpecular
        '
        Me.btnMinReflectSpecular.Location = New System.Drawing.Point(173, 68)
        Me.btnMinReflectSpecular.Name = "btnMinReflectSpecular"
        Me.btnMinReflectSpecular.Size = New System.Drawing.Size(26, 23)
        Me.btnMinReflectSpecular.TabIndex = 25
        Me.btnMinReflectSpecular.Text = "-"
        Me.btnMinReflectSpecular.UseVisualStyleBackColor = True
        '
        'btnPlusReflectSpecular
        '
        Me.btnPlusReflectSpecular.Location = New System.Drawing.Point(141, 68)
        Me.btnPlusReflectSpecular.Name = "btnPlusReflectSpecular"
        Me.btnPlusReflectSpecular.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusReflectSpecular.TabIndex = 27
        Me.btnPlusReflectSpecular.Text = "+"
        Me.btnPlusReflectSpecular.UseVisualStyleBackColor = True
        '
        'txtRExponentSpecular
        '
        Me.txtRExponentSpecular.Location = New System.Drawing.Point(76, 70)
        Me.txtRExponentSpecular.Name = "txtRExponentSpecular"
        Me.txtRExponentSpecular.Size = New System.Drawing.Size(59, 20)
        Me.txtRExponentSpecular.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Reflection"
        '
        'btnMinSpecular
        '
        Me.btnMinSpecular.Location = New System.Drawing.Point(173, 33)
        Me.btnMinSpecular.Name = "btnMinSpecular"
        Me.btnMinSpecular.Size = New System.Drawing.Size(26, 23)
        Me.btnMinSpecular.TabIndex = 14
        Me.btnMinSpecular.Text = "-"
        Me.btnMinSpecular.UseVisualStyleBackColor = True
        '
        'btnPlusSpecular
        '
        Me.btnPlusSpecular.Location = New System.Drawing.Point(141, 33)
        Me.btnPlusSpecular.Name = "btnPlusSpecular"
        Me.btnPlusSpecular.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusSpecular.TabIndex = 24
        Me.btnPlusSpecular.Text = "+"
        Me.btnPlusSpecular.UseVisualStyleBackColor = True
        '
        'txtCoefSpecular
        '
        Me.txtCoefSpecular.Location = New System.Drawing.Point(76, 35)
        Me.txtCoefSpecular.Name = "txtCoefSpecular"
        Me.txtCoefSpecular.Size = New System.Drawing.Size(59, 20)
        Me.txtCoefSpecular.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Coeficient"
        '
        'GroupBoxLightSource
        '
        Me.GroupBoxLightSource.Controls.Add(Me.btnChangeLight)
        Me.GroupBoxLightSource.Controls.Add(Me.btnResetLight)
        Me.GroupBoxLightSource.Controls.Add(Me.btnMinLightZ)
        Me.GroupBoxLightSource.Controls.Add(Me.btnPlusLightZ)
        Me.GroupBoxLightSource.Controls.Add(Me.btnMinLightY)
        Me.GroupBoxLightSource.Controls.Add(Me.btnPlusLightY)
        Me.GroupBoxLightSource.Controls.Add(Me.btnMinLightX)
        Me.GroupBoxLightSource.Controls.Add(Me.btnPlusLightX)
        Me.GroupBoxLightSource.Controls.Add(Me.txtLightZ)
        Me.GroupBoxLightSource.Controls.Add(Me.txtLightY)
        Me.GroupBoxLightSource.Controls.Add(Me.txtLightX)
        Me.GroupBoxLightSource.Controls.Add(Me.Label10)
        Me.GroupBoxLightSource.Controls.Add(Me.Label11)
        Me.GroupBoxLightSource.Controls.Add(Me.Label12)
        Me.GroupBoxLightSource.Location = New System.Drawing.Point(433, 200)
        Me.GroupBoxLightSource.Name = "GroupBoxLightSource"
        Me.GroupBoxLightSource.Size = New System.Drawing.Size(219, 213)
        Me.GroupBoxLightSource.TabIndex = 24
        Me.GroupBoxLightSource.TabStop = False
        Me.GroupBoxLightSource.Text = "Light Source"
        '
        'btnChangeLight
        '
        Me.btnChangeLight.Location = New System.Drawing.Point(19, 141)
        Me.btnChangeLight.Name = "btnChangeLight"
        Me.btnChangeLight.Size = New System.Drawing.Size(182, 23)
        Me.btnChangeLight.TabIndex = 24
        Me.btnChangeLight.Text = "Change"
        Me.btnChangeLight.UseVisualStyleBackColor = True
        '
        'btnResetLight
        '
        Me.btnResetLight.Location = New System.Drawing.Point(19, 172)
        Me.btnResetLight.Name = "btnResetLight"
        Me.btnResetLight.Size = New System.Drawing.Size(182, 23)
        Me.btnResetLight.TabIndex = 20
        Me.btnResetLight.Text = "Reset"
        Me.btnResetLight.UseVisualStyleBackColor = True
        '
        'btnMinLightZ
        '
        Me.btnMinLightZ.Location = New System.Drawing.Point(173, 100)
        Me.btnMinLightZ.Name = "btnMinLightZ"
        Me.btnMinLightZ.Size = New System.Drawing.Size(26, 23)
        Me.btnMinLightZ.TabIndex = 23
        Me.btnMinLightZ.Text = "-"
        Me.btnMinLightZ.UseVisualStyleBackColor = True
        '
        'btnPlusLightZ
        '
        Me.btnPlusLightZ.Location = New System.Drawing.Point(141, 100)
        Me.btnPlusLightZ.Name = "btnPlusLightZ"
        Me.btnPlusLightZ.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusLightZ.TabIndex = 22
        Me.btnPlusLightZ.Text = "+"
        Me.btnPlusLightZ.UseVisualStyleBackColor = True
        '
        'btnMinLightY
        '
        Me.btnMinLightY.Location = New System.Drawing.Point(173, 69)
        Me.btnMinLightY.Name = "btnMinLightY"
        Me.btnMinLightY.Size = New System.Drawing.Size(26, 23)
        Me.btnMinLightY.TabIndex = 21
        Me.btnMinLightY.Text = "-"
        Me.btnMinLightY.UseVisualStyleBackColor = True
        '
        'btnPlusLightY
        '
        Me.btnPlusLightY.Location = New System.Drawing.Point(141, 69)
        Me.btnPlusLightY.Name = "btnPlusLightY"
        Me.btnPlusLightY.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusLightY.TabIndex = 20
        Me.btnPlusLightY.Text = "+"
        Me.btnPlusLightY.UseVisualStyleBackColor = True
        '
        'btnMinLightX
        '
        Me.btnMinLightX.Location = New System.Drawing.Point(173, 35)
        Me.btnMinLightX.Name = "btnMinLightX"
        Me.btnMinLightX.Size = New System.Drawing.Size(26, 23)
        Me.btnMinLightX.TabIndex = 19
        Me.btnMinLightX.Text = "-"
        Me.btnMinLightX.UseVisualStyleBackColor = True
        '
        'btnPlusLightX
        '
        Me.btnPlusLightX.Location = New System.Drawing.Point(141, 35)
        Me.btnPlusLightX.Name = "btnPlusLightX"
        Me.btnPlusLightX.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusLightX.TabIndex = 18
        Me.btnPlusLightX.Text = "+"
        Me.btnPlusLightX.UseVisualStyleBackColor = True
        '
        'txtLightZ
        '
        Me.txtLightZ.Location = New System.Drawing.Point(49, 103)
        Me.txtLightZ.Name = "txtLightZ"
        Me.txtLightZ.Size = New System.Drawing.Size(86, 20)
        Me.txtLightZ.TabIndex = 17
        '
        'txtLightY
        '
        Me.txtLightY.Location = New System.Drawing.Point(49, 69)
        Me.txtLightY.Name = "txtLightY"
        Me.txtLightY.Size = New System.Drawing.Size(86, 20)
        Me.txtLightY.TabIndex = 16
        '
        'txtLightX
        '
        Me.txtLightX.Location = New System.Drawing.Point(49, 35)
        Me.txtLightX.Name = "txtLightX"
        Me.txtLightX.Size = New System.Drawing.Size(86, 20)
        Me.txtLightX.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Z: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Y: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "X: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Center: "
        '
        'lblCenter
        '
        Me.lblCenter.AutoSize = True
        Me.lblCenter.Location = New System.Drawing.Point(63, 421)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(39, 13)
        Me.lblCenter.TabIndex = 33
        Me.lblCenter.Text = "Label4"
        '
        'FormGouraud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 443)
        Me.Controls.Add(Me.lblCenter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBoxLightSource)
        Me.Controls.Add(Me.GroupBoxSpecular)
        Me.Controls.Add(Me.GroupBoxDiffuse)
        Me.Controls.Add(Me.GroupBoxAmbient)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.grpTranslate)
        Me.Name = "FormGouraud"
        Me.Text = "Form1"
        Me.grpTranslate.ResumeLayout(False)
        Me.grpTranslate.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAmbient.ResumeLayout(False)
        Me.GroupBoxAmbient.PerformLayout()
        Me.GroupBoxDiffuse.ResumeLayout(False)
        Me.GroupBoxDiffuse.PerformLayout()
        Me.GroupBoxSpecular.ResumeLayout(False)
        Me.GroupBoxSpecular.PerformLayout()
        Me.GroupBoxLightSource.ResumeLayout(False)
        Me.GroupBoxLightSource.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTranslate As GroupBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents btnTranslateMinY As Button
    Friend WithEvents btnTranslatePlusY As Button
    Friend WithEvents btnTranslateMinX As Button
    Friend WithEvents btnTranslatePlusX As Button
    Friend WithEvents txtTranslateY As TextBox
    Friend WithEvents txtTranslateX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResetTranslate As Button
    Friend WithEvents GroupBoxAmbient As GroupBox
    Friend WithEvents btnMinAmbient As Button
    Friend WithEvents btnPlusAmbient As Button
    Friend WithEvents txtCoefAmbient As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBoxDiffuse As GroupBox
    Friend WithEvents btnMinDiffuse As Button
    Friend WithEvents btnPlusDiffuse As Button
    Friend WithEvents txtCoefDiffuse As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBoxSpecular As GroupBox
    Friend WithEvents btnMinSpecular As Button
    Friend WithEvents btnPlusSpecular As Button
    Friend WithEvents txtCoefSpecular As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBoxLightSource As GroupBox
    Friend WithEvents btnMinLightZ As Button
    Friend WithEvents btnPlusLightZ As Button
    Friend WithEvents btnMinLightY As Button
    Friend WithEvents btnPlusLightY As Button
    Friend WithEvents btnMinLightX As Button
    Friend WithEvents btnPlusLightX As Button
    Friend WithEvents txtLightZ As TextBox
    Friend WithEvents txtLightY As TextBox
    Friend WithEvents txtLightX As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnMinReflectSpecular As Button
    Friend WithEvents btnPlusReflectSpecular As Button
    Friend WithEvents txtRExponentSpecular As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnResetLight As Button
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnChangeAmbient As Button
    Friend WithEvents btnChangeDiffuse As Button
    Friend WithEvents btnChangeSpecular As Button
    Friend WithEvents btnChangeLight As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCenter As Label
End Class
