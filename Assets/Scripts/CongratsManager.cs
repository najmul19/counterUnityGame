using UnityEngine;
using UnityEngine.UI;
public class CongratsManager : MonoBehaviour
{
    public Text congratsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = PlayerPrefs.GetString("username", "User");
        congratsText.text = "Congratulations, " + name + " You reached 10";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
