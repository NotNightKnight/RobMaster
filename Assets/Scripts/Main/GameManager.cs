using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobMaster
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private CanvasGroup endLevelPanel;

        [SerializeField]
        private Button nextBtn;

        private bool isDead;

        public void EndLevel(bool dead)
        {
            isDead = dead;
            OpenEndLevelPanel();
        }

        private void OpenEndLevelPanel()
        {
            Time.timeScale = 0;

            endLevelPanel.alpha = 1;
            endLevelPanel.interactable = true;
            endLevelPanel.blocksRaycasts = true;

            if(isDead)
            {
                nextBtn.interactable = false;
            }
        }
    }
}