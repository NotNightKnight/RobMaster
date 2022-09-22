using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RobMaster
{
    public class EndLevelUI : MonoBehaviour
    {
        public void OnClickRestart()
        {
            SceneManager.LoadScene(sceneName: "RobMaster");
            Time.timeScale = 1;
        }
    }
}