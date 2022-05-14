/* Sampldll.c - Example file for VisSim DLL */

#include <windows.h>  // standard windows include file
#include <windowsx.h>  // standard windows 16/32 macro set include file
#include <string.h>
#include <stdlib.h>
#include "vsuser.h" // vissim function prototypes
#include "sampldll.h"  // sampldll type definitions and literals

#ifndef GET_WM_COMMAND_ID
#ifndef _WIN32
#define GET_WM_COMMAND_ID(wp, lp) LOWORD(wp)
#define GET_WM_COMMAND_CMD(wp, lp)  HIWORD(lp)
#else
#define GET_WM_COMMAND_ID(wp, lp)  (wp)
#define GET_WM_COMMAND_CMD(wp, lp) HIWORD(wp)
#endif
#endif

HWND vsmHWnd;

/* User menu Table */
USER_MENU_ITEM um1[] = {
/* level 0 menu name, DLL name, -2 */
  {"&PLCTech", "sampldll", -2} /* level 0 (top level) block menu item */
/* level 1 menu name, DLL name, -1 */
  ,{"&Fuzzy", "sampldll", -1} /* level 1 block menu item */
/* menu name, function name, input count, output count */
  ,{"fuzzyFun", "sampldll", 5,1, sizeof(FUZZY_INFO),"Fuzzy Rule Interpreter"} /* level 2 menu item #1 */
  ,{"secondOne", "samp2", 5,1, 20*sizeof(double),"Inverse Moire Filter"} /* level 2 menu item #1 */
  ,{0}};

/* User menu Table 2 */
USER_MENU_ITEM um2[] = {
/* level 0 menu name, DLL name, -2 */
  {"&PLCTech", "sampldll", -2} /* level 0 (top level) block menu item */
/* level 1 menu name, DLL name, -1 */
  ,{"&About PLCTech", "about", 0,0, 0,"About PLCTech"} /* level 2 menu item w/no block */
  ,{0} /* End of table */
  };

  char startupDir[_MAX_PATH];
/* This function will be called by VisSim if the DLL in which it resides
 * is placed in the \windows\vissim.ini file with the line:
   addons=<dll file name>
 */
EXPORT32 int EXPORT PASCAL vsmInit()
{
    LPSTR lpszStartup;
    
  lpszStartup = (LPSTR)vissimRequest(VR_GET_STARTUP_DIR, 0, 0);
/* Each following line adds a block item list to the Blocks menu */
  setUserBlockMenu(um1);
  setUserBlockMenu(um2);
  return 0;
}

char *floatToStr( double d )
{
  static char floatBuf[64];
  static int sign, dec;
  char *p = gcvt( d, 10, floatBuf);
/* skip leading minus */
  if (*p == '-') p++;
/* remove leading space */
  while (*p == ' ') strcpy (p, p+1);
/* Remove leading zeros, (be sure number has a digit left) */
  if (*p == '0'&& p[1]) strcpy (p, p+1);
/* Remove trailing '.' for 1. and 1.e12 */
  p = floatBuf;
  while (*p && *p != '.') p++;
  if (*p == '.')
  { if (p[1] == 0) *p = 0;
    else if (tolower(p[1]) == 'e') strcpy (p, p+1);
  }
  /* set to zero if removed everything */
  if (!*floatBuf) strcpy( floatBuf, "0");
  return floatBuf;
}

void setDlgItemFlt( HWND hDlg, int id, double val)
{
  SetDlgItemText( hDlg, id, floatToStr(val));
}

double getDlgItemFlt( HWND hDlg, int id)
{
  static char valBuf[80];
  
  GetDlgItemText( hDlg, id, valBuf, sizeof(valBuf));
  return atof(valBuf);
}

/* globals */

HINSTANCE DLLInst;

/* user Event function to handle menu pick */
EXPORT32 LPSTR PASCAL EXPORT aboutEvent(HWND h, int msg, WPARAM wParam, LPARAM lParam)
{
  switch (msg) {

    case WM_COMMAND:  // Menu pick
      MessageBox(vsmHWnd, "PLCTech Version 1.0\nCopyright 1995", "About PLCTech", MB_OK);
      return (LPSTR)(LPARAM)VBF_MENU_ONLY;   // Surpress block creation
    case WM_VSM_CREATE:  // Tell VisSim not to create block
      return (LPSTR)(LPARAM)VBF_MENU_ONLY;   // Surpress block creation
  }      
  return 0;
}

EXPORT32 void FAR EXPORT PASCAL panic( int code);

/* simulation start function */
EXPORT32 void FAR EXPORT PASCAL sampldllSS(params, runCount)
double FAR params[];
long FAR *runCount;
{
/* Do simulation startup sorts of things here */
}


/* Get size for param */
EXPORT32 long FAR  PASCAL EXPORT sampldllPA( short FAR *ppCount)
{
    return sizeof(FUZZY_INFO);
}


/* simulation step function */
EXPORT32 void FAR EXPORT PASCAL sampldll(params, insig, outsig)
double FAR params[];
double FAR insig[];
double FAR outsig[];
{
  /* Do simulation time step things here */
  outsig[0] = insig[0] + insig[1] + insig[2];
  outsig[1] = 5;
}


/* simulation end function */
EXPORT32 void FAR EXPORT PASCAL sampldllSE(double FAR params[], long FAR*runCount)
{
  /* Do simulation end time things here */
}


/* Create and display custom dialog */
static int showCustomDialog(values)
FUZZY_INFO FAR *values;
{
  return DialogBoxParam(DLLInst, "SAMPLDLL", vsmHWnd, (DLGPROC)SampleDllProc, (LPARAM) values);

} /* sampldllPC */


#define FUZZY_INFO_STR "i[4]c[%d]"
static char fmtBuf[128];

/* user Event function to set block name  and handle parameter discription for auto file save/restore */
EXPORT32 LPSTR  PASCAL EXPORT sampldllEvent(HWND h, int msg, WPARAM wParam, LPARAM lParam)
{
  FUZZY_INFO FAR*fzParam;
  LPARAM blockHandle;
  long arg;
  SIM_INFO simInfo;
  OPT_INFO optInfo;
  int port;
  
  switch (msg) {

    case WM_VSM_GET_PARAM_DESC:
      wsprintf( fmtBuf, FUZZY_INFO_STR, MAX_BLOCK_NAME); /* Use sprintf so field size gets set */
      return fmtBuf;

    case WM_VSM_CONNECTOR_NAME:
      port = wParam;
      wsprintf( fmtBuf, "%slab%d", port<0?"out":"in", abs(port)); /* Use sprintf so field size gets set */
      return fmtBuf;
      
    case WM_VSM_CREATE:
      port = wParam;
      //wsprintf( fmtBuf, "%slab%d", port<0?"out":"in", abs(port)); /* Use sprintf so field size gets set */
      return 0;
      
    case WM_VSM_DESTROY:
      port = wParam;
      //wsprintf( fmtBuf, "%slab%d", port<0?"out":"in", abs(port)); /* Use sprintf so field size gets set */
      return 0;
      
    case WM_VSM_GET_BLOCK_NAME:  /* returns block name */
     fzParam = (FUZZY_INFO FAR*)lParam;
     return (fzParam && fzParam->name[0])?fzParam->name:"This\nis a\nmulti-line\nname";   // If no name, return null
    
#if NO
    case WM_VSM_GET_BLOCK_BITMAP:  /* returns block name */
     fzParam = (FUZZY_INFO FAR*)lParam;
     return fzParam->bitmap[0]?fzParam->bitmap:0;   // If no bitmap, return null
#endif     
    
    case WM_VSM_BLOCK_SETUP:  /* User clicked right mouse button */
      blockHandle = lParam;
      fzParam = (FUZZY_INFO FAR*)vissimRequest(VR_GET_BLOCK_PARAMS, blockHandle, 0);  // Get params from block handle
      if (!fzParam) return 0; // No param's allocated yet. Probably forgot addons= line
      vissimRequest(VR_GET_VISSIM_STATE, (LPARAM)(void FAR*)&simInfo, sizeof(simInfo));
      vissimRequest(VR_GET_GLOBAL_OPT_INFO, (LPARAM)(void FAR*)&optInfo, sizeof(optInfo));
      vsmHWnd = (HWND)vissimRequest(VR_GET_WINDOW_HANDLE, 0, 0);
      if (IDOK == showCustomDialog(fzParam))
        { // If user said OK, set block connector counts
          arg = fzParam->inputCount | (((long)fzParam->outputCount)<<16);
//          vissimRequest(VR_SET_BLOCK_CONNECTOR_COUNT, blockHandle, arg);
        }
      return 0;
     
    case WM_VSM_SIM_START: // Get connector input count on sim startup
     fzParam = (FUZZY_INFO FAR*)vissimRequest( VR_GET_BLOCK_PARAMS, lParam, 0);
     fzParam->inputCount = vissimRequest( VR_GET_CONNECTOR_COUNT, lParam, 1);
     return 0;

    case WM_VSM_ADD_CONNECTOR: // These messages sent when user tries to add or del connectors on block 
    case WM_VSM_DEL_CONNECTOR:
      return 0;   // return of 0 says don't allow users to change connect count
  }                                                               
  return 0;
}

/* simulation step function */
EXPORT32 void FAR EXPORT PASCAL samp2(params, insig, outsig)
double FAR params[];
double FAR insig[];
double FAR outsig[];
{
  /* Do simulation time step things here */
  outsig[0] = insig[0] + insig[1] + insig[2];
  outsig[1] = 5;
}

/* Get size for param */
EXPORT32 long FAR PASCAL EXPORT samp2PA( short FAR *ppCount)
{
    return sizeof(FUZZY_INFO);
}

/* Get default dialog for param setup */
EXPORT32 LPSTR  PASCAL EXPORT samp2PC( DOUBLE *param)
{
    return "lb1;tl1;tr1;br1;lb2;tl2;tr2;br2;lb3;tl3;tr3;br3;lb4;tl4;tr4;br4;lb5;tl5;tr5;br5";
}

/* parameter initialization function */
EXPORT32 void FAR EXPORT PASCAL sampldllPI(values)
FUZZY_INFO FAR *values;
{

  values->iInfMethod = INF_MAX_MIN;
  values->iDefuzMethod = DEFUZ_YAGERS;
  values->inputCount = 3;
  values->outputCount = 2;
} /* sampldllPI */


/* parameter change dialog procedure */

BOOL FAR EXPORT PASCAL SampleDllProc(hDlg, msg, wParam, lParam)
HWND hDlg;
UINT msg;
WPARAM wParam;
LPARAM lParam;
{
  static FUZZY_INFO FAR *data;
  int iInference, iDefuz;

  switch (msg) {

  case WM_INITDIALOG:
    /* initialize the dialog box fields */
    data = (FUZZY_INFO FAR *) lParam;
    if (!data)
      { debMsg("You must put 'addons=sampldll.dll' in your vissim.ini file");
        EndDialog( hDlg, FALSE);
      }
    iInference = IDD_FIRST_INFERENCE + data->iInfMethod;
    iDefuz = IDD_FIRST_DEFUZ + data->iDefuzMethod;
    CheckRadioButton(hDlg, IDD_MINMAX, IDD_BOUNDSUMPROD, iInference);
    CheckRadioButton(hDlg, IDD_YAGER, IDD_MAXHEIGHT, iDefuz);
    SetDlgItemText( hDlg, IDD_NAME, data->name);
    SetDlgItemText( hDlg, IDD_BITMAP, data->bitmap);
    break;

  case WM_COMMAND:
    switch (GET_WM_COMMAND_ID(wParam, lParam)) {
    case IDCANCEL:
      EndDialog(hDlg, FALSE);
      break;

    case IDOK:
      /* read the new values */
      if (IsDlgButtonChecked(hDlg, IDD_MINMAX))
        data->iInfMethod = INF_MAX_MIN;
      else if (IsDlgButtonChecked(hDlg, IDD_SUMPROD))
        data->iInfMethod = INF_SUM_PRODUCT;
      else
        data->iInfMethod = INF_BOUNDED_SUM;

      if (IsDlgButtonChecked(hDlg, IDD_YAGER))
        data->iDefuzMethod = DEFUZ_YAGERS;
      else if (IsDlgButtonChecked(hDlg, IDD_CENTER))
        data->iDefuzMethod = DEFUZ_CENTER_GRAVITY;
      else
        data->iDefuzMethod = DEFUZ_MAX_HEIGHT;

      GetDlgItemText( hDlg, IDD_NAME, data->name, sizeof(data->name));
      GetDlgItemText( hDlg, IDD_BITMAP, data->bitmap, sizeof(data->bitmap));
      EndDialog(hDlg, TRUE);
      break;
    }
    return TRUE;
  }
  return FALSE;
} /* SampleDllProc */


EXPORT32 char* EXPORT PASCAL vsmEvent( int msg, int wParam, long FAR*arg)
{
  switch (msg)
  {
    case WM_DESTROY:      // Sent at VisSim shutdown time
    case WM_VSM_STOP_SIM: // Sent at sim end
      // closePorts();
      break;
    case WM_VSM_WINDOW_HANDLE:  // Sent at VisSim startup
      vsmHWnd = (HWND) (long)arg;
      break;
    case VSE_TIME_STEP: // Sent at end of each time step
      // can do own integration method now
      break;
    case VSE_PRE_SIM_START:  // Sent before block sim start messages
      // Put reset code here
      break;
    case VSE_POST_SIM_START:  // Sent after block sim start messages
      break;
    case WM_COMMNOTIFY:
      // Passed thru from VisSim for comm port handling
      break;
  }
}


/* DLL entry point for 16 bit/Borland32/MSVC32 */
#if defined(__WIN32__) | defined (WIN32)
  #if __BORLANDC__
    BOOL APIENTRY EXPORT DllEntryPoint( HANDLE hInstance, DWORD dwReason, LPVOID pv)
  #else
    EXPORT32 BOOL APIENTRY DllMain( HANDLE hInstance, DWORD dwReason, LPVOID pv)
  #endif
#else 
  int FAR EXPORT PASCAL LibMain(hInstance, wDataSeg, cbHeapSize, lpszCmdLine)
  HINSTANCE hInstance;
  WORD wDataSeg;
  WORD cbHeapSize;
  LPSTR lpszCmdLine;
#endif
{
  DLLInst = hInstance;
  MessageBeep((unsigned)-1);  // just to say we are alive
  return TRUE;
}


