using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // ���콺 �� Ŭ�� �� ȣ��� �Լ�
    private void Update()
    {

 
        if (Input.GetMouseButtonDown(1)) 
        {
            SwitchScene();  
        }

    }

    // �ٸ� ������ ��ȯ�ϴ� �Լ�
    private void SwitchScene()
    {

        SceneManager.LoadScene("MainScene");
    }
}