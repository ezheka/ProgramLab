using UnityEngine;
using UnityEngine.EventSystems;

public class ClickOnObject : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool CanPaint = true;

    private bool _isDown, _leftButton;

    private void Start()
    {
        RandomColor(gameObject.GetComponent<MeshRenderer>().material);
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            _leftButton = true;
            Movement(_isDown);
        }
        else _leftButton = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isDown = true;

        if (_leftButton && CanPaint)
        {
            RandomColor(gameObject.GetComponent<MeshRenderer>().material);            
        }        

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isDown = false;
    }  

    public void RandomColor(Material material)
    {
        var r = Random.Range(0f, 1f);
        var g = Random.Range(0f, 1f);
        var b = Random.Range(0f, 1f);
        material.color = new Color(r, g, b);
    }

    public void Movement(bool isDown)
    {
        if (isDown)
        {
            Ray _ray;
            RaycastHit _hit;

            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(_ray, out _hit))
            {
                transform.position = new Vector3(_hit.point.x, _hit.point.y, transform.position.z);
            }
        }
        
    }

}
