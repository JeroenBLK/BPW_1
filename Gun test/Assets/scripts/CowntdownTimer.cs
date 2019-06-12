using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CowntdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 30f;
    AudioSource myAudio;

    [SerializeField] Text countdownText;

    private void Start()
    {
        currentTime = startingTime;

        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(19.0f);
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if(currentTime <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if(currentTime <= 10)
        {
            countdownText.color = Color.red;
            
        }
    }

}
