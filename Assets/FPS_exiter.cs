﻿using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            MSController.SetCursorLock(false);
            ReturnToMainScene();
        }
    }

    public void ReturnToMainScene()
    {
        SceneManager.LoadScene("scene-MainMenu");
    }
}
