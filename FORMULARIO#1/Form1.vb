
Imports System.Drawing.Text
    Imports System.Reflection.Emit
    Imports System.Runtime.InteropServices.JavaScript.JSType
    Imports System.Windows.Forms.VisualStyles.VisualStyleElement
    Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

    Public Class Form1
        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre1.TextChanged

        End Sub

        Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
            Dim cadena1 As String

            cadena1 = txtNombre1.Text

            MessageBox.Show("La cadena es: " & cadena1)

            If rdoOpcion1.Checked Then
                Label1.Text = "Opcion 1 seleccionada"
            End If
            If rdoOpcion2.Checked Then
                Label1.Text = "Opcion 2 seleccionada"
            End If
            If chkAceptar.Checked Then
                Label1.Text = "Opcion 3 seleccionada"
            End If



        End Sub

        Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
            Dim precio, itbms As Double
            precio = txtNombre2.Text

            itbms = precio * 0.07

            ' Redondear itbms
            itbms = Math.Round(itbms, 2)

            ' MessageBox.Show("El ITBMS es: " & itbms)
            Label1.Text = "El itmbs es: " & itbms

            If itbms > 30 Then
                MessageBox.Show("El ITBMS es mayor a 30, está caro")
            End If

            Label2.Text = "El precio total es: " & itbms + precio
        End Sub

        Private Sub chkAceptar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAceptar.CheckedChanged

        End Sub

        Private Sub rdoOpcion1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOpcion1.CheckedChanged
            ' Solo actualizamos el Label si rdoOpcion1 está ahora seleccionado (Checked = True)
            If rdoOpcion1.Checked Then
                Label1.Text = "Opción 1 (rdoOpcion1) seleccionada."
            End If
        End Sub


        Private Sub rdoOpcion2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOpcion2.CheckedChanged
            ' Solo actualizamos el Label si rdoOpcion2 está ahora seleccionado (Checked = True)
            If rdoOpcion2.Checked Then
                Label1.Text = "Opción 2 (rdoOpcion2) seleccionada."
            End If
        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

        Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        End Sub
    End Class

