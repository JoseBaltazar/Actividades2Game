using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {

    public Transform mainMenu, optionsMenu, difficultMenu;

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OptionsMenu(bool onclicked)
    {
        if (onclicked == true)
        {
            optionsMenu.gameObject.SetActive(onclicked);
            mainMenu.gameObject.SetActive(false);
        }
        else {
            optionsMenu.gameObject.SetActive(onclicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void SelectDifficult(bool onclicked)
    {
        if (onclicked == true)
        {
            difficultMenu.gameObject.SetActive(onclicked);
            mainMenu.gameObject.SetActive(false);
        }
        else {
            difficultMenu.gameObject.SetActive(onclicked);
            difficultMenu.gameObject.SetActive(true);
        }
    }
}
