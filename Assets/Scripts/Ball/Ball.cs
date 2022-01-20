using UnityEngine;
using System.Collections;

namespace PinGolf
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private BallSettings _ballSettings;
        [SerializeField] private GameObject _flag;

        public static UIManager _managerUI;
        public new Rigidbody2D rigidbody;

        private void Start()
        {
            _managerUI = FindObjectOfType<UIManager>();
        }
        void Update()
        {
            BallSpeed();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Flag"))
            {
                RandomSpawnFlag();
                Counter._score++;
            }
            else if (other.CompareTag("Lose"))
            {
                _managerUI.Lose();
            }
        }

        void RandomSpawnFlag()
        {
            float randomX = Random.Range(-1.9f, 1.7f);
            float randomY = Random.Range(0, 4);

            _flag.transform.position = new Vector3(randomX, randomY, 0);
        }

        void BallSpeed()
        {
            if (rigidbody.velocity.magnitude < _ballSettings._minSpeed)
            {
                rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, _ballSettings._minSpeed);
            }

            if (rigidbody.velocity.magnitude > _ballSettings._maxSped)
            {
                rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, _ballSettings._maxSped);
            }
        }
    }
}