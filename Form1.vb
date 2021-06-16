Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Dim DES As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider

    'hash function
    Function MD5Hash(value As String) As Byte()

        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))

    End Function
    'encrypt function

    Function Encrypt(StringInput As String, Keys As String) As String

        DES.Key = MD5Hash(Keys)
        DES.Mode = CipherMode.ECB

        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(StringInput)

        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

    End Function
    'encryption

    Private Sub btnMD5_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click

        txtencrypted.Text = Encrypt(txtinputtext.Text, "This is Key")
    End Sub

    Function Decrypt(Encryptedstring As String, Key As String) As String
        DES.Key = MD5Hash(Key)
        DES.Mode = CipherMode.ECB

        Dim Buffer As Byte() = Convert.FromBase64String(Encryptedstring)

        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))

    End Function

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        txtdecrypted.Text = Decrypt(btnEncrypt.Text, "This is Key")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtdecrypted_TextChanged(sender As Object, e As EventArgs) Handles txtdecrypted.TextChanged

    End Sub
End Class
