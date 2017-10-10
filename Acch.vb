Option Strict Off
Option Explicit On
Module Acch
	' This file is unique for each protected software. This is necessary
	' to ensure a well protected algorithm to transfer data to your application.

	Delegate Function DCbfn(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer, ByVal D As Integer) As Integer
	Declare Function Accdd11 Lib "rcp958.dll" Alias "Accdd1" (ByVal Acck() As Integer) As Boolean
	Declare Function Fddig11 Lib "rcp958.dll" Alias "Fddig1" (ByVal D As Integer) As Integer
	Declare Function Dscbf11 Lib "rcp958.dll" Alias "Dscbf1" (ByVal Cbfn As DCbfn, ByVal N As Integer) As Integer

	Dim ARufcb1 As DCbfn = AddressOf Rufcb1

	Public Function DriveInPort() As Integer
	' in the Visual Studio environment press Ctrl-Alt-E to bring up
	' the Exception Manager or in the menu Debug->Exceptions, from there drill down
	' into Managed Debugging Assistants, find LoaderLock, and uncheck the "Thrown"
	' checkbox, then click "OK".

		Return Fddig11(0)
	End Function

    Public Function DriveIsOrig(ByRef Disk As Char, _
        ByRef Num1 As Integer, ByRef Num2 As Integer, ByRef LicType As Integer) As Boolean
        '------------------------------------------------------------
        Dim AccR4, AccR2, AccR1, AccR3, AccNa, I As Integer
        Dim AccUr, LicIn As Integer
        Dim OrigDrive As Boolean
        Dim AccA(99) As Integer
        '------------------------------------------------------------

        Randomize()
        For I = 0 To 99
            AccA(I) = CInt(Int(&H7FFF * Rnd()))
        Next
        AccUr = 0
        For I = 1 To 99
            AccUr = AccA((AccA(I) Xor (AccUr And &HFF)) Mod 99) Xor (AccUr \ &H100)
        Next
        AccUr = &H60AEADAD Xor AccUr

        Call Accdd11(AccA)

        AccNa = (AccA(99) Xor &H37E56FEF) And 1061109567

        AccR1 = &H15F39379 Xor AccA((AccNa And &HFF))
        AccR2 = &H6D98875F Xor AccA((&HFF And (AccNa \ &H100)))
        AccR3 = &H04C824E0 Xor AccA((&HFF And (AccNa \ &H10000)))
        AccR4 = &H75F07A62 Xor AccA((&HFF And (AccNa \ &H1000000)))
        AccUr = AccUr And 65535
        If (AccUr = 0) Then AccUr = AccUr + 1

        OrigDrive = (AccR4 = (((AccR2 - (Not AccR1) \ AccUr) Xor AccR3) - AccUr))

        LicType = 0
        If OrigDrive Then
            LicIn = 78 + ((&HFF And (AccNa \ &H1000000)) Mod 21)
            I = AccA(LicIn) Xor AccA(AccNa And &HFF)
            If (I = &H532EA214) Then LicType = 1 Else
            If (I = &H3A7E01AB) Then LicType = 2
            Num1 = &H52671C65 Xor AccA((AccNa And &HFF) + 1)
            Num2 = &H5DDC6800 Xor AccA((&HFF And (AccNa \ &H100)) + 1)
            Disk = Chr((AccA(LicIn - 8) Xor AccA(&H1F2AE404 Mod 64)) + 65)
        End If

        Call Dscbf11(ARufcb1, 1)  ' this line can be moved to the initialization code
        Return OrigDrive

    End Function

    Public Function Rufcb1(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer, ByVal D As Integer) As Integer
        '------------------------------------------------------------
        Dim L As Integer
        Dim DriveLetter As Char
        'Dim Disk As Char, Num1 As Integer, Num2 As Integer, LicType As Integer
        '------------------------------------------------------------

	L = &H7653B7B2
		L = L + (B Mod &H8A7F)
		L = L Xor ((A Mod &H2ABA) << 12)
		L = L Xor ((C Mod &H0992) << 7)
		L = L Xor ((D Mod &H4428) << 5)
		L = ((L And &HFFFFFFF) << 2) Or (L >> 30)
		L = &H11F08219 Xor L
		L = L Xor (((A And &H3FFFF) << 12) Or (A >> 20))
		L = L Xor (((C And &H7) << 27) Or (C >> 5))

        L = &H7FFFFFFF And L
        DriveLetter = Chr(L Mod 64 + 65)

        Call MsgBox("Original Drive " & DriveLetter & ": was removed!")

        'If Not DriveIsOrig(Disk, Num1, Num2, LicType) Then
        '  Call MsgBox("Original Drive was not found!")
        'End If

        Return L
    End Function

End Module

