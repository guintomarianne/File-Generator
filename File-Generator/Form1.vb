﻿Imports System
Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json




Public Class Form1
    Dim sw1 As StreamWriter

    Private Sub TXTButton_Click(sender As Object, e As EventArgs) Handles TXTButton.Click
        If NameTextBox.Text <> "" Or AgeTextBox.Text <> "" Or AddressTextBox.Text <> "" Then

            Dim filename As String = "../TXTFile_" & System.DateTime.Now.ToString("MMddyyyy_hh_mm_ss") & ".txt"
            'filename = filename.Replace(".txt", "_" & System.DateTime.Now.ToString("MMddyyyy_hh_mm_ss") & ".txt")

            sw1 = File.AppendText(filename)
            sw1.WriteLine("Name: " & NameTextBox.Text)
            sw1.WriteLine("Age: " & AgeTextBox.Text)
            sw1.WriteLine("Address: " & AddressTextBox.Text)

            MsgBox("TXT File successfully created!", MsgBoxStyle.Information, "Saved")
            clearboxes()

            sw1.Close()

        Else
            MsgBox("Please input data into the boxes", MsgBoxStyle.Critical, "Complete the data")
        End If
    End Sub



    Private Sub XMLButton_Click(sender As Object, e As EventArgs) Handles XMLButton.Click
        If NameTextBox.Text <> "" Or AgeTextBox.Text <> "" Or AddressTextBox.Text <> "" Then

            Dim settings As New XmlWriterSettings()
            settings.Indent = True

            Dim filename As String = "../XMLFile_" & System.DateTime.Now.ToString("MMddyyyy_hh_mm_ss") & ".xml"
            Dim XmlWrt As XmlWriter = XmlWriter.Create(filename, settings)

            With XmlWrt
                .WriteStartDocument()
                .WriteComment("XML File")
                .WriteStartElement("Personal_Data")
                .WriteStartElement("Name")
                .WriteString(NameTextBox.Text.ToString())
                .WriteEndElement()

                .WriteStartElement("Age")
                .WriteString(AgeTextBox.Text.ToString())
                .WriteEndElement()

                .WriteStartElement("Address")
                .WriteString(AddressTextBox.Text.ToString())
                .WriteEndElement()

                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With

            MsgBox("XML File successfully created!", MsgBoxStyle.Information, "Saved")
            clearboxes()

        Else
            MsgBox("Please input data into the boxes", MsgBoxStyle.Critical, "Complete the data")
        End If
    End Sub


    Private Sub JSONButton_Click(sender As Object, e As EventArgs) Handles JSONButton.Click

        If NameTextBox.Text <> "" Or AgeTextBox.Text <> "" Or AddressTextBox.Text <> "" Then
            SerializeJsonObj()

            MsgBox("JSON File successfully created!", MsgBoxStyle.Information, "Saved")
            clearboxes()
        Else
            MsgBox("Please input data into the boxes", MsgBoxStyle.Critical, "Complete the data")
        End If

    End Sub

    Sub SerializeJsonObj()
        Dim myObj As New JsonObj()
        myObj.name = NameTextBox.ToString
        myObj.age = AgeTextBox.ToString
        myObj.address = AddressTextBox.ToString

        Dim json As String = JsonConvert.SerializeObject(myObj)
        'Dim filename As String = "../JSONFile_" & System.DateTime.Now.ToString("MMddyyyy_hh_mm_ss") & ".json"
        Dim file As IO.StreamWriter
        Dim filename As String = "JSONFile.json"
        filename = filename.Replace(".json", "_" & System.DateTime.Now.ToString("MMddyyyy_hh_mm_ss") & ".json")
        file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)

        file.WriteLine(json)
        file.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub clearboxes()
        NameTextBox.Clear()
        AgeTextBox.Clear()
        AddressTextBox.Clear()

    End Sub

End Class
