using System ;
using System.Threading;
class Program
{
    static void Main(){
        string Ejercicio_1(){
            Console.WriteLine("INGRESE UN NUMERO");
            int  num1 = Convert.ToInt32(Console.ReadLine());
            if (num1>0){
                return "Es positivo";
            }
            else{
                return " no es positivo";
            }
        }
        string Ejercicio_2(){
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 5==0){
                return "es multiplo";
            }
            else{
                return "No es multiplo";
            }
        }
        int Ejercicio_3(){
            Console.WriteLine("Division entre el numero mayor por el menor");
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo  numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2){
                int Resp = num1/num2;
                return Resp;
            }
            else if (num1 < num2){
                int Resp = num2/num1;
                return Resp;
            }
            else {
                return 0;
            }
        }
        string Ejercicio_4(){
            int año = Convert.ToInt32(Console.ReadLine());
            string resp="";
            if (año%4==0){
                resp = "El año  es bisiesto";
            }
            else{
                resp = "El año  no es bisiesto";
            }
            return resp;

        }
        string Ejercicio_5(){
            Console.WriteLine("Suma de enteros hasta un numero ingresado");
            Console.WriteLine("Ingrese el numero limite");
            int numlim = Convert.ToInt32(Console.ReadLine());
            int cont  = 1 ;
            int suma = 0;
            while(cont<=numlim){
                suma += cont;
                cont++;
            }
            return "La suma de los enteros es: "+ suma;
        }
        String Ejercicio_6(){
            Console.WriteLine("cantidad de numeros pares");
            Console.WriteLine("Ingrese la cantidad de numeros pares que desea");
            int cantnum = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            string numerosPares =  " ";
            while (cont <= cantnum){
            if (cont % 2==0){
                numerosPares += cont + " ";
            }
            cont++;
            }
            return numerosPares;
        }
        string Ejercicio_7(){
            Console.WriteLine("Tabla de multiplicar");
            Console.WriteLine("Ingrese el numero del cual desea la tabla");
            int num = Convert.ToInt32(Console.ReadLine());
            int cont =1;
            string tabla= "";
            while (cont<=12){
                int resultado = num * cont ;
                tabla+= num + " x " + cont + " = "+ resultado+ "\n" ; 
                cont++;
            }
            return tabla;
        }
        string Ejercicio_8(){
            Console.WriteLine("Imprimir los numeros impares hasta un limite");
            Console.WriteLine("Ingrese un limite");
            int limite = Convert.ToInt32(Console.ReadLine());
            string resultado =" ";
            for( int i=1; i<=limite;i++){
                if (i % 2 !=0 ){
                    resultado +=  i + "\n";
                }
            }
            return resultado;
        }
        string Ejercicio_9(){
            Console.WriteLine("Imprimir la suma de los numeros multiplos de 3 y 5 menores que 100");
            int suma =0;
            for (int i=1; i<=100;i++){
                    if (i%3 ==0 ||i%5==0 ){
                        suma+=i;
                    }
            }
            return "La suma es igual a ="+suma;
           
        }
        int Ejercicio_10(){
            Console.WriteLine("Suma de primeros 15 numeros impares");
            int resultado = 0;
            
            for( int i=1; i<=15;i++){
                if (i % 2 !=0 ){
                    resultado +=  i;
                }
            }
            return resultado;
        }
           string Ejercicio_11(){
            Console.WriteLine("Numeros del 1 al 25 descendentes");
            string resultado = " ";
            for( int i=25; i>=1;i--){
                    resultado += i + "\n" ;
            }
            return resultado;
        }
        string Ejercicio_12(){
            Console.WriteLine("Imprimir cada letra de una palabra");
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            
                for(int i=0;i<palabra.Length;i++){
                    Console.WriteLine(palabra[i]+"\n");
            }
            return palabra+ " palabra original";
        }
        int Ejercicio_13(){
          Console.WriteLine("Calcular el factorial de un numero");
          int num =  Convert.ToInt32(Console.ReadLine());
           int cont = 1;
           int resp = 1;
           do{
           resp = cont * resp;
           cont ++;
           }
           while (cont<=num);
           return resp;
        }
        string Ejercicio_14(){
            int producto = 1;
            int numero;
            do{
            Console.WriteLine("Ingrese un numero(cero para terminar)");  
            numero = Convert.ToInt32(Console.ReadLine());  
            if (numero>0){
                producto *= numero;
            }
            }
            while(numero>0);
            return " Elproducto es " + producto;

        }
        string Ejercicio_15(){
            int numero;
            do{
            Console.WriteLine("Ingrese un numero(numero cero para terminar)");  
            numero = Convert.ToInt32(Console.ReadLine());  
            if (numero>0){
                Console.WriteLine("es positivo");
            }
            else{
                Console.WriteLine("es negativo");
            }

            }
            while(numero!=0);
            return "fin del proceso";
        }
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Numero positivo");
            Console.WriteLine("2. Numero múltiplo de 5");
            Console.WriteLine("3. División del mayor por menor");
            Console.WriteLine("4. Año bisiesto");
            Console.WriteLine("5. Suma de los primeros números enteros hasta un número ingresado");
            Console.WriteLine("6. Presentar los números pares hasta un número ingresado");
            Console.WriteLine("7. Tabla de multiplicar");
            Console.WriteLine("8. Presentar los números impares hasta un número ingresado");
            Console.WriteLine("9. Suma de los primeros 15 números impares");
            Console.WriteLine("10. Números descendentes desde el 25 hasta el 1 ");
            Console.WriteLine("11. Imprimir la suma de los números múltiplos de 3 y 5 menores que 100");
            Console.WriteLine("12. Dada una palabra presentar cada uno de sus caracteres línea por línea");
            Console.WriteLine("13. Factorial de un número");
            Console.WriteLine("14. Producto de una serie ingresada hasta que se ingrese el número cero");
            Console.WriteLine("15. Presentarse un número es negativo o positivo de una serie ingresada hasta ingresar el número cero");
            Console.WriteLine("16. Salir");
            Console.WriteLine("Seleccione una opcion:");
            int opcion =Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    
                    Console.WriteLine("selecciono la opcion 1");
                    Console.WriteLine(Ejercicio_1());
                    Thread.Sleep(4000);
            
                    break;
                case 2:
                    Console.WriteLine("selecciono la opcion 2");
                    Console.WriteLine(Ejercicio_2());
                    Thread.Sleep(4000);
                    break;
                case 3:
                    Console.WriteLine("selecciono la opcion 3");
                    Console.WriteLine(Ejercicio_3());
                    Thread.Sleep(4000);
                    break;
                case 4:
                    Console.WriteLine("selecciono la opcion 4");
                    Console.WriteLine(Ejercicio_4());
                    Thread.Sleep(4000);
                    break;
                case 5:
                    Console.WriteLine("selecciono la opcion 5");
                    Console.WriteLine(Ejercicio_5());
                    Thread.Sleep(4000);
                    break;
                case 6:
                    Console.WriteLine("selecciono la opcion 6");
                    Console.WriteLine(Ejercicio_6());
                    Thread.Sleep(4000);
                    break;
                case 7:
                    Console.WriteLine("selecciono la opcion 7");
                    Console.WriteLine(Ejercicio_7());
                    Thread.Sleep(4000);
                    break;
                case 8:
                    Console.WriteLine("selecciono la opcion 8");
                    Console.WriteLine(Ejercicio_8());
                    Thread.Sleep(4000);
                    break;
                case 9:
                    Console.WriteLine("selecciono la opcion 9");
                    Console.WriteLine(Ejercicio_9());
                    Thread.Sleep(4000);
                    break;
                case 10:
                    Console.WriteLine("selecciono la opcion 10");
                    Console.WriteLine(Ejercicio_10());

                    Thread.Sleep(4000);
                    break;
                case 11:
                    Console.WriteLine("selecciono la opcion 11");
                    Console.WriteLine(Ejercicio_11());
                    Thread.Sleep(4000);
                    break;
                case 12:
                    Console.WriteLine("selecciono la opcion 12");
                    Console.WriteLine(Ejercicio_12());
                    Thread.Sleep(4000);
                    break;
                case 13:
                    Console.WriteLine("selecciono la opcion 13");
                    Console.WriteLine(Ejercicio_13());
                    Thread.Sleep(4000);
                    break;
                case 14:
                    Console.WriteLine("selecciono la opcion 14");
                    Console.WriteLine(Ejercicio_14());
                    Thread.Sleep(4000);
                    break;
                case 15:
                    Console.WriteLine("selecciono la opcion 15");
                    Console.WriteLine(Ejercicio_15());
                    Thread.Sleep(4000);
                    break;
                
                case 16:
                    Console.WriteLine("selecciono la opcion  salir");
                    return;

            } 
             
        }
        Console.Clear();
    }

}