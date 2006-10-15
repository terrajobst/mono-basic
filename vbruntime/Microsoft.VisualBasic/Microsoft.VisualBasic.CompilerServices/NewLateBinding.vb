'
' NewLateBinding.vb
'
' Author:
'   Mizrahi Rafael (rafim@mainsoft.com)
'

'
' Copyright (C) 2002-2006 Mainsoft Corporation.
' Copyright (C) 2004-2006 Novell, Inc (http://www.novell.com)
'
' Permission is hereby granted, free of charge, to any person obtaining
' a copy of this software and associated documentation files (the
' "Software"), to deal in the Software without restriction, including
' without limitation the rights to use, copy, modify, merge, publish,
' distribute, sublicense, and/or sell copies of the Software, and to
' permit persons to whom the Software is furnished to do so, subject to
' the following conditions:
' 
' The above copyright notice and this permission notice shall be
' included in all copies or substantial portions of the Software.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
' EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
' NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
' LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
' OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
' WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
#If NET_2_0 Then
Imports System
Namespace Microsoft.VisualBasic.CompilerServices
    Public NotInheritable Class NewLateBinding
        Private Sub New()
            'Nobody should see constructor
        End Sub
        Public Shared Function LateCall(ByVal Instance As Object, ByVal Type As Type, ByVal MemberName As String, ByVal Arguments As Object(), ByVal ArgumentNames As String(), ByVal TypeArguments As Type(), ByVal CopyBack As Boolean(), ByVal IgnoreReturn As Boolean) As Object
            Throw New NotImplementedException
        End Function
        Public Shared Function LateCanEvaluate(ByVal instance As Object, ByVal type As Type, ByVal memberName As String, ByVal arguments As Object(), ByVal allowFunctionEvaluation As Boolean, ByVal allowPropertyEvaluation As Boolean) As Boolean
            Throw New NotImplementedException
        End Function
        Public Shared Function LateGet(ByVal Instance As Object, ByVal Type As Type, ByVal MemberName As String, ByVal Arguments As Object(), ByVal ArgumentNames As String(), ByVal TypeArguments As Type(), ByVal CopyBack As Boolean()) As Object
            Throw New NotImplementedException
        End Function
        Public Shared Function LateIndexGet(ByVal Instance As Object, ByVal Arguments As Object(), ByVal ArgumentNames As String()) As Object
            Throw New NotImplementedException
        End Function
        Public Shared Sub LateIndexSet(ByVal Instance As Object, ByVal Arguments As Object(), ByVal ArgumentNames As String())
            Throw New NotImplementedException
        End Sub
        Public Shared Sub LateIndexSetComplex(ByVal Instance As Object, ByVal Arguments As Object(), ByVal ArgumentNames As String(), ByVal OptimisticSet As Boolean, ByVal RValueBase As Boolean)
            Throw New NotImplementedException
        End Sub
        Public Shared Sub LateSet(ByVal Instance As Object, ByVal Type As Type, ByVal MemberName As String, ByVal Arguments As Object(), ByVal ArgumentNames As String(), ByVal TypeArguments As Type())
            Throw New NotImplementedException
        End Sub
        Public Shared Sub LateSet(ByVal Instance As Object, ByVal Type As Type, ByVal MemberName As String, ByVal Arguments As Object(), ByVal ArgumentNames As String(), ByVal TypeArguments As Type(), ByVal OptimisticSet As Boolean, ByVal RValueBase As Boolean, ByVal CallType As CallType)
            Throw New NotImplementedException
        End Sub
        Public Shared Sub LateSetComplex(ByVal Instance As Object, ByVal Type As Type, ByVal MemberName As String, ByVal Arguments As Object(), ByVal ArgumentNames As String(), ByVal TypeArguments As Type(), ByVal OptimisticSet As Boolean, ByVal RValueBase As Boolean)
            Throw New NotImplementedException
        End Sub
    End Class
End Namespace
#End If