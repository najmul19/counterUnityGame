using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CounterManager : MonoBehaviour
{
    public Text counterText;
    private int counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        counter = PlayerPrefs.GetInt("counter", 0);
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Increment() {
        counter++;
        Check();
    }

    public void Decrement() {
        counter--;
        Check();
    }
    void Check() {
        PlayerPrefs.SetInt("counter", counter);
        UpdateUI();
        if(counter>=10) {
            SceneManager.LoadScene("Congratulations");
        }
    }
    void UpdateUI(){
        counterText.text = counter.ToString();
    }
}

