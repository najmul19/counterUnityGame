using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WelcomeManager : MonoBehaviour
{
    public InputField nameInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        PlayerPrefs.DeleteAll();
        if (PlayerPrefs.HasKey("username")) {
            SceneManager.LoadScene("Counter");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnContinue() {
        string username=nameInput.text;
        if (!string.IsNullOrEmpty(username)) {
            PlayerPrefs.SetString("username", username);
            SceneManager.LoadScene("Counter");
        }
    }
}


