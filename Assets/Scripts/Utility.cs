using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utility 
{

    public class PlayerProfile
    {
        Text playerName;

        public void ResetData()
        {
            playerName.text =" " ;
        }
    }
   public static string GetPlayerName()
    {
        return PlayerPrefs.GetString(MainMenuManager.playerName);
    }
}
