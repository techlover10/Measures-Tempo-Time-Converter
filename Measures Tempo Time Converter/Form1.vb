Option Explicit On
'API Functions

Public Class Form1
    Private Declare Function ReleaseCapture Lib "user32" () As Long
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer) As Long
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Min As Double = ((NumericUpDown1.Value * NumericUpDown3.Value) / NumericUpDown2.Value) * 60
        Dim Measures As Double = (NumericUpDown2.Value * (NumericUpDown1.Value / 60) / NumericUpDown3.Value)
        Dim Tempo As Double = (NumericUpDown2.Value * NumericUpDown3.Value / (NumericUpDown1.Value / 60))

        If RadioButton1.Checked = True Then
            If CheckBox1.Checked = True Then
                Label4.Text = Math.Round(Measures, MidpointRounding.AwayFromZero)
            Else
                Label4.Text = Measures
            End If
        End If

        If RadioButton2.Checked = True Then
            If CheckBox1.Checked = True Then
                Label4.Text = Math.Round(Min, MidpointRounding.AwayFromZero)
            Else
                Label4.Text = Min

            End If
        End If

        If RadioButton3.Checked = True Then
            If CheckBox1.Checked = True Then
                Label4.Text = Math.Round(Tempo, MidpointRounding.AwayFromZero)
            Else
                Label4.Text = Tempo
            End If
        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutMusicMeasurementConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMusicMeasurementConverterToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Number of Measures"
        Label2.Text = "Tempo (BPM)"
        Label3.Text = "Number of Seconds"
        Label4.Text = "---"
        NumericUpDown1.Minimum = 1
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Number of Seconds"
        Label2.Text = "Tempo (BPM)"
        Label3.Text = "Number of Measures"
        Label4.Text = "---"
        NumericUpDown1.Minimum = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "Number of Seconds"
        Label2.Text = "Measures"
        Label3.Text = "Tempo (BPM)"
        Label4.Text = "---"
        NumericUpDown1.Minimum = 1
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Text = "---"
    End Sub
End Class
