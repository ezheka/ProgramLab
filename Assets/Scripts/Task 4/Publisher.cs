using UnityEngine;
using Observers.Main;


public class Publisher : MonoBehaviour
{

    private void Start()
    {
        Observer.Singleton.ObserverCall += EventStart;
    }

    public void EventStart()
    {

    }
}


