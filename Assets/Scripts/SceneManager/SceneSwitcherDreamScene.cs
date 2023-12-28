
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherDreamScene : MonoBehaviour
{
    public string dreamSceneName = "DreamScene";

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.CompareTag("Bed"))
                {

                    SwitchToDreamScene();
                }
            }
        }
    }


    private void SwitchToDreamScene()
    {
        SceneManager.LoadScene(dreamSceneName);
    }
}
