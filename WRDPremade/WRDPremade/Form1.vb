Imports MaterialSkin
Imports WeAreDevs_API

Public Class Form1
    Private WRDPremade As ExploitAPI = New ExploitAPI()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialLabelEdit()
        System.Threading.Thread.Sleep(1000)
        FormSkinDesign() '<< This will call the function that changed the material forms design
    End Sub

    Function FormSkinDesign()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue500, Primary.Blue700, Accent.Cyan100, TextShade.WHITE)

        If MaterialLabel1.Text = "Credits: SP!KE !S BACK + WeAreDevs" Then
            'Check Done
        Else
            Alteration.EditedCredits()
        End If
        Return vbNull
    End Function

    Function MaterialLabelEdit()
        MaterialLabel1.Text = "Credits: SP!KE !S BACK + WeAreDevs"
        Return vbNull
    End Function

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Process.Start("www.spikeisback.com")
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Process.Start("https://wearedevs.net")
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        WRDPremade.LaunchExploit()
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        WRDPremade.AddFire()
    End Sub
End Class
