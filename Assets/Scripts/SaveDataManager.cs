using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveDataManager : MonoBehaviour
{
    public Text playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        string userName = PlayerPrefs.GetString("UserName", "Mystery Player");

        playerNameText.text = userName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
