﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BakeOnAwake : MonoBehaviour
{

    public NavMeshSurface surface;

    void Start()
    {
        surface.BuildNavMesh();
    }
}
