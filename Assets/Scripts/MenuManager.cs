using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Load(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
