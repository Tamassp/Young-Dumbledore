using System;
using UnityEngine;

namespace Unity.Template.VR
{
    public class ProjectileLauncher: MonoBehaviour
    {
        public GameObject projectile;
        public float launchVelocity = 700f;
        private void Update()
        {
            if (!Input.GetButtonDown("Fire1")) return;
            var transform1 = transform;
            var ball = Instantiate(projectile, transform1.position, transform1.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
        }
    }
}