using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WinAppGym.Models;
using WinAppGym.Properties;
using Class;
using WinAppGym;

namespace Clases

{
    public class ClsFuncGym
    {
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
                var user2 = (from d3 in bd.Zk_MembresiasxSocio
                            join d2 in bd.USERINFO
                            on d3.UserInfoID equals d2.USERID
                            where d3.UserInfoID == vID & d3.FechaFinal >= vDay &
                            d3.FechaInicio <= vDay & d3.EstadoAnulado == false
                            orderby d3.FechaFinal ascending
                            select d3);

                foreach (var dd in user2)
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
        public static Boolean ValidaCambioFechasMembresias(Int32 vIDSocio,Int32 vIDMemb, DateTime vFechaInicio)
        {
            using (Model1 bd = new Model1())
            {
                var user = (from d3 in bd.Zk_MembresiasxSocio
                            where d3.UserInfoID == (vIDSocio) & d3.ID!=(vIDMemb) 
                            & d3.FechaFinal > vFechaInicio.Date
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
                            where d3.UserInfoID == vID & d3.FechaFinal >= vDay &
                            d3.FechaInicio <= vDay & d3.EstadoAnulado==false
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
        public static void ActualizaSensor()
        {
            DateTime vDay =Convert.ToDateTime(DateTime.Now.Date);
            using (Model1 bd = new Model1())
            {
                var Resultado = (from d1 in bd.USERINFO
                                 join d2 in bd.Zk_MembresiasxSocio
                                 on d1.USERID equals d2.UserInfoID
                                 where (d1.acc_startdate != d2.FechaInicio || d1.acc_enddate != d2.FechaFinal)
                                        & d2.FechaInicio <= (vDay) & d2.FechaFinal >= (vDay)
                                 select new
                                 {
                                     d1.USERID,
                                     d1.acc_startdate,
                                     d1.acc_enddate
                                 });
                foreach (var busca in Resultado)
                {
                    DateTime vfecha1 = Convert.ToDateTime(busca.acc_startdate);
                    DateTime vfecha2 = Convert.ToDateTime(busca.acc_enddate);
                    Int32 vID = Convert.ToInt32(busca.USERID);
                    if (ValidaFechasSensor(1, vID, ref vfecha1, ref vfecha2))
                    {

                        using (Model1 bd1 = new Model1())
                        {
                            var Graba = (from d1 in bd1.USERINFO
                                         where d1.USERID == vID
                                         select d1
                                         ).First();
                            Graba.acc_startdate = vfecha1;
                            Graba.acc_enddate = vfecha2;
                            bd1.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
    