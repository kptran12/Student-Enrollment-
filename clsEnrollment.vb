Public Class clsEnrollment
    Dim strBroncoID As String
    Dim strCatalogID As String


    Public Property broncoId As String
        Get
            Return strBroncoID
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Bronco_ID")) Then
                strBroncoID = value
            End If
        End Set
    End Property

    Public Property catalogID As String
        Get
            Return strCatalogID
        End Get
        Set(value As String)
            If (clsValidator.isValidString(value, "Catalog_ID")) Then
                strCatalogID = value
            End If
        End Set
    End Property


End Class
