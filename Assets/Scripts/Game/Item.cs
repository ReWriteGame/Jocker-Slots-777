using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemEnum item;

    public ItemEnum ItemValue { get => item; set => item = value; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Box>())
            gameObject.GetComponent<Destroyable>().Destroy();
    }
}
