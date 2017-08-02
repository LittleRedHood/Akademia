using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnClick : MonoBehaviour {

    


    public void OnMouseUp()
    {
        PlayerLife.gameOver = false;

        if (DataInfoClass.lvlNumber == 1)
        {
            Application.LoadLevel("lvl_1");
        }
         else if(DataInfoClass.lvlNumber == 2)
        {
            Application.LoadLevel("lvl_2");
        }
        else if (DataInfoClass.lvlNumber == 3)
        {
            Application.LoadLevel("lvl_3");
        }
        DataInfoClass.isLoadFile = true;
        
    


    }
}
