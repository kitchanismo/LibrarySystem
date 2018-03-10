Imports System, System.IO, System.Collections.Generic
Imports System.Drawing, System.Drawing.Drawing2D
Imports System.ComponentModel, System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Windows.Forms.TabControl
Imports System.ComponentModel.Design
Imports System.Drawing.Text

'---------/CREDITS/-----------
'
'Themebase creator: Aeonhack
'Site: elitevs.net
'Created: 08/02/2011
'Changed: 12/06/2011
'Version: 1.5.4
'
'Theme creator: Mavamaarten
'Created: 9/12/2011
'Changed: 3/03/2012
'Version: 2.0
'
'Thanks to Tedd for helping
'with combobox & tabcontrol!
'--------/CREDITS/------------

#Region "THEMEBASE"
MustInherit Class ThemeContainer154
    Inherits ContainerControl

#Region " Initialization "

    Protected G As Graphics, B As Bitmap

    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)

        _ImageSize = Size.Empty
        Font = New Font(_mod.Decrypt("PT9kJWgq3JartEjrZAOhLg=="), 8S)

        MeasureBitmap = New Bitmap(1, 1)
        MeasureGraphics = Graphics.FromImage(MeasureBitmap)

        DrawRadialPath = New GraphicsPath

        InvalidateCustimization()
    End Sub

    Protected NotOverridable Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        If DoneCreation Then InitializeMessages()

        InvalidateCustimization()
        ColorHook()

        If Not _LockWidth = 0 Then Width = _LockWidth
        If Not _LockHeight = 0 Then Height = _LockHeight
        If Not _ControlMode Then MyBase.Dock = DockStyle.Fill

        Transparent = _Transparent
        If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

        MyBase.OnHandleCreated(e)
    End Sub

    Private DoneCreation As Boolean
    Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
        MyBase.OnParentChanged(e)

        If Parent Is Nothing Then Return
        _IsParentForm = TypeOf Parent Is Form

        If Not _ControlMode Then
            InitializeMessages()

            If _IsParentForm Then
                ParentForm.FormBorderStyle = _BorderStyle
                ParentForm.TransparencyKey = _TransparencyKey

                If Not DesignMode Then
                    AddHandler ParentForm.Shown, AddressOf FormShown
                End If
            End If

            Parent.BackColor = BackColor
        End If

        OnCreation()
        DoneCreation = True
        InvalidateTimer()
    End Sub

#End Region

    Private Sub DoAnimation(ByVal i As Boolean)
        OnAnimation()
        If i Then Invalidate()
    End Sub

    Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Width = 0 OrElse Height = 0 Then Return

        If _Transparent AndAlso _ControlMode Then
            PaintHook()
            e.Graphics.DrawImage(B, 0, 0)
        Else
            G = e.Graphics
            PaintHook()
        End If
    End Sub

    Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
        RemoveAnimationCallback(AddressOf DoAnimation)
        MyBase.OnHandleDestroyed(e)
    End Sub

    Private HasShown As Boolean
    Private Sub FormShown(ByVal sender As Object, ByVal e As EventArgs)
        If _ControlMode OrElse HasShown Then Return

        If _StartPosition = FormStartPosition.CenterParent OrElse _StartPosition = FormStartPosition.CenterScreen Then
            Dim SB As Rectangle = Screen.PrimaryScreen.Bounds
            Dim CB As Rectangle = ParentForm.Bounds
            ParentForm.Location = New Point(SB.Width \ 2 - CB.Width \ 2, SB.Height \ 2 - CB.Width \ 2)
        End If

        HasShown = True
    End Sub


#Region " Size Handling "

    Private Frame As Rectangle
    Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If _Movable AndAlso Not _ControlMode Then
            Frame = New Rectangle(7, 7, Width - 14, _Header - 7)
        End If

        InvalidateBitmap()
        Invalidate()

        MyBase.OnSizeChanged(e)
    End Sub

    Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
        If Not _LockWidth = 0 Then width = _LockWidth
        If Not _LockHeight = 0 Then height = _LockHeight
        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

#End Region

#Region " State Handling "

    Protected State As MouseState
    Private Sub SetState(ByVal current As MouseState)
        State = current
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized) Then
            If _Sizable AndAlso Not _ControlMode Then InvalidateMouse()
        End If

        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        If Enabled Then SetState(MouseState.None) Else SetState(MouseState.Block)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        SetState(MouseState.Over)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        SetState(MouseState.Over)
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        SetState(MouseState.None)

        If GetChildAtPoint(PointToClient(MousePosition)) IsNot Nothing Then
            If _Sizable AndAlso Not _ControlMode Then
                Cursor = Cursors.Default
                Previous = 0
            End If
        End If

        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)

        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized OrElse _ControlMode) Then
            If _Movable AndAlso Frame.Contains(e.Location) Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(0))
            ElseIf _Sizable AndAlso Not Previous = 0 Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(Previous))
            End If
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Private WM_LMBUTTONDOWN As Boolean
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If WM_LMBUTTONDOWN AndAlso m.Msg = 513 Then
            WM_LMBUTTONDOWN = False

            SetState(MouseState.Over)
            If Not _SmartBounds Then Return

            If IsParentMdi Then
                CorrectBounds(New Rectangle(Point.Empty, Parent.Parent.Size))
            Else
                CorrectBounds(Screen.FromControl(Parent).WorkingArea)
            End If
        End If
    End Sub

    Private GetIndexPoint As Point
    Private B1, B2, B3, B4 As Boolean
    Private Function GetIndex() As Integer
        GetIndexPoint = PointToClient(MousePosition)
        B1 = GetIndexPoint.X < 7
        B2 = GetIndexPoint.X > Width - 7
        B3 = GetIndexPoint.Y < 7
        B4 = GetIndexPoint.Y > Height - 7

        If B1 AndAlso B3 Then Return 4
        If B1 AndAlso B4 Then Return 7
        If B2 AndAlso B3 Then Return 5
        If B2 AndAlso B4 Then Return 8
        If B1 Then Return 1
        If B2 Then Return 2
        If B3 Then Return 3
        If B4 Then Return 6
        Return 0
    End Function

    Private Current, Previous As Integer
    Private Sub InvalidateMouse()
        Current = GetIndex()
        If Current = Previous Then Return

        Previous = Current
        Select Case Previous
            Case 0
                Cursor = Cursors.Default
            Case 1, 2
                Cursor = Cursors.SizeWE
            Case 3, 6
                Cursor = Cursors.SizeNS
            Case 4, 8
                Cursor = Cursors.SizeNWSE
            Case 5, 7
                Cursor = Cursors.SizeNESW
        End Select
    End Sub

    Private Messages(8) As Message
    Private Sub InitializeMessages()
        Messages(0) = Message.Create(Parent.Handle, 161, New IntPtr(2), IntPtr.Zero)
        For I As Integer = 1 To 8
            Messages(I) = Message.Create(Parent.Handle, 161, New IntPtr(I + 9), IntPtr.Zero)
        Next
    End Sub

    Private Sub CorrectBounds(ByVal bounds As Rectangle)
        If Parent.Width > bounds.Width Then Parent.Width = bounds.Width
        If Parent.Height > bounds.Height Then Parent.Height = bounds.Height

        Dim X As Integer = Parent.Location.X
        Dim Y As Integer = Parent.Location.Y

        If X < bounds.X Then X = bounds.X
        If Y < bounds.Y Then Y = bounds.Y

        Dim Width As Integer = bounds.X + bounds.Width
        Dim Height As Integer = bounds.Y + bounds.Height

        If X + Parent.Width > Width Then X = Width - Parent.Width
        If Y + Parent.Height > Height Then Y = Height - Parent.Height

        Parent.Location = New Point(X, Y)
    End Sub

#End Region


#Region " Base Properties "

    Overrides Property Dock As DockStyle
        Get
            Return MyBase.Dock
        End Get
        Set(ByVal value As DockStyle)
            If Not _ControlMode Then Return
            MyBase.Dock = value
        End Set
    End Property

    Private _BackColor As Boolean
    <Category("Misc")> _
    Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            If value = MyBase.BackColor Then Return

            If Not IsHandleCreated AndAlso _ControlMode AndAlso value = Color.Transparent Then
                _BackColor = True
                Return
            End If

            MyBase.BackColor = value
            If Parent IsNot Nothing Then
                If Not _ControlMode Then Parent.BackColor = value
                ColorHook()
            End If
        End Set
    End Property

    Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(ByVal value As Size)
            MyBase.MinimumSize = value
            If Parent IsNot Nothing Then Parent.MinimumSize = value
        End Set
    End Property

    Overrides Property MaximumSize As Size
        Get
            Return MyBase.MaximumSize
        End Get
        Set(ByVal value As Size)
            MyBase.MaximumSize = value
            If Parent IsNot Nothing Then Parent.MaximumSize = value
        End Set
    End Property

    Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            Invalidate()
        End Set
    End Property

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property ForeColor() As Color
        Get
            Return Color.Empty
        End Get
        Set(ByVal value As Color)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImage() As Image
        Get
            Return Nothing
        End Get
        Set(ByVal value As Image)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImageLayout() As ImageLayout
        Get
            Return ImageLayout.None
        End Get
        Set(ByVal value As ImageLayout)
        End Set
    End Property

#End Region

#Region " Public Properties "

    Private _SmartBounds As Boolean = True
    Property SmartBounds() As Boolean
        Get
            Return _SmartBounds
        End Get
        Set(ByVal value As Boolean)
            _SmartBounds = value
        End Set
    End Property

    Private _Movable As Boolean = True
    Property Movable() As Boolean
        Get
            Return _Movable
        End Get
        Set(ByVal value As Boolean)
            _Movable = value
        End Set
    End Property

    Private _Sizable As Boolean = True
    Property Sizable() As Boolean
        Get
            Return _Sizable
        End Get
        Set(ByVal value As Boolean)
            _Sizable = value
        End Set
    End Property

    Private _TransparencyKey As Color
    Property TransparencyKey() As Color
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.TransparencyKey Else Return _TransparencyKey
        End Get
        Set(ByVal value As Color)
            If value = _TransparencyKey Then Return
            _TransparencyKey = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.TransparencyKey = value
                ColorHook()
            End If
        End Set
    End Property

    Private _BorderStyle As FormBorderStyle
    Property BorderStyle() As FormBorderStyle
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.FormBorderStyle Else Return _BorderStyle
        End Get
        Set(ByVal value As FormBorderStyle)
            _BorderStyle = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.FormBorderStyle = value

                If Not value = FormBorderStyle.None Then
                    Movable = False
                    Sizable = False
                End If
            End If
        End Set
    End Property

    Private _StartPosition As FormStartPosition
    Property StartPosition As FormStartPosition
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.StartPosition Else Return _StartPosition
        End Get
        Set(ByVal value As FormStartPosition)
            _StartPosition = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.StartPosition = value
            End If
        End Set
    End Property

    Private _NoRounding As Boolean
    Property NoRounding() As Boolean
        Get
            Return _NoRounding
        End Get
        Set(ByVal v As Boolean)
            _NoRounding = v
            Invalidate()
        End Set
    End Property

    Private _Image As Image
    Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            If value Is Nothing Then _ImageSize = Size.Empty Else _ImageSize = value.Size

            _Image = value
            Invalidate()
        End Set
    End Property

    Private Items As New Dictionary(Of String, Color)
    Property Colors() As Bloom()
        Get
            Dim T As New List(Of Bloom)
            Dim E As Dictionary(Of String, Color).Enumerator = Items.GetEnumerator

            While E.MoveNext
                T.Add(New Bloom(E.Current.Key, E.Current.Value))
            End While

            Return T.ToArray
        End Get
        Set(ByVal value As Bloom())
            For Each B As Bloom In value
                If Items.ContainsKey(B.Name) Then Items(B.Name) = B.Value
            Next

            InvalidateCustimization()
            ColorHook()
            Invalidate()
        End Set
    End Property

    Private _Customization As String
    Property Customization() As String
        Get
            Return _Customization
        End Get
        Set(ByVal value As String)
            If value = _Customization Then Return

            Dim Data As Byte()
            Dim Items As Bloom() = Colors

            Try
                Data = Convert.FromBase64String(value)
                For I As Integer = 0 To Items.Length - 1
                    Items(I).Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4))
                Next
            Catch
                Return
            End Try

            _Customization = value

            Colors = Items
            ColorHook()
            Invalidate()
        End Set
    End Property

    Private _Transparent As Boolean
    Property Transparent() As Boolean
        Get
            Return _Transparent
        End Get
        Set(ByVal value As Boolean)
            _Transparent = value
            If Not (IsHandleCreated OrElse _ControlMode) Then Return

            If Not value AndAlso Not BackColor.A = 255 Then
                Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
            End If

            SetStyle(ControlStyles.Opaque, Not value)
            SetStyle(ControlStyles.SupportsTransparentBackColor, value)

            InvalidateBitmap()
            Invalidate()
        End Set
    End Property

#End Region

#Region " Private Properties "

    Private _ImageSize As Size
    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Private _IsParentForm As Boolean
    Protected ReadOnly Property IsParentForm As Boolean
        Get
            Return _IsParentForm
        End Get
    End Property

    Protected ReadOnly Property IsParentMdi As Boolean
        Get
            If Parent Is Nothing Then Return False
            Return Parent.Parent IsNot Nothing
        End Get
    End Property

    Private _LockWidth As Integer
    Protected Property LockWidth() As Integer
        Get
            Return _LockWidth
        End Get
        Set(ByVal value As Integer)
            _LockWidth = value
            If Not LockWidth = 0 AndAlso IsHandleCreated Then Width = LockWidth
        End Set
    End Property

    Private _LockHeight As Integer
    Protected Property LockHeight() As Integer
        Get
            Return _LockHeight
        End Get
        Set(ByVal value As Integer)
            _LockHeight = value
            If Not LockHeight = 0 AndAlso IsHandleCreated Then Height = LockHeight
        End Set
    End Property

    Private _Header As Integer = 24
    Protected Property Header() As Integer
        Get
            Return _Header
        End Get
        Set(ByVal v As Integer)
            _Header = v

            If Not _ControlMode Then
                Frame = New Rectangle(7, 7, Width - 14, v - 7)
                Invalidate()
            End If
        End Set
    End Property

    Private _ControlMode As Boolean
    Protected Property ControlMode() As Boolean
        Get
            Return _ControlMode
        End Get
        Set(ByVal v As Boolean)
            _ControlMode = v

            Transparent = _Transparent
            If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

            InvalidateBitmap()
            Invalidate()
        End Set
    End Property

    Private _IsAnimated As Boolean
    Protected Property IsAnimated() As Boolean
        Get
            Return _IsAnimated
        End Get
        Set(ByVal value As Boolean)
            _IsAnimated = value
            InvalidateTimer()
        End Set
    End Property

#End Region


#Region " Property Helpers "

    Protected Function GetPen(ByVal name As String) As Pen
        Return New Pen(Items(name))
    End Function
    Protected Function GetPen(ByVal name As String, ByVal width As Single) As Pen
        Return New Pen(Items(name), width)
    End Function

    Protected Function GetBrush(ByVal name As String) As SolidBrush
        Return New SolidBrush(Items(name))
    End Function

    Protected Function GetColor(ByVal name As String) As Color
        Return Items(name)
    End Function

    Protected Sub SetColor(ByVal name As String, ByVal value As Color)
        If Items.ContainsKey(name) Then Items(name) = value Else Items.Add(name, value)
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(a, r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal value As Color)
        SetColor(name, Color.FromArgb(a, value))
    End Sub

    Private Sub InvalidateBitmap()
        If _Transparent AndAlso _ControlMode Then
            If Width = 0 OrElse Height = 0 Then Return
            B = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
            G = Graphics.FromImage(B)
        Else
            G = Nothing
            B = Nothing
        End If
    End Sub

    Private Sub InvalidateCustimization()
        Dim M As New MemoryStream(Items.Count * 4)

        For Each B As Bloom In Colors
            M.Write(BitConverter.GetBytes(B.Value.ToArgb), 0, 4)
        Next

        M.Close()
        _Customization = Convert.ToBase64String(M.ToArray)
    End Sub

    Private Sub InvalidateTimer()
        If DesignMode OrElse Not DoneCreation Then Return

        If _IsAnimated Then
            AddAnimationCallback(AddressOf DoAnimation)
        Else
            RemoveAnimationCallback(AddressOf DoAnimation)
        End If
    End Sub

#End Region


#Region " User Hooks "

    Protected MustOverride Sub ColorHook()
    Protected MustOverride Sub PaintHook()

    Protected Overridable Sub OnCreation()
    End Sub

    Protected Overridable Sub OnAnimation()
    End Sub

#End Region


#Region " Offset "

    Private OffsetReturnRectangle As Rectangle
    Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
        OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2))
        Return OffsetReturnRectangle
    End Function

    Private OffsetReturnSize As Size
    Protected Function Offset(ByVal s As Size, ByVal amount As Integer) As Size
        OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
        Return OffsetReturnSize
    End Function

    Private OffsetReturnPoint As Point
    Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
        OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
        Return OffsetReturnPoint
    End Function

#End Region

#Region " Center "

    Private CenterReturn As Point

    Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X + c.X, (p.Height \ 2 - c.Height \ 2) + p.Y + c.Y)
        Return CenterReturn
    End Function
    Protected Function Center(ByVal p As Rectangle, ByVal c As Size) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X, (p.Height \ 2 - c.Height \ 2) + p.Y)
        Return CenterReturn
    End Function

    Protected Function Center(ByVal child As Rectangle) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal child As Size) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As Point
        Return Center(Width, Height, childWidth, childHeight)
    End Function

    Protected Function Center(ByVal p As Size, ByVal c As Size) As Point
        Return Center(p.Width, p.Height, c.Width, c.Height)
    End Function

    Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
        CenterReturn = New Point(pWidth \ 2 - cWidth \ 2, pHeight \ 2 - cHeight \ 2)
        Return CenterReturn
    End Function

#End Region

#Region " Measure "

    Private MeasureBitmap As Bitmap
    Private MeasureGraphics As Graphics

    Protected Function Measure() As Size
        SyncLock MeasureGraphics
            Return MeasureGraphics.MeasureString(Text, Font, Width).ToSize
        End SyncLock
    End Function
    Protected Function Measure(ByVal text As String) As Size
        SyncLock MeasureGraphics
            Return MeasureGraphics.MeasureString(text, Font, Width).ToSize
        End SyncLock
    End Function

#End Region


#Region " DrawPixel "

    Private DrawPixelBrush As SolidBrush

    Protected Sub DrawPixel(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer)
        If _Transparent Then
            B.SetPixel(x, y, c1)
        Else
            DrawPixelBrush = New SolidBrush(c1)
            G.FillRectangle(DrawPixelBrush, x, y, 1, 1)
        End If
    End Sub

#End Region

#Region " DrawCorners "

    Private DrawCornersBrush As SolidBrush

    Protected Sub DrawCorners(ByVal c1 As Color, ByVal offset As Integer)
        DrawCorners(c1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle, ByVal offset As Integer)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawCorners(ByVal c1 As Color)
        DrawCorners(c1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        If _NoRounding Then Return

        If _Transparent Then
            B.SetPixel(x, y, c1)
            B.SetPixel(x + (width - 1), y, c1)
            B.SetPixel(x, y + (height - 1), c1)
            B.SetPixel(x + (width - 1), y + (height - 1), c1)
        Else
            DrawCornersBrush = New SolidBrush(c1)
            G.FillRectangle(DrawCornersBrush, x, y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
        End If
    End Sub

#End Region

#Region " DrawBorders "

    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal offset As Integer)
        DrawBorders(p1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle, ByVal offset As Integer)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawBorders(ByVal p1 As Pen)
        DrawBorders(p1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        G.DrawRectangle(p1, x, y, width - 1, height - 1)
    End Sub

#End Region

#Region " DrawText "

    Private DrawTextPoint As Point
    Private DrawTextSize As Size

    Protected Sub DrawText(ByVal b1 As Brush, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawText(b1, Text, a, x, y)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal text As String, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If text.Length = 0 Then Return

        DrawTextSize = Measure(text)
        DrawTextPoint = New Point(Width \ 2 - DrawTextSize.Width \ 2, Header \ 2 - DrawTextSize.Height \ 2)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Center
                G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Right
                G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y)
        End Select
    End Sub

    Protected Sub DrawText(ByVal b1 As Brush, ByVal p1 As Point)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, p1)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal x As Integer, ByVal y As Integer)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, x, y)
    End Sub

#End Region

#Region " DrawImage "

    Private DrawImagePoint As Point

    Protected Sub DrawImage(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, a, x, y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        DrawImagePoint = New Point(Width \ 2 - image.Width \ 2, Header \ 2 - image.Height \ 2)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Center
                G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Right
                G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height)
        End Select
    End Sub

    Protected Sub DrawImage(ByVal p1 As Point)
        DrawImage(_Image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, x, y)
    End Sub

    Protected Sub DrawImage(ByVal image As Image, ByVal p1 As Point)
        DrawImage(image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        G.DrawImage(image, x, y, image.Width, image.Height)
    End Sub

#End Region

#Region " DrawGradient "

    Private DrawGradientBrush As LinearGradientBrush
    Private DrawGradientRectangle As Rectangle

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub


    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub

#End Region

#Region " DrawRadial "

    Private DrawRadialPath As GraphicsPath
    Private DrawRadialBrush1 As PathGradientBrush
    Private DrawRadialBrush2 As LinearGradientBrush
    Private DrawRadialRectangle As Rectangle

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, width \ 2, height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal center As Point)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, cx, cy)
    End Sub

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawRadial(blend, r, r.Width \ 2, r.Height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal center As Point)
        DrawRadial(blend, r, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialPath.Reset()
        DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)

        DrawRadialBrush1 = New PathGradientBrush(DrawRadialPath)
        DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
        DrawRadialBrush1.InterpolationColors = blend

        If G.SmoothingMode = SmoothingMode.AntiAlias Then
            G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
        Else
            G.FillEllipse(DrawRadialBrush1, r)
        End If
    End Sub


    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawGradientRectangle)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
        G.FillEllipse(DrawGradientBrush, r)
    End Sub

#End Region

#Region " CreateRound "

    Private CreateRoundPath As GraphicsPath
    Private CreateRoundRectangle As Rectangle

    Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
        CreateRoundRectangle = New Rectangle(x, y, width, height)
        Return CreateRound(CreateRoundRectangle, slope)
    End Function

    Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
        CreateRoundPath = New GraphicsPath(FillMode.Winding)
        CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
        CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

#End Region

End Class

MustInherit Class ThemeControl154
    Inherits Control


#Region " Initialization "

    Protected G As Graphics, B As Bitmap

    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)

        _ImageSize = Size.Empty
        Font = New Font("Verdana", 8S)

        MeasureBitmap = New Bitmap(1, 1)
        MeasureGraphics = Graphics.FromImage(MeasureBitmap)

        DrawRadialPath = New GraphicsPath

        InvalidateCustimization() 'Remove?
    End Sub

    Protected NotOverridable Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        InvalidateCustimization()
        ColorHook()

        If Not _LockWidth = 0 Then Width = _LockWidth
        If Not _LockHeight = 0 Then Height = _LockHeight

        Transparent = _Transparent
        If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

        MyBase.OnHandleCreated(e)
    End Sub

    Private DoneCreation As Boolean
    Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
        If Parent IsNot Nothing Then
            OnCreation()
            DoneCreation = True
            InvalidateTimer()
        End If

        MyBase.OnParentChanged(e)
    End Sub

#End Region

    Private Sub DoAnimation(ByVal i As Boolean)
        OnAnimation()
        If i Then Invalidate()
    End Sub

    Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Width = 0 OrElse Height = 0 Then Return

        If _Transparent Then
            PaintHook()
            e.Graphics.DrawImage(B, 0, 0)
        Else
            G = e.Graphics
            PaintHook()
        End If
    End Sub

    Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
        RemoveAnimationCallback(AddressOf DoAnimation)
        MyBase.OnHandleDestroyed(e)
    End Sub

#Region " Size Handling "

    Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If _Transparent Then
            InvalidateBitmap()
        End If

        Invalidate()
        MyBase.OnSizeChanged(e)
    End Sub

    Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
        If Not _LockWidth = 0 Then width = _LockWidth
        If Not _LockHeight = 0 Then height = _LockHeight
        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

#End Region

#Region " State Handling "

    Private InPosition As Boolean
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        InPosition = True
        SetState(MouseState.Over)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        If InPosition Then SetState(MouseState.Over)
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        InPosition = False
        SetState(MouseState.None)
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        If Enabled Then SetState(MouseState.None) Else SetState(MouseState.Block)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected State As MouseState
    Private Sub SetState(ByVal current As MouseState)
        State = current
        Invalidate()
    End Sub

#End Region


#Region " Base Properties "

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property ForeColor() As Color
        Get
            Return Color.Empty
        End Get
        Set(ByVal value As Color)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImage() As Image
        Get
            Return Nothing
        End Get
        Set(ByVal value As Image)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImageLayout() As ImageLayout
        Get
            Return ImageLayout.None
        End Get
        Set(ByVal value As ImageLayout)
        End Set
    End Property

    Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property
    Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            Invalidate()
        End Set
    End Property

    Private _BackColor As Boolean
    <Category("Misc")> _
    Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            If Not IsHandleCreated AndAlso value = Color.Transparent Then
                _BackColor = True
                Return
            End If

            MyBase.BackColor = value
            If Parent IsNot Nothing Then ColorHook()
        End Set
    End Property

#End Region

#Region " Public Properties "

    Private _NoRounding As Boolean
    Property NoRounding() As Boolean
        Get
            Return _NoRounding
        End Get
        Set(ByVal v As Boolean)
            _NoRounding = v
            Invalidate()
        End Set
    End Property

    Private _Image As Image
    Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            If value Is Nothing Then
                _ImageSize = Size.Empty
            Else
                _ImageSize = value.Size
            End If

            _Image = value
            Invalidate()
        End Set
    End Property

    Private _Transparent As Boolean
    Property Transparent() As Boolean
        Get
            Return _Transparent
        End Get
        Set(ByVal value As Boolean)
            _Transparent = value
            If Not IsHandleCreated Then Return

            If Not value AndAlso Not BackColor.A = 255 Then
                Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
            End If

            SetStyle(ControlStyles.Opaque, Not value)
            SetStyle(ControlStyles.SupportsTransparentBackColor, value)

            If value Then InvalidateBitmap() Else B = Nothing
            Invalidate()
        End Set
    End Property

    Private Items As New Dictionary(Of String, Color)
    Property Colors() As Bloom()
        Get
            Dim T As New List(Of Bloom)
            Dim E As Dictionary(Of String, Color).Enumerator = Items.GetEnumerator

            While E.MoveNext
                T.Add(New Bloom(E.Current.Key, E.Current.Value))
            End While

            Return T.ToArray
        End Get
        Set(ByVal value As Bloom())
            For Each B As Bloom In value
                If Items.ContainsKey(B.Name) Then Items(B.Name) = B.Value
            Next

            InvalidateCustimization()
            ColorHook()
            Invalidate()
        End Set
    End Property

    Private _Customization As String
    Property Customization() As String
        Get
            Return _Customization
        End Get
        Set(ByVal value As String)
            If value = _Customization Then Return

            Dim Data As Byte()
            Dim Items As Bloom() = Colors

            Try
                Data = Convert.FromBase64String(value)
                For I As Integer = 0 To Items.Length - 1
                    Items(I).Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4))
                Next
            Catch
                Return
            End Try

            _Customization = value

            Colors = Items
            ColorHook()
            Invalidate()
        End Set
    End Property

#End Region

#Region " Private Properties "

    Private _ImageSize As Size
    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Private _LockWidth As Integer
    Protected Property LockWidth() As Integer
        Get
            Return _LockWidth
        End Get
        Set(ByVal value As Integer)
            _LockWidth = value
            If Not LockWidth = 0 AndAlso IsHandleCreated Then Width = LockWidth
        End Set
    End Property

    Private _LockHeight As Integer
    Protected Property LockHeight() As Integer
        Get
            Return _LockHeight
        End Get
        Set(ByVal value As Integer)
            _LockHeight = value
            If Not LockHeight = 0 AndAlso IsHandleCreated Then Height = LockHeight
        End Set
    End Property

    Private _IsAnimated As Boolean
    Protected Property IsAnimated() As Boolean
        Get
            Return _IsAnimated
        End Get
        Set(ByVal value As Boolean)
            _IsAnimated = value
            InvalidateTimer()
        End Set
    End Property

#End Region


#Region " Property Helpers "

    Protected Function GetPen(ByVal name As String) As Pen
        Return New Pen(Items(name))
    End Function
    Protected Function GetPen(ByVal name As String, ByVal width As Single) As Pen
        Return New Pen(Items(name), width)
    End Function

    Protected Function GetBrush(ByVal name As String) As SolidBrush
        Return New SolidBrush(Items(name))
    End Function

    Protected Function GetColor(ByVal name As String) As Color
        Return Items(name)
    End Function

    Protected Sub SetColor(ByVal name As String, ByVal value As Color)
        If Items.ContainsKey(name) Then Items(name) = value Else Items.Add(name, value)
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(a, r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal value As Color)
        SetColor(name, Color.FromArgb(a, value))
    End Sub

    Private Sub InvalidateBitmap()
        If Width = 0 OrElse Height = 0 Then Return
        B = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
        G = Graphics.FromImage(B)
    End Sub

    Private Sub InvalidateCustimization()
        Dim M As New MemoryStream(Items.Count * 4)

        For Each B As Bloom In Colors
            M.Write(BitConverter.GetBytes(B.Value.ToArgb), 0, 4)
        Next

        M.Close()
        _Customization = Convert.ToBase64String(M.ToArray)
    End Sub

    Private Sub InvalidateTimer()
        If DesignMode OrElse Not DoneCreation Then Return

        If _IsAnimated Then
            AddAnimationCallback(AddressOf DoAnimation)
        Else
            RemoveAnimationCallback(AddressOf DoAnimation)
        End If
    End Sub
#End Region


#Region " User Hooks "

    Protected MustOverride Sub ColorHook()
    Protected MustOverride Sub PaintHook()

    Protected Overridable Sub OnCreation()
    End Sub

    Protected Overridable Sub OnAnimation()
    End Sub

#End Region


#Region " Offset "

    Private OffsetReturnRectangle As Rectangle
    Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
        OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2))
        Return OffsetReturnRectangle
    End Function

    Private OffsetReturnSize As Size
    Protected Function Offset(ByVal s As Size, ByVal amount As Integer) As Size
        OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
        Return OffsetReturnSize
    End Function

    Private OffsetReturnPoint As Point
    Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
        OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
        Return OffsetReturnPoint
    End Function

#End Region

#Region " Center "

    Private CenterReturn As Point

    Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X + c.X, (p.Height \ 2 - c.Height \ 2) + p.Y + c.Y)
        Return CenterReturn
    End Function
    Protected Function Center(ByVal p As Rectangle, ByVal c As Size) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X, (p.Height \ 2 - c.Height \ 2) + p.Y)
        Return CenterReturn
    End Function

    Protected Function Center(ByVal child As Rectangle) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal child As Size) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As Point
        Return Center(Width, Height, childWidth, childHeight)
    End Function

    Protected Function Center(ByVal p As Size, ByVal c As Size) As Point
        Return Center(p.Width, p.Height, c.Width, c.Height)
    End Function

    Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
        CenterReturn = New Point(pWidth \ 2 - cWidth \ 2, pHeight \ 2 - cHeight \ 2)
        Return CenterReturn
    End Function

#End Region

#Region " Measure "

    Private MeasureBitmap As Bitmap
    Private MeasureGraphics As Graphics 'TODO: Potential issues during multi-threading.

    Protected Function Measure() As Size
        Return MeasureGraphics.MeasureString(Text, Font, Width).ToSize
    End Function
    Protected Function Measure(ByVal text As String) As Size
        Return MeasureGraphics.MeasureString(text, Font, Width).ToSize
    End Function

#End Region


#Region " DrawPixel "

    Private DrawPixelBrush As SolidBrush

    Protected Sub DrawPixel(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer)
        If _Transparent Then
            B.SetPixel(x, y, c1)
        Else
            DrawPixelBrush = New SolidBrush(c1)
            G.FillRectangle(DrawPixelBrush, x, y, 1, 1)
        End If
    End Sub

#End Region

#Region " DrawCorners "

    Private DrawCornersBrush As SolidBrush

    Protected Sub DrawCorners(ByVal c1 As Color, ByVal offset As Integer)
        DrawCorners(c1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle, ByVal offset As Integer)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawCorners(ByVal c1 As Color)
        DrawCorners(c1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        If _NoRounding Then Return

        If _Transparent Then
            B.SetPixel(x, y, c1)
            B.SetPixel(x + (width - 1), y, c1)
            B.SetPixel(x, y + (height - 1), c1)
            B.SetPixel(x + (width - 1), y + (height - 1), c1)
        Else
            DrawCornersBrush = New SolidBrush(c1)
            G.FillRectangle(DrawCornersBrush, x, y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
        End If
    End Sub

#End Region

#Region " DrawBorders "

    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal offset As Integer)
        DrawBorders(p1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle, ByVal offset As Integer)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawBorders(ByVal p1 As Pen)
        DrawBorders(p1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        G.DrawRectangle(p1, x, y, width - 1, height - 1)
    End Sub

#End Region

#Region " DrawText "

    Private DrawTextPoint As Point
    Private DrawTextSize As Size

    Protected Sub DrawText(ByVal b1 As Brush, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawText(b1, Text, a, x, y)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal text As String, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If text.Length = 0 Then Return

        DrawTextSize = Measure(text)
        DrawTextPoint = Center(DrawTextSize)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Center
                G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Right
                G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y)
        End Select
    End Sub

    Protected Sub DrawText(ByVal b1 As Brush, ByVal p1 As Point)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, p1)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal x As Integer, ByVal y As Integer)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, x, y)
    End Sub

#End Region

#Region " DrawImage "

    Private DrawImagePoint As Point

    Protected Sub DrawImage(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, a, x, y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        DrawImagePoint = Center(image.Size)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Center
                G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Right
                G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height)
        End Select
    End Sub

    Protected Sub DrawImage(ByVal p1 As Point)
        DrawImage(_Image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, x, y)
    End Sub

    Protected Sub DrawImage(ByVal image As Image, ByVal p1 As Point)
        DrawImage(image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        G.DrawImage(image, x, y, image.Width, image.Height)
    End Sub

#End Region

#Region " DrawGradient "

    Private DrawGradientBrush As LinearGradientBrush
    Private DrawGradientRectangle As Rectangle

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub


    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub

#End Region

#Region " DrawRadial "

    Private DrawRadialPath As GraphicsPath
    Private DrawRadialBrush1 As PathGradientBrush
    Private DrawRadialBrush2 As LinearGradientBrush
    Private DrawRadialRectangle As Rectangle

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, width \ 2, height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal center As Point)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, cx, cy)
    End Sub

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawRadial(blend, r, r.Width \ 2, r.Height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal center As Point)
        DrawRadial(blend, r, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialPath.Reset()
        DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)

        DrawRadialBrush1 = New PathGradientBrush(DrawRadialPath)
        DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
        DrawRadialBrush1.InterpolationColors = blend

        If G.SmoothingMode = SmoothingMode.AntiAlias Then
            G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
        Else
            G.FillEllipse(DrawRadialBrush1, r)
        End If
    End Sub


    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawRadialRectangle)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawRadialRectangle, angle)
    End Sub

    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillEllipse(DrawRadialBrush2, r)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
        G.FillEllipse(DrawRadialBrush2, r)
    End Sub

#End Region

#Region " CreateRound "

    Private CreateRoundPath As GraphicsPath
    Private CreateRoundRectangle As Rectangle

    Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
        CreateRoundRectangle = New Rectangle(x, y, width, height)
        Return CreateRound(CreateRoundRectangle, slope)
    End Function

    Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
        CreateRoundPath = New GraphicsPath(FillMode.Winding)
        CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
        CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

#End Region

End Class

Module ThemeShare

#Region " Animation "

    Private Frames As Integer
    Private Invalidate As Boolean
    Public ThemeTimer As New PrecisionTimer

    Public FPS As Integer = 20 '1000 / 50 = 20 FPS
    Public Rate As Integer = 50

    Public Delegate Sub AnimationDelegate(ByVal invalidate As Boolean)

    Private Callbacks As New List(Of AnimationDelegate)

    Private Sub HandleCallbacks(ByVal state As IntPtr, ByVal reserve As Boolean)
        Invalidate = (Frames >= FPS)
        If Invalidate Then Frames = 0

        SyncLock Callbacks
            For I As Integer = 0 To Callbacks.Count - 1
                Callbacks(I).Invoke(Invalidate)
            Next
        End SyncLock

        Frames += Rate
    End Sub

    Private Sub InvalidateThemeTimer()
        If Callbacks.Count = 0 Then
            ' ThemeTimer.Delete()
        Else
            ThemeTimer.Create(0, Rate, AddressOf HandleCallbacks)
        End If
    End Sub

    Sub AddAnimationCallback(ByVal callback As AnimationDelegate)
        SyncLock Callbacks
            If Callbacks.Contains(callback) Then Return

            Callbacks.Add(callback)
            InvalidateThemeTimer()
        End SyncLock
    End Sub

    Sub RemoveAnimationCallback(ByVal callback As AnimationDelegate)
        SyncLock Callbacks
            If Not Callbacks.Contains(callback) Then Return

            Callbacks.Remove(callback)
            InvalidateThemeTimer()
        End SyncLock
    End Sub

#End Region

End Module

Enum MouseState As Byte
    None = 0
    Over = 1
    Down = 2
    Block = 3
End Enum

Structure Bloom

    Public _Name As String
    ReadOnly Property Name() As String
        Get
            Return _Name
        End Get
    End Property

    Private _Value As Color
    Property Value() As Color
        Get
            Return _Value
        End Get
        Set(ByVal value As Color)
            _Value = value
        End Set
    End Property

    Property ValueHex() As String
        Get
            Return String.Concat("#", _
            _Value.R.ToString("X2", Nothing), _
            _Value.G.ToString("X2", Nothing), _
            _Value.B.ToString("X2", Nothing))
        End Get
        Set(ByVal value As String)
            Try
                _Value = ColorTranslator.FromHtml(value)
            Catch
                Return
            End Try
        End Set
    End Property


    Sub New(ByVal name As String, ByVal value As Color)
        _Name = name
        _Value = value
    End Sub
End Structure

'------------------
'Creator: aeonhack
'Site: elitevs.net
'Created: 11/30/2011
'Changed: 11/30/2011
'Version: 1.0.0
'------------------
Class PrecisionTimer
    Implements IDisposable

    Private _Enabled As Boolean
    ReadOnly Property Enabled() As Boolean
        Get
            Return _Enabled
        End Get
    End Property

    Private Handle As IntPtr
    Private TimerCallback As TimerDelegate

    <DllImport("kernel32.dll", EntryPoint:="CreateTimerQueueTimer")> _
    Private Shared Function CreateTimerQueueTimer( _
    ByRef handle As IntPtr, _
    ByVal queue As IntPtr, _
    ByVal callback As TimerDelegate, _
    ByVal state As IntPtr, _
    ByVal dueTime As UInteger, _
    ByVal period As UInteger, _
    ByVal flags As UInteger) As Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="DeleteTimerQueueTimer")> _
    Private Shared Function DeleteTimerQueueTimer( _
    ByVal queue As IntPtr, _
    ByVal handle As IntPtr, _
    ByVal callback As IntPtr) As Boolean
    End Function

    Delegate Sub TimerDelegate(ByVal r1 As IntPtr, ByVal r2 As Boolean)

    Sub Create(ByVal dueTime As UInteger, ByVal period As UInteger, ByVal callback As TimerDelegate)
        If _Enabled Then Return

        TimerCallback = callback
        Dim Success As Boolean = CreateTimerQueueTimer(Handle, IntPtr.Zero, TimerCallback, IntPtr.Zero, dueTime, period, 0)

        If Not Success Then ThrowNewException("CreateTimerQueueTimer")
        _Enabled = Success
    End Sub

    ' Sub Delete()
    '     If Not _Enabled Then Return

    ' Dim Success As Boolean = DeleteTimerQueueTimer(IntPtr.Zero, Handle, IntPtr.Zero)
    '    If Not Success AndAlso Not Marshal.GetLastWin32Error = 997 Then

    '      ThrowNewException("DeleteTimerQueueTimer")
    '
    '    End If

    '   _Enabled = Not Success

    'End Sub

    Private Sub ThrowNewException(ByVal name As String)
        Throw New Exception(String.Format("{0} failed. Win32Error: {1}", name, Marshal.GetLastWin32Error))
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Delete()
    End Sub
End Class
#End Region

Class GhostTheme
    Inherits ThemeContainer154

    Protected Overrides Sub ColorHook()

    End Sub

    Private _ShowIcon As Boolean
    Public Property ShowIcon As Boolean
        Get
            Return _ShowIcon
        End Get
        Set(ByVal value As Boolean)
            _ShowIcon = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub PaintHook()
        G.Clear(Color.DimGray)
        Dim hatch As New ColorBlend(2)
        DrawBorders(Pens.Gray, 1)
        hatch.Colors(0) = Color.DimGray
        hatch.Colors(1) = Color.FromArgb(60, 60, 60)
        hatch.Positions(0) = 0
        hatch.Positions(1) = 1
        DrawGradient(hatch, New Rectangle(0, 0, Width, 24))
        hatch.Colors(0) = Color.FromArgb(100, 100, 100)
        hatch.Colors(1) = Color.DimGray
        DrawGradient(hatch, New Rectangle(0, 0, Width, 12))
        Dim asdf As HatchBrush
        asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(15, Color.Black), Color.FromArgb(0, Color.Gray))
        hatch.Colors(0) = Color.FromArgb(120, Color.Black)
        hatch.Colors(1) = Color.FromArgb(0, Color.Black)
        DrawGradient(hatch, New Rectangle(0, 0, Width, 30))
        G.FillRectangle(asdf, 0, 0, Width, 24)
        G.DrawLine(Pens.Black, 6, 24, Width - 7, 24)
        G.DrawLine(Pens.Black, 6, 24, 6, Height - 7)
        G.DrawLine(Pens.Black, 6, Height - 7, Width - 7, Height - 7)
        G.DrawLine(Pens.Black, Width - 7, 24, Width - 7, Height - 7)
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(1, 24, 5, Height - 6 - 24))
        G.FillRectangle(asdf, 1, 24, 5, Height - 6 - 24)
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(Width - 6, 24, Width - 1, Height - 6 - 24))
        G.FillRectangle(asdf, Width - 6, 24, Width - 2, Height - 6 - 24)
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(1, Height - 6, Width - 2, Height - 1))
        G.FillRectangle(asdf, 1, Height - 6, Width - 2, Height - 1)
        DrawBorders(Pens.Black)
        asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
        G.FillRectangle(asdf, 7, 25, Width - 14, Height - 24 - 8)
        G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), 7, 25, Width - 14, Height - 24 - 8)
        DrawCorners(Color.Fuchsia)
        DrawCorners(Color.Fuchsia, 0, 1, 1, 1)
        DrawCorners(Color.Fuchsia, 1, 0, 1, 1)
        DrawPixel(Color.Black, 1, 1)

        DrawCorners(Color.Fuchsia, 0, Height - 2, 1, 1)
        DrawCorners(Color.Fuchsia, 1, Height - 1, 1, 1)
        DrawPixel(Color.Black, Width - 2, 1)

        DrawCorners(Color.Fuchsia, Width - 1, 1, 1, 1)
        DrawCorners(Color.Fuchsia, Width - 2, 0, 1, 1)
        DrawPixel(Color.Black, 1, Height - 2)

        DrawCorners(Color.Fuchsia, Width - 1, Height - 2, 1, 1)
        DrawCorners(Color.Fuchsia, Width - 2, Height - 1, 1, 1)
        DrawPixel(Color.Black, Width - 2, Height - 2)

        Dim cblend As New ColorBlend(2)
        cblend.Colors(0) = Color.FromArgb(35, Color.Black)
        cblend.Colors(1) = Color.FromArgb(0, 0, 0, 0)
        cblend.Positions(0) = 0
        cblend.Positions(1) = 1
        DrawGradient(cblend, 7, 25, 2, Height - 6 - 24, 0)
        cblend.Colors(0) = Color.FromArgb(0, 0, 0, 0)
        cblend.Colors(1) = Color.FromArgb(35, Color.Black)
        DrawGradient(cblend, Width - 24, 25, 17, Height - 6 - 24, 0)
        cblend.Colors(1) = Color.FromArgb(0, 0, 0, 0)
        cblend.Colors(0) = Color.FromArgb(35, Color.Black)
        DrawGradient(cblend, 7, 25, Me.Width - 14, 17, 90)
        cblend.Colors(0) = Color.FromArgb(0, 0, 0, 0)
        cblend.Colors(1) = Color.FromArgb(35, Color.Black)
        DrawGradient(cblend, 8, Me.Height - 24, Me.Width - 14, 17, 90)
        If _ShowIcon = False Then
            ' G.DrawString(Text, Font, Brushes.White, New Point(6, 6))
        Else
            G.DrawIcon(FindForm.Icon, New Rectangle(New Point(9, 5), New Size(16, 16)))
            ' G.DrawString(Text, Font, Brushes.White, New Point(28, 6))
        End If

    End Sub

    Public Sub New()
        TransparencyKey = Color.Fuchsia
    End Sub
End Class

Class GhostButton
    Inherits ThemeControl154
    Private Glass As Boolean = True
    Private _color As Color
    Dim a As Integer = 0

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub OnAnimation()
        MyBase.OnAnimation()
        Select Case State
            Case MouseState.Over
                If a < 20 Then
                    a += 5
                    Invalidate()
                    Application.DoEvents()
                End If
            Case MouseState.None
                If a > 0 Then
                    a -= 5
                    If a < 0 Then a = 0
                    Invalidate()
                    Application.DoEvents()
                End If
        End Select
    End Sub

    Public Property EnableGlass As Boolean
        Get
            Return Glass
        End Get
        Set(ByVal value As Boolean)
            Glass = value
        End Set
    End Property

    Public Property Color As Color
        Get
            Return _color
        End Get
        Set(ByVal value As Color)
            _color = value
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Dim gg As Graphics = Me.CreateGraphics
        Dim textSize As SizeF = Me.CreateGraphics.MeasureString(Text, Font)
        gg.DrawString(Text, Font, Brushes.White, New RectangleF(0, 0, Me.Width, Me.Height))
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(_color)
        If State = MouseState.Over Then
            Dim cblend As New ColorBlend(2)
            cblend.Colors(0) = Color.FromArgb(200, 50, 50, 50)
            cblend.Colors(1) = Color.FromArgb(200, 70, 70, 70)
            cblend.Positions(0) = 0
            cblend.Positions(1) = 1
            DrawGradient(cblend, New Rectangle(0, 0, Width, Height))
            cblend.Colors(0) = Color.FromArgb(0, 0, 0, 0)
            cblend.Colors(1) = Color.FromArgb(40, Color.White)
            If Glass Then DrawGradient(cblend, New Rectangle(0, 0, Width, Height / 5 * 2))
        ElseIf State = MouseState.None Then
            Dim cblend As New ColorBlend(2)
            cblend.Colors(0) = Color.FromArgb(200, 50, 50, 50)
            cblend.Colors(1) = Color.FromArgb(200, 70, 70, 70)
            cblend.Positions(0) = 0
            cblend.Positions(1) = 1
            DrawGradient(cblend, New Rectangle(0, 0, Width, Height))
            cblend.Colors(0) = Color.FromArgb(0, 0, 0, 0)
            cblend.Colors(1) = Color.FromArgb(40, Color.White)
            If Glass Then DrawGradient(cblend, New Rectangle(0, 0, Width, Height / 5 * 2))
        Else
            Dim cblend As New ColorBlend(2)
            cblend.Colors(0) = Color.FromArgb(200, 30, 30, 30)
            cblend.Colors(1) = Color.FromArgb(200, 50, 50, 50)
            cblend.Positions(0) = 0
            cblend.Positions(1) = 1
            DrawGradient(cblend, New Rectangle(0, 0, Width, Height))
            cblend.Colors(0) = Color.FromArgb(0, 0, 0, 0)
            cblend.Colors(1) = Color.FromArgb(40, Color.White)
            If Glass Then DrawGradient(cblend, New Rectangle(0, 0, Width, Height / 5 * 2))
        End If
        G.FillRectangle(New SolidBrush(Color.FromArgb(a, Drawing.Color.White)), 0, 0, Width, Height)
        Dim hatch As HatchBrush
        hatch = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(25, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(hatch, 0, 0, Width, Height)
        Dim textSize As SizeF = Me.CreateGraphics.MeasureString(Text, Font, Width - 4)
        Dim sf As New StringFormat
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center
        G.DrawString(Text, Font, Brushes.White, New RectangleF(2, 2, Me.Width - 5, Me.Height - 4), sf)
        DrawBorders(Pens.Black)
        DrawBorders(New Pen(Color.FromArgb(80, 80, 80)), 1)
    End Sub

    Sub New()
        IsAnimated = True
    End Sub

End Class

Class GhostProgressbar
    Inherits ThemeControl154
    Private _Maximum As Integer = 100
    Private _Value As Integer
    Private HOffset As Integer = 0
    Private Progress As Integer
    Protected Overrides Sub ColorHook()

    End Sub

    Public Property Maximum As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal V As Integer)
            If V < 1 Then V = 1
            If V < _Value Then _Value = V
            _Maximum = V
            Invalidate()
        End Set
    End Property
    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(ByVal V As Integer)
            If V > _Maximum Then V = Maximum
            _Value = V
            Invalidate()
        End Set
    End Property
    Public Property Animated As Boolean
        Get
            Return IsAnimated
        End Get
        Set(ByVal V As Boolean)
            IsAnimated = V
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnAnimation()
        HOffset -= 1
        If HOffset = 7 Then HOffset = 0
    End Sub

    Protected Overrides Sub PaintHook()
        Dim hatch As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(60, Color.Black))
        G.Clear(Color.FromArgb(0, 30, 30, 30))
        Dim cblend As New ColorBlend(2)
        cblend.Colors(0) = Color.FromArgb(50, 50, 50)
        cblend.Colors(1) = Color.FromArgb(70, 70, 70)
        cblend.Positions(0) = 0
        cblend.Positions(1) = 1
        DrawGradient(cblend, New Rectangle(0, 0, CInt(((Width / _Maximum) * _Value) - 2), Height - 2))
        cblend.Colors(1) = Color.FromArgb(80, 80, 80)
        DrawGradient(cblend, New Rectangle(0, 0, CInt(((Width / _Maximum) * _Value) - 2), Height / 5 * 2))
        G.RenderingOrigin = New Point(HOffset, 0)
        hatch = New HatchBrush(HatchStyle.ForwardDiagonal, Color.FromArgb(40, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(hatch, 0, 0, CInt(((Width / _Maximum) * _Value) - 2), Height - 2)
        DrawBorders(Pens.Black)
        DrawBorders(New Pen(Color.FromArgb(90, 90, 90)), 1)
        DrawCorners(Color.Black)
        G.DrawLine(New Pen(Color.FromArgb(200, 90, 90, 90)), CInt(((Width / _Maximum) * _Value) - 2), 1, CInt(((Width / _Maximum) * _Value) - 2), Height - 2)
        G.DrawLine(Pens.Black, CInt(((Width / _Maximum) * _Value) - 2) + 1, 2, CInt(((Width / _Maximum) * _Value) - 2) + 1, Height - 3)
        Progress = CInt(((Width / _Maximum) * _Value))
        Dim cblend2 As New ColorBlend(3)
        cblend2.Colors(0) = Color.FromArgb(0, Color.Gray)
        cblend2.Colors(1) = Color.FromArgb(80, Color.DimGray)
        cblend2.Colors(2) = Color.FromArgb(0, Color.Gray)
        cblend2.Positions = {0, 0.5, 1}
        If Value > 0 Then G.FillRectangle(New SolidBrush(Color.FromArgb(5, 5, 5)), CInt(((Width / _Maximum) * _Value)) - 1, 2, Width - CInt(((Width / _Maximum) * _Value)) - 1, Height - 4)
    End Sub

    Public Sub New()
        _Maximum = 100
        IsAnimated = True
    End Sub
End Class

<DefaultEvent("CheckedChanged")> _
Class GhostCheckbox
    Inherits ThemeControl154
    Private _Checked As Boolean
    Private X As Integer

    Event CheckedChanged(ByVal sender As Object)

    Public Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal V As Boolean)
            _Checked = V
            Invalidate()
            RaiseEvent CheckedChanged(Me)
        End Set
    End Property

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Dim textSize As Integer
        textSize = Me.CreateGraphics.MeasureString(Text, Font).Width
        Me.Width = 20 + textSize
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.X
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If _Checked = True Then _Checked = False Else _Checked = True
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(60, 60, 60))
        Dim asdf As HatchBrush
        asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(0, 0, Width, Height))
        asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
        G.FillRectangle(asdf, 0, 0, Width, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, Width, Height)

        G.FillRectangle(New SolidBrush(Color.FromArgb(10, 10, 10)), 3, 3, 10, 10)
        If _Checked Then
            Dim cblend As New ColorBlend(2)
            cblend.Colors(0) = Color.FromArgb(60, 60, 60)
            cblend.Colors(1) = Color.FromArgb(80, 80, 80)
            cblend.Positions(0) = 0
            cblend.Positions(1) = 1
            DrawGradient(cblend, New Rectangle(3, 3, 10, 10))
            cblend.Colors(0) = Color.FromArgb(70, 70, 70)
            cblend.Colors(1) = Color.FromArgb(100, 100, 100)
            DrawGradient(cblend, New Rectangle(3, 3, 10, 4))
            Dim hatch As HatchBrush
            hatch = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray))
            G.FillRectangle(hatch, 3, 3, 10, 10)
        Else
            Dim hatch As HatchBrush
            hatch = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray))
            G.FillRectangle(hatch, 3, 3, 10, 10)
        End If

        If State = MouseState.Over And X < 15 Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.Gray)), New Rectangle(3, 3, 10, 10))
        ElseIf State = MouseState.Down Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.Black)), New Rectangle(3, 3, 10, 10))
        End If

        G.DrawRectangle(Pens.Black, 0, 0, 15, 15)
        G.DrawRectangle(New Pen(Color.FromArgb(90, 90, 90)), 1, 1, 13, 13)
        G.DrawString(Text, Font, Brushes.White, 17, 1)
    End Sub

    Public Sub New()
        Me.Size = New Point(16, 50)
    End Sub
End Class

<DefaultEvent("CheckedChanged")> _
Class GhostRadiobutton
    Inherits ThemeControl154
    Private X As Integer
    Private _Checked As Boolean

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)

    Protected Overrides Sub OnCreation()
        InvalidateControls()
    End Sub

    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return

        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is GhostRadiobutton Then
                DirectCast(C, GhostRadiobutton).Checked = False
            End If
        Next
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.X
        Invalidate()
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Dim textSize As Integer
        textSize = Me.CreateGraphics.MeasureString(Text, Font).Width
        Me.Width = 20 + textSize
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(60, 60, 60))
        Dim asdf As HatchBrush
        asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(0, 0, Width, Height))
        asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
        G.FillRectangle(asdf, 0, 0, Width, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, Width, Height)

        G.SmoothingMode = SmoothingMode.AntiAlias
        G.FillEllipse(New SolidBrush(Color.Black), 2, 2, 11, 11)
        G.DrawEllipse(Pens.Black, 0, 0, 13, 13)
        G.DrawEllipse(New Pen(Color.FromArgb(90, 90, 90)), 1, 1, 11, 11)

        If _Checked = False Then
            Dim hatch As HatchBrush
            hatch = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray))
            G.FillEllipse(hatch, 2, 2, 10, 10)
        Else
            G.FillEllipse(New SolidBrush(Color.FromArgb(80, 80, 80)), 3, 3, 7, 7)
            Dim hatch As HatchBrush
            hatch = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray))
            G.FillRectangle(hatch, 3, 3, 7, 7)
        End If

        If State = MouseState.Over And X < 13 Then
            G.FillEllipse(New SolidBrush(Color.FromArgb(20, Color.White)), 2, 2, 11, 11)
        End If

        G.DrawString(Text, Font, Brushes.White, 16, 0)
    End Sub

    Public Sub New()
        Me.Size = New Point(50, 14)
    End Sub
End Class

Class GhostTabControl
    Inherits TabControl
    Private Xstart(9999) As Integer 'Stupid VB.Net bug. Please don't use more than 9999 tabs :3
    Private Xstop(9999) As Integer  'Stupid VB.Net bug. Please don't use more than 9999 tabs :3

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        For Each p As TabPage In TabPages
            p.BackColor = Color.White
            Application.DoEvents()
            p.BackColor = Color.Transparent
        Next
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub

    Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)
        Dim index As Integer = 0
        Dim height As Integer = Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8
        For Each a As Integer In Xstart
            If e.X > a And e.X < Xstop(index) And e.Y < height And e.Button = Windows.Forms.MouseButtons.Left Then
                SelectedIndex = index
                Invalidate()
            Else
            End If
            index += 1
        Next
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.Clear(Color.FromArgb(60, 60, 60))
        Dim asdf As HatchBrush
        asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(0, 0, Width, Height))
        asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
        G.FillRectangle(asdf, 0, 0, Width, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, Width, Height)

        G.FillRectangle(Brushes.Black, 0, 0, Width, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8)
        G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), 2, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 7, Width - 2, Height - 2)

        Dim totallength As Integer = 0
        Dim index As Integer = 0
        For Each tab As TabPage In TabPages
            If SelectedIndex = index Then
                G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), totallength, 1, Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 10)
                asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
                G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), totallength, 1, Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 10)
                asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
                G.FillRectangle(asdf, totallength, 1, Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 10)
                G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), totallength, 1, Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 10)

                Dim gradient As New LinearGradientBrush(New Point(totallength, 1), New Point(totallength, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8), Color.FromArgb(15, Color.White), Color.Transparent)
                G.FillRectangle(gradient, totallength, 1, Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 5)

                G.DrawLine(New Pen(Color.FromArgb(60, 60, 60)), totallength + Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, 2, totallength + Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8)
                G.DrawLine(New Pen(Color.FromArgb(60, 60, 60)), totallength, 2, totallength, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8)

                G.DrawLine(New Pen(Color.FromArgb(60, 60, 60)), totallength + Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8, Width - 1, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8)
                G.DrawLine(New Pen(Color.FromArgb(60, 60, 60)), 1, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8, totallength, Me.CreateGraphics.MeasureString("Mava is awesome", Font).Height + 8)

            End If
            Xstart(index) = totallength
            Xstop(index) = totallength + Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15
            G.DrawString(tab.Text, Font, Brushes.White, totallength + 8, 5)
            totallength += Me.CreateGraphics.MeasureString(tab.Text, Font).Width + 15
            index += 1
        Next

        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), 1, 1, Width - 2, 1) 'boven
        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), 1, Height - 2, Width - 2, Height - 2) 'onder
        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), 1, 1, 1, Height - 2) 'links
        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), Width - 2, 1, Width - 2, Height - 2) 'rechts

        G.DrawLine(Pens.Black, 0, 0, Width - 1, 0) 'boven
        G.DrawLine(Pens.Black, 0, Height - 1, Width, Height - 1) 'onder
        G.DrawLine(Pens.Black, 0, 0, 0, Height - 1) 'links
        G.DrawLine(Pens.Black, Width - 1, 0, Width - 1, Height - 1) 'rechts

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As System.EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        Invalidate()
    End Sub
End Class

Class GhostTabControlLagFree
    Inherits TabControl
    Private _Forecolor As Color = Color.White
    Public Property ForeColor As Color
        Get
            Return _Forecolor
        End Get
        Set(ByVal value As Color)
            _Forecolor = value
        End Set
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        For Each p As TabPage In TabPages
            Try
                p.BackColor = Color.Black
                p.BackColor = Color.Transparent
            Catch ex As Exception
            End Try
        Next
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
        For Each p As TabPage In TabPages
            Try
                p.BackColor = Color.Black
                p.BackColor = Color.Transparent
            Catch ex As Exception
            End Try
        Next
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        G.Clear(Color.FromArgb(60, 60, 60))

        Dim asdf As HatchBrush
        asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(0, 0, Width, Height))
        asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
        G.FillRectangle(asdf, 0, 0, Width, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, Width, Height)

        G.FillRectangle(Brushes.Black, New Rectangle(New Point(0, 4), New Size(Width - 2, 20)))

        G.DrawRectangle(Pens.Black, New Rectangle(New Point(0, 3), New Size(Width - 1, Height - 4)))
        G.DrawRectangle(New Pen(Color.FromArgb(90, 90, 90)), New Rectangle(New Point(1, 4), New Size(Width - 3, Height - 6)))

        For i = 0 To TabCount - 1
            If i = SelectedIndex Then
                Dim x2 As Rectangle = New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 2, GetTabRect(i).Width + 2, GetTabRect(i).Height - 1)

                asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
                G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 3, GetTabRect(i).Width + 1, GetTabRect(i).Height - 2))
                asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
                G.FillRectangle(asdf, New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 3, GetTabRect(i).Width + 1, GetTabRect(i).Height - 2))
                G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 3, GetTabRect(i).Width + 1, GetTabRect(i).Height - 2))

                Dim gradient As New LinearGradientBrush(New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 2, GetTabRect(i).Width + 2, GetTabRect(i).Height - 1), Color.FromArgb(15, Color.White), Color.Transparent, 90.0F)
                G.FillRectangle(gradient, New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 2, GetTabRect(i).Width + 2, GetTabRect(i).Height - 1))
                G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), New Point(GetTabRect(i).Right, 4), New Point(GetTabRect(i).Right, GetTabRect(i).Height + 3))
                If Not SelectedIndex = 0 Then
                    G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), New Point(GetTabRect(i).X, 4), New Point(GetTabRect(i).X, GetTabRect(i).Height + 3))
                    G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), New Point(1, GetTabRect(i).Height + 3), New Point(GetTabRect(i).X, GetTabRect(i).Height + 3))
                End If
                G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), New Point(GetTabRect(i).Right, GetTabRect(i).Height + 3), New Point(Width - 2, GetTabRect(i).Height + 3))
                G.DrawString(TabPages(i).Text, Font, New SolidBrush(_Forecolor), x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
            Else
                Dim x2 As Rectangle = New Rectangle(GetTabRect(i).X, GetTabRect(i).Y + 2, GetTabRect(i).Width + 2, GetTabRect(i).Height - 1)
                G.DrawString(TabPages(i).Text, Font, New SolidBrush(_Forecolor), x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
            End If
        Next

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class

Class GhostListBoxPretty
    Inherits ThemeControl154
    Public WithEvents LBox As New ListBox
    Private __Items As String() = {""}
    Public Property Items As String()
        Get
            Return __Items
            Invalidate()
        End Get
        Set(ByVal value As String())
            __Items = value
            LBox.Items.Clear()
            Invalidate()
            LBox.Items.AddRange(value)
            Invalidate()
        End Set
    End Property

    Public ReadOnly Property SelectedItem() As String
        Get
            Return LBox.SelectedItem
        End Get
    End Property

    Sub New()
        Controls.Add(LBox)
        Size = New Size(131, 101)

        LBox.BackColor = Color.FromArgb(0, 0, 0)
        LBox.BorderStyle = BorderStyle.None
        LBox.DrawMode = Windows.Forms.DrawMode.OwnerDrawVariable
        LBox.Location = New Point(3, 3)
        LBox.ForeColor = Color.White
        LBox.ItemHeight = 20
        LBox.Items.Clear()
        LBox.IntegralHeight = False
        Invalidate()
    End Sub
    Protected Overrides Sub ColorHook()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        LBox.Width = Width - 4
        LBox.Height = Height - 4
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.Black)
        G.DrawRectangle(Pens.Black, 0, 0, Width - 2, Height - 2)
        G.DrawRectangle(New Pen(Color.FromArgb(90, 90, 90)), 1, 1, Width - 3, Height - 3)
        LBox.Size = New Size(Width - 5, Height - 5)
    End Sub
    Sub DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LBox.DrawItem
        If e.Index < 0 Then Exit Sub
        e.DrawBackground()
        e.DrawFocusRectangle()
        If InStr(e.State.ToString, "Selected,") > 0 Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
            Dim x2 As Rectangle = New Rectangle(e.Bounds.Location, New Size(e.Bounds.Width - 1, e.Bounds.Height))
            Dim x3 As Rectangle = New Rectangle(x2.Location, New Size(x2.Width, (x2.Height / 2) - 2))
            Dim G1 As New LinearGradientBrush(New Point(x2.X, x2.Y), New Point(x2.X, x2.Y + x2.Height), Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50))
            Dim H As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(15, Color.Black), Color.Transparent)
            e.Graphics.FillRectangle(G1, x2) : G1.Dispose()
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), x3)
            e.Graphics.FillRectangle(H, x2) : G1.Dispose()
            e.Graphics.DrawString(" " & LBox.Items(e.Index).ToString(), Font, Brushes.White, e.Bounds.X, e.Bounds.Y + 2)
        Else
            e.Graphics.DrawString(" " & LBox.Items(e.Index).ToString(), Font, Brushes.White, e.Bounds.X, e.Bounds.Y + 2)
        End If
    End Sub
    Sub AddRange(ByVal Items As Object())
        LBox.Items.Remove("")
        LBox.Items.AddRange(Items)
        Invalidate()
    End Sub
    Sub AddItem(ByVal Item As Object)
        LBox.Items.Remove("")
        LBox.Items.Add(Item)
        Invalidate()
    End Sub
End Class

Class GhostListboxLessPretty
    Inherits ListBox

    Sub New()
        SetStyle(ControlStyles.DoubleBuffer, True)
        Font = New Font("Microsoft Sans Serif", 9)
        BorderStyle = Windows.Forms.BorderStyle.None
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ItemHeight = 20
        ForeColor = Color.DeepSkyBlue
        BackColor = Color.FromArgb(7, 7, 7)
        IntegralHeight = False
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = 15 Then CustomPaint()
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            If e.Index < 0 Then Exit Sub
            e.DrawBackground()
            Dim rect As New Rectangle(New Point(e.Bounds.Left, e.Bounds.Top + 2), New Size(Bounds.Width, 16))
            e.DrawFocusRectangle()
            If InStr(e.State.ToString, "Selected,") > 0 Then
                e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
                Dim x2 As Rectangle = New Rectangle(e.Bounds.Location, New Size(e.Bounds.Width - 1, e.Bounds.Height))
                Dim x3 As Rectangle = New Rectangle(x2.Location, New Size(x2.Width, (x2.Height / 2)))
                Dim G1 As New LinearGradientBrush(New Point(x2.X, x2.Y), New Point(x2.X, x2.Y + x2.Height), Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50))
                Dim H As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(15, Color.Black), Color.Transparent)
                e.Graphics.FillRectangle(G1, x2) : G1.Dispose()
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), x3)
                e.Graphics.FillRectangle(H, x2) : G1.Dispose()
                e.Graphics.DrawString(" " & Items(e.Index).ToString(), Font, Brushes.White, e.Bounds.X, e.Bounds.Y + 1)
            Else
                e.Graphics.DrawString(" " & Items(e.Index).ToString(), Font, Brushes.White, e.Bounds.X, e.Bounds.Y + 1)
            End If
            e.Graphics.DrawRectangle(New Pen(Color.FromArgb(0, 0, 0)), New Rectangle(1, 1, Width - 3, Height - 3))
            e.Graphics.DrawRectangle(New Pen(Color.FromArgb(90, 90, 90)), New Rectangle(0, 0, Width - 1, Height - 1))
            MyBase.OnDrawItem(e)
        Catch ex As Exception : End Try
    End Sub

    Sub CustomPaint()
        CreateGraphics.DrawRectangle(New Pen(Color.FromArgb(0, 0, 0)), New Rectangle(1, 1, Width - 3, Height - 3))
        CreateGraphics.DrawRectangle(New Pen(Color.FromArgb(90, 90, 90)), New Rectangle(0, 0, Width - 1, Height - 1))
    End Sub
End Class

Class GhostComboBox
    Inherits ComboBox

    Private X As Integer
    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ItemHeight = 20
        BackColor = Color.FromArgb(30, 30, 30)
        DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.X
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        X = -1
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Not DropDownStyle = ComboBoxStyle.DropDownList Then DropDownStyle = ComboBoxStyle.DropDownList
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        G.Clear(Color.FromArgb(50, 50, 50))
        Dim GradientBrush As LinearGradientBrush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height / 5 * 2), Color.FromArgb(20, 0, 0, 0), Color.FromArgb(15, Color.White), 90.0F)
        G.FillRectangle(GradientBrush, New Rectangle(0, 0, Width, Height / 5 * 2))
        Dim hatch As HatchBrush
        hatch = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(hatch, 0, 0, Width, Height)

        Dim S1 As Integer = G.MeasureString("...", Font).Height
        If SelectedIndex <> -1 Then
            G.DrawString(Items(SelectedIndex), Font, New SolidBrush(Color.White), 4, Height \ 2 - S1 \ 2)
        Else
            If Not Items Is Nothing And Items.Count > 0 Then
                G.DrawString(Items(0), Font, New SolidBrush(Color.White), 4, Height \ 2 - S1 \ 2)
            Else
                G.DrawString("...", Font, New SolidBrush(Color.White), 4, Height \ 2 - S1 \ 2)
            End If
        End If

        If MouseButtons = Windows.Forms.MouseButtons.None And X > Width - 25 Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(7, Color.White)), Width - 25, 1, Width - 25, Height - 3)
        ElseIf MouseButtons = Windows.Forms.MouseButtons.None And X < Width - 25 And X >= 0 Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(7, Color.White)), 2, 1, Width - 27, Height - 3)
        End If

        G.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1)
        G.DrawRectangle(New Pen(Color.FromArgb(90, 90, 90)), 1, 1, Width - 3, Height - 3)
        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), Width - 25, 1, Width - 25, Height - 3)
        G.DrawLine(Pens.Black, Width - 24, 0, Width - 24, Height)
        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), Width - 23, 1, Width - 23, Height - 3)

        G.FillPolygon(Brushes.Black, Triangle(New Point(Width - 14, Height \ 2), New Size(5, 3)))
        G.FillPolygon(Brushes.White, Triangle(New Point(Width - 15, Height \ 2 - 1), New Size(5, 3)))

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
        If e.Index < 0 Then Exit Sub
        Dim rect As New Rectangle()
        rect.X = e.Bounds.X
        rect.Y = e.Bounds.Y
        rect.Width = e.Bounds.Width - 1
        rect.Height = e.Bounds.Height - 1

        e.DrawBackground()
        If e.State = 785 Or e.State = 17 Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
            Dim x2 As Rectangle = New Rectangle(e.Bounds.Location, New Size(e.Bounds.Width - 1, e.Bounds.Height))
            Dim x3 As Rectangle = New Rectangle(x2.Location, New Size(x2.Width, (x2.Height / 2) - 1))
            Dim G1 As New LinearGradientBrush(New Point(x2.X, x2.Y), New Point(x2.X, x2.Y + x2.Height), Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50))
            Dim H As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(15, Color.Black), Color.Transparent)
            e.Graphics.FillRectangle(G1, x2) : G1.Dispose()
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), x3)
            e.Graphics.FillRectangle(H, x2) : G1.Dispose()
            e.Graphics.DrawString(" " & Items(e.Index).ToString(), Font, Brushes.White, e.Bounds.X, e.Bounds.Y + 2)
        Else
            e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
            e.Graphics.DrawString(" " & Items(e.Index).ToString(), Font, Brushes.White, e.Bounds.X, e.Bounds.Y + 2)
        End If
        MyBase.OnDrawItem(e)
    End Sub

    Public Function Triangle(ByVal Location As Point, ByVal Size As Size) As Point()
        Dim ReturnPoints(0 To 3) As Point
        ReturnPoints(0) = Location
        ReturnPoints(1) = New Point(Location.X + Size.Width, Location.Y)
        ReturnPoints(2) = New Point(Location.X + Size.Width \ 2, Location.Y + Size.Height)
        ReturnPoints(3) = Location

        Return ReturnPoints
    End Function

    Private Sub GhostComboBox_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DropDownClosed
        DropDownStyle = ComboBoxStyle.Simple
        Application.DoEvents()
        DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub GhostCombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Invalidate()
    End Sub
End Class

<Designer("System.Windows.Forms.Design.ParentControlDesigner,System.Design", GetType(IDesigner))> _
Class GhostGroupBox
    Inherits ThemeControl154

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.ContainerControl, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(60, 60, 60))
        Dim asdf As HatchBrush
        asdf = New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray))
        G.FillRectangle(New SolidBrush(Color.FromArgb(60, 60, 60)), New Rectangle(0, 0, Width, Height))
        asdf = New HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray)
        G.FillRectangle(asdf, 0, 0, Width, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, Width, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(70, Color.Black)), 1, 1, Width - 2, Me.CreateGraphics.MeasureString(Text, Font).Height + 8)

        G.DrawLine(New Pen(Color.FromArgb(90, 90, 90)), 1, Me.CreateGraphics.MeasureString(Text, Font).Height + 8, Width - 2, Me.CreateGraphics.MeasureString(Text, Font).Height + 8)

        DrawBorders(Pens.Black)
        DrawBorders(New Pen(Color.FromArgb(90, 90, 90)), 1)
        G.DrawString(Text, Font, Brushes.White, 5, 5)
    End Sub
End Class

<DefaultEvent("TextChanged")> _
Class GhostTextBox
    Inherits ThemeControl154

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If Base IsNot Nothing Then
                Base.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If Base IsNot Nothing Then
                Base.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If Base IsNot Nothing Then
                Base.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If Base IsNot Nothing Then
                Base.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If Base IsNot Nothing Then
                Base.Multiline = value

                If value Then
                    LockHeight = 0
                    Base.Height = Height - 11
                Else
                    LockHeight = Base.Height + 11
                End If
            End If
        End Set
    End Property
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If Base IsNot Nothing Then
                Base.Text = value
            End If
        End Set
    End Property
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If Base IsNot Nothing Then
                Base.Font = value
                Base.Location = New Point(3, 5)
                Base.Width = Width - 6

                If Not _Multiline Then
                    LockHeight = Base.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreation()
        If Not Controls.Contains(Base) Then
            Controls.Add(Base)
        End If
    End Sub

    Private Base As TextBox
    Sub New()
        Base = New TextBox

        Base.Font = Font
        Base.Text = Text
        Base.MaxLength = _MaxLength
        Base.Multiline = _Multiline
        Base.ReadOnly = _ReadOnly
        Base.UseSystemPasswordChar = _UseSystemPasswordChar

        Base.BorderStyle = BorderStyle.None

        Base.Location = New Point(5, 5)
        Base.Width = Width - 10

        If _Multiline Then
            Base.Height = Height - 11
        Else
            LockHeight = Base.Height + 11
        End If

        AddHandler Base.TextChanged, AddressOf OnBaseTextChanged
        AddHandler Base.KeyDown, AddressOf OnBaseKeyDown


        SetColor("Text", Color.White)
        SetColor("Back", 0, 0, 0)
        SetColor("Border1", Color.Black)
        SetColor("Border2", 90, 90, 90)
    End Sub

    Private C1 As Color
    Private P1, P2 As Pen

    Protected Overrides Sub ColorHook()
        C1 = GetColor("Back")

        P1 = GetPen("Border1")
        P2 = GetPen("Border2")

        Base.ForeColor = GetColor("Text")
        Base.BackColor = C1
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(C1)

        DrawBorders(P1, 1)
        DrawBorders(P2)
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = Base.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            Base.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        Base.Location = New Point(5, 5)
        Base.Width = Width - 10

        If _Multiline Then
            Base.Height = Height - 11
        End If


        MyBase.OnResize(e)
    End Sub

End Class

Class GhostControlBox
    Inherits ThemeControl154
    Private X As Integer
    Dim BG, Edge As Color
    Dim BEdge As Pen
    Protected Overrides Sub ColorHook()
        BG = GetColor("Background")
        Edge = GetColor("Edge color")
        BEdge = New Pen(GetColor("Button edge color"))
    End Sub

    Sub New()
        SetColor("Background", Color.FromArgb(64, 64, 64))
        SetColor("Edge color", Color.Black)
        SetColor("Button edge color", Color.FromArgb(90, 90, 90))
        Me.Size = New Size(71, 19)
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.X
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        MyBase.OnClick(e)
        If X <= 22 Then
            FindForm.WindowState = FormWindowState.Minimized
        ElseIf X > 22 And X <= 44 Then
            If FindForm.WindowState <> FormWindowState.Maximized Then FindForm.WindowState = FormWindowState.Maximized Else FindForm.WindowState = FormWindowState.Normal
        ElseIf X > 44 Then
            FindForm.Close()
        End If
    End Sub

    Protected Overrides Sub PaintHook()
        'Draw outer edge
        G.Clear(Edge)

        'Fill buttons
        Dim SB As New LinearGradientBrush(New Rectangle(New Point(1, 1), New Size(Width - 2, Height - 2)), BG, Color.FromArgb(30, 30, 30), 90.0F)
        G.FillRectangle(SB, New Rectangle(New Point(1, 1), New Size(Width - 2, Height - 2)))

        'Draw icons
        G.DrawString("0", New Font("Marlett", 8.25), Brushes.White, New Point(5, 5))
        If FindForm.WindowState <> FormWindowState.Maximized Then G.DrawString("1", New Font("Marlett", 8.25), Brushes.White, New Point(27, 4)) Else G.DrawString("2", New Font("Marlett", 8.25), Brushes.White, New Point(27, 4))
        G.DrawString("r", New Font("Marlett", 10), Brushes.White, New Point(49, 3))

        'Glassy effect
        Dim CBlend As New ColorBlend(2)
        CBlend.Colors = {Color.FromArgb(100, Color.Black), Color.Transparent}
        CBlend.Positions = {0, 1}
        DrawGradient(CBlend, New Rectangle(New Point(1, 8), New Size(68, 8)), 90.0F)

        'Draw button outlines
        G.DrawRectangle(BEdge, New Rectangle(New Point(1, 1), New Size(20, 16)))
        G.DrawRectangle(BEdge, New Rectangle(New Point(23, 1), New Size(20, 16)))
        G.DrawRectangle(BEdge, New Rectangle(New Point(45, 1), New Size(24, 16)))

        'Mouse states
        Select Case State
            Case MouseState.Over
                If X <= 22 Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(New Point(1, 1), New Size(21, Height - 2)))
                ElseIf X > 22 And X <= 44 Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(New Point(23, 1), New Size(21, Height - 2)))
                ElseIf X > 44 Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(New Point(45, 1), New Size(25, Height - 2)))
                End If
            Case MouseState.Down
                If X <= 22 Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), New Rectangle(New Point(1, 1), New Size(21, Height - 2)))
                ElseIf X > 22 And X <= 44 Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), New Rectangle(New Point(23, 1), New Size(21, Height - 2)))
                ElseIf X > 44 Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), New Rectangle(New Point(45, 1), New Size(25, Height - 2)))
                End If
        End Select
    End Sub
End Class

Class FlatAlertBox : Inherits Control

    ''' <summary>
    ''' How to use: FlatAlertBox.ShowControl(Kind, String, Interval)
    ''' </summary>
    ''' <remarks></remarks>

#Region " Variables"

    Private W, H As Integer
    Private K As _Kind
    Private _Text As String
    Private State As MouseState = MouseState.None
    Private X As Integer
    Private WithEvents T As Timer

#End Region

#Region " Properties"

    <Flags()> _
    Enum _Kind
        [Success]
        [Error]
        [Info]
    End Enum

#Region " Options"

    <Category("Options")> _
    Public Property kind As _Kind
        Get
            Return K
        End Get
        Set(ByVal value As _Kind)
            K = value
        End Set
    End Property

    <Category("Options")> _
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If _Text IsNot Nothing Then
                _Text = value
            End If
        End Set
    End Property

    <Category("Options")> _
    Shadows Property Visible As Boolean
        Get
            Return MyBase.Visible = False
        End Get
        Set(ByVal value As Boolean)
            MyBase.Visible = value
        End Set
    End Property

#End Region

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        Height = 42
    End Sub

    Public Sub ShowControl(ByVal Kind As _Kind, ByVal Str As String, ByVal Interval As Integer)
        K = Kind
        Text = Str
        Me.Visible = True
        T = New Timer
        T.Interval = Interval
        T.Enabled = True
    End Sub

    Private Sub T_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles T.Tick
        Me.Visible = False
        T.Enabled = False
        T.Dispose()
    End Sub

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.X : Invalidate()
    End Sub

    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        MyBase.OnClick(e)
        Me.Visible = False
    End Sub

#End Region

#End Region

#Region " Colors"

    Private SuccessColor As Color = Color.FromArgb(60, 85, 79)
    Private SuccessText As Color = Color.FromArgb(35, 169, 110)
    Private ErrorColor As Color = Color.FromArgb(87, 71, 71)
    Private ErrorText As Color = Color.FromArgb(254, 142, 122)
    Private InfoColor As Color = Color.FromArgb(70, 91, 94)
    Private InfoText As Color = Color.FromArgb(97, 185, 186)

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        BackColor = Color.FromArgb(60, 70, 73)
        Size = New Size(576, 42)
        Location = New Point(10, 61)
        Font = New Font("Segoe UI", 10)
        Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)
        W = Width - 1 : H = Height - 1

        Dim Base As New Rectangle(0, 0, W, H)

        With G
            .SmoothingMode = 2
            .TextRenderingHint = 5
            .Clear(BackColor)

            Select Case K
                Case _Kind.Success
                    '-- Base
                    .FillRectangle(New SolidBrush(SuccessColor), Base)

                    '-- Ellipse
                    .FillEllipse(New SolidBrush(SuccessText), New Rectangle(8, 9, 24, 24))
                    .FillEllipse(New SolidBrush(SuccessColor), New Rectangle(10, 11, 20, 20))

                    '-- Checked Sign
                    .DrawString("ü", New Font("Wingdings", 22), New SolidBrush(SuccessText), New Rectangle(7, 7, W, H), NearSF)
                    .DrawString(Text, Font, New SolidBrush(SuccessText), New Rectangle(48, 12, W, H), NearSF)

                    '-- X button
                    .FillEllipse(New SolidBrush(Color.FromArgb(35, Color.Black)), New Rectangle(W - 30, H - 29, 17, 17))
                    .DrawString("r", New Font("Marlett", 8), New SolidBrush(SuccessColor), New Rectangle(W - 28, 16, W, H), NearSF)

                    Select Case State ' -- Mouse Over
                        Case MouseState.Over
                            .DrawString("r", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(W - 28, 16, W, H), NearSF)
                    End Select

                Case _Kind.Error
                    '-- Base
                    .FillRectangle(New SolidBrush(ErrorColor), Base)

                    '-- Ellipse
                    .FillEllipse(New SolidBrush(ErrorText), New Rectangle(8, 9, 24, 24))
                    .FillEllipse(New SolidBrush(ErrorColor), New Rectangle(10, 11, 20, 20))

                    '-- X Sign
                    .DrawString("r", New Font("Marlett", 16), New SolidBrush(ErrorText), New Rectangle(6, 11, W, H), NearSF)
                    .DrawString(Text, Font, New SolidBrush(ErrorText), New Rectangle(48, 12, W, H), NearSF)

                    '-- X button
                    .FillEllipse(New SolidBrush(Color.FromArgb(35, Color.Black)), New Rectangle(W - 32, H - 29, 17, 17))
                    .DrawString("r", New Font("Marlett", 8), New SolidBrush(ErrorColor), New Rectangle(W - 30, 17, W, H), NearSF)

                    Select Case State
                        Case MouseState.Over ' -- Mouse Over
                            .DrawString("r", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(W - 30, 15, W, H), NearSF)
                    End Select

                Case _Kind.Info
                    '-- Base
                    .FillRectangle(New SolidBrush(InfoColor), Base)

                    '-- Ellipse
                    .FillEllipse(New SolidBrush(InfoText), New Rectangle(8, 9, 24, 24))
                    .FillEllipse(New SolidBrush(InfoColor), New Rectangle(10, 11, 20, 20))

                    '-- Info Sign
                    .DrawString("¡", New Font("Segoe UI", 20, FontStyle.Bold), New SolidBrush(InfoText), New Rectangle(12, -4, W, H), NearSF)
                    .DrawString(Text, Font, New SolidBrush(InfoText), New Rectangle(48, 12, W, H), NearSF)

                    '-- X button
                    .FillEllipse(New SolidBrush(Color.FromArgb(35, Color.Black)), New Rectangle(W - 32, H - 29, 17, 17))
                    .DrawString("r", New Font("Marlett", 8), New SolidBrush(InfoColor), New Rectangle(W - 30, 17, W, H), NearSF)

                    Select Case State
                        Case MouseState.Over ' -- Mouse Over
                            .DrawString("r", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(W - 30, 17, W, H), NearSF)
                    End Select
            End Select

        End With

        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub



End Class

<DefaultEvent("CheckedChanged")> Class FlatToggle : Inherits Control

#Region " Variables"

    Private W, H As Integer
    Private O As _Options
    Private _Checked As Boolean = False
    Private State As MouseState = MouseState.None

#End Region

#Region " Properties"
    Public Event CheckedChanged(ByVal sender As Object)

    <Flags()> _
    Enum _Options
        Style1
        Style2
        Style3
        Style4 '-- TODO: New Style
        Style5 '-- TODO: New Style
    End Enum

#Region " Options"

    <Category("Options")> _
    Public Property Options As _Options
        Get
            Return O
        End Get
        Set(ByVal value As _Options)
            O = value
        End Set
    End Property

    <Category("Options")> _
    Public Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
        End Set
    End Property

#End Region

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        Width = 76
        Height = 33
    End Sub

#Region " Mouse States"

    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        MyBase.OnClick(e)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
    End Sub

#End Region

#End Region

#Region " Colors"

    Private BaseColor As Color = Color.FromArgb(10, 157, 53)
    Private BaseColorRed As Color = Color.FromArgb(220, 85, 96)
    Private BGColor As Color = Color.FromArgb(84, 85, 86)
    Private ToggleColor As Color = Color.FromArgb(45, 47, 49)
    Private TextColor As Color = Color.FromArgb(243, 243, 243)

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Size = New Size(44, Height + 1)
        Cursor = Cursors.Hand
        Font = New Font("Segoe UI", 10)
        Size = New Size(76, 33)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)
        W = Width - 1 : H = Height - 1

        Dim GP, GP2 As New GraphicsPath
        Dim Base As New Rectangle(0, 0, W, H), Toggle As New Rectangle(CInt(W \ 2), 0, 38, H)

        With G
            .SmoothingMode = 2
            .PixelOffsetMode = 2
            .TextRenderingHint = 5
            .Clear(BackColor)

            Select Case O
                Case _Options.Style1   '-- Style 1
                    '-- Base
                    GP = Helpers.RoundRec(Base, 6)
                    GP2 = Helpers.RoundRec(Toggle, 6)
                    .FillPath(New SolidBrush(BGColor), GP)
                    .FillPath(New SolidBrush(ToggleColor), GP2)

                    '-- Text
                    .DrawString("OFF", Font, New SolidBrush(BGColor), New Rectangle(19, 1, W, H), CenterSF)

                    If Checked Then
                        '-- Base
                        GP = Helpers.RoundRec(Base, 6)
                        GP2 = Helpers.RoundRec(New Rectangle(CInt(W \ 2), 0, 38, H), 6)
                        .FillPath(New SolidBrush(ToggleColor), GP)
                        .FillPath(New SolidBrush(BaseColor), GP2)

                        '-- Text
                        .DrawString("ON", Font, New SolidBrush(BaseColor), New Rectangle(8, 7, W, H), NearSF)
                    End If
                Case _Options.Style2   '-- Style 2
                    '-- Base
                    GP = Helpers.RoundRec(Base, 6)
                    Toggle = New Rectangle(4, 4, 36, H - 8)
                    GP2 = Helpers.RoundRec(Toggle, 4)
                    .FillPath(New SolidBrush(BaseColorRed), GP)
                    .FillPath(New SolidBrush(ToggleColor), GP2)

                    '-- Lines
                    .DrawLine(New Pen(BGColor), 18, 20, 18, 12)
                    .DrawLine(New Pen(BGColor), 22, 20, 22, 12)
                    .DrawLine(New Pen(BGColor), 26, 20, 26, 12)

                    '-- Text
                    .DrawString("r", New Font("Marlett", 8), New SolidBrush(TextColor), New Rectangle(19, 2, Width, Height), CenterSF)

                    If Checked Then
                        GP = Helpers.RoundRec(Base, 6)
                        Toggle = New Rectangle(CInt(W \ 2) - 2, 4, 36, H - 8)
                        GP2 = Helpers.RoundRec(Toggle, 4)
                        .FillPath(New SolidBrush(BaseColor), GP)
                        .FillPath(New SolidBrush(ToggleColor), GP2)

                        '-- Lines
                        .DrawLine(New Pen(BGColor), CInt(W \ 2) + 12, 20, CInt(W \ 2) + 12, 12)
                        .DrawLine(New Pen(BGColor), CInt(W \ 2) + 16, 20, CInt(W \ 2) + 16, 12)
                        .DrawLine(New Pen(BGColor), CInt(W \ 2) + 20, 20, CInt(W \ 2) + 20, 12)

                        '-- Text
                        .DrawString("ü", New Font("Wingdings", 14), New SolidBrush(TextColor), New Rectangle(8, 7, Width, Height), NearSF)
                    End If
                Case _Options.Style3   '-- Style 3
                    '-- Base
                    GP = Helpers.RoundRec(Base, 16)
                    Toggle = New Rectangle(W - 28, 4, 22, H - 8)
                    GP2.AddEllipse(Toggle)
                    .FillPath(New SolidBrush(ToggleColor), GP)
                    .FillPath(New SolidBrush(BaseColorRed), GP2)

                    '-- Text
                    .DrawString("OFF", Font, New SolidBrush(BaseColorRed), New Rectangle(-12, 2, W, H), CenterSF)

                    If Checked Then
                        '-- Base
                        GP = Helpers.RoundRec(Base, 16)
                        Toggle = New Rectangle(6, 4, 22, H - 8)
                        GP2.Reset()
                        GP2.AddEllipse(Toggle)
                        .FillPath(New SolidBrush(ToggleColor), GP)
                        .FillPath(New SolidBrush(BaseColor), GP2)

                        '-- Text
                        .DrawString("ON", Font, New SolidBrush(BaseColor), New Rectangle(12, 2, W, H), CenterSF)
                    End If
                Case _Options.Style4
                    '-- TODO: New Styles
                    If Checked Then
                        '--
                    End If
                Case _Options.Style5
                    '-- TODO: New Styles
                    If Checked Then
                        '--
                    End If
            End Select

        End With

        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
End Class

Module Helpers

#Region " Variables"
    Friend G As Graphics, B As Bitmap
    Friend _FlatColor As Color = Color.FromArgb(35, 168, 109)
    Friend NearSF As New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near}
    Friend CenterSF As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
#End Region

#Region " Functions"

    Public Function RoundRec(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim P As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
        P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        Return P
    End Function

    Public Function RoundRect(ByVal x!, ByVal y!, ByVal w!, ByVal h!, Optional ByVal r! = 0.3, Optional ByVal TL As Boolean = True, Optional ByVal TR As Boolean = True, Optional ByVal BR As Boolean = True, Optional ByVal BL As Boolean = True) As GraphicsPath
        Dim d! = Math.Min(w, h) * r, xw = x + w, yh = y + h
        RoundRect = New GraphicsPath

        With RoundRect
            If TL Then .AddArc(x, y, d, d, 180, 90) Else .AddLine(x, y, x, y)
            If TR Then .AddArc(xw - d, y, d, d, 270, 90) Else .AddLine(xw, y, xw, y)
            If BR Then .AddArc(xw - d, yh - d, d, d, 0, 90) Else .AddLine(xw, yh, xw, yh)
            If BL Then .AddArc(x, yh - d, d, d, 90, 90) Else .AddLine(x, yh, x, yh)

            .CloseFigure()
        End With
    End Function


    Public Function DrawArrow(ByVal x As Integer, ByVal y As Integer, ByVal flip As Boolean) As GraphicsPath
        Dim GP As New GraphicsPath()

        Dim W As Integer = 12
        Dim H As Integer = 6

        If flip Then
            GP.AddLine(x + 1, y, x + W + 1, y)
            GP.AddLine(x + W, y, x + H, y + H - 1)
        Else
            GP.AddLine(x, y + H, x + W, y + H)
            GP.AddLine(x + W, y + H, x + H, y)
        End If

        GP.CloseFigure()
        Return GP
    End Function

#End Region

End Module

Public Class ReactorTabControl : Inherits TabControl

#Region " Control Help - Properties & Flicker Control "
    Private DrawGradientBrush, DrawGradientBrush2 As LinearGradientBrush
    Private _TabBrColor As Color
    Public Property TabBorderColor() As Color
        Get
            Return _TabBrColor
        End Get
        Set(ByVal v As Color)
            _TabBrColor = v
            Invalidate()
        End Set
    End Property
    Private _ControlBColor As Color
    Public Property TabTextColor() As Color
        Get
            Return _ControlBColor
        End Get
        Set(ByVal v As Color)
            _ControlBColor = v
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
    End Sub
#End Region

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or _
        ControlStyles.ResizeRedraw Or _
        ControlStyles.UserPaint Or _
        ControlStyles.DoubleBuffer, True)

        TabBorderColor = Color.White
        TabTextColor = Color.White

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)

        Dim r2 As New Rectangle(0, 0, Width - 1, 25)
        Dim r3 As New Rectangle(0, 0, Width - 1, 25)
        Dim r4 As New Rectangle(2, 0, Width - 1, 13)
        Dim ItemBounds As Rectangle
        Dim TextBrush As New SolidBrush(Color.Empty)
        Dim TabBrush As New SolidBrush(Color.DimGray)
        Dim dgb2 As New LinearGradientBrush(r4, Color.FromArgb(50, Color.White), Color.FromArgb(25, Color.White), 90S)

        G.Clear(Color.FromArgb(32, 32, 32))
        DrawGradientBrush2 = New LinearGradientBrush(r3, Color.FromArgb(10, 10, 10), Color.FromArgb(50, 50, 50), 90S)
        G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(28, 28, 28))), New Rectangle(1, 1, Width - 3, Height - 3))

        G.FillRectangle(DrawGradientBrush2, r2)
        G.FillRectangle(dgb2, r4)

        For TabItemIndex As Integer = 0 To Me.TabCount - 1
            ItemBounds = Me.GetTabRect(TabItemIndex)

            If CBool(TabItemIndex And 1) Then
                TabBrush.Color = Color.Transparent
            Else
                TabBrush.Color = Color.Transparent
            End If
            G.FillRectangle(TabBrush, ItemBounds)
            Dim BorderPen As Pen
            If TabItemIndex = SelectedIndex Then
                BorderPen = New Pen(Color.Transparent, 1)
                Dim dgb As New LinearGradientBrush(New Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height - 6), Color.FromArgb(205, 150, 0), Color.FromArgb(205, 100, 0), 90S)
                Dim gloss As New LinearGradientBrush(New Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height / 2 - 5), Color.FromArgb(80, Color.White), Color.FromArgb(20, Color.White), 90S)
                G.FillRectangle(dgb, New Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height - 6))
                G.FillRectangle(gloss, New Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height / 2 - 4))
                G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(10, 10, 10))), New Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height - 6))
                G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(100, 230, 90, 0))), New Rectangle(ItemBounds.Location.X + 4, ItemBounds.Location.Y + 4, ItemBounds.Width - 10, ItemBounds.Height - 8))
                Dim r1 As New Rectangle(1, 1, Width - 1, 3)
            Else
                BorderPen = New Pen(Color.Transparent, 1)
            End If

            G.DrawRectangle(BorderPen, New Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 1, ItemBounds.Width - 8, ItemBounds.Height - 4))

            BorderPen.Dispose()

            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center

            If Me.SelectedIndex = TabItemIndex Then
                TextBrush.Color = TabTextColor
            Else
                TextBrush.Color = Color.DimGray
            End If
            G.DrawString( _
            Me.TabPages(TabItemIndex).Text, _
            Me.Font, TextBrush, _
            RectangleF.op_Implicit(Me.GetTabRect(TabItemIndex)), sf)
            Try
                Me.TabPages(TabItemIndex).BackColor = Color.FromArgb(60, 60, 60)
            Catch
            End Try
        Next
        Try
            For Each tabpg As TabPage In Me.TabPages
                tabpg.BorderStyle = BorderStyle.None
            Next
        Catch
        End Try

        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(10, 10, 10))), 2, 24, Width - 2, 24)
        G.DrawRectangle((New Pen(New SolidBrush(Color.Black))), New Rectangle(1, 1, Width - 3, Height - 3))
        G.DrawRectangle((New Pen(New SolidBrush(Color.FromArgb(70, 70, 70)))), New Rectangle(0, 0, Width - 1, Height - 1))
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, Width, 0)
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, Height)
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(45, 45, 45))), Width - 1, 0, Width - 1, Height)
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, Width - 3, 2)
    End Sub
End Class

Class XSeperator
    Inherits Control

    Sub New()
        SetStyle(DirectCast(139286, ControlStyles), True)
        SetStyle(ControlStyles.Selectable, False)

        Height = 6

        P1 = New Pen(Color.FromArgb(205, 150, 0))
        P2 = New Pen(Color.FromArgb(134, 134, 110))
    End Sub

    Private P1, P2 As Pen

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        G = e.Graphics
        G.Clear(BackColor)

        G.DrawLine(P1, 0, 3, Width, 3)
        G.DrawLine(P2, 0, 4, Width, 4)
    End Sub

End Class

#Region "ControlBox"
Class SLCClose
    Inherits ThemeControl154
    Dim LB As New Label
    Protected Overrides Sub ColorHook()

    End Sub

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Size = New Size(20, 20)


    End Sub

    Protected Overrides Sub PaintHook()
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Color.FromArgb(33, 40, 46))
        G.FillRectangle(New SolidBrush(Color.Transparent), New Rectangle(-1, -1, Width + 1, Height + 1))



        Select Case State
            Case MouseState.None


                '// circle

                G.SmoothingMode = SmoothingMode.HighQuality

                Dim GPF As New GraphicsPath
                GPF.AddEllipse(New Rectangle(Width - 20, Height - 19, 15, 15))
                Dim PB3 As PathGradientBrush
                PB3 = New PathGradientBrush(GPF)
                PB3.CenterPoint = New Point(Height - 18.5, Height - 20)
                PB3.CenterColor = Color.FromArgb(70, 70, 70)
                PB3.SurroundColors = {Color.FromArgb(130, 130, 130)}
                PB3.FocusScales = New PointF(0.6F, 0.6F)


                G.FillPath(PB3, GPF)

                G.DrawPath(New Pen(Color.FromArgb(50, 50, 50)), GPF)
                G.SetClip(GPF)
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Gainsboro)), New Rectangle(Width - 20, Height - 18, 6, 6))
                G.ResetClip()
            Case MouseState.Down
                '// circle

                G.SmoothingMode = SmoothingMode.HighQuality

                Dim GPF As New GraphicsPath
                GPF.AddEllipse(New Rectangle(Width - 20, Height - 19, 15, 15))
                Dim PB3 As PathGradientBrush
                PB3 = New PathGradientBrush(GPF)
                PB3.CenterPoint = New Point(Height - 18.5, Height - 20)
                PB3.CenterColor = Color.FromArgb(221, 32, 32)
                PB3.SurroundColors = {Color.FromArgb(229, 110, 110)}
                PB3.FocusScales = New PointF(0.6F, 0.6F)


                G.FillPath(PB3, GPF)

                G.DrawPath(New Pen(Color.FromArgb(180, 130, 0)), GPF)
                G.SetClip(GPF)
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Gainsboro)), New Rectangle(Width - 20, Height - 18, 6, 6))
                G.ResetClip()
            Case MouseState.Over
                '// circle

                G.SmoothingMode = SmoothingMode.HighQuality

                Dim GPF As New GraphicsPath
                GPF.AddEllipse(New Rectangle(Width - 20, Height - 19, 15, 15))
                Dim PB3 As PathGradientBrush
                PB3 = New PathGradientBrush(GPF)
                PB3.CenterPoint = New Point(Height - 18.5, Height - 20)
                PB3.CenterColor = Color.FromArgb(225, 53, 53)
                PB3.SurroundColors = {Color.FromArgb(229, 110, 110)}
                PB3.FocusScales = New PointF(0.6F, 0.6F)


                G.FillPath(PB3, GPF)

                G.DrawPath(New Pen(Color.FromArgb(159, 41, 41)), GPF)
                G.SetClip(GPF)
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Gainsboro)), New Rectangle(Width - 20, Height - 18, 6, 6))
                G.ResetClip()
        End Select

    End Sub
End Class

Class SLCMin
    Inherits ThemeControl154
    Dim LB As New Label
    Protected Overrides Sub ColorHook()

    End Sub

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Size = New Size(20, 20)


    End Sub

    Protected Overrides Sub PaintHook()
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Color.FromArgb(33, 40, 46))
        G.FillRectangle(New SolidBrush(Color.Transparent), New Rectangle(-1, -1, Width + 1, Height + 1))



        Select Case State
            Case MouseState.None


                '// circle

                G.SmoothingMode = SmoothingMode.HighQuality

                Dim GPF As New GraphicsPath
                GPF.AddEllipse(New Rectangle(Width - 20, Height - 19, 15, 15))
                Dim PB3 As PathGradientBrush
                PB3 = New PathGradientBrush(GPF)
                PB3.CenterPoint = New Point(Height - 18.5, Height - 20)
                PB3.CenterColor = Color.FromArgb(70, 70, 70)
                PB3.SurroundColors = {Color.FromArgb(130, 130, 130)}
                PB3.FocusScales = New PointF(0.6F, 0.6F)


                G.FillPath(PB3, GPF)

                G.DrawPath(New Pen(Color.FromArgb(50, 50, 50)), GPF)
                G.SetClip(GPF)
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Gainsboro)), New Rectangle(Width - 20, Height - 18, 6, 6))
                G.ResetClip()
            Case MouseState.Down
                '// circle

                G.SmoothingMode = SmoothingMode.HighQuality

                Dim GPF As New GraphicsPath
                GPF.AddEllipse(New Rectangle(Width - 20, Height - 19, 15, 15))
                Dim PB3 As PathGradientBrush
                PB3 = New PathGradientBrush(GPF)
                PB3.CenterPoint = New Point(Height - 18.5, Height - 20)
                PB3.CenterColor = Color.FromArgb(13, 155, 33)
                PB3.SurroundColors = {Color.FromArgb(12, 143, 18)}
                PB3.FocusScales = New PointF(0.6F, 0.6F)


                G.FillPath(PB3, GPF)

                G.DrawPath(New Pen(Color.FromArgb(180, 130, 0)), GPF)
                G.SetClip(GPF)
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Gainsboro)), New Rectangle(Width - 20, Height - 18, 6, 6))
                G.ResetClip()
            Case MouseState.Over
                '// circle

                G.SmoothingMode = SmoothingMode.HighQuality

                Dim GPF As New GraphicsPath
                GPF.AddEllipse(New Rectangle(Width - 20, Height - 19, 15, 15))
                Dim PB3 As PathGradientBrush
                PB3 = New PathGradientBrush(GPF)
                PB3.CenterPoint = New Point(Height - 18.5, Height - 20)
                PB3.CenterColor = Color.FromArgb(13, 155, 33)
                PB3.SurroundColors = {Color.FromArgb(61, 239, 69)}
                PB3.FocusScales = New PointF(0.6F, 0.6F)


                G.FillPath(PB3, GPF)

                G.DrawPath(New Pen(Color.FromArgb(11, 128, 17)), GPF)
                G.SetClip(GPF)
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Gainsboro)), New Rectangle(Width - 20, Height - 18, 6, 6))
                G.ResetClip()
        End Select

    End Sub
End Class
#End Region

Public Class OrangeTabControl
    Inherits TabControl

#Region "Declarations"

    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BackTabColour As Color = Color.FromArgb(54, 54, 54)
    Private _BaseColour As Color = Color.FromArgb(35, 35, 35)
    Private _ActiveColour As Color = Color.FromArgb(47, 47, 47)
    Private _BorderColour As Color = Color.FromArgb(30, 30, 30)
    Private _UpLineColour As Color = Color.FromArgb(255, 150, 0)
    Private _HorizLineColour As Color = Color.FromArgb(23, 119, 151)
    Private CenterSF As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

#End Region

#Region "Properties"

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(ByVal value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property UpLineColour As Color
        Get
            Return _UpLineColour
        End Get
        Set(ByVal value As Color)
            _UpLineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property HorizontalLineColour As Color
        Get
            Return _HorizLineColour
        End Get
        Set(ByVal value As Color)
            _HorizLineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(ByVal value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BackTabColour As Color
        Get
            Return _BackTabColour
        End Get
        Set(ByVal value As Color)
            _BackTabColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(ByVal value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ActiveColour As Color
        Get
            Return _ActiveColour
        End Get
        Set(ByVal value As Color)
            _ActiveColour = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
        SizeMode = TabSizeMode.Normal
        ItemSize = New Size(240, 32)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(_BaseColour)
            Try : SelectedTab.BackColor = _BackTabColour : Catch : End Try
            Try : SelectedTab.BorderStyle = BorderStyle.FixedSingle : Catch : End Try
            .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
            For i = 0 To TabCount - 1
                Dim Base As New Rectangle(New Point(GetTabRect(i).Location.X, GetTabRect(i).Location.Y), New Size(GetTabRect(i).Width, GetTabRect(i).Height))
                Dim BaseSize As New Rectangle(Base.Location, New Size(Base.Width, Base.Height))
                If i = SelectedIndex Then
                    .FillRectangle(New SolidBrush(_BaseColour), BaseSize)
                    .FillRectangle(New SolidBrush(_ActiveColour), New Rectangle(Base.X + 1, Base.Y - 3, Base.Width, Base.Height + 5))
                    .DrawString(TabPages(i).Text, Font, New SolidBrush(_TextColour), New Rectangle(Base.X + 7, Base.Y, Base.Width - 3, Base.Height), CenterSF)
                    .DrawLine(New Pen(_UpLineColour, 2), New Point(Base.X + 3, Base.Y - 3), New Point(Base.X + 3, Base.Height + 5))
                Else
                    .DrawString(TabPages(i).Text, Font, New SolidBrush(_TextColour), BaseSize, CenterSF)
                End If
            Next
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class OrangeGroupBox
    Inherits ContainerControl

#Region "Declarations"
    Private _MainColour As Color = Color.FromArgb(50, 50, 50)
    Private _HeaderColour As Color = Color.FromArgb(40, 40, 40)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)

    Private _OrangeColour As Color = Color.FromArgb(230, 130, 0)
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(ByVal value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(ByVal value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HeaderColour As Color
        Get
            Return _HeaderColour
        End Get
        Set(ByVal value As Color)
            _HeaderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property MainColour As Color
        Get
            Return _MainColour
        End Get
        Set(ByVal value As Color)
            _MainColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(160, 110)
        Font = New Font("Segoe UI", 11, FontStyle.Regular)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim Circle As New Rectangle(8, 8, 10, 10)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 28, Width, Height))
            .FillRectangle(New SolidBrush(_HeaderColour), New Rectangle(0, 0, Width, 28))
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Point(5, 5))
            .DrawRectangle(New Pen(_BorderColour), New Rectangle(0, 0, Width, Height))
            .DrawLine(New Pen(_BorderColour), 0, 28, Width, 28)
            .DrawLine(New Pen(_OrangeColour, 3), New Point(0, 27), New Point(.MeasureString(Text, Font).Width + 7, 27))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region
End Class

Public Class OrangeSeperator
    Inherits Control

#Region "Declarations"
    Private _SeperatorColour As Color = Color.FromArgb(134, 136, 138)
    Private _Alignment As Style = Style.Horizontal
    Private _Thickness As Single = 1
#End Region

#Region "Properties"

    Enum Style
        Horizontal
        Verticle
    End Enum

    <Category("Control")>
    Public Property Thickness As Single
        Get
            Return _Thickness
        End Get
        Set(ByVal value As Single)
            _Thickness = value
        End Set
    End Property

    <Category("Control")>
    Public Property Alignment As Style
        Get
            Return _Alignment
        End Get
        Set(ByVal value As Style)
            _Alignment = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SeperatorColour As Color
        Get
            Return _SeperatorColour
        End Get
        Set(ByVal value As Color)
            _SeperatorColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Size = New Size(20, 20)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            Select Case _Alignment
                Case Style.Horizontal
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(0, Height / 2), New Point(Width, Height / 2))
                Case Style.Verticle
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(Width / 2, 0), New Point(Width / 2, Height))
            End Select
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class