'
' Created by SharpDevelop.
' User: Ariel
' Date: 05/03/2021
' Time: 13:45
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Diagnostics.ProcessThread
Imports System.Runtime.InteropServices
Imports System
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.SQLite
Imports System.Data.SqlClient
Imports System.Management



Public Partial Class MainForm
	Inherits System.Windows.Forms.Form
	Private Const WM_SYSCOMMAND As Integer = &H112&
	Private Const MOUSE_MOVE As Integer = &HF012&
	
	<System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
	Private Shared Sub ReleaseCapture()
	End Sub
	
	<System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage( _
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
            ByVal wParam As Integer, ByVal lParam As Integer _
	)
	End Sub
	
	Dim Detener= False
	Dim Ruta
	Dim Database As String
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		guna2Button2.Enabled= False
		guna2Button1.Enabled= False
		
		Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
		Dim d As DriveInfo

	
      For Each d In allDrives
        	Application.DoEvents
        	
       	If d.DriveType= d.DriveType.Removable And d.IsReady or d.DriveType = 3 And d.IsReady Then
       	
       		guna2ComboBox1.Items.Add(d.name & " [" & d.VolumeLabel & "]")
       		End if
            
      Next
		
		toolStripStatusLabel1.Text= "Esperando por alguna acción"
	End Sub
	
	Private Sub moverForm()	
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
	
	
	Public Sub recursividad()
		'On Error Resume Next
		Detener= False
		guna2Button1.Text= "Detener"
		guna2Button2.Enabled= False
		guna2ComboBox1.Enabled= False
		If(Not File.Exists(CurDir & "\Data\" & Database & ".db")) Then 
			
			create()
			
		Else
			
			quitar()
			Application.DoEvents
			create()
		
		End If
		
		Dim Coincidencias= {"*.exe"}


		For Each archivos As String In My.Computer.FileSystem.GetFiles(Ruta, FileIO.SearchOption.SearchTopLevelOnly, Coincidencias)
			'Application.DoEvents
			If Detener = True Then Exit For
			'ListBox1.Items.Add(archivos)
			'lista1.Add(archivos)
			'MsgBox(archivos)
			analizar(archivos)	
		Next

		Dim Carpetas= Dir(Ruta & "*.*", vbDirectory)
		Do While (Len(Carpetas))
			'Application.DoEvents
		
			If Detener= True Then Exit Do 
		
			If File.GetAttributes(Ruta & carpetas) = 16 Or File.GetAttributes(Ruta & carpetas) = 18 Then
				'MsgBox(Carpetas & " - " & File.GetAttributes(Ruta & carpetas))
			
				If Len(Ruta & carpetas & "\") < 255 Then
					For Each archivos As String In My.Computer.FileSystem.GetFiles(Ruta & carpetas & "\", FileIO.SearchOption.SearchAllSubDirectories, Coincidencias)
						'Application.DoEvents
						If Detener= True Then Exit For
						'lista1.Add(archivos)
						'MsgBox(archivos)
						analizar(archivos)
		
					Next
	
				End if
	  	
			End if
			Carpetas= Dir$
	
		Loop
		
		guna2Button1.Text= "Recopilar datos"
		
		If(Detener = True) Then
			Try

			10:
			File.Delete(CurDir & "\Data\" & Database & ".db")

			Catch ex As Exception
			GoTo 10
			End Try
			toolStripStatusLabel1.Text= "¡Recopilación abortada por el usuario!"
			
		Else
			guna2Button2.Enabled= True
			toolStripStatusLabel1.Text= "¡Recopilación terminada!"
			
		End If
		
		guna2ComboBox1.Enabled= True
		MsgBox("Operación finalizada")
		
	End Sub
	
	Public Function GetMD5(File As String) As String
		'On Error Resume Next
		
		Dim p As New Process
		
		Dim md5Path As String


		md5Path= "md5.exe"
		p.StartInfo.FileName = md5Path
	
		p.StartInfo.Arguments = "-l " & ChrW(34) & File & ChrW(34)
        'p.StartInfo.Arguments = ChrW(34) & File & ChrW(34)
        ' Indicamos que queremos redirigir la salida
        p.StartInfo.RedirectStandardOutput = True
        ' Para redirigir la salida, UseShellExecute debe ser falso
        p.StartInfo.CreateNoWindow= True
        p.StartInfo.UseShellExecute= False

        'Application.DoEvents()

        ' Iniciamos el proceso
		 
        p.Start()
        
        p.WaitForExit(200)

        ' Leer el contenido de la salida y mostrarla
        ' La comprobación MD5 estará hasta el primer espacio
        
        
        Return Mid(p.StandardOutput.ReadToEnd(),1,32)
	End Function
	
	
	Public Function analizar(Fichero As String)
		
		toolStripStatusLabel1.Text= "Recopilando: " & Fichero
		insertar(Fichero, GetMD5(Fichero))
		
	End Function
	
	
	Public Function insertar(path, hash)
		Try

		Dim con As New SQLiteConnection("Data source=Data/" + Database + ".db; Version=3")			
		Dim sentencia= "INSERT INTO analisis (path, hash) VALUES (?, ?);"
		Dim comando As New SQLiteCommand(sentencia, con)
		Dim resultados As Integer
		
		Dim param1, param2 As new SQLiteParameter()
		param1.Value = path
		param2.Value= hash
		
		con.Open
		
		comando.Parameters.Add(param1)
		comando.Parameters.Add(param2)	
		
		resultados= comando.ExecuteNonQuery()

		con.Close
		
		Catch err As SQLiteException
			'MsgBox(err.Message)
		Catch err As Exception
			'MsgBox(err.Message)
		End Try
	End Function
	
	
	Public Sub create()
		
		Try
							
		FileCopy(CurDir & "\model.db", CurDir & "\Data\" & Database & ".db")
			
		Catch err As Exception
			
			'MsgBox(err.Message)
			
		End Try
		
	End Sub
	
	Public Sub quitar()
		
		Try
			
			Kill(CurDir & "\Data\" & Database & ".db")
			
		Catch err As Exception
			
			'MsgBox(err.Message)
			
		End Try
		
	End Sub
	
	
	Public Function verificar()
		
		Try
		Detener= False
		guna2TextBox1.Text= ""
		guna2Button2.Text = "Detener"
		guna2Button1.Enabled= False
		guna2ComboBox1.Enabled= False
		Dim con As New SQLiteConnection("Data source=Data/" + Database + ".db; Version=3")
		Dim sentencia= "Select path, hash from analisis"
		Dim comando As New SQLiteCommand(sentencia, con)

		con.Open
		
		Dim consulta= comando.ExecuteReader

	
	Do While consulta.Read
		
		If(Detener = True) Then Exit Do
		
			toolStripStatusLabel1.Text= "Verificando: " & consulta.Item("path").ToString
			
			If(File.Exists(consulta.Item("path").ToString)) Then
				
				If(Not GetMD5(consulta.Item("path").ToString) = consulta.Item("hash").ToString) Then
				'MsgBox(consulta.Item("path").ToString)
				guna2TextBox1.Text= guna2TextBox1.Text & "**Detectado** " & consulta.Item("path").ToString & vbNewLine
				
			End If
			
			End If
					
							
		Loop

		con.Close
		
		Catch err As SQLiteException
			'MsgBox(err.Message)
		Catch err As Exception
			'MsgBox(err.Message)
		End Try
		
		guna2Button2.Text = "Verificar"
		
		If(Detener = True) Then
			toolStripStatusLabel1.Text= "¡Verificación abortada por el usuario!"
		Else
			toolStripStatusLabel1.Text= "¡Verificación terminada!"
		End If
		
		guna2ComboBox1.Enabled=True
		guna2Button1.Enabled= True
		MsgBox("Operación finalizada")
		
	End Function
	
	
	Private Function getInfo(Disco) As String
       Dim computer As String = "."
       Dim wmi As Object = GetObject("winmgmts:" & _
           "{impersonationLevel=impersonate}!\\" & _
           computer & "\root\cimv2")
       
       Dim estedisco As Object = wmi.ExecQuery("SELECT * FROM Win32_LogicalDisk WHERE Name = '" + Disco +"'")

       Dim disk_ids As String = ""
       For Each disk As Object In estedisco
       	disk_ids = disk_ids & ", " & disk.VolumeSerialNumber
       	Exit For
       Next disk
       
       If disk_ids.Length > 0 Then disk_ids = _
           disk_ids.Substring(2)

		Return disk_ids

	End Function
	
	
	Sub Guna2Button1Click(sender As Object, e As EventArgs)
		
		Dim resp As Integer
		Dim MultiThreadStart As New Thread(AddressOf recursividad)
		
		If(Not Guna2ComboBox1.SelectedItem.ToString = "" And guna2Button1.Text= "Recopilar datos") Then
			
			If(File.Exists(CurDir & "\Data\" & Database & ".db")) Then
			resp= MessageBox.Show("Ya existe en nuestra base de datos el dispositivo. ¿Desea volver a recopilar datos?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
			Else
			MultiThreadStart.Start()	
			End If
			
			If(resp = 1) Then			
			MultiThreadStart.Start()
			Else
			toolStripStatusLabel1.Text= "¡Operación cancelada!"
			End If
			
		Else
			
			Detener= True
			MultiThreadStart.Abort()
			
		End If
		
	End Sub
	
	Sub Guna2Button2Click(sender As Object, e As EventArgs)
		
		Dim MultiThreadVerifi As New Thread(AddressOf verificar)
		
		If(Not Guna2ComboBox1.SelectedItem.ToString = "" And guna2Button2.Text = "Verificar") Then
									
			MultiThreadVerifi.Start()
									
		Else
			
			Detener= True
			MultiThreadVerifi.Abort()
		
		End If	
	
		
	End Sub
	
	
	

	
	Sub Guna2ComboBox1SelectedIndexChanged(sender As Object, e As EventArgs)
		
		If Len(Guna2ComboBox1.SelectedItem.ToString) Then
			Dim unidad= Split(Guna2ComboBox1.SelectedItem.ToString, "\")
			Ruta= unidad(0) & "\"
			Database= getInfo(Mid(Ruta, 1, 2))
			
			If(Not Database = "") Then guna2Button1.Enabled= True
			
			If(File.Exists(CurDir & "\Data\" & Database & ".db")) Then
				guna2Button2.Enabled= True
			Else
				guna2Button2.Enabled= False
			End If
			
		End If
	
	End Sub
	
	Sub Guna2Button3Click(sender As Object, e As EventArgs)
		Application.Exit
	End Sub
	
	Sub Guna2Button4Click(sender As Object, e As EventArgs)
	Me.WindowState= WindowState.Minimized
	End Sub
	
	 Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    	Handles MyBase.MouseMove

   	If e.Button = MouseButtons.Left Then
   		  moverForm()
        End If
    End Sub
	

End Class
