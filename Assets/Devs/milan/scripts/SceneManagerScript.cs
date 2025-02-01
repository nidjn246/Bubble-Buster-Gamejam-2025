using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] public int cleaneditems = 0;
    public void StartGame()
    {
        cleaneditems = 0;
        SceneManager.LoadScene("House 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {

        if (cleaneditems > 57)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);         
        }

        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {

            if (cleaneditems > 56)
            {
                int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextSceneIndex);
            }

        }
    }
}
