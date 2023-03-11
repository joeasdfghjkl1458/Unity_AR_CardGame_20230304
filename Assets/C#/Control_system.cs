using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    public class Control_system : MonoBehaviour
    {
        [SerializeField, Header("�ؼЪ���")]
        private Transform target;

        private void Update()
        {
            LookAtTarget();
        }

        private void LookAtTarget()
        {
            transform.LookAt(target);

            transform.eulerAngles= new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}

