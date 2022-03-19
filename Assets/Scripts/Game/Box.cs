using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Box : MonoBehaviour
{
    [SerializeField] private ItemEnum currentItem;


    public UnityEvent rightItemEvent;
    public UnityEvent wrongItemEvent;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Item>())
        {
            if (collision.gameObject.GetComponent<Item>().ItemValue == currentItem)
                rightItemEvent?.Invoke();
            else wrongItemEvent?.Invoke();
        }
      
    }
}
