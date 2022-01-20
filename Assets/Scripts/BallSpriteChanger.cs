using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpriteChanger : MonoBehaviour
{
    [SerializeField] private CoinSettings _coinSettings;
    [SerializeField] private BallSpriteChangerSettings _changerSettings;
    [SerializeField] private GameObject _ball;


    [SerializeField] private Sprite _defaultSprite;
    [SerializeField] private Sprite _redSprite;
    [SerializeField] private Sprite _blueSprite;

    public Sprite currentSprite;

    public void WhiteBall()
    {
        currentSprite = _defaultSprite;
        Debug.Log("White Ball Activated");
    }

    public void RedBall()
    {
        if (_changerSettings.isRedLocked)
        {
            if (_coinSettings.coinCount >= 100)
                _coinSettings.coinCount -= 100;
            else
                return;

            _changerSettings.isRedLocked = false;
        }
        else
        {
            currentSprite = _redSprite;
            Debug.Log("Red Ball Activated");
        }
    }

    public void BlueBall()
    {
        if (_changerSettings.isBlueLocked)
        {
            if (_coinSettings.coinCount >= 100)
                _coinSettings.coinCount -= 100;
            else
                return;

            _changerSettings.isBlueLocked = false;
        }
        else
        {
            currentSprite = _blueSprite;
            Debug.Log("Blue Ball Activated");
        }
    }

}
