using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject gm;
    public int port = 7777;
    public void CreateGame ()
    {




        
        SceneManager.LoadScene(1);
        /* 

        

        byte[] bytes= new byte[256];
        int recv;


        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);
        socket.Connect("8.8.8.8", port);
        IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
        int outport = ((IPEndPoint)endPoint).Port;
       // int data = socket.Receive(bytes,0,socket.Available,SocketFlags.None);


        string ip = socket.LocalEndPoint.AddressFamily.ToString();



        Debug.Log("Ip:"+ ip);
        Debug.Log("waiting for client on port: " + outport );
        */
        

        
    }



    public void JoinServer()
    {
        byte[] msg = Encoding.UTF8.GetBytes("This is a test");


        Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);


        int bytecount = socket.Send(msg,0,msg.Length,SocketFlags.None); 
        Debug.Log("Sent bytes" + bytecount);


        socket.Connect("10.0.0.23",59843);
        Debug.Log("connection made");

    }
}
