using UnityEngine;
using UnityEngine.UI;

public class StoreNameManager : MonoBehaviour
{
    public InputField storeNameInputField;  // InputField referansý
    public Text displayStoreNameText;  // Dükkan adýný gösteren metin

    public void SetStoreName()
    {
        string storeName = storeNameInputField.text;

        if (!string.IsNullOrEmpty(storeName))  // Dükkan adý boþ deðilse
        {
            displayStoreNameText.text = "Dükkan Adýnýz: " + storeName;
            PlayerPrefs.SetString("StoreName", storeName);  // Dükkan adýný kaydet
            // Dükkan adýný kaydettikten sonra, baþka bir sahneye geçiþ yapabilirsin
            // SceneManager.LoadScene("MainGameScene");  // Yani oyun sahnesine geç
        }
        else
        {
            displayStoreNameText.text = "Lütfen bir ad girin!";
        }
    }
}
