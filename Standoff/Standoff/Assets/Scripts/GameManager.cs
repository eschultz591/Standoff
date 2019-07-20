using UnityEngine;
using System.Collections.Generic;       //Allows us to use Lists. 

public class GameManager : MonoBehaviour
{
    //test variable
    public GameObject curMap;
    public GameObject cam;

    public GameObject Players;
    public GameObject Dummies;

    public GameObject Astar;

    [SerializeField] private static GameManager instance = null;
    [SerializeField] private GameObject[] Maps;
    // [SerializeField] private Vector3[] PlayerSpawns;
    // [SerializeField] private Vector3[] DummySpawns;
    [SerializeField] private int selection;

    [SerializeField] private List<GameObject> EnemySpawns; //edited for lists of gameobject spawns
    [SerializeField] private List<Vector3> PlayerSpawns;
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);



        //Call the InitGame function to initialize the specific level
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //Creates Map based selection
        Instantiate(Maps[selection]);

        //curMap = GameObject.Find("Background");
        // int childrenCount = curMap.transform.childCount;

        foreach (Transform child in curMap.transform)
        {
            if (child.tag == "PlayerSpawn")
            {
                PlayerSpawns.Add(child.gameObject.transform.position);
                
            }
            else if (child.tag == "EnemySpawn")
            {
                EnemySpawns.Add(child.gameObject);
            }
            
        }

        foreach (Vector3 spawn in PlayerSpawns)
        {
            Instantiate(Players, spawn, Quaternion.identity);
            //cam.GetComponent<CameraMovement>().player = Players;
        }
        foreach (GameObject spawn in EnemySpawns)
        {
            Instantiate(Dummies, spawn.gameObject.transform.position, Quaternion.identity);
            Dummies.gameObject.layer = spawn.layer;
        }
        Vector3 cv = new Vector3(0f, 0f, 20f);


        GameObject cfollow = GameObject.Find("CirclePlayer(Clone)");
        Instantiate(Astar, new Vector3(0, 0, 0), Quaternion.identity);
        cam.GetComponent<CameraMovement>().player = GameObject.Find("CameraFollow");
        Instantiate(cam, cv, Quaternion.identity);
        // Instantiate(Players, (Maps[selection].transform.Find("PlayerSpawn")).transform);
    }



    //Update is called every frame.
    void Update()
    {

    }
}