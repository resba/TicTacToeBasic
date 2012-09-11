Public Class Form2

    Public turn As String = "X"

    Public game As Boolean = False

    Private Sub Form2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        MsgBox("Click!")
    End Sub

    Private Sub C1R1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles C1R1.MouseClick
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C2R1_Click(sender As System.Object, e As System.EventArgs) Handles C2R1.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C3R1_Click(sender As System.Object, e As System.EventArgs) Handles C3R1.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C1R2_Click(sender As System.Object, e As System.EventArgs) Handles C1R2.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C2R2_Click(sender As System.Object, e As System.EventArgs) Handles C2R2.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C3R2_Click(sender As System.Object, e As System.EventArgs) Handles C3R2.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C1R3_Click(sender As System.Object, e As System.EventArgs) Handles C1R3.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C2R3_Click(sender As System.Object, e As System.EventArgs) Handles C2R3.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub C3R3_Click(sender As System.Object, e As System.EventArgs) Handles C3R3.Click
        Me.Text = turn
        Me.Enabled = False
        CheckWin()
        SwitchTurn()
    End Sub

    Private Sub CheckWin()
        If game = False Then
            '' [x] [ ] [ ]
            '' [x] [ ] [ ]
            '' [x] [ ] [ ]

            If C1R1.Enabled = False And C1R2.Enabled = False And C1R3.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If


            '' [ ] [x] [ ]
            '' [ ] [x] [ ]
            '' [ ] [x] [ ]

            If C2R1.Enabled = False And C2R2.Enabled = False And C2R3.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

            '' [ ] [ ] [x]
            '' [ ] [ ] [x]
            '' [ ] [ ] [x]

            If C3R1.Enabled = False And C3R2.Enabled = False And C3R3.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

            '' [x] [x] [x]
            '' [ ] [ ] [ ]
            '' [ ] [ ] [ ]

            If C1R1.Enabled = False And C2R1.Enabled = False And C3R1.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

            '' [ ] [ ] [ ]
            '' [x] [x] [x]
            '' [ ] [ ] [ ]

            If C1R2.Enabled = False And C2R2.Enabled = False And C3R2.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

            '' [ ] [ ] [ ]
            '' [ ] [ ] [ ]
            '' [x] [x] [x]

            If C1R3.Enabled = False And C2R3.Enabled = False And C3R3.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

            '' [x] [ ] [ ]
            '' [ ] [x] [ ]
            '' [ ] [ ] [x]

            If C1R1.Enabled = False And C2R2.Enabled = False And C3R3.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

            '' [ ] [ ] [x]
            '' [ ] [x] [ ]
            '' [x] [ ] [ ]

            If C1R3.Enabled = False And C2R2.Enabled = False And C3R1.Enabled = False Then
                MsgBox(turn + " wins!")
                GameOver()
            End If

        End If

    End Sub

    Private Sub SwitchTurn()

        If turn = "X" Then

            turn = "Y"

        End If

        If turn = "Y" Then

            turn = "X"

        End If

    End Sub

    Private Sub GameOver()

        C1R1.Enabled = False
        C1R2.Enabled = False
        C1R3.Enabled = False
        C2R1.Enabled = False
        C2R2.Enabled = False
        C2R3.Enabled = False
        C3R1.Enabled = False
        C3R2.Enabled = False
        C3R3.Enabled = False

        game = True

    End Sub


    Private Sub NewGame()

        C1R1.Enabled = True
        C1R2.Enabled = True
        C1R3.Enabled = True
        C2R1.Enabled = True
        C2R2.Enabled = True
        C2R3.Enabled = True
        C3R1.Enabled = True
        C3R2.Enabled = True
        C3R3.Enabled = True

        turn = "X"

        game = False

    End Sub


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        turn = "X"
        game = False
    End Sub

End Class