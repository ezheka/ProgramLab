using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Observers.Main
{
    public class Observer : MonoBehaviour
    {
        public static Observer Singleton { get; private set; }

        public event Action ObserverCall;

        private void Start()
        {
            InitSingleton();

            Component[] _publishersM = FindObjectsOfType(typeof(Component)) as Component[];
            List<Component> _publishers = _publishersM.ToList();

            Debug.Log("Количество Publisher на сцене = "+_publishers.Count);
        }

        

        private void InitSingleton()
        {
            Singleton = this;
        }

        
    }
}
