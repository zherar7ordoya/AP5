from functools import reduce
import numpy

# SUMA YA ESTÁ HECHA (USANDO NUMPY), FALTA EL RESTO...

#lambda calculator
def LambdaCalculator():
    quit_l = False
    quit2_l = False
    dzialanie =' '
    while quit_l !=True:
        x=0.0
        y=0.0
        z=0.0
        print("Welcome in calculator")
   
        while quit2_l != True:
            print("\nto add two numbers type '+'")
            print("to subtract two numbers type '-'")
            print("to multiply two numbers type'*'")
            print("to divide two numbers type '/'")
            print("to exit type 'q'")
            dzialanie=(input('\n which operation you want to choose? '))
           
            #excpetion handler and adding        
            def executeAddition(x, y):
                try:
                    ##z = lambda x, y: float(x) + float(y)
                    #return z(x, y)
                    numeros = numpy.array([x, y])
                    acumulador = lambda m, n: float(m) + float(n)
                    return reduce(acumulador, numeros)
                except:
                    print('Fallo en Suma')
       
            if str(dzialanie)=='+':
                print("result is: "  + str(executeAddition(input("input 1st number: "), input("input 2nd number: "))))
   
            
            #excpetion handler and multiplying        
            def executeMultip(x, y):
                try:
                    z = lambda x, y: float(x) * float(y)
                    # you need to execute the lambda, like this:
                    return z(x, y)
                except:
                    print('Exception caught')

            if str(dzialanie)=='*':
                multip = lambda x,y : x * y
                print("result is: "  + str(executeMultip(input("input 1st number: ")), int(input("input 2nd number: "))))
       
            #excpetion handler and subtracting        
            def executeSubtract(x, y):
                try:
                    z = lambda x, y: float(x) - float(y)
                    # you need to execute the lambda, like this:
                    return z(x, y)
                except:
                    print('Exception caught')
                
            if str(dzialanie)=='-':
                subtract = lambda x,y : x - y
                print("result is: "  + str(executeSubtract(input("input 1st number: ") , input("input 2nd number: "))))
  
                
            #excpetion handler and dividing        
            def executeDiv(x, y):
                try:
                    z = lambda x, y: float(x) / float(y)
                    # you need to execute the lambda, like this:
                    return z(x, y)
                except:
                    print('Exception caught')

            if str(dzialanie)=='/':
                print("result is: "  + str(executeDiv(input("input 1st number: "), input("input 2nd number: "))))

   
                   
   
            if str(dzialanie)=='q':
                quit_l = True
                quit2_l = True
                print ("\nsubprogram finished, returning to main menu\n")
                break
            else:
                x=1
 
 


#main program
if __name__ == '__main__':
    LambdaCalculator()
