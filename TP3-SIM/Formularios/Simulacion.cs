using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            grdMontecarlo.Rows.Clear();
            int cantOferta = int.Parse(txtOferta.Value.ToString());
            double gananciaAC = 0;
            Random random = new Random();

            for (int i=0; i < 120; i++)
            {
                double rndTipoDemanda = random.NextDouble();
                double rndCantDemanda = random.NextDouble();

                List<object> tipoDemanda = new List<object>();                
                string tipo = clasificarTipoDemanda(rndTipoDemanda);
                tipoDemanda.Add(truncarNumero(rndTipoDemanda));
                tipoDemanda.Add(tipo);

                List<object> cantDemanda = new List<object>();                
                int cant = clasificarCantDemanda(rndCantDemanda, tipo);
                cantDemanda.Add(truncarNumero(rndCantDemanda));
                cantDemanda.Add(cant);


                int sobrantes = calcularSobrantes(cantOferta, Convert.ToInt32(cantDemanda[1])); // resta cantOFerta - cantDemanda
                double[] costos = calcularCostos(cantOferta, sobrantes);                
                double[] ingresos = calcularIngresos(cantOferta, sobrantes);
                double ganancia = ingresos[2] - costos[2] ; // ingreso total - costo total
                gananciaAC += ganancia;

                grdMontecarlo.Rows.Add(i + 1, tipoDemanda[0], tipoDemanda[1], cantDemanda[0], cantDemanda[1], cantOferta, sobrantes, truncarNumero(costos[0]), truncarNumero(costos[1]), truncarNumero(costos[2]), truncarNumero(ingresos[0]), truncarNumero(ingresos[1]), truncarNumero(ingresos[2]), truncarNumero(ganancia), truncarNumero(gananciaAC)); 

            }
            
            txtResultado.Text = (gananciaAC / 120 ).ToString(); // devuelve el último valor de la gananciaAC / cant de días = ganancia promedio por día
                                                                // con la oferta seleccionada

        }

        private int calcularSobrantes(int cantOferta, int cantDemanda)
        {
            return cantOferta - cantDemanda;
        }

        private double[] calcularCostos(int cantOferta, int sobrantes)
        {
            double[] vector = new double[3];
            double costoFabricacion = 0.15 * cantOferta;
            double costoPerdida = 0;
            if (sobrantes <= 0) { costoPerdida = Math.Abs(sobrantes) * 0.1; }
            else { costoPerdida = 0; }

            double costoTotal = costoFabricacion + costoPerdida;
            vector[0] = costoFabricacion;
            vector[1] = costoPerdida;
            vector[2] = costoTotal;
            return vector;
        }


        private double[] calcularIngresos(int cantOferta, int sobrantes)
        {
            double[] vector = new double[3];
            double ingresoVenta = 0;
            if (sobrantes <= 0) { ingresoVenta = cantOferta * 0.25; }
            else { ingresoVenta = (cantOferta - sobrantes) * 0.25; }

            double ingresoRecup = 0;
            if (sobrantes > 0) { ingresoRecup = sobrantes * 0.08; }

            double ingresoTotal = ingresoVenta + ingresoRecup;
            vector[0] = ingresoVenta;
            vector[1] = ingresoRecup;
            vector[2] = ingresoTotal;
            return vector;
        }
        
        private string clasificarTipoDemanda(double rnd)
        {
            string tipoDemanda = "";

            if (rnd >= 0 && rnd < 0.35)
            {
                tipoDemanda = "Alta";
            }
            else if (rnd >= 0.35 && rnd < 0.75)
            {
                tipoDemanda = "Media";
            }
            else
            {
                tipoDemanda = "Baja";
            }

            return tipoDemanda;
        }

        private int clasificarCantDemanda(double rnd, string tipo)
        {
            int cantidad = 0;
            if (tipo == "Alta")
            {
                if (rnd >= 0 && rnd < 0.05) { cantidad = 36; }
                else if (rnd >= 0.05 && rnd < 0.15) { cantidad = 48; }
                else if (rnd >= 0.15 && rnd < 0.4) { cantidad = 60; }
                else if (rnd >= 0.4 && rnd < 0.7) { cantidad = 72; }
                else if (rnd >= 0.7 && rnd < 0.9) { cantidad = 84; }
                else { cantidad = 90; }
            }
            if (tipo == "Media")
            {
                if (rnd >= 0 && rnd < 0.1) { cantidad = 36; }
                else if (rnd >= 0.1 && rnd < 0.3) { cantidad = 48; }
                else if (rnd >= 0.3 && rnd < 0.6) { cantidad = 60; }
                else if (rnd >= 0.6 && rnd < 0.85) { cantidad = 72; }
                else if (rnd >= 0.85 && rnd < 0.95) { cantidad = 84; }
                else { cantidad = 90; }
            }
            if (tipo == "Baja")
            {
                if (rnd >= 0 && rnd < 0.15) { cantidad = 36; }
                else if (rnd >= 0.15 && rnd < 0.4) { cantidad = 48; }
                else if (rnd >= 0.4 && rnd < 0.75) { cantidad = 60; }
                else if (rnd >= 0.75 && rnd < 0.9) { cantidad = 72; }
                else if (rnd >= 0.9 && rnd < 0.95) { cantidad = 84; }
                else { cantidad = 90; }
            }

            return cantidad;
        }

        private double truncarNumero(double numero)
        {
            double factor = Math.Pow(10, 2);
            return Math.Truncate(numero * factor) / factor;
        }

    }
}
