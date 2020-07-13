<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRedaktor
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ВидToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СбросToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВысотаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ШиринаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФонФормыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.БирюзовыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СерыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СиреневыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФорматToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ШрифтToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РазмерToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.НачертаниеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДоступноИзменениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НедоступноToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЦветToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КрасныйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЧерныйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СинийToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АбзацToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыравниваниеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДоступноИзменениеToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.НедоступноToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФонзаливкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.БелыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗеленыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЖелтыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбАвтореToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.txtStroka = New System.Windows.Forms.TextBox()
        Me.frmFront = New System.Windows.Forms.GroupBox()
        Me.ChUnderline = New System.Windows.Forms.CheckBox()
        Me.ChItalic = New System.Windows.Forms.CheckBox()
        Me.СhBold = New System.Windows.Forms.CheckBox()
        Me.frmAlignment = New System.Windows.Forms.GroupBox()
        Me.Img3 = New System.Windows.Forms.PictureBox()
        Me.Img2 = New System.Windows.Forms.PictureBox()
        Me.Img1 = New System.Windows.Forms.PictureBox()
        Me.OptRight = New System.Windows.Forms.RadioButton()
        Me.OptCenter = New System.Windows.Forms.RadioButton()
        Me.OptLeft = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.frmFront.SuspendLayout()
        Me.frmAlignment.SuspendLayout()
        CType(Me.Img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Img1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВидToolStripMenuItem, Me.ФорматToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ВидToolStripMenuItem
        '
        Me.ВидToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СбросToolStripMenuItem, Me.ФормыToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.ВидToolStripMenuItem.Name = "ВидToolStripMenuItem"
        Me.ВидToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ВидToolStripMenuItem.Text = "Вид"
        '
        'СбросToolStripMenuItem
        '
        Me.СбросToolStripMenuItem.Name = "СбросToolStripMenuItem"
        Me.СбросToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СбросToolStripMenuItem.Text = "Сброс"
        '
        'ФормыToolStripMenuItem
        '
        Me.ФормыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВысотаToolStripMenuItem, Me.ШиринаToolStripMenuItem, Me.ФонФормыToolStripMenuItem})
        Me.ФормыToolStripMenuItem.Name = "ФормыToolStripMenuItem"
        Me.ФормыToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ФормыToolStripMenuItem.Text = "Формы"
        '
        'ВысотаToolStripMenuItem
        '
        Me.ВысотаToolStripMenuItem.Name = "ВысотаToolStripMenuItem"
        Me.ВысотаToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ВысотаToolStripMenuItem.Text = "Высота"
        '
        'ШиринаToolStripMenuItem
        '
        Me.ШиринаToolStripMenuItem.Name = "ШиринаToolStripMenuItem"
        Me.ШиринаToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ШиринаToolStripMenuItem.Text = "Ширина"
        '
        'ФонФормыToolStripMenuItem
        '
        Me.ФонФормыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.БирюзовыйToolStripMenuItem, Me.СерыйToolStripMenuItem, Me.СиреневыйToolStripMenuItem})
        Me.ФонФормыToolStripMenuItem.Name = "ФонФормыToolStripMenuItem"
        Me.ФонФормыToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ФонФормыToolStripMenuItem.Text = "Фон формы"
        '
        'БирюзовыйToolStripMenuItem
        '
        Me.БирюзовыйToolStripMenuItem.Name = "БирюзовыйToolStripMenuItem"
        Me.БирюзовыйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.БирюзовыйToolStripMenuItem.Text = "Бирюзовый"
        '
        'СерыйToolStripMenuItem
        '
        Me.СерыйToolStripMenuItem.Name = "СерыйToolStripMenuItem"
        Me.СерыйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СерыйToolStripMenuItem.Text = "Серый"
        '
        'СиреневыйToolStripMenuItem
        '
        Me.СиреневыйToolStripMenuItem.Name = "СиреневыйToolStripMenuItem"
        Me.СиреневыйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СиреневыйToolStripMenuItem.Text = "Сиреневый"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ФорматToolStripMenuItem
        '
        Me.ФорматToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ШрифтToolStripMenuItem, Me.АбзацToolStripMenuItem})
        Me.ФорматToolStripMenuItem.Name = "ФорматToolStripMenuItem"
        Me.ФорматToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ФорматToolStripMenuItem.Text = "Формат"
        '
        'ШрифтToolStripMenuItem
        '
        Me.ШрифтToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РазмерToolStripMenuItem, Me.НачертаниеToolStripMenuItem, Me.ЦветToolStripMenuItem})
        Me.ШрифтToolStripMenuItem.Name = "ШрифтToolStripMenuItem"
        Me.ШрифтToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ШрифтToolStripMenuItem.Text = "Шрифт"
        '
        'РазмерToolStripMenuItem
        '
        Me.РазмерToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.РазмерToolStripMenuItem.Name = "РазмерToolStripMenuItem"
        Me.РазмерToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.РазмерToolStripMenuItem.Text = "Размер"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "10"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "14"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "16"
        '
        'НачертаниеToolStripMenuItem
        '
        Me.НачертаниеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДоступноИзменениеToolStripMenuItem, Me.НедоступноToolStripMenuItem})
        Me.НачертаниеToolStripMenuItem.Name = "НачертаниеToolStripMenuItem"
        Me.НачертаниеToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.НачертаниеToolStripMenuItem.Text = "Начертание"
        '
        'ДоступноИзменениеToolStripMenuItem
        '
        Me.ДоступноИзменениеToolStripMenuItem.Name = "ДоступноИзменениеToolStripMenuItem"
        Me.ДоступноИзменениеToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ДоступноИзменениеToolStripMenuItem.Text = "Доступно изменение"
        '
        'НедоступноToolStripMenuItem
        '
        Me.НедоступноToolStripMenuItem.Name = "НедоступноToolStripMenuItem"
        Me.НедоступноToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.НедоступноToolStripMenuItem.Text = "Недоступно"
        '
        'ЦветToolStripMenuItem
        '
        Me.ЦветToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КрасныйToolStripMenuItem, Me.ЧерныйToolStripMenuItem, Me.СинийToolStripMenuItem})
        Me.ЦветToolStripMenuItem.Name = "ЦветToolStripMenuItem"
        Me.ЦветToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ЦветToolStripMenuItem.Text = "Цвет"
        '
        'КрасныйToolStripMenuItem
        '
        Me.КрасныйToolStripMenuItem.Name = "КрасныйToolStripMenuItem"
        Me.КрасныйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.КрасныйToolStripMenuItem.Text = "Красный"
        '
        'ЧерныйToolStripMenuItem
        '
        Me.ЧерныйToolStripMenuItem.Name = "ЧерныйToolStripMenuItem"
        Me.ЧерныйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ЧерныйToolStripMenuItem.Text = "Черный"
        '
        'СинийToolStripMenuItem
        '
        Me.СинийToolStripMenuItem.Name = "СинийToolStripMenuItem"
        Me.СинийToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СинийToolStripMenuItem.Text = "Синий"
        '
        'АбзацToolStripMenuItem
        '
        Me.АбзацToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыравниваниеToolStripMenuItem, Me.ФонзаливкаToolStripMenuItem})
        Me.АбзацToolStripMenuItem.Name = "АбзацToolStripMenuItem"
        Me.АбзацToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.АбзацToolStripMenuItem.Text = "Абзац"
        '
        'ВыравниваниеToolStripMenuItem
        '
        Me.ВыравниваниеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДоступноИзменениеToolStripMenuItem1, Me.НедоступноToolStripMenuItem1})
        Me.ВыравниваниеToolStripMenuItem.Name = "ВыравниваниеToolStripMenuItem"
        Me.ВыравниваниеToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ВыравниваниеToolStripMenuItem.Text = "Выравнивание"
        '
        'ДоступноИзменениеToolStripMenuItem1
        '
        Me.ДоступноИзменениеToolStripMenuItem1.Name = "ДоступноИзменениеToolStripMenuItem1"
        Me.ДоступноИзменениеToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.ДоступноИзменениеToolStripMenuItem1.Text = "Доступно изменение"
        '
        'НедоступноToolStripMenuItem1
        '
        Me.НедоступноToolStripMenuItem1.Name = "НедоступноToolStripMenuItem1"
        Me.НедоступноToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.НедоступноToolStripMenuItem1.Text = "Недоступно"
        '
        'ФонзаливкаToolStripMenuItem
        '
        Me.ФонзаливкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.БелыйToolStripMenuItem, Me.ЗеленыйToolStripMenuItem, Me.ЖелтыйToolStripMenuItem})
        Me.ФонзаливкаToolStripMenuItem.Name = "ФонзаливкаToolStripMenuItem"
        Me.ФонзаливкаToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ФонзаливкаToolStripMenuItem.Text = "Фон (заливка)"
        '
        'БелыйToolStripMenuItem
        '
        Me.БелыйToolStripMenuItem.Name = "БелыйToolStripMenuItem"
        Me.БелыйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.БелыйToolStripMenuItem.Text = "Белый"
        '
        'ЗеленыйToolStripMenuItem
        '
        Me.ЗеленыйToolStripMenuItem.Name = "ЗеленыйToolStripMenuItem"
        Me.ЗеленыйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ЗеленыйToolStripMenuItem.Text = "Зеленый"
        '
        'ЖелтыйToolStripMenuItem
        '
        Me.ЖелтыйToolStripMenuItem.Name = "ЖелтыйToolStripMenuItem"
        Me.ЖелтыйToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ЖелтыйToolStripMenuItem.Text = "Желтый"
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
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(12, 35)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(80, 13)
        Me.Lb1.TabIndex = 1
        Me.Lb1.Text = "Введите текст"
        '
        'txtStroka
        '
        Me.txtStroka.Location = New System.Drawing.Point(12, 51)
        Me.txtStroka.Multiline = True
        Me.txtStroka.Name = "txtStroka"
        Me.txtStroka.Size = New System.Drawing.Size(291, 49)
        Me.txtStroka.TabIndex = 2
        Me.txtStroka.Text = "Текстовый редактор"
        '
        'frmFront
        '
        Me.frmFront.Controls.Add(Me.ChUnderline)
        Me.frmFront.Controls.Add(Me.ChItalic)
        Me.frmFront.Controls.Add(Me.СhBold)
        Me.frmFront.Location = New System.Drawing.Point(12, 106)
        Me.frmFront.Name = "frmFront"
        Me.frmFront.Size = New System.Drawing.Size(101, 100)
        Me.frmFront.TabIndex = 3
        Me.frmFront.TabStop = False
        Me.frmFront.Text = "Начертание"
        Me.frmFront.Visible = False
        '
        'ChUnderline
        '
        Me.ChUnderline.AutoSize = True
        Me.ChUnderline.Location = New System.Drawing.Point(6, 65)
        Me.ChUnderline.Name = "ChUnderline"
        Me.ChUnderline.Size = New System.Drawing.Size(34, 17)
        Me.ChUnderline.TabIndex = 2
        Me.ChUnderline.Text = "Ч"
        Me.ChUnderline.UseVisualStyleBackColor = True
        '
        'ChItalic
        '
        Me.ChItalic.AutoSize = True
        Me.ChItalic.Location = New System.Drawing.Point(6, 42)
        Me.ChItalic.Name = "ChItalic"
        Me.ChItalic.Size = New System.Drawing.Size(33, 17)
        Me.ChItalic.TabIndex = 1
        Me.ChItalic.Text = "К"
        Me.ChItalic.UseVisualStyleBackColor = True
        '
        'СhBold
        '
        Me.СhBold.AutoSize = True
        Me.СhBold.Location = New System.Drawing.Point(6, 19)
        Me.СhBold.Name = "СhBold"
        Me.СhBold.Size = New System.Drawing.Size(37, 17)
        Me.СhBold.TabIndex = 0
        Me.СhBold.Text = "Ж"
        Me.СhBold.UseVisualStyleBackColor = True
        '
        'frmAlignment
        '
        Me.frmAlignment.Controls.Add(Me.Img3)
        Me.frmAlignment.Controls.Add(Me.Img2)
        Me.frmAlignment.Controls.Add(Me.Img1)
        Me.frmAlignment.Controls.Add(Me.OptRight)
        Me.frmAlignment.Controls.Add(Me.OptCenter)
        Me.frmAlignment.Controls.Add(Me.OptLeft)
        Me.frmAlignment.Location = New System.Drawing.Point(119, 106)
        Me.frmAlignment.Name = "frmAlignment"
        Me.frmAlignment.Size = New System.Drawing.Size(99, 100)
        Me.frmAlignment.TabIndex = 4
        Me.frmAlignment.TabStop = False
        Me.frmAlignment.Text = "Выравнивание"
        Me.frmAlignment.Visible = False
        '
        'Img3
        '
        Me.Img3.Image = Global.Laboratory_2.My.Resources.Resources._3
        Me.Img3.Location = New System.Drawing.Point(28, 71)
        Me.Img3.Name = "Img3"
        Me.Img3.Size = New System.Drawing.Size(19, 21)
        Me.Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Img3.TabIndex = 5
        Me.Img3.TabStop = False
        '
        'Img2
        '
        Me.Img2.Image = Global.Laboratory_2.My.Resources.Resources._2
        Me.Img2.Location = New System.Drawing.Point(27, 44)
        Me.Img2.Name = "Img2"
        Me.Img2.Size = New System.Drawing.Size(20, 21)
        Me.Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Img2.TabIndex = 4
        Me.Img2.TabStop = False
        '
        'Img1
        '
        Me.Img1.Image = Global.Laboratory_2.My.Resources.Resources._1
        Me.Img1.Location = New System.Drawing.Point(27, 19)
        Me.Img1.Name = "Img1"
        Me.Img1.Size = New System.Drawing.Size(19, 19)
        Me.Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Img1.TabIndex = 3
        Me.Img1.TabStop = False
        '
        'OptRight
        '
        Me.OptRight.AutoSize = True
        Me.OptRight.Location = New System.Drawing.Point(6, 71)
        Me.OptRight.Name = "OptRight"
        Me.OptRight.Size = New System.Drawing.Size(14, 13)
        Me.OptRight.TabIndex = 2
        Me.OptRight.TabStop = True
        Me.OptRight.UseVisualStyleBackColor = True
        '
        'OptCenter
        '
        Me.OptCenter.AutoSize = True
        Me.OptCenter.Location = New System.Drawing.Point(6, 46)
        Me.OptCenter.Name = "OptCenter"
        Me.OptCenter.Size = New System.Drawing.Size(14, 13)
        Me.OptCenter.TabIndex = 1
        Me.OptCenter.TabStop = True
        Me.OptCenter.UseVisualStyleBackColor = True
        '
        'OptLeft
        '
        Me.OptLeft.AutoSize = True
        Me.OptLeft.Location = New System.Drawing.Point(6, 19)
        Me.OptLeft.Name = "OptLeft"
        Me.OptLeft.Size = New System.Drawing.Size(14, 13)
        Me.OptLeft.TabIndex = 0
        Me.OptLeft.TabStop = True
        Me.OptLeft.UseVisualStyleBackColor = True
        '
        'FrmRedaktor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(324, 223)
        Me.Controls.Add(Me.frmAlignment)
        Me.Controls.Add(Me.frmFront)
        Me.Controls.Add(Me.txtStroka)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmRedaktor"
        Me.Text = "Простейший редактор"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.frmFront.ResumeLayout(False)
        Me.frmFront.PerformLayout()
        Me.frmAlignment.ResumeLayout(False)
        Me.frmAlignment.PerformLayout()
        CType(Me.Img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Img1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ВидToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lb1 As Label
    Friend WithEvents txtStroka As TextBox
    Friend WithEvents frmFront As GroupBox
    Friend WithEvents ChUnderline As CheckBox
    Friend WithEvents ChItalic As CheckBox
    Friend WithEvents СhBold As CheckBox
    Friend WithEvents frmAlignment As GroupBox
    Friend WithEvents Img3 As PictureBox
    Friend WithEvents Img2 As PictureBox
    Friend WithEvents Img1 As PictureBox
    Friend WithEvents OptRight As RadioButton
    Friend WithEvents OptCenter As RadioButton
    Friend WithEvents OptLeft As RadioButton
    Friend WithEvents СбросToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФормыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВысотаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ШиринаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФонФормыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БирюзовыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СерыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СиреневыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФорматToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ШрифтToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РазмерToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents НачертаниеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДоступноИзменениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НедоступноToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЦветToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КрасныйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЧерныйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СинийToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents АбзацToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыравниваниеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДоступноИзменениеToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents НедоступноToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ФонзаливкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БелыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗеленыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЖелтыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбАвтореToolStripMenuItem As ToolStripMenuItem
End Class
