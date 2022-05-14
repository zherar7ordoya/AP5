// tankwiz.h : main header file for the TANKWIZ DLL
//

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CTankwizApp
// See tankwiz.cpp for the implementation of this class
//

class CTankwizApp : public CWinApp
{
public:
	CTankwizApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTankwizApp)
	//}}AFX_VIRTUAL

	//{{AFX_MSG(CTankwizApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////
