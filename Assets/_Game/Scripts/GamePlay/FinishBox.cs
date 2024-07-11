using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StackMaker
{

    public class FinishBox : MonoBehaviour
    {
        public GameObject chestOpen;
        public GameObject chestClose;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {


                other.GetComponent<Player>().playerSkin.localPosition = new Vector3(0, 0, 4);
                other.GetComponent<Player>().ClearBrick();
                other.GetComponent<Player>().ChangeAnim("dance");

                chestClose.SetActive(false);
                chestOpen.SetActive(true);

                LevelManager.Ins.OnFinish();

            }
        }
    }
}

