Imports System.Management
Module Module1

    Dim DeviceId As String = ""


    Public id As String
    Public Function GetDeviceId() As String
        Try
            Dim MS As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_diskdrive where interfacetype='USB'")
            For Each MO As ManagementObject In MS.Get
                For Each Data As PropertyData In MO.Properties
                    If Data.Name = "PNPDeviceID" Then
                        DeviceId = Convert.ToString(Data.Value)
                        Dim ArrUSBInfo() As String = DeviceId.Split("\")
                        Return ArrUSBInfo(UBound(ArrUSBInfo))
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Function
End Module
