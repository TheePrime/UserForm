<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(301, 175)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(195, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(218, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(412, 37)
        Label1.TabIndex = 1
        Label1.Text = "Circumfrence and Area Calculator"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.System
        Label2.Location = New Point(301, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 2
        Label2.Text = "Radius"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(301, 216)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 37)
        Button1.TabIndex = 3
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(301, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 4
        Label3.Text = "Area ="
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(301, 297)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 15)
        Label4.TabIndex = 5
        Label4.Text = "Circumfrence ="
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(350, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 6
        Label5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(397, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(13, 15)
        Label6.TabIndex = 7
        Label6.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(817, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
