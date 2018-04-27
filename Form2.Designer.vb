<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttugasbesar = New System.Windows.Forms.TextBox()
        Me.txtbobotkecil = New System.Windows.Forms.TextBox()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.txttugaskecil = New System.Windows.Forms.TextBox()
        Me.txtbobotbesar = New System.Windows.Forms.TextBox()
        Me.txtbobotuts = New System.Windows.Forms.TextBox()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.txtbobotuas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.Label()
        Me.txtgrade = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung Huruf Mutu Mata Kuliah "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tugas Kecil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(263, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bobot"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tugas Besar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "UTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "UAS"
        '
        'txttugasbesar
        '
        Me.txttugasbesar.Location = New System.Drawing.Point(97, 136)
        Me.txttugasbesar.Name = "txttugasbesar"
        Me.txttugasbesar.Size = New System.Drawing.Size(105, 20)
        Me.txttugasbesar.TabIndex = 7
        '
        'txtbobotkecil
        '
        Me.txtbobotkecil.Location = New System.Drawing.Point(231, 109)
        Me.txtbobotkecil.Name = "txtbobotkecil"
        Me.txtbobotkecil.Size = New System.Drawing.Size(105, 20)
        Me.txtbobotkecil.TabIndex = 8
        '
        'txtuts
        '
        Me.txtuts.Location = New System.Drawing.Point(97, 160)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(105, 20)
        Me.txtuts.TabIndex = 9
        '
        'txttugaskecil
        '
        Me.txttugaskecil.Location = New System.Drawing.Point(97, 109)
        Me.txttugaskecil.Name = "txttugaskecil"
        Me.txttugaskecil.Size = New System.Drawing.Size(105, 20)
        Me.txttugaskecil.TabIndex = 10
        '
        'txtbobotbesar
        '
        Me.txtbobotbesar.Location = New System.Drawing.Point(231, 136)
        Me.txtbobotbesar.Name = "txtbobotbesar"
        Me.txtbobotbesar.Size = New System.Drawing.Size(105, 20)
        Me.txtbobotbesar.TabIndex = 11
        '
        'txtbobotuts
        '
        Me.txtbobotuts.Location = New System.Drawing.Point(231, 162)
        Me.txtbobotuts.Name = "txtbobotuts"
        Me.txtbobotuts.Size = New System.Drawing.Size(105, 20)
        Me.txtbobotuts.TabIndex = 12
        '
        'txtuas
        '
        Me.txtuas.Location = New System.Drawing.Point(97, 185)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(105, 20)
        Me.txtuas.TabIndex = 13
        '
        'txtbobotuas
        '
        Me.txtbobotuas.Location = New System.Drawing.Point(231, 188)
        Me.txtbobotuas.Name = "txtbobotuas"
        Me.txtbobotuas.Size = New System.Drawing.Size(105, 20)
        Me.txtbobotuas.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(94, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Grade"
        '
        'txttotal
        '
        Me.txttotal.AutoSize = True
        Me.txttotal.Location = New System.Drawing.Point(166, 229)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(169, 13)
        Me.txttotal.TabIndex = 17
        Me.txttotal.Text = "......................................................"
        '
        'txtgrade
        '
        Me.txtgrade.AutoSize = True
        Me.txtgrade.Location = New System.Drawing.Point(166, 261)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(169, 13)
        Me.txtgrade.TabIndex = 18
        Me.txtgrade.Text = "......................................................"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(97, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(253, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(354, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(354, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(354, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "%"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 336)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtgrade)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbobotuas)
        Me.Controls.Add(Me.txtuas)
        Me.Controls.Add(Me.txtbobotuts)
        Me.Controls.Add(Me.txtbobotbesar)
        Me.Controls.Add(Me.txttugaskecil)
        Me.Controls.Add(Me.txtuts)
        Me.Controls.Add(Me.txtbobotkecil)
        Me.Controls.Add(Me.txttugasbesar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttugasbesar As System.Windows.Forms.TextBox
    Friend WithEvents txtbobotkecil As System.Windows.Forms.TextBox
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents txttugaskecil As System.Windows.Forms.TextBox
    Friend WithEvents txtbobotbesar As System.Windows.Forms.TextBox
    Friend WithEvents txtbobotuts As System.Windows.Forms.TextBox
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents txtbobotuas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.Label
    Friend WithEvents txtgrade As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
