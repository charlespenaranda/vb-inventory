<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItems
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.RichTextBox_Desc = New System.Windows.Forms.RichTextBox()
        Me.TextBox_Qty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(480, 446)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(403, 41)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "SUBMIT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product ID : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Description : "
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.TextBox_ID.Location = New System.Drawing.Point(23, 71)
        Me.TextBox_ID.Multiline = True
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(403, 27)
        Me.TextBox_ID.TabIndex = 10
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.TextBox_Name.Location = New System.Drawing.Point(23, 141)
        Me.TextBox_Name.Multiline = True
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(403, 27)
        Me.TextBox_Name.TabIndex = 11
        '
        'RichTextBox_Desc
        '
        Me.RichTextBox_Desc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_Desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_Desc.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.RichTextBox_Desc.Location = New System.Drawing.Point(23, 223)
        Me.RichTextBox_Desc.Name = "RichTextBox_Desc"
        Me.RichTextBox_Desc.Size = New System.Drawing.Size(403, 107)
        Me.RichTextBox_Desc.TabIndex = 12
        Me.RichTextBox_Desc.Text = ""
        '
        'TextBox_Qty
        '
        Me.TextBox_Qty.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.TextBox_Qty.Location = New System.Drawing.Point(480, 141)
        Me.TextBox_Qty.Multiline = True
        Me.TextBox_Qty.Name = "TextBox_Qty"
        Me.TextBox_Qty.Size = New System.Drawing.Size(403, 27)
        Me.TextBox_Qty.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(477, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity : "
        '
        'TextBox_Price
        '
        Me.TextBox_Price.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.TextBox_Price.Location = New System.Drawing.Point(480, 283)
        Me.TextBox_Price.Multiline = True
        Me.TextBox_Price.Name = "TextBox_Price"
        Me.TextBox_Price.Size = New System.Drawing.Size(403, 27)
        Me.TextBox_Price.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(477, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Price : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(477, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Selling Price : "
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(480, 361)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(403, 25)
        Me.ComboBox1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(477, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Critical Quantity : "
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(480, 218)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(403, 25)
        Me.ComboBox2.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(477, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Unit measure : "
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(480, 73)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(403, 25)
        Me.ComboBox3.TabIndex = 22
        '
        'AddItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(935, 530)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox_Price)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_Qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox_Desc)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Name = "AddItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox_Desc As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox_Qty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Price As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
End Class
