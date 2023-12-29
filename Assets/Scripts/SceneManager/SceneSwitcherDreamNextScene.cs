using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherDreamNextScene : MonoBehaviour
{
    public Transform player; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DetectClick();
        }
    }

    private void DetectClick()
    {
       
        Ray ray = new Ray(player.position, player.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Bed2"))
            {
                SwitchDreamNextScene();
            }
        }
    }

    private void SwitchDreamNextScene()
    {
        SceneManager.LoadScene("DreamNextScene");
    }
}
