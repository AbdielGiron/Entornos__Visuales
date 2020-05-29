<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtValor1 = New System.Windows.Forms.ComboBox()
        Me.txtValor2 = New System.Windows.Forms.ComboBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.CheckBoxSuma = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMulti = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPoten = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResta = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDivi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRaiz = New System.Windows.Forms.CheckBox()
        Me.txtSigno = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtValor1
        '
        Me.txtValor1.FormattingEnabled = True
        Me.txtValor1.Location = New System.Drawing.Point(18, 144)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(121, 21)
        Me.txtValor1.TabIndex = 2
        '
        'txtValor2
        '
        Me.txtValor2.FormattingEnabled = True
        Me.txtValor2.Location = New System.Drawing.Point(193, 144)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(121, 21)
        Me.txtValor2.TabIndex = 3
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Location = New System.Drawing.Point(190, 9)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(132, 13)
        Me.Titulo.TabIndex = 4
        Me.Titulo.Text = "OPERACIONES BASICAS"
        '
        'txtRespuesta
        '
        Me.txtRespuesta.FormattingEnabled = True
        Me.txtRespuesta.Location = New System.Drawing.Point(102, 206)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(121, 21)
        Me.txtRespuesta.TabIndex = 9
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(130, 177)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(64, 233)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 14
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(193, 233)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'CheckBoxSuma
        '
        Me.CheckBoxSuma.AutoSize = True
        Me.CheckBoxSuma.Location = New System.Drawing.Point(34, 40)
        Me.CheckBoxSuma.Name = "CheckBoxSuma"
        Me.CheckBoxSuma.Size = New System.Drawing.Size(53, 17)
        Me.CheckBoxSuma.TabIndex = 16
        Me.CheckBoxSuma.Text = "Suma"
        Me.CheckBoxSuma.UseVisualStyleBackColor = True
        '
        'CheckBoxMulti
        '
        Me.CheckBoxMulti.AutoSize = True
        Me.CheckBoxMulti.Location = New System.Drawing.Point(133, 40)
        Me.CheckBoxMulti.Name = "CheckBoxMulti"
        Me.CheckBoxMulti.Size = New System.Drawing.Size(90, 17)
        Me.CheckBoxMulti.TabIndex = 17
        Me.CheckBoxMulti.Text = "Multiplicacion"
        Me.CheckBoxMulti.UseVisualStyleBackColor = True
        '
        'CheckBoxPoten
        '
        Me.CheckBoxPoten.AutoSize = True
        Me.CheckBoxPoten.Location = New System.Drawing.Point(239, 40)
        Me.CheckBoxPoten.Name = "CheckBoxPoten"
        Me.CheckBoxPoten.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxPoten.TabIndex = 18
        Me.CheckBoxPoten.Text = "Potencia"
        Me.CheckBoxPoten.UseVisualStyleBackColor = True
        '
        'CheckBoxResta
        '
        Me.CheckBoxResta.AutoSize = True
        Me.CheckBoxResta.Location = New System.Drawing.Point(34, 73)
        Me.CheckBoxResta.Name = "CheckBoxResta"
        Me.CheckBoxResta.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxResta.TabIndex = 19
        Me.CheckBoxResta.Text = "Resta"
        Me.CheckBoxResta.UseVisualStyleBackColor = True
        '
        'CheckBoxDivi
        '
        Me.CheckBoxDivi.AutoSize = True
        Me.CheckBoxDivi.Location = New System.Drawing.Point(133, 73)
        Me.CheckBoxDivi.Name = "CheckBoxDivi"
        Me.CheckBoxDivi.Size = New System.Drawing.Size(64, 17)
        Me.CheckBoxDivi.TabIndex = 20
        Me.CheckBoxDivi.Text = "Divicion"
        Me.CheckBoxDivi.UseVisualStyleBackColor = True
        '
        'CheckBoxRaiz
        '
        Me.CheckBoxRaiz.AutoSize = True
        Me.CheckBoxRaiz.Location = New System.Drawing.Point(239, 73)
        Me.CheckBoxRaiz.Name = "CheckBoxRaiz"
        Me.CheckBoxRaiz.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxRaiz.TabIndex = 21
        Me.CheckBoxRaiz.Text = "Raiz"
        Me.CheckBoxRaiz.UseVisualStyleBackColor = True
        '
        'txtSigno
        '
        Me.txtSigno.FormattingEnabled = True
        Me.txtSigno.Location = New System.Drawing.Point(150, 144)
        Me.txtSigno.Name = "txtSigno"
        Me.txtSigno.Size = New System.Drawing.Size(35, 21)
        Me.txtSigno.TabIndex = 22
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(130, 101)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 283)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtSigno)
        Me.Controls.Add(Me.CheckBoxRaiz)
        Me.Controls.Add(Me.CheckBoxDivi)
        Me.Controls.Add(Me.CheckBoxResta)
        Me.Controls.Add(Me.CheckBoxPoten)
        Me.Controls.Add(Me.CheckBoxMulti)
        Me.Controls.Add(Me.CheckBoxSuma)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValor1 As ComboBox
    Friend WithEvents txtValor2 As ComboBox
    Friend WithEvents Titulo As Label
    Friend WithEvents txtRespuesta As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents CheckBoxSuma As CheckBox
    Friend WithEvents CheckBoxMulti As CheckBox
    Friend WithEvents CheckBoxPoten As CheckBox
    Friend WithEvents CheckBoxResta As CheckBox
    Friend WithEvents CheckBoxDivi As CheckBox
    Friend WithEvents CheckBoxRaiz As CheckBox
    Friend WithEvents txtSigno As ComboBox
    Friend WithEvents btnAgregar As Button
End Class
