Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim textFont = New Font("Arial", 10)
        '2 OK
        e.Graphics.DrawString(Me.TextBox1.Text, textFont, Brushes.Black, 0, 184)
        e.Graphics.DrawString(Me.TextBox2.Text, textFont, Brushes.Black, 0, 200)
        e.Graphics.DrawString(Me.TextBox3.Text, textFont, Brushes.Black, 0, 216)
        e.Graphics.DrawString(Me.TextBox4.Text, textFont, Brushes.Black, 0, 232)
        e.Graphics.DrawString(Me.TextBox5.Text, textFont, Brushes.Black, 0, 249)

        '16 OK
        e.Graphics.DrawString(Me.TextBox10.Text, textFont, Brushes.Black, 440, 271)
        e.Graphics.DrawString(Me.TextBox6.Text, textFont, Brushes.Black, 600, 271)
        e.Graphics.DrawString(Me.TextBox9.Text, textFont, Brushes.Black, 480, 287)
        e.Graphics.DrawString(Me.TextBox8.Text, textFont, Brushes.Black, 440, 304)
        e.Graphics.DrawString(Me.TextBox7.Text, textFont, Brushes.Black, 440, 320)

        '3 OK
        e.Graphics.DrawString(Me.TextBox13.Text, textFont, Brushes.Black, 80, 284)
        e.Graphics.DrawString(Me.TextBox12.Text, textFont, Brushes.Black, 80, 301)
        e.Graphics.DrawString(Me.TextBox11.Text, textFont, Brushes.Black, 80, 317)

        '17 OK
        e.Graphics.DrawString(Me.TextBox16.Text, textFont, Brushes.Black, 370, 355)
        e.Graphics.DrawString(Me.TextBox15.Text, textFont, Brushes.Black, 370, 371)
        e.Graphics.DrawString(Me.TextBox14.Text, textFont, Brushes.Black, 370, 387)

        '4 OK
        e.Graphics.DrawString(Me.TextBox19.Text, textFont, Brushes.Black, 80, 350)
        e.Graphics.DrawString(Me.TextBox18.Text, textFont, Brushes.Black, 80, 365)
        e.Graphics.DrawString(Me.TextBox17.Text, textFont, Brushes.Black, 80, 382)

        '18 OK
        e.Graphics.DrawString(Me.TextBox22.Text, textFont, Brushes.Black, 370, 421)
        e.Graphics.DrawString(Me.TextBox21.Text, textFont, Brushes.Black, 370, 437)
        e.Graphics.DrawString(Me.TextBox20.Text, textFont, Brushes.Black, 370, 453)

        '5 OK
        e.Graphics.DrawString(Me.TextBox25.Text, textFont, Brushes.Black, 0, 416)
        e.Graphics.DrawString(Me.TextBox24.Text, textFont, Brushes.Black, 0, 433)
        e.Graphics.DrawString(Me.TextBox23.Text, textFont, Brushes.Black, 0, 448)

        '6 OK
        e.Graphics.DrawString(Me.TextBox26.Text, textFont, Brushes.Black, 0, 485)
        e.Graphics.DrawString(Me.TextBox27.Text, textFont, Brushes.Black, 0, 501)
        e.Graphics.DrawString(Me.TextBox28.Text, textFont, Brushes.Black, 0, 517)
        e.Graphics.DrawString(Me.TextBox29.Text, textFont, Brushes.Black, 0, 534)
        e.Graphics.DrawString(Me.TextBox30.Text, textFont, Brushes.Black, 0, 551)
        e.Graphics.DrawString(Me.TextBox31.Text, textFont, Brushes.Black, 0, 567)
        e.Graphics.DrawString(Me.TextBox32.Text, textFont, Brushes.Black, 0, 581)
        e.Graphics.DrawString(Me.TextBox33.Text, textFont, Brushes.Black, 0, 598)
        e.Graphics.DrawString(Me.TextBox34.Text, textFont, Brushes.Black, 0, 614)
        e.Graphics.DrawString(Me.TextBox35.Text, textFont, Brushes.Black, 0, 631)
        e.Graphics.DrawString(Me.TextBox36.Text, textFont, Brushes.Black, 0, 647)
        e.Graphics.DrawString(Me.TextBox37.Text, textFont, Brushes.Black, 0, 664)
        e.Graphics.DrawString(Me.TextBox38.Text, textFont, Brushes.Black, 0, 680)
        e.Graphics.DrawString(Me.TextBox39.Text, textFont, Brushes.Black, 0, 697)
        e.Graphics.DrawString(Me.TextBox40.Text, textFont, Brushes.Black, 0, 713)
        e.Graphics.DrawString(Me.TextBox41.Text, textFont, Brushes.Black, 0, 733)

        '7 OK
        e.Graphics.DrawString(Me.TextBox57.Text, textFont, Brushes.Black, 130, 485)
        e.Graphics.DrawString(Me.TextBox56.Text, textFont, Brushes.Black, 130, 501)
        e.Graphics.DrawString(Me.TextBox55.Text, textFont, Brushes.Black, 130, 517)
        e.Graphics.DrawString(Me.TextBox54.Text, textFont, Brushes.Black, 130, 534)
        e.Graphics.DrawString(Me.TextBox53.Text, textFont, Brushes.Black, 130, 551)
        e.Graphics.DrawString(Me.TextBox52.Text, textFont, Brushes.Black, 130, 567)
        e.Graphics.DrawString(Me.TextBox51.Text, textFont, Brushes.Black, 130, 581)
        e.Graphics.DrawString(Me.TextBox50.Text, textFont, Brushes.Black, 130, 598)
        e.Graphics.DrawString(Me.TextBox49.Text, textFont, Brushes.Black, 130, 614)
        e.Graphics.DrawString(Me.TextBox48.Text, textFont, Brushes.Black, 130, 631)
        e.Graphics.DrawString(Me.TextBox47.Text, textFont, Brushes.Black, 130, 647)
        e.Graphics.DrawString(Me.TextBox46.Text, textFont, Brushes.Black, 130, 664)
        e.Graphics.DrawString(Me.TextBox45.Text, textFont, Brushes.Black, 130, 681)
        e.Graphics.DrawString(Me.TextBox44.Text, textFont, Brushes.Black, 130, 697)
        e.Graphics.DrawString(Me.TextBox43.Text, textFont, Brushes.Black, 130, 713)
        e.Graphics.DrawString(Me.TextBox42.Text, textFont, Brushes.Black, 130, 733)

        '8 OK
        e.Graphics.DrawString(Me.TextBox73.Text, textFont, Brushes.Black, 240, 485)
        e.Graphics.DrawString(Me.TextBox72.Text, textFont, Brushes.Black, 240, 501)
        e.Graphics.DrawString(Me.TextBox71.Text, textFont, Brushes.Black, 240, 517)
        e.Graphics.DrawString(Me.TextBox70.Text, textFont, Brushes.Black, 240, 534)
        e.Graphics.DrawString(Me.TextBox69.Text, textFont, Brushes.Black, 240, 551)
        e.Graphics.DrawString(Me.TextBox68.Text, textFont, Brushes.Black, 240, 567)
        e.Graphics.DrawString(Me.TextBox67.Text, textFont, Brushes.Black, 240, 581)
        e.Graphics.DrawString(Me.TextBox66.Text, textFont, Brushes.Black, 240, 598)
        e.Graphics.DrawString(Me.TextBox65.Text, textFont, Brushes.Black, 240, 614)
        e.Graphics.DrawString(Me.TextBox64.Text, textFont, Brushes.Black, 240, 631)
        e.Graphics.DrawString(Me.TextBox63.Text, textFont, Brushes.Black, 240, 647)
        e.Graphics.DrawString(Me.TextBox62.Text, textFont, Brushes.Black, 240, 664)
        e.Graphics.DrawString(Me.TextBox61.Text, textFont, Brushes.Black, 240, 680)
        e.Graphics.DrawString(Me.TextBox60.Text, textFont, Brushes.Black, 240, 697)
        e.Graphics.DrawString(Me.TextBox59.Text, textFont, Brushes.Black, 240, 713)
        e.Graphics.DrawString(Me.TextBox58.Text, textFont, Brushes.Black, 240, 733)

        '9 OK
        e.Graphics.DrawString(Me.TextBox89.Text, textFont, Brushes.Black, 370, 485)
        e.Graphics.DrawString(Me.TextBox88.Text, textFont, Brushes.Black, 370, 501)
        e.Graphics.DrawString(Me.TextBox87.Text, textFont, Brushes.Black, 370, 517)
        e.Graphics.DrawString(Me.TextBox86.Text, textFont, Brushes.Black, 370, 534)
        e.Graphics.DrawString(Me.TextBox85.Text, textFont, Brushes.Black, 370, 551)
        e.Graphics.DrawString(Me.TextBox84.Text, textFont, Brushes.Black, 370, 567)
        e.Graphics.DrawString(Me.TextBox83.Text, textFont, Brushes.Black, 370, 581)
        e.Graphics.DrawString(Me.TextBox82.Text, textFont, Brushes.Black, 370, 598)
        e.Graphics.DrawString(Me.TextBox81.Text, textFont, Brushes.Black, 370, 614)
        e.Graphics.DrawString(Me.TextBox80.Text, textFont, Brushes.Black, 370, 631)
        e.Graphics.DrawString(Me.TextBox79.Text, textFont, Brushes.Black, 370, 647)
        e.Graphics.DrawString(Me.TextBox78.Text, textFont, Brushes.Black, 370, 664)
        e.Graphics.DrawString(Me.TextBox77.Text, textFont, Brushes.Black, 370, 680)
        e.Graphics.DrawString(Me.TextBox76.Text, textFont, Brushes.Black, 370, 697)
        e.Graphics.DrawString(Me.TextBox75.Text, textFont, Brushes.Black, 370, 713)
        e.Graphics.DrawString(Me.TextBox74.Text, textFont, Brushes.Black, 370, 733)

        '11 OK
        e.Graphics.DrawString(Me.TextBox105.Text, textFont, Brushes.Black, 550, 485)
        e.Graphics.DrawString(Me.TextBox104.Text, textFont, Brushes.Black, 550, 501)
        e.Graphics.DrawString(Me.TextBox103.Text, textFont, Brushes.Black, 550, 517)
        e.Graphics.DrawString(Me.TextBox102.Text, textFont, Brushes.Black, 550, 534)
        e.Graphics.DrawString(Me.TextBox101.Text, textFont, Brushes.Black, 550, 551)
        e.Graphics.DrawString(Me.TextBox100.Text, textFont, Brushes.Black, 550, 567)
        e.Graphics.DrawString(Me.TextBox99.Text, textFont, Brushes.Black, 550, 581)
        e.Graphics.DrawString(Me.TextBox98.Text, textFont, Brushes.Black, 550, 598)
        e.Graphics.DrawString(Me.TextBox97.Text, textFont, Brushes.Black, 550, 614)
        e.Graphics.DrawString(Me.TextBox96.Text, textFont, Brushes.Black, 550, 631)
        e.Graphics.DrawString(Me.TextBox95.Text, textFont, Brushes.Black, 550, 647)
        e.Graphics.DrawString(Me.TextBox94.Text, textFont, Brushes.Black, 550, 664)
        e.Graphics.DrawString(Me.TextBox93.Text, textFont, Brushes.Black, 550, 680)
        e.Graphics.DrawString(Me.TextBox92.Text, textFont, Brushes.Black, 550, 697)
        e.Graphics.DrawString(Me.TextBox91.Text, textFont, Brushes.Black, 550, 713)
        e.Graphics.DrawString(Me.TextBox90.Text, textFont, Brushes.Black, 550, 733)

        '21
        e.Graphics.DrawString(Me.TextBox107.Text, textFont, Brushes.Black, 40, 1012)
        e.Graphics.DrawString(Me.TextBox106.Text, textFont, Brushes.Black, 200, 1012)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim file_name As String
        Dim text_line As String
        Dim astr As String
        Dim bstr As String

        Dim sr As IO.StreamReader

        Try
            With OpenFileDialog1
                'With statement is used to execute statements using a particular object, here,_
                'OpenFileDialog1
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                'setting filters so that Text files and All Files choice appears in the Files of Type box
                'in the dialog
                If .ShowDialog() = DialogResult.OK Then
                    'showDialog method makes the dialog box visible at run time
                    file_name = .FileName
                    sr = New IO.StreamReader(.OpenFile)
                    Do While sr.Peek() <> -1
                        text_line = sr.ReadLine()
                        astr = Mid(text_line, 6)
                        bstr = Mid(text_line, 1, 4)
                        Select Case bstr
                            Case "t001"
                                TextBox1.Text = astr
                            Case "t002"
                                TextBox2.Text = astr
                            Case "t003"
                                TextBox3.Text = astr
                            Case "t004"
                                TextBox4.Text = astr
                            Case "t005"
                                TextBox5.Text = astr
                            Case "t006"
                                TextBox6.Text = astr
                            Case "t007"
                                TextBox7.Text = astr
                            Case "t008"
                                TextBox8.Text = astr
                            Case "t009"
                                TextBox9.Text = astr
                            Case "t010"
                                TextBox10.Text = astr
                            Case "t011"
                                TextBox11.Text = astr
                            Case "t012"
                                TextBox12.Text = astr
                            Case "t013"
                                TextBox13.Text = astr
                            Case "t014"
                                TextBox14.Text = astr
                            Case "t015"
                                TextBox15.Text = astr
                            Case "t016"
                                TextBox16.Text = astr
                            Case "t017"
                                TextBox17.Text = astr
                            Case "t018"
                                TextBox18.Text = astr
                            Case "t019"
                                TextBox19.Text = astr
                            Case "t020"
                                TextBox20.Text = astr
                            Case "t021"
                                TextBox21.Text = astr
                            Case "t022"
                                TextBox22.Text = astr
                            Case "t023"
                                TextBox23.Text = astr
                            Case "t024"
                                TextBox24.Text = astr
                            Case "t025"
                                TextBox25.Text = astr
                            Case "t026"
                                TextBox26.Text = astr
                            Case "t027"
                                TextBox27.Text = astr
                            Case "t028"
                                TextBox28.Text = astr
                            Case "t029"
                                TextBox29.Text = astr
                            Case "t030"
                                TextBox30.Text = astr
                            Case "t031"
                                TextBox31.Text = astr
                            Case "t032"
                                TextBox32.Text = astr
                            Case "t033"
                                TextBox33.Text = astr
                            Case "t034"
                                TextBox34.Text = astr
                            Case "t035"
                                TextBox35.Text = astr
                            Case "t036"
                                TextBox36.Text = astr
                            Case "t037"
                                TextBox37.Text = astr
                            Case "t038"
                                TextBox38.Text = astr
                            Case "t039"
                                TextBox39.Text = astr
                            Case "t040"
                                TextBox40.Text = astr
                            Case "t041"
                                TextBox41.Text = astr
                            Case "t042"
                                TextBox42.Text = astr
                            Case "t043"
                                TextBox43.Text = astr
                            Case "t044"
                                TextBox44.Text = astr
                            Case "t045"
                                TextBox45.Text = astr
                            Case "t046"
                                TextBox46.Text = astr
                            Case "t047"
                                TextBox47.Text = astr
                            Case "t048"
                                TextBox48.Text = astr
                            Case "t049"
                                TextBox49.Text = astr
                            Case "t050"
                                TextBox50.Text = astr
                            Case "t051"
                                TextBox51.Text = astr
                            Case "t052"
                                TextBox52.Text = astr
                            Case "t053"
                                TextBox53.Text = astr
                            Case "t054"
                                TextBox54.Text = astr
                            Case "t055"
                                TextBox55.Text = astr
                            Case "t056"
                                TextBox56.Text = astr
                            Case "t057"
                                TextBox57.Text = astr
                            Case "t058"
                                TextBox58.Text = astr
                            Case "t059"
                                TextBox59.Text = astr
                            Case "t060"
                                TextBox60.Text = astr
                            Case "t061"
                                TextBox61.Text = astr
                            Case "t062"
                                TextBox62.Text = astr
                            Case "t063"
                                TextBox63.Text = astr
                            Case "t064"
                                TextBox64.Text = astr
                            Case "t065"
                                TextBox65.Text = astr
                            Case "t066"
                                TextBox66.Text = astr
                            Case "t067"
                                TextBox67.Text = astr
                            Case "t068"
                                TextBox68.Text = astr
                            Case "t069"
                                TextBox69.Text = astr
                            Case "t070"
                                TextBox70.Text = astr
                            Case "t071"
                                TextBox71.Text = astr
                            Case "t072"
                                TextBox72.Text = astr
                            Case "t073"
                                TextBox73.Text = astr
                            Case "t074"
                                TextBox74.Text = astr
                            Case "t075"
                                TextBox75.Text = astr
                            Case "t076"
                                TextBox76.Text = astr
                            Case "t077"
                                TextBox77.Text = astr
                            Case "t078"
                                TextBox78.Text = astr
                            Case "t079"
                                TextBox79.Text = astr
                            Case "t080"
                                TextBox80.Text = astr
                            Case "t081"
                                TextBox81.Text = astr
                            Case "t082"
                                TextBox82.Text = astr
                            Case "t083"
                                TextBox83.Text = astr
                            Case "t084"
                                TextBox84.Text = astr
                            Case "t085"
                                TextBox85.Text = astr
                            Case "t086"
                                TextBox86.Text = astr
                            Case "t087"
                                TextBox87.Text = astr
                            Case "t088"
                                TextBox88.Text = astr
                            Case "t089"
                                TextBox89.Text = astr
                            Case "t090"
                                TextBox90.Text = astr
                            Case "t091"
                                TextBox91.Text = astr
                            Case "t092"
                                TextBox92.Text = astr
                            Case "t093"
                                TextBox93.Text = astr
                            Case "t094"
                                TextBox94.Text = astr
                            Case "t095"
                                TextBox95.Text = astr
                            Case "t096"
                                TextBox96.Text = astr
                            Case "t097"
                                TextBox97.Text = astr
                            Case "t098"
                                TextBox98.Text = astr
                            Case "t099"
                                TextBox99.Text = astr
                            Case "t100"
                                TextBox100.Text = astr
                            Case "t101"
                                TextBox101.Text = astr
                            Case "t102"
                                TextBox102.Text = astr
                            Case "t103"
                                TextBox103.Text = astr
                            Case "t104"
                                TextBox104.Text = astr
                            Case "t105"
                                TextBox105.Text = astr
                            Case "t106"
                                TextBox106.Text = astr
                            Case "t107"
                                TextBox107.Text = astr
                            Case Else

                        End Select

                    Loop
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim file_namew As String
        Dim sw As IO.StreamWriter
        'streamwriter is used to write text
        Try
            With SaveFileDialog1
                .FileName = file_namew
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    file_namew = .FileName
                    sw = New IO.StreamWriter(file_namew)
                    'using streamwriter to write text from richtextbox and saving it
                    sw.WriteLine("t001=" & TextBox1.Text)
                    sw.WriteLine("t002=" & TextBox2.Text)
                    sw.WriteLine("t003=" & TextBox3.Text)
                    sw.WriteLine("t004=" & TextBox4.Text)
                    sw.WriteLine("t005=" & TextBox5.Text)
                    sw.WriteLine("t006=" & TextBox6.Text)
                    sw.WriteLine("t007=" & TextBox7.Text)
                    sw.WriteLine("t008=" & TextBox8.Text)
                    sw.WriteLine("t009=" & TextBox9.Text)
                    sw.WriteLine("t010=" & TextBox10.Text)
                    sw.WriteLine("t011=" & TextBox11.Text)
                    sw.WriteLine("t012=" & TextBox12.Text)
                    sw.WriteLine("t013=" & TextBox13.Text)
                    sw.WriteLine("t014=" & TextBox14.Text)
                    sw.WriteLine("t015=" & TextBox15.Text)
                    sw.WriteLine("t016=" & TextBox16.Text)
                    sw.WriteLine("t017=" & TextBox17.Text)
                    sw.WriteLine("t018=" & TextBox18.Text)
                    sw.WriteLine("t019=" & TextBox19.Text)
                    sw.WriteLine("t020=" & TextBox20.Text)
                    sw.WriteLine("t021=" & TextBox21.Text)
                    sw.WriteLine("t022=" & TextBox22.Text)
                    sw.WriteLine("t023=" & TextBox23.Text)
                    sw.WriteLine("t024=" & TextBox24.Text)
                    sw.WriteLine("t025=" & TextBox25.Text)
                    sw.WriteLine("t026=" & TextBox26.Text)
                    sw.WriteLine("t027=" & TextBox27.Text)
                    sw.WriteLine("t028=" & TextBox28.Text)
                    sw.WriteLine("t029=" & TextBox29.Text)
                    sw.WriteLine("t030=" & TextBox30.Text)
                    sw.WriteLine("t031=" & TextBox31.Text)
                    sw.WriteLine("t032=" & TextBox32.Text)
                    sw.WriteLine("t033=" & TextBox33.Text)
                    sw.WriteLine("t034=" & TextBox34.Text)
                    sw.WriteLine("t035=" & TextBox35.Text)
                    sw.WriteLine("t036=" & TextBox36.Text)
                    sw.WriteLine("t037=" & TextBox37.Text)
                    sw.WriteLine("t038=" & TextBox38.Text)
                    sw.WriteLine("t039=" & TextBox39.Text)
                    sw.WriteLine("t040=" & TextBox40.Text)
                    sw.WriteLine("t041=" & TextBox41.Text)
                    sw.WriteLine("t042=" & TextBox42.Text)
                    sw.WriteLine("t043=" & TextBox43.Text)
                    sw.WriteLine("t044=" & TextBox44.Text)
                    sw.WriteLine("t045=" & TextBox45.Text)
                    sw.WriteLine("t046=" & TextBox46.Text)
                    sw.WriteLine("t047=" & TextBox47.Text)
                    sw.WriteLine("t048=" & TextBox48.Text)
                    sw.WriteLine("t049=" & TextBox49.Text)
                    sw.WriteLine("t050=" & TextBox50.Text)
                    sw.WriteLine("t051=" & TextBox51.Text)
                    sw.WriteLine("t052=" & TextBox52.Text)
                    sw.WriteLine("t053=" & TextBox53.Text)
                    sw.WriteLine("t054=" & TextBox54.Text)
                    sw.WriteLine("t055=" & TextBox55.Text)
                    sw.WriteLine("t056=" & TextBox56.Text)
                    sw.WriteLine("t057=" & TextBox57.Text)
                    sw.WriteLine("t058=" & TextBox58.Text)
                    sw.WriteLine("t059=" & TextBox59.Text)
                    sw.WriteLine("t060=" & TextBox60.Text)
                    sw.WriteLine("t061=" & TextBox61.Text)
                    sw.WriteLine("t062=" & TextBox62.Text)
                    sw.WriteLine("t063=" & TextBox63.Text)
                    sw.WriteLine("t064=" & TextBox64.Text)
                    sw.WriteLine("t065=" & TextBox65.Text)
                    sw.WriteLine("t066=" & TextBox66.Text)
                    sw.WriteLine("t067=" & TextBox67.Text)
                    sw.WriteLine("t068=" & TextBox68.Text)
                    sw.WriteLine("t069=" & TextBox69.Text)
                    sw.WriteLine("t070=" & TextBox70.Text)
                    sw.WriteLine("t071=" & TextBox71.Text)
                    sw.WriteLine("t072=" & TextBox72.Text)
                    sw.WriteLine("t073=" & TextBox73.Text)
                    sw.WriteLine("t074=" & TextBox74.Text)
                    sw.WriteLine("t075=" & TextBox75.Text)
                    sw.WriteLine("t076=" & TextBox76.Text)
                    sw.WriteLine("t077=" & TextBox77.Text)
                    sw.WriteLine("t078=" & TextBox78.Text)
                    sw.WriteLine("t079=" & TextBox79.Text)
                    sw.WriteLine("t080=" & TextBox80.Text)
                    sw.WriteLine("t081=" & TextBox81.Text)
                    sw.WriteLine("t082=" & TextBox82.Text)
                    sw.WriteLine("t083=" & TextBox83.Text)
                    sw.WriteLine("t084=" & TextBox84.Text)
                    sw.WriteLine("t085=" & TextBox85.Text)
                    sw.WriteLine("t086=" & TextBox86.Text)
                    sw.WriteLine("t087=" & TextBox87.Text)
                    sw.WriteLine("t088=" & TextBox88.Text)
                    sw.WriteLine("t089=" & TextBox89.Text)
                    sw.WriteLine("t090=" & TextBox90.Text)
                    sw.WriteLine("t091=" & TextBox91.Text)
                    sw.WriteLine("t092=" & TextBox92.Text)
                    sw.WriteLine("t093=" & TextBox93.Text)
                    sw.WriteLine("t094=" & TextBox94.Text)
                    sw.WriteLine("t095=" & TextBox95.Text)
                    sw.WriteLine("t096=" & TextBox96.Text)
                    sw.WriteLine("t097=" & TextBox97.Text)
                    sw.WriteLine("t098=" & TextBox98.Text)
                    sw.WriteLine("t099=" & TextBox99.Text)
                    sw.WriteLine("t100=" & TextBox100.Text)
                    sw.WriteLine("t101=" & TextBox101.Text)
                    sw.WriteLine("t102=" & TextBox102.Text)
                    sw.WriteLine("t103=" & TextBox103.Text)
                    sw.WriteLine("t104=" & TextBox104.Text)
                    sw.WriteLine("t105=" & TextBox105.Text)
                    sw.WriteLine("t106=" & TextBox106.Text)
                    sw.WriteLine("t107=" & TextBox107.Text)

                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If
        End Try
    End Sub
End Class
