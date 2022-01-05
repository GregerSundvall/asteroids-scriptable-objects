
using Assignment;
using DefaultNamespace.ScriptableEvents;
using ScriptableEvents;
using UnityEditor;
using UnityEngine;

namespace _Game.Assignment.Editor
{
    [CustomEditor(typeof(Debugger))]
    public class DebuggerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            Debugger debugger = target as Debugger;
            
            GUILayout.Label("asdf");

            foreach (var l in debugger.listeners)
            {
                GUILayout.Label(l.GetComponent<ScriptableEvent>().name);
            }
            // if (debugger._listeners.Count > 0)
            // {
            //     foreach (var e in debugger._listeners)
            //     {
            //         using (new GUILayout.VerticalScope())
            //         {
            //             using (new GUILayout.VerticalScope(EditorStyles.helpBox))
            //             {
            //                 using (new GUILayout.HorizontalScope())
            //                 {
            //                     GUILayout.Label(e.name);
            //                     if (GUILayout.Button("Disable", GUILayout.Width(60)))
            //                     {
            //                         Debug.Log("did the thing");
            //                     }
            //                 }
            //                 //EditorGUILayout.ObjectField("Drop Event here:", null, typeof(ScriptableEvent), true);
            //             }
            //             GUILayout.Space(30);
            //         }
            //     }
            //     
            // }



            base.OnInspectorGUI();
            
        }
    }
}
