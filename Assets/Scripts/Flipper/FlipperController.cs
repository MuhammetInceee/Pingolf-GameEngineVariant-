using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PinGolf.Controller
{
    public class FlipperController : MonoBehaviour
    {
        [SerializeField] private FlipperControllerSettings _flipperControllerSettings;
        [SerializeField] private GameObject _leftFlipper;
        [SerializeField] private GameObject _rightFlipper;
        private Rigidbody2D _rightFlipperRigid;
        private Rigidbody2D _leftFlipperRigid;

        //public GameObject obstaclePrefab;
        void Start()
        {
            Application.targetFrameRate = 60;
            Time.timeScale = 0f;
            _leftFlipperRigid = _leftFlipper.GetComponent<Rigidbody2D>();
            _rightFlipperRigid = _rightFlipper.GetComponent<Rigidbody2D>();

            //GameObject asdas = Instantiate(obstaclePrefab, new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 200.1552f), Quaternion.identity);
        }

        void FixedUpdate()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mouseInput = Input.mousePosition;
                //Flipping right
                if (mouseInput.x >= Screen.width / 2f)
                {
                    AddTorque(_rightFlipperRigid, -_flipperControllerSettings._torqueForce);
                }

                //Flipping left
                if (mouseInput.x < Screen.width / 2f)
                {
                    AddTorque(_leftFlipperRigid, _flipperControllerSettings._torqueForce);
                }
            }
            else if (Input.GetMouseButton(0))
            {
                Vector3 mouseHolding = Input.mousePosition;

                //Holding right
                if (mouseHolding.x >= Screen.width / 2f)
                {
                    AddTorque(_rightFlipperRigid, -_flipperControllerSettings._torqueForce);
                }

                //Holdding left
                if (mouseHolding.x < Screen.width / 2f)
                {
                    AddTorque(_leftFlipperRigid, _flipperControllerSettings._torqueForce);
                }
            }
        }
        void AddTorque(Rigidbody2D rigid, float force)
        {
            rigid.AddTorque(force);
        }
    }
}