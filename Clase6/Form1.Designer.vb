<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtRUT = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        cboComuna = New ComboBox()
        txtCiudad = New TextBox()
        txtObservacion = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        rbtnNoEspecifica = New RadioButton()
        rbtnFemenino = New RadioButton()
        rbtnMasculino = New RadioButton()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 4
        Label5.Text = "Comuna"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 5
        Label6.Text = "Ciudad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 6
        Label7.Text = "Observacion"
        ' 
        ' txtRUT
        ' 
        txtRUT.Location = New Point(92, 20)
        txtRUT.Name = "txtRUT"
        txtRUT.Size = New Size(100, 23)
        txtRUT.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(92, 54)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(208, 23)
        txtNombre.TabIndex = 8
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(92, 87)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(208, 23)
        txtApellido.TabIndex = 9
        ' 
        ' cboComuna
        ' 
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(92, 187)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(208, 23)
        cboComuna.TabIndex = 12
        cboComuna.Text = "(Seleccione una Comuna)"
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(92, 230)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(208, 23)
        txtCiudad.TabIndex = 13
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(92, 274)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(208, 23)
        txtObservacion.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(92, 319)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 23)
        Button1.TabIndex = 15
        Button1.Text = "Guardar MySql"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnNoEspecifica)
        GroupBox1.Controls.Add(rbtnFemenino)
        GroupBox1.Controls.Add(rbtnMasculino)
        GroupBox1.Location = New Point(12, 131)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(299, 50)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo:"
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(181, 22)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(96, 19)
        rbtnNoEspecifica.TabIndex = 19
        rbtnNoEspecifica.TabStop = True
        rbtnNoEspecifica.Text = "No especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(92, 22)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(78, 19)
        rbtnFemenino.TabIndex = 18
        rbtnFemenino.TabStop = True
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(6, 22)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(80, 19)
        rbtnMasculino.TabIndex = 11
        rbtnMasculino.TabStop = True
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(198, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 17
        Label4.Text = "Ejemplo:123456789"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(323, 362)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(txtObservacion)
        Controls.Add(txtCiudad)
        Controls.Add(cboComuna)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtRUT)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Clase 6 - MySql"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRUT As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents cboComuna As ComboBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoEspecifica As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents Label4 As Label

End Class
