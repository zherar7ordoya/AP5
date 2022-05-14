/*************************************************************************
 *              (C) Copyright 1989-1998 Visual Solutions, Inc.           *
 *                      All Rights Reserved                              *
 * This software may not be used, copied or made available to anyone,    *
 * except in accordance with the license under which it is furnished.    *
 *************************************************************************/

#ifndef INC_VSUSER_H
#define INC_VSUSER_H

#ifndef VERSION_10X
#define VERSION_10X 30
#endif

#if defined(_WIN32) /*MSVC 32 */ | defined(__WIN32__) /* Borland 32 */ | defined(_WINNT_) /*MSVC 32 */
#   define EXPORT32 __declspec(dllexport)
# ifndef EXPORT
#   define EXPORT
# endif
# ifndef FAR
#   define FAR
# endif
# ifndef PASCAL
#   define PASCAL _stdcall
# endif
#elif defined(WIN16) || defined( _WINDOWS ) /*MSVC 16 */ || defined(__WINDOWS_H) /* Borland 16 */
#ifndef APIENTRY
# define APIENTRY
#endif
# ifndef EXPORT
#   define EXPORT __export
# endif
# ifndef EXPORT32
#   define EXPORT32
# endif
# ifndef FAR
#   define FAR _far
# endif
# ifndef PASCAL
#   define PASCAL _pascal
# endif
#else
# define EXPORT
# define EXPORT32
# define FAR
# define PASCAL
#endif

#ifndef CDECL
#define CDECL
#endif


#if !defined(_INC_WINDOWS) & !defined(_WINNT_) & !defined(__WINDOWS_H) /* [6/5/96 BC 5.0] && !defined(_Windows) */
typedef unsigned HWND;
typedef unsigned WPARAM;
typedef long LPARAM;
typedef char FAR* LPSTR;
typedef const char FAR* LPCSTR;
typedef int BOOL;
#endif

#define TRUE 1
#define FALSE 0

#ifndef NO_PROTOS
# define  P(s) s
#else
# define P(s) ()
#endif

#if defined __BORLANDC__ || defined(_Windows)   /* Borland defs */
#define _far far
#define _pascal pascal
#endif

#if defined(__TCPLUSPLUS__)  || defined(__cplusplus)
extern "C" {        /* Start C declarations for C++ */
#endif
typedef struct {
  char FAR* menuName;
  char FAR* funcName;
  int inputCount;
  int outputCount;
  int paramCount;
  char FAR* helpText;
} USER_MENU_ITEM;

typedef double FAR DOUBLE;
typedef void FAR *VOID_PTR;
typedef void FAR PASCAL USER_BLOCK( DOUBLE *, DOUBLE *, DOUBLE *);
typedef void FAR PASCAL USER_BLOCK_PI( DOUBLE *param );
typedef LPSTR FAR PASCAL USER_OPT_EVENT(HWND,int,WPARAM,LPSTR);
typedef int FAR PASCAL USER_OPT_FUNC(DOUBLE *unknownVec, int unknownCount
    , int costCount, int globalConstraintCount);
typedef void FAR PASCAL USER_BLOCK_V();
typedef long FAR PASCAL USER_BLOCK_L();
typedef char FAR* FAR PASCAL USER_BLOCK_STR();
typedef USER_BLOCK *USER_BLOCK_FUNC;
typedef USER_BLOCK_PI *USER_BLOCK_FUNC_PI;
typedef LPSTR PASCAL USER_INIT_FUNC(void);
typedef void PASCAL USER_SOLVER_FUNC(void);
typedef LPSTR PASCAL USER_EVENT_FUNC( HWND, int, WPARAM, LPARAM);
typedef LPSTR PASCAL USER_VSM_EVENT_FUNC( int, WPARAM, LPARAM);

/* Return sim time thru arg pointer since not all langs agree
 * on how to return a double val */
EXPORT32 void PASCAL FAR EXPORT getSimTime( DOUBLE *pTime);
EXPORT32 void PASCAL FAR EXPORT getSimTimeStep( DOUBLE *pTimeStep);
EXPORT32 void PASCAL EXPORT stopSimulation( int stopVal); /* 1:stop this run,2:stop multirun */
EXPORT32 void PASCAL EXPORT setBlockErr(void);     /* Flag Block in Red */
EXPORT32 int  EXPORT debMsg P((char FAR *fmt , ... ));
#ifndef _DSP
EXPORT32 void FAR *PASCAL EXPORT galloc (unsigned long size );
EXPORT32 void PASCAL EXPORT gfree (void FAR *freeP );
EXPORT32 void FAR*PASCAL EXPORT grealloc (void FAR *inP , unsigned long size );
#endif
EXPORT32 LPSTR EXPORT getStartUpDirectory(void);
EXPORT32 int  PASCAL EXPORT userSolver();
EXPORT32 LPSTR EXPORT PASCAL vsmEvent( int msg, int wParam, long FAR*arg);
EXPORT32 long EXPORT FAR PASCAL vsmRequest( long FAR*, double FAR*);
EXPORT32 long EXPORT vissimRequest( long , LPARAM, LPARAM);
EXPORT32 void EXPORT setUserBlockMenu P((USER_MENU_ITEM FAR * ));
EXPORT32 void EXPORT setUserBlockMenuExt P((USER_MENU_ITEM FAR *, int ));

#if defined(__TCPLUSPLUS__)  || defined(__cplusplus)
 }        /* End C declarations for C++ */
#endif  /* CPLUSPLUS */

#define MAX_TITLE_LEN (180)
#define MAX_USER_NAME_LEN (80)

typedef enum { IM_EULER, IM_TRAP, IM_RK2, IM_RK4, IM_RK5AS, IM_BULIRSH_STOER, IM_BACK_EULER
} INTEGRATION_METHOD;

#ifndef _DSP
typedef struct {
  float VisSimVersion;
  double timeStart, timePanel, timeEnd, T;
  unsigned char fReadOnly:1, fDisplayPanel:1, showType:1, retainStates:1;
  char product;                 /* product type (demo, professional, etc.) */
  char continuousMode;          /* run simulation in continuous mode */
  char endNotify;               /* notify the user on end simulation w/beep and MessageBox */
  char integrationMethod;   /* integration method in use */
} SIM_INFO;
#endif

typedef enum {
  T_NULL, T_DOUBLE, T_FLOAT, T_INT, T_LONG, T_ULONG
  ,T_CHAR, T_UCHAR, T_SHORT, T_USHORT, T_STRING
  ,T_MAT_DOUBLE, T_MAT_COMPLEX, T_POINTER, T_COMBO_ITEM, T_LAST
} TYPE;

typedef enum {
  S_NULL, S_SCALAR, S_VECTOR, S_MATRIX, S_STRUCT, S_LAST
} SHAPE;

#define IS_INTEGER(t) ((t) >= T_INT)

typedef struct {
  int len;
  DOUBLE *vec;
} VECTOR;
typedef VECTOR FAR* LPVECTOR;

typedef struct
{ 
#ifdef _DSP
  unsigned int isTemp:1;
#else
  unsigned char isTemp:1;
#endif
  unsigned dim1;
  unsigned dim2;
#if VERSION_10X > 20
  unsigned dim3;
#endif
#ifdef _DSP
  float d[1];
#else
  double d[1];
#endif
} FAR MATRIX;

#ifdef _MDEBUG
#define MX(m,j1,j2) *matRef( m, j1, j2)
#define MX1(m,j1,j2) *matRef1( m, j1, j2)
#else
#define MX(m,j1,j2) m->d[(j1) + (j2) * m->dim1]
#define MX1(m,j1,j2) m->d[(j1-1) + (j2-1) * m->dim1]
#endif

#ifdef _MDEBUG
#define M3X(m,j1,j2,j3) *matRef3D( m, j1, j2, j3)
#else
#define M3X(m,j1,j2,j3) m->d[(j1) + (j2)*m->dim1 + (j3)*m->dim2*m->dim1]
#endif

typedef struct {
  unsigned char type;
  union {
    double Double;
    float Float;
    int Int;
    long Long;
#ifdef VISSIM_H
    struct sig_vec FAR* v;
#endif
    MATRIX *m;
  } u;
#if VERSION_10X > 20
  struct node_info* n; // For Version 3.0
#endif
} SIGNAL;


typedef struct {
  double errEpsilon;
  int loopMax;
  unsigned iterationCount;
} OPT_INFO;

typedef struct {
  int iPort;
  LPSTR label;
  char fInput;
} CONNECTOR_DESC;

#ifndef WM_USER
#define WM_USER 0x400
#endif

typedef enum {PROD_UNKNOWN, PROD_RUNTIME, PROD_DEMO, PROD_MICRO,
                PROD_STUDENT, PROD_STUDENT_BOOK, PROD_TRIAL, PROD_FULL} SIM_PRODUCT;

typedef enum {
  VR_NULL, VR_GET_CONSTRAINTS
  , VR_GET_UNKNOWNS, VR_SET_UNKNOWNS
  , VR_GET_SOLVER_INFO, VR_EXECUTE, VR_GET_UNKNOWNS_INPUT
  , VR_SET_BLOCK_MENU, VR_RESET_XFERS, VR_GET_VERSION
  , VR_GET_BLOCK_PARAMS
  , VR_SET_BLOCK_CONNECTOR_COUNT // arg1:BH arg2:Hiword = input, Loword = output
  , VR_GET_GLOBAL_CONSTRAINTS, VR_GET_GLOBAL_CONSTRAINT_BOUNDS, VR_GET_GLOBAL_COST
  , VR_GET_GLOBAL_UNKNOWNS, VR_GET_GLOBAL_UNKNOWN_BOUNDS
  , VR_GET_GLOBAL_UNKNOWNS_INPUT, VR_SET_GLOBAL_UNKNOWNS
  , VR_RUN_SIMULATION, VR_GET_GLOBAL_OPT_INFO, VR_GET_VISSIM_STATE
  , VR_DISABLE_BLOCK_TYPE, VR_GET_STARTUP_DIR, VR_SET_CONNECTOR_LABEL
  , VR_SNAP_STATES, VR_GET_SUB_VERSION, VR_CLEAR_BLOCK_ERR
  , VR_GET_CONNECTOR_COUNT  // arg1:BH arg2: arg2==1 =>input arg2==0 => output
  , VR_GET_BLOCK_POS, VR_SET_BLOCK_POS, VR_SET_CONNECTOR_CHAR, VR_GET_WINDOW_HANDLE
  , VR_REALLOC_USER_PARAM, VR_GET_BLOCK_INPUT
  , VR_GET_BLOCK_OUTPUT   // Return Ptr to output signal vector
  , VR_GET_CUR_BLOCK_HANDLE, VR_GET_RUN_STATE, VR_GET_BLOCK_ID

} VR_CMD;

/* Block event message, called once for each user block in a diagram */
#define WM_VSM_GET_PARAM_DESC   WM_USER+2000
#define WM_VSM_GET_BLOCK_NAME   WM_USER+2001
#define WM_VSM_WINDOW_HANDLE    WM_USER+2002
#define WM_VSM_STOP_SIM         WM_USER+2003
#define WM_VSM_FILE_CLOSE       WM_USER+2004
#define WM_VSM_BLOCK_INFO       WM_USER+2005
#define WM_VSM_INFO             WM_USER+2006
#define WM_VSM_SNAP_STATE       WM_USER+2007
#define WM_VSM_CHECKPOINT_STATE WM_USER+2008
#define WM_VSM_FILE_READ        WM_USER+2009
#define WM_VSM_BLOCK_SETUP      WM_USER+2010
#define WM_VSM_ADD_CONNECTOR    WM_USER+2011  // wp=count lp=1->input:0->output
#define WM_VSM_DEL_CONNECTOR    WM_USER+2012
#define WM_VSM_CREATE           WM_USER+2013
#define WM_VSM_DESTROY          WM_USER+2014
#define WM_VSM_BLOCK_PLACED     WM_USER+2015
#define WM_VSM_GET_BLOCK_BITMAP WM_USER+2016
#define WM_VSM_CONNECTOR_NAME   WM_USER+2017
#define WM_VSM_SIM_START        WM_USER+2018
#define WM_VSM_SIM_END          WM_USER+2019
#define WM_VSM_IS_VEC_CONNECT   WM_USER+2020  /* is wparam port a vector? rtn 1 if true, 0 if false  */
#define WM_VSM_GET_PARAM        WM_USER+2021  /* pass the dll a number and a pointer.  */
#define WM_VSM_PUT_PARAM        WM_USER+2022  /* pass the dll a number a get a pointer.  Allows two dlls to pass information. */
                        /* used from callDllEventFunc but must know NODE pointer which is not generally known.*/
#define WM_VSM_GET_OBJ_CLASS    WM_USER+2023  /* return the object class; not yet supported */
#define WM_VSM_GET_DEFAULT_IN_VAL   WM_USER+2024  /* return the default value for an unconnected input.*/
#define WM_VSM_GET_CONNECTOR_TYPE WM_USER+2025  /* return the datatype for a connector pos are input neg are output*/
#define WM_VSM_BLOCK_LABEL      WM_USER+2026  /* return string for label under block*/
#define WM_VSM_RETAIN_STATE_RESTART WM_USER+2027  /* Sent to each block on sim auto restart */
#define WM_VSM_SIM_RESTART      WM_USER+2028  /* Sent to each block on sim restart due to continue or single step*/
#define WM_VSM_SIM_RESET        WM_USER+2029  /* Sent to each block on sim reset due to user click of reset button  */
#define WM_VSM_GET_CODEGEN_STRING WM_USER+2030  /* Return text of generated code for block, %1=input1, %2=input2 etc. */
#define WM_VSM_SUPPRESS_WARN_UNCONNECT  WM_USER+2031  /* Return TRUE to suppress unconnected block warning */
#define WM_VSM_ALLOC_VEC_OUTPUT  WM_USER+2032  /* Allow user DLL to alloc vector outputs */
#define WM_VSM_GET_CODEGEN_ALLOC_STRING WM_USER+2033  /* Return text of generated data for block, %1=input1, %2=input2 etc. */
#define WM_VSM_GET_CODEGEN_START_STRING WM_USER+2034  /* Return text of init function, %1=input1, %2=input2 etc. */
#define WM_VSM_GET_CODEGEN_END_STRING WM_USER+2035  /* Return text of init function, %1=input1, %2=input2 etc. */
#define WM_VSM_GET_CODEGEN_TARGET WM_USER+2036  /* Return text of codegen target ("PC32", PC44" etc) */
#define WM_VSM_GET_OUT_SIG_VECTOR WM_USER+2037  /* Return Ptr to output signal vector */

/* VisSim Simulation Event message, called once for each DLL */
typedef enum {
  VSE_NULL=WM_USER+3000, VSE_TIME_STEP, VSE_PRE_SIM_START, VSE_POST_SIM_START, VSE_POST_SIM_END
  , VSE_SIM_RESTART, VSE_WINDOW_HANDLE=WM_VSM_WINDOW_HANDLE
} VSE_CMD;

/* VisSim Filter Event message, sent to user added diagram filters. */
typedef enum {
  VFLT_NULL=WM_USER+4000, VFLT_FILE_OPENED, VFLT_FILE_SAVE, VFLT_FILE_SAVE_AS
} VFLT_CMD;

#define VSE_PRE_SIM_STOP WM_VSM_STOP_SIM

/* VisSim Message Flags, passed in wParam for Create and Destroy Message */
#define VMF_IS_MENU                 0x0001
#define VMF_FROM_CLIPBOARD          0x0002

/* VisSim Block Flags, returned by Create Message */
#define VBF_HAS_STATE               0x0001
#define VBF_USE_SIGNAL_DESCRIPTORS  0x0002
#define VBF_ALLOC_VEC_OUTPUT        0x0004
#define VBF_EXECUTE_ALWAYS          0x0008
#define VBF_ALLOW_VEC_CHAMELIONS    0x0010
#define VBF_STRAIGHT_WIRES          0x0020
#define VBF_MENU_ONLY           0xFFFFFFFEL

#endif
