using SimpleCity.AI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathVisualizer : MonoBehaviour
{
    LineRenderer lineRenderer;
    AiAgent currentAgent;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
    }

    public void ShowPath(List<Vector3> path, AiAgent agent, Color color)
    {
        ResetPath();
        lineRenderer.positionCount = path.Count;
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
        for (int i = 0; i < path.Count; i++)
        {
            lineRenderer.SetPosition(i, path[i] + new Vector3(0, agent.transform.position.y, 0));
        }
        currentAgent = agent;
        currentAgent.OnDeath += ResetPath;
    }

    public void ResetPath()
    {
        if(lineRenderer != null)
        {
            lineRenderer.positionCount = 0;
        }
        if(currentAgent != null)
        {
            currentAgent.OnDeath -= ResetPath;
        }
        currentAgent = null;
    }
}
