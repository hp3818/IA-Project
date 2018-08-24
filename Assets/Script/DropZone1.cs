using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone1 : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    public static int childCount = 33;
    public static GameObject droppedObject;
    public static int count;
    public static GameObject orience;
    public static int doing = 0;

    void Update()
    {
        childCount = this.transform.childCount;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.placeholderParent = transform;
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null && d.placeholderParent == this.transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Card.i = 1;
        Card.runOnce = false;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        
        if (Input.touchCount == 1)
        {
            if (d != null && doing == 0)
            {
                d.parentToReturnTo = transform;
            }
        }
        
        /*
        if (d != null && doing == 0)
        {
            d.parentToReturnTo = transform;
        }
        */
    }

}

