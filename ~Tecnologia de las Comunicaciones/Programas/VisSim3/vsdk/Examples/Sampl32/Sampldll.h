/* VSI Sample DLL Example header file */

/* type definitions */

#define MAX_BLOCK_NAME 32
typedef struct _temp_struct {
  int iInfMethod;
  int iDefuzMethod;
  int inputCount;
  int outputCount;
  char name[MAX_BLOCK_NAME];
  char bitmap[MAX_BLOCK_NAME];
} FUZZY_INFO;


/* resource values */
#define IDC_STATIC  -1
#define INF_MAX_MIN   1
#define INF_SUM_PRODUCT   2
#define INF_BOUNDED_SUM   3
#define DEFUZ_YAGERS    1
#define DEFUZ_CENTER_GRAVITY  2
#define DEFUZ_MAX_HEIGHT  3

#define IDD_MINMAX                  105
#define IDD_SUMPROD                 106
#define IDD_BOUNDSUMPROD            107
#define IDD_YAGER                   108
#define IDD_CENTER                  109
#define IDD_MAXHEIGHT               110

#define IDD_FIRST_INFERENCE     (IDD_MINMAX - 1)
#define IDD_FIRST_DEFUZ       (IDD_YAGER - 1)

/* function prototypes */

EXPORT32 BOOL FAR EXPORT PASCAL SampleDllProc(HWND, UINT, WPARAM, LPARAM);

#define IDD_NAME                    111
#define IDD_BITMAP                  112
