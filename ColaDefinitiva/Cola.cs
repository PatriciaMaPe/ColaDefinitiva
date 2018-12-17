using System;
using System.Collections.Generic;
namespace ColaDefinitiva
{
    public class Cola<T>
    {
        public Cola()
        {
			this.elementos = new List<T>();
			
        }

		public void Add(T x){
			elementos.Add(x);
		}

		public int Longitud{
			get{
				return this.elementos.Count;
			}
		}

		public T Principio{
			get{
				return this.elementos[0];
			}
		}

		public T Final{
			get{
				return this.elementos[this.elementos.Count - 1];
			}
		}

		public bool EstaVacia{
			get{
				return this.Longitud == 0;
			}
		}

		public void Elimina(){
			this.elementos.Clear();
		}

		List<T> elementos;

    }
}
