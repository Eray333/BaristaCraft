using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    

    public void PlayButton ()
    {

        Debug.Log("Play button �al��t�");

        SceneManager.LoadScene("GameScene");

    }
    
    public void OptionsButton()
    {
        Debug.Log("Options button �al��t�");

    }
    

        

    }
        
}
