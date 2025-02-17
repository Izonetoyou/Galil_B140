
Public Class Form1
    Dim GalilController As New Class_GalilController
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            ' สร้างอ็อบเจ็กต์ของ Class_Galil


            ' เรียกใช้งานฟังก์ชัน Connect และส่งค่าพารามิเตอร์ให้ครบ
            ToolStripStatusLabel_Galil.Text = GalilController.Connect(txt_GalilIP.Text,
                                                 txt_speedA.Text, txt_AccA.Text, txt_DecA.Text, txt_smoothA.Text,  ' ค่าแกน A
                                                 txt_speedB.Text, txt_AccB.Text, txt_DecB.Text, txt_smoothB.Text,  ' ค่าแกน B
                                                 txt_speedC.Text, txt_AccC.Text, txt_DecC.Text, txt_smoothC.Text)  ' ค่าแกน C
        Catch ex As Exception
            ToolStripStatusLabel_Galil.Text = "Connection Failed: " & ex.Message ' แสดงข้อความข้อผิดพลาด
        End Try
    End Sub


    ' เมื่อกดปุ่ม Mouse (เริ่ม Jog)
    Private Sub bt_Jog_forward_MouseDown(sender As Object, e As MouseEventArgs) Handles bt_A_Jog_forward.MouseDown, bt_B_Jog_forward.MouseDown, bt_C_Jog_forward.MouseDown
        ' อ่านค่า Tag ของปุ่มที่ถูกกด
        Dim axis As String = CType(sender, Button).Tag.ToString()

        ' เรียกใช้ฟังก์ชัน Jog_forward โดยส่งค่าแกนและความเร็ว
        GalilController.Jog_forward(axis, txt_speed_jogA.Text)

    End Sub

    ' เมื่อปล่อยปุ่ม Mouse (หยุด Jog)
    Private Sub bt_Jog_forward_MouseUp(sender As Object, e As MouseEventArgs) Handles bt_A_Jog_forward.MouseUp, bt_B_Jog_forward.MouseUp, bt_C_Jog_forward.MouseUp, bt_A_Jog_reverse.MouseUp, bt_B_Jog_reverse.MouseUp, bt_C_Jog_reverse.MouseUp
        GalilController.StopJog()
    End Sub
    Private Sub bt_Jog_reverse_MouseDown(sender As Object, e As MouseEventArgs) Handles bt_A_Jog_reverse.MouseDown, bt_B_Jog_reverse.MouseDown, bt_C_Jog_reverse.MouseDown
        ' อ่านค่า Tag ของปุ่มที่ถูกกด
        Dim axis As String = CType(sender, Button).Tag.ToString()

        ' เรียกใช้ฟังก์ชัน Jog_forward โดยส่งค่าแกนและความเร็ว
        GalilController.Jog_reverse(axis, txt_speed_jogA.Text)

    End Sub

End Class
