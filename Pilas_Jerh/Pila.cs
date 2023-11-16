using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Jerh
{
    public class Pila
    {
        private int _cima;
        private int _longitudPila = 5;
        private int[] _listaPila;

        public Pila()
        {
            _cima = -1;
            _listaPila = new int[_longitudPila];
        }
        public bool PilaVacia()
        {
            return _cima == -1? true:false;
        }
        public bool PilaLlena()
        {
            if (_cima == (_longitudPila - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int LongitudPila()
        {
            return _longitudPila;
        }
        public int CantidadElemento()
        {
            return _cima + 1;
        }
        public int ElementoCima()
        {
            if (PilaVacia())
            {
                return _cima;
            }
            else
            {
                return _listaPila[_cima];
            }
        }
        public bool Push(int valor)
        {
            if (PilaLlena())
            {
                return false;
            }
            else
            {
                _cima++;
                _listaPila[_cima] = valor;
                return true;
            }
        
        }
        public int ExtraerElemento()
        {
            if (PilaVacia())
            {
                return _cima;
            }
            else
            {
                int aux = _listaPila[_cima];
                _cima--;
                return aux;
            }
        }
        public bool LimpiarPila()
        {
            if (PilaVacia())
            {
                return false;
            }
            else
            {
                //while (!PilaVacia())
                //{
                //    ExtraerElemento();
                //}
                _cima = -1;
                return true;
            }
        }

        public void ImprimirPila()
        { 
            if (!PilaVacia())
        for (int i=_cima,j=0; i>=0;i--,j++)
                Console.WriteLine($"La pila {j+1} es { _listaPila[i]}");
        else
                Console.WriteLine("la pila esta vacia");
        }

    }
}