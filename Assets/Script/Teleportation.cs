using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
   public Transform player;
   public void Teleport()
   {
       Vector3 move = new Vector3(0, 800, 0);
       player.position = move;
   }
}
