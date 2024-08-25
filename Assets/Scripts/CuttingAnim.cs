using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingAnim : MonoBehaviour
{
    private Animator animator;
    private const string CUT = "Cut";
    [SerializeField] private CuttingCounter cuttingCounter;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        cuttingCounter.OnCuttingProgress += StartCutting;
    }

    private void StartCutting(object sender, CuttingCounter.CuttingProgress e)
    {
        animator.SetTrigger(CUT);
    }

   
}
