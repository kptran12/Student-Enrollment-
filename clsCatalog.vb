Public Class clsCatalog
    Dim strCatalogID As String
    Dim strYear As String
    Dim strQuarter As String
    Dim strCourseId As String
    Dim strProfId As String

    Public Property catalogID As String
        Get
            Return strCatalogID
        End Get
        Set(value As String)

            strCatalogID = value

        End Set
    End Property

    Public Property year As String
        Get
            Return strYear
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Year")) Then
                strYear = value
            End If
        End Set
    End Property

    Public Property quarter As String
        Get
            Return strQuarter
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Quarter")) Then
                strQuarter = value
            End If
        End Set
    End Property

    Public Property courseId As String
        Get
            Return strCourseId
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Course_ID")) Then
                strCourseId = value
            End If
        End Set
    End Property

    Public Property profId As String
        Get
            Return strProfId
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Prof_ID")) Then
                strProfId = value
            End If
        End Set
    End Property
End Class
