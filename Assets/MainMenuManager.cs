using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public void GoToScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
