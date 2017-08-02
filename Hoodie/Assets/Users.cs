using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Users : MonoBehaviour
{


    private const int MAX_PLACES = 5;
    private const int NICK_X = 820;
    private const int POSITION_Y = 400;
    private const int POINTS_X = 1230;
    private const int HEIGHT = 50;
    private const int WIDTH = 100;
    private const int GAP = 60;
    private GUIStyle style = new GUIStyle();

    void Start()
    {

        style.fontSize = 50;

    }


    void Update()
    {

    }
    void OnGUI()
    {
        int moveDownClear = 0;
        for (int i = 0; i < UsersList.howManyUsers - 1; i++)
        {
            GUI.Box(new Rect(NICK_X, POSITION_Y + moveDownClear, WIDTH, HEIGHT), "", style);
            GUI.Box(new Rect(POINTS_X, POSITION_Y + moveDownClear, WIDTH, HEIGHT), "", style);
            moveDownClear += GAP;
        }
        UsersList.usersList.Sort();
        int moveDown = 0;
        int nrPlace = 1;
        foreach (User user in UsersList.usersList)
        {

            GUI.Box(new Rect(NICK_X, POSITION_Y + moveDown, WIDTH, HEIGHT), nrPlace.ToString() + ". " + user.getNickname(), style);
            GUI.Box(new Rect(POINTS_X, POSITION_Y + moveDown, WIDTH, HEIGHT), user.getPoints().ToString(), style);
            moveDown += GAP;
            nrPlace++;
            if (nrPlace > MAX_PLACES)
            {
                break;
            }

        }
    }








}


