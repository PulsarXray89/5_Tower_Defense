﻿using UnityEngine;

public class Waypoint : MonoBehaviour
{
    const int gridSize = 10;

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize)
            , Mathf.RoundToInt(transform.position.z / gridSize)
        );
    }

    public void SetTopColor(Color color)
    {
        MeshRenderer topMeshRenderer = transform.Find("YPositive").GetComponent<MeshRenderer>();
        topMeshRenderer.material.color = color;
    }
}
