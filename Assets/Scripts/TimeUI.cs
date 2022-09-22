using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RobMaster
{
    public class TimeUI : MonoBehaviour
    {
        [SerializeField]
        private Player player;

        private float stopTime;

        private bool startTimer = false;

        [SerializeField]
        private TextMeshProUGUI moneyTMP;

        private void Update()
        {
            if(startTimer)
            {
                stopTime -= Time.deltaTime;
                moneyTMP.text = ((int)stopTime).ToString();
                if(stopTime < 0)
                {
                    startTimer = false;
                }
            }
        }

        public void StartTimer()
        {
            stopTime = player.GetStopTime();
            startTimer = true;
        }
    }
}