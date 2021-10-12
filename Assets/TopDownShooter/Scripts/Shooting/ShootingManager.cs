using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Shooting
{
    public class ShootingManager : MonoBehaviour
    {
       
        public void Shoot(Vector3 from,Vector3 direction)
        {
            RaycastHit hit;

           bool rayhit= Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);



        }

    }


}
