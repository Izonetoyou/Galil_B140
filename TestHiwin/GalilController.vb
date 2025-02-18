Imports Galil

Public Class Class_GalilController

    WithEvents dmc As New Galil.Galil ' ประกาศตัวแปรแต่ยังไม่กำหนดค่า

    Friend Function Connect(IP As String) As String
        Try
            dmc.address = IP ' Set the controller's address

            Return dmc.connection ' Return the connection status

        Catch ex As Exception
            Return "Connection Failed: " & ex.Message ' Return the error message
        End Try
    End Function
    Public Sub Setdefault(SPC_A As Integer, ACC_A As Integer, DEC_A As Integer, SM_A As Integer,
                                SPC_B As Integer, ACC_B As Integer, DEC_B As Integer, SM_B As Integer,
                                SPC_C As Integer, ACC_C As Integer, DEC_C As Integer, SM_C As Integer)
        Try

            ' ตั้งค่าความเร็ว (Speed)
            dmc.command("SPA=" & SPC_A)
            dmc.command("SPB=" & SPC_B)
            dmc.command("SPC=" & SPC_C)

            ' ตั้งค่าอัตราเร่ง (Acceleration)
            dmc.command("ACA=" & ACC_A)
            dmc.command("ACB=" & ACC_B)
            dmc.command("ACC=" & ACC_C)

            ' ตั้งค่าอัตราหน่วง (Deceleration)
            dmc.command("DCA=" & DEC_A)
            dmc.command("DCB=" & DEC_B)
            dmc.command("DCC=" & DEC_C)

            ' ตั้งค่าการเคลื่อนที่ให้ Smooth
            dmc.command("SMA=" & SM_A)
            dmc.command("SMB=" & SM_B)
            dmc.command("SMC=" & SM_C)

        Catch ex As Exception
            Debug.Print("Set Default Error: " & ex.Message) ' Return the error message
        End Try
    End Sub

    Public Sub Jog_forward(Servo As String, Speed As String)
        Try
            dmc.command("JG" & Servo & "=" & Speed)  ' ตั้งค่า Jog Speed
            dmc.command("BG" & Servo)           ' เริ่มการเคลื่อนที่
        Catch ex As Exception
            Debug.Print("Jog Forward Error: " & ex.Message)
        End Try
    End Sub

    Public Sub StopJog()
        Try
            dmc.command("AB") ' หยุด Jog ทันที
        Catch ex As Exception
            Debug.Print("Stop Jog Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Jog_reverse(Servo As String, Speed As String)
        Try
            dmc.command("JG" & Servo & "= -" & Speed)  ' ตั้งค่า Jog Speed
            dmc.command("BG" & Servo)           ' เริ่มการเคลื่อนที่
        Catch ex As Exception
            Debug.Print("Jog Forward Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Home(Servo As String)
        Try
            dmc.command("SP" & Servo & "= 1000") 'Set speed Home only
            dmc.command("HM" & Servo) 'Home
            dmc.command("BG" & Servo) ' เริ่มการเคลื่อนที่
            dmc.command("AM" & Servo)
        Catch ex As Exception
            Debug.Print("Home Servo Error: " & ex.Message)
        End Try
    End Sub

    Friend Function GetPositions(Servo As String) As String
        Try
            Dim Position As String = dmc.command("RP" & Servo) 'Repotr Position
            Return Position
        Catch ex As Exception
            Debug.Print("Get Positions Servo Error: " & ex.Message)
            Return ("Get Positions Servo Error: " & ex.Message)
        End Try
    End Function

    Public Sub Enable(Servo As String)
        Try
            dmc.command("SH" & Servo) 'Enable servo
        Catch ex As Exception
            Debug.Print("Enable Servo Error: " & ex.Message)
        End Try

    End Sub
    Public Sub Disable(Servo As String)
        Try
            dmc.command("MO" & Servo) 'Disable servo
        Catch ex As Exception
            Debug.Print("Disable Servo Error: " & ex.Message)
        End Try
    End Sub

    Public Sub GoToPosition(Servo As String, Position As String)
        Try
            dmc.command("PA" & Servo & "=" & Position) 'GoToPosition
            dmc.command("BG" & Servo)
            dmc.command("AM" & Servo)
        Catch ex As Exception
            Debug.Print("GoToPosition Error: " & ex.Message)
        End Try
    End Sub
End Class
