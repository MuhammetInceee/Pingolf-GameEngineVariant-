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
        [SerializeField] private Text _coinText;

        [SerializeField] private CoinSettings _coinSettings;

        [SerializeField] private Image _redDot;

        public static float startTime = 61;
        public static int _score = 0;
        void Update()
        {
            _scoreText.text = "" + _score;
            _coinText.text = "Coin : " + _coinSettings.coinCount;

            startTime -= Time.deltaTime;
            _coinSettings.giftCounter -= Time.deltaTime;

            DisplayTime(startTime);
            TimeIsUp();
            GiftTimer();
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
                _coinSettings.coinCount += (_score * 2);
            }
        }

        public void Gift()
        {
            if (_coinSettings.giftCounter == 0)
            {
                _coinSettings.coinCount += 25;
                _coinSettings.giftCounter = 150;
                _redDot.rectTransform.anchoredPosition = new Vector2(-110, 24);
                Debug.Log("25 coins add by gifter");
            }
        }

        void GiftTimer()
        {
            if(_coinSettings.giftCounter <= 0)
            {
                _coinSettings.giftCounter = 0;
                _redDot.rectTransform.anchoredPosition = new Vector2(22, 24);
            }
        }
    }
}