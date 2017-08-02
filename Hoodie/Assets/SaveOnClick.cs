using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOnClick : MonoBehaviour {
    public Player player;

    public void OnMouseUp()
    {

       player.Save();
        DataInfoClass.lvlNumber = Player.currentLvl;



    }
}
