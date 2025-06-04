using UnityEngine;
using TMPro; // TextMeshPro desteði

using UnityEngine.SceneManagement;

public class StoreNameManager : MonoBehaviour
{
    public TMP_InputField storeNameInputField; // TMP kullanýyoruz
    public TMP_Text displayStoreNameText;

    public void SetStoreName()
    {
        string storeName = storeNameInputField.text;

        if (!string.IsNullOrEmpty(storeName))
        {
            displayStoreNameText.text = "Dükkan Adýnýz: " + storeName;
            PlayerPrefs.SetString("StoreName", storeName);
            SceneManager.LoadScene("Game"); // sahne adýn buysa
        }
        else
        {
            displayStoreNameText.text = "Lütfen bir ad girin!";
        }
    }
}
