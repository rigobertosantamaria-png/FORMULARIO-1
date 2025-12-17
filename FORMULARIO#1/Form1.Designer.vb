<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label2 = New Label()
        Label1 = New Label()
        txtNombre2 = New TextBox()
        txtNombre1 = New TextBox()
        rdoOpcion1 = New RadioButton()
        rdoOpcion2 = New RadioButton()
        chkAceptar = New CheckBox()
        btnInfo = New Button()
        btnSaludar = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(528, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 17
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(206, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 16
        Label1.Text = "Label1"
        ' 
        ' txtNombre2
        ' 
        txtNombre2.BackColor = SystemColors.Window
        txtNombre2.Location = New Point(497, 110)
        txtNombre2.Margin = New Padding(3, 2, 3, 2)
        txtNombre2.Name = "txtNombre2"
        txtNombre2.Size = New Size(110, 23)
        txtNombre2.TabIndex = 15
        ' 
        ' txtNombre1
        ' 
        txtNombre1.BackColor = SystemColors.Window
        txtNombre1.Location = New Point(176, 110)
        txtNombre1.Margin = New Padding(3, 2, 3, 2)
        txtNombre1.Name = "txtNombre1"
        txtNombre1.Size = New Size(110, 23)
        txtNombre1.TabIndex = 9
        ' 
        ' rdoOpcion1
        ' 
        rdoOpcion1.AutoSize = True
        rdoOpcion1.Location = New Point(390, 322)
        rdoOpcion1.Margin = New Padding(3, 2, 3, 2)
        rdoOpcion1.Name = "rdoOpcion1"
        rdoOpcion1.Size = New Size(73, 19)
        rdoOpcion1.TabIndex = 14
        rdoOpcion1.TabStop = True
        rdoOpcion1.Text = "Opción 1"
        rdoOpcion1.UseVisualStyleBackColor = True
        ' 
        ' rdoOpcion2
        ' 
        rdoOpcion2.AutoSize = True
        rdoOpcion2.Location = New Point(551, 322)
        rdoOpcion2.Margin = New Padding(3, 2, 3, 2)
        rdoOpcion2.Name = "rdoOpcion2"
        rdoOpcion2.Size = New Size(73, 19)
        rdoOpcion2.TabIndex = 13
        rdoOpcion2.TabStop = True
        rdoOpcion2.Text = "Opción 2"
        rdoOpcion2.UseVisualStyleBackColor = True
        ' 
        ' chkAceptar
        ' 
        chkAceptar.AutoSize = True
        chkAceptar.Location = New Point(206, 322)
        chkAceptar.Margin = New Padding(3, 2, 3, 2)
        chkAceptar.Name = "chkAceptar"
        chkAceptar.Size = New Size(67, 19)
        chkAceptar.TabIndex = 12
        chkAceptar.Text = "Aceptar"
        chkAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnInfo
        ' 
        btnInfo.Location = New Point(507, 151)
        btnInfo.Margin = New Padding(3, 2, 3, 2)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(82, 22)
        btnInfo.TabIndex = 11
        btnInfo.Text = "Información"
        btnInfo.UseVisualStyleBackColor = True
        ' 
        ' btnSaludar
        ' 
        btnSaludar.Location = New Point(187, 151)
        btnSaludar.Margin = New Padding(3, 2, 3, 2)
        btnSaludar.Name = "btnSaludar"
        btnSaludar.Size = New Size(82, 22)
        btnSaludar.TabIndex = 10
        btnSaludar.Text = "Saludar"
        btnSaludar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNombre2)
        Controls.Add(txtNombre1)
        Controls.Add(rdoOpcion1)
        Controls.Add(rdoOpcion2)
        Controls.Add(chkAceptar)
        Controls.Add(btnInfo)
        Controls.Add(btnSaludar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents rdoOpcion1 As RadioButton
    Friend WithEvents rdoOpcion2 As RadioButton
    Friend WithEvents chkAceptar As CheckBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnSaludar As Button

End Class
