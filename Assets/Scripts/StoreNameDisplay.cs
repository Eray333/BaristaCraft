using UnityEngine;
using TMPro;

public class StoreNameDisplay : MonoBehaviour
{
    public TMP_Text storeNameText;

    void Start()
    {
        string storeName = PlayerPrefs.GetString("StoreName", "Dükkaným");
        storeNameText.text = storeName;
    }
}
