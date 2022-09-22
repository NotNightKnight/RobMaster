using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobMaster
{
    public class Part : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;

        [SerializeField]
        private Player player;

        [SerializeField]
        private PartMover partMover;

        private float delayTime;

        private void OnMouseDrag()
        {
            partMover.MovePart(this.transform);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.transform.CompareTag("Laser"))
            {
                gameManager.EndLevel(true);
            }
            else if(collision.transform.CompareTag("FinishLine"))
            {
                gameManager.EndLevel(false);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("BeforeLaser"))
            {
                Invoke(nameof(Stop), delayTime);
                Invoke(nameof(Continue), player.GetStopTime() + delayTime);
                other.enabled = false;
            }
        }

        private void GetPlayTime()
        {
            delayTime = player.GetDelayTime();
        }

        private void Stop()
        {
            player.Stop();
        }

        private void Continue()
        {
            player.Continue();
        }
    }
}