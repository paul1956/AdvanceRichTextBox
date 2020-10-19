' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports AdvanceRichTextBox

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AdvancedRichTextBox1.LineNrsDockSide = LineNumberDockSides.Right
    End Sub
End Class
