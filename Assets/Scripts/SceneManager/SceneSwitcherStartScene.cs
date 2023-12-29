using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherStartScene : MonoBehaviour
{

    void Start()
    {
 
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchStartScene();  
        }
    }


    private void SwitchStartScene()
    {

        SceneManager.LoadScene("StartScene");
    }
}
