using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class FollowPlayer : MonoBehaviour
    {
        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            if (player == null)
            {
                return;
            }
            Vector3 target = player.transform.position + new Vector3(0, 0.61f, -5.452f);
            transform.position = target;
        }
    }
}