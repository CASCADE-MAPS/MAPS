﻿using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class ReflectiveEnumerator
{
    static ReflectiveEnumerator() { }

    public static List<T> GetListOfType<T>(params object[] constructorArgs) where T : class
    {
        List<T> objects = new List<T>();
        foreach (Type type in
            Assembly.GetAssembly(typeof(T)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
        {
            objects.Add((T)Activator.CreateInstance(type, constructorArgs));
        }
        //objects.Sort();
        return objects;
    }
}
