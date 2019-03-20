using System;
using System.Reflection;
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Start()
    {
        Type t = typeof(System.String);

        // Iterate over all the methods from the System.String class and display
        // return type and parameters.
        // This reveals all the things you can do with a String.
        foreach (MethodInfo mi in t.GetMethods())
        {
            System.String s = System.String.Format("{0} {1} (", mi.ReturnType, mi.Name);
            ParameterInfo[] pars = mi.GetParameters();

            for (int j = 0; j < pars.Length; j++)
            {
                s = String.Concat(s, String.Format("{0}{1}", pars[j].ParameterType, ((j == pars.Length - 1) ? "" : ", ")));
            }
            s = String.Concat(s, ")");
            Debug.Log(s);
        }
    }
}
