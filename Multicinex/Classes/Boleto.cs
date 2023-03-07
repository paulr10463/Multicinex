﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    public class Boleto
    {
        public string codigoBoleto;
        public string fila;
        public int columna;
        public string nombreSucursal;
        public string codigoSala;
        public string codigoFuncion;
        public DateTime fechaEmision;
        public TimeSpan horaEmision;

        public Boleto(string codigoBoleto, string fila, int columna, string nombreSucursal, string codigoSala, string codigoFuncion, DateTime fechaEmision, TimeSpan horaEmision)
        {
            this.codigoBoleto = codigoBoleto;
            this.fila = fila;
            this.columna = columna;
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
            this.codigoFuncion = codigoFuncion;
            this.fechaEmision = fechaEmision;
            this.horaEmision = horaEmision;
        }

        public Boleto(string codigoBoleto, string fila, int columna, string nombreSucursal, string codigoSala, string codigoFuncion, DateTime fechaEmision)
        {
            this.codigoBoleto = codigoBoleto;
            this.fila = fila;
            this.columna = columna;
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
            this.codigoFuncion = codigoFuncion;
            this.fechaEmision = fechaEmision;
            this.horaEmision = fechaEmision.TimeOfDay;
        }
        public override string ToString()
        {
            String resumen =
            "      Boleto: " + this.codigoBoleto + "\n"+
            "      Código Sala: " + this.codigoSala + "\n"+
            "      Codigo Funcion: " + this.codigoFuncion + "\n"+
            "      Fecha Emision: " + this.fechaEmision.Date.ToShortDateString() + "\n"+
            "      Hora Emision: " + this.horaEmision.ToString() + "\n";
            return "";
        }
    }
}
