using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject loadImage;

    public void NewGame (string sceneName)
    {
        //GameObject.Find("Dif").SetActive(true);
        loadImage.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }

    public void Options(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(5);
    }
}
