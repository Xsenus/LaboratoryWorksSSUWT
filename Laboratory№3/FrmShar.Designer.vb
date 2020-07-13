<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShar
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
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СбросToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбАвтореToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(48, 41)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(15, 13)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "R"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Location = New System.Drawing.Point(12, 67)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(51, 13)
        Me.lb2.TabIndex = 1
        Me.lb2.Text = "S сферы"
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Location = New System.Drawing.Point(20, 93)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(43, 13)
        Me.lb3.TabIndex = 2
        Me.lb3.Text = "V шара"
        '
        'txtR
        '
        Me.txtR.Enabled = False
        Me.txtR.Location = New System.Drawing.Point(69, 38)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(100, 20)
        Me.txtR.TabIndex = 3
        Me.txtR.Visible = False
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(69, 64)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(100, 20)
        Me.txtS.TabIndex = 4
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(69, 90)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(100, 20)
        Me.txtV.TabIndex = 5
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(175, 38)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(121, 34)
        Me.btnS.TabIndex = 6
        Me.btnS.Text = "Вычисление S cферы"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Location = New System.Drawing.Point(175, 76)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(121, 34)
        Me.btnV.TabIndex = 7
        Me.btnV.Text = "Вычисление V шара"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СбросToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СбросToolStripMenuItem
        '
        Me.СбросToolStripMenuItem.Name = "СбросToolStripMenuItem"
        Me.СбросToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.СбросToolStripMenuItem.Text = "Сброс"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОбАвтореToolStripMenuItem})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'ОбАвтореToolStripMenuItem
        '
        Me.ОбАвтореToolStripMenuItem.Name = "ОбАвтореToolStripMenuItem"
        Me.ОбАвтореToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ОбАвтореToolStripMenuItem.Text = "Об авторе"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.Laboratory_3.My.Resources.Resources._4
        Me.PictureBox3.InitialImage = Global.Laboratory_3.My.Resources.Resources._4
        Me.PictureBox3.Location = New System.Drawing.Point(302, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Laboratory_3.My.Resources.Resources._6
        Me.PictureBox2.Location = New System.Drawing.Point(165, 116)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Laboratory_3.My.Resources.Resources._5
        Me.PictureBox1.Location = New System.Drawing.Point(15, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FrmShar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(456, 178)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.lb3)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmShar"
        Me.Text = "Вычисления"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents txtR As TextBox
    Friend WithEvents txtS As TextBox
    Friend WithEvents txtV As TextBox
    Friend WithEvents btnS As Button
    Friend WithEvents btnV As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СбросToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбАвтореToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
End Class
