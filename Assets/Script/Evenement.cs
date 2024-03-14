using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;


public class Evenement 
{
    public Dictionary<string,(double,double,double)> _event { get; set; }//nom evenement ; multiplicateur de bénéfice ; multiplicateur d'attractivité ; chance d'apparition;
    public List<string> _eventComing { get; set; } // nom des évènements à venir;
    
    public static List<string> aVenir(Dictionary<string, (double, double, double)> evenement)
    {
        List<string> fin = new List<string>();
        System.Random aleatoire = new System.Random();
        for (int i = 0; i < 20; i++)
        {
            foreach ((string nom ,(double benef,double pop,double chance)) in evenement)
            {
                int a = aleatoire.Next(0,100);
                if (a < chance)
                {
                    fin.Add(nom);
                }
            }
        }

        return fin;
    }

    public Evenement()
    {
        _event = new Dictionary<string, (double, double, double)>()
        {
            { "Jeux Olympiques", (2, 2, 5) },
            { "Fashion Week", (1.5, 2, 7) },
            { "Grève SNCF", (0.8, 0.8, 20) },
            { "Vacances", (1.4, 1.3, 30) },
            { "Inflation", (0.8, 1, 20) },
            { "Coupure de courant", (0.5, 0.9, 10) },
            { "Attentat", (0.1, 1, 2) },
            { "Exposition", (1.2, 1.4, 10) },
            { "Tremblement de terre", (0.1, 0.2, 2) },
            { "Concert", (1.2, 1.4, 30) },
            { "Conférence", (1.1, 1.3, 35) },
            { "Cambriolage", (0.1, 1, 1) },
            { "Mode", (1.5, 1.5, 10) }
        };
        _eventComing = aVenir(_event);
    }
    
    
}

