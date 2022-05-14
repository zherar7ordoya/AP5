// TankInfo.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CTankInfo dialog

class CTankInfo : public CDialog
{
// Construction
public:
	CTankInfo(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CTankInfo)
	enum { IDD = IDD_DIALOG1 };
	double	m_capacity;
	CString	m_fileName;
	double	m_initialLevel;
	int		m_alarm;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTankInfo)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CTankInfo)
		// NOTE: the ClassWizard will add member functions here
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};
