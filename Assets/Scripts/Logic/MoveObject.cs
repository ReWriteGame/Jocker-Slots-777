using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
   [SerializeField] private Transform moveObject;

   public void MoveObjectInCurrentPosition()
   {
      moveObject.position = new Vector3(transform.position.x, transform.position.y, moveObject.position.z);
   }
}
