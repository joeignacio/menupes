Public Class FrmMenuSistema

    Private Sub FrmMenuSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDoubleBuffered(RibbonControl1)

        fondo_menu()
        cambia_configuracion_regional()

    End Sub

    Sub SetDoubleBuffered(ByVal c As Control)
        If SystemInformation.TerminalServerSession Then Return
        Dim aProp As Reflection.PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        aProp.SetValue(c, True, Nothing)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Sub fondo_menu()
        Try
            Dim ctl As Control

            For Each ctl In Controls
                If TypeOf ctl Is MdiClient Then

                    Dim mdi As MdiClient = CType(ctl, MdiClient)
                    mdi.BackColor = Color.DarkGray

                    BackgroundImageLayout = ImageLayout.Stretch
                    mdi.BackgroundImage = My.Resources.FONDO
                    Dim styles As ControlStyles = ControlStyles.OptimizedDoubleBuffer
                    Dim flags As Reflection.BindingFlags = Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic
                    Dim method As Reflection.MethodInfo = mdi.GetType.GetMethod("SetStyle", flags)

                    Dim param As Object() = {styles, True}
                    method.Invoke(mdi, param)

                    Exit For

                End If

            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub cambia_configuracion_regional()
        Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        'System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd HH:mm:ss"
        Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy HH:mm:ss"
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = " "
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = " "
    End Sub

    Private Sub FrmMenuSistema_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If menuprincipal_login_cerrado = "SI" Then
        If MsgBox("Desea realmente salir del sistema", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Menu Principal") = MsgBoxResult.Yes Then
            For Each ChildForm As Form In MdiChildren
                ChildForm.Close()
                If Application.OpenForms.Count = 0 Then Exit For
            Next
            Dispose()
            Application.Exit()
        Else
            e.Cancel = True
        End If
        'End If
    End Sub

    Private Sub MenuCatalogo_ProductosServicios_Click(sender As Object, e As EventArgs) Handles MenuCatalogo_ProductosServicios.Click
        With FrmProductos
            .MdiParent = Me
            If .IsHandleCreated = True Then
                .BringToFront()
            Else
                .Show()
            End If
        End With
    End Sub

    Private Sub MenuCatalogo_Clientes_Click(sender As Object, e As EventArgs) Handles MenuCatalogo_Clientes.Click
        With FrmClientes
            .MdiParent = Me
            If .IsHandleCreated = True Then
                .BringToFront()
            Else
                .Show()
            End If
        End With
    End Sub

    Private Sub MenuCatalogo_Proveedores_Click(sender As Object, e As EventArgs) Handles MenuCatalogo_Proveedores.Click
        With FrmProveedores
            .MdiParent = Me
            If .IsHandleCreated = True Then
                .BringToFront()
            Else
                .Show()
            End If
        End With
    End Sub

End Class