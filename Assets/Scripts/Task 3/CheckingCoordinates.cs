using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckingCoordinates : MonoBehaviour
{
    public GameObject Panel, gameObject_1, gameObject_2;
    
    void Update()
    {
        Vector3 positionGameObject_1 = Camera.main.WorldToViewportPoint(gameObject_1.transform.position);
        Vector3 positionGameObject_2 = Camera.main.WorldToViewportPoint(gameObject_2.transform.position);

        // Не смог расчитать координаты верхнего левого угла панели, поэтому прописал вручную 
        if ((positionGameObject_1.x < 0.5f) && (positionGameObject_1.x > 0))
        {
            if ((positionGameObject_1.y < 1f) && (positionGameObject_1.y > 0))
            {
                gameObject_1.GetComponent<ClickOnObject>().CanPaint = false;
            }
            else gameObject_1.GetComponent<ClickOnObject>().CanPaint = true;
        }
        else gameObject_1.GetComponent<ClickOnObject>().CanPaint = true;

        // Не смог расчитать координаты верхнего левого угла панели, поэтому прописал вручную
        if ((positionGameObject_2.x < 0.5f) && (positionGameObject_2.x > 0))
        {
            if ((positionGameObject_2.y < 1f) && (positionGameObject_2.y > 0))
            {
                gameObject_2.GetComponent<ClickOnObject>().CanPaint = false;
            }
            else gameObject_2.GetComponent<ClickOnObject>().CanPaint = true;
        }
        else gameObject_2.GetComponent<ClickOnObject>().CanPaint = true;



    }
}
