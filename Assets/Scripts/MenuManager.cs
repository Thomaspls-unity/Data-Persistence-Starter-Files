using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public InputField userName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("UserName", userName.text);

        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
