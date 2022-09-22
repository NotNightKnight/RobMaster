using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobMaster
{
    public class GameManager : MonoBehaviour
    {
        private bool isDead;

        public void EndLevel(bool dead)
        {
            isDead = dead;
            OpenEndLevelPanel();
        }

        private void OpenEndLevelPanel()
        {
            Time.timeScale = 0;
        }
    }
}