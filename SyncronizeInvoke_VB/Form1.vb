Imports System
Imports System.Threading
Imports System.Windows.Forms
Public Class Form1

    Private Sub Test_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Testaction.Click
        Dim timestart As DateTime = DateTime.Now

        Dim thread = New Thread(Sub()
                                    For i = 0 To 10000
                                        Dim _action As Action = Sub()
                                                                    Progress.Value = i / 100
                                                                End Sub

                                        If InvokeRequired Then
                                            Invoke(_action)
                                        Else
                                            _action()
                                        End If
                                    Next

                                    Dim timeaction As Action = Sub()
                                                                   Dim timeend As DateTime = DateTime.Now
                                                                   Dim timediff As Integer = timeend.Second * 1000 + timeend.Millisecond - timestart.Second * 1000 - timestart.Millisecond
                                                                   Timeelapsed.Text = timediff.ToString
                                                               End Sub
                                    If InvokeRequired Then
                                        Invoke(timeaction)
                                    Else
                                        timeaction()
                                    End If
                                End Sub)
        thread.Start()
    End Sub
    Private Delegate Sub ProgressDelegate(ByVal a As Integer)
    Public Sub UpdateProgress(ByVal a As Integer)


        If Me.InvokeRequired Then
            Dim d As New ProgressDelegate(AddressOf Me.UpdateProgress)
            Me.BeginInvoke(d, New Object() {a})


        Else

            Try

                Progress.Value = a

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Testdelegate_Click(sender As Object, e As EventArgs) Handles Testdelegate.Click
        Dim timestart As DateTime = DateTime.Now
        Dim thread = New Thread(Sub()

                                    For i = 0 To 10000
                                        UpdateProgress(i / 100)
                                    Next

                                    Dim timeaction As Action = Sub()
                                                                   Dim timeend As DateTime = DateTime.Now
                                                                   Dim timediff As Integer = timeend.Second * 1000 + timeend.Millisecond - timestart.Second * 1000 - timestart.Millisecond
                                                                   Timeelapsed.Text = timediff.ToString
                                                               End Sub

                                    If InvokeRequired Then
                                        Invoke(timeaction)
                                    Else
                                        timeaction()
                                    End If



                                End Sub)
        thread.Start()
    End Sub
End Class
