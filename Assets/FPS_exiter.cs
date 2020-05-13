using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPS_exiter : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.MouseLook MSController;
    // Start is called before the first frame update
    void Start()
    {
        MSController.SetCursorLock(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            MSController.SetCursorLock(false);
            ReturnToMainScene();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Destroy(this.gameObject);
        }
    }

    public void ReturnToMainScene()
    {
        SceneManager.LoadScene("scene-MainMenu");
    }
}
