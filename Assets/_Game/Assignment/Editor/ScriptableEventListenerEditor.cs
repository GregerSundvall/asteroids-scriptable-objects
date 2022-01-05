// using System.Collections;
// using System.Collections.Generic;
// using DefaultNamespace.ScriptableEvents;
// using UnityEditor;
// using UnityEngine;
//
// [CustomEditor(typeof(ScriptableEventListener))]
// public class ScriptableEventListenerEditor : Editor
// {
//     [SerializeField] private bool _enabled;
//     
//     public override void OnInspectorGUI()
//     {
//         ScriptableEventListener listener = target as ScriptableEventListener;
//         
//         using (new GUILayout.HorizontalScope())
//         {
//             GUILayout.Label(listener.name);
//             if (GUILayout.Button("Disable", GUILayout.Width(60)))
//             {
//                 Debug.Log("did the thing");
//             }
//         }
//         
//         base.OnInspectorGUI();
//     }
// }
