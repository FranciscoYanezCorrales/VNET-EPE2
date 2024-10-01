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
        ButtonGuardar = New Button()
        GroupBox1 = New GroupBox()
        rbtnNoEspecifica = New RadioButton()
        rbtnFemenino = New RadioButton()
        rbtnMasculino = New RadioButton()
        Label4 = New Label()
        ButtonBuscar = New Button()
        ButtonActualizar = New Button()
        ButtonEliminar = New Button()
        ButtonVerUsuarios = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 20)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 4
        Label5.Text = "Comuna"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 313)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 5
        Label6.Text = "Ciudad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 373)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 20)
        Label7.TabIndex = 6
        Label7.Text = "Observacion"
        ' 
        ' txtRUT
        ' 
        txtRUT.Location = New Point(105, 27)
        txtRUT.Margin = New Padding(3, 4, 3, 4)
        txtRUT.Name = "txtRUT"
        txtRUT.Size = New Size(114, 27)
        txtRUT.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(105, 72)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(237, 27)
        txtNombre.TabIndex = 8
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(105, 116)
        txtApellido.Margin = New Padding(3, 4, 3, 4)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(237, 27)
        txtApellido.TabIndex = 9
        ' 
        ' cboComuna
        ' 
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(105, 249)
        cboComuna.Margin = New Padding(3, 4, 3, 4)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(237, 28)
        cboComuna.TabIndex = 12
        cboComuna.Text = "(Seleccione una Comuna)"
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(105, 307)
        txtCiudad.Margin = New Padding(3, 4, 3, 4)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(237, 27)
        txtCiudad.TabIndex = 13
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(105, 365)
        txtObservacion.Margin = New Padding(3, 4, 3, 4)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(237, 27)
        txtObservacion.TabIndex = 14
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Location = New Point(14, 425)
        ButtonGuardar.Margin = New Padding(3, 4, 3, 4)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(131, 31)
        ButtonGuardar.TabIndex = 15
        ButtonGuardar.Text = "Guardar"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnNoEspecifica)
        GroupBox1.Controls.Add(rbtnFemenino)
        GroupBox1.Controls.Add(rbtnMasculino)
        GroupBox1.Location = New Point(14, 175)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(342, 67)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo:"
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(207, 29)
        rbtnNoEspecifica.Margin = New Padding(3, 4, 3, 4)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(120, 24)
        rbtnNoEspecifica.TabIndex = 19
        rbtnNoEspecifica.TabStop = True
        rbtnNoEspecifica.Text = "No especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(105, 29)
        rbtnFemenino.Margin = New Padding(3, 4, 3, 4)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(95, 24)
        rbtnFemenino.TabIndex = 18
        rbtnFemenino.TabStop = True
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(7, 29)
        rbtnMasculino.Margin = New Padding(3, 4, 3, 4)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(97, 24)
        rbtnMasculino.TabIndex = 11
        rbtnMasculino.TabStop = True
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 20)
        Label4.TabIndex = 17
        Label4.Text = "Ejemplo:123456789"
        ' 
        ' ButtonBuscar
        ' 
        ButtonBuscar.Location = New Point(236, 26)
        ButtonBuscar.Name = "ButtonBuscar"
        ButtonBuscar.Size = New Size(105, 29)
        ButtonBuscar.TabIndex = 18
        ButtonBuscar.Text = "Buscar"
        ButtonBuscar.UseVisualStyleBackColor = True
        ' 
        ' ButtonActualizar
        ' 
        ButtonActualizar.Location = New Point(210, 427)
        ButtonActualizar.Name = "ButtonActualizar"
        ButtonActualizar.Size = New Size(131, 29)
        ButtonActualizar.TabIndex = 19
        ButtonActualizar.Text = "Actualizar"
        ButtonActualizar.UseVisualStyleBackColor = True
        ' 
        ' ButtonEliminar
        ' 
        ButtonEliminar.Location = New Point(14, 476)
        ButtonEliminar.Name = "ButtonEliminar"
        ButtonEliminar.Size = New Size(131, 29)
        ButtonEliminar.TabIndex = 20
        ButtonEliminar.Text = "Eliminar"
        ButtonEliminar.UseVisualStyleBackColor = True
        ' 
        ' ButtonVerUsuarios
        ' 
        ButtonVerUsuarios.Location = New Point(210, 476)
        ButtonVerUsuarios.Name = "ButtonVerUsuarios"
        ButtonVerUsuarios.Size = New Size(131, 29)
        ButtonVerUsuarios.TabIndex = 21
        ButtonVerUsuarios.Text = "Ver Datos BD"
        ButtonVerUsuarios.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(353, 551)
        Controls.Add(ButtonVerUsuarios)
        Controls.Add(ButtonEliminar)
        Controls.Add(ButtonActualizar)
        Controls.Add(ButtonBuscar)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(ButtonGuardar)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "EVA 2 - MySql"
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
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoEspecifica As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonVerUsuarios As Button

End Class
