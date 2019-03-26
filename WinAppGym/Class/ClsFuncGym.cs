using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WinAppGym.Models;
using WinAppGym.Properties;

namespace Clases
{
    public class ClsFuncGym
    {
     public static string VGCnxSql = Settings.Default.CadenaConexion;
        public static string VGUsuarioCodigo = "sa";

        public static Boolean ActivarFechasSensor(int vTipo, Int32 vID, ref DateTime vFechaInicio, ref DateTime vFechaFinal)
        {
            DateTime vDay = DateTime.Now.Date;
            DateTime vfecha1 = vDay;
            DateTime vfecha2 = vDay;
            DateTime vfechaMax = vDay;
            Boolean vCancelado = false;

            using (Model1 bd = new Model1())
            {
                var user = (from d3 in bd.Zk_MembresiasxSocio
                            join d2 in bd.USERINFO
                            on d3.UserInfoID equals d2.USERID
                            where d3.UserInfoID == vID & d3.FechaFinal >= vDay &
                            d3.FechaInicio <= vDay & d3.EstadoAnulado == false
                            orderby d3.FechaFinal ascending
                            select d3);

                foreach (var dd in user)
                {
                    vfecha1 = Convert.ToDateTime(dd.FechaInicio);
                    vfecha2 = Convert.ToDateTime(dd.FechaFinal);
                    vfechaMax = Convert.ToDateTime(dd.fechaMaximadePago);
                    vCancelado = Convert.ToBoolean(dd.EstadoCancelacion);
                }
            }
            if (vCancelado == false)
            {
                if (vfechaMax < vDay)
                    vfecha2 = vDay;
            }
            if ((vFechaInicio != vfecha1) || (vFechaFinal != vfecha2))
            {
                vFechaInicio = vfecha1;
                vFechaFinal = vfecha2;

                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean ValidaFechasMembresias(Int32 vID, DateTime vFechaInicio)
        {
            using (Model1 bd = new Model1())
            {
                var user = (from d3 in bd.Zk_MembresiasxSocio
                            where d3.UserInfoID == (vID) & d3.FechaFinal > vFechaInicio.Date
                            & d3.EstadoAnulado == false
                            select d3);
                Boolean vNroreg = false;

                foreach (var xd in user)
                {
                    vNroreg = true;
                }
                if (vNroreg == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public static Boolean ValidaFechasSensor(int vTipo, Int32 vID, ref DateTime vFechaInicio, ref DateTime vFechaFinal)
        {
            DateTime vDay = DateTime.Now.Date;
            DateTime vfecha1 = vDay;
            DateTime vfecha2 = vDay;
            DateTime vfechaMax = vDay;
            Boolean vCancelado = false;

            using (Model1 bd = new Model1())
            {
                var user = (from d3 in bd.Zk_MembresiasxSocio
                            join d2 in bd.USERINFO
                            on d3.UserInfoID equals d2.USERID
                            where d3.UserInfoID == vID & d3.FechaFinal >= vDay &
                            d3.FechaInicio <= vDay & !Convert.ToBoolean(d3.EstadoAnulado)
                            orderby d3.FechaFinal ascending
                            select d3);

                foreach (var dd in user)
                {
                    vfecha1 = Convert.ToDateTime(dd.FechaInicio);
                    vfecha2 = Convert.ToDateTime(dd.FechaFinal);
                    vfechaMax = Convert.ToDateTime(dd.fechaMaximadePago);
                    vCancelado = Convert.ToBoolean(dd.EstadoCancelacion);
                }
            }
            if (vCancelado == false)
            {
                if (vfechaMax < vDay)
                    vfecha2 = vDay;
            }
            if ((vFechaInicio != vfecha1) || (vFechaFinal != vfecha2))
            {
                vFechaInicio = vfecha1;
                vFechaFinal = vfecha2;

                return true;
            }
            else
            {
                return false;
            }

        }
        public static DataTable ConsultarTabla(string vSQL, string vCadConex, int vCommandTimeOut = 800)
        {
            string cError = "";
            try
            {
                string strConn = "";
                strConn = vCadConex;
                SqlConnection oConn = new SqlConnection(vCadConex);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(vSQL, oConn);
                da.Fill(dt1);
                oConn.Close();
                return dt1;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return null;
            }
        }
        public static bool GrabarTabla(string vSQL, string vCadConex)
        {
            string cError = "";
            try
            {
                SqlConnection oConn = new SqlConnection(vCadConex);
                SqlCommand da = new SqlCommand(vSQL, oConn);
                oConn.Open();
                da.ExecuteNonQuery();
                oConn.Close();
                da = null;
                return true;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return false;
            }
        }
   
    }
}