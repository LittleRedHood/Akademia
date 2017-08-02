using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool isLoad;
    public static int currentLvl;
    public static int points;
    public static float timer;
    public static int lifeAmount;
    public const int primaryTime = 120;
    public static int lvlnumber;
    public static bool yellow_key = false;
    public static bool red_key = false;
    public static bool green_key = false;
    public static bool _collision = false;
    public static string lvlName;
    public GUIStyle infoStyle = new GUIStyle();//added for txt //my //zostawiłam dla Oli do wyswietlania punktów

    void Start()
    {
        infoStyle.fontSize = 35;
        infoStyle.normal.textColor = Color.white;
        infoStyle.fontStyle = FontStyle.Bold;

        isLoad = DataInfoClass.isLoadFile;
        if (isLoad)
        {
            lvlnumber = Application.loadedLevel;
            Load();
            DataInfoClass.isLoadFile = false;

        }
        else
        {
            timer = primaryTime;
            lvlnumber = Application.loadedLevel;
            lvlName = Application.loadedLevelName;
            if (lvlName.Equals("lvl_1"))
            {
                currentLvl = 1;
                lifeAmount = 3;
                points = 0;
            }
            else if (lvlName.Equals("lvl_2"))
            {
                currentLvl = 2;

            }
            else if (lvlName.Equals("lvl_3"))
            {
                currentLvl = 3;
            }
        }
    }
    void Update()
    {
        if (PlayerLife.gameOver == true)
        {
            DataInfoClass.addUser = true;
            Application.LoadLevel("game_over");

        }
        if (Application.loadedLevel > lvlnumber)
        {
            currentLvl++;
            timer = primaryTime;
        }
        if (_collision == false)
        {
            if (lifeAmount > 0)
            {
                if (timer > 0)
                {
                    timer -= Time.deltaTime;

                }
                else if (timer < 0) timer = 0;
                else
                {
                    lifeAmount--;
                    timer = primaryTime;
                }
            }
        }
        else
        {
            lifeAmount--;
            timer = primaryTime;
            _collision = false;
        }
    }
    public void Save()
    {
        SaveLoadManager.SavePlayer(this);
    }

    public void Load()
    {
        PlayerData dataLoad = SaveLoadManager.LoadPlayer(this);
        transform.position = new Vector3(dataLoad.getPositionX(), dataLoad.getPositionY(), dataLoad.getPositionZ());
        lifeAmount = dataLoad.getPlayerLives();
        points = dataLoad.getPlayerPoints();
        timer = dataLoad.getPlayerTime();
        currentLvl = dataLoad.getPlayerLvl();
        yellow_key = dataLoad.getYellowKey();
        green_key = dataLoad.getGreenKey();
        red_key = dataLoad.getRedKey();

    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "background" || col.gameObject.tag == "enemy")
        {
            _collision = true;
        }

    }
    void OnGUI()
    {
        GUI.Box(new Rect(550, 10, 50, 20), "Score:  " + points, infoStyle);//was changed for txt
    }
}
