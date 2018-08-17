using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    EventMachine m_em;

	void Start () {
		m_em = new EventMachine(typeof(TestControl));
        m_em.Start();
	}
	
	void Update () {
		m_em.Update();
	}

    private void OnGUI()
    {
        if (GUILayout.Button("BUT A"))
        {
            m_em.EventMan.Push("BUT_A");
        }
        if (GUILayout.Button("BUT B"))
        {
            m_em.EventMan.Push("BUT_B");
        }
        if (GUILayout.Button("BUT C"))
        {
            m_em.EventMan.Push("BUT_C");
        }
    }
}
