using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class User : System.IComparable
{
    private string nickname;
    private int points;

    public string getNickname()
    {
        return nickname;
    }
    public int getPoints()
    {
        return points;
    }
    public void setNickname(string n)
    {
        nickname = n;
    }
    public void setPoints(int p)
    {
        points = p;
    }



    public int CompareTo(object obj)
    {
        User userX = (User)obj;


        if (points < userX.points )
        {
            return 1;
        }
        else if (points > userX.points)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
