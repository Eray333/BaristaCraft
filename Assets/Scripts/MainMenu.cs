using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("TutorialScene");  // Burada "TutorialScene" sahnesi adýyla geçiþ yapýyoruz
    }
}

