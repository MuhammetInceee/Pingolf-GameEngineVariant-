using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace PinGolf
{
    public class UIManager : MonoBehaviour
    {

        [SerializeField] private GameObject _loginScreen;
        [SerializeField] private GameObject _gameplayScreen;
        [SerializeField] private GameObject _settingsScreen;
        [SerializeField] private GameObject _winEnded;
        [SerializeField] private GameObject _loseEnded;


        [SerializeField] private GameObject _ball;
        [SerializeField] private GameObject _flag;

        private void Start()
        {
            _flag.SetActive(true);
            _loginScreen.SetActive(true);
            _gameplayScreen.SetActive(false);
            _settingsScreen.SetActive(false);
            _winEnded.SetActive(false);
        }

        public void StartGame()
        {
            Time.timeScale = 1f;
            _loginScreen.SetActive(false);
            _gameplayScreen.SetActive(true);
            _ball.SetActive(true);
        }
        public void Settings()
        {
            Time.timeScale = 0f;
            _loginScreen.SetActive(false);
            _settingsScreen.SetActive(true);
            _flag.SetActive(false);
        }
        public void CloseSettings()
        {
            Time.timeScale = 1f;
            _settingsScreen.SetActive(false);
            _loginScreen.SetActive(true);
            _flag.SetActive(true);
        }
        public void RestartGame()
        {
            Counter._score = 0;
            Counter.startTime = 61;
            SceneManager.LoadScene(0);
        }
        public void Lose()
        {
            Time.timeScale = 0f;
            _flag.SetActive(false);
            _ball.SetActive(false);
            _gameplayScreen.SetActive(false);
            _loseEnded.SetActive(true);
        }
        public void SettingsWin()
        {
            Time.timeScale = 0f;
            _ball.transform.position = new Vector3(-0.83f, 0.54f, -2.039551f);
            _winEnded.SetActive(false);
            _settingsScreen.SetActive(true);
        }
        public void SettingsLose()
        {
            Time.timeScale = 0f;
            _ball.transform.position = new Vector3(-0.83f, 0.54f, -2.039551f);
            _loseEnded.SetActive(false);
            _settingsScreen.SetActive(true);
        }
    }
}