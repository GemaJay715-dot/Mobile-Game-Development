using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void Test()
    {
        Debug.Log("TEST WORKS");
    }


    public void BackToMenu()
    {
        Debug.Log("Menu button clicked");
        SceneManager.LoadScene("SampleScene");
    }

}
