﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeToScene(int changeScene)
    {
        SceneManager.LoadScene(changeScene);
    }
}
