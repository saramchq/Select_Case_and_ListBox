Imports System.Reflection.Emit

Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Select Case ListBox1.SelectedItem.ToString()
            Case "Português"
                Label2.Text = "Olá!!! Bem-vindos a Portugal!"
                PictureBox1.Image = Image.FromFile("D:\Os meus documentos\IEFP - EFA Programador Informática\3934 - Visual Basic .NET\Visual Basic\Ex2Select\Portugal.png")
                Label3.Text = "Capital: Lisboa"

            Case "Inglês"
                Label2.Text = "Hello!!! Welcome to England!"
                PictureBox1.Image = Image.FromFile("D:\Os meus documentos\IEFP - EFA Programador Informática\3934 - Visual Basic .NET\Visual Basic\Ex2Select\Inglaterra.png")
                Label3.Text = "Capital: London"

            Case "Espanhol"
                Label2.Text = "Hola!!! Bienvenidos a España!"
                PictureBox1.Image = Image.FromFile("D:\Os meus documentos\IEFP - EFA Programador Informática\3934 - Visual Basic .NET\Visual Basic\Ex2Select\Espanha.png")
                Label3.Text = "Capital: Madrid"

            Case "Francês"
                Label2.Text = "Bonjour! Bienvenue en France!"
                PictureBox1.Image = Image.FromFile("D:\Os meus documentos\IEFP - EFA Programador Informática\3934 - Visual Basic .NET\Visual Basic\Ex2Select\França.png")
                Label3.Text = "Capital: Paris"

            Case "Alemão"
                Label2.Text = "Hallo! Willkommen in Deutschland!"
                PictureBox1.Image = Image.FromFile("D:\Os meus documentos\IEFP - EFA Programador Informática\3934 - Visual Basic .NET\Visual Basic\Ex2Select\Alemanha.png")
                Label3.Text = "Capital: Berlim"

            Case "Italiano"
                Label2.Text = "EHI! Benvenuti in Italia!"
                PictureBox1.Image = Image.FromFile("D:\Os meus documentos\IEFP - EFA Programador Informática\3934 - Visual Basic .NET\Visual Basic\Ex2Select\Italia.png")
                Label3.Text = "Capital: Roma"

        End Select
    End Sub

End Class

