Option Strict On
Option Explicit On

Public MustInherit Class Persona

    Private _nombre As String
    Private _apellido As String

    Protected Sub New(nombre As String, apellido As String)
        Me.Nombre = nombre
        Me.Apellido = apellido
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("El nombre no puede estar vacío.")
            End If

            _nombre = value.Trim()
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("El apellido no puede estar vacío.")
            End If

            _apellido = value.Trim()
        End Set
    End Property

    Public ReadOnly Property NombreCompleto As String
        Get
            Return Nombre & " " & Apellido
        End Get
    End Property

    Public MustOverride Function ObtenerDescripcion() As String

End Class