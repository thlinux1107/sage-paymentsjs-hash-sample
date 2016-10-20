Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'TH - Gather Developer Key (Client Secret) and JSON Response
        Dim sageDeveloperKey As String = "EzHUFdK3Egr4MI3x"
        Dim jsonResponse As String = ""
        jsonResponse = txtJSONresp.Text

        'TH - Parse the JSON response to get the transaction Response and Hash
        Dim jsonObject As JObject = JObject.Parse(jsonResponse)
        Dim resp As String = jsonObject.Item("Response").ToString()
        'Dim respObj As Object = JsonConvert.DeserializeObject(jsonObject.Item("Response").ToString())
        Dim json_resp As Object = JsonConvert.SerializeObject(resp).ToString()
        Dim hash As String = jsonObject.Item("Hash").ToString()

        'TH - Display the parsed Response
        txtResponse.Text = resp

        'TH - Display the parsed Hash
        txtHash.Text = hash

        'TH - setup the parsed response to get the SHA512 HASH
        Dim computedHash As Byte()
        Dim computedHashString As String
        Dim hmac As HMACSHA512 = New HMACSHA512(Encoding.ASCII.GetBytes(sageDeveloperKey))

        'TH - Base64 encode the hash
        computedHash = hmac.ComputeHash(Encoding.ASCII.GetBytes(json_resp))
        computedHashString = Convert.ToBase64String(computedHash)

        'TH - Display the computed hash of the parsed response.
        txtComputedHash.Text = computedHashString



    End Sub
End Class
