﻿using UnityEngine;
using System.Collections;
using System;

public class GameMasterScript : MonoBehaviour
{
    public static GameMasterScript instance; // Singleton

    public GameObject worldObjectPanel; // Access to Prefab

    //Main ressources of the game, >0
    public float resMoney, resElectricity, resWorkforce, resFood;
    // Production in Unit/Second, >0
    public float OverallProdMoney, OverallProdElectricity, OverallProdWorkforce, OverallProdFood;
    private int production_basespeed = 1;
    


    /* Resource Description
    Money: Generated by Towns(paid for electricity), Unit: Euro
    Electricity: Generated by Power Facilitys(Wind, Atom, Wasser) , Unit: Mega Watt
    Workforce: ???
    Food: Generated by Farms, user by Towns to grow, Unit: Tons
    */

    void Awake()
    {
        //Singleton 
        if (instance != null)
            GameObject.Destroy(instance);
        else
            instance = this;

        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Produce(production_basespeed);
    }

    /// <summary>
    /// Adds The Production of all WorldObjects and produces the goods frame independant
    /// </summary>
    /// <param name="speed">base speed modifier</param>
    private void Produce(int speed)
    {
        // Calculating current Production
        GameObject[] wolist = GameObject.FindGameObjectsWithTag("WorldObject");

        foreach (GameObject go in wolist)
        {
            try { OverallProdElectricity += ((Resource)(go.GetComponent<WorldObject>().infos.production["electricity"])).amount; } catch (Exception e) { }
            try { OverallProdFood += ((Resource)(go.GetComponent<WorldObject>().infos.production["food"])).amount;} catch (Exception e) { }
            try { OverallProdMoney += ((Resource)(go.GetComponent<WorldObject>().infos.production["money"])).amount; } catch (Exception e) { }
            try { OverallProdWorkforce += ((Resource)(go.GetComponent<WorldObject>().infos.production["workforce"])).amount; } catch (Exception e) { }
        }

        // Production of Resources is handled here. Using checked to check for uint-Overflow

        try
        {
            checked
            {
                resMoney += (OverallProdMoney * Time.deltaTime);
            }
        }
        catch (OverflowException e)
        {
            Console.Write(e.Message);
        }

        try
        {
            checked
            {
                resElectricity += (OverallProdElectricity * Time.deltaTime);
            }
        }
        catch (OverflowException e)
        {
            Console.Write(e.Message);
        }

        try
        {
            checked
            {
                resWorkforce += (OverallProdWorkforce * Time.deltaTime);
            }
        }
        catch (OverflowException e)
        {
            Console.Write(e.Message);
        }

        try
        {
            checked
            {
                resFood += (OverallProdFood * Time.deltaTime);
            }
        }
        catch (OverflowException e)
        {
            Console.Write(e.Message);
        }
    }

    //Time in seconds since the app was opened last
    public int lastDowntime { get
        {
            return 0;
        }
    }
}