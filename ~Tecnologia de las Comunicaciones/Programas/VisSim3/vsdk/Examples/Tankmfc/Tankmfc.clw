; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
ClassCount=2
Class1=CTankwizApp
LastClass=CTankInfo
NewFileInclude2=#include "tankwiz.h"
ResourceCount=1
NewFileInclude1=#include "stdafx.h"
Class2=CTankInfo
LastTemplate=CDialog
Resource1=IDD_DIALOG1

[CLS:CTankwizApp]
Type=0
HeaderFile=tankwiz.h
ImplementationFile=tankwiz.cpp
Filter=N
LastObject=IDC_INITIAL_LEVEL

[DLG:IDD_DIALOG1]
Type=1
Class=CTankInfo
ControlCount=10
Control1=IDOK,button,1342242817
Control2=IDCANCEL,button,1342242816
Control3=IDC_STATIC,static,1342308352
Control4=IDC_FILE_NAME,edit,1350631552
Control5=IDC_CAPACITY,edit,1350631552
Control6=IDC_INITIAL_LEVEL,edit,1350631552
Control7=IDC_STATIC,static,1342308352
Control8=IDC_STATIC,static,1342308352
Control9=IDC_STATIC,static,1342308352
Control10=IDC_ALARM,combobox,1344339971

[CLS:CTankInfo]
Type=0
HeaderFile=TankInfo.h
ImplementationFile=TankInfo.cpp
BaseClass=CDialog
Filter=D
VirtualFilter=dWC
LastObject=CTankInfo

