Public Class FormGouraud

    Public op As New operation

    'Load
    Private Sub FormSphere_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        op.load()

        txtTranslateX.Text = op.translateX
        txtTranslateY.Text = op.translateY

        'load shading variable
        txtCoefAmbient.Text = op.coefAmbient
        txtCoefDiffuse.Text = op.coefDiffuse
        txtCoefSpecular.Text = op.coefSpecular
        txtRExponentSpecular.Text = op.rExponentSpecular

        txtLightX.Text = op.defaultlight(0)
        txtLightY.Text = op.defaultlight(1)
        txtLightZ.Text = op.defaultlight(2)

    End Sub

    'translate interface
    Private Sub btnTranslatePlusX_Click(sender As Object, e As EventArgs) Handles btnTranslatePlusX.Click
        txtTranslateX.Text += 0.01
    End Sub

    Private Sub btnTranslateMinX_Click(sender As Object, e As EventArgs) Handles btnTranslateMinX.Click
        txtTranslateX.Text -= 0.01
    End Sub

    Private Sub btnTranslatePlusY_Click(sender As Object, e As EventArgs) Handles btnTranslatePlusY.Click
        txtTranslateY.Text += 0.01
    End Sub

    Private Sub btnTranslateMinY_Click(sender As Object, e As EventArgs) Handles btnTranslateMinY.Click
        txtTranslateY.Text -= 0.01
    End Sub

    Private Sub btnResetTranslate_Click(sender As Object, e As EventArgs) Handles btnResetTranslate.Click
        txtTranslateX.Text = op.defaultTranslateX
        txtTranslateY.Text = op.defaultTranslateY
    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        op.translateX = txtTranslateX.Text
        op.translateY = txtTranslateY.Text
        op.process()
        op.translateX = 0
        op.translateY = 0
    End Sub

    'Shading interface ------------------------------------------------------------------------------

    'ambient
    Private Sub btnPlusAmbient_Click(sender As Object, e As EventArgs) Handles btnPlusAmbient.Click
        txtCoefAmbient.Text += 0.01
    End Sub

    Private Sub btnMinAmbient_Click(sender As Object, e As EventArgs) Handles btnMinAmbient.Click
        txtCoefAmbient.Text -= 0.01
    End Sub

    Private Sub btnChangeAmbient_Click(sender As Object, e As EventArgs) Handles btnChangeAmbient.Click
        op.coefAmbient = txtCoefAmbient.Text
        op.process()
    End Sub
    'diffuse
    Private Sub btnPlusDiffuse_Click(sender As Object, e As EventArgs) Handles btnPlusDiffuse.Click
        txtCoefDiffuse.Text += 0.01
    End Sub

    Private Sub btnMinDiffuse_Click(sender As Object, e As EventArgs) Handles btnMinDiffuse.Click
        txtCoefDiffuse.Text -= 0.01
    End Sub

    Private Sub btnChangeDiffuse_Click(sender As Object, e As EventArgs) Handles btnChangeDiffuse.Click
        op.coefDiffuse = txtCoefDiffuse.Text
        op.process()
    End Sub

    'specular
    Private Sub btnPlusSpecular_Click(sender As Object, e As EventArgs) Handles btnPlusSpecular.Click
        txtCoefSpecular.Text += 0.01
    End Sub

    Private Sub btnMinSpecular_Click(sender As Object, e As EventArgs) Handles btnMinSpecular.Click
        txtCoefSpecular.Text -= 0.01
    End Sub

    Private Sub btnPlusReflectSpecular_Click(sender As Object, e As EventArgs) Handles btnPlusReflectSpecular.Click
        txtRExponentSpecular.Text += 0.1
    End Sub

    Private Sub btnMinReflectSpecular_Click(sender As Object, e As EventArgs) Handles btnMinReflectSpecular.Click
        txtRExponentSpecular.Text -= 0.1
    End Sub

    Private Sub btnChangeSpecular_Click(sender As Object, e As EventArgs) Handles btnChangeSpecular.Click
        op.rExponentSpecular = txtRExponentSpecular.Text
        op.coefSpecular = txtCoefSpecular.Text
        op.process()
    End Sub

    'Light Source
    Private Sub btnPlusLightX_Click(sender As Object, e As EventArgs) Handles btnPlusLightX.Click
        txtLightX.Text += 1
    End Sub

    Private Sub btnMinLightX_Click(sender As Object, e As EventArgs) Handles btnMinLightX.Click
        txtLightX.Text -= 1
    End Sub

    Private Sub btnPlusLightY_Click(sender As Object, e As EventArgs) Handles btnPlusLightY.Click
        txtLightY.Text += 1
    End Sub

    Private Sub btnMinLightY_Click(sender As Object, e As EventArgs) Handles btnMinLightY.Click
        txtLightY.Text -= 1
    End Sub

    Private Sub btnPlusLightZ_Click(sender As Object, e As EventArgs) Handles btnPlusLightZ.Click
        txtLightZ.Text += 1
    End Sub

    Private Sub btnMinLightZ_Click(sender As Object, e As EventArgs) Handles btnMinLightZ.Click
        txtLightZ.Text -= 1
    End Sub

    Private Sub btnChangeLight_Click(sender As Object, e As EventArgs) Handles btnChangeLight.Click
        op.lightSource(0) = txtLightX.Text
        op.lightSource(1) = txtLightY.Text
        op.lightSource(2) = txtLightZ.Text

        op.process()
    End Sub

    Private Sub btnResetLight_Click(sender As Object, e As EventArgs) Handles btnResetLight.Click
        txtLightX.Text = op.defaultlight(0)
        txtLightY.Text = op.defaultlight(1)
        txtLightZ.Text = op.defaultlight(2)

        op.lightSource(0) = txtLightX.Text
        op.lightSource(1) = txtLightY.Text
        op.lightSource(2) = txtLightZ.Text

        op.process()
    End Sub

    'submit
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

        op.translateX = txtTranslateX.Text
        op.translateY = txtTranslateY.Text

        'shading
        op.coefAmbient = txtCoefAmbient.Text
        op.coefDiffuse = txtCoefDiffuse.Text
        op.coefSpecular = txtCoefSpecular.Text
        op.rExponentSpecular = txtRExponentSpecular.Text

        op.lightSource(0) = txtLightX.Text
        op.lightSource(1) = txtLightY.Text
        op.lightSource(2) = txtLightZ.Text

        op.process()
    End Sub


End Class





