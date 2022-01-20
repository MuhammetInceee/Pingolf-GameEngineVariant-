using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PinGolf.Controller
{
    [CreateAssetMenu(menuName = "PinGolf/Flipper/Movement Settings")]
    public class FlipperControllerSettings : ScriptableObject
    {
        public float _torqueForce;
    }
}