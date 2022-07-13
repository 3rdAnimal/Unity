// resources for curve
// https://forum.unity.com/threads/generating-dynamic-parabola.211681/#post-1426169
// https://old.reddit.com/user/Sanketpanda/comments/f475vn/make_a_curved_line_using_unity3d_line_renderer/
// https://www.youtube.com/watch?v=Xo3n4W3QbWM

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    //Anchors Line Renderer positions to corresponding GameObjects in the Unity Editor
    [ExecuteInEditMode]
    public class VFX_Beam_TEMPScript_A : MonoBehaviour
    {
        public List<GameObject> attachedObjects;
        public LineRenderer lineRenderer;

/*    Vector3 SampleParabola(Vector3 start, Vector3 end, float height, float t, Vector3 outDirection)
    {
        float parabolicT = t * 2 - 1;
        //start and end are not level, gets more complicated
        Vector3 travelDirection = end - start;
        Vector3 levelDirection = end - new Vector3(start.x, end.y, start.z);
        Vector3 right = Vector3.Cross(travelDirection, levelDirection);
        Vector3 up = outDirection;
        Vector3 result = start + t * travelDirection;
        result += ((-parabolicT * parabolicT + 1) * height) * up.normalized;
        return result;
    }*/


    #if UNITY_EDITOR
        void Update()
        {
            if (Application.isEditor && !Application.isPlaying)
            {
                for (int i = 0; i < attachedObjects.Count; i++)
                {
                    if (i < lineRenderer.positionCount && attachedObjects != null)
                        { lineRenderer.SetPosition(i, transform.InverseTransformPoint(attachedObjects[i].transform.position)); }

                }
            }
        }
    #endif
    }
