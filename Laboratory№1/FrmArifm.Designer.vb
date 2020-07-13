<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArifm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdPls = New System.Windows.Forms.Button()
        Me.cmdMns = New System.Windows.Forms.Button()
        Me.cmdUmn = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAuthor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(39, 12)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(100, 20)
        Me.txta.TabIndex = 0
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(39, 38)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(100, 20)
        Me.txtb.TabIndex = 1
        '
        'txtc
        '
        Me.txtc.Location = New System.Drawing.Point(39, 64)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(100, 20)
        Me.txtc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "a="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "b="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "c="
        '
        'cmdPls
        '
        Me.cmdPls.Location = New System.Drawing.Point(145, 12)
        Me.cmdPls.Name = "cmdPls"
        Me.cmdPls.Size = New System.Drawing.Size(76, 20)
        Me.cmdPls.TabIndex = 6
        Me.cmdPls.Text = "+"
        Me.cmdPls.UseVisualStyleBackColor = True
        '
        'cmdMns
        '
        Me.cmdMns.Location = New System.Drawing.Point(145, 37)
        Me.cmdMns.Name = "cmdMns"
        Me.cmdMns.Size = New System.Drawing.Size(76, 20)
        Me.cmdMns.TabIndex = 7
        Me.cmdMns.Text = "-"
        Me.cmdMns.UseVisualStyleBackColor = True
        '
        'cmdUmn
        '
        Me.cmdUmn.Location = New System.Drawing.Point(145, 64)
        Me.cmdUmn.Name = "cmdUmn"
        Me.cmdUmn.Size = New System.Drawing.Size(76, 20)
        Me.cmdUmn.TabIndex = 8
        Me.cmdUmn.Text = "*"
        Me.cmdUmn.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        Me.cmdDel.Location = New System.Drawing.Point(145, 90)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(76, 20)
        Me.cmdDel.TabIndex = 9
        Me.cmdDel.Text = "/"
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(227, 11)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 20)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Сброс"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAuthor
        '
        Me.btnAuthor.Location = New System.Drawing.Point(227, 37)
        Me.btnAuthor.Name = "btnAuthor"
        Me.btnAuthor.Size = New System.Drawing.Size(76, 20)
        Me.btnAuthor.TabIndex = 11
        Me.btnAuthor.Text = "Автор"
        Me.btnAuthor.UseVisualStyleBackColor = True
        '
        'frmArifm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 126)
        Me.Controls.Add(Me.btnAuthor)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmdDel)
        Me.Controls.Add(Me.cmdUmn)
        Me.Controls.Add(Me.cmdMns)
        Me.Controls.Add(Me.cmdPls)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtc)
        Me.Controls.Add(Me.txtb)
        Me.Controls.Add(Me.txta)
        Me.Name = "frmArifm"
        Me.Text = "Арифмометр"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txta As TextBox
    Friend WithEvents txtb As TextBox
    Friend WithEvents txtc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdPls As Button
    Friend WithEvents cmdMns As Button
    Friend WithEvents cmdUmn As Button
    Friend WithEvents cmdDel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAuthor As Button
End Class
