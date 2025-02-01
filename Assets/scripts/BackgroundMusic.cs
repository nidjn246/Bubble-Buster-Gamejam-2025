using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource bgmusic;

    private void Awake()
    {
        bgmusic = GetComponent<AudioSource>();
        bgmusic.Play();
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("main menu");
    }
}
