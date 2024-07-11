using StackMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brigde : MonoBehaviour
{
        public GameObject brigde;

        private bool isCollect = false;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !isCollect)
            {
                Player player = other.GetComponent<Player>();
                isCollect = true;
                brigde.SetActive(true);
                player.RemoveBrick();
            }
        }
}

