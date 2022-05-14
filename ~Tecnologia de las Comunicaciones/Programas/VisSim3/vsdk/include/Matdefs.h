 /************************************************************************
 *              (C) Copyright 1989-1991 Visual Solutions                 *
 *                      All Rights Reserved                              *
 * This software may not be used, copied or made available to anyone,    *
 * except in accordance with the license under which it is furnished.    *
 *************************************************************************/

#ifdef _MDEBUG
#define MX(m,j1,j2) *matRef( m, j1, j2)
#define MX1(m,j1,j2) *matRef1( m, j1, j2)
#else
#define MX(m,j1,j2) m->d[(j1) + (j2) * m->dim1]
#define MX1(m,j1,j2) m->d[(j1-1) + (j2-1) * m->dim1]
#endif

EXPORT32 MATRIX *PASCAL EXPORT matReDecl( MATRIX *m, unsigned dim1, unsigned dim2 );
