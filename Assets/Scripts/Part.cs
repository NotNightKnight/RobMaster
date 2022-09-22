using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobMaster
{
    public class Part : MonoBehaviour
    {
        [SerializeField]
        private PartMover partMover;

        private void OnMouseDrag()
        {
            partMover.MovePart(this.transform);
        }
    }
}