Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión para MySQL
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    ' Cargar el formulario y llenar ComboBox de comunas desde la base de datos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComunas()
        BloquearCampos() ' Bloquear campos al inicio
    End Sub

    ' Método para cargar comunas desde la base de datos
    Private Sub CargarComunas()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT NombreComuna FROM Comuna"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboComuna.Items.Add(reader("NombreComuna").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar las comunas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Funcionalidad de Guardar
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim rut As String = txtRUT.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String

        ' Validar la selección del sexo
        If rbtnMasculino.Checked Then
            sexo = "Masculino"
        ElseIf rbtnFemenino.Checked Then
            sexo = "Femenino"
        ElseIf rbtnNoEspecifica.Checked Then
            sexo = "No especifica"
        Else
            MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim comuna As String = cboComuna.SelectedItem?.ToString()
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO Personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                    "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarFormulario()
                    BloquearCampos() ' Bloquear campos después de guardar
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Funcionalidad de Buscar por RUT
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim rut As String = txtRUT.Text

        ' Validar que el RUT no esté vacío
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese un RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buscar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT * FROM Personas WHERE RUT = @rut"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtNombre.Text = reader("Nombre").ToString()
                            txtApellido.Text = reader("Apellido").ToString()
                            Select Case reader("Sexo").ToString()
                                Case "Masculino"
                                    rbtnMasculino.Checked = True
                                Case "Femenino"
                                    rbtnFemenino.Checked = True
                                Case "No especifica"
                                    rbtnNoEspecifica.Checked = True
                            End Select
                            cboComuna.SelectedItem = reader("Comuna").ToString()
                            txtCiudad.Text = reader("Ciudad").ToString()
                            txtObservacion.Text = reader("Observacion").ToString()
                            HabilitarCampos() ' Habilitar campos si se encuentra el registro
                        Else
                            ' Si no se encuentra, preguntar si desea ingresar una nueva persona
                            Dim respuesta As DialogResult = MessageBox.Show("No se encontró un registro con el RUT proporcionado. ¿Desea ingresar una nueva persona?", "No encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If respuesta = DialogResult.Yes Then
                                HabilitarCampos() ' Habilitar campos para ingresar una nueva persona
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar el formulario
    Private Sub LimpiarFormulario()
        txtRUT.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        rbtnMasculino.Checked = False
        rbtnFemenino.Checked = False
        rbtnNoEspecifica.Checked = False
        cboComuna.SelectedIndex = -1
        txtRUT.Focus() ' Colocar el foco en el campo RUT
    End Sub

    ' Método para bloquear los campos del formulario
    Private Sub BloquearCampos()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        rbtnMasculino.Enabled = False
        rbtnFemenino.Enabled = False
        rbtnNoEspecifica.Enabled = False
        cboComuna.Enabled = False
        txtCiudad.Enabled = False
        txtObservacion.Enabled = False
        ButtonGuardar.Enabled = False
    End Sub

    ' Método para habilitar los campos del formulario
    Private Sub HabilitarCampos()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        rbtnMasculino.Enabled = True
        rbtnFemenino.Enabled = True
        rbtnNoEspecifica.Enabled = True
        cboComuna.Enabled = True
        txtCiudad.Enabled = True
        txtObservacion.Enabled = True
        ButtonGuardar.Enabled = True
    End Sub

End Class
