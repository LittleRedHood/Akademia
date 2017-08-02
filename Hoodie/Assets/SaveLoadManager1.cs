using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public static class  SaveLoadManager {
    public static void SavePlayer(Player Player) {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/player.sav", FileMode.Create);

        PlayerData data = new PlayerData(Player);
        bf.Serialize(stream, data);
        stream.Close();

    }

    public static PlayerData LoadPlayer(Player Player)
    {
        if(File.Exists(Application.persistentDataPath + "/player.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/player.sav", FileMode.Open);

            PlayerData data = bf.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
  
        }
        else
        {
            Debug.LogError("The file does not exist.");
            PlayerData dataEmpty = new PlayerData(Player);
            return dataEmpty;
        }
        
    }
}
	

[Serializable]
public class PlayerData
{

    private float positionX, positionY, positionZ, playerTime;
    private int playerPoints, playerLives, playerLvl;
    private bool yellowKey, greenKey, redKey;
    
    public float getPositionX()
    {
        return positionX;
    }
    public float getPositionY()
    {
        return positionY;
    }
    public float getPositionZ()
    {
        return positionZ;
    }
    public float getPlayerTime()
    {
        return playerTime;
    }
    public int getPlayerPoints()
    {
        return playerPoints;
    }
    public int getPlayerLives()
    {
        return playerLives;
    }
    public int getPlayerLvl()
    {
        return playerLvl;
    }
    public bool getYellowKey()
    {
        return yellowKey;
    }
    public bool getGreenKey()
    {
        return greenKey;
    }
    public bool getRedKey()
    {
        return redKey;
    }
    public PlayerData(Player player)
    {
        positionX = player.transform.position.x;
        positionY = player.transform.position.y;
        positionZ = player.transform.position.z;
        playerPoints = Player.points;
        playerTime = Player.timer;
        playerLives = Player.lifeAmount;
        playerLvl = Player.currentLvl;
        yellowKey = Player.yellow_key;
        redKey = Player.red_key;
        greenKey = Player.green_key;

    }
}


