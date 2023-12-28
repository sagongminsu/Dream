using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // 마우스 우 클릭 시 호출될 함수
    private void Update()
    {

 
        if (Input.GetMouseButtonDown(1)) 
        {
            SwitchScene();  
        }

    }

    // 다른 씬으로 전환하는 함수
    private void SwitchScene()
    {

        SceneManager.LoadScene("MainScene");
    }
}