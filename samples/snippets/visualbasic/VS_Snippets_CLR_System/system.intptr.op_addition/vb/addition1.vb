' Visual Basic .NET Document
Option Strict On

Imports System.Runtime.InteropServices

Module Example
   Public Sub Main()
      ' <Snippet1>
      Dim arr() As Integer = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }
      Dim ptr As IntPtr = Marshal.UnsafeAddrOfPinnedArrayElement(arr, 0)
      For ctr As Integer = 0 To arr.Length - 1
         Dim newPtr As IntPtr = ptr + ctr * Len(arr(0))
         Console.WriteLine("{0}   ", Marshal.ReadInt32(newPtr))
      Next
      ' The example displays the following output:
      '       2   4   6   8   10   12   14   16   18   20
      ' </Snippet1>
   End Sub
End Module

