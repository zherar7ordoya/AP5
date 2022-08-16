using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace MPP
{
    public class Reporte
    {
        public DateTime FECHA { get; private set; }
        public DateTime DESDE { get; private set; }
        public DateTime HASTA { get; private set; }
        public List<BE.ReporteListado> REPORTE_LISTADO { get; private set; }
        public List<BE.ReportePeriodo> REPORTE_PERIODO { get; private set; }
        public double IMPORTE_TOTAL { get; private set; }


        public void MapearReporte(DateTime desde, DateTime hasta)
        {
            this.FECHA = DateTime.Now;
            this.DESDE = desde;
            this.HASTA = hasta;
            var conexion = new DAL.Conexion();
            var dtabla = conexion.ConsultaParaReporte(desde, hasta);
            REPORTE_LISTADO = new List<BE.ReporteListado>();

            foreach (DataRow item in dtabla.Rows)
            {
                var entidad = new BE.ReporteListado()
                {
                    Id = Convert.ToInt32(item[0]),
                    Fecha = Convert.ToDateTime(item[1]),
                    Empleado = Convert.ToString(item[2]),
                    Producto = Convert.ToString(item[3]),
                    Total = Convert.ToDouble(item[4])
                };
                REPORTE_LISTADO.Add(entidad);
                IMPORTE_TOTAL += Convert.ToDouble(item[4]);
            }

            var datos = (from venta in REPORTE_LISTADO
                         group venta by venta.Fecha
                                    into ventas
                         select new
                         {
                             fecha = ventas.Key,
                             monto = ventas.Sum(item => item.Total)
                         }).AsEnumerable();

            int dias = Convert.ToInt32((hasta - desde).Days);

            if (dias <= 7)
            {
                REPORTE_PERIODO = (from venta in datos
                                   group venta by venta.fecha.ToString("dd-MM-yy")
                                            into ventas
                                   select new BE.ReportePeriodo
                                   {
                                       Periodo = ventas.Key,
                                       Pedidos = ventas.Sum(item => item.monto)
                                   }).ToList();
            }
            else if (dias <= 30)
            {
                REPORTE_PERIODO = (from venta in datos
                                   group venta by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(venta.fecha, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into ventas
                                   select new BE.ReportePeriodo
                                   {
                                       Periodo = "Semana " + ventas.Key.ToString(),
                                       Pedidos = ventas.Sum(item => item.monto)
                                   }).ToList();
            }
            else if (dias <= 365)
            {
                REPORTE_PERIODO = (from venta in datos
                                   group venta by venta.fecha.ToString("MM-yyyy")
                                            into ventas
                                   select new BE.ReportePeriodo
                                   {
                                       Periodo = ventas.Key,
                                       Pedidos = ventas.Sum(item => item.monto)
                                   }).ToList();
            }
            else
            {
                REPORTE_PERIODO = (from venta in datos
                                   group venta by venta.fecha.ToString("yyyy")
                                            into ventas
                                   select new BE.ReportePeriodo
                                   {
                                       Periodo = ventas.Key,
                                       Pedidos = ventas.Sum(item => item.monto)
                                   }).ToList();
            }
        }
    }
}
