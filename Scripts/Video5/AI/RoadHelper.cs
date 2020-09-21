using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleCity.AI
{
    public class RoadHelper : MonoBehaviour
    {
        [SerializeField]
        protected List<Marker> pedestrianMarkers;
        [SerializeField]
        protected bool isCorner;
        [SerializeField]
        protected bool hasCrosswalks;
        
    }
}

