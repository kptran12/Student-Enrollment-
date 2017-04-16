Public Class clsValidator
    'Share the function and apply the validator to the other classes
    Public Shared sError As String

    'Error Functions
    Public Shared Sub addError(ByVal s As String)
        If sError = "" Then
            sError = s
        Else
            sError += vbCrLf & s
        End If
    End Sub

    Public Function getError()
        Return sError
    End Function

    'Validation Functions
    'Validate that fields are filled
    Public Shared Function isValidString(ByVal s As String, ByVal sLabel As String)
        Dim bResult As Boolean
        Try
            If s <> "" Then
                bResult = True
            Else
                addError(sLabel & ": Invalid " & sLabel)
                bResult = False
            End If
        Catch ex As Exception
            addError(sLabel & " : Invalid" & sLabel & " ( " & ex.Message & ")")
            bResult = False
        End Try
        Return bResult
    End Function

    'Validate phone number
    Public Shared Function isValidPhone(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" And s.Length = 10 Then
                bResult = True
            Else
                addError("Invalid phone number. There should be 10 digits")
                bResult = False
            End If
        Catch ex As Exception
            addError("Invalid phone number. (" & ex.Message & ")")
        End Try

        Return bResult
    End Function

    'Validate Email
    Public Shared Function IsValidEmail(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" And s.Contains("@") And s.Contains(".") Then
                bResult = True
            Else
                addError("Invalid email")
                bResult = False
            End If
        Catch ex As Exception
            addError("Invalid email. (" & ex.Message & ")")
        End Try

        Return bResult
    End Function



End Class
