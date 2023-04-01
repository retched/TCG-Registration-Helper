Public Class frmSplashScreen
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When this program loads, check to see if AllPlayers.xml exists.
        ' If it doesn't, create an empty AllPlayers.xml

        If Not File.Exists(Application.StartupPath + "\AllPlayers.xml") Then
            Try

                Dim xmlFile As XmlTextWriter
                xmlFile = New XmlTextWriter(Application.StartupPath + "\AllPlayers.xml", Encoding.UTF8)

                xmlFile.WriteStartDocument()
                xmlFile.Formatting = Formatting.Indented
                xmlFile.Indentation = 2
                xmlFile.WriteStartElement("PlayerList")
                xmlFile.WriteAttributeString("xmlns", "xsi", Nothing, "http://www.w3.org/2001/XMLSchema-instance")
                xmlFile.WriteAttributeString("xmlns", "xsd", Nothing, "http://www.w3.org/2001/XMLSchema")
                ' Empty PlayersList doesn't need anything here.
                xmlFile.WriteEndElement()

                xmlFile.Flush()
                xmlFile.Close()
            Catch ex As Exception
                ' Something went wrong with making the file. Shut the program down.
                MessageBox.Show("Cannot create the AllPlayers.xml file. This program is necessary for the program to operate. Please double check the program's compatibility settings and try again. If necessary, relaunch the program as an Administrator or install the program somewhere else. If asked by the developer, screen capture this window." + Environment.NewLine + Environment.NewLine + "Error:" + ex.ToString)
                Application.Exit()
            End Try
        End If

        ' Change the version number to that of the one listed in the Assembly
        lblVersionNumber.Text = "Version " & Application.ProductVersion.ToString
    End Sub
End Class