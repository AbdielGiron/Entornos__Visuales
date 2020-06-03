<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.PictureBox()
        Me.txtAbout = New System.Windows.Forms.PictureBox()
        CType(Me.txtLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(73, 246)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(311, 43)
        Me.txtUsuario.TabIndex = 0
        '
        'txtContra
        '
        Me.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.Location = New System.Drawing.Point(73, 327)
        Me.txtContra.Multiline = True
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(311, 38)
        Me.txtContra.TabIndex = 1
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.Transparent
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin.Location = New System.Drawing.Point(25, 416)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(361, 50)
        Me.txtLogin.TabIndex = 2
        Me.txtLogin.TabStop = False
        '
        'txtAbout
        '
        Me.txtAbout.BackColor = System.Drawing.Color.Transparent
        Me.txtAbout.Location = New System.Drawing.Point(161, 482)
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.Size = New System.Drawing.Size(88, 32)
        Me.txtAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.txtAbout.TabIndex = 3
        Me.txtAbout.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_Pizzeria.My.Resources.Resources.restaurant_waiter_app_template_for_android_2594_imgs_2594
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(410, 522)
        Me.Controls.Add(Me.txtAbout)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.txtLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtLogin As PictureBox
    Friend WithEvents txtAbout As PictureBox
End Class
