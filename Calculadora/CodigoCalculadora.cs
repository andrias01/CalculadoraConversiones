using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        long Pantalla, conversionNumero;
        double Primero, Segundo,Total=0;
        string operador="", pantalla, conversionString, operadorBases = "decimal";
        bool evaluacion = true, bandera = false, EncontrarLetra = false, PuntoRepetido=false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Inicio de los botones con numeros 🔽
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("1");//Modulo para mostrar el numero en pantalla
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("2");//Modulo para mostrar el numero en pantalla
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("3");//Modulo para mostrar el numero en pantalla
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("4");//Modulo para mostrar el numero en pantalla
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("5");//Modulo para mostrar el numero en pantalla
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("6");//Modulo para mostrar el numero en pantalla
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("7");//Modulo para mostrar el numero en pantalla
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("8");//Modulo para mostrar el numero en pantalla
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("9");//Modulo para mostrar el numero en pantalla
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.Text == "0")
            {
                return;//Cuando tengo el string cero no poner otro cero
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "0";
            }//Cuando no tiene solo el cero sigue concatenando los string
        }
        //Final de los botones con numeros 🔼
        //Inicio de botones con letras 🔽
        private void LetraA_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("A");//Modulo para mostrar la letra en pantalla
        }
        private void LetraB_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("B");//Modulo para mostrar la letra en pantalla
        }
        private void LetraC_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("C");//Modulo para mostrar la letra en pantalla
        }
        private void LetraD_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("D");//Modulo para mostrar la letra en pantalla
        }
        private void LetraE_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("E");//Modulo para mostrar la letra en pantalla
        }
        private void LetraF_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("F");//Modulo para mostrar la letra en pantalla
        }
        private void LetraI_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("I");//Modulo para mostrar la letra en pantalla
        }
        private void LetraM_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("M");//Modulo para mostrar la letra en pantalla
        }
        private void LetraL_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("L");//Modulo para mostrar la letra en pantalla
        }
        private void LetraV_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("V");//Modulo para mostrar la letra en pantalla
        }
        private void LetraX_Click(object sender, EventArgs e)
        {
            MostrarNumeroEnPantalla("X");//Modulo para mostrar la letra en pantalla
        }
        //Final botones con letras 🔼
        public void EvaluarOperacion(string operacion)
        {
            if (PantallaPrincipal.Text == "")//Si no hay nada
                PantallaPrincipal.Text = "";//Poner nada
            else
            {
                operador = operacion;//operador en forma de string
                Primero = double.Parse(PantallaPrincipal.Text);//Convierte el valor de string a doble
                PantallaPrincipal.Clear();//Limpia la pantalla
            }
        }//Modulo que me dice que operacon tiene cada boton
        public void EvaluarConversionDeLetra(string operacion)
        {
            if (PantallaPrincipal.Text == "")//Si no hay nada
                PantallaPrincipal.Text = "";//Poner nada
            else
            {
                operador = operacion;//operador en forma de strig
                pantalla = PantallaPrincipal.Text; //Toma el valor de la pantalla
                PantallaPrincipal.Clear();//Limpia la pantalla
            }

        }//Modulo que evalua la convercion literal a numerica
        public void EvaluarConversion(string operacion)
        {
            if (PantallaPrincipal.Text == "")//Si no hay nada
                PantallaPrincipal.Text = "";//Poner nada
            else
            {
                operadorBases = operacion;//operador en forma de strig
                Pantalla = long.Parse(PantallaPrincipal.Text); //Convierte el valor de string a long
                PantallaPrincipal.Clear();//Limpia la pantalla
            }
        }//Modulo para evaluar la convercion numerica y literal
        public void verSihayLetras(string textoPantalla)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'M', 'L', 'X', 'V', 'I' };
            for (int i = 0; i < textoPantalla.Length; i++)//El for se repite segun el largo del string en pantalla
            {
                int a = textoPantalla[i];//Variable a toma los valores del string por cada vuelta
                int c = i;//Variable c es para analizar la otra cadena la cual tiene las letras
                for (int p = c; p < letras.Length; p++)//Este for realiza la segunda reviciòn para comparar
                {
                    int b = letras[p];
                    if (a == b)//Cuando son repetidas las letras
                    {
                        EncontrarLetra = true;//se cambia el buleano a true
                    }
                }
            }
        }//Modulo que identifica si hay alguna letra en pantalla
        public void verSiHayComas(string textoPantalla)
        {
            char[] punto1 = { ',' };
            for (int i = 0; i < textoPantalla.Length; i++)//El for se repite segun el largo del string en pantalla
            {
                int a = textoPantalla[i];//Variable 'a' toma los valores del string por cada vuelta
                int c = 0;//Varible 'c' inica en cero para el sigiente for
                for (int p = c; p < punto1.Length; p++)//Este for realiza la segunda reviciòn para comparar
                {
                    int b = punto1[p];//Da el valor de coma ','
                    if (a == b)//Cuando son repetidos los puntos se bloquea
                        PuntoRepetido = true;//No pone nada
                }
            }
        }//Modulo que identifica si hay mas de una coma en pantalla
        public void verSihayNumeros(string textoPantalla)
        {
            char[] Numeros1 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < textoPantalla.Length; i++)//El for se repite segun el largo del string en pantalla
            {
                int a = textoPantalla[i];//Variable a toma los valores del string por cada vuelta
                int c = i;//Variable c es para analizar la otra cadena la cual tiene las letras
                for (int p = c; p < Numeros1.Length; p++)//Este for realiza la segunda reviciòn para comparar
                {
                    int b = Numeros1[p];
                    if (a == b)//Cuando son repetidas las letras
                    {
                        bool EncontrarLetra = true;//se cambia el buleano a true
                    }
                }
            }
        }//Modulo que identifica si hay algun numero en pantalla
        //Inicio de botones para las operaciones 🔽
        public void Suma_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (bandera == false)
            {
                if (EncontrarLetra == false)
                {
                    if (operador == "+" || operador == "-" || operador == "/" || operador == "*")//Cuando operador tiene un signo
                    {
                        Segundo = double.Parse(PantallaPrincipal.Text);//Guarda el numero en pantalla como segundo
                        PantallaPrincipal.Clear();
                        OperacionesPorBoton(Primero, operador, Segundo);//Modulo que hace la operacion por cada boton de signo
                        Primero=Total;//Total se convierte en el valor final de cada operacion
                        PantallaDos.Text = Convert.ToString(Total);//Lo imprime en la pantalla total
                        operador = "+";//Deja activo el operador suma para la siguiente operacion
                        PantallaPrincipal.Clear();
                    }
                    if (operador == "" )
                        EvaluarOperacion("+");
                    bandera = true; //La bandera la cambio para que no genere error cuando preciono el boton otra vez
                }
                if (EncontrarLetra==true)
                    PantallaPrincipal.Text = "OPERACION NO VALIDA";
            }
            else
                PantallaPrincipal.Text = "NO REPETIR UN OPERADOR";
        }
        private void Resta_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (bandera == false)
            {
                if (EncontrarLetra == false)
                {
                    if (operador == "-" || operador == "+" || operador == "/" || operador == "*")
                    {
                        Segundo = double.Parse(PantallaPrincipal.Text);
                        PantallaPrincipal.Clear();
                        OperacionesPorBoton(Primero, operador, Segundo);
                        Primero = Total;
                        PantallaDos.Text = Convert.ToString(Total);
                        operador = "-";
                        PantallaPrincipal.Clear();
                    }
                    if (operador == "" )
                        EvaluarOperacion("-");
                    bandera = true;//La bandera la cambio para que no genere error cuando preciono el boton otra vez
                }
                if (EncontrarLetra == true)
                    PantallaPrincipal.Text = "OPERACION NO VALIDA";
            }
            else
                PantallaPrincipal.Text = "NO REPETIR UN OPERADOR";
        }
        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (bandera == false)
            {
                if (EncontrarLetra == false)
                {
                    if (operador == "*" || operador == "+" || operador == "/" || operador == "-")
                    {
                        Segundo = double.Parse(PantallaPrincipal.Text);
                        PantallaPrincipal.Clear();
                        OperacionesPorBoton(Primero, operador, Segundo);
                        Primero = Total;
                        PantallaDos.Text = Convert.ToString(Total);
                        operador = "*";
                        PantallaPrincipal.Clear();
                    }
                    if (operador == "" )
                        EvaluarOperacion("*");
                    bandera = true;//La bandera la cambio para que no genere error cuando preciono el boton otra vez
                }
                if (EncontrarLetra == true)
                    PantallaPrincipal.Text = "OPERACION NO VALIDA";
            }
            else
                PantallaPrincipal.Text = "NO REPETIR UN OPERADOR";
        }
        private void Division_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (bandera == false)
            {
                if (EncontrarLetra == false)
                {
                    if (operador == "/" || operador == "+" || operador == "-" || operador == "*")
                    {
                        Segundo = double.Parse(PantallaPrincipal.Text);
                        PantallaPrincipal.Clear();
                        OperacionesPorBoton(Primero, operador, Segundo);
                        Primero = Total;
                        PantallaDos.Text = Convert.ToString(Total);
                        operador = "/";
                        PantallaPrincipal.Clear();
                    }
                    if (operador == "" )
                        EvaluarOperacion("/");
                    bandera = true;//La bandera la cambio para que no genere error cuando preciono el boton otra vez
                }
                if (EncontrarLetra == true)
                    PantallaPrincipal.Text = "OPERACION NO VALIDA";
            }
            else
                PantallaPrincipal.Text = "NO REPETIR UN OPERADOR";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("%");//Modulo para asignar y evaluar operador
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla pone el mensaje
                PantallaPrincipal.Text = "OPERACION NO VALIDA HAY LETRAS";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("LN");// Modulo para asignar un operador
                PantallaPrincipal.Text = Convert.ToString(Operadores.LN(Primero));//Evalua el logaritmo
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla pone el mensaje
                PantallaPrincipal.Text = "OPERACION NO VALIDA HAY LETRAS";
        }
        private void Cuadrado_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("x.x");// Modulo para asignar un operador
                PantallaPrincipal.Text = Convert.ToString(Operadores.Cuadrado(Primero));//Evalua el numero al cuadrado
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla pone el mensaje
                PantallaPrincipal.Text = "OPERACION NO VALIDA HAY LETRAS";
        }
        private void RaizCuadrada_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("√");// Modulo para asignar un operador
                PantallaPrincipal.Text = Convert.ToString(Operadores.Raiz(Primero));//Evalua la raiz del numero
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla pone el mensaje
                PantallaPrincipal.Text = "OPERACION NO VALIDA HAY LETRAS";
        }
        private void MasMenos_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("-/+");
                PantallaPrincipal.Text = Convert.ToString(Operadores.MasMenos(Primero));//Multiplica por -1
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla pone el mensaje
                PantallaPrincipal.Text = "OPERACION NO VALIDA HAY LETRAS";
        }
        //Final de los botones para las operaciones 🔼
        //Inicio de botones de operaciones trigonometricas 🔽
        private void SENO_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("sin");
                PantallaPrincipal.Text = Convert.ToString(Operadores.SENO(Primero));//Arroja el valor seno del numero en pantalla    
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
                PantallaPrincipal.Text = "NO VALIDO POR LETRAS";
        }
        private void COSENO_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("cos");
                PantallaPrincipal.Text = Convert.ToString(Operadores.COSENO(Primero));
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
                PantallaPrincipal.Text = "NO VALIDO POR LETRAS";
        }
        private void TANGENTE_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                EvaluarOperacion("tan");
                PantallaPrincipal.Text = Convert.ToString(Operadores.TANGENTE(Primero));
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
                PantallaPrincipal.Text = "NO VALIDO POR LETRAS";
        }
        //Final botones de operaciones trigonometricas 🔼
        //Inicio de botones de converciones Decimales y Romanos 🔽
        private void DeciRoma_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                if (PantallaPrincipal.Text == "")
                    PantallaPrincipal.Text = "";//Cuando la pantalla esta vacia sigue dejando en vacio
                else if (PantallaPrincipal.Text == "0")
                    PantallaPrincipal.Text = "0";
                else
                {
                    pantalla = PantallaPrincipal.Text;//Cuando no esta vacia hace la converciòn
                    PantallaPrincipal.Text = Operadores.DecimalAromano(int.Parse(pantalla));//Decimal a Romano
                }
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
                PantallaPrincipal.Text = "NO SE PUEDE CONVERTIR POR QUE HAY LETRAS";
        }//Convercion de Decimal a Romano
        private void RomaDeci_Click(object sender, EventArgs e)
        {
            verSihayNumeros(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay numeros
            {
                if (PantallaPrincipal.Text == "")
                    PantallaPrincipal.Text = "";//Cuando la pantalla esta vacia sigue dejando en vacio
                if (PantallaPrincipal.Text == "0")
                    PantallaPrincipal.Text = "0";
                else
                {
                    pantalla = PantallaPrincipal.Text;
                    PantallaPrincipal.Text = Convert.ToString(Operadores.RomanoAdecimal(pantalla));
                }
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
                PantallaPrincipal.Text = "NO SE PUEDE CONVERTIR POR QUE HAY NUMEROS";
        }//Convercion de Romano a Decimal
        //Final botones de converciones Decimales y Romanos 🔼
        //Inicio de botones de converciones Binarias,Octale,Decimales y Hexadecimales 🔽
        private void buttonBINARIO_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
            {
                EvaluarConversion("binario");
                Pantalla = Operadores.HexadecimalaBinario(pantalla);
                PantallaPrincipal.Text = Pantalla.ToString(); //El resultado de hexadecimal a binario
                EncontrarLetra = false;
            }
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                switch (operadorBases)
                {
                    case "decimal":
                        EvaluarConversion("binario");
                        conversionNumero = Operadores.DecimalaBinario(Pantalla);
                        PantallaPrincipal.Text = conversionNumero.ToString();
                        break;
                    case "octal":
                        EvaluarConversion("binario");
                        conversionNumero = Operadores.OctalaBinario(Pantalla);
                        PantallaPrincipal.Text = conversionNumero.ToString();
                        break;
                    case "binario":
                        PantallaPrincipal.Text = PantallaPrincipal.Text;
                        operadorBases = "binario";
                        break;
                }
            }
        }
        private void buttonOCTAL_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                switch (operadorBases)
                {
                    case "binario":
                        EvaluarConversion("octal");
                        conversionNumero = Operadores.BinarioaOctal(Pantalla);
                        PantallaPrincipal.Text = conversionNumero.ToString();
                        break;
                    case "decimal":
                        EvaluarConversion("octal");
                        conversionNumero = Operadores.DecimalaOctal(Pantalla);
                        PantallaPrincipal.Text = conversionNumero.ToString();
                        break;
                    case "octal":
                        PantallaPrincipal.Text = PantallaPrincipal.Text;
                        operadorBases = "octal";
                        break;
                }
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
            {
                operador = "octal";//operador en forma de string
                pantalla = PantallaPrincipal.Text; //lee lo que hay en pantalla
                PantallaPrincipal.Clear();//Limpia la pantalla
                long Octal1;
                Octal1 = Operadores.HexadecimalaOctal(pantalla);
                PantallaPrincipal.Text = Octal1.ToString(); //El resultado de hexadecimal a octal
                EncontrarLetra = false;
            }
        }
        private void buttonDECIMAL_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                switch (operadorBases)
                {
                    case "binario":
                        EvaluarConversion("decimal");
                        conversionNumero = Operadores.BinarioaDecimal(Pantalla);
                        PantallaPrincipal.Text = conversionNumero.ToString();
                        break;
                    case "octal":
                        EvaluarConversion("decimal");
                        conversionNumero = Operadores.OctalaDecimal(Pantalla);
                        PantallaPrincipal.Text = conversionNumero.ToString();
                        break;
                    case "decimal":
                        PantallaPrincipal.Text = PantallaPrincipal.Text;
                        operadorBases = "decimal";
                        break;
                }
            }
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
            {
                pantalla = PantallaPrincipal.Text; //lee lo que hay en pantalla
                PantallaPrincipal.Clear();//Limpia la pantalla
                long Decimal1;
                Decimal1 = Operadores.HexadecimalaDecimal(pantalla);
                PantallaPrincipal.Text = Decimal1.ToString(); //El resultado de hexadecimal a DEcimal
                EncontrarLetra = false;
                operadorBases = "decimal";//operador en forma de string
            }
        }
        private void buttonHEXADECIMAL_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text; //lee lo que hay en pantalla
                EncontrarLetra = true;
                operador = "hex";//operador en forma de string
            }
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                switch (operadorBases)
                {
                    case "binario":
                        EvaluarConversion("hex");
                        pantalla = Operadores.BinarioaHexadecimal(Pantalla);
                        PantallaPrincipal.Text = pantalla;
                        break;
                    case "decimal":
                        EvaluarConversion("hex");
                        pantalla = Operadores.DecimalaHexadecimal(Pantalla);
                        PantallaPrincipal.Text = pantalla;
                        break;
                    case "octal":
                        EvaluarConversion("hex");
                        pantalla = Operadores.OctalaHexadecimal(Pantalla);
                        PantallaPrincipal.Text = pantalla;
                        break;
                    case "hex":
                        PantallaPrincipal.Text = PantallaPrincipal.Text; //lee lo que hay en pantalla
                        EncontrarLetra = true;
                        break;
                }
            }
        }
        //Final botones de converciones Binarias,Octale,Decimales y Hexadecimales🔼
        public void MostrarNumeroEnPantalla(string numero)
        {
            if (evaluacion==true)
            {
                PantallaPrincipal.Text = "";
                PantallaPrincipal.Text = numero;
                evaluacion = false;
                bandera = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + numero;
                bandera = false;
            }
        }//Boton que pone el numero en pantalla y va concatenando
        private void Punto_Click(object sender, EventArgs e)
        {
            verSiHayComas(PantallaPrincipal.Text);
            if (PuntoRepetido == false)//Cuando no hay puntos se pone una coma NORMAL
                MostrarNumeroEnPantalla(",");
        }//Boton de punto
        private void Igual_Click(object sender, EventArgs e)
        {
            verSihayLetras(PantallaPrincipal.Text);
            if (EncontrarLetra == true)//Cuando se encuentra una letra en pantalla
                PantallaPrincipal.Text = "NO VALIDO PORQUE LAS LETRAS NO OPERAN";
            if (EncontrarLetra == false)//Cuando no hay letras
            {
                if (PantallaPrincipal.Text == "") //Si no hay nada en pantalla 
                    PantallaPrincipal.Text = "";//Pone nada en pantalla
                else
                {
                    Segundo = double.Parse(PantallaPrincipal.Text);//Toma el segundo numero que esta en pantalla
                    double Sum, Rest, Multi, Div, Porc;//Creo las variables que utilizare
                    switch (operador)
                    {
                        case "+"://El caso que el operador sea suma
                            Sum = Operadores.Suma((Primero), (Segundo));//LLamo la clase que opera
                            PantallaPrincipal.Text = Sum.ToString();//Convierto el resultado en string
                            Primero = 0;
                            PantallaDos.Text = Sum.ToString();
                            operador = "";
                            break;
                        case "-"://El caso que el operador sea resta
                            Rest = Operadores.Resta((Primero), (Segundo));
                            PantallaPrincipal.Text = Rest.ToString();
                            Primero = 0;
                            PantallaDos.Text = Rest.ToString();
                            operador = "";
                            break;
                        case "*"://El caso que el operador sea multiplicaciòn
                            Multi = Operadores.Multiplicacion((Primero), (Segundo));
                            PantallaPrincipal.Text = Multi.ToString();
                            Primero = 0;
                            PantallaDos.Text = Multi.ToString();
                            operador = "";
                            break;
                        case "/"://El caso que el operador sea diviciòn
                            Div = Operadores.Divicion((Primero), (Segundo));
                            PantallaPrincipal.Text = Div.ToString();
                            Primero = 0;
                            PantallaDos.Text = Div.ToString();
                            operador = "";
                            break;
                        case "%"://El caso que el operador sea porcentaje 
                            Porc = Operadores.porcentaje((Primero), (Segundo));
                            PantallaPrincipal.Text = Porc.ToString();
                            Primero = 0;
                            PantallaDos.Text = Porc.ToString();
                            operador = "";
                            break;
                    }
                }
            }
        }//El boton igual para iniciar la operacion con el primer numero y el segundo
        private void Closer_Click(object sender, EventArgs e)
        {
            Close();
        }//Boton closer para cerrar la calculadora
        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.Clear();
            Total = 0;
            PantallaDos.Clear();
            operador = "";
            operadorBases = "decimal";
        }//Boton para limpiar todo
        private void BorrarUno_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.Text.Length == 1)//Si en la pantalla hay solo un numero o letra
                PantallaPrincipal.Text = "";//Deja vacia la pantalla
            
            else if (PantallaPrincipal.Text.Length == 0)//Si No hay nada en la pantalla
                PantallaPrincipal.Text = "";//Deja nada en pantalla
            else
                PantallaPrincipal.Text = PantallaPrincipal.Text.Substring(0, PantallaPrincipal.Text.Length - 1);//Si es mayor a uno va quitando el ultimo elemento
        }//Boton que quita el ultimo numero de pantalla
        public void OperacionesPorBoton(double numero1, string operador, double numero2)
        {
            switch (operador)
            {
                case "+"://El caso que el operador sea suma
                    Total = Operadores.Suma((numero1), (numero2));//LLamo la clase que opera
                    //Sum.ToString();//Convierto el resultado en string
                    PantallaPrincipal.Text = Total.ToString();//Convierto el resultado en string
                    break;
                case "-"://El caso que el operador sea resta
                    Total = Operadores.Resta((numero1), (numero2));
                    //return Rest.ToString();
                    PantallaPrincipal.Text = Total.ToString();
                    break;
                case "*"://El caso que el operador sea multiplicaciòn
                    Total = Operadores.Multiplicacion((numero1), (numero2));
                    //return Multi.ToString();
                    PantallaPrincipal.Text = Total.ToString();
                    break;
                case "/"://El caso que el operador sea diviciòn
                    Total = Operadores.Divicion((numero1), (numero2));
                    //return Div.ToString(); 
                    PantallaPrincipal.Text = Total.ToString();
                    break;
                case "%"://El caso que el operador sea porcentaje 
                    Total = Operadores.porcentaje((numero1), (numero2));
                    //return Porc.ToString(); 
                    PantallaPrincipal.Text = Total.ToString();
                    break;
            }
            
        }//Modulo que hace las operaciones recurrentes
    }
    public class Operadores//Esta Clase contiene cada operacion matematica para la calculadora
    {
        public static double SENO(double numero)
        {
            double C,D;
            C = numero  *(180/ Math.PI);//Esto me pasa el numero de radianes a un algulo
            D = Math.Sin(C);//Metodo que opera el seno
            return D;
        }//Modulo seno en angulo
        public static double COSENO(double numero)
        {
            double C, D;
            C =Math.PI* numero / 180.0;//Esto me pasa el numero de radianes a un algulo
            D = Math.Cos(C);//Metodo que opera el coseno
            return D;
        }//Modulo coseno en angulo
        public static double TANGENTE(double numero)
        {
            double C, D;
            C = numero * (Math.PI / 180);//Esto me pasa el numero de radianes a un algulo
            D = Math.Tan(C);//Metodo que opera el tangente
            return D;
        }//Modulo tangente en angulo
        public static double MasMenos(double numero)
        {
            double C;
            C = numero *(-1);//multiplica por -1 si es positivo el numero queda negativo y si es negativo queda positivo
            return C;
        }//Modulo que cambia el signo del numero en pantalla
        public static double Raiz(double numero)
        {
            double B;
            B = Math.Sqrt(numero);//Metodo que calcula la raiz cuadrada
            return B;
        }//Modulo que encuentra la raiz de un numero
        public static double Cuadrado(double numero)
        {
            double A;
            A = Math.Pow(numero,2);//Metodo que calcula el cuadrado de un numero 
            return A;
        }//Modulo que calcula el cuadrado de un numero
        public static double LN(double numero)
        {
            double L;
            L = 1 / numero;
            return L;
        }//Modulo que calcula el logaritmo de un numero
        public static double porcentaje(double n1, double n2)
        {
            double P;
            P = (n1 * n2) / 100;
            return P;
        }//Modulo que encuentra el procentaje de un numero con otro
        public static double Suma(double n1,double n2)
        {
            double S;
            S = n1 + n2;
            return S;
        }//Modulo que hace la suma entre dos numeros
        public static double Resta(double n1, double n2)
        {
            double R;
            R = n1 - n2;
            return R;
        }//Modulo que hace la resta entre dos numeros
        public static double Multiplicacion(double n1, double n2)
        {
            double M;
            M = n1 * n2;
            return M;
        }//Modulo que hace la diviciòn entre dos numeros
        public static double Divicion(double n1, double n2)
        {
            double D;
            D = n1 / n2;
            return D;
        }//Modulo que hace la diviciòn entre dos numeros
        public static long DecimalaBinario(long numero)
        {
            long binario = 0;
            const int DIVISOR = 2;
            long digito = 0;
            for (long i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario;
        }//Modulo que convierte un numero decimal en binario
        public static long BinarioaOctal(long binario)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
            for (long i = binario, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    numero = numero-1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            //return numero;
            int p, q, Octal = 0;
            int DecimalNumero = numero;
            p = 1;
            for (q = DecimalNumero; q > 0; q = q / 8)
            {
                Octal = Octal + (q % 8) * p;
                p *= 10;
                DecimalNumero /= 8;
            }
            return Octal;
        }//Modulo que convierte un numero binario en octal 
        public static string DecimalaHexadecimal(long Decimal)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
            String hexadecimal = "";
            const int DIVISOR2 = 16;
            long resto = 0;
            for (long i = Decimal % DIVISOR2, j = 0; Decimal > 0; Decimal /= DIVISOR2, i = Decimal % DIVISOR2, j++)
            {                                   // condicion de i--------Condicion de j
                resto = i % DIVISOR2;
                if (resto >= 10)                   // LISTO PROFE .....
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;
                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }
            return hexadecimal;
        }//Modulo que convierte un numero decimal en hexadecimal
        public static long OctalaDecimal(long octal)
        {
            long numero = 0;
            long digito = 0;
            const int DIVISOR = 10;
            for (long i = octal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (long)i % DIVISOR;
                if (!(digito >= 0 && digito <= 7))
                {
                    return -1;
                }
                numero += digito * (long)Math.Pow(8, j);
            }
            return numero;
        }//Modulo que convierte un numero octal en decimal
        public static long HexadecimalaBinario(string hex)
        {
            long numero = 0;
            const int DIVISOR = 16;
            for (int i = 0, j = hex.Length - 1; i < hex.Length; i++, j--)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    numero += (long)Math.Pow(DIVISOR, j) * Convert.ToInt64(hex[i] + "");
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    numero += (long)Math.Pow(DIVISOR, j) * Convert.ToInt64((hex[i] - 'A' + 10) + "");
                }
                else
                {
                   numero= numero -1;
                }
            }
            //return numero;
            //La varible numero es el valor de hexadecimal a decimal
            //Ahora sigue cambiar el decimal a binario
            long binario = 0;
            const int DIVISOR2 = 2;
            long digito = 0;
            for (long i = numero % DIVISOR2, j = 0; numero > 0; numero /= DIVISOR2, i = numero % DIVISOR2, j++)
            {
                digito = i % DIVISOR2;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario;
        }//Modulo que convierte un numero hexadecimal en binario
        public static long HexadecimalaDecimal(string hex)
        {
            long numero = 0;
            const int DIVISOR = 16;
            for (int i = 0, j = hex.Length - 1; i < hex.Length; i++, j--)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    numero += (long)Math.Pow(DIVISOR, j) * Convert.ToInt64(hex[i] + "");
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    numero += (long)Math.Pow(DIVISOR, j) * Convert.ToInt64((hex[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }
            }
            return numero;
        }//Modulo que convierte un numero hexadecimal en decimal
        public static long HexadecimalaOctal(string hex)
        {
            long numero = 0;
            const int DIVISOR = 16;
            for (int i = 0, j = hex.Length - 1; i < hex.Length; i++, j--)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    numero += (long)Math.Pow(DIVISOR, j) * Convert.ToInt64(hex[i] + "");
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    numero += (long)Math.Pow(DIVISOR, j) * Convert.ToInt64((hex[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }
            }
            //return numero;
            //La variable numero es un decimal
            //ahora vamos a cambiar ese decimal por octal
            long p, q, Octal = 0;
            long DecimalNumero = numero;
            p = 1;
            for (q = DecimalNumero; q > 0; q = q / 8)
            {
                Octal = Octal + (q % 8) * p;
                p *= 10;
                DecimalNumero /= 8;
            }
            return Octal;
        }//Modulo que convierte un numero hexadecimal en octal
        public static string DecimalAromano(int num)
        {
            int[] decimalValue = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanNumeral = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int num_cp = num; 
            String result = "";
            for (var i = 0; i < decimalValue.Length; i = i + 1)
            { 
                while (decimalValue[i] <= num_cp)
                {
                    result = result + romanNumeral[i];
                    num_cp = num_cp - decimalValue[i];
                }
            }
            return result;
        }//Modulo que convierte un numero decimal en romano
        public static int RomanoAdecimal(string numero)
        {
            int result = 0; 
            foreach (char letra in numero)
                result += letraAnumero(letra);//Cada ves que encuentre una letra romana va sumando su valor
            if (numero.Contains("IV") || numero.Contains("IX"))//Si encuentra esto 'IV' o esto 'IX' resta dos 
                result -= 2;
            if (numero.Contains("XL") || numero.Contains("XC"))//Si encuentra esto 'XL' o esto 'XC' resta 20 
                result -= 20;
            if (numero.Contains("CD") || numero.Contains("CM"))//Si encuentra esto 'CD' o esto 'CM' resta 200 dos 
                result -= 200;
            return result;
        }//Modulo que convierte un numero romano en decimal
        public static int letraAnumero(char letra)//Este modulo es necesario para el de romanoAdecimal porque da valor a las letras romanas
        {
            switch (letra)
            {
                case 'M':
                        return 1000;
                case 'D':
                        return 500;
                case 'C':                   
                        return 100;                  
                case 'L':
                        return 50;
                case 'X':
                        return 10;          
                case 'V':
                        return 5;                  
                case 'I':
                        return 1;
                default:
                    return 0;
            }
        }
        public static long BinarioaDecimal(long binario)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
            for (long i = binario, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            return numero;
        }//Modulo que convierte un numero binario en decimal
        public static string BinarioaHexadecimal(long binario)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
            for (long i = binario, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    numero = numero - 1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            //La variable numero hasta aqui es un numero decimal entero
            //return numero;
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            String hexadecimal = "";

            const int DIVISOR2 = 16;
            long resto = 0;

            for (int i = numero % DIVISOR2, j = 0; numero > 0; numero /= DIVISOR2, i = numero % DIVISOR2, j++)
            {
                resto = i % DIVISOR2;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }
            return hexadecimal;
        }//Modulo que convierte un numero binario en hexadecimal
        public static long DecimalaOctal(long Decimal)
        {
            long p, q, Octal = 0;
            long DecimalNumero = Decimal;
            p = 1;
            for (q = DecimalNumero; q > 0; q = q / 8)
            {
                Octal = Octal + (q % 8) * p;
                p *= 10;
                DecimalNumero /= 8;
            }
            return Octal;
        }//Modulo que convierte de numero decimal a octal
        public static long OctalaBinario(long octal)
        {
            long numero = 0;
            long digito = 0;
            const int DIVISOR = 10;
            for (long i = octal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (long)i % DIVISOR;
                if (!(digito >= 0 && digito <= 7))
                {
                    return -1;
                }
                numero += digito * (long)Math.Pow(8, j);
            }
            //return numero;
            //La variable numero es un decimal
            long binario = 0;
            const int DIVISOR2 = 2;
            long digito2 = 0;
            for (long i = numero % DIVISOR2, j = 0; numero > 0; numero /= DIVISOR2, i = numero % DIVISOR2, j++)
            {
                digito2 = i % DIVISOR2;
                binario += digito2 * (long)Math.Pow(10, j);
            }
            return binario;
        }//Modulo que convierte un numero octal en binario
        public static string OctalaHexadecimal(long octal)
        {
            long numero = 0;
            long digito = 0;
            const int DIVISOR = 10;
            for (long i = octal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (long)i % DIVISOR;
                if (!(digito >= 0 && digito <= 7))
                {
                    numero = numero - 1;
                }
                numero += digito * (long)Math.Pow(8, j);
            }
            //return numero;
            //La varible numero es el valor de octal a decimal
            //Ahora sigue cambiar el decimal a hexadecimal
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
            String hexadecimal = "";
            const int DIVISOR2 = 16;
            long resto = 0;
            for (long i = numero % DIVISOR2, j = 0; numero > 0; numero /= DIVISOR2, i = numero % DIVISOR2, j++)
            {
                resto = i % DIVISOR2;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;
                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }
            return hexadecimal;
        }//Modulo que convierte un numero octal en hexadecimal
    }
}
