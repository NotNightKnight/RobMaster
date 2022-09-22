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
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("BeforeLaser"))
            {
                player.Stop();
                Invoke(nameof(Continue), player.GetStopTime());
            }
        }

        private void Continue()
        {
            player.Continue();
        }
    }
}