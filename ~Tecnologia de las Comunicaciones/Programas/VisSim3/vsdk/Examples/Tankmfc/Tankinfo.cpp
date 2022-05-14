// TankInfo.cpp : implementation file
//

#include "stdafx.h"
#include "tankmfc.h"
#include "TankInfo.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CTankInfo dialog


CTankInfo::CTankInfo(CWnd* pParent /*=NULL*/)
	: CDialog(CTankInfo::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTankInfo)
	m_capacity = 0.0;
	m_fileName = _T("");
	m_initialLevel = 0.0;
	m_alarm = -1;
	//}}AFX_DATA_INIT
}


void CTankInfo::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTankInfo)
	DDX_Text(pDX, IDC_CAPACITY, m_capacity);
	DDV_MinMaxDouble(pDX, m_capacity, 0., 500.);
	DDX_Text(pDX, IDC_FILE_NAME, m_fileName);
	DDV_MaxChars(pDX, m_fileName, 256);
	DDX_Text(pDX, IDC_INITIAL_LEVEL, m_initialLevel);
	DDV_MinMaxDouble(pDX, m_initialLevel, 0., 50.);
	DDX_CBIndex(pDX, IDC_ALARM, m_alarm);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CTankInfo, CDialog)
	//{{AFX_MSG_MAP(CTankInfo)
		// NOTE: the ClassWizard will add message map macros here
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTankInfo message handlers
