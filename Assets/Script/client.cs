using UnityEngine.UIElements;

namespace Script
{
    using System.Collections;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    using TMPro;
    using UnityEngine.UI;
    using static PlayerScript;
    using static TextActionJoueur1;
    using static System.Math;
   
    public class client : MonoBehaviour
    {
        public GameObject Client;
        public float x;
        public float y;

        void Start()
        {
            x = 300;
            y = 300;
        }
        void Update()
        {
            System.Random aleatoire = new System.Random();
            float X = aleatoire.Next(10); 
            float Y = aleatoire.Next(10);
            Vector3 move = new Vector3(x+X, x+Y, 0);
            if (X % 2 == 0)
            {
                move = new Vector3(x-X, x-Y, 0);
            }
            
            Client.transform.position = move;
        }
    }
}