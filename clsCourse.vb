Public Class clsCourse
    Dim strCourseID As String
    Dim strDesc As String
    Dim strUnits As String

    Public Property courseID As String
        Get
            Return strCourseID
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Course_ID")) Then
                strCourseID = value
            End If
        End Set
    End Property

    Public Property desc As String
        Get
            Return strDesc
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Description")) Then
                strDesc = value
            End If
        End Set
    End Property

    Public Property units As String
        Get
            Return strUnits
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Units")) Then
                strUnits = Convert.ToInt32(value)
            End If
        End Set
    End Property
End Class
