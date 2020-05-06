using UnityEngine;
using UnityEditor;
using System.Collections;

class EditorTracker : EditorWindow
{
    enum TrackerTypes
    {
        Ninguno = 0, // Custom name for "Nothing" option
        MainMenu = 1 << 0,
        FirstMinute = 1 << 1,
        ScoreSystem = 1 << 2,
        Todos = ~0, // Custom name for "Everything" option
    }

    TrackerTypes m_Flags;


    [MenuItem("Window/Tracker")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(EditorTracker));
        GetWindow<EditorTracker>().Show();
    }

    void OnGUI()
    {
        //Selección de paquete
        GUILayout.Label("Selección de trackers que empiezan activos", EditorStyles.boldLabel);
        m_Flags = (TrackerTypes)EditorGUILayout.EnumFlagsField(m_Flags);

    }
}