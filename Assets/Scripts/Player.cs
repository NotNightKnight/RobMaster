using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobMaster
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private TimeUI timeUI;

        [SerializeField]
        private Camera myCamera;

        [SerializeField]
        private float movSpeed, stopTime;

        private float tempSpeed;

        private void Start()
        {
            tempSpeed = movSpeed;
        }

        private void Update()
        {
            var speed = movSpeed * Time.deltaTime * Vector3.forward;
            transform.position += speed;
            myCamera.transform.position += speed;
        }

        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.CompareTag("BeforeLaser"))
        //    {
        //        Stop();
        //        Invoke(nameof(Continue), stopTime);
        //    }
        //}

        public void Stop()
        {
            movSpeed = 0;
            timeUI.StartTimer();
        }
        public void Continue()
        {
            movSpeed = tempSpeed;
        }
        public float GetStopTime()
        {
            return stopTime;
        }
    }
}