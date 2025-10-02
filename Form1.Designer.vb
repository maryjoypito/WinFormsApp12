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
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.InactiveCaption
        Button1.Location = New Point(310, 77)
        Button1.Name = "Button1"
        Button1.Size = New Size(212, 39)
        Button1.TabIndex = 0
        Button1.Text = "USERNAME"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(310, 150)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Location = New Point(310, 212)
        Button2.Name = "Button2"
        Button2.Size = New Size(212, 37)
        Button2.TabIndex = 2
        Button2.Text = "PASSWORD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(310, 277)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(212, 38)
        TextBox2.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Plum
        Button3.Location = New Point(333, 338)
        Button3.Name = "Button3"
        Button3.Size = New Size(166, 29)
        Button3.TabIndex = 4
        Button3.Text = "SAVE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button

End Class
