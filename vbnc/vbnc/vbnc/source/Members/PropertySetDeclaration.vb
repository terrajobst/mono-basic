' 
' Visual Basic.Net Compiler
' Copyright (C) 2004 - 2008 Rolf Bjarne Kvinge, RKvinge@novell.com
' 
' This library is free software; you can redistribute it and/or
' modify it under the terms of the GNU Lesser General Public
' License as published by the Free Software Foundation; either
' version 2.1 of the License, or (at your option) any later version.
' 
' This library is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
' Lesser General Public License for more details.
' 
' You should have received a copy of the GNU Lesser General Public
' License along with this library; if not, write to the Free Software
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
' 

Imports System.Reflection
Imports System.Reflection.Emit

''' <summary>
''' PropertySetDeclaration  ::=
'''	[  Attributes  ]  [  AccessModifier  ]  "Set" [  (  ParameterList  )  ]  LineTerminator
'''	[  Block  ]
'''	"End" "Set" StatementTerminator
''' </summary>
''' <remarks></remarks>
Public Class PropertySetDeclaration
    Inherits PropertyHandlerDeclaration

    Public Sub New(ByVal Parent As PropertyDeclaration)
        MyBase.New(Parent)
    End Sub

    Public Shadows Sub Init(ByVal Attributes As Attributes, ByVal Modifiers As Modifiers, ByVal ImplementsClause As MemberImplementsClause, ByVal Block As CodeBlock, ByVal SetParameters As ParameterList)
        Dim mySignature As SubSignature
        Dim name As String
        Dim typeParams As TypeParameters
        Dim params As ParameterList
        Dim manualValue As Boolean

        mySignature = New SubSignature(Me)

        If PropertySignature.TypeParameters IsNot Nothing Then
            typeParams = PropertySignature.TypeParameters.Clone()
            typeParams.Initialize(mySignature)
        Else
            typeParams = Nothing
        End If
        If SetParameters IsNot Nothing Then
            params = SetParameters
        Else
            params = New ParameterList(Me)
        End If

        Helper.Assert(CecilBuilder.Parameters.Count = params.Count)

        If params.Count = 1 Then
            manualValue = True
        Else
            manualValue = False
            If params.Count > 1 Then
                Helper.AddError(Compiler, Me.Location, "Invalid set parameters, there should be only 0 or 1 parameters")
                params.Clear()
            End If
        End If

        If PropertySignature.Parameters IsNot Nothing Then
            Dim tmp As Parameter = Nothing
            Dim ctmp As Mono.Cecil.ParameterDefinition = Nothing

            'The 'value' parameter should go at the end, so take it out of the list, add the other parameters, and add it back again
            If manualValue Then
                tmp = params(0)
                ctmp = CecilBuilder.Parameters(0)
                params.Clear()
                CecilBuilder.Parameters.Clear()
            End If

            For i As Integer = 0 To PropertySignature.Parameters.Count - 1
                params.Add(PropertySignature.Parameters(i).Clone(params))
            Next
            If manualValue Then
                params.Add(tmp)
                CecilBuilder.Parameters.Add(ctmp)
                ctmp.Sequence = CecilBuilder.Parameters.Count
            End If
        End If

        ' Setter without a 'value', create it automatically
        If manualValue = False Then
            Dim valueName As String = "value"
            Dim param As Parameter
            If PropertySignature.ReturnType IsNot Nothing Then
                param = New Parameter(params, valueName, PropertySignature.ReturnType)
            Else
                param = New Parameter(params, valueName, PropertySignature.TypeName)
            End If
            params.Add(param)
        End If

        name = "set_" & PropertySignature.Name

        mySignature.Init(New Identifier(mySignature, name, PropertySignature.Location, PropertySignature.Identifier.TypeCharacter), typeParams, params)

        MyBase.Init(Attributes, Modifiers, mySignature, ImplementsClause, Block)
    End Sub

    Shared Shadows Function IsMe(ByVal tm As tm) As Boolean
        Dim i As Integer
        While tm.PeekToken(i).Equals(ModifierMasks.AccessModifiers)
            i += 1
        End While
        Return tm.PeekToken(i) = KS.Set
    End Function

End Class