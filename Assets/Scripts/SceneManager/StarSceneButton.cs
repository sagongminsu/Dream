using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        SwitchScene(); 
    }
    private void SwitchScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
