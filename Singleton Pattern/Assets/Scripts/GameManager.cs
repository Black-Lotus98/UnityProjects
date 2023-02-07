using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime sessionStartTime;
    private DateTime sessionEndTime;

    void Start()
    {
        sessionStartTime = DateTime.Now;
        Debug.Log("Game Session start time: " + DateTime.Now);
    }
    private void OnApplicationQuit()
    {
        sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = sessionEndTime.Subtract(sessionStartTime);
        Debug.Log("Game Session start time: " + DateTime.Now);
        Debug.Log("Game Session lasted: " + timeDifference);

    }

    private void OnGUI()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int NextSceneIndex = CurrentSceneIndex + 1;
        if (NextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            NextSceneIndex = 0;
        }

        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(NextSceneIndex);
        }
    }

}

