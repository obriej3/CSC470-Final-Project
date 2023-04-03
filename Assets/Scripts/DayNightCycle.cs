using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DayNightCycle : MonoBehaviour
{
   public float duration = 240.0f; // 4 minutes
   public float intensity = 1.0f;
   public Gradient lightColor;


   private float timer = 0.0f;
   private Light sun;


   void Start()
   {
       sun = GetComponent<Light>();
       sun.intensity = intensity;
   }


   void Update()
   {
       timer += Time.deltaTime;


       if (timer > duration)
       {
           timer = 0.0f;
       }


       float angle = Mathf.Lerp(-90.0f, 270.0f, timer / duration);
       float intensityMultiplier = Mathf.Clamp01(1.0f - Mathf.Abs(angle / 180.0f));


       sun.transform.rotation = Quaternion.Euler(angle, 0.0f, 0.0f);
       sun.intensity = intensity * intensityMultiplier;
       sun.color = lightColor.Evaluate(intensityMultiplier);
   }
}

