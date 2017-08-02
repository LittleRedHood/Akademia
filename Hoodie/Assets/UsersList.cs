using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsersList : MonoBehaviour {

    public static List<User> usersList = new List<User>();
    public static int howManyUsers = 0;
    private User user;
    void Start () {
		
	}
	

	void Update () {

        if (DataInfoClass.addUser)
        {
            addToList();
            DataInfoClass.addUser = false;
        }

    }
    public void addToList()
    {
        howManyUsers++;
        user = new User();
        user.setNickname( NameSaveOnClick.userName);
        user.setPoints( Player.points);
        usersList.Add(user);

    }
}
