using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobMaster
{
    public class PartMover : MonoBehaviour
    {
        [SerializeField]
        private float dragSpeed;

        [SerializeField]
        private float rotateSpeed;

        private float axisX;
        private float axisY;

        private bool arm;

        public void MovePart(Transform obj)
        {
            axisX = Input.GetAxis("Mouse X");
            axisY = Input.GetAxis("Mouse Y");

            if(obj.CompareTag("Head"))
            {
                MyMove(obj);
            }
            else if(obj.CompareTag("RightArm"))
            {
                arm = true;
                Rotate(obj, arm);
            }
            else if (obj.CompareTag("LeftArm"))
            {
                arm = true;
                Rotate(obj, arm);
            }
            else if (obj.CompareTag("RightLeg"))
            {
                arm = false;
                Rotate(obj, arm);
            }
            else if (obj.CompareTag("LeftLeg"))
            {
                arm = false;
                Rotate(obj, arm);
            }
        }

        private void MyMove(Transform obj)
        {
            obj.position += axisX * dragSpeed * Time.deltaTime * Vector3.right;
            obj.position += axisY * dragSpeed * Time.deltaTime * Vector3.up;
        }

        private void Rotate(Transform obj, bool isArm)
        {
            float newVal;
            if(isArm)
            {
                if(Mathf.Abs(axisX) > Mathf.Abs(axisY))
                {
                    newVal = rotateSpeed * axisX * Time.deltaTime;
                }
                else
                {
                    newVal = rotateSpeed * axisY * Time.deltaTime;
                }

                obj.Rotate(newVal, 0, 0);
            }
            else
            {
                if (Mathf.Abs(axisX) > Mathf.Abs(axisY))
                {
                    newVal = rotateSpeed * axisX * Time.deltaTime;
                }
                else
                {
                    newVal = rotateSpeed * axisY * Time.deltaTime;
                }

                obj.Rotate(0, 0, newVal);
            }
        }
    }
}