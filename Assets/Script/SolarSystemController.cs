using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemController : MonoBehaviour
{

    public GameObject[] planetObjects;
    public Transform[] PlanetTransform;
    public LineRenderer[] rendererPlanet;
    List<Vector3[]> planetPosition = new List<Vector3[]>();
    
    public DateTime time;
    


    public void UpdatePosition(DateTime t)
    {
        
        for(int i=0; i< PlanetTransform.Length; i++) {

           
            Vector3 maPos =PlanetData.GetPlanetPosition((PlanetData.Planet)i, t);

            PlanetTransform[i].position = maPos;

        }
        
    }

    void Start()
    {
        PlanetManager.current.OnTimeChange += UpdatePosition;

    }



    public void SetLineRenderer() {

        Debug.Log("fonction lanc�");

        time = DateTime.Now;

        List<Vector3> listMercury = new List<Vector3>();
        List<Vector3> listVenus = new List<Vector3>();
        List<Vector3> listEarth = new List<Vector3>();
        List<Vector3> listMars = new List<Vector3>();
        List<Vector3> listJupiter = new List<Vector3>();
        List<Vector3> listSaturn = new List<Vector3>();
        List<Vector3> listUranus = new List<Vector3>();
        List<Vector3> listNeptune = new List<Vector3>();



        for (int i = 0; i < 89; i++)
        {
            listMercury.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)0, time));
            
           time= time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listMercury.Count]);

        for (int i = 0; i < listMercury.Count; i++)
        {
            planetPosition[0][i] = listMercury[i];
        }

        rendererPlanet[0].positionCount = listMercury.Count;

        rendererPlanet[0].startWidth = 0.5f;

        rendererPlanet[0].SetPositions(planetPosition[0]);
 
        
        for (int i = 0; i < 226; i++)
        {
            listVenus.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)1, time));
            time = time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listVenus.Count]);

        for (int i = 0; i < listVenus.Count; i++)
        {
            planetPosition[1][i] = listVenus[i];
        }

        rendererPlanet[1].positionCount = listVenus.Count;

        rendererPlanet[1].startWidth = 0.5f;

        rendererPlanet[1].SetPositions(planetPosition[1]);


        for (int i= 0; i < 367; i++)
        {
            listEarth.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)2, time));
            time = time.AddDays(1);
        }


        planetPosition.Add( new Vector3[listEarth.Count]);

        for(int i=0; i< listEarth.Count; i++)
        {
            planetPosition[2][i] = listEarth[i];
        }

        rendererPlanet[2].positionCount = listEarth.Count;

        rendererPlanet[2].startWidth = 0.5f;

        rendererPlanet[2].SetPositions(planetPosition[2]);


        for (int i = 0; i < 688; i++)
        {
            listMars.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)3, time));
            time = time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listMars.Count]);

        for (int i = 0; i < listMars.Count; i++)
        {
            planetPosition[3][i] = listMars[i];
        }

        rendererPlanet[3].positionCount = listMars.Count;

        rendererPlanet[3].startWidth = 0.5f;

        rendererPlanet[3].SetPositions(planetPosition[3]);


        for (int i = 0; i < 4334; i++)
        {
            listJupiter.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)4, time));
            time = time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listJupiter.Count]);

        for (int i = 0; i < listJupiter.Count; i++)
        {
            planetPosition[4][i] = listJupiter[i];
        }

        rendererPlanet[4].positionCount = listJupiter.Count;

        rendererPlanet[4].startWidth = 0.5f;

        rendererPlanet[4].SetPositions(planetPosition[4]);


        for (int i = 0; i < 10761; i++)
        {
            listSaturn.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)5, time));
            time = time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listSaturn.Count]);

        for (int i = 0; i < listSaturn.Count; i++)
        {
            planetPosition[5][i] = listSaturn[i];
        }

        rendererPlanet[5].positionCount = listSaturn.Count;

        rendererPlanet[5].startWidth = 0.5f;

        rendererPlanet[5].SetPositions(planetPosition[5]);



        for (int i = 0; i < 30687; i++)
        {
            listUranus.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)6, time));
            time = time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listUranus.Count]);

        for (int i = 0; i < listUranus.Count; i++)
        {
            planetPosition[6][i] = listUranus[i];
        }

        rendererPlanet[6].positionCount = listUranus.Count;

        rendererPlanet[6].startWidth = 0.5f;

        rendererPlanet[6].SetPositions(planetPosition[6]);



        for (int i = 0; i < 60267; i++)
        {
            listNeptune.Add(PlanetData.GetPlanetPosition((PlanetData.Planet)7, time));
            time = time.AddDays(1);
        }


        planetPosition.Add(new Vector3[listNeptune.Count]);

        for (int i = 0; i < listNeptune.Count; i++)
        {
            planetPosition[7][i] = listNeptune[i];
        }

        rendererPlanet[7].positionCount = listNeptune.Count;

        rendererPlanet[7].startWidth = 0.5f;

        rendererPlanet[7].SetPositions(planetPosition[7]);

    }


}
