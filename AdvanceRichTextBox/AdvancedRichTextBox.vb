' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.ComponentModel

<DefaultProperty("ParentRichTextBox")>
Public Class AdvancedRichTextBox

    <Browsable(False)>
    <Description("Use this property to automatically resize the control (and reposition it if needed).")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property AutoSizing() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.AutoSizing
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.AutoSizing = value
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    Public Property BackgroundGradientAlphaColor() As Color
        Get
            Return Me.LineNumbersForRichTextBox1.BackgroundGradientAlphaColor
        End Get
        Set(value As Color)
            Me.LineNumbersForRichTextBox1.BackgroundGradientAlphaColor = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(GetType(Color), "LightSteelBlue")>
    Public Property BackgroundGradientBetaColor() As Color
        Get
            Return Me.LineNumbersForRichTextBox1.BackgroundGradientBetaColor
        End Get
        Set(value As Color)
            Me.LineNumbersForRichTextBox1.BackgroundGradientBetaColor = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(Drawing2D.LinearGradientMode.Horizontal)>
    Public Property BackgroundGradientDirection() As Drawing2D.LinearGradientMode
        Get
            Return Me.LineNumbersForRichTextBox1.BackgroundGradientDirection
        End Get
        Set(value As Drawing2D.LinearGradientMode)
            Me.LineNumbersForRichTextBox1.BackgroundGradientDirection = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(GetType(Color), "SlateGray")>
    Public Property BorderLinesColor() As Color
        Get
            Return Me.LineNumbersForRichTextBox1.BorderLinesColor
        End Get
        Set(value As Color)
            Me.LineNumbersForRichTextBox1.BorderLinesColor = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(Drawing2D.DashStyle.Dot)>
    Public Property BorderLinesStyle() As Drawing2D.DashStyle
        Get
            Return Me.LineNumbersForRichTextBox1.BorderLinesStyle
        End Get
        Set(value As Drawing2D.DashStyle)
            If value = Drawing2D.DashStyle.Custom Then
                value = Drawing2D.DashStyle.Solid
            End If
            Me.LineNumbersForRichTextBox1.BorderLinesStyle = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(1)>
    Public Property BorderLinesThickness() As Single
        Get
            Return Me.LineNumbersForRichTextBox1.BorderLinesThickness
        End Get
        Set(value As Single)
            Me.LineNumbersForRichTextBox1.BorderLinesThickness = Math.Max(1, Math.Min(255, value))
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(GetType(Color), "SlateGray")>
    Public Property GridLinesColor() As Color
        Get
            Return Me.LineNumbersForRichTextBox1.GridLinesColor
        End Get
        Set(value As Color)
            Me.LineNumbersForRichTextBox1.GridLinesColor = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(Drawing2D.DashStyle.Dot)>
    Public Property GridLinesStyle() As Drawing2D.DashStyle
        Get
            Return Me.LineNumbersForRichTextBox1.GridLinesStyle
        End Get
        Set(value As Drawing2D.DashStyle)
            If value = Drawing2D.DashStyle.Custom Then
                value = Drawing2D.DashStyle.Solid
            End If
            Me.LineNumbersForRichTextBox1.GridLinesStyle = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(1)>
    Public Property GridLinesThickness() As Single
        Get
            Return Me.LineNumbersForRichTextBox1.GridLinesThickness
        End Get
        Set(value As Single)
            Me.LineNumbersForRichTextBox1.GridLinesThickness = Math.Max(1, Math.Min(255, value))
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True)>
    Public Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this to align the LineNumbers to a chosen corner (or center) within their item-area.")>
    <Category("Additional Behavior")>
    <DefaultValue(ContentAlignment.TopRight)>
    Public Property LineNrsAlignment() As ContentAlignment
        Get
            Return Me.LineNumbersForRichTextBox1.LineNrsAlignment
        End Get
        Set(value As ContentAlignment)
            Me.LineNumbersForRichTextBox1.LineNrsAlignment = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this to apply Anti-Aliasing to the LineNumbers (high quality). Some fonts will look better without it, though.")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property LineNrsAntiAlias() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.LineNrsAntiAlias
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.LineNrsAntiAlias = value
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this to set whether the LineNumbers should be shown as hexadecimal values.")>
    <Category("Additional Behavior")>
    <DefaultValue(False)>
    Public Property LineNrsAsHexadecimal() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.LineNrsAsHexadecimal
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.LineNrsAsHexadecimal = value
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this to set whether the LineNumbers are allowed to spill out of their item-area, or should be clipped by it.")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property LineNrsClippedByItemRectangle() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.LineNrsClippedByItemRectangle
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.LineNrsClippedByItemRectangle = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Browsable(True)>
    <Description("Use this property to dock the LineNumbers to a chosen side of the RichTextBox.")>
    <Category("Additional Behavior")>
    <DefaultValue(LineNumberDockSides.Left)>
    Public Property LineNrsDockSide() As LineNumberDockSides
        Get
            Return Me.LineNumbersForRichTextBox1.DockSide
        End Get
        Set(value As LineNumberDockSides)
            Select Case value
                Case LineNumberDockSides.Height
                    Me.LineNumbersForRichTextBox1.Dock = DockStyle.Left
                Case LineNumberDockSides.None
                    Me.LineNumbersForRichTextBox1.Dock = DockStyle.None
                Case LineNumberDockSides.Left
                    Me.LineNumbersForRichTextBox1.Dock = DockStyle.Left
                Case LineNumberDockSides.Right
                    Me.LineNumbersForRichTextBox1.Dock = DockStyle.Right
            End Select
            Me.LineNumbersForRichTextBox1.DockSide = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this to set whether the LineNumbers should have leading zeros (based on the total amount of text lines).")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property LineNrsLeadingZeroes() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.LineNrsLeadingZeroes
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.LineNrsLeadingZeroes = value
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this property to manually reposition the LineNumbers, relative to their current location.")>
    <Category("Additional Behavior")>
    Public Property LineNrsOffset() As Size
        Get
            Return Me.LineNumbersForRichTextBox1.LineNrsOffset
        End Get
        Set(value As Size)
            Me.LineNumbersForRichTextBox1.LineNrsOffset = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Browsable(True)>
    Public Property LineNumbersFont() As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(GetType(Color), "SlateGray")>
    Public Property MarginLinesColor() As Color
        Get
            Return Me.LineNumbersForRichTextBox1.MarginLinesColor
        End Get
        Set(value As Color)
            Me.LineNumbersForRichTextBox1.MarginLinesColor = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(LineNumberDockSides.Left)>
    Public Property MarginLinesSide() As LineNumberDockSides
        Get
            Return Me.LineNumbersForRichTextBox1.MarginLinesSide
        End Get
        Set(value As LineNumberDockSides)
            Me.LineNumbersForRichTextBox1.MarginLinesSide = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(Drawing2D.DashStyle.Solid)>
    Public Property MarginLinesStyle() As Drawing2D.DashStyle
        Get
            Return Me.LineNumbersForRichTextBox1.MarginLinesStyle
        End Get
        Set(value As Drawing2D.DashStyle)
            If value = Drawing2D.DashStyle.Custom Then
                value = Drawing2D.DashStyle.Solid
            End If
            Me.LineNumbersForRichTextBox1.MarginLinesStyle = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Appearance")>
    <DefaultValue(1)>
    Public Property MarginLinesThickness() As Single
        Get
            Return Me.LineNumbersForRichTextBox1.MarginLinesThickness
        End Get
        Set(value As Single)
            Me.LineNumbersForRichTextBox1.MarginLinesThickness = Math.Max(1, Math.Min(255, value))
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this property to enable LineNumbers for the chosen RichTextBox.")>
    <Category("Add LineNumbers to")>
    Public Property ParentRichTextBox() As RichTextBox
        Get
            Return Me.LineNumbersForRichTextBox1.ParentRichTextBox
        End Get
        Set(value As RichTextBox)
            Me.LineNumbersForRichTextBox1.Parent = value
            If Me.LineNumbersForRichTextBox1.Parent IsNot Nothing Then
                Me.Parent = Me.LineNumbersForRichTextBox1.Parent.Parent
                Me.LineNumbersForRichTextBox1.Parent.Refresh()
            End If
            Me.Text = ""
            Me.Refresh()
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("Use this property to enable the control to act as an overlay on top of the RichTextBox.")>
    <Category("Additional Behavior")>
    <DefaultValue(False)>
    Public Property SeeThroughMode() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.SeeThroughMode
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.SeeThroughMode = value
            Me.Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("The BackgroundGradient is a gradual blend of two colors, shown in the back of each LineNumber's item-area.")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property ShowBackgroundGradient() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.ShowBackgroundGradient
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.ShowBackgroundGradient = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("BorderLines are shown on all sides of the LineNumber control.")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property ShowBorderLines() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.ShowBorderLines
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.ShowBorderLines = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("GridLines are the horizontal divider-lines shown above each LineNumber.")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property ShowGridLines() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.ShowGridLines
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.ShowGridLines = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property ShowLineNrs() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.ShowLineNrs
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.ShowLineNrs = value
            Me.Invalidate()
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Description("MarginLines are shown on the Left or Right (or both in Height-mode) of the LineNumber control.")>
    <Category("Additional Behavior")>
    <DefaultValue(True)>
    Public Property ShowMarginLines() As Boolean
        Get
            Return Me.LineNumbersForRichTextBox1.ShowMarginLines
        End Get
        Set(value As Boolean)
            Me.LineNumbersForRichTextBox1.ShowMarginLines = value
            Me.Invalidate()
        End Set
    End Property

    Private Sub LineNumbersForRichTextBox1_Resize(sender As Object, e As EventArgs) Handles LineNumbersForRichTextBox1.Resize
        Select Case Me.LineNumbersForRichTextBox1.DockSide
            Case LineNumberDockSides.Height
                Me.RichTextBox1.Left = Me.LineNumbersForRichTextBox1.Width - 1
                Me.RichTextBox1.Width = Me.Width - (Me.LineNumbersForRichTextBox1.Width * 2)
            Case LineNumberDockSides.Left
                Me.RichTextBox1.Left = Me.LineNumbersForRichTextBox1.Width - 1
                Me.RichTextBox1.Width = Me.Width - Me.LineNumbersForRichTextBox1.Width
            Case LineNumberDockSides.Right
                Me.RichTextBox1.Left = 0
                Me.RichTextBox1.Width = Me.Width - Me.LineNumbersForRichTextBox1.Width
            Case LineNumberDockSides.None
                Me.RichTextBox1.Width = Me.Width
        End Select
    End Sub

End Class
