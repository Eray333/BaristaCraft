using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public void BackButton ()

        
    {
        Debug.Log("Back button çalýþtý");

        SceneManager.LoadScene("MenuScene");
    }
}
