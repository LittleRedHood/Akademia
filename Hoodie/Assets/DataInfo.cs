using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInfoClass : MonoBehaviour
{

    public static bool isLoadFile;
    public static int lvlNumber=1;
    public static bool addUser;


    // Use this for initialization
    void Start()
    {

        Object.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        Object.DontDestroyOnLoad(this);
    }
}
