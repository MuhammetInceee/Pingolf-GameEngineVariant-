using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PinGolf
{
    public class Counter : MonoBehaviour
    {
        [SerializeField] private Text _timerText;
        [SerializeField] private Text _scoreText;

        public static float startTime = 61;
        public static int _score = 0;
        void Update()
        {
            _scoreText.text = "" + _score;
            startTime -= Time.deltaTime;
            DisplayTime(startTime);
            TimeIsUp();
        }

        void DisplayTime(float timeToDisplay)
        {
            if (timeToDisplay < 0)
            {
                timeToDisplay = 0;
            }

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            _timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        void TimeIsUp()
        {
            if(startTime <= 0)
            {
                Debug.Log("asdasd");
                Ball._managerUI.Lose();
            }
        }
    }
}