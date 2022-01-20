using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PinGolf
{
    [CreateAssetMenu(menuName = "PinGolf/Ball/Speed Settings")]
    public class BallSettings : ScriptableObject
    {
        public float _minSpeed = 9f;
        public float _maxSped = 12f;
    }
}