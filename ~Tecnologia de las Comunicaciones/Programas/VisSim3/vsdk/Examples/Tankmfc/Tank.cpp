/* Sample MFC VisSim DLL file */
/* This uses class wizard to create dialogs */

#include "stdafx.h"
//#include "windows.h"
#include "vsuser.h"
#include <stdio.h>

#include "resource.h"
#include "tank.h"
#include "tankinfo.h"

void tankDlgMFC( TANK_INFO *ti) // Invoke MFC dialog
{
  CTankInfo tDlg;
  tDlg.m_capacity = ti->capacity;
  tDlg.m_initialLevel = ti->initialLevel;
  tDlg.m_fileName = ti->name;
  tDlg.m_alarm = ti->alarm;
  if (!tDlg.DoModal())  return;
  ti->capacity = tDlg.m_capacity;
  ti->initialLevel = tDlg.m_initialLevel;
  strcpy( ti->name, tDlg.m_fileName) ;
  ti->alarm = tDlg.m_alarm;
}

extern "C" {  // Following functions need C naming to be seen by VisSim

/************   This is the base function in the DLL   ************/
/************   Called by VisSim at every step size    ************/
EXPORT32 void FAR PASCAL EXPORT level (TANK_INFO *ti, double far inSig[],double FAR outSig[])
{ double simTime;

   outSig[0]=((ti->initialLevel+inSig[0]-inSig[1])/(ti->capacity))*100;
   outSig[1]=ti->capacity;     /* display capacity  */

   getSimTime(&simTime);
   outSig[2]=simTime;
   if (outSig[0] > 100)
     stopSimulation(1);
}

/****************    Parameter Allocation Function   **************/
/****************   Called by VisSim on block creation ************/
EXPORT32 long FAR PASCAL EXPORT levelPA(short FAR *pCount)
{
  return sizeof(TANK_INFO) ;
}

/***************   Parameter Initialization Function   *************/
/***********   Called by VisSim after the PA function   ************/
EXPORT32 void FAR PASCAL EXPORT levelPI(TANK_INFO *ti)
{
  ti->capacity =25;   /* capacity   */
  ti->initialLevel =5;    /* initial level  */
}

/**************      Simulation Start Function      ***************/
/*********  Called by VisSim at the start of simulation  **********/
EXPORT32 void FAR PASCAL EXPORT levelSS (TANK_INFO * ti,long FAR *runCount )
{  if(*runCount > 1)
   ti->initialLevel =5;   /* autorestart:reset initial condition */
}

/****************      Simulation End Function      ***************/
/************  Called by VisSim at the end of simulation **********/
EXPORT32 void FAR PASCAL EXPORT levelSE (TANK_INFO * ti,long FAR*runcount)
{
  debMsg("Simulation End");
}

/*****************     Parameter Change Function   *****************/
/********* Called by VisSim on right mouse button click ************/
EXPORT32 char FAR* PASCAL EXPORT levelPC (TANK_INFO *ti)
{
  tankDlgMFC(ti);   
  return 0; "Capacity;Initial_level";
}
/*****************    Block Event Function   *****************/
/** Called by VisSim on block event occurrance (see vsuser.h for event list) **/
EXPORT32 LPSTR  PASCAL EXPORT levelEvent(HWND h, int msg, WPARAM wParam, LPARAM lParam)
{
  TANK_INFO *ti;
  switch (msg) {
    case WM_VSM_GET_PARAM_DESC:
      return TANK_DESCR;
    case WM_VSM_GET_BLOCK_NAME:
     ti = (TANK_INFO *)lParam;
     return (ti && ti->name[0])?ti->name:"Tank";   // return block name
    }
  return 0;
}

}