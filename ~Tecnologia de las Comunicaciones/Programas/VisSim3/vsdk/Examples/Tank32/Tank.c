#include "windows.h"
#include "vsuser.h"
#include <stdio.h>

/************   This is the base function in the DLL   ************/
/************   Called by VisSim at every time step    ************/
EXPORT32 void FAR PASCAL EXPORT level (param,inSig, outSig)
  double far inSig[],FAR outSig[],FAR param[];
{ double simTime, simStep;
  double level = param[3];
  double capacity = param[0];
  /* Calculate tank level based on net flow into tank */

  getSimTimeStep(&simStep);  /* Get time step from VisSim */
  /* in[0] = inflow, in[1] = outflow, param[3] = current level */
  level += (inSig[0]-inSig[1])*simStep; /* Euler integration */
  if (level < 0) level = 0;
  else if (level > capacity) level = capacity;

  outSig[0] = level;      /* output level */
  outSig[1] = capacity;   /* output capacity */

  getSimTime(&simTime);   /* Get sim time from VisSim */
  outSig[2]=simTime;      /* output capacity */

  if (outSig[0] > 100)
    stopSimulation(1);    /* Show how DLL can stop the sim */
  param[3] = level;
}

/**************      Simulation Start Function      ***************/
/*********  Called by VisSim at the start of simulation  **********/
EXPORT32 void FAR PASCAL EXPORT levelSS (double FAR param[],long FAR *runCount )
{
  param[3]=param[1];   /* Reset tank to initial level */
}

/****************      Simulation End Function      ***************/
/************  Called by VisSim at the end of simulation **********/
EXPORT32 void FAR PASCAL EXPORT levelSE (double FAR param[],long FAR*runcount)
{
  debMsg("Simulation End");
}


/****************    Parameter Allocation Function   **************/
/****************   Called by VisSim on block creation ************/
EXPORT32 long FAR PASCAL EXPORT levelPA(pCount)
  short FAR *pCount;
{
  *pCount=4;       /* number of prompted parameters */
  return((*pCount)*sizeof(double)) ;
}

/***************   Parameter Initialization Function   *************/
/***********   Called by VisSim after the PA function   ************/
EXPORT32 void FAR PASCAL EXPORT levelPI(DOUBLE *param)
{
  param[0]=25;   /* capacity   */
  param[1]=5;    /* initial level  */
}


/*****************     Parameter Change Function   *****************/
/********* Called by VisSim on right mouse button click ************/
EXPORT32 char FAR* PASCAL EXPORT levelPC (DOUBLE *param)
{
   return "Capacity;Initial level";
}

/*********This code is required for creating a Windows DLL ********/
 HINSTANCE DLLInst;

/* DLL entry point */
#if defined(__WIN32__) | defined (WIN32)

# if defined( __BORLANDC__)
int PASCAL EXPORT DllEntryPoint( HANDLE hInst, DWORD dwReason, LPVOID pv)
# else
EXPORT32 BOOL APIENTRY DllMain( HANDLE hInst, DWORD dwReason, LPVOID pv)
# endif
{
  DLLInst = hInst;
  MessageBeep((UINT)-1); // Just to say we're alive
  return TRUE;
}
#else
EXPORT32 int FAR EXPORT PASCAL LibMain(hInstance, wDataSeg, cbHeapSize, lpszCmdLine)
HINSTANCE hInstance;
WORD wDataSeg;
WORD cbHeapSize;
LPSTR lpszCmdLine;
{
#ifdef UNIX
  LibFunc("motor", motor);
  LibFunc("motorPA", motorPA);
  LibFunc("motorPI", motorPI);
  LibFunc("motorPC", motorPC);
  LibFunc("motorSE", motorSE);
  LibFunc("motorSS", motorSS);
#endif
  DLLInst = hInstance;
  return TRUE;
} /* LibMain */
#endif
/****************************** end of file  *****************************/
