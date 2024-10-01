Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión para MySQL
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    ' Cargar el formulario y llenar ComboBox de comunas desde la base de datos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComunas()
        DeshabilitarCampos() ' Deshabilitar campos al cargar el formulario
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
                    DeshabilitarCampos() ' Deshabilitar campos después de guardar
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
                            ' Llenar los campos con los datos encontrados
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

                            ' Habilitar campos
                            HabilitarCampos()
                        Else
                            Dim result As DialogResult = MessageBox.Show("No se encontró un registro con el RUT proporcionado. ¿Desea ingresar una nueva persona?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                HabilitarCampos() ' Habilitar campos para ingresar nueva persona
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Funcionalidad de Actualizar datos
    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
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

        ' Actualizar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE Personas SET Nombre = @nombre, Apellido = @apellido, Sexo = @sexo, Comuna = @comuna, Ciudad = @ciudad, Observacion = @observacion WHERE RUT = @rut"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarFormulario()
                    DeshabilitarCampos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Funcionalidad de Eliminar datos
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim rut As String = txtRUT.Text

        ' Validar que el RUT no esté vacío
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese un RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Eliminar los datos de la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "DELETE FROM Personas WHERE RUT = @rut"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarFormulario() ' Limpiar el formulario después de eliminar
                        DeshabilitarCampos() ' Deshabilitar campos
                    Else
                        MessageBox.Show("No se encontró un registro con el RUT proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Funcionalidad para ver todos los usuarios
    Private Sub ButtonVerUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonVerUsuarios.Click
        Dim usuarios As String = ""

        ' Obtener todos los registros de la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT RUT, Nombre, Apellido FROM Personas"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            usuarios &= "RUT: " & reader("RUT").ToString() & ", Nombre: " & reader("Nombre").ToString() & ", Apellido: " & reader("Apellido").ToString() & Environment.NewLine
                        End While
                    End Using
                End Using

                If String.IsNullOrWhiteSpace(usuarios) Then
                    MessageBox.Show("No hay usuarios registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(usuarios, "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener la lista de usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    ' Método para deshabilitar campos
    Private Sub DeshabilitarCampos()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        cboComuna.Enabled = False
        txtCiudad.Enabled = False
        txtObservacion.Enabled = False
        rbtnMasculino.Enabled = False
        rbtnFemenino.Enabled = False
        rbtnNoEspecifica.Enabled = False
        ButtonGuardar.Enabled = False
        ButtonActualizar.Enabled = False
        ButtonEliminar.Enabled = False
    End Sub

    ' Método para habilitar campos
    Private Sub HabilitarCampos()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cboComuna.Enabled = True
        txtCiudad.Enabled = True
        txtObservacion.Enabled = True
        rbtnMasculino.Enabled = True
        rbtnFemenino.Enabled = True
        rbtnNoEspecifica.Enabled = True
        ButtonGuardar.Enabled = True
        ButtonActualizar.Enabled = True
        ButtonEliminar.Enabled = True
    End Sub


End Class


