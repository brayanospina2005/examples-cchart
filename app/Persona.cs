using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Persona
    {
        //atributos
        private string apellido;
        private byte edad;
        private double altura;
        private string nombre;
        private double peso;

        public Persona(string nombre, string apellido, byte edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(string apellido,string nombre, double peso, byte edad, double altura)
        {
            this.Apellido = apellido;
            this.Edad = edad;
            this.Altura = altura;
            this.nombre = nombre;
            this.Peso = peso;
          
        }
        public Persona (string nombre, double peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public byte Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        //metodos
        public bool Esmayor()
        {
            if ( edad >= 18)
                 return true;
            else
                 return false;   
        }

        public int CalcularImc()
        {
            float imc = (float)(peso / (Math.Pow(altura, 2)));
            if (imc <= 18.5)
                return 0;
            else if (imc > 18.5 && imc <= 24.9)
                return 1;
            else
                return 2;
        }

    }
}
