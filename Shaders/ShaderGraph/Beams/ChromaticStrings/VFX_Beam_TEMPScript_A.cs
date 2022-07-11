\using System.Collections;
using System.Collections.Generic;

    //Anchors Line Renderer positions to corresponding GameObjects in the Unity Editor
    [ExecuteInEditMode]
    public class VFX_Beam_TEMPScript_A : MonoBehaviour
    {
        public List<GameObject> attachedObjects;
        public LineRenderer lineRenderer;
     
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
