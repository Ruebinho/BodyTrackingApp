using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour {

    GameObject UebersichtElements = null;
    GameObject allHabitElements = null;
    GameObject allRoutineElements = null;
    GameObject allGesundheitElements = null;
    GameObject allTrainingElements = null;
    GameObject habitTab1 = null;
    GameObject habitTab2 = null;
    GameObject habitTab3 = null;
    GameObject routineTab1 = null;
    GameObject routineTab2 = null;
    GameObject routineTab3 = null;
    GameObject gesundheitTab1 = null;
    GameObject gesundheitTab2 = null;
    GameObject trainingTab1 = null;
    GameObject trainingTab2 = null;
    GameObject trainingTab3 = null;

    // Use this for initialization
    void Start () {
        GetAllUIElements();
        SetDefaultView();
	}

    private void GetAllUIElements()
    {
        UebersichtElements = GameObject.FindGameObjectWithTag("UebersichtTab");
        allHabitElements = GameObject.FindGameObjectWithTag("HabitTab");
        allRoutineElements = GameObject.FindGameObjectWithTag("RoutineTab");
        allGesundheitElements = GameObject.FindGameObjectWithTag("GesundheitTab");
        allTrainingElements = GameObject.FindGameObjectWithTag("TrainingTab");

        habitTab1 = GameObject.FindGameObjectWithTag("HabitTab1");
        habitTab2 = GameObject.FindGameObjectWithTag("HabitTab2");
        habitTab3 = GameObject.FindGameObjectWithTag("HabitTab3");
        routineTab1 = GameObject.FindGameObjectWithTag("RoutineTab1");
        routineTab2 = GameObject.FindGameObjectWithTag("RoutineTab2");
        routineTab3 = GameObject.FindGameObjectWithTag("RoutineTab3");
        gesundheitTab1 = GameObject.FindGameObjectWithTag("GesundheitTab1");
        gesundheitTab2 = GameObject.FindGameObjectWithTag("GesundheitTab2");
        trainingTab1 = GameObject.FindGameObjectWithTag("TrainingTab1");
        trainingTab2 = GameObject.FindGameObjectWithTag("TrainingTab2");
        trainingTab3 = GameObject.FindGameObjectWithTag("TrainingTab3");
    }

    private void SetDefaultView()
    {
        ShowUebersichtTab();
    }

    public void ShowUebersichtTab()
    {
        UebersichtElements.SetActive(true);
        allHabitElements.SetActive(false);
        allRoutineElements.SetActive(false);
        allGesundheitElements.SetActive(false);
        allTrainingElements.SetActive(false);


    }

    public void ShowHabitTab()
    {
        UebersichtElements.SetActive(false);
        allHabitElements.SetActive(true);
        allRoutineElements.SetActive(false);
        allGesundheitElements.SetActive(false);
        allTrainingElements.SetActive(false);
    }

    public void ShowRoutineTab()
    {
        UebersichtElements.SetActive(false);
        allHabitElements.SetActive(false);
        allRoutineElements.SetActive(true);
        allGesundheitElements.SetActive(false);
        allTrainingElements.SetActive(false);
    }

    public void ShowGesundheitTab()
    {
        UebersichtElements.SetActive(false);
        allHabitElements.SetActive(false);
        allRoutineElements.SetActive(false);
        allGesundheitElements.SetActive(true);
        allTrainingElements.SetActive(false);
    }

    public void ShowTrainingTab()
    {
        UebersichtElements.SetActive(false);
        allHabitElements.SetActive(false);
        allRoutineElements.SetActive(false);
        allGesundheitElements.SetActive(false);
        allTrainingElements.SetActive(true);
    }

    public void ShowHabitTab1()
    {
        habitTab1.SetActive(true);
        habitTab2.SetActive(false);
        habitTab3.SetActive(false);
    }

    public void ShowHabitTab2()
    {
        habitTab1.SetActive(false);
        habitTab2.SetActive(true);
        habitTab3.SetActive(false);
    }

    public void ShowHabitTab3()
    {
        habitTab1.SetActive(false);
        habitTab2.SetActive(false);
        habitTab3.SetActive(true);
    }

    public void ShowRoutineTab1()
    {
        routineTab1.SetActive(true);
        routineTab2.SetActive(false);
        routineTab3.SetActive(false);
    }

    public void ShowRoutineTab2()
    {
        routineTab1.SetActive(false);
        routineTab2.SetActive(true);
        routineTab3.SetActive(false);
    }

    public void ShowRoutineTab3()
    {
        routineTab1.SetActive(false);
        routineTab2.SetActive(false);
        routineTab3.SetActive(true);
    }

    public void ShowGesundheitTab1()
    {
        gesundheitTab1.SetActive(true);
        gesundheitTab2.SetActive(false);
    }

    public void ShowGesundheitTab2()
    {
        gesundheitTab1.SetActive(false);
        gesundheitTab2.SetActive(true);
    }

    public void ShowTrainingTab1()
    {
        trainingTab1.SetActive(true);
        trainingTab2.SetActive(false);
        trainingTab3.SetActive(false);
    }

    public void ShowTrainingTab2()
    {
        trainingTab1.SetActive(false);
        trainingTab2.SetActive(true);
        trainingTab3.SetActive(false);
    }

    public void ShowTrainingTab3()
    {
        trainingTab1.SetActive(false);
        trainingTab2.SetActive(false);
        trainingTab3.SetActive(true);
    }


}
