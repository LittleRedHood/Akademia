using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {
    public void OnMouseUp()
    {
        Application.LoadLevel("nickname");
        PlayerLife.gameOver = false;
    }
}
