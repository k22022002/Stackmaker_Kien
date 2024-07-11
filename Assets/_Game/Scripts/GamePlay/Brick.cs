using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StackMaker
{

    public class Brick : MonoBehaviour
    {
        public GameObject brick;
        private bool isCollect = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !isCollect)
            {
                isCollect = true;
                brick.SetActive(false);
                other.GetComponent<Player>().AddBrick();
            }
        }
    }
}