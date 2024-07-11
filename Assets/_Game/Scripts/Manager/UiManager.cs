using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StackMaker
{
    public class UIManager : Singleton<UIManager>
    {
        public GameObject mainMenuUI;
        public GameObject finishUI;
        public GameObject comingSoonUI;

        public Text currentlevel;
        public Text score;

        public void OpenMainMenuUI()
        {
            mainMenuUI.SetActive(true);
            finishUI.SetActive(false);
            comingSoonUI.SetActive(false);

            currentlevel.text = "Level " + LevelManager.Ins.level.ToString();
        }

        public void OpenFinishUI()
        {
            mainMenuUI.SetActive(false);
            finishUI.SetActive(true);
            comingSoonUI.SetActive(false);
            score.text = LevelManager.Ins.GetScore().ToString();
        }

        public void OpenComingSoonUI()
        {
            mainMenuUI.SetActive(false);
            finishUI.SetActive(false);
            comingSoonUI.SetActive(true);

        }

        public void PlayButton()
        {
            mainMenuUI.SetActive(false);
            LevelManager.Ins.OnStart();

        }

        public void RetryButton()
        {
            LevelManager.Ins.LoadLevel();
            GameManager.Ins.ChangeState(GameState.MainMenu);
            OpenMainMenuUI();
        }

        public void NextButton()
        {
            if (LevelManager.Ins.CheckNextLevel())
            {
                LevelManager.Ins.NextLevel();
                GameManager.Ins.ChangeState(GameState.MainMenu);
                OpenMainMenuUI();
            }
            else
            {
                GameManager.Ins.ChangeState(GameState.Finish);
                OpenComingSoonUI();
            }
        }
    }
}

