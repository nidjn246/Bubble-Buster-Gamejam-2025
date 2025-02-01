using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] public int cleaneditems = 0;
    private AudioSource bgmusic;
    public void StartGame()
    {
        cleaneditems = 0;
        SceneManager.LoadScene("House 1");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("main menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {

        if (cleaneditems > 57)
        {
                //DontDestroyOnLoad(gameObject);
                //bgmusic = GetComponent<AudioSource>();
                //bgmusic.Play();
                int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);         
        }

        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {

            if (cleaneditems > 55)
            {
                //bgmusic = GetComponent<AudioSource>();
                //bgmusic.Play();
                //DontDestroyOnLoad(gameObject);
                int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextSceneIndex);
            }

        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {

            if (cleaneditems > 49)
            {
                //bgmusic = GetComponent<AudioSource>();
                //bgmusic.Play();
                //DontDestroyOnLoad(gameObject);
                int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextSceneIndex);
                //Cursor.lockState = CursorLockMode.None;
                //Cursor.visible = true;
            }

        }

    }
}
