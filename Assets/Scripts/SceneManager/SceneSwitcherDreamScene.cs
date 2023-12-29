
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherDreamScene : MonoBehaviour
{


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

                    SwitchDreamScene();
                }
            }
        }
    }


    private void SwitchDreamScene()
    {
        SceneManager.LoadScene("DreamScene");
    }
}
