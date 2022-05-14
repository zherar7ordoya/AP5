// tankmfc.cpp : Defines the initialization routines for the DLL.
//

#include "stdafx.h"
#include "tankmfc.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CTankwizApp

BEGIN_MESSAGE_MAP(CTankwizApp, CWinApp)
	//{{AFX_MSG_MAP(CTankwizApp)
		// NOTE - the ClassWizard will add and remove mapping macros here.
		//    DO NOT EDIT what you see in these blocks of generated code!
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTankwizApp construction

CTankwizApp::CTankwizApp()
{
	// TODO: add construction code here,
	// Place all significant initialization in InitInstance
}

/////////////////////////////////////////////////////////////////////////////
// The one and only CTankwizApp object

CTankwizApp theApp;

