using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void CreateGame ()
    {
         string localIP;

        using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
        {
             socket.Connect("8.8.8.8", 65530);
             IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
             localIP = endPoint.Address.ToString();

             
        }

        SceneManager.LoadScene(1);
        Debug.Log("Ip:"+ localIP);

        
    }
}
