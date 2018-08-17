using System;
public partial class TestControl  {
	
	bool m_bYesNo;
	
	void br_YES(Action<bool> st)
	{
		if (!HasNextState())
		{
			if (m_bYesNo)
			{
				SetNextState(st);
			}
		}
	}

	void br_NO(Action<bool> st)
	{
		if (!HasNextState())
		{
			if (!m_bYesNo)
			{
				SetNextState(st);
			}
		}
	}
    void br_BTN_A(Action<bool> st)
    {
		if (!HasNextState())
		{
			if (m_eventman.CUR!=null && m_eventman.CUR.ToString() == "BUT_A")
			{
				SetNextState(st);
			}
		}
    }
    void br_BTN_B(Action<bool> st)
    {
		if (!HasNextState())
		{
			if (m_eventman.CUR!=null && m_eventman.CUR.ToString() == "BUT_B")
			{
				SetNextState(st);
			}
		}
    }
    void br_BTN_C(Action<bool> st)
    {
		if (!HasNextState())
		{
			if (m_eventman.CUR!=null && m_eventman.CUR.ToString() == "BUT_C")
			{
				SetNextState(st);
			}
		}
    }

}
