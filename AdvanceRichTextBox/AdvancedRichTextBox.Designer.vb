Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdvancedRichTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.LineNumbersForRichTextBox1 = New LineNumbersForRichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(22, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(777, 450)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'LineNumbersForRichTextBox1
        '
        Me.LineNumbersForRichTextBox1.BackgroundGradientAlphaColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LineNumbersForRichTextBox1.BorderLinesThickness = 1.0!
        Me.LineNumbersForRichTextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LineNumbersForRichTextBox1.GridLinesThickness = 1.0!
        Me.LineNumbersForRichTextBox1.LineNrsOffset = New System.Drawing.Size(0, 0)
        Me.LineNumbersForRichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.LineNumbersForRichTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.LineNumbersForRichTextBox1.MarginLinesThickness = 1.0!
        Me.LineNumbersForRichTextBox1.Name = "LineNumbersForRichTextBox1"
        Me.LineNumbersForRichTextBox1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.LineNumbersForRichTextBox1.ParentRichTextBox = Me.RichTextBox1
        Me.LineNumbersForRichTextBox1.Size = New System.Drawing.Size(23, 491)
        Me.LineNumbersForRichTextBox1.TabIndex = 23
        Me.LineNumbersForRichTextBox1.Visible = True
        '
        'AdvancedRichTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LineNumbersForRichTextBox1)
        Me.Name = "AdvancedRichTextBox"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LineNumbersForRichTextBox1 As LineNumbersForRichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
