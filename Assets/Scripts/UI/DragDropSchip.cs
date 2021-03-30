using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropSchip : MonoBehaviour, IDragHandler, /*IEndDragHandler,*/ IBeginDragHandler
{
    [SerializeField]
    private GameObject _ship;
    private GameObject _target;

    public void OnBeginDrag(PointerEventData eventData)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            _target = Instantiate(_ship, hit.point, _ship.transform.rotation);
            Debug.Log("Begin");
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        int layermask = 1 << 7;
        layermask = ~layermask;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layermask))
        {
            _target.transform.position = hit.point;
        }
    }

    /*public void OnEndDrag(PointerEventData eventData)
    {
        Drop();
    }

    private void Drop()
    {
        int LayerMask = 1 << 4;
        RaycastHit hit;
        Debug.Log(Input.mousePosition);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask))
        {
            Instantiate(_ship, hit.point, _ship.transform.rotation);
            Destroy(_target);
        }
        //transform.localPosition = Vector3.zero;
    }*/
}
