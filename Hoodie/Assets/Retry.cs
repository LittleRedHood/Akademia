using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour {

    private void OnMouseUp()
    {
        Application.LoadLevel("lvl_1");
        PlayerLife.gameOver = false;
        DataInfoClass.isLoadFile = false;
    }

}
