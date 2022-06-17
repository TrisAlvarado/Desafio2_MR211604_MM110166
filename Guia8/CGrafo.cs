using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_MR211604_MM110166
{
    class CGrafo
    {
        public List<CVertice> nodos; // Lista de nodos del grafo
        CVertice Ahuachapan, SantaAna, Sonsonate, LaLibertad, Chalatenango, SanSalvador, Cuscatlan, Cabanas, LaPaz, SanVicente, Usulutan, SanMiguel, LaUnion, Morazan;
        List<CVertice> departamentos;

        public CGrafo() // Constructor
        {
            nodos = new List<CVertice>();
            departamentos = new List<CVertice>();

            Ahuachapan = new CVertice("Ahuachapán");
            Ahuachapan.Posicion = new Point(67, 172);
            Ahuachapan.Dimensiones = new Size(30, 30);

            SantaAna = new CVertice("Santa Ana");
            SantaAna.Posicion = new Point(173, 110);
            SantaAna.Dimensiones = new Size(30, 30);

            Sonsonate = new CVertice("Sonsonate");
            Sonsonate.Posicion = new Point(127, 222);
            Sonsonate.Dimensiones = new Size(30, 30);

            Chalatenango = new CVertice("Chalatenango");
            Chalatenango.Posicion = new Point(272, 79);
            Chalatenango.Dimensiones = new Size(30, 30);

            LaLibertad = new CVertice("La Libertad");
            LaLibertad.Posicion = new Point(208, 213);
            LaLibertad.Dimensiones = new Size(30, 30);
            
            SanSalvador = new CVertice("San Salvador");
            SanSalvador.Posicion = new Point(258, 192);
            SanSalvador.Dimensiones = new Size(30, 30);

            LaPaz = new CVertice("La Paz");
            LaPaz.Posicion = new Point(308, 271);
            LaPaz.Dimensiones = new Size(30, 30);

            Cuscatlan = new CVertice("Cuscatlán");
            Cuscatlan.Posicion = new Point(290, 154);
            Cuscatlan.Dimensiones = new Size(30, 30);

            Cabanas = new CVertice("Cabañas");
            Cabanas.Posicion = new Point(369, 164);
            Cabanas.Dimensiones = new Size(30, 30);

            SanVicente = new CVertice("San Vicente");
            SanVicente.Posicion = new Point(373, 236);
            SanVicente.Dimensiones = new Size(30, 30);

            Usulutan = new CVertice("Usulután");
            Usulutan.Posicion = new Point(428, 283);
            Usulutan.Dimensiones = new Size(30, 30);

            SanMiguel = new CVertice("San Miguel");
            SanMiguel.Posicion = new Point(496, 267);
            SanMiguel.Dimensiones = new Size(30, 30);

            Morazan = new CVertice("Morazán");
            Morazan.Posicion = new Point(534, 199);
            Morazan.Dimensiones = new Size(30, 30);

            LaUnion = new CVertice("La Unión");
            LaUnion.Posicion = new Point(585,263);
            LaUnion.Dimensiones = new Size(30, 30);

            departamentos.Add(Ahuachapan);
            departamentos.Add(SantaAna);
            departamentos.Add(Sonsonate);
            departamentos.Add(Chalatenango);
            departamentos.Add(LaLibertad);
            departamentos.Add(SanSalvador);
            departamentos.Add(LaPaz);
            departamentos.Add(Cuscatlan);
            departamentos.Add(Cabanas);
            departamentos.Add(Usulutan);
            departamentos.Add(SanMiguel);
            departamentos.Add(Morazan);
            departamentos.Add(LaUnion);
            departamentos.Add(SanVicente);

            nodos = departamentos;
        }

        //=====================Operaciones Básicas=================================
        //Construye un nodo a partir de su valor y lo agrega a la lista de nodos
        public CVertice AgregarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;
        }
        //Agrega un nodo a la lista de nodos del grafo
        public void AgregarVertice(CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }

        //Busca un nodo en la lista de nodos del grafo
        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }

        //Crea una arista a partir de los valores de los nodos de origen y de destino
        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;
            //Si alguno de los nodos no existe, se activa una excepción
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + " no existe dentro del grafo");
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");
            return AgregarArco(vOrigen, vnDestino);
        }

        // Crea la arista a partir de los nodos de origen y de destino
        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }
            return false;
        }
        // Método para dibujar el grafo
        public void DibujarGrafo(Graphics g)
        {
            // Dibujando los arcos
            foreach (CVertice nodo in nodos)
                nodo.DibujarArco(g);

            // Dibujando los vértices
            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g);
        }
        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
                if (nodoActual.DetectarPunto(posicionMouse)) return nodoActual;
            return null;
        }
        // Método para regresar al estado original
        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach (CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }
            DibujarGrafo(g);
        }

        public void ColoArista(string o, string d)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null && nodo.Valor == o && a.nDestino.Valor == d)
                    {
                        a.color = Color.Red;
                        a.grosor_flecha = 4;
                    }
                }
            }
        }

        public void Colorear(CVertice nodo)
        {
            nodo.Color = Color.Gray;
            nodo.FontColor = Color.Black;
        }

        //Colorea el nodo
        public string ColorearNodoTest(string valorEscogido)
        {
            CVertice nodoEscogido = this.BuscarVertice(valorEscogido);

            if (nodoEscogido != null)
            {
                nodoEscogido.Color = Color.Orange;
                return "Coloreado";
            }
            else
            {
                return "No existe";
            }

        }

        //Reestable el color del nodo
        public void ReestablecerColorNodo(string valorEscogido)
        {
            CVertice nodoEscogido = this.BuscarVertice(valorEscogido);
            nodoEscogido.Color = Color.FromArgb(26, 156, 219);
        }

        public CVertice nododistanciaminima()
        {
            int min = int.MaxValue;
            CVertice temp = null;
            foreach (CVertice origen in nodos)
            {
                if (origen.Visitado)
                {
                    foreach (CVertice destino in nodos)
                    {
                        if (!destino.Visitado)
                        {
                            foreach (CArco a in origen.ListaAdyacencia)
                            {
                                if (a.nDestino == destino && min > a.peso)
                                {
                                    min = a.peso;
                                    temp = destino;
                                }  }  } } } }
            return temp;
        }

        public int posicionNodo(string Nodo)
        {
            for (int i = 0; i < nodos.Count; i++)
            {
                if (String.Compare(nodos[i].Valor, Nodo) == 0)
                    return i;
            }
            return -1;
        }
        //Funcion para re-dibujar los arcos que llegan a un nodo
        public void DibujarEntrantes(CVertice nDestino)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null && nodo != nDestino)
                    {
                        if (a.nDestino == nDestino)
                        {
                            a.color = Color.Black;
                            a.grosor_flecha = 2;
                            break;
                        }  } } }  }

        //funcion que desmarca como visitados todos los nodos del grafo
        public void Desmarcar()
        {
            foreach (CVertice n in nodos)
            {
                n.Visitado = false;
                n.Padre = null;
                n.distancianodo = int.MaxValue;
                n.pesoasignado = false;
            }
        }
    }
}