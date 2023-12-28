using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherMainScene : MonoBehaviour
{
    public string MainSceneName = "MainScene";

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            DetectClick();
        }
    }
    private void DetectClick()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.CompareTag("Bed2"))
                {

                    SwitchToMainScene();
                }
            }
        }
    }
    private void SwitchToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
