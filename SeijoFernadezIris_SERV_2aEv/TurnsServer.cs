using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace SeijoFernadezIris_SERV_2aEv
{
    /*
     Se desea realizar un servidor de turnos, para ello se creará un nuevo proyecto de consola en Visual Studio denominado
    ApellidosNombre_SERV_2aEv. En dicho proyecto se creará una nueva clase denominada TurnsServer con, al menos, los campos
    privados siguientes(no son necesarios set/get, no son estáticos):
    students: Array de strings con los nombres de los alumnos en minúsculas.
    teacherPass: string que será la contraseña del profesor.
    ports: Array de dos ints con los posibles puertos de escucha, el primero será 135 el segundo en principio 0 luego se cambiará.
    queue: Colección de strings que será la cola de alumnos a la espera de ser atendidos.

     */
    class TurnsServer
    {
        private string[] students;
        private string teacherPass;
        private int[] ports = new int[] { 135,0 };
        private List<string> queue;

        public void prueba()
        {
            //Console.WriteLine("31416 :"+TestPort("31416"));
            //Console.WriteLine("-3 :"+TestPort("-3"));
            //Console.WriteLine("111 :"+TestPort("111"));
            //Console.WriteLine("aa :"+TestPort("aa"));
            //Console.WriteLine("1141414141414141 :" + TestPort("1141414141414141"));
        }

        /// <summary>
        /// Método privado TestPort: Tiene como parámetro un string. La función comprobará si dicho string es un puerto válido para 
        ///un servidor(no hagas aquí la comprobación de ocupado). Convierte y devuelve el puerto como int si es válido o -1 si no lo es
        /// </summary>
        /// <param name="isPort"></param>
        /// <returns></returns>
        private int TestPort(string isPort)
        {
            int portValid;
            try
            {
                portValid = Convert.ToInt32(isPort);
                if (portValid >= IPEndPoint.MinPort && portValid <= IPEndPoint.MaxPort)
                {
                    return portValid;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("puerto no valido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("demasiado grande");
            }
            return -1;
        }

        private void ReadData()
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("%USERPROFILE%")))
            {

            } 
        }
    }

    /*
     b) (8p) Método privado ReadData: Carga de un archivo de texto denominado list.txt (te lo dará el profesor)que se encuentra en 
    %USERPROFILE% la lista de usuarios, la contraseña y el puerto secundario. El formato es el siguiente: en la primera linea separado 
    por comas los nombres de los usuarios tipo alumno. En la segunda fila la contraseña del profesor. En la tercera un dato que 
    corresponde a un posible puerto de escucha. Puedes ver como ejemplo el archivo list.txt.
    Rellenará el vector students con los datos de la primera línea y teacherPass con el dato de la segunda.
    El dato de la tercera línea se comprueba que sea un puerto válido mediante TestPort y se guarda en la segunda posición de ports. Si 
    no es válido también devuelve false (puedes dejar en este caso la segunda posición de ports a 0 o -1).
    Si no hubiera al menos 3 filas o hay algún problema con el archivos devuelve false. Si fuera todo correctamente devuelve true. 
    Nota: Si no sabes leer el archivo inicializa los campos privados con los valores predeterminados del archivo list.txt que te dan
     */
}
